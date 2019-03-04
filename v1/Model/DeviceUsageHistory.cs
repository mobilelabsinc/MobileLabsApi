 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class DeviceUsageHistory
    {
        public int Count { get; set; }
        public DateTime? StartAt { get; set; }
        public int PageSize { get; set; }
        public DeviceUsageSummary[] DeviceUsage { get; set; }
    }
}
