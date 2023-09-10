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
        
        Mock<IRepository1> _repository1;
        Mock<IRepository2> _repository2;
        Mock<IRepository3> _repository3;

       
        BigService CreateBigService()
        {
            return new BigService(_repository1.Object, _repository2.Object, _repository3.Object);
        }

        [TestInitialize]
        public void InitTest()
        {
            _repository1 = new Mock<IRepository1>();
            _repository2 = new Mock<IRepository2>();
            _repository3 = new Mock<IRepository3>();
        }
    

        [TestMethod()]
        public void GetDataTest1()
        {
            
            _repository1.Setup(m => m.GetData1()).Returns("1");

            _repository2.Setup(m => m.GetData2()).Returns("2");

            _repository3.Setup(m => m.GetData3()).Returns("3");

            var bigService = CreateBigService();

            var actualData = bigService.GetData();

            Assert.AreEqual("123", actualData);
            
        }

        [TestMethod()]
        public void GetDataTest2()
        {

            _repository1.Setup(m => m.GetData1()).Returns("11");

            _repository2.Setup(m => m.GetData2()).Returns("22");

            _repository3.Setup(m => m.GetData3()).Returns("33");

            var bigService = CreateBigService();

            var actualData = bigService.GetData();
            
            Assert.AreEqual("112233", actualData);
        }

        [TestMethod()]
        public void GetDataTest3()
        {
            _repository1.Setup(m => m.GetData1()).Returns("111");

            _repository2.Setup(m => m.GetData2()).Returns("222");

            _repository3.Setup(m => m.GetData3()).Returns("333");

            var bigService = CreateBigService();

            var actualData = bigService.GetData();
            
            Assert.AreEqual("111222333", actualData);
        }
    }
}