using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class Mail
    {
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("messageId")]
        public string MessageId { get; set; }

        [JsonPropertyName("destination")]
        public string[] Destination { get; set; }

        [JsonPropertyName("headersTruncated")]
        public bool HeadersTruncated { get; set; }

        [JsonPropertyName("headers")]
        public List<Header> Headers { get; set; }

        [JsonPropertyName("commonHeaders")]
        public CommonHeaders CommonHeaders { get; set; }
    }
}
