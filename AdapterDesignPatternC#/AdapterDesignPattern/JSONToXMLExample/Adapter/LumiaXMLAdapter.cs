using AdapterDesignPattern.JSONToXMLExample.Adaptee;
using AdapterDesignPattern.JSONToXMLExample.Target;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern.JSONToXMLExample.Adapter
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public LumiaJSONAdaptee _lumiaJSONAdaptee { get; set; }

        public LumiaXMLAdapter(LumiaJSONAdaptee LumiaJSONAdaptee)
        {
            this._lumiaJSONAdaptee = LumiaJSONAdaptee;
        }

        //Convert JSON to XML
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            string jsonLumia = _lumiaJSONAdaptee.GetLumiaMobilesJSONSpecifications();
            
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMoblies", true);
            return doc;
        }
    }
}
