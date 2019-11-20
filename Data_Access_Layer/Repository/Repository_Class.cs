using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public class Repository_Class
    {
        public static class localStorage
        {
            public static string HostName;
            public static string IP;
            public static string MachineIdentity;
            public static string UserName;
            public static string CMapID;
        }

        public static class Repository
        {
            public static SqlCommand Command;
            public static DataSet ds;
            public static DataTable dt;
            public static string SqlConnectionPath;
            public static string dv;
            public static int id = 0;
            public static string SQLMethod; // --- (Read,Modify,Single,SP)
            public static string SQLCommand; // --- {Modify = (Select,Delete,Update,Insert)} & {SP = (Select)}
            public static string SQLQuery;
        }
    }
}
