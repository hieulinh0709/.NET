using System.Collections.Generic;

namespace WebAPI.Core.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Items { get; set; }
        public string Type { get; set; }
        public string Desciption { get; set; }
        public string Number { get; set; }

        public ICollection<ProductStock> ProductStock { get; set; }
    }
}
