using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class ApplicationDeviceReadyState
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public DeviceAvailabilityStatus Availability { get; set; }
        public bool IsProvisioned { get; set; }
        public string[] ProvisioningErrors { get; set; }
        public bool Enabled { get; set; }
        public string RetainedById { get; set; }
    }
}
