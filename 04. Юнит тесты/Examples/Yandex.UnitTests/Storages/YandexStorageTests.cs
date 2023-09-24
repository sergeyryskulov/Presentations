using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yandex.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Yandex.Interfaces;

namespace Yandex.Storages.Tests
{
    [TestClass()]
    public class YandexStorageTests
    {
        [TestMethod()]
        public async Task GetOrderTest()
        {
            var yandexContextMock = new Mock<IYandexContext>();

            yandexContextMock.Setup(m => m.SendRequestAsync("https://business.taxi.yandex.ru/api/order/1")).ReturnsAsync(
                @"{""id"": ""1"", ""status"": ""complete""}");

            var yandexRepository = new YandexStorage(yandexContextMock.Object);

            var actualOrder = await yandexRepository.GetOrderAsync(1);

            Assert.AreEqual(1, actualOrder.Id);

            Assert.AreEqual("complete", actualOrder.Status); ;
        }
    }
}