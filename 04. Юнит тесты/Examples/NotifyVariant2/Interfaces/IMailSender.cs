using NotifyVariant2.Models;

namespace NotifyVariant2.Interfaces
{
    public interface IMailSender
    {
        void SendMail(MailMessage message);
    }
}