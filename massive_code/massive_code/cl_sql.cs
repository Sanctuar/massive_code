using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlServerCe;

namespace massive_code
{
    public class cl_sql
    {
        SqlCeEngine sql_SQL_Engine;
        SqlCeConnection sql_SQL_Connection;
        SqlCeCommand sql_SQL_Command;
        public class pcl_user_regist
        {
            public String Name;
            public String Surname;
            public String Login;
            public String Mail;
            public String Password;
        }

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
                                          "Attribute nvarchar(50))";
            sql_SQL_Command.ExecuteNonQuery();
            sql_SQL_Connection.Close();
        }

        public void pv_Add_RegistrBase(pcl_user_regist lcl_ur, String ls_BasePath)
        {

            sql_SQL_Engine = new SqlCeEngine("Data Source='" + ls_BasePath + "';");
            sql_SQL_Connection = new SqlCeConnection(sql_SQL_Engine.LocalConnectionString);
            sql_SQL_Connection.Open();
            sql_SQL_Command = sql_SQL_Connection.CreateCommand();
            sql_SQL_Command.CommandText = "INSERT INTO Registration(Login, Password, UID, Name, Surname, Date, Mail, Attribute) VALUES(?,?,?,?,?,?,?,?)";
            sql_SQL_Command.Parameters.AddWithValue("Login", lcl_ur.Login);
            sql_SQL_Command.Parameters.AddWithValue("Password", lcl_ur.Password);
            sql_SQL_Command.Parameters.AddWithValue("UID", "null");
            sql_SQL_Command.Parameters.AddWithValue("Name", lcl_ur.Name);
            sql_SQL_Command.Parameters.AddWithValue("Surname", lcl_ur.Surname);
            sql_SQL_Command.Parameters.AddWithValue("RegistDate", "null");
            sql_SQL_Command.Parameters.AddWithValue("Mail", lcl_ur.Mail);
            sql_SQL_Command.Parameters.AddWithValue("Attribute", "null");
            sql_SQL_Command.ExecuteScalar();
            sql_SQL_Connection.Close();
        }
    }
}