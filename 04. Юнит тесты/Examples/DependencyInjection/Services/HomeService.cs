﻿using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class HomeService : IHomeService
    {
        private IDatabaseStorage _databaseStorage;

        public HomeService(IDatabaseStorage testStorage)
        {
            _databaseStorage = testStorage;
        }

        public string MyMethod()
        {
            return _databaseStorage.GetData();
        }
    }
}
