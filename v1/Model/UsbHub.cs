 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class UsbHub
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Firmware { get; set; }
        public string FirmwareDate { get; set; }
        public TimeSpan Uptime { get; set; }
        public double FiveVoltNow { get; set; }
        public double FiveVoltMin { get; set; }
        public double FiveVoltMax { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrored { get; set; }
        public UsbHubDevice[] Devices { get; set; }
    }
}
