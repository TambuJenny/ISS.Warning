using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ISS.Warning.Classes
{
    class SendSmsTwilio
    {
        string numero = "922201314";
        string body = "[*titleday] [*Client-title] [*NOME_CURTO],a sua apólice de[*NomeApolice] vence no dia[*datafim].Vale lembrar que, para continuar contando com as facilidades contratadas, é importante que faça o pagamento da apólice.";
        private static searches procura = new searches();


        public string  SendTwilio(string idpessoa) 
        {

            var contacto = procura.ContactoPessoa(idpessoa);

            foreach (var item in contacto)
            {

                EnviarTwilio(item.Telefone,body);

            }

            return "";

        }
        public void EnviarTwilio(string destino,string body)
        {
            var message = MessageResource.Create(
             body: body,
             from: new Twilio.Types.PhoneNumber("+12246018391"),
             to: new Twilio.Types.PhoneNumber(destino)
         );

            Console.WriteLine(message.Sid);
        }
    }
}
