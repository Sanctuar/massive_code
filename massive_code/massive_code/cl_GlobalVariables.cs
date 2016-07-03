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
            return HttpContext.Current.Server.MapPath("app_data/base/registration.sdf");
        }

        public class pcl_UserData
        {
            public String Login;
            public String UID;
        }

        public class pcl_user_regist
        {
            public String Name;
            public String Surname;
            public String Login;
            public String Mail;
            public String Password;
            public String Date;
            public String Attribute;
            public String Permission;
            public String UID;
        }

        public String ps_MailSupportAddress = "support@massivecode.ru";
        public String ps_MailSupportPassword = "sUppoRt#7";
    }
}