using ApplicationLayer.Interfaces;
using DALLayer.Interfaces;

namespace ApplicationLayer.Services
{
    public class HomeService : IHomeService
    {
        private IDatabaseStorage _databaseStorage;

        public HomeService(IDatabaseStorage databaseStorage)
        {
            _databaseStorage = databaseStorage;
        }

        public string MyMethod()
        {
            return _databaseStorage.GetData();
        }
    }
}
