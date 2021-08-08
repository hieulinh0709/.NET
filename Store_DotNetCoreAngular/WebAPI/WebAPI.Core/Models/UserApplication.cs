using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using WebAPI.Core.Enum;

namespace WebAPI.Core.Models
{
    public class UserApplication : IdentityUser<int>
    {
        public Title Title { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public string Avatar { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public int Cash { get; set; }

        public int CreditCard { get; set; }
    }
}
