using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.Warning.Extras;
using ISS.Warning.Model;

namespace ISS.Warning.Classes
{
    class SendMAil
    {
        public static searches procura = new searches();
        public static FileSystemManager ftp = new FileSystemManager();
        public static SendMAil mail = new SendMAil();
        public static EmailModel entiMmail = new EmailModel();
        public static MailConfiguration MailConfiguration;

        public void MandarEmail() 
        {
            
            
            DateTime datehoje = DateTime.Now;
            
           
            var pessoas = procura.allpessoa();

            foreach (var item in pessoas)
            {
                if (item.DataNascimento == datehoje)
                {
                    string a = item.IdPessoa; 
                }
            }

        }

        private void sendMail(string idpessoa)
        {
            var contacto = procura.ContactoPessoa(idpessoa);

            foreach (var item in contacto)
            {

                entiMmail.Destinatario = item.Email;
                entiMmail.Assunto = "Teste";
                entiMmail.Conteudo =  ftp.template($"Avisodecobranca.html");
                MailConfiguration.Send(entiMmail);



            }
        }


    }
}
