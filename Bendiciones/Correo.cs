using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Bendiciones
{
    public class Correo
    {
        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "bendicionestest@gmail.com"; //Sender Email Address  
        static string password = "bendiciones1234."; //Sender Password  

        public void CorreoNuevoColaborador( Service.colaborador colaborador)
        {

			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress(emailFromAddress);
				mail.To.Add(colaborador.email);
				mail.Subject = "Bienvenida/o a Escuela para embarazadas " + colaborador.nombre;
				mail.Body = "Usuario: " + colaborador.user + "<br>Contraseña: " + colaborador.password +
					"<br> Contraseña personal. Por favor, no comparta con nadie su contraseña" ; 
				mail.IsBodyHtml = true;
				using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
				{
					smtp.Credentials = new NetworkCredential(emailFromAddress, password);
					smtp.EnableSsl = enableSSL;
					smtp.Send(mail);
					MessageBox.Show("Se ha enviado el correo a " + colaborador.email, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			//try
   //         {
   //             MailMessage mail = new MailMessage();
   //             mail.From = new MailAddress(emailFromAddress);
   //             mail.To.Add(colaborador.email);
   //             mail.Subject = "Bienvenido a Escula para Embarazadas" + colaborador.nombre;
   //             mail.Body = "Usuario: " + colaborador.user +
   //                 "\nContraseña: " + colaborador.password + "\n Contraseña persola. Por favor, no comparta con nadie su contraseña";
   //             mail.IsBodyHtml = true;

   //             SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);
   //             smtp.Credentials = new NetworkCredential(emailFromAddress, password);
   //             smtp.EnableSsl = enableSSL;
   //             smtp.Send(mail);
   //             MessageBox.Show("Se ha enviado el correo a "+colaborador.email , "", MessageBoxButtons.OK, MessageBoxIcon.Information);

   //         }
   //         catch(Exception ex)
   //         {
   //             MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
   //         }
               
            
        }
    }
}

