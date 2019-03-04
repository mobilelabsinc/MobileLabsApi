 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class UsbHubDevice
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string SerialNumber { get; set; }
        public string UsbHubSerialNumber { get; set; }
        public int UsbHubPortNumber { get; set; }
        public int Milliamps { get; set; }
        public UsbHubPortState State { get; set; }
        public UsbHubDeviceFlags Flags { get; set; }
        public TimeSpan ChargingTime { get; set; }
        public string ChargingProfile { get; set; }
    }
}
