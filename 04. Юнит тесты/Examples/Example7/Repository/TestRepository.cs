using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example6.Repository
{
    public class TestRepository : ITestRepository
    {

        public string Test()
        {
            return "ok";
        }
    }
}
