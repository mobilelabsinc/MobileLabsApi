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
    public static class ServiceEndPoints
    {
        public static Task<AirStreamHubInformation> GetServiceAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<AirStreamHubInformation>("/Service",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        public static AirStreamHubInformation GetService(this MobileLabsApi api)
        {
            return api.Request<AirStreamHubInformation>("/Service",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }
    }
}
