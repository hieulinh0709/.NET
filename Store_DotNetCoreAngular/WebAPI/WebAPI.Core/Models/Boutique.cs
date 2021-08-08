using System.Collections.Generic;

namespace WebAPI.Core.Models
{
    public class Boutique
    {
        public int BoutiqueId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
