
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ISS.Warning.Model;

namespace ISS.Warning.Extras
{
    class MailConfiguration
    {
        #region Private Members
        /// <summary>
        /// Usado para pegar as configurações de email.
        /// </summary>
      
        private readonly IConfiguration _configuration;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor Padrão.
        /// </summary>
        public MailConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Interface Implementations
        /// <summary>
        /// Enviar email para uma determinada pessoa.
        /// <param name="emailModel">Estrutura contendo dados necessários ao email.</param>
        /// </summary>
        public void Send(EmailModel EmailViewModel , Action<object, AsyncCompletedEventArgs> onCompleted = null)
        {
            // Configurar a mensagem a ser enviada.
            var msg = new MailMessage(EmailModel.From, EmailViewModel.Destinatario);
            msg.Subject = EmailViewModel.Assunto;
            msg.Body = EmailViewModel.Conteudo;
            msg.IsBodyHtml = true;
            // Configurar o cliente SMTP
            var smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(EmailModel.From, EmailModel.Password);
            smtpClient.Host = EmailModel.Host;
            smtpClient.Port = EmailModel.Port;
            smtpClient.EnableSsl = EmailModel.EnableSsl;

            if (!EmailViewModel.SendNow)
                Debug.WriteLine("Enviando ..."); // TODO: Implementar um background service para enviar o email na data programada.

            // TODO: Tratar desse atributo.
            object userToken = null;
            smtpClient.SendAsync(msg, userToken);

            smtpClient.SendCompleted += (ss, ee) =>
            {
                onCompleted?.Invoke(ss, ee);
            };
        }

        /// <summary>
        /// Enviar email para uma determinada pessoa.
        /// <param name="emailModel">Estrutura contendo dados necessários ao email.</param>
        /// </summary>
        public async Task SendAsync(EmailModel EmailViewModel , Action<object, AsyncCompletedEventArgs> onCompleted = null)
        {
            // Configurar a mensagem a ser enviada.
            var msg = new MailMessage(EmailModel.From, EmailViewModel.Destinatario);
            msg.Subject = EmailViewModel.Assunto;
            msg.Body = EmailViewModel.Conteudo;
            msg.IsBodyHtml = true;

            // Configurar o cliente SMTP
            var smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(EmailModel.From, EmailModel.Password);
            smtpClient.Host = EmailModel.Host;
            smtpClient.Port = EmailModel.Port;
            smtpClient.EnableSsl = EmailModel.EnableSsl;

            if (!EmailViewModel.SendNow)
                Debug.WriteLine("Enviando ..."); // TODO: Implementar um background service para enviar o email na data programada.

            // Envio de uma mensagem em smtp de forma assincrona.
            await smtpClient.SendMailAsync(msg);

            smtpClient.SendCompleted += (ss, ee) =>
            {
                onCompleted?.Invoke(ss, ee);
            };
        }
        #endregion
    }
}

