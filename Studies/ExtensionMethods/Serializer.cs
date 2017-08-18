using System.IO;
using System.Xml.Serialization;

namespace ExtensionMethods
{
    class Serializer
    {
        public static string AsXml(Account acc)
        {
            var stringWriter = new StringWriter();
            new XmlSerializer(acc.GetType()).Serialize(stringWriter, acc);
            return stringWriter.ToString();
        }

    }
}