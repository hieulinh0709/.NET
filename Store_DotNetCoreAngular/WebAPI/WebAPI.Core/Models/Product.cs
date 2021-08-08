using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Core.Models
{
    public class Product
    {
        #region properties
        public int ProductId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string PhotoFileName { get; set; }

        [Required]
        public double Price { get; set; }

        public double SalePrice { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StoreDate { get; set; }

        public int StoreInventory { get; set; }

        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        public int BoutiqueId { get; set; }
        public Boutique Boutique { get; set; }

        public ICollection<Picture> Pictures { get; set; }
        public ICollection<ProductStock> ProductStocks { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public ICollection<CartProduct> CartProducts { get; set; }
        public ICollection<ColorProduct> ColorProducts { get; set; }

        #endregion properties
    }
}
