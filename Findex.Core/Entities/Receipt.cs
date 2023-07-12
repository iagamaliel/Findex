using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class Receipt
    {
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("processingTimeMillis")]
        public int ProcessingTimeMillis { get; set; }

        [JsonPropertyName("recipients")]
        public List<string> Recipients { get; set; }

        [JsonPropertyName("spamVerdict")]
        public SpamVerdict SpamVerdict { get; set; }

        [JsonPropertyName("virusVerdict")]
        public VirusVerdict VirusVerdict { get; set; }

        [JsonPropertyName("spfVerdict")]
        public SpfVerdict SpfVerdict { get; set; }

        [JsonPropertyName("dkimVerdict")]
        public DkimVerdict DkimVerdict { get; set; }

        [JsonPropertyName("dmarcVerdict")]
        public DmarcVerdict DmarcVerdict { get; set; }

        [JsonPropertyName("dmarcPolicy")]
        public string DmarcPolicy { get; set; }

        [JsonPropertyName("action")]
        public Action Action { get; set; }
    }
}
