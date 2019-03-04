 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class Application
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string ApplicationIdentifier { get; set; }
        public string Version { get; set; }
        public string BuildVersion { get; set; }
        public DeviceOperatingSystem OperatingSystem { get; set; }
        public string MinimumOperatingSystemVersion { get; set; }
        public string ApplicationBlob { get; set; }
        public string OriginalApplicationBlob { get; set; }
        public string FileName { get; set; }
        public int RemotePort { get; set; }
        public int VersionCounter { get; set; }
        public string IconBlob { get; set; }
        public long FileByteCount { get; set; }
        public string VendorApplicationName { get; set; }
        public DateTime? ProvisionExpirationDate { get; set; }
        public bool ProvisionsAllDevices { get; set; }
        public string SigningCertificateName { get; set; }
        public DateTime? SigningCertificateExpirationDate { get; set; }
        public bool IsSigningCertificatePresentInEmbeddedProvisionProfile { get; set; }
        public ApplicationFormFactor SupportedFormFactors { get; set; }
        public string[] ApplicationErrors { get; set; }
        public bool Enabled { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string AppTeamIdentifier { get; set; }
        public string TrustDylibTeamIdentifier { get; set; }
        public bool IsTrustDylibEmbeddedInApp { get; set; }
        public string Notes { get; set; }
        public string AgentHash { get; set; }
    }
}
