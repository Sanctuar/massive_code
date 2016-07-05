using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlServerCe;

namespace massive_code
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        cl_sql g_SQL = new cl_sql();
        cl_GlobalVariables g_GV = new cl_GlobalVariables();
        cl_Cryptography g_CR = new cl_Cryptography();
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton_UserName.Visible = false;
            ImageButton_userexit.Visible = false;
            Button_Download_UnionServer.Attributes.Add("onmouseover", "this.className='button_mouse_over1'");
            Button_Download_UnionServer.Attributes.Add("onmouseout", "this.className='button_mouse_out1'");
            Button_Download_UnionClient.Attributes.Add("onmouseover", "this.className='button_mouse_over1'");
            Button_Download_UnionClient.Attributes.Add("onmouseout", "this.className='button_mouse_out1'");
            prv_Check_RegistrBase();
            prv_Check_UserSignIn();
        }

        private void prv_Check_RegistrBase()
        {
            if (File.Exists(g_GV.gs_RegistrBasePath()) == false)
            {
                g_SQL.pv_Create_RegistrBase(g_GV.gs_RegistrBasePath());
                cl_GlobalVariables.pcl_user_regist lcl_ur = new cl_GlobalVariables.pcl_user_regist();
                lcl_ur.Login="null_Admin";
                lcl_ur.Date = DateTime.Now.ToShortDateString();
                lcl_ur.Attribute= "null";
                lcl_ur.Mail="support@massivecode.ru";
                lcl_ur.Permission="administrator";
                lcl_ur.Name = "Артур";
                lcl_ur.Surname = "Хусаинов";
                lcl_ur.Password = g_CR.ps_MD5("nUll_admIn#10");
                lcl_ur.UID = g_CR.ps_MD5("null_Admin");
                g_SQL.pv_Add_RegistrBase(lcl_ur, g_GV.gs_RegistrBasePath());
            }
        }

        private void prv_Check_UserSignIn()
        {
            cl_GlobalVariables.pcl_UserData lcl_UD = new cl_GlobalVariables.pcl_UserData();
            Object lo_UserData = Session["user_data"];
            if ( lo_UserData!= null)
            {
                lcl_UD = (cl_GlobalVariables.pcl_UserData)lo_UserData;
                LinkButton_UserName.Text = "Добро пожаловать: " + lcl_UD.Login.ToString();
                LinkButton_UserName.Visible = true;
                ImageButton_userexit.Visible = true;
                Button_Registr.Visible = false;
                Button_SignIn.Visible = false;
            }
        }

        protected void ImageButton_userexit_Click(object sender, ImageClickEventArgs e)
        {
            Session["user_data"] = null;
            Session["panel_user_data"] = null;
            Response.Redirect("default.aspx");
        }
    }
}