 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class Event
    {
        public int Id { get; set; }
        public Guid? DeviceId { get; set; }
        public string DeviceName { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventDate { get; set; }
        public Guid? PerformedById { get; set; }
        public string PerformedByName { get; set; }
        public int IntValue { get; set; }
        public bool BoolValue { get; set; }
        public string StringValue { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Guid? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public Guid? UserId { get; set; }
        public int DeviceInuseCount { get; set; }
        public int DeviceOnlineCount { get; set; }
    }
}
