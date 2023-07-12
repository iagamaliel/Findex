using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class Ses
    {
        [JsonPropertyName("receipt")]
        public Receipt Receipt { get; set; }

        [JsonPropertyName("mail")]
        public Mail Mail { get; set; }
    }
}
