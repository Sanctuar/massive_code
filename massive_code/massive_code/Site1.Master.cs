using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace massive_code
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button_Download_UnionServer.Attributes.Add("onmouseover", "this.className='button_mouse_over1'");
            Button_Download_UnionServer.Attributes.Add("onmouseout", "this.className='button_mouse_out1'");
            Button_Download_UnionClient.Attributes.Add("onmouseover", "this.className='button_mouse_over1'");
            Button_Download_UnionClient.Attributes.Add("onmouseout", "this.className='button_mouse_out1'");
        }
        public int pi_ClientScreenWidth()
        {
            return Request.Browser.ScreenPixelsWidth;
        }
    }
}