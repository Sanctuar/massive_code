using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wa_MASSIVE_CODE
{
    public partial class wf_UnionServerDownload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button_Download_UnionServer.Attributes.Add("onmouseover", "this.className='button_mouse_over1_1'");
            Button_Download_UnionServer.Attributes.Add("onmouseout", "this.className='button_mouse_out1_1'");
        }

        protected void Button_Download_UnionServer_Click(object sender, EventArgs e)
        {
            Response.ContentType = "Application/exe";
            Response.AppendHeader("Content-Disposition", "attachment; filename=union_server.exe");
            Response.TransmitFile(Server.MapPath("files/union_server.exe"));
            Response.End();
        }
    }
}