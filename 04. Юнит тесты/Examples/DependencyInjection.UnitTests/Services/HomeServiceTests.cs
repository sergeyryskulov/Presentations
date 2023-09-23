using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;
using Moq;

namespace DependencyInjection.Services.Tests
{
    [TestClass()]
    public class HomeServiceTests
    {
        [TestMethod()]
        public void MyMethodTest()
        {
            var storage = new Mock<IMyStorage>();

            storage.Setup(m => m.GetData()).Returns("test data");

            var homeService = new HomeService(storage.Object);

            var result = homeService.MyMethod();

            Assert.AreEqual("test data", result);
        }
    }
}