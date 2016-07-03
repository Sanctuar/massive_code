using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlServerCe;
using System.Data;

namespace massive_code
{
    public class cl_sql
    {
        SqlCeEngine sql_SQL_Engine;
        SqlCeConnection sql_SQL_Connection;
        SqlCeCommand sql_SQL_Command;
        cl_GlobalVariables g_GV = new cl_GlobalVariables();

        public void pv_Create_RegistrBase(String ls_BasePath)
        {
            sql_SQL_Engine = new SqlCeEngine("Data Source='" + ls_BasePath + "';");
            sql_SQL_Engine.CreateDatabase();
            sql_SQL_Connection = new SqlCeConnection(sql_SQL_Engine.LocalConnectionString);
            sql_SQL_Connection.Open();
            sql_SQL_Command = sql_SQL_Connection.CreateCommand();
            sql_SQL_Command.CommandText =
                     "CREATE TABLE Registration(N int IDENTITY(1,1)," +
                                          "Login nvarchar(50)," +
                                          "Password nvarchar(50)," +
                                          "UID nvarchar(50)," +
                                          "Date nvarchar(50)," +
                                          "Name nvarchar(50)," +
                                          "Surname nvarchar(50)," +
                                          "Mail nvarchar(50)," +
                                          "Permission nvarchar(50)," +
                                          "Attribute nvarchar(50))";
            sql_SQL_Command.ExecuteNonQuery();
            sql_SQL_Connection.Close();
        }

        public void pv_Add_RegistrBase(cl_GlobalVariables.pcl_user_regist lcl_ur, String ls_BasePath)
        {

            sql_SQL_Engine = new SqlCeEngine("Data Source='" + ls_BasePath + "';");
            sql_SQL_Connection = new SqlCeConnection(sql_SQL_Engine.LocalConnectionString);
            sql_SQL_Connection.Open();
            sql_SQL_Command = sql_SQL_Connection.CreateCommand();
            sql_SQL_Command.CommandText = "INSERT INTO Registration(Login, Password, UID, Name, Surname, Date, Mail, Permission, Attribute) VALUES(?,?,?,?,?,?,?,?,?)";
            sql_SQL_Command.Parameters.AddWithValue("Login", lcl_ur.Login);
            sql_SQL_Command.Parameters.AddWithValue("Password", lcl_ur.Password);
            sql_SQL_Command.Parameters.AddWithValue("UID", lcl_ur.UID);
            sql_SQL_Command.Parameters.AddWithValue("Name", lcl_ur.Name);
            sql_SQL_Command.Parameters.AddWithValue("Surname", lcl_ur.Surname);
            sql_SQL_Command.Parameters.AddWithValue("RegistDate", lcl_ur.Date);
            sql_SQL_Command.Parameters.AddWithValue("Mail", lcl_ur.Mail);
            sql_SQL_Command.Parameters.AddWithValue("Permission", lcl_ur.Permission);
            sql_SQL_Command.Parameters.AddWithValue("Attribute", lcl_ur.Attribute);
            sql_SQL_Command.ExecuteScalar();
            sql_SQL_Connection.Close();
        }

        public DataTable pdt_Find_RegistrBase(String ls_Param, String ls_Data, String ls_BasePath)
        {
            sql_SQL_Engine = new SqlCeEngine("Data Source='" + ls_BasePath + "';");
            sql_SQL_Connection = new SqlCeConnection(sql_SQL_Engine.LocalConnectionString);
            sql_SQL_Connection.Open();
            sql_SQL_Command = sql_SQL_Connection.CreateCommand();
            sql_SQL_Command.CommandText = "SELECT * FROM Registration WHERE "+ls_Param+" = '" + ls_Data + "'";
            SqlCeDataReader n_SQL_DataReader = sql_SQL_Command.ExecuteReader();
            DataTable n_dt = new DataTable();
            n_dt.Load(n_SQL_DataReader);
            sql_SQL_Connection.Close();
            return n_dt;
        }

        public DataTable pdt_Autorization(String ls_Login, String ls_Password, String ls_BasePath)
        {
            sql_SQL_Engine = new SqlCeEngine("Data Source='" + ls_BasePath + "';");
            sql_SQL_Connection = new SqlCeConnection(sql_SQL_Engine.LocalConnectionString);
            sql_SQL_Connection.Open();
            sql_SQL_Command = sql_SQL_Connection.CreateCommand();
            sql_SQL_Command.CommandText = "SELECT * FROM Registration WHERE Login='" + ls_Login + "' AND Password='" + ls_Password + "' AND Attribute != 'blocked'";
            SqlCeDataReader n_SQL_DataReader = sql_SQL_Command.ExecuteReader();
            DataTable n_dt = new DataTable();
            n_dt.Load(n_SQL_DataReader);
            sql_SQL_Connection.Close();
            return n_dt;
        }

        public void pv_Update_RegistrBase(String ls_UpdateParam, String ls_UpdateData, String ls_WhereParam, String ls_WhereData, String ls_BasePath)
        {
            sql_SQL_Engine = new SqlCeEngine("Data Source='" + ls_BasePath + "';");
            sql_SQL_Connection = new SqlCeConnection(sql_SQL_Engine.LocalConnectionString);
            sql_SQL_Connection.Open();
            sql_SQL_Command = sql_SQL_Connection.CreateCommand();
            sql_SQL_Command.CommandText = "UPDATE Registration SET " + ls_UpdateParam + "='"+ls_UpdateData+"+'WHERE " + ls_WhereParam + " = '" + ls_WhereData + "'";
            sql_SQL_Command.ExecuteScalar();
            sql_SQL_Connection.Close();
        }
    }
}