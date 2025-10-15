using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }

    public async Task EnviarEmailAsync(string destinatario, string assunto, string mensagem)
    {
        var emailSettings = _config.GetSection("EmailSettings");
        var smtpServer = emailSettings["SmtpServer"];
        var smtpPort = int.Parse(emailSettings["SmtpPort"]);
        var username = emailSettings["Username"];
        var password = emailSettings["Password"];
        var senderEmail = emailSettings["SenderEmail"];
        var enableSSL = bool.Parse(emailSettings["EnableSSL"]);

        using (var client = new SmtpClient(smtpServer, smtpPort))
        {
            client.Credentials = new NetworkCredential(username, password);
            client.EnableSsl = enableSSL;

            var mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(destinatario);
            mail.Subject = assunto;
            mail.Body = mensagem;
            mail.IsBodyHtml = true;

            await client.SendMailAsync(mail);
        }
    }
}
