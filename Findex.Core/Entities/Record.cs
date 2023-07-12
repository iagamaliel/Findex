using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class Record
    {
        [JsonPropertyName("eventVersion")]
        public string EventVersion { get; set; }

        [JsonPropertyName("ses")]
        public Ses Ses { get; set; }

        [JsonPropertyName("eventSource")]
        public string EventSource { get; set; }
    }
}
