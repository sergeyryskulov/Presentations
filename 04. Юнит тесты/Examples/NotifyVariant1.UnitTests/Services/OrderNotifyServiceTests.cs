using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifyVariant1.Services;
using NotifyVariant1.Models;
using NotifyVariant1.Constants.Enums;

namespace Example2.Services.Tests
{
    [TestClass()]
    public class OrderNotifyServiceTests
    {
        [TestMethod()]
        public void GenerateMessageTest()
        {
            var orderNotifyService = new OrderNotifyService(null);
            
            var actualMessage = orderNotifyService.GenerateMessage(new OrderModel()
            {
                Status = OrderStatus.Created,
                Id = 1,
                Description = "мой заказ"
            });

            Assert.AreEqual("Заказ создан. Номер заказа: 1 Описание: мой заказ", actualMessage);
        }
    }
}