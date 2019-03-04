 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class AirStreamHubInformation
    {
        public string DeviceConnectNodeId { get; set; }
        public string DeviceConnectVersion { get; set; }
        public DateTime SystemDateTime { get; set; }
        public DateTime SystemDateTimeUtc { get; set; }
        public AirStreamGatewayInformation[] GatewayInformation { get; set; }
    }
}
