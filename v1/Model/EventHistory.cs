using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi.v1.Model
{
    public class EventHistory
    {
        public int Count { get; set; }
        public int PageSize { get; set; }
        public Event[] Events { get; set; }
    }
}
