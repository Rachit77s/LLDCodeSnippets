using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.XMLToJSONExample.Target
{
    // https://code-maze.com/adapter/
    public interface IXmlToJson
    {
        void ConvertXmlToJson();
    }
}
