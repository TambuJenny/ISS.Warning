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
        private static searches procura = new searches();
        private static FileSystemManager ftp = new FileSystemManager();
        private static SendMAil mail = new SendMAil();
        private static EmailModel entiMmail = new EmailModel();
        private static MailConfiguration MailConfiguration;
        private static CalData CalData = new CalData();
        public static SendSmsTwilio SmsTwilio = new SendSmsTwilio();
        DateTime datehoje = DateTime.Now;

        public bool MandarEmailFelizAni() 
        {
            bool trigg = false;
            try
            {

                List<string> Idpessoa = new List<string>();



                var pessoas = procura.allpessoa();

                foreach (var item in pessoas)
                {
                    if (item.DataNascimento == datehoje)
                    {
                        Idpessoa.Add(item.IdPessoa);
                    }
                }

                if (Idpessoa.Count < 1)
                {
                    Console.WriteLine("Nenhum Aniversariante para hoje... ");
                    trigg = true;
                }
                else
                {
                    for (int i = 0; i < Idpessoa.Count; i++)
                    {
                        sendMail(Idpessoa[i], "Avisodecobranca");
                    }
                    trigg = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw ;
            }

            return trigg;
        }

        public void MandarAviso_Apolice() 
        {

           
            DateTime date2;
            var _apolice = procura.buscar_apolice();
            List<string> id_pessoa = new List<string>();

            foreach (var item in _apolice)
            {
                date2 = CalData.CallData(Convert.ToDateTime(item.DataExpiracao));
                if (date2 == DateTime.Now)
                {
                    sendMail(item.TomadorId, "Avisodecobranca");
                    SmsTwilio.SendTwilio(item.TomadorId);


                }

            }
        
        }

        private async void  sendMail(string idpessoa,string template)
        {
            var contacto = procura.ContactoPessoa(idpessoa);

            foreach (var item in contacto)
            {
                var templateMail = ftp.template($"" + template + ".html");
                

                entiMmail.Destinatario = item.Email;
                entiMmail.Assunto = "Teste";
                entiMmail.Conteudo = templateMail;
                //template 
                MailConfiguration.Send(entiMmail);


            }
        }


    }
}
