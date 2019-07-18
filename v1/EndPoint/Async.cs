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
    public static class AsyncEndPoints
    {
        /// <summary>
        /// Query an async result&apos;s state. See Async for more information.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetAsync&apos;.
        /// </summary>
        /// <param name="id">The async ID.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<AsyncStatusModel> GetAsyncAsync(this MobileLabsApi api, Guid id, CancellationToken cancel)
        {
            return api.RequestAsync<AsyncStatusModel>("/Async",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                false, cancel);
        }

        /// <summary>Query an async result&apos;s state. See Async for more information.</summary>
        /// <param name="id">The async ID.</param>
        public static AsyncStatusModel GetAsync(this MobileLabsApi api, Guid id)
        {
            return api.Request<AsyncStatusModel>("/Async",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                }, false);
        }
    }
}
