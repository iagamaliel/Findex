using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class DkimVerdict
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
