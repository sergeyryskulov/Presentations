using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifyVariant1.Constants.Enums;

namespace NotifyVariant1.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public OrderStatus Status { get; set; }

        public string Description { get; set; }

        public string InitiatorMail { get; set; }
    }
}
