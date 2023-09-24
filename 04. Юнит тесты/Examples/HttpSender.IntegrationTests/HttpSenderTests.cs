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
    public class HttpSenderTests
    {
        [TestMethod()]
        public async Task SendRequestTest()
        {
            var result = await new HttpSender().SendRequest("https://ya.ru");
            Assert.IsTrue(result.Contains("Яндекс"));
        }
    }
}