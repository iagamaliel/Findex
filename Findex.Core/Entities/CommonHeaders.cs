using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class CommonHeaders
    {
        [JsonPropertyName("returnPath")]
        public string ReturnPath { get; set; }

        [JsonPropertyName("from")]
        public List<string> From { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("to")]
        public List<string> To { get; set; }

        [JsonPropertyName("messageId")]
        public string MessageId { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    }
}
