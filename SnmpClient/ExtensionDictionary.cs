using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnmpClient
{
    public class ExtensionDictionary
    {
        public string key { get; set; }
        public string value { get; set; }
        public string type { get; set; }

        public ExtensionDictionary(string key, string value, string type)
        {
            this.key = key;
            this.value = value;
            this.type = type;
        }

    }
}
