using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PetShopMetrics.Models
{
    public record Session
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [JsonIgnore]
        public ICollection<PageSession> PageSessions { get; set; }
    }
}
