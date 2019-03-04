 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobileLabs.DeviceConnect.RestApi
{
    public class DeviceMetricsQuery
    {
        public Guid Id { get; set; }
        public string Table { get; set; }
        public string Aggr { get; set; }
        public string Fields { get; set; }
        public string Marker { get; set; }
        public int? MarkerLimit { get; set; }
        public int? MarkerOffset { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string GroupBy { get; set; }
        public string OrderBy { get; set; }
        public string Format { get; set; }
        public string Filename { get; set; }
        public int? Timeout { get; set; }
    }
}
