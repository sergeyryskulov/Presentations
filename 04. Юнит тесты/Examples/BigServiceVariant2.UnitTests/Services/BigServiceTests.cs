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
        Mock<IStorage1> _storage1;
        Mock<IStorage2> _storage2;
        Mock<IStorage3> _storage3;
       
        BigService CreateBigService()
        {
            return new BigService(_storage1.Object, _storage2.Object, _storage3.Object);
        }

        [TestInitialize]
        public void InitTest()
        {
            _storage1 = new Mock<IStorage1>();
            _storage2 = new Mock<IStorage2>();
            _storage3 = new Mock<IStorage3>();
        }
    

        [TestMethod()]
        public void GetDataTest1()
        {
            
            _storage1.Setup(m => m.GetData1()).Returns("1");

            _storage2.Setup(m => m.GetData2()).Returns("2");

            _storage3.Setup(m => m.GetData3()).Returns("3");

            var bigService = CreateBigService();

            var actualData = bigService.GetData();

            Assert.AreEqual("123", actualData);
            
        }

        [TestMethod()]
        public void GetDataTest2()
        {
            _storage1.Setup(m => m.GetData1()).Returns("11");

            _storage2.Setup(m => m.GetData2()).Returns("22");

            _storage3.Setup(m => m.GetData3()).Returns("33");

            var bigService = CreateBigService();

            var actualData = bigService.GetData();
            
            Assert.AreEqual("112233", actualData);
        }

        [TestMethod()]
        public void GetDataTest3()
        {
            _storage1.Setup(m => m.GetData1()).Returns("111");

            _storage2.Setup(m => m.GetData2()).Returns("222");

            _storage3.Setup(m => m.GetData3()).Returns("333");

            var bigService = CreateBigService();

            var actualData = bigService.GetData();
            
            Assert.AreEqual("111222333", actualData);
        }
    }
}