using NotifyVariant1.Constants.Enums;
using NotifyVariant1.Helpers;
using NotifyVariant1.Models;

namespace NotifyVariant1.Services
{
// старый код до использования юнит теста
/*
    class OrderNotifyService
    {
        private MailSender _mailSender;

        public OrderNotifyService(MailSender mailSender)
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
    }*/

    // преобразованный код для возможности тестировать текст сообщения
    // правильно ли так делать? какие есть недостатки у такого подхода?
    public class OrderNotifyService
    {
        private MailSender _mailSender;

        public OrderNotifyService(MailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public void SendNotify(OrderModel order)
        {
            string messageBody = GenerateMessage(order);

            _mailSender.SendMail(new MailMessage()
            {
                To = order.InitiatorMail,
                Subject = "Информация о заказе",
                Body = messageBody
            });
        }

        public string GenerateMessage(OrderModel order)
        {
            if (order.Status == OrderStatus.Created)
            {
                return $"Заказ создан. Номер заказа: {order.Id} Описание: {order.Description}";
            }
            if (order.Status == OrderStatus.Canceled)
            {
                return $"Заказ отменен. Номер заказа: {order.Id} Описание: {order.Description}";
            }
            if (order.Status == OrderStatus.Completed)
            {
                return $"Заказ выполнен. Номер заказа: {order.Id} Описание: {order.Description}";
            }

            return "";
        }    
    }
}
