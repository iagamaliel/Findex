using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class SpamVerdict
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
