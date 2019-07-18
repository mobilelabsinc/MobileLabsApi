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
        /// <summary>
        /// Fetch the list of GigaFox users.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetUser&apos;.
        /// </summary>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of UserProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

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

        /// <summary>
        /// Fetch the list of GigaFox users.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetUser&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<User[]> GetUserAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<User[]>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        /// <summary>
        /// Modify a specified user record.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UpdateUser&apos;.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of UserProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

        public static Task UpdateUserAsync(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJsonAsync<Dictionary<string, string>>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false, cancel);
        }

        /// <summary>
        /// Create a new GigaFox user.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;AddUser&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task AddUserAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.PostAsync("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("add", ""),
                },
                false, cancel);
        }

        /// <summary>Fetch the list of GigaFox users.</summary>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of UserProperties with associated values to filter by.</param>

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

        /// <summary>Fetch the list of GigaFox users.</summary>
        public static User[] GetUser(this MobileLabsApi api)
        {
            return api.Request<User[]>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }

        /// <summary>Modify a specified user record.</summary>
        /// <param name="id">The ID of the user.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of UserProperties with associated values to filter by.</param>

        public static void UpdateUser(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            api.PostJson<Dictionary<string, string>>("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false);
        }

        /// <summary>Create a new GigaFox user.</summary>
        public static void AddUser(this MobileLabsApi api)
        {
            api.Post("/User",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("add", ""),
                }, false);
        }
    }
}
