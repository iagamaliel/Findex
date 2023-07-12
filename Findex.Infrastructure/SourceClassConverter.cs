using System.ComponentModel;
using System.Globalization;

namespace Findex.Utils
{
    public sealed class SourceClassConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(DataEmail);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            var concreteValue = (JsonFormat)value;
            var record = concreteValue.Records.FirstOrDefault();

            List<string> destinatarios = new();

            foreach (var email in record.Ses.Mail.Destination)
            {
                destinatarios.Add(email.IndexOf('@') > 0 ? email.Substring(0, email.IndexOf('@')): email);
            };

            var result = new DataEmail
            {
                Spam = record.Ses.Receipt.SpamVerdict.Status == "PASS",
                Virus = record.Ses.Receipt.VirusVerdict.Status == "PASS",
                Dns = (record.Ses.Receipt.SpfVerdict.Status == "PASS" && record.Ses.Receipt.DkimVerdict.Status == "PASS"
                && record.Ses.Receipt.DmarcVerdict.Status == "PASS"),
                Mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(record.Ses.Mail.Timestamp.Month),
                Retrasado = record.Ses.Receipt.ProcessingTimeMillis > 1000,
                Emisor = record.Ses.Mail.Source.IndexOf('@') > 0 ? record.Ses.Mail.Source.Substring(0, record.Ses.Mail.Source.IndexOf('@')) : record.Ses.Mail.Source,
                Receptor = destinatarios
            };

            return result;
        }
    }
}
