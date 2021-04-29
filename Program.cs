using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.Warning.Extras;
using ISS.Warning.Classes;
using ISS.Warning.Model;
using System.Timers;
using Twilio;
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

        public static SendSmsTwilio SmsTwilio = new SendSmsTwilio();

        private static Timer timer = new Timer();
        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {
           Twilio.TwilioClient.Init("ACacbef9be5c77fe285d6c082f06a25f6b", "642a41b67c344c238b08ed778b3ad964");
            SmsTwilio.EnviarTwilio("922201314", "");

           /* SetTimer();
            Console.ReadLine();
            aTimer.Stop(); 
            aTimer.Dispose();

          

            //mail.MandarAviso_Apolice();



            Console.ReadKey();*/

            
            
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += Envios;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static bool a1 = false;
        private static void Envios(Object source, ElapsedEventArgs e) 
        {
            
           
            if (e.SignalTime.Hour == 00 && e.SignalTime.Minute == 06 && e.SignalTime.Second== 00)
            {


                if (!mail.MandarEmailFelizAni())
                    return;
                a1 = true;

                if (a1 == true)
                {
                    mail.MandarAviso_Apolice();

                    a1 = false;
                }
            }

          

            
           
        }

    }
}

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