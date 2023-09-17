using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NotifyVariant2.Constants.Enums;
using NotifyVariant2.Interfaces;
using NotifyVariant2.Models;
using NotifyVariant2.Services;

namespace Example3.UnitTests.Services
{
    [TestClass()]
    public class OrderNotifyServiceTests
    {

        [TestMethod()]
        public void SendCreatedNotifyTest()
        {
            var mailSenderMock = new Mock<IMailSender>();
            
            OrderNotifyService orderNotifyService = new OrderNotifyService(mailSenderMock.Object);

            orderNotifyService.SendNotify(new OrderModel()
            {
                InitiatorMail = "initiatorMail",
                Status = OrderStatus.Created,
                Description = "description",
                Id = 1
            });

            mailSenderMock.Verify(
                m=>m.SendMail(It.Is<MailMessage>(
                    t=>t.To == "initiatorMail" &&
                       t.Subject == "Информация о заявке" &&
                       t.Body == "Заказ создан. Номер заказа: 1 Описание: description")));
        }

        [TestMethod()]
        public void SendCompletedNotifyTest()
        {
            var mailSenderMock = new Mock<IMailSender>();

            OrderNotifyService orderNotifyService = new OrderNotifyService(mailSenderMock.Object);

            string expectedBody = File.ReadAllText("TestFiles/CompletedNotifyTest.txt");

            orderNotifyService.SendNotify(new OrderModel()
            {
                InitiatorMail = "initiatorMail",
                Status = OrderStatus.Completed,
                Description = "description",
                Id = 1
            });

            mailSenderMock.Verify(
                m => m.SendMail(It.Is<MailMessage>(
                    t => t.To == "initiatorMail" &&
                         t.Subject == "Информация о заявке" &&
                         t.Body == expectedBody)));
        }


        [TestMethod()] 
        public void SendCancelledNotifyTest()
        {
            var mailSenderMock = new Mock<IMailSender>();

            OrderNotifyService orderNotifyService = new OrderNotifyService(mailSenderMock.Object);

            MailMessage? savedMailMessage = null;

            mailSenderMock.Setup(m => m.SendMail(It.IsAny<MailMessage>()))
                .Callback<MailMessage>(t => savedMailMessage = t);

            orderNotifyService.SendNotify(new OrderModel()
            {
                InitiatorMail = "initiatorMail",
                Status = OrderStatus.Canceled,
                Description = "description",
                Id = 1
            });

            Assert.AreEqual("initiatorMail", savedMailMessage?.To);
            Assert.AreEqual("Информация о заявке", savedMailMessage?.Subject);
            Assert.AreEqual("Заказ отменен. Номер заказа: 1 Описание: description", savedMailMessage?.Body);
        }
    }
}