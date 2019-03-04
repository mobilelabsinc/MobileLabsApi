 // This is a generated file. Do not modify directly.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobileLabs.DeviceConnect.RestApi.v1.Model;

namespace MobileLabs.DeviceConnect.RestApi.v1.EndPoint
{
    public static class ReportEndPoints
    {
        public static Task<object> GetReportAsync(this MobileLabsApi api, string type, CancellationToken cancel)
        {
            return api.RequestAsync<object>("/Report",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("type", type),
                },
                false, cancel);
        }

        public static object GetReport(this MobileLabsApi api, string type)
        {
            return api.Request<object>("/Report",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("type", type),
                }, false);
        }
    }
}
