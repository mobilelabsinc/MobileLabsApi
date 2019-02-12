using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class DeviceProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public DevicePropertyType Type { get; set; }
    }
}
