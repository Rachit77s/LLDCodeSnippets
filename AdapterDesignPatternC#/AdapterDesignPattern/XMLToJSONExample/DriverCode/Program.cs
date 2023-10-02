using AdapterDesignPattern.XMLToJSONExample.Adaptee;
using AdapterDesignPattern.XMLToJSONExample.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.XMLToJSONExample.DriverCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rachit: Create 3rd party class/service class object
            var xmlConverter = new XmlConverter();

            // Rachit: Pass the 3rd party class/service class object to the Adapter class
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
        }
    }
}
