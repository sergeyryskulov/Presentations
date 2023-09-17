using NotifyVariant2.Constants.Enums;

namespace NotifyVariant2.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public OrderStatus Status { get; set; }

        public string InitiatorMail { get; set; }
    }
}
