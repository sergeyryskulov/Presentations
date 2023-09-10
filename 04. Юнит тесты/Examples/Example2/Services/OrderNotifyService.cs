using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.Constants.Enums;
using Example2.Models;
using Example2.Repositories;

namespace Example2.Services
{
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
    
    public class OrderNotifyService
    {
        private MailSender _mailSender;

        public OrderNotifyService(MailSender mailSender)
        {
            _mailSender = mailSender;
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
                return  $"Заказ выполнен. Номер заказа: {order.Id} Описание: {order.Description}";
            }

            return "";
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
    }
}
