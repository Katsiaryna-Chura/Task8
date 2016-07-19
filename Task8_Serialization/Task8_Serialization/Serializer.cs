using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8_Serialization
{
    class Serializer
    {
        public void SerializeToXml(Catalog details, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", XmlFilesInfo.Namespace);
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, details, namespaces);
            }
        }

        public Catalog DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (Catalog)serializer.Deserialize(reader);
            }
        }
    }
}
