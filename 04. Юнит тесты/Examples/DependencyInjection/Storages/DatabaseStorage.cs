using DependencyInjection.Interfaces;

namespace DependencyInjection.Storages
{
    public class DatabaseStorage : IDatabaseStorage
    {
        public string GetData()
        {
            return "test";
        }
    }
}
