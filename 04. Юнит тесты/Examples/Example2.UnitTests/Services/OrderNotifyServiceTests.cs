using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.Constants.Enums;
using Example2.Models;
using Example2.Repositories;

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