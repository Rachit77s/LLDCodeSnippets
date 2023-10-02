using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.JSONToXMLExample.Adaptee
{
    // Rachit: This is a 3rd party class/service class code which we need to integrate with our current code 
    public class LumiaJSONAdaptee
    {
        public string GetLumiaMobilesJSONSpecifications()
        {
            List<LumiaMobile> LumiaMobiles = new List<LumiaMobile>();

            LumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia550",
                Height = "136.1 mm",
                Width = "67.8 mm",
                Thickness = "9.9 mm",
                Weight = "141.9 g"
            });
            LumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia950",
                Height = "145 mm",
                Width = "73.2 mm",
                Thickness = "8.2 mm",
                Weight = "150 g"
            });
            LumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "Text",
                Height = "",
                Width = "",
                Thickness = "8.2 mm",
                Weight = "150 g"
            });

            dynamic collectionLumiaMobiles = new
                                            {
                                                lumiaMobiles = LumiaMobiles
                                            };

            return JsonConvert.SerializeObject(collectionLumiaMobiles);
        }
    }
}
