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
        /*
            Start looking from the Adaptee class, LumiaJSONAdaptee.cs
            LumiaJSONAdaptee.cs is the class that we want to use in our client code.
            But, it is not compatible with our client code.
            So, we need to create an adapter class that will make 
            LumiaJSONAdaptee.cs compatible with our client code.
            LumiaJSONAdapter.cs is the concrete adapter class that we will create.

            We will create an interface, ILumiaXMLTarget.cs, that will be implemented by the
            LumiaXMLAdapter.cs class. The client code will interact with the ILumiaXMLTarget.cs

            The client will interact with the ILumiaXMLTarget.cs interface and the class that implements
            the ILumiaXMLTarget.cs interface is LumiaXMLAdapter.cs. 
            LumiaXMLAdapter.cs will interact with the Adaptee class and get the required conversion done.

            
            We have Adaptee class which returns JSON Data. This is 3rd party class code.
            And the client wants the data in XML. But the client cannot directly interact with Adaptee class
            as Adaptee class return the JSON Data, however, client demands it in XML.
            Therefore, we will create an Adapter interface and the client class will interact with Adapter interface.
            In the Adapter interface we will put the methods that client demands(GetXMLData), and we will
            create a ConcreteAdapter class that will directly talk with the Adaptee class(3rd party code) and
            convert the JSON data to XML data and serve it to the client class.

        */
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
