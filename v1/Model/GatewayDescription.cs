 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class GatewayDescription
    {
        public string ApiKey { get; set; }
        public string Name { get; set; }
        public string PublicAddress { get; set; }
        public int PublicPort { get; set; }
        public UsbHub[] UsbHubList { get; set; }
    }
}
