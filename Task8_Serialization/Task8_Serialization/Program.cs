using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializer serializer = new Serializer();
            Catalog catalog = serializer.DeserializeFromXml(XmlFilesInfo.SourceFile);
            Console.WriteLine($"Information from file {XmlFilesInfo.SourceFile} has been deserialized to Catalog object\n");
            serializer.SerializeToXml(catalog, XmlFilesInfo.ResultFile);
            Console.WriteLine($"Catalog object has been serialized to file {XmlFilesInfo.ResultFile}\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
