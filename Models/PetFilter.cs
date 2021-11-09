using System;

namespace PetShopMetrics.Models
{
    public record PetFilter
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string FilterCriteria { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberRecordsReturned { get; set; }
    }
}
