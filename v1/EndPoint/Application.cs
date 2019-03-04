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
    public static class ApplicationEndPoints
    {

        public static Task<Application[]> GetApplicationAsync(this MobileLabsApi api, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJsonAsync<Application[]>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                propertiesQuery,
                false, cancel);
        }

        public static Task<Application[]> GetApplicationAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<Application[]>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }


        public static Task<OperationResult> UpdateApplicationAsync(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJsonAsync<OperationResult, Dictionary<string, string>>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false, cancel);
        }

        public static Task<OperationResult> DeleteApplicationAsync(this MobileLabsApi api, Guid id, bool? all, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("all", all == null ? null : all.ToString()),
                },
                false, cancel);
        }

        public static Task<OperationResult> DeleteApplicationAsync(this MobileLabsApi api, Guid id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                false, cancel);
        }

        public static Task<OperationResult<Application>> AddApplicationAsync(this MobileLabsApi api, string filename, CancellationToken cancel)
        {
            return api.PostFileAsync<OperationResult<Application>>("/Application?add",
                filename,
                true, cancel);
        }

        public static Task<OperationResult> InstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, bool? force, bool? nativeAutomation, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("force", force == null ? null : force.ToString()),
                    new KeyValuePair<string, string>("nativeAutomation", nativeAutomation == null ? null : nativeAutomation.ToString()),
                },
                true, cancel);
        }

        public static Task<OperationResult> InstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                true, cancel);
        }

        public static Task<OperationResult> UninstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, bool? removedata, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("removedata", removedata == null ? null : removedata.ToString()),
                },
                false, cancel);
        }

        public static Task<OperationResult> UninstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                false, cancel);
        }

        public static Task<OperationResult> LaunchApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Launch"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                true, cancel);
        }


        public static Application[] GetApplication(this MobileLabsApi api, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJson<Application[]>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                propertiesQuery,
                false);
        }

        public static Application[] GetApplication(this MobileLabsApi api)
        {
            return api.Request<Application[]>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }


        public static OperationResult UpdateApplication(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJson<OperationResult, Dictionary<string, string>>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false);
        }

        public static OperationResult DeleteApplication(this MobileLabsApi api, Guid id, bool? all)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("all", all == null ? null : all.ToString()),
                }, false);
        }

        public static OperationResult DeleteApplication(this MobileLabsApi api, Guid id)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                }, false);
        }

        public static OperationResult<Application> AddApplication(this MobileLabsApi api, string filename)
        {
            return api.PostFile<OperationResult<Application>>("/Application?add",
                filename,
                true);
        }

        public static OperationResult InstallApplication(this MobileLabsApi api, Guid id, string deviceId, bool? force, bool? nativeAutomation)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("force", force == null ? null : force.ToString()),
                    new KeyValuePair<string, string>("nativeAutomation", nativeAutomation == null ? null : nativeAutomation.ToString()),
                }, true);
        }

        public static OperationResult InstallApplication(this MobileLabsApi api, Guid id, string deviceId)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, true);
        }

        public static OperationResult UninstallApplication(this MobileLabsApi api, Guid id, string deviceId, bool? removedata)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("removedata", removedata == null ? null : removedata.ToString()),
                }, false);
        }

        public static OperationResult UninstallApplication(this MobileLabsApi api, Guid id, string deviceId)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, false);
        }

        public static OperationResult LaunchApplication(this MobileLabsApi api, Guid id, string deviceId)
        {
            return api.Post<OperationResult>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Launch"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, true);
        }
    }
}
