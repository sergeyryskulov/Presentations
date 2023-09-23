using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example5.Repositories;

namespace Example5.Services
{
    public class BigService
    {
        private IStorage1 _storage1;

        private IStorage2 _storage2;

        private IStorage3 _storage3;

        public BigService(
            IStorage1 storage1,
            IStorage2 storage2,
            IStorage3 storage3
        )
        {
            _storage1 = storage1;
            _storage2 = storage2;
            _storage3 = storage3;
        }

        public string GetData()
        {
            return "" + _storage1.GetData1() + _storage2.GetData2() + _storage3.GetData3();
        }
    }
}
