namespace Findex.Utils
{
    public class DataEmail
    {
        public bool Spam { get; set; }
        public bool Virus { get; set; }
        public bool Dns { get; set; }
        public string Mes { get; set; }
        public bool Retrasado { get; set; }
        public string Emisor { get; set; }
        public List<string> Receptor { get; set; }
    }
}
