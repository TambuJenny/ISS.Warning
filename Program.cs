using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.Warning.Extras;
using ISS.Warning.Classes;
using ISS.Warning.Model;

namespace ISS.Warning
{
    class Program
    {
        public  static FileSystemManager fsp = new FileSystemManager();
        public static searches searche = new searches();
       
        public static searches procura = new searches();
        public static FileSystemManager ftp = new FileSystemManager();
        public static SendMAil mail = new SendMAil();
        public static EmailModel entiMmail = new EmailModel();
        private static IConfiguration _configuration;

        static void Main(string[] args)
        {
            entiMmail.Destinatario = "tambu.jenny@snir.co.ao";
            entiMmail.Assunto = "Teste";
            entiMmail.Conteudo = ftp.template($"Avisodecobranca.html");
            var email = new MailConfiguration(_configuration);
            email.Send(entiMmail);

            /* var teste1 = searche.pessoas("c2ee14b4-da99-46d9-ad5c-8b02b31ec3f0");
              foreach (var item in teste1)
              {
                  string a = item.NomeCompleto;
              }*/

            /*  using (DBIS_PRE_PRODEntities _PRODEntities = new DBIS_PRE_PRODEntities())
              {
                  Pessoa pessoas = new Pessoa();

                  pessoas.NomeCompleto = "Alala";
                  pessoas.NIF = "Ppppqpppqp";

                  _PRODEntities.Pessoa.Add(pessoas);
                  _PRODEntities.SaveChanges();


              };*/


            var teste = fsp.template("vindo.html");

            if (teste!=null || teste!=string.Empty)
            {
                Console.WriteLine("o template foi carregado");
            }
            else
            {
                Console.WriteLine("um erro aconteceu !");
            }



            Console.ReadKey();

            

        }
    }
}
