using Example3.Models;

namespace Example3.Repositories
{
    public interface IMailSender
    {
        void SendMail(MailMessage message);
    }
}