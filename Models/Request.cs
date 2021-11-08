using System;

namespace PetShopMetrics.Models
{
    public record Request
    {
        public int Id { get; set; }
        public DateTime DateAndTime { get; set; }
        public bool Response { get; set; }
    }
}
