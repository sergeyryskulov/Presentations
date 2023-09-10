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
        private IRepository1 _repository1;

        private IRepository2 _repository2;

        private IRepository3 _repository3;

        public BigService(IRepository1 repository1, IRepository2 repository2, IRepository3 repository3)
        {
            _repository1 = repository1;
            _repository2 = repository2;
            _repository3 = repository3;
        }


        public string GetData()
        {
            return "" + _repository1.GetData1() + _repository2.GetData2() + _repository3.GetData3();
        }
    }
}
