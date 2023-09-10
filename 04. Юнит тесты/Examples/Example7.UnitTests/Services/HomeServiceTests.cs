using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example6.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;

namespace Example6.Services.Tests
{
    [TestClass()]
    public class HomeServiceTests
    {
        [TestMethod()]
        public void GetHomeViewModelTest()
        {
            /*var testRepositoryMock = new Mock<ITestRepository>();

            testRepositoryMock.Setup(m => m.Test()).Returns("testmessage");

            var homeService = new HomeService(testRepositoryMock.Object);

            var actual = homeService.GetHomeViewModel();

            Assert.AreEqual("testmessage", actual.Message);*/
            
        }
    }
}