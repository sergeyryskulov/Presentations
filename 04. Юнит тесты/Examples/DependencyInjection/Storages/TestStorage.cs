using DependencyInjection.Interfaces;

namespace DependencyInjection.Storages
{
    public class TestStorage : IMyStorage
    {
        public string GetData()
        {
            return "test";
        }
    }
}
