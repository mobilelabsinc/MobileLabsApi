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
        public static Task<AsyncStatusModel> GetAsyncAsync(this MobileLabsApi api, Guid id, CancellationToken cancel)
        {
            return api.RequestAsync<AsyncStatusModel>("/Async",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                false, cancel);
        }

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
