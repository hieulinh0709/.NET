using System;
using System.Collections.Generic;
using WebAPI.Core.Enum;

namespace WebAPI.Core.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int Type { get; set; }
        public Status Status { get; set; }
        public double SubTotal { get; set; }
        public double ItemDisCount { get; set; }
        public double Tax { get; set; }
        public double Shipping { get; set; }
        public double Total { get; set; }
        public double Promo { get; set; }
        public double Discount { get; set; }
        public double GrandTotal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }
        public UserApplication User { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }



    }
}
