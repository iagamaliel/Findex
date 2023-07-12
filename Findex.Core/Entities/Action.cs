using System.Text.Json.Serialization;

namespace Findex.Core.Entities
{
    public class Action
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("topicArn")]
        public string TopicArn { get; set; }
    }
}
