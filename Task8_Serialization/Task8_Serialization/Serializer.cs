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
        XmlSerializer serializer;
        XmlSerializerNamespaces namespaces;

        public Serializer()
        {
            serializer = new XmlSerializer(typeof(Catalog));
            namespaces = new XmlSerializerNamespaces();
        }

        public void SerializeToXml(Catalog details, string filePath)
        {
            namespaces.Add("", XmlFilesInfo.Namespace);
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, details, namespaces);
            }
        }

        public Catalog DeserializeFromXml(string filePath)
        {
            using (TextReader reader = new StreamReader(filePath))
            {
                return (Catalog)serializer.Deserialize(reader);
            }
        }
    }
}
