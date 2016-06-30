using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace massive_code
{
    public partial class registration : System.Web.UI.Page
    {
        cl_sql g_SQL = new cl_sql();
        cl_GlobalVariables g_GV = new cl_GlobalVariables();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butt_regist_Click(object sender, EventArgs e)
        {
            if (prb_CheckRegistrData() == true)
            {
                cl_sql.pcl_user_regist lcl_ur = new cl_sql.pcl_user_regist();
                lcl_ur.Name = TextBox_name.Text;
                lcl_ur.Surname = TextBox_surname.Text;
                lcl_ur.Login = TextBox_login.Text;
                lcl_ur.Mail = TextBox_mail.Text;
                lcl_ur.Password = TextBox_pass.Text;
                g_SQL.pv_Add_RegistrBase(lcl_ur, g_GV.gs_RegistrBasePath());
            }
            else { Label_Registr_Error.Text = "Неверно заполнены поля"; }
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
    }
}