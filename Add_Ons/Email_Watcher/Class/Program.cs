using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Timers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Timer = System.Timers.Timer;
using Thread = System.Threading.Thread;
using Data_Access_Layer.Repository;
using System.Dynamic;

namespace Email_Watcher
{
    public class Program
    {
        #region  Business Logic and Data Access Layer Referance
            Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();
        #endregion

        static string[] Scopes = { GmailService.Scope.MailGoogleCom, GmailService.Scope.GmailModify };
        static string ApplicationName = "Gmail API .NET Quickstart";
        public static string token;

        public static void Main(string[] args)
        {
            Console.Title = "Email_Watcher";
            Console.WriteLine("Email Watched Trigered @ " + DateTime.Now);
            ConnectToGmail();
        }

        public string returnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }

        public static void ConnectToGmail()
        {
            UserCredential credential;
            using (var stream =
                new FileStream(@"Credential\Client_Secret_VIKI.json", FileMode.Open, FileAccess.Read))
            //O:\GIT\Virtual-Interface-Key-Intelligence\Email_Watcher\Credential\Client_Secret_VIKI.json
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "admin",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            Console.WriteLine("Gmail Connected @ " + DateTime.Now);
            CallMethod(service);
        }

        public static void CallMethod(GmailService service)
        {
            Console.WriteLine("Checking For New Message @ " + DateTime.Now);
            ListMessages(service, "me", "is:SMS UNREAD");
            Console.WriteLine("Checking Completed @ " + DateTime.Now);
            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        #region GMAIL API
        // ...
        /// <summary>
        /// List all Messages of the user's mailbox matching the query.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        /// <param name="query">String used to filter Messages returned.</param>
        public static List<Message> ListMessages(GmailService service, String userId, String query)
        {
            List<Message> result = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(userId);
            request.Q = query;

            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    result.AddRange(response.Messages);
                    request.PageToken = response.NextPageToken;

                }
                catch (Exception e)
                {
                    if (e.Message.ToString() == "Value cannot be null.\r\nParameter name: collection")
                    {
                        Console.WriteLine("No SMS Received");
                    }
                    else
                    {
                        Console.WriteLine("An error occurred: " + e.Message);
                    }
                }
            } while (!String.IsNullOrEmpty(request.PageToken));
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item.Id);
                    GetMessage(service, "me", item.Id.ToString());

                    List<String> labelsToAdd = new List<String>();
                    labelsToAdd.Add("Label_1231102223600634216");
                    List<String> labelsToRemove = new List<String>();
                    labelsToRemove.Add("Label_275355708915253079");
                    labelsToRemove.Add("UNREAD");
                    ModifyMessage(service, "me", item.Id.ToString(), labelsToAdd, labelsToRemove);
                }
            }
            return result;
        }
        // ...

        // ...
        /// <summary>
        /// Retrieve a Message by ID.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        /// <param name="messageId">ID of Message to retrieve.</param>
        public static Message GetMessage(GmailService service, String userId, String messageId)
        {
            try
            {
                //return service.Users.Messages.Get(userId, messageId).Execute();
                var request = service.Users.Messages.Get(userId, messageId);
                request.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Full;
                var response = request.Execute();

                if (response != null)
                {
                    String from = "";
                    String date = "";
                    String subject = "";
                    String body = "";
                    //loop through the headers and get the fields we need...
                    foreach (var mParts in response.Payload.Headers)
                    {
                        if (mParts.Name == "Date")
                        {
                            date = mParts.Value;
                        }
                        else if (mParts.Name == "From")
                        {
                            from = mParts.Value;
                        }
                        else if (mParts.Name == "Subject")
                        {
                            subject = mParts.Value;
                        }

                        if (date != "" && from != "")
                        {
                            if (response.Payload.Parts == null && response.Payload.Body != null)
                                body = DecodeBase64String(response.Payload.Body.Data);
                            else
                                body = GetNestedBodyParts(response.Payload.Parts, "");
                        }

                    }

                    string source = body;
                    string[] stringSeparators = new string[] { "---" };
                    var result = source.Split(stringSeparators, StringSplitOptions.None);
                    string.Format("{0:s}", date);

                    {
                        dynamic dyn_Data = new ExpandoObject();
                        dyn_Data.MsgID = messageId;
                        dyn_Data.SMSType = "In";
                        dyn_Data.RcvdDate = date;
                        dyn_Data.RcvdFrom = from;
                        dyn_Data.Subject = subject;
                        dyn_Data.Body = result[0];
                        Repository_DataMapper.AddNewSMS(dyn_Data);
                    }

                    Console.Write(Environment.NewLine + "-------------------" + Environment.NewLine);
                    Console.Write(from + Environment.NewLine);
                    Console.Write(subject + Environment.NewLine);
                    Console.Write(date + Environment.NewLine);
                    Console.Write(body + Environment.NewLine);
                    Console.Write(Environment.NewLine + "-------------------" + Environment.NewLine);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return null;
        }
        // ...

        // ...
        /// <summary>
        /// Modify the Labels a Message is associated with.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        /// <param name="messageId">ID of Message to modify.</param>
        /// <param name="labelsToAdd">List of label ids to add.</param>
        /// <param name="labelsToRemove">List of label ids to remove.</param>
        public static Message ModifyMessage(GmailService service, String userId, String messageId, List<String> labelsToAdd, List<String> labelsToRemove)
        {
            ModifyMessageRequest mods = new ModifyMessageRequest();
            mods.AddLabelIds = labelsToAdd;
            mods.RemoveLabelIds = labelsToRemove;

            try
            {
                return service.Users.Messages.Modify(mods, userId, messageId).Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return null;
        }
        // ...

        // ...
        static String DecodeBase64String(string s)
        {
            var ts = s.Replace("-", "+");
            ts = ts.Replace("_", "/");
            var bc = Convert.FromBase64String(ts);
            var tts = Encoding.UTF8.GetString(bc);

            return tts;
        }
        // ...

        // ...
        static String GetNestedBodyParts(IList<MessagePart> part, string curr)
        {
            string str = curr;
            if (part == null)
            {
                return str;
            }
            else
            {
                foreach (var parts in part)
                {
                    if (parts.Parts == null)
                    {
                        if (parts.Body != null && parts.Body.Data != null)
                        {
                            var ts = DecodeBase64String(parts.Body.Data);
                            str += ts;
                        }
                    }
                    else
                    {
                        return GetNestedBodyParts(parts.Parts, str);
                    }
                }

                return str;
            }

        }
        // ...
        #endregion

    }
}
