using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Core.Models
{
    public class RoleApplication : IdentityRole<int>
    {
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
