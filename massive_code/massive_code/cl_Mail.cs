using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Security;

namespace massive_code
{
    public class cl_Mail
    {
        cl_GlobalVariables g_GV = new cl_GlobalVariables();

        private void prv_SendMail(MailMessage lmm_Message)
        {
            SmtpClient lsmtp = new SmtpClient("mail.massivecode.ru", 25);
            lsmtp.Credentials = new NetworkCredential(g_GV.ps_MailSupportAddress, g_GV.ps_MailSupportPassword);
            lsmtp.Send(lmm_Message);
        }
        public void pv_Mail_ConfirmRegistration(String ls_UID, String ls_MailTo)
        {
            String ls_ConfirmURL = "http://massivecode.ru/information.aspx?mail_confirm="+ls_UID;
            MailMessage lmm = new MailMessage(g_GV.ps_MailSupportAddress, ls_MailTo);
            lmm.Body = "Подтвердите ваши регистрационные данные перейдя по ссылке: " + ls_ConfirmURL;
            lmm.Subject = "Подтверждение регистрации MASSIVECODE.RU";
            prv_SendMail(lmm);
        }


    }
}