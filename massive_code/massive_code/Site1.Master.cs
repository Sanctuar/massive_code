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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Button_Download_UnionServer.Attributes.Add("onmouseover", "this.className='button_mouse_over1'");
            Button_Download_UnionServer.Attributes.Add("onmouseout", "this.className='button_mouse_out1'");
            Button_Download_UnionClient.Attributes.Add("onmouseover", "this.className='button_mouse_over1'");
            Button_Download_UnionClient.Attributes.Add("onmouseout", "this.className='button_mouse_out1'");
            prv_CheckRegistrBase();
        }

        private void prv_CheckRegistrBase()
        {
            if (File.Exists(g_GV.gs_RegistrBasePath()) == false)
            {
                g_SQL.pv_Create_RegistrBase(g_GV.gs_RegistrBasePath());
            }
        }

    }
}