using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace massive_code
{
    public partial class panel : System.Web.UI.Page
    {
        cl_GlobalVariables g_GV = new cl_GlobalVariables();
        cl_sql g_SQL = new cl_sql();
        protected void Page_Load(object sender, EventArgs e)
        {
            cl_GlobalVariables.pcl_UserData lcl_UD = new cl_GlobalVariables.pcl_UserData();
            Object lo_user_data = Session["user_data"];
            if (lo_user_data == null)
            {
                Label_error.Text = "Ошибка x0.05: неверное значение!";
            }
            else
            {
                lcl_UD = (cl_GlobalVariables.pcl_UserData)lo_user_data;
                if (Session["panel_user_data"] == null)
                {
                    prv_ReadUserData(lcl_UD.UID);
                }
                else
                {
                    DataRow ldr_temp = (DataRow)Session["panel_user_data"];
                    if (ldr_temp["Login"].ToString() != lcl_UD.Login)
                    {
                        prv_ReadUserData(lcl_UD.UID);
                    }
                }
                DataRow ldr_row = (DataRow)Session["panel_user_data"];
                Panel_info.Visible = true;
                Label_Name.Text = "Имя: " + ldr_row["Name"].ToString();
                Label_Surname.Text = "Фамилия: " + ldr_row["Surname"].ToString();
                Label_Login.Text = "Логин: " + ldr_row["Login"].ToString();
                Label_RegistrDate.Text = "Дата регистрации: " + ldr_row["Date"].ToString();
                Label_Mail.Text = "Адрес электронной почты: " + ldr_row["Mail"].ToString();
                Label_Permission.Text = "Права доступа: " + ldr_row["Permission"].ToString();

                if (ldr_row["Permission"].ToString() == "administrator")
                {
                    LinkButton_ShowRegistrBase.Visible = true;
                }
            }
        }

        private void prv_ReadUserData(String ls_UID)
        {
            DataTable ldt = g_SQL.pdt_Find_RegistrBase("UID", ls_UID, g_GV.gs_RegistrBasePath());
            Session["panel_user_data"] = ldt.Rows[0];
        }

        protected void LinkButton_ShowRegistrBase_Click(object sender, EventArgs e)
        {
            DataTable ldt = g_SQL.pdt_Read_RegistrBase(g_GV.gs_RegistrBasePath());
            ldt.Columns.Remove("Password");
            ldt.Columns.Remove("UID");
            GridView1.DataSource = ldt;
            GridView1.DataBind();
            GridView1.Visible = true;
        }
    }
}