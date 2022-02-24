using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace den_office.Controllers
{
    public class EmailSender
    {
        public EmailSender()
        {
            
        }
        public bool Execute(string userEmail, string confirmationLink)
        {
            string fromEmail = "glackkoteu@gmail.com";
            //string toEmail = "tefrak74@gmail.com";
            MailMessage mailConfirmation = new MailMessage();
            mailConfirmation.From = new MailAddress(fromEmail);
            mailConfirmation.To.Add(new MailAddress(userEmail));
            mailConfirmation.Subject = "Prośba o potwierdzenie konta";
            mailConfirmation.Body = confirmationLink;
            mailConfirmation.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   
            NetworkCredential basicCredential1 = new
            NetworkCredential("glackkoteu@gmail.com", "gregory77");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            client.Send(mailConfirmation);
            return true;

            }

        
    }
}
