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
    public class cl_GlobalVariables
    {
        public String gs_RegistrBasePath()
        {
            return HttpContext.Current.Server.MapPath("base/registration.sdf");
        }
        
    }
}