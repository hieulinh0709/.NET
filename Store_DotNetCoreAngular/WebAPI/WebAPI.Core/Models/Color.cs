using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Core.Models
{
    public class Color
    {
        [Required]
        public int ColorId { get; set; }

        [Required]
        [StringLength(50)]
        public string ColorName { get; set; }

        public ICollection<ColorProduct> ColorProducts { get; set; }
    }
}
