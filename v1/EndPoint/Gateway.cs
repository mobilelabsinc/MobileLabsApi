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
    public static class GatewayEndPoints
    {
        public static Task<OperationResult> UpdateGatewayUsbHubAsync(this MobileLabsApi api, string id, int? usbHubPort, string usbHubPortState, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPort", usbHubPort == null ? null : usbHubPort.ToString()),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                },
                false, cancel);
        }

        public static Task<OperationResult> UpdateGatewayUsbHubAsync(this MobileLabsApi api, string id, string usbHubPortState, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                },
                false, cancel);
        }

        public static Task<OperationResult> RebootGatewayUsbHubAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static Task<GatewayDescription[]> GetGatewayAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<GatewayDescription[]>("/Gateway",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        public static OperationResult UpdateGatewayUsbHub(this MobileLabsApi api, string id, int? usbHubPort, string usbHubPortState)
        {
            return api.Post<OperationResult>("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPort", usbHubPort == null ? null : usbHubPort.ToString()),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                }, false);
        }

        public static OperationResult UpdateGatewayUsbHub(this MobileLabsApi api, string id, string usbHubPortState)
        {
            return api.Post<OperationResult>("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                }, false);
        }

        public static OperationResult RebootGatewayUsbHub(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static GatewayDescription[] GetGateway(this MobileLabsApi api)
        {
            return api.Request<GatewayDescription[]>("/Gateway",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }
    }
}
