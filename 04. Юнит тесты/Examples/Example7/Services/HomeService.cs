using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example6.Models;
using Example6.Repository;


namespace Example6.Services
{
    public class HomeService
    {
        private ITestRepository _testRepository;

        public HomeService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public HomeViewModel GetHomeViewModel()
        {
            return new HomeViewModel()
            {
                Message = _testRepository.Test()
            };
        }
    }
}
