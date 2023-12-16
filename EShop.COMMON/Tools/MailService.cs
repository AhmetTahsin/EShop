using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EShop.COMMON.Tools
{
    public static class MailService
    {
        public static void Send(string receiver, string password = "ktfcfqfbmwrojhfu", string body = "Test mesajıdır", string subject = "Email Testi", string sender = "charcter741@hotmail.com")
        {
            MailAddress senderEmail = new MailAddress(sender);      //gönderici adresi

            MailAddress receiverEmail = new MailAddress(receiver);  //alıcı adresi

            #region GmailSmtp
            //SmtpClient smtp = new SmtpClient()//smtp ayarlamaları
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587, //465 
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = true,
            //    Credentials = new NetworkCredential(senderEmail.Address, password)
            //}; 
            #endregion
            SmtpClient smtp = new SmtpClient()//smtp ayarlamaları
            {
                Host = "smtp.live.com",
                Port = 587, //465 
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };

            using (MailMessage message = new(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Mail gönderirken bir hata oluştu: " + ex.Message);
                }
            }



        }
    }
}
