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
        /// <summary>
        /// Fetch the list of applications stored in GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetApplication&apos;.
        /// </summary>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of ApplicationProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

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

        /// <summary>
        /// Fetch the list of applications stored in GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetApplication&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<Application[]> GetApplicationAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<Application[]>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        /// <summary>
        /// Update the stored application.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UpdateApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to update.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of ApplicationProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

        public static Task UpdateApplicationAsync(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJsonAsync<Dictionary<string, string>>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false, cancel);
        }

        /// <summary>
        /// Delete an application so that it is no longer stored by GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;DeleteApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to delete.</param>
        /// <param name="all">If set to true, all applications with the same identifier are deleted. If set to false or excluded, only the application specified by id is deleted.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task DeleteApplicationAsync(this MobileLabsApi api, Guid id, bool? all, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("all", all == null ? null : all.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Delete an application so that it is no longer stored by GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;DeleteApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to delete.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task DeleteApplicationAsync(this MobileLabsApi api, Guid id, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Upload an application to be stored by GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;AddApplication&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<Application> AddApplicationAsync(this MobileLabsApi api, string filename, CancellationToken cancel)
        {
            return api.PostFileAsync<Application>("/Application?add",
                filename,
                true, cancel);
        }

        /// <summary>
        /// Install a GigaFox stored application to a device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;InstallApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to install.</param>
        /// <param name="deviceId">The device to install the application to.</param>
        /// <param name="force">
        /// If set to true, any existing copy of the application is uninstalled and all user data for it is deleted. This may be required
        /// when changing signing certificates on iOS or Android. If false or excluded, a normal application installation is attempted.
        /// </param>
        /// <param name="nativeAutomation">
        /// If set to true, the application is installed ready for using native automation with Trust automation.
        /// If false or excluded, the application is installed normally.
        /// </param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task InstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, bool? force, bool? nativeAutomation, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("force", force == null ? null : force.ToString()),
                    new KeyValuePair<string, string>("nativeAutomation", nativeAutomation == null ? null : nativeAutomation.ToString()),
                },
                true, cancel);
        }

        /// <summary>
        /// Install a GigaFox stored application to a device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;InstallApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to install.</param>
        /// <param name="deviceId">The device to install the application to.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task InstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                true, cancel);
        }

        /// <summary>
        /// Uninstall a GigaFox stored application from a given device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UninstallApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        /// <param name="removedata">If set to true or excluded, the user data for the application is removed. If set to false, the application data is preserved. This would be any files that the application has stored.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UninstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, bool removedata, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("removedata", removedata.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Uninstall a GigaFox stored application from a given device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UninstallApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UninstallApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                false, cancel);
        }

        /// <summary>
        /// Uninstall an application by bundle ID from a given device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UninstallBundleApplication&apos;.
        /// </summary>
        /// <param name="bundleId">The bundle id of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        /// <param name="removedata">If set to true or excluded, the user data for the application is removed. If set to false, the application data is preserved. This would be any files that the application has stored.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UninstallBundleApplicationAsync(this MobileLabsApi api, string bundleId, string deviceId, bool removedata, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "UninstallBundle"),
                    new KeyValuePair<string, string>("bundleId", bundleId),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("removedata", removedata.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Uninstall an application by bundle ID from a given device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UninstallBundleApplication&apos;.
        /// </summary>
        /// <param name="bundleId">The bundle id of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UninstallBundleApplicationAsync(this MobileLabsApi api, string bundleId, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "UninstallBundle"),
                    new KeyValuePair<string, string>("bundleId", bundleId),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                false, cancel);
        }

        /// <summary>
        /// Launch an application that is installed on a device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;LaunchApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to launch.</param>
        /// <param name="deviceId">The device to launch the application on.</param>
        /// <param name="startOnly">If set to true, no instrumentation is performed on the application.</param>
        /// <param name="arguments">The arguments to send to &quot;am start&quot; on Android.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task LaunchApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, bool startOnly, string arguments, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Launch"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("startOnly", startOnly.ToString()),
                    new KeyValuePair<string, string>("arguments", arguments),
                },
                true, cancel);
        }

        /// <summary>
        /// Launch an application that is installed on a device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;LaunchApplication&apos;.
        /// </summary>
        /// <param name="id">The ID of the application to launch.</param>
        /// <param name="deviceId">The device to launch the application on.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task LaunchApplicationAsync(this MobileLabsApi api, Guid id, string deviceId, CancellationToken cancel)
        {
            return api.PostAsync("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Launch"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                },
                true, cancel);
        }

        /// <summary>Fetch the list of applications stored in GigaFox.</summary>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of ApplicationProperties with associated values to filter by.</param>

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

        /// <summary>Fetch the list of applications stored in GigaFox.</summary>
        public static Application[] GetApplication(this MobileLabsApi api)
        {
            return api.Request<Application[]>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }

        /// <summary>Update the stored application.</summary>
        /// <param name="id">The ID of the application to update.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of ApplicationProperties with associated values to filter by.</param>

        public static void UpdateApplication(this MobileLabsApi api, Guid id, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            api.PostJson<Dictionary<string, string>>("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                },
                propertiesQuery,
                false);
        }

        /// <summary>Delete an application so that it is no longer stored by GigaFox.</summary>
        /// <param name="id">The ID of the application to delete.</param>
        /// <param name="all">If set to true, all applications with the same identifier are deleted. If set to false or excluded, only the application specified by id is deleted.</param>
        public static void DeleteApplication(this MobileLabsApi api, Guid id, bool? all)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("all", all == null ? null : all.ToString()),
                }, false);
        }

        /// <summary>Delete an application so that it is no longer stored by GigaFox.</summary>
        /// <param name="id">The ID of the application to delete.</param>
        public static void DeleteApplication(this MobileLabsApi api, Guid id)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id.ToString()),
                }, false);
        }

        /// <summary>Upload an application to be stored by GigaFox.</summary>
        public static Application AddApplication(this MobileLabsApi api, string filename)
        {
            return api.PostFile<Application>("/Application?add",
                filename,
                true);
        }

        /// <summary>Install a GigaFox stored application to a device.</summary>
        /// <param name="id">The ID of the application to install.</param>
        /// <param name="deviceId">The device to install the application to.</param>
        /// <param name="force">
        /// If set to true, any existing copy of the application is uninstalled and all user data for it is deleted. This may be required
        /// when changing signing certificates on iOS or Android. If false or excluded, a normal application installation is attempted.
        /// </param>
        /// <param name="nativeAutomation">
        /// If set to true, the application is installed ready for using native automation with Trust automation.
        /// If false or excluded, the application is installed normally.
        /// </param>
        public static void InstallApplication(this MobileLabsApi api, Guid id, string deviceId, bool? force, bool? nativeAutomation)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("force", force == null ? null : force.ToString()),
                    new KeyValuePair<string, string>("nativeAutomation", nativeAutomation == null ? null : nativeAutomation.ToString()),
                }, true);
        }

        /// <summary>Install a GigaFox stored application to a device.</summary>
        /// <param name="id">The ID of the application to install.</param>
        /// <param name="deviceId">The device to install the application to.</param>
        public static void InstallApplication(this MobileLabsApi api, Guid id, string deviceId)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Install"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, true);
        }

        /// <summary>Uninstall a GigaFox stored application from a given device.</summary>
        /// <param name="id">The ID of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        /// <param name="removedata">If set to true or excluded, the user data for the application is removed. If set to false, the application data is preserved. This would be any files that the application has stored.</param>
        public static void UninstallApplication(this MobileLabsApi api, Guid id, string deviceId, bool removedata)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("removedata", removedata.ToString()),
                }, false);
        }

        /// <summary>Uninstall a GigaFox stored application from a given device.</summary>
        /// <param name="id">The ID of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        public static void UninstallApplication(this MobileLabsApi api, Guid id, string deviceId)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Uninstall"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, false);
        }

        /// <summary>Uninstall an application by bundle ID from a given device.</summary>
        /// <param name="bundleId">The bundle id of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        /// <param name="removedata">If set to true or excluded, the user data for the application is removed. If set to false, the application data is preserved. This would be any files that the application has stored.</param>
        public static void UninstallBundleApplication(this MobileLabsApi api, string bundleId, string deviceId, bool removedata)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "UninstallBundle"),
                    new KeyValuePair<string, string>("bundleId", bundleId),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("removedata", removedata.ToString()),
                }, false);
        }

        /// <summary>Uninstall an application by bundle ID from a given device.</summary>
        /// <param name="bundleId">The bundle id of the application to uninstall.</param>
        /// <param name="deviceId">The device to uninstall the application from.</param>
        public static void UninstallBundleApplication(this MobileLabsApi api, string bundleId, string deviceId)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "UninstallBundle"),
                    new KeyValuePair<string, string>("bundleId", bundleId),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, false);
        }

        /// <summary>Launch an application that is installed on a device.</summary>
        /// <param name="id">The ID of the application to launch.</param>
        /// <param name="deviceId">The device to launch the application on.</param>
        /// <param name="startOnly">If set to true, no instrumentation is performed on the application.</param>
        /// <param name="arguments">The arguments to send to &quot;am start&quot; on Android.</param>
        public static void LaunchApplication(this MobileLabsApi api, Guid id, string deviceId, bool startOnly, string arguments)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Launch"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("startOnly", startOnly.ToString()),
                    new KeyValuePair<string, string>("arguments", arguments),
                }, true);
        }

        /// <summary>Launch an application that is installed on a device.</summary>
        /// <param name="id">The ID of the application to launch.</param>
        /// <param name="deviceId">The device to launch the application on.</param>
        public static void LaunchApplication(this MobileLabsApi api, Guid id, string deviceId)
        {
            api.Post("/Application",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Launch"),
                    new KeyValuePair<string, string>("id", id.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                }, true);
        }
    }
}
