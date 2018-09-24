using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Intern_forms_management_system
{
    class sendMail
    {
        public void sendmail(string sendermail,string sendepassword,string receivermail) {

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.EnableSsl = true;
                SmtpServer.Credentials = new NetworkCredential(sendermail, sendepassword);
                SmtpServer.Send(sendermail, receivermail, "About Form I-1", "Sir, My details are added to the Form I-1, please sir check it");
            }
            catch(Exception e) {
                Console.Write(e);
            }

            }
        }

    }

