using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class Header
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
