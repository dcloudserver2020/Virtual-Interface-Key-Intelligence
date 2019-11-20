using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Repository;

namespace Data_Access_Layer.Repository
{
    public class Repository_DataMapper
    {
        #region  Business Logic and Data Access Layer Referance

        Repository_SqlHandler Repository_SqlHandler = new Repository_SqlHandler();

        #endregion

        #region  Method

        #region  SMS

        public static void AddNewSMS(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Insert";
            Repository_Class.Repository.SQLQuery = "INSERT INTO SMSMaster (MsgID,SMSType,RcvdDate,RcvdFrom,Subject,Body,Isactive) VALUES ('" + dyn_Data.MsgID + "','" + dyn_Data.SMSType + "','" + dyn_Data.RcvdDate + "','" + dyn_Data.RcvdFrom + "','" + dyn_Data.Subject + "','" + dyn_Data.Body + "', 1)";
            Repository_SqlHandler.SQL_Handler();
        }

        #endregion

        #endregion
    }
}
