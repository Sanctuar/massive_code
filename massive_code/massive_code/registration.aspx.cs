using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;

namespace massive_code
{
    public partial class registration : System.Web.UI.Page
    {
        cl_sql g_SQL = new cl_sql();
        cl_GlobalVariables g_GV = new cl_GlobalVariables();
        cl_Cryptography g_CR = new cl_Cryptography();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butt_regist_Click(object sender, EventArgs e)
        {
            if (prb_CheckRegistrData() == true)
            {
                cl_GlobalVariables.pcl_user_regist lcl_ur = new cl_GlobalVariables.pcl_user_regist();
                lcl_ur.Name = TextBox_name.Text;
                lcl_ur.Surname = TextBox_surname.Text;
                lcl_ur.Login = TextBox_login.Text;
                lcl_ur.Mail = TextBox_mail.Text;
                lcl_ur.Attribute = "null";
                lcl_ur.Permission = "user";
                lcl_ur.UID = g_CR.ps_MD5(TextBox_login.Text);
                lcl_ur.Password = g_CR.ps_MD5(TextBox_pass.Text);
                lcl_ur.Date = DateTime.Now.ToShortDateString();
                DataTable ldt_Login = g_SQL.pdt_Find_RegistrBase("Login", lcl_ur.Login, g_GV.gs_RegistrBasePath());
                DataTable ldt_Mail = g_SQL.pdt_Find_RegistrBase("Mail", lcl_ur.Mail, g_GV.gs_RegistrBasePath());
                if (ldt_Login.Rows.Count ==0 &ldt_Mail.Rows.Count==0)
                {
                    g_SQL.pv_Add_RegistrBase(lcl_ur, g_GV.gs_RegistrBasePath());
                    cl_GlobalVariables.pcl_UserData lcl_UD = new cl_GlobalVariables.pcl_UserData();
                    lcl_UD.Login = lcl_ur.Login;
                    lcl_UD.UID = lcl_ur.UID;
                    Session.Add("user_data", (object)lcl_UD);
                    Response.Redirect("default.aspx");
                }
                else
                {
                    Label_Registr_Error.Text = "указан существующий логин и/или адрес электронной почты!";
                }
            }
            else { Label_Registr_Error.Text = "неверно заполнены регистрационые данные!"; }
        }


        private Boolean prb_CheckRegistrData()
        {
            Boolean lb_Correct = true;
            if (String.IsNullOrWhiteSpace(TextBox_name.Text) == true || String.IsNullOrEmpty(TextBox_name.Text)== true)
            {
                TextBox_name.BackColor = Color.Coral; lb_Correct = false;
            }
            if (String.IsNullOrWhiteSpace(TextBox_surname.Text) == true || String.IsNullOrEmpty(TextBox_surname.Text) == true)
            {
                TextBox_surname.BackColor = Color.Coral; lb_Correct = false;
            }
            if (String.IsNullOrWhiteSpace(TextBox_mail.Text) == true || String.IsNullOrEmpty(TextBox_mail.Text) == true)
            {
                TextBox_mail.BackColor = Color.Coral; lb_Correct = false;
            }
            if (String.IsNullOrWhiteSpace(TextBox_login.Text) == true || String.IsNullOrEmpty(TextBox_login.Text) == true)
            {
                TextBox_login.BackColor = Color.Coral; lb_Correct = false;
            }
            if (String.IsNullOrWhiteSpace(TextBox_pass.Text) == true || String.IsNullOrEmpty(TextBox_pass.Text) == true)
            {
                TextBox_pass.BackColor = Color.Coral; lb_Correct = false;
            }
            if (String.IsNullOrWhiteSpace(TextBox_repass.Text) == true || String.IsNullOrEmpty(TextBox_repass.Text) == true)
            {
                TextBox_repass.BackColor = Color.Coral; lb_Correct = false;
            }
            if (TextBox_pass.Text!=TextBox_repass.Text)
            {
                TextBox_repass.BackColor = Color.Coral; lb_Correct = false;
            }
            return lb_Correct;
        }

        protected void TextBox_name_TextChanged(object sender, EventArgs e)
        {
            TextBox_name.BackColor = Color.White;
            Label_Registr_Error.Text = "";
        }

        protected void TextBox_surname_TextChanged(object sender, EventArgs e)
        {
            TextBox_surname.BackColor = Color.White;
            Label_Registr_Error.Text = "";
        }

        protected void TextBox_login_TextChanged(object sender, EventArgs e)
        {
            TextBox_login.BackColor = Color.White;
            Label_Registr_Error.Text = "";
        }

        protected void TextBox_mail_TextChanged(object sender, EventArgs e)
        {
            TextBox_mail.BackColor = Color.White;
            Label_Registr_Error.Text = "";
        }

        protected void TextBox_pass_TextChanged(object sender, EventArgs e)
        {
            TextBox_pass.BackColor = Color.White;
            Label_Registr_Error.Text = "";
        }

        protected void TextBox_repass_TextChanged(object sender, EventArgs e)
        {
            TextBox_repass.BackColor = Color.White;
            Label_Registr_Error.Text = "";
        }

        protected void butt_SignIn_Click(object sender, EventArgs e)
        {
            String ls_Login = TextBox_SignIn_Login.Text;
            String ls_Pass = TextBox_SignIn_Pass.Text;
            List<TextBox> list_Box = new List<TextBox>();
            list_Box.Add(TextBox_SignIn_Login);
            list_Box.Add(TextBox_SignIn_Pass);
            Boolean lb_Check = true;
            foreach (TextBox ltb_Box in list_Box)
            {
                if (prb_Check_TextBox_EmptyOrSpace(ltb_Box) == false)
                { lb_Check = false; }
            }
            if (lb_Check == true)
            {
                DataTable ldt = g_SQL.pdt_Autorization(ls_Login, g_CR.ps_MD5(ls_Pass), g_GV.gs_RegistrBasePath());
                if (ldt.Rows.Count > 0)
                {
                    cl_GlobalVariables.pcl_UserData lcl_UD = new cl_GlobalVariables.pcl_UserData();
                    lcl_UD.Login = ls_Login;
                    lcl_UD.UID = g_CR.ps_MD5(ls_Login);
                    Session.Add("user_data", (object)lcl_UD);
                    Response.Redirect("default.aspx");
                }

                if (ldt.Rows.Count == 0)
                {
                    Label_SignIn_Error.Text = "неверно указаны логин и/или пароль!";
                }
            }
        }

        private Boolean prb_Check_TextBox_EmptyOrSpace(TextBox ltb_Box)
        {
            if (String.IsNullOrEmpty(ltb_Box.Text) == true || String.IsNullOrWhiteSpace(ltb_Box.Text) == true)
            {
                ltb_Box.BackColor = Color.Coral;
                return false;
            }
            return true;
        }

        protected void TextBox_SignIn_Login_TextChanged(object sender, EventArgs e)
        {
            TextBox_SignIn_Login.BackColor = Color.White;
            Label_SignIn_Error.Text = "";
        }

        protected void TextBox_SignIn_Pass_TextChanged(object sender, EventArgs e)
        {
            TextBox_SignIn_Pass.BackColor = Color.White;
            Label_SignIn_Error.Text = "";
        }
    }
}