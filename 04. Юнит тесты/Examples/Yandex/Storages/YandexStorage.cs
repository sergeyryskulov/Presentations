﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Yandex.Interfaces;
using Yandex.Models;

namespace Yandex.Storages
{
    public class YandexStorage
    {
        private IYandexContext _context;

        public YandexStorage(IYandexContext context)
        {
            _context = context;
        }

        public async Task<YandexOrderModel> GetOrderAsync(int id)
        {
            string yandexOrderNotParsed = await _context.SendRequestAsync("https://business.taxi.yandex.ru/api/order/" + id);

            var objectForParse = JObject.Parse(yandexOrderNotParsed);

            YandexOrderModel yandexOrderParsed = new YandexOrderModel();

            yandexOrderParsed.Id = int.Parse(objectForParse["id"].ToString());

            yandexOrderParsed.Status = objectForParse["status"].ToString();

            return yandexOrderParsed;
        }
    }
}
