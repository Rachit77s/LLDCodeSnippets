using AdapterDesignPattern.JSONToXMLExample.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern.JSONToXMLExample.ClientCode
{
    public class MyLumiaClient
    {
        private ILumiaXMLTarget _lumiaXmlTarget;
        public MyLumiaClient(ILumiaXMLTarget lumiaXmlTarget)
        {
            _lumiaXmlTarget = lumiaXmlTarget;
        }
        public XmlDocument GetLumiaData()
        {
            return _lumiaXmlTarget.GetLumiaMobilesXMLSpecifications();
        }
    }
}
