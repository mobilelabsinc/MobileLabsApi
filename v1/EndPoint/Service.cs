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
        /// <summary>
        /// Fetch GigaFox history service installation information.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetService&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<AirStreamHubInformation> GetServiceAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<AirStreamHubInformation>("/Service",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        /// <summary>Fetch GigaFox history service installation information.</summary>
        public static AirStreamHubInformation GetService(this MobileLabsApi api)
        {
            return api.Request<AirStreamHubInformation>("/Service",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }
    }
}
