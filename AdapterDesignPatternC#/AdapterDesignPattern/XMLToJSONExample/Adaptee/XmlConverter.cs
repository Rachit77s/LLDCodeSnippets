using AdapterDesignPattern.XMLToJSONExample.Adaptee.ModelDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterDesignPattern.XMLToJSONExample.Adaptee
{
    // Rachit: This is a 3rd party class/service class code which we need to integrate with our current code 
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Manufacturers");
            var xAttributes = ManufacturerDataProvider.GetData()
                                                      .Select( m => new XElement("Manufacturer",
                                                                   new XAttribute("City", m.City),
                                                                   new XAttribute("Name", m.Name),
                                                                   new XAttribute("Year", m.Year))
                                                              );

            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            Console.WriteLine(xDocument);
            return xDocument;
        }
    }
}
