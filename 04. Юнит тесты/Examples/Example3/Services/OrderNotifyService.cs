using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example3.Constants.Enums;
using Example3.Models;
using Example3.Repositories;

namespace Example2.Services
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
