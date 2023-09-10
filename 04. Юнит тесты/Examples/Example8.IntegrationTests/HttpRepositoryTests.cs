using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8.Tests
{
    [TestClass()]
    public class HttpRepositoryTests
    {
        [TestMethod()]
        public void SendRequestTest()
        {
            var result = new HttpRepository().SendRequest("https://portal.cft.ru");
            Assert.IsTrue(result.Contains("Портал"));
            
        }
    }
}