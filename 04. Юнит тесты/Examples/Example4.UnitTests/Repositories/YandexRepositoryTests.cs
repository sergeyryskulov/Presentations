using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example4.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example4.Context;
using Moq;

namespace Example4.Repositories.Tests
{
    [TestClass()]
    public class YandexRepositoryTests
    {
        [TestMethod()]
        public void GetOrderTest()
        {
            var yandexContextMock = new Mock<IYandexContext>();

            yandexContextMock.Setup(m => m.SendRequest("https://business.taxi.yandex.ru/api/order/1")).Returns(
                @"{""id"": ""1"", ""status"": ""complete""}");

            var yandexRepository = new YandexRepository(yandexContextMock.Object);

            var actualOrder = yandexRepository.GetOrder(1);

            Assert.AreEqual(1, actualOrder.Id);

            Assert.AreEqual("complete", actualOrder.Status);
        }
    }
}