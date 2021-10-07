using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public record Request
    {
        public int Id { get; set; }
        public DateTime DateAndTime { get; set; }
        public bool Response { get; set; }
    }
}
