using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8_Serialization
{
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlAttribute("date", DataType = "date")]
        public DateTime Date { get; set; }

        //[XmlIgnore]
        //public DateTime Date { get; set; }

        //[XmlAttribute("date")]
        //public string StringDate
        //{
        //    get { return this.Date.ToString("yyyy-MM-dd"); }
        //    set { this.Date = DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture); }
        //}

        [XmlElement("book")]
        public List<Book> BookList { get; set;}
    }
}
