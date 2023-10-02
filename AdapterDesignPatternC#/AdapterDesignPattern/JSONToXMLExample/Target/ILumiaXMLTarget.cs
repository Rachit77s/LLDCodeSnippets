using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern.JSONToXMLExample.Target
{
    // https://www.c-sharpcorner.com/UploadFile/efa3cf/adapter-design-pattern-in-C-Sharp/

    public interface ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobilesXMLSpecifications();
    }
}
