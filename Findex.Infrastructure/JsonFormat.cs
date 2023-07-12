using Findex.Core.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Findex.Utils
{
    [TypeConverter(typeof(SourceClassConverter))]
    public class JsonFormat
    {
        [Required(ErrorMessage = "The Record is requiered")]
        [JsonPropertyName("Records")]
        public List<Record> Records
        {
            get; set;
        }
    }
}
