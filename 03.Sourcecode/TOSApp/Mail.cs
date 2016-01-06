using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace TOSApp
{
    public static class Mail
    {
        
        public static void sendEmail(string emailFrom, string password, string emailTo, string subject, string body)
        {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom); //email của mình
                mail.To.Add(emailTo); //gửi tới ai
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
               
                // Can set to false, if you are sending pure text.

                //mail.Attachments.Add(new Attachment("H:\\cpaior2012_path.pdf"));

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}
