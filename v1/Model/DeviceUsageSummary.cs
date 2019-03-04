 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class DeviceUsageSummary
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public string DeviceName { get; set; }
        public Guid? PerformedById { get; set; }
        public string PerformedByName { get; set; }
        public Guid? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public Guid? ReservedById { get; set; }
        public string ReservedByName { get; set; }
        public EventType EventType { get; set; }
        public DeviceOperatingSystem OperatingSystem { get; set; }
        public string OperatingSystemVersion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsDirty { get; set; }
    }
}
