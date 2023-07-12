using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class SpfVerdict
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
