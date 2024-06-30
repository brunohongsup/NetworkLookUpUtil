using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLookUp
{
    internal class NetworkAdapterDesc
    {
        public System.Net.NetworkInformation.NetworkInterface? Adapter { get; set; }

        public string Desc { get;  set; } = string.Empty;    
    }
}
