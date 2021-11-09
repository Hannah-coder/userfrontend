using System;

namespace PetShopMetrics.Models
{
    public record ServerInformation
    {
        public int Id { get; set; }
        public long Uptime { get; set; }
        public string RuntimeVersion { get; set; }
        public string OSVersion { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}