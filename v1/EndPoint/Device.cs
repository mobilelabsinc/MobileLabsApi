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
    public static class DeviceEndPoints
    {
        public static Task<Device[]> GetDeviceAsync(this MobileLabsApi api, bool? properties, bool? applications, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                },
                false, cancel);
        }

        public static Device[] GetDevice(this MobileLabsApi api, bool? properties, bool? applications)
        {
            return api.Request<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                }, false);
        }

        public static Task<Device[]> GetDeviceAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        public static Device[] GetDevice(this MobileLabsApi api)
        {
            return api.Request<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }

        public static Task<Device[]> GetDeviceAvailableAsync(this MobileLabsApi api, bool? properties, bool? applications, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                },
                false, cancel);
        }

        public static Device[] GetDeviceAvailable(this MobileLabsApi api, bool? properties, bool? applications)
        {
            return api.Request<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                }, false);
        }

        public static Task<Device[]> GetDeviceAvailableAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        public static Device[] GetDeviceAvailable(this MobileLabsApi api)
        {
            return api.Request<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }

        public static Task<OperationResult<string>> GetDeviceLogAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.RequestAsync<OperationResult<string>>("/Device/Log",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult<string> GetDeviceLog(this MobileLabsApi api, string id)
        {
            return api.Request<OperationResult<string>>("/Device/Log",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult<string>> GetDeviceAppiumLogAsync(this MobileLabsApi api, string id, bool? currentSessionOnly, CancellationToken cancel)
        {
            return api.RequestAsync<OperationResult<string>>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("currentSessionOnly", currentSessionOnly == null ? null : currentSessionOnly.ToString()),
                },
                false, cancel);
        }

        public static OperationResult<string> GetDeviceAppiumLog(this MobileLabsApi api, string id, bool? currentSessionOnly)
        {
            return api.Request<OperationResult<string>>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("currentSessionOnly", currentSessionOnly == null ? null : currentSessionOnly.ToString()),
                }, false);
        }

        public static Task<OperationResult<string>> GetDeviceAppiumLogAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.RequestAsync<OperationResult<string>>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult<string> GetDeviceAppiumLog(this MobileLabsApi api, string id)
        {
            return api.Request<OperationResult<string>>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult> DeleteDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult DeleteDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }


        public static Task<OperationResult> UpdateDeviceAsync(this MobileLabsApi api, string id, Dictionary<string, string> properties, CancellationToken cancel)
        {
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }

            return api.PostJsonAsync<OperationResult, Dictionary<string, string>>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                properties,
                false, cancel);
        }


        public static OperationResult UpdateDevice(this MobileLabsApi api, string id, Dictionary<string, string> properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }

            return api.PostJson<OperationResult, Dictionary<string, string>>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                properties
                , false);
        }

        public static Task<OperationResult> UpdateDeviceUsbPortAsync(this MobileLabsApi api, string id, string usbHubPortState, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device/UsbPort",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                },
                false, cancel);
        }

        public static OperationResult UpdateDeviceUsbPort(this MobileLabsApi api, string id, string usbHubPortState)
        {
            return api.Post<OperationResult>("/Device/UsbPort",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                }, false);
        }

        public static Task<string> GetDeviceMetricsAsync(this MobileLabsApi api, string id, string table, string aggr, string fields, string marker, int? markerLimit, int? markerOffset, int? limit, int? offset, DateTime? start, DateTime? end, string groupBy, string orderBy, string format, string filename, int? timeout, CancellationToken cancel)
        {
            return api.RequestAsync<string>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("table", table),
                    new KeyValuePair<string, string>("aggr", aggr),
                    new KeyValuePair<string, string>("fields", fields),
                    new KeyValuePair<string, string>("marker", marker),
                    new KeyValuePair<string, string>("markerLimit", markerLimit == null ? null : markerLimit.ToString()),
                    new KeyValuePair<string, string>("markerOffset", markerOffset == null ? null : markerOffset.ToString()),
                    new KeyValuePair<string, string>("limit", limit == null ? null : limit.ToString()),
                    new KeyValuePair<string, string>("offset", offset == null ? null : offset.ToString()),
                    new KeyValuePair<string, string>("start", start == null ? null : start.ToString()),
                    new KeyValuePair<string, string>("end", end == null ? null : end.ToString()),
                    new KeyValuePair<string, string>("groupBy", groupBy),
                    new KeyValuePair<string, string>("orderBy", orderBy),
                    new KeyValuePair<string, string>("format", format),
                    new KeyValuePair<string, string>("filename", filename),
                    new KeyValuePair<string, string>("timeout", timeout == null ? null : timeout.ToString()),
                },
                false, cancel);
        }

        public static Task<string> GetDeviceMetricsAsync(this MobileLabsApi api, DeviceMetricsQuery deviceMetricsQuery, CancellationToken cancel)
        {
            if (deviceMetricsQuery == null)
            {
                throw new ArgumentNullException("deviceMetricsQuery");
            }

            return api.RequestAsync<string>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", deviceMetricsQuery.Id.ToString()),
                    new KeyValuePair<string, string>("table", deviceMetricsQuery.Table),
                    new KeyValuePair<string, string>("aggr", deviceMetricsQuery.Aggr),
                    new KeyValuePair<string, string>("fields", deviceMetricsQuery.Fields),
                    new KeyValuePair<string, string>("marker", deviceMetricsQuery.Marker),
                    new KeyValuePair<string, string>("markerLimit", deviceMetricsQuery.MarkerLimit == null ? null : deviceMetricsQuery.MarkerLimit.ToString()),
                    new KeyValuePair<string, string>("markerOffset", deviceMetricsQuery.MarkerOffset == null ? null : deviceMetricsQuery.MarkerOffset.ToString()),
                    new KeyValuePair<string, string>("limit", deviceMetricsQuery.Limit == null ? null : deviceMetricsQuery.Limit.ToString()),
                    new KeyValuePair<string, string>("offset", deviceMetricsQuery.Offset == null ? null : deviceMetricsQuery.Offset.ToString()),
                    new KeyValuePair<string, string>("start", deviceMetricsQuery.Start == null ? null : deviceMetricsQuery.Start.ToString()),
                    new KeyValuePair<string, string>("end", deviceMetricsQuery.End == null ? null : deviceMetricsQuery.End.ToString()),
                    new KeyValuePair<string, string>("groupBy", deviceMetricsQuery.GroupBy),
                    new KeyValuePair<string, string>("orderBy", deviceMetricsQuery.OrderBy),
                    new KeyValuePair<string, string>("format", deviceMetricsQuery.Format),
                    new KeyValuePair<string, string>("filename", deviceMetricsQuery.Filename),
                    new KeyValuePair<string, string>("timeout", deviceMetricsQuery.Timeout == null ? null : deviceMetricsQuery.Timeout.ToString()),
                },
                false, cancel);
        }

        public static string GetDeviceMetrics(this MobileLabsApi api, string id, string table, string aggr, string fields, string marker, int? markerLimit, int? markerOffset, int? limit, int? offset, DateTime? start, DateTime? end, string groupBy, string orderBy, string format, string filename, int? timeout)
        {
            return api.Request<string>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("table", table),
                    new KeyValuePair<string, string>("aggr", aggr),
                    new KeyValuePair<string, string>("fields", fields),
                    new KeyValuePair<string, string>("marker", marker),
                    new KeyValuePair<string, string>("markerLimit", markerLimit == null ? null : markerLimit.ToString()),
                    new KeyValuePair<string, string>("markerOffset", markerOffset == null ? null : markerOffset.ToString()),
                    new KeyValuePair<string, string>("limit", limit == null ? null : limit.ToString()),
                    new KeyValuePair<string, string>("offset", offset == null ? null : offset.ToString()),
                    new KeyValuePair<string, string>("start", start == null ? null : start.ToString()),
                    new KeyValuePair<string, string>("end", end == null ? null : end.ToString()),
                    new KeyValuePair<string, string>("groupBy", groupBy),
                    new KeyValuePair<string, string>("orderBy", orderBy),
                    new KeyValuePair<string, string>("format", format),
                    new KeyValuePair<string, string>("filename", filename),
                    new KeyValuePair<string, string>("timeout", timeout == null ? null : timeout.ToString()),
                }, false);
        }

        public static string GetDeviceMetrics(this MobileLabsApi api, DeviceMetricsQuery deviceMetricsQuery)
        {
            if (deviceMetricsQuery == null)
            {
                throw new ArgumentNullException("deviceMetricsQuery");
            }

            return api.Request<string>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", deviceMetricsQuery.Id.ToString()),
                    new KeyValuePair<string, string>("table", deviceMetricsQuery.Table),
                    new KeyValuePair<string, string>("aggr", deviceMetricsQuery.Aggr),
                    new KeyValuePair<string, string>("fields", deviceMetricsQuery.Fields),
                    new KeyValuePair<string, string>("marker", deviceMetricsQuery.Marker),
                    new KeyValuePair<string, string>("markerLimit", deviceMetricsQuery.MarkerLimit == null ? null : deviceMetricsQuery.MarkerLimit.ToString()),
                    new KeyValuePair<string, string>("markerOffset", deviceMetricsQuery.MarkerOffset == null ? null : deviceMetricsQuery.MarkerOffset.ToString()),
                    new KeyValuePair<string, string>("limit", deviceMetricsQuery.Limit == null ? null : deviceMetricsQuery.Limit.ToString()),
                    new KeyValuePair<string, string>("offset", deviceMetricsQuery.Offset == null ? null : deviceMetricsQuery.Offset.ToString()),
                    new KeyValuePair<string, string>("start", deviceMetricsQuery.Start == null ? null : deviceMetricsQuery.Start.ToString()),
                    new KeyValuePair<string, string>("end", deviceMetricsQuery.End == null ? null : deviceMetricsQuery.End.ToString()),
                    new KeyValuePair<string, string>("groupBy", deviceMetricsQuery.GroupBy),
                    new KeyValuePair<string, string>("orderBy", deviceMetricsQuery.OrderBy),
                    new KeyValuePair<string, string>("format", deviceMetricsQuery.Format),
                    new KeyValuePair<string, string>("filename", deviceMetricsQuery.Filename),
                    new KeyValuePair<string, string>("timeout", deviceMetricsQuery.Timeout == null ? null : deviceMetricsQuery.Timeout.ToString()),
                }
                , false);
        }

        public static Task<OperationResult> StartMarkerDeviceMetricsAsync(this MobileLabsApi api, string id, string name, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StartMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                },
                false, cancel);
        }

        public static OperationResult StartMarkerDeviceMetrics(this MobileLabsApi api, string id, string name)
        {
            return api.Post<OperationResult>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StartMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                }, false);
        }

        public static Task<OperationResult> StopMarkerDeviceMetricsAsync(this MobileLabsApi api, string id, string name, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StopMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                },
                false, cancel);
        }

        public static OperationResult StopMarkerDeviceMetrics(this MobileLabsApi api, string id, string name)
        {
            return api.Post<OperationResult>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StopMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                }, false);
        }

        public static Task<OperationResult> EnabledDeviceMetricsAsync(this MobileLabsApi api, string id, bool enable, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enabled"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("enable", enable.ToString()),
                },
                false, cancel);
        }

        public static OperationResult EnabledDeviceMetrics(this MobileLabsApi api, string id, bool enable)
        {
            return api.Post<OperationResult>("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enabled"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("enable", enable.ToString()),
                }, false);
        }

        public static Task<OperationResult> RebootDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult RebootDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult> RetainDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Retain"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult RetainDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Retain"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult> ReleaseDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Release"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult ReleaseDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Release"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult> EnableDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enable"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult EnableDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enable"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult> DisableDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Disable"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult DisableDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Disable"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        public static Task<OperationResult> ResetDeviceAsync(this MobileLabsApi api, string id, bool? uninstallAll, bool? reboot, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("uninstallAll", uninstallAll == null ? null : uninstallAll.ToString()),
                    new KeyValuePair<string, string>("reboot", reboot == null ? null : reboot.ToString()),
                },
                false, cancel);
        }

        public static OperationResult ResetDevice(this MobileLabsApi api, string id, bool? uninstallAll, bool? reboot)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("uninstallAll", uninstallAll == null ? null : uninstallAll.ToString()),
                    new KeyValuePair<string, string>("reboot", reboot == null ? null : reboot.ToString()),
                }, false);
        }

        public static Task<OperationResult> ResetDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        public static OperationResult ResetDevice(this MobileLabsApi api, string id)
        {
            return api.Post<OperationResult>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }
    }
}
