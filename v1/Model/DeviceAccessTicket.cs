using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class DeviceAccessTicket
    {
        public string Authenticator { get; set; }
        public string GatewayAddress { get; set; }
        public int GatewayPort { get; set; }
        public string DeviceVendorUniqueIdentifier { get; set; }
        public long SerialNumber { get; set; }
    }
}
