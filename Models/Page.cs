using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PetShopMetrics.Models
{

    public record Page
    {
        public int Id { get; init; }
        public string Page_Url { get; init; }
        [JsonIgnore]
        public ICollection<PageSession> PageSessions { get; set; }
    }
}
