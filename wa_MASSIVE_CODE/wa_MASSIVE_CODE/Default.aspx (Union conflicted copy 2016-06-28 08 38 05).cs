using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace wa_MASSIVE_CODE
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_mini_code_description.Text = "mini code";
            Label_mini_code.Text = File.ReadAllText(Server.MapPath("code/mini/mini_code_1.txt"));
        }

    }
}