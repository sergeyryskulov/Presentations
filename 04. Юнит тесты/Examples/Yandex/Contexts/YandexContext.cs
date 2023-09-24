using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex.Interfaces;

namespace Yandex.Contexts
{
    public class YandexContext : IYandexContext
    {
        public async Task<string> SendRequestAsync(string yandexApiUrl)
        {
            //запрос к яндексу
            await Task.Delay(100);            
            return "result data from yandex";
        }
    }
}
