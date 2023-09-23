using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class HomeService : IHomeService
    {
        private IMyStorage _testStorage;

        public HomeService(IMyStorage testStorage)
        {
            _testStorage = testStorage;
        }

        public string MyMethod()
        {
            return _testStorage.GetData();
        }
    }
}
