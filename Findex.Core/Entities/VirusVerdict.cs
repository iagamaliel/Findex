using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class VirusVerdict
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
