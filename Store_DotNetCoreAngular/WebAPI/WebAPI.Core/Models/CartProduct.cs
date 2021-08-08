using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Enum;

namespace WebAPI.Core.Models
{
    public class CartProduct
    {
        public int CartProductId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public string Sku { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
    }
}
