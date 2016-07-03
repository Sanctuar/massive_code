using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace massive_code
{
    public partial class information : System.Web.UI.Page
    {
        cl_sql g_SQL = new cl_sql();
        cl_GlobalVariables g_GV = new cl_GlobalVariables();
        protected void Page_Load(object sender, EventArgs e)
        {
            Boolean lb_Redirect = true;
            String ls_Query = Request.QueryString["mail_confirm"];
            if (ls_Query != null)
            {
                lb_Redirect = false;
                DataTable ldt = g_SQL.pdt_Find_RegistrBase("UID", ls_Query, g_GV.gs_RegistrBasePath());
                if (ldt.Rows.Count > 0)
                {
                    if (ldt.Rows[0]["Attribute"].ToString() == "mail_confirm")
                    {
                        g_SQL.pv_Update_RegistrBase("Attribute", "ready", "UID", ls_Query, g_GV.gs_RegistrBasePath());
                        Label_Info.Text = "Регистрационные данные успешно подтверждены!";
                    }
                    else 
                    {
                        Label_Info.Text = "Ошибка x0.04: неверное значение!";
                    }
                }
                if (ldt.Rows.Count == 0)
                {
                    Label_Info.Text = "Ошибка x0.03: неверное значение!";
                }
            }

            Object lo_Data = Session["information"];
            if (lo_Data != null)
            {
                lb_Redirect = false;
                switch (lo_Data.ToString())
                {
                    case "mail_confirm": Label_Info.Text = "Для подтверждения регистрационных данных необходимо перейти по ссылке отправленной на вашу почту."; break;
                }
                Session["information"] = null;
            }
            else
            {
                if (lb_Redirect == true)
                {
                    Response.Redirect("default.aspx");
                }
            }

         
        }
    }
}