using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example4.Context;
using Example4.Models;
using Newtonsoft.Json.Linq;

namespace Example4.Repositories
{
    public class YandexRepository
    {

        private IYandexContext _context;

        public YandexRepository(IYandexContext context)
        {
            _context = context;
        }

        public YandexOrderModel GetOrder(int id)
        {
             string yandexOrderNotParsed = _context.SendRequest("https://business.taxi.yandex.ru/api/order/" + id);

             var objectForParse = JObject.Parse(yandexOrderNotParsed);
             
             YandexOrderModel yandexOrderParsed = new YandexOrderModel();

             yandexOrderParsed.Id = int.Parse(objectForParse["id"].ToString());

             yandexOrderParsed.Status= objectForParse["status"].ToString();

             return yandexOrderParsed;
        }
    }
}
