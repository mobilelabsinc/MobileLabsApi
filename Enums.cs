using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi
{
    public enum DeviceAvailabilityStatus
    {
        Offline = 0,
        Charging = 1,
        Online = 2,
    }

    public enum DeviceOperatingSystem
    {
        IOS = 0,
        Android = 1,
        Unknown = 2,
    }

    public enum ApplicationFormFactor
    {
        Universal = 0,
        Phone = 1,
        Tablet = 2,
    }

    public enum DevicePropertyType
    {
        System = 0,
        Phone = 1,
    }

    public enum DeviceBatteryStatus
    {
        Unknown = 0,
        Charging = 1,
        Discharging = 2,
        NotCharging = 3,
        Full = 4,
    }

    public enum DeviceFormFactor
    {
        Unknown = 0,
        Phone = 1,
        Tablet = 2,
    }

    public enum EventType
    {
        DeviceAvailability = 0,
        DeviceRetained = 1,
        DeviceEnablement = 2,
        DeviceOperatingSystemChange = 3,
        DeviceDeletion = 4,
        ApplicationLaunch = 100,
        ApplicationInstall = 101,
        UserLogin = 200,
        UserCreated = 201,
        ServerStarting = 300,
        ServerRestarting = 301,
        Note = 900,
    }

    public enum UsbHubPortState
    {
        Unknown = 0,
        Off = 1,
        Sync = 2,
        Charge = 3,
    }

    public enum UsbHubDeviceFlags
    {
        None = 0,
        Off = 1,
        Sync = 2,
        Biased = 4,
        ChargeIdle = 8,
        ChargeProfiling = 16,
        ChargeCharging = 32,
        ChargeFinished = 64,
        Attached = 128,
        Detached = 256,
        Errors = 512,
        Rebooted = 1024,
        VBusReset = 2048,
    }
}
