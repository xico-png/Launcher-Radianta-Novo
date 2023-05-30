using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Launcher_Radianta_Novo
{
    
    internal class Util 

    {
        

        private static void AddEmails(MailAddressCollection emailcollection, string[] emailList)
        {
            if (emailList != null)
            {
                foreach (var emailString in emailList)
                {
                    if (emailString != null)
                    {
                        string[] emailSplited = emailString.Split(';');
                        foreach (string email in emailSplited)
                        {
                            try
                            {
                                emailcollection.Add(new MailAddress(email));
                            }
                            catch(Exception) { return; }
                        }
                    }
                }
            }
        }

        private static void AddAttachment(MailMessage message, string[] anexos)
        {
            if (anexos.Length > 0)
            {
                foreach (string file in anexos)
                {
                    if (file != "")
                    {
                        if (System.IO.File.Exists(file))   // verifica a existência do arquivo
                        {
                            // Cria o anexo para colocar dentro da mensagem
                            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
                            data.Name = System.IO.Path.GetFileName(file);
                            // Insere as datas no anexo
                            ContentDisposition disposition = data.ContentDisposition;
                            disposition.CreationDate = System.IO.File.GetCreationTime(file);
                            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
                            // Adiciona o arquivo na mensagem criada
                            message.Attachments.Add(data);
                        }
                    }
                }
            }
        }
        

        public static bool EnviarMensagem(EmailServerAccount conta, string[] destino, string[] emailcc, string mensagem, string titulo, string[] anexos)
        {
            if (String.IsNullOrEmpty(destino[0]))
                //return "Erro sem e-mail ! Assunto:" + titulo;
                return false;

            if (conta == null)
                //return "Erro, conta de e-mail não existente !";
                return false;
            MailMessage message = new MailMessage();                                // instancia o objeto da mensagem
            message.From = new MailAddress(conta.EmailOrigem, conta.NomeOrigem);    // atribui remetente
            message.ReplyToList.Add(new MailAddress(conta.Retorno));                // atribui e-mail de resposta

            // o config e-mail debug permite enviar para um e-mail de teste configurado no appsettings
            // caso estejamos rodando o software em modo Teste isto é útil para não disparar para clientes
            if (conta.EmailDebug != "")
                message.To.Add(new MailAddress(conta.EmailDebug));
            else
            {
                AddEmails(message.To, destino);                                     // adiciona destinatários
                AddEmails(message.Bcc, emailcc);                                    // adiciona cópias ocultas
            }

            AddAttachment(message, anexos);                                         // adiciona os anexos se houver
            message.Priority = MailPriority.Normal;                                 //prioridade do email
            message.IsBodyHtml = false;                                             //utilize true pra ativar html no conteúdo do email, ou false, para somente texto
            message.Subject = titulo;                                               //Assunto do email
            message.Body = mensagem;                                                 //corpo do email a ser enviado
            EmailServerAccount teste = new EmailServerAccount();
            SmtpClient client = new SmtpClient(conta.Server, conta.Port);           // Instancia o objeto que envia e-mails
            client.EnableSsl = (bool)conta.Autentica;
            client.Credentials = CredentialCache.DefaultNetworkCredentials;         // Insere as credenciais se o Servidor SMTP exigir
            client.Host = conta.Server;                                             //endereço do servidor SMTP(para mais detalhes leia abaixo do código)
            client.Credentials = new NetworkCredential(conta.EmailOrigem, conta.Pass);  //para envio de email autenticado, coloque login e senha de seu servidor de email
            try
            
            {
                // realiza o envio da mensagem
                client.Send(message);
                MessageBox.Show("Email Enviado, use suas informações de login para acessar a sua conta");

                //return "Email Enviado";
                return true;
                

            }
            catch (Exception)
            {


                return false;
                //return " Erro no envio de email para !  " + message.To.ToString() + "\r\n" + " " + ex.Message + "      -       " + ex.StackTrace + System.Environment.NewLine;
                
            }

        }
    }
}
