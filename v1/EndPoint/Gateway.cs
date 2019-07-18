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
        /// <summary>
        /// Change the port state to usbHubPort for the port number given as
        /// usbHubPort on the USB hub given as a serial number in id.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UpdateGatewayUsbHub&apos;.
        /// </summary>
        /// <param name="id">The serial number for the USB hub.</param>
        /// <param name="usbHubPort">The numerical port number of the USB hub port to change.</param>
        /// <param name="usbHubPortState">The state to transition the port to.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UpdateGatewayUsbHubAsync(this MobileLabsApi api, string id, int? usbHubPort, string usbHubPortState, CancellationToken cancel)
        {
            return api.PostAsync("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPort", usbHubPort == null ? null : usbHubPort.ToString()),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                },
                false, cancel);
        }

        /// <summary>
        /// Change the port state to usbHubPort for the port number given as
        /// usbHubPort on the USB hub given as a serial number in id.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UpdateGatewayUsbHub&apos;.
        /// </summary>
        /// <param name="id">The serial number for the USB hub.</param>
        /// <param name="usbHubPortState">The state to transition the port to.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UpdateGatewayUsbHubAsync(this MobileLabsApi api, string id, string usbHubPortState, CancellationToken cancel)
        {
            return api.PostAsync("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                },
                false, cancel);
        }

        /// <summary>
        /// Reboot a USB hub. This is a diagnostic action and should be rarely required.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;RebootGatewayUsbHub&apos;.
        /// </summary>
        /// <param name="id">The serial number of the USB hub to reboot.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task RebootGatewayUsbHubAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch information about the attached device gateways and any associated USB hubs and their attached devices.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetGateway&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<GatewayDescription[]> GetGatewayAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<GatewayDescription[]>("/Gateway",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        /// <summary>
        /// Change the port state to usbHubPort for the port number given as
        /// usbHubPort on the USB hub given as a serial number in id.
        /// </summary>
        /// <param name="id">The serial number for the USB hub.</param>
        /// <param name="usbHubPort">The numerical port number of the USB hub port to change.</param>
        /// <param name="usbHubPortState">The state to transition the port to.</param>
        public static void UpdateGatewayUsbHub(this MobileLabsApi api, string id, int? usbHubPort, string usbHubPortState)
        {
            api.Post("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPort", usbHubPort == null ? null : usbHubPort.ToString()),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                }, false);
        }

        /// <summary>
        /// Change the port state to usbHubPort for the port number given as
        /// usbHubPort on the USB hub given as a serial number in id.
        /// </summary>
        /// <param name="id">The serial number for the USB hub.</param>
        /// <param name="usbHubPortState">The state to transition the port to.</param>
        public static void UpdateGatewayUsbHub(this MobileLabsApi api, string id, string usbHubPortState)
        {
            api.Post("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                }, false);
        }

        /// <summary>Reboot a USB hub. This is a diagnostic action and should be rarely required.</summary>
        /// <param name="id">The serial number of the USB hub to reboot.</param>
        public static void RebootGatewayUsbHub(this MobileLabsApi api, string id)
        {
            api.Post("/Gateway/UsbHub",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Fetch information about the attached device gateways and any associated USB hubs and their attached devices.</summary>
        public static GatewayDescription[] GetGateway(this MobileLabsApi api)
        {
            return api.Request<GatewayDescription[]>("/Gateway",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }
    }
}
