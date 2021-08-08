using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Core.Models
{
    public class Category
    {
        #region properties
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Order { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public ICollection<Product> Products { get; set; }
        #endregion properties
    }
}
