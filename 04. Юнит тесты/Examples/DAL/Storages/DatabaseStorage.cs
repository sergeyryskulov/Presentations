using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Storages
{
    internal class DatabaseStorage : IDatabaseStorage
    {
        public string GetData()
        {
            return "test data";
        }
    }
}
