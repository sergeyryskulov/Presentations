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
            var storage1Mock = new Mock<IStorage1>();
            storage1Mock.Setup(m => m.GetData1()).Returns("1");

            var storage2Mock = new Mock<IStorage2>();
            storage2Mock.Setup(m => m.GetData2()).Returns("2");

            var storage3Mock = new Mock<IStorage3>();
            storage3Mock.Setup(m => m.GetData3()).Returns("3");

            var bigService = new BigService(storage1Mock.Object, storage2Mock.Object, storage3Mock.Object);

            var actualData = bigService.GetData();

            Assert.AreEqual("123", actualData);
        }

        [TestMethod()]
        public void GetDataTest2()
        {
            var storage1Mock = new Mock<IStorage1>();
            storage1Mock.Setup(m => m.GetData1()).Returns("11");

            var storage2Mock = new Mock<IStorage2>();
            storage2Mock.Setup(m => m.GetData2()).Returns("22");

            var storage3Mock = new Mock<IStorage3>();
            storage3Mock.Setup(m => m.GetData3()).Returns("33");

            var bigService = new BigService(storage1Mock.Object, storage2Mock.Object, storage3Mock.Object);

            var actualData = bigService.GetData();

            Assert.AreEqual("112233", actualData);
        }

        [TestMethod()]
        public void GetDataTest3()
        {
            var storage1Mock = new Mock<IStorage1>();
            storage1Mock.Setup(m => m.GetData1()).Returns("111");

            var storage2Mock = new Mock<IStorage2>();
            storage2Mock.Setup(m => m.GetData2()).Returns("222");

            var storage3Mock = new Mock<IStorage3>();
            storage3Mock.Setup(m => m.GetData3()).Returns("333");

            var bigService = new BigService(storage1Mock.Object, storage2Mock.Object, storage3Mock.Object);

            var actualData = bigService.GetData();

            Assert.AreEqual("111222333", actualData);
        }
    }
}