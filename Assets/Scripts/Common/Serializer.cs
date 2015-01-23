using System.IO;
using System.Xml.Serialization;

namespace Assets.Scripts.Common
{
    public static class Serializer
    {
        public static string Serialize(object input)
        {
            var serializer = new XmlSerializer(input.GetType());

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, input);

                return writer.ToString();
            }
        }

        public static T Deserialize<T>(string input)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = new StringReader(input))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}