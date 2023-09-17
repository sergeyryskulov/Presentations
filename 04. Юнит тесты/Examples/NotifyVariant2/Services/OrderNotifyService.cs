using NotifyVariant2.Constants.Enums;
using NotifyVariant2.Interfaces;
using NotifyVariant2.Models;

namespace NotifyVariant2.Services
{
    public class OrderNotifyService
    {
        private IMailSender _mailSender;

        public OrderNotifyService(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public void SendNotify(OrderModel order)
        {
            string messageBody = "";

            if (order.Status == OrderStatus.Created)
            {
                messageBody = $"Заказ создан. Номер заказа: {order.Id} Описание: {order.Description}";
            }
            else if (order.Status == OrderStatus.Canceled)
            {
                messageBody = $"Заказ отменен. Номер заказа: {order.Id} Описание: {order.Description}";
            }
            if (order.Status == OrderStatus.Completed)
            {
                messageBody = $"Заказ выполнен. Номер заказа: {order.Id} Описание: {order.Description}";
            }

            _mailSender.SendMail(new MailMessage()
            {
                To = order.InitiatorMail,
                Subject = "Информация о заявке",
                Body = messageBody
            });

        }
    }
}
