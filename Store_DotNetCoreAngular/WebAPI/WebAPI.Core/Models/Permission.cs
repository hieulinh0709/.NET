using System.Collections.Generic;

namespace WebAPI.Core.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Title { get; set; }
        public string Module { get; set; }
        public string Description { get; set; }

        public int RoleId { get; set; }
        public RoleApplication Role { get; set; }

        public int SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
