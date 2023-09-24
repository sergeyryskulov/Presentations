using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer.Interfaces;

namespace DALLayer.Storages
{
    internal class DatabaseStorage : IDatabaseStorage
    {
        public string GetData()
        {
            return "test data";
        }
    }
}
