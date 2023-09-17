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
        public string SendRequest(string yandexApiUrl)
        {
            //запрос к яндексу
            return "ok";
        }
    }
}
