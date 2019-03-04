 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class Device
    {
        public Guid Id { get; set; }
        public DeviceAvailabilityStatus Availability { get; set; }
        public Guid? RetainedById { get; set; }
        public string RetainedByDisplayName { get; set; }
        public bool Enabled { get; set; }
        public DeviceBatteryStatus BatteryStatus { get; set; }
        public int BatteryPercentCharged { get; set; }
        public long DiskSpace { get; set; }
        public int? SlotNumber { get; set; }
        public long DiskSpaceUsed { get; set; }
        public DateTime? NextReservationStartTime { get; set; }
        public DateTime? NextReservationEndTime { get; set; }
        public Guid? ReservedById { get; set; }
        public string ReservedByDisplayName { get; set; }
        public DateTime? LastInuseAt { get; set; }
        public DateTime? LastDisconnectedAt { get; set; }
        public DateTime? LastConnectedAt { get; set; }
        public bool Deleted { get; set; }
        public string Notes { get; set; }
        public string RetainedByUserName { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DeviceOperatingSystem OperatingSystem { get; set; }
        public string OperatingSystemVersion { get; set; }
        public string MacAddress { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string FriendlyModel { get; set; }
        public string VendorUniqueIdentifier { get; set; }
        public string VendorDeviceName { get; set; }
        public string DeviceClass { get; set; }
        public DeviceFormFactor FormFactor { get; set; }
        public string ProductType { get; set; }
        public bool IsAudioEnabled { get; set; }
        public string HardwareModel { get; set; }
        public string OperatingSystemBuild { get; set; }
        public string UsbHubSerialNumber { get; set; }
        public int? UsbHubPortNumber { get; set; }
        public string UsbLocation { get; set; }
        public string BluetoothAddress { get; set; }
        public DateTime? FirstConnectedAt { get; set; }
        public DateTime? LastRetainedAt { get; set; }
        public DeviceProperty[] Properties { get; set; }
        public Application[] InstalledApplications { get; set; }
    }
}
