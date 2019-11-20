using Data_Access_Layer.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using Data_Access_Layer.Repository;

namespace Data_Access_Layer.Repository
{
    public class Repository_SqlHandler
    {
        #region  Method

        public static DataSet SQL_Handler()
        {
            ResourceManager RES_MNG = new ResourceManager(typeof(Resources));
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                Repository_Class.Repository.SqlConnectionPath = RES_MNG.GetString("SQLConnection");
                SqlConnection SQLconnection = new SqlConnection(Repository_Class.Repository.SqlConnectionPath);
                if (Repository_Class.Repository.SQLCommand == "Insert")
                {
                    Repository_Class.Repository.Command = new SqlCommand(Repository_Class.Repository.SQLQuery + " SELECT SCOPE_IDENTITY()", SQLconnection);
                }
                else
                {
                    Repository_Class.Repository.Command = new SqlCommand(Repository_Class.Repository.SQLQuery, SQLconnection);
                }
                SQLconnection.Open();

                if (Repository_Class.Repository.SQLMethod == "Read")
                {
                    SqlDataReader dr = Repository_Class.Repository.Command.ExecuteReader();
                    dt.Load(dr);
                    ds.Clear();
                    ds.Tables.Add(dt);
                }
                else if (Repository_Class.Repository.SQLMethod == "Modify")
                {
                    if (Repository_Class.Repository.SQLCommand == "Select")
                    {
                        da.SelectCommand = Repository_Class.Repository.Command;
                        ds.Clear();
                        da.Fill(ds);
                    }
                    else if (Repository_Class.Repository.SQLCommand == "Delete")
                    {
                        Repository_Class.Repository.Command.ExecuteNonQuery();
                    }
                    else if (Repository_Class.Repository.SQLCommand == "Update")
                    {
                        Repository_Class.Repository.Command.ExecuteNonQuery();
                    }
                    else if (Repository_Class.Repository.SQLCommand == "Insert")
                    {
                        Repository_Class.Repository.id = Convert.ToInt32((Repository_Class.Repository.Command.ExecuteScalar()).ToString());
                    }
                }
                else if (Repository_Class.Repository.SQLMethod == "Single")
                {
                    Repository_Class.Repository.dv = (Repository_Class.Repository.Command.ExecuteScalar()).ToString();
                }
                else if (Repository_Class.Repository.SQLMethod == "SP")
                {
                    if (Repository_Class.Repository.SQLCommand == "Select")
                    {
                        Repository_Class.Repository.Command.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = Repository_Class.Repository.Command;
                        ds.Clear();
                        da.Fill(ds);
                        return ds;
                    }
                    else
                    {
                        Repository_Class.Repository.Command.CommandType = CommandType.StoredProcedure;
                        Repository_Class.Repository.Command.ExecuteNonQuery();
                    }
                }
                SQLconnection.Close();
                Repository_Class.Repository.SQLMethod = null;
                Repository_Class.Repository.SQLCommand = null;
                Repository_Class.Repository.SQLQuery = null;
                return ds;
            }
            catch (Exception)
            {
                return ds;
            }
        }

        #endregion
    }
}
