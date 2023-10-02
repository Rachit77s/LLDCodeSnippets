using AdapterDesignPattern.XMLToJSONExample.Adaptee;
using AdapterDesignPattern.XMLToJSONExample.HelperClass;
using AdapterDesignPattern.XMLToJSONExample.Model;
using AdapterDesignPattern.XMLToJSONExample.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.XMLToJSONExample.Adapter
{
    class XmlToJsonAdapter : IXmlToJson
    {
        public XmlConverter _xmlConverter { get; set; }

        public XmlToJsonAdapter(XmlConverter XmlConverter)
        {
            this._xmlConverter = XmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverter.GetXML()
                                             .Element("Manufacturers")
                                             .Elements("Manufacturer")
                                             .Select(m => new Manufacturer
                                             {
                                                 City = m.Attribute("City").Value,
                                                 Name = m.Attribute("Name").Value,
                                                 Year = Convert.ToInt32(m.Attribute("Year").Value)
                                             });

            new JsonConverter(manufacturers).ConvertToJson();
        }
    }
}
