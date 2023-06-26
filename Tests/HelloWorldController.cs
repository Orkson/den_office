using den_office.Tests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Mail;

namespace den_office.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {

            HelloWorldViewModel helloWorldViewModel = new HelloWorldViewModel
            {
                Id = 1,
                Text = "agehujrguihorgrghiougrhohgroijuhrgo;soh;gir"
            };

            return View();
        }

        public IActionResult MailSender()
        {
            string to = "tefrak74@gmail.com"; //To address    
            string from = "glackkoteu@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "My maail body";
            message.Subject = "Confirm your acc";
            message.Body = mailbody;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("glackkoteu@gmail.com", "gregory77");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }





            return View();

        }
    }
}
