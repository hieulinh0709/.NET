using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Models
{
    public class ProductStock
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }
    }
}
