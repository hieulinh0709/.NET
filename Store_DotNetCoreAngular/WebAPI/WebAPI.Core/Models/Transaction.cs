using System;

namespace WebAPI.Core.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string Code { get; set; }
        public int Type { get; set; }
        public int Mode { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Content { get; set; }
    }
}
