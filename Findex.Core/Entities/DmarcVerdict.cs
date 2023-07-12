using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class DmarcVerdict
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
