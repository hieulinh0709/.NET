using System.Collections.Generic;

namespace WebAPI.Core.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public string Descripyion { get; set; }

        public int CustomerId { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
