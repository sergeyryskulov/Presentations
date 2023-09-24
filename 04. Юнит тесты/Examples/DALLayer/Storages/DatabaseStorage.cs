using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DALLayer.Interfaces;
[assembly: InternalsVisibleTo("DALLayer.IntegrationTests")]

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
