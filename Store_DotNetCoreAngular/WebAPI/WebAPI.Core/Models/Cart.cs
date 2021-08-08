using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Enum;

namespace WebAPI.Core.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string SessionId { get; set; }
        public string Token { get; set; }
        public Status Status { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string LineFirst { get; set; }
        public string LineSecond { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string Content { get; set; }
    }
}
