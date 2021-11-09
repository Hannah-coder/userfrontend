using System;

namespace PetShopMetrics.Models
{

    public class MerchandiseFilter
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberRecordsReturned { get; set; }
    }
}
