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
    public static class UserEndPoints
    {

        public static Task<User[]> GetUserAsync(this MobileLabsApi api, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJsonAsync<User[]>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                propertiesQuery,
                false, cancel);
        }

        public static Task<User[]> GetUserAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<User[]>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }


        public static Task<OperationResult> UpdateUserAsync(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJsonAsync<OperationResult, Dictionary<string, string>>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false, cancel);
        }

        public static Task<OperationResult> AddUserAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("add", ""),
                },
                false, cancel);
        }


        public static User[] GetUser(this MobileLabsApi api, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJson<User[]>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                propertiesQuery,
                false);
        }

        public static User[] GetUser(this MobileLabsApi api)
        {
            return api.Request<User[]>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }


        public static OperationResult UpdateUser(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJson<OperationResult, Dictionary<string, string>>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false);
        }

        public static OperationResult AddUser(this MobileLabsApi api)
        {
            return api.Post<OperationResult>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("add", ""),
                }, false);
        }
    }
}
