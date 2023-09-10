using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example5.Repositories;
using Moq;

namespace Example5.Services.Tests
{
    [TestClass()]
    public class BigServiceTests
    {
        [TestMethod()]
        public void GetDataTest1()
        {
            var repository1Mock = new Mock<IRepository1>();
            repository1Mock.Setup(m => m.GetData1()).Returns("1");

            var repository2Mock = new Mock<IRepository2>();
            repository2Mock.Setup(m => m.GetData2()).Returns("2");

            var repository3Mock = new Mock<IRepository3>();
            repository3Mock.Setup(m => m.GetData3()).Returns("3");

            var bigService = new BigService(repository1Mock.Object, repository2Mock.Object, repository3Mock.Object);

            var actualData = bigService.GetData();

            Assert.AreEqual("123", actualData);
        }

        [TestMethod()]
        public void GetDataTest2()
        {
            var repository1Mock = new Mock<IRepository1>();
            repository1Mock.Setup(m => m.GetData1()).Returns("11");

            var repository2Mock = new Mock<IRepository2>();
            repository2Mock.Setup(m => m.GetData2()).Returns("22");

            var repository3Mock = new Mock<IRepository3>();
            repository3Mock.Setup(m => m.GetData3()).Returns("33");

            var bigService = new BigService(repository1Mock.Object, repository2Mock.Object, repository3Mock.Object);

            var actualData = bigService.GetData();

            Assert.AreEqual("112233", actualData);
        }

        [TestMethod()]
        public void GetDataTest3()
        {
            var repository1Mock = new Mock<IRepository1>();
            repository1Mock.Setup(m => m.GetData1()).Returns("111");

            var repository2Mock = new Mock<IRepository2>();
            repository2Mock.Setup(m => m.GetData2()).Returns("222");

            var repository3Mock = new Mock<IRepository3>();
            repository3Mock.Setup(m => m.GetData3()).Returns("333");

            var bigService = new BigService(repository1Mock.Object, repository2Mock.Object, repository3Mock.Object);

            var actualData = bigService.GetData();

            Assert.AreEqual("111222333", actualData);
        }
    }
}