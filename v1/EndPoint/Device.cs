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
    public static class DeviceEndPoints
    {
        /// <summary>
        /// Fetch the list of devices managed by GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDevice&apos;.
        /// </summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of DeviceProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

        public static Task<Device[]> GetDeviceAsync(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJsonAsync<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                },
                propertiesQuery,
                false, cancel);
        }

        /// <summary>
        /// Fetch the list of devices managed by GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDevice&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<Device[]> GetDeviceAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch the list of devices managed by GigaFox.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDevice&apos;.
        /// </summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<Device[]> GetDeviceAsync(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch a list of devices with an Available status that the user can retain. The output will not include devices with a Retained/In-Use, Disabled, or Reserved (by another user) status.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceAvailable&apos;.
        /// </summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of DeviceProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

        public static Task<Device[]> GetDeviceAvailableAsync(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJsonAsync<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                },
                propertiesQuery,
                false, cancel);
        }

        /// <summary>
        /// Fetch a list of devices with an Available status that the user can retain. The output will not include devices with a Retained/In-Use, Disabled, or Reserved (by another user) status.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceAvailable&apos;.
        /// </summary>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<Device[]> GetDeviceAvailableAsync(this MobileLabsApi api, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch a list of devices with an Available status that the user can retain. The output will not include devices with a Retained/In-Use, Disabled, or Reserved (by another user) status.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceAvailable&apos;.
        /// </summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<Device[]> GetDeviceAvailableAsync(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications, CancellationToken cancel)
        {
            return api.RequestAsync<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch the device&apos;s system log.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceLog&apos;.
        /// </summary>
        /// <param name="id">The device to get the system log for.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<string> GetDeviceLogAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.RequestAsync<string>("/Device/Log",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch the appium stdout/stderr output log.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceAppiumLog&apos;.
        /// </summary>
        /// <param name="id">The device to get the system log for.</param>
        /// <param name="currentSessionOnly">Only return logs for the current (or if session has ended, the last active) session.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<string> GetDeviceAppiumLogAsync(this MobileLabsApi api, string id, bool? currentSessionOnly, CancellationToken cancel)
        {
            return api.RequestAsync<string>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("currentSessionOnly", currentSessionOnly == null ? null : currentSessionOnly.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch the appium stdout/stderr output log.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceAppiumLog&apos;.
        /// </summary>
        /// <param name="id">The device to get the system log for.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<string> GetDeviceAppiumLogAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.RequestAsync<string>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Delete a device that is no longer managed by GigaFox. This can only be done to offline devices.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;DeleteDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to delete.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task DeleteDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Update the stored device model.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UpdateDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to update.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of DeviceProperties with associated values to filter by.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>

        public static Task UpdateDeviceAsync(this MobileLabsApi api, string id, Dictionary<string, string> propertiesQuery, CancellationToken cancel)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.PostJsonAsync<Dictionary<string, string>>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                propertiesQuery,
                false, cancel);
        }

        /// <summary>
        /// Update the state of a USB hub port. This allows alternative a device&apos;s USB hub port between disconnect, charging, and data modes.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;UpdateDeviceUsbPort&apos;.
        /// </summary>
        /// <param name="id">The ID of the device&apos;s USB hub port to update.</param>
        /// <param name="usbHubPortState">The state to transition the USB hub port to.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task UpdateDeviceUsbPortAsync(this MobileLabsApi api, string id, string usbHubPortState, CancellationToken cancel)
        {
            return api.PostAsync("/Device/UsbPort",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                },
                false, cancel);
        }

        /// <summary>
        /// Query the device metrics database for specified metrics for a given device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetDeviceMetrics&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to query metrics for.</param>
        /// <param name="table">Tables to select fields from. Formatted as a comma delineated list of measurement names. Table names are listed in the metrics schema.Example:&amp;table=event, &amp;table=event,logWarning: Referencing more than one table in a single query has a severe performance impact in InfluxDB.</param>
        /// <param name="fields">A list of fields to select. If excluded, all fields from the referenced tables will be returned. Referencing specific fields can drastically decrease the response size. Formatted as a comma delineated list of fields. Field names are listed in the metrics schema.</param>
        /// <param name="aggr">
        /// A list of functions to perform on the referenced fields. When used, &quot;fields&quot; becomes a required argument. Formatted as a comma delineated list.
        /// Each function is implicitly given each listed field as the first argument. The function list is shown in
        /// influxdata.Example: Get the max aggregate of 2 fields. &amp;aggr=max&amp;fields=fieldA,fieldB performs the query as
        /// SELECT max(fieldA), max(fieldB)Example: Get the max aggregate and mean of 2 fields. &amp;aggr=max,mean&amp;fields=fieldA,fieldB performs the query as
        /// SELECT max(fieldA), max(fieldB), mean(fieldA), mean(fieldB)
        /// </param>
        /// <param name="marker">
        /// The name of a marker. When used, the results are limited to the intermediate periods for the most recent specified markers. The marker session is
        /// automatically inserted for the periods of time when a device is retained. Custom markers can be inserted using the startmarker and
        /// stopmarker API actions. When a marker is specified, start and end are ignored.
        /// Example: Get the metrics for the last 5 sessions.
        /// &amp;marker=session&amp;markerLimit=5
        /// </param>
        /// <param name="markerLimit">
        /// The number of number of marker entries to reference. If not specific, defaults to 1. Having a markerLimit greater than 1 produces
        /// multiple timelines in a single result and may not be directly processable. This is a side effect of InfluxDB.
        /// </param>
        /// <param name="markerOffset">The number of markers to skip. For example, if markerLimit is 1, and markerOffset is 3, then the 4th previous marker entry will be used.</param>
        /// <param name="limit">
        /// Limit the result rows to the specified limit. If not set, there is no limit. limit can be used with offset to &quot;page&quot;
        /// results in smaller portions. limit is required if marker, start, and end are not present.
        /// </param>
        /// <param name="offset">The result row to start at. Can only be specified if limit is also specified.</param>
        /// <param name="start"></param>
        /// <param name="end">The time range to limit the query to. Both do not need to be specified. These values are ignored if marker is present.</param>
        /// <param name="groupBy">A field name to group the results by.</param>
        /// <param name="orderBy">
        /// A field name to order the results by. Due to limitations in InfluxDB, at present only the time field is supported. An ordering
        /// direction can be specified after a space in the field name. Ascending is assumed, desc can be specified manually.
        /// Example: Order by time descending. &amp;orderBy=time+desc
        /// </param>
        /// <param name="format">
        /// The format of the result. Possible values are csv and default. If CSV is not given, default is assumed.
        /// default is a pass-through of the JSON returned by InfluxDB. This permits any InfluxDB result processing tool to be used. Documentation
        /// of the format is available on their site: influxdatacsv is a transcoding of the JSON to CSV format. CSV is beneficial in it may be less CPU intensive to process,could consume less bandwidth,
        /// and has compatibility with any CSV processing application.
        /// </param>
        /// <param name="filename">
        /// The filename for the returned document. If not specified, the default is &quot;metrics-&quot; followed by the device&apos;s name. The extension is automatically
        /// set according to the specified format.
        /// </param>
        /// <param name="timeout">
        /// The optional number of seconds to allow the query to run. The default is 120 seconds. This may need to be adjusted for more complex or larger
        /// queries.
        /// </param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
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

        /// <summary>
        /// Start a metrics marker. The marker must be ended using stopmarker. The marker&apos;s timespan is represented by when the startmarker
        /// and stopmarker calls were made. Markers are used as named reference points into the metrics timeline. Multiple calls to startmarker
        /// can be made before calling stopmarker given each call has a unique name.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;StartMarkerDeviceMetrics&apos;.
        /// </summary>
        /// <param name="id">The ID of the device.</param>
        /// <param name="name">The name of the marker. There are no character limitations.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task StartMarkerDeviceMetricsAsync(this MobileLabsApi api, string id, string name, CancellationToken cancel)
        {
            return api.PostAsync("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StartMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                },
                false, cancel);
        }

        /// <summary>
        /// End the metrics marker of the same name for the same device as passed to startmarker.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;StopMarkerDeviceMetrics&apos;.
        /// </summary>
        /// <param name="id">
        /// deviceConnect ID,
        /// serial number, or
        /// vendor ID
        /// </param>
        /// <param name="name">The name of the marker which was passed to startmarker.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task StopMarkerDeviceMetricsAsync(this MobileLabsApi api, string id, string name, CancellationToken cancel)
        {
            return api.PostAsync("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StopMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                },
                false, cancel);
        }

        /// <summary>
        /// Enable or disable passive metric logging for a device. By default, all devices have passive logging enabled. It&apos;s recommended that this be turned off if the performance overhead on the device is detrimental to testing.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;EnabledDeviceMetrics&apos;.
        /// </summary>
        /// <param name="id">
        /// deviceConnect ID,
        /// serial number, or
        /// vendor ID
        /// </param>
        /// <param name="enable">Set to true if metrics should be passively logged for this device.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task EnabledDeviceMetricsAsync(this MobileLabsApi api, string id, bool enable, CancellationToken cancel)
        {
            return api.PostAsync("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enabled"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("enable", enable.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Reboot the operating system on the device. The device&apos;s availability will show Offline until the reboot has completed.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;RebootDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to reboot.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task RebootDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Set a device as retained by the authenticated user inside GigaFox. This prevents other users from performing most actions on the device. See the GigaFox user&apos;s guide for more details.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;RetainDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to retain.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task RetainDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Retain"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Release the retain held on a device.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;ReleaseDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to release.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task ReleaseDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Release"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Enable a device to be managed by GigaFox. While a device is disabled, it can not be used but does not count toward the licensed device limit.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;EnableDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to enable.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task EnableDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enable"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Disable a device so it is no longer accessible from GigaFox. While a device is disabled, it can not be used but does not count toward the licensed device limit.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;DisableDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to disable.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task DisableDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Disable"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>
        /// Reset the state of a device. Resetting device state is to permit increased determinacy of the device&apos;s state between usage or testing sessions.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;ResetDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to reset.</param>
        /// <param name="uninstallAll">If set to true, all user installed applications on the device will be uninstalled. If false, no applications are uninstalled. If excluded, the default inside GigaFox&apos;s System area is used.</param>
        /// <param name="reboot">If set to true, the device is reboot. If false, no reboot is performed. If excluded, the default inside GigaFox&apos;s System area is used.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task ResetDeviceAsync(this MobileLabsApi api, string id, bool? uninstallAll, bool? reboot, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("uninstallAll", uninstallAll == null ? null : uninstallAll.ToString()),
                    new KeyValuePair<string, string>("reboot", reboot == null ? null : reboot.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Reset the state of a device. Resetting device state is to permit increased determinacy of the device&apos;s state between usage or testing sessions.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;ResetDevice&apos;.
        /// </summary>
        /// <param name="id">The ID of the device to reset.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task ResetDeviceAsync(this MobileLabsApi api, string id, CancellationToken cancel)
        {
            return api.PostAsync("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                },
                false, cancel);
        }

        /// <summary>Fetch the list of devices managed by GigaFox.</summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of DeviceProperties with associated values to filter by.</param>

        public static Device[] GetDevice(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJson<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                },
                propertiesQuery,
                false);
        }

        /// <summary>Fetch the list of devices managed by GigaFox.</summary>
        public static Device[] GetDevice(this MobileLabsApi api)
        {
            return api.Request<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }

        /// <summary>Fetch the list of devices managed by GigaFox.</summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        public static Device[] GetDevice(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications)
        {
            return api.Request<Device[]>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                }, false);
        }

        /// <summary>Fetch a list of devices with an Available status that the user can retain. The output will not include devices with a Retained/In-Use, Disabled, or Reserved (by another user) status.</summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of DeviceProperties with associated values to filter by.</param>

        public static Device[] GetDeviceAvailable(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            return api.RequestJson<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                },
                propertiesQuery,
                false);
        }

        /// <summary>Fetch a list of devices with an Available status that the user can retain. The output will not include devices with a Retained/In-Use, Disabled, or Reserved (by another user) status.</summary>
        public static Device[] GetDeviceAvailable(this MobileLabsApi api)
        {
            return api.Request<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                }, false);
        }

        /// <summary>Fetch a list of devices with an Available status that the user can retain. The output will not include devices with a Retained/In-Use, Disabled, or Reserved (by another user) status.</summary>
        /// <param name="properties">Include the Properties field.</param>
        /// <param name="applications">If set to true, returns the GigaFox managed applications that are installed on the device in installedApplications.</param>
        /// <param name="allApplications">If set to true, returns all applications that are installed on the device in installedApplications. Applications not managed by GigaFox will have 00000000-0000-0000-0000-000000000000 as their id.</param>
        public static Device[] GetDeviceAvailable(this MobileLabsApi api, bool? properties, bool? applications, bool? allApplications)
        {
            return api.Request<Device[]>("/Device/Available",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("properties", properties == null ? null : properties.ToString()),
                    new KeyValuePair<string, string>("applications", applications == null ? null : applications.ToString()),
                    new KeyValuePair<string, string>("allApplications", allApplications == null ? null : allApplications.ToString()),
                }, false);
        }

        /// <summary>Fetch the device&apos;s system log.</summary>
        /// <param name="id">The device to get the system log for.</param>
        public static string GetDeviceLog(this MobileLabsApi api, string id)
        {
            return api.Request<string>("/Device/Log",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Fetch the appium stdout/stderr output log.</summary>
        /// <param name="id">The device to get the system log for.</param>
        /// <param name="currentSessionOnly">Only return logs for the current (or if session has ended, the last active) session.</param>
        public static string GetDeviceAppiumLog(this MobileLabsApi api, string id, bool? currentSessionOnly)
        {
            return api.Request<string>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("currentSessionOnly", currentSessionOnly == null ? null : currentSessionOnly.ToString()),
                }, false);
        }

        /// <summary>Fetch the appium stdout/stderr output log.</summary>
        /// <param name="id">The device to get the system log for.</param>
        public static string GetDeviceAppiumLog(this MobileLabsApi api, string id)
        {
            return api.Request<string>("/Device/AppiumLog",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Delete a device that is no longer managed by GigaFox. This can only be done to offline devices.</summary>
        /// <param name="id">The ID of the device to delete.</param>
        public static void DeleteDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("delete", ""),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Update the stored device model.</summary>
        /// <param name="id">The ID of the device to update.</param>
        /// <param name="propertiesQuery">Filter the query. A dictionary with keys of DeviceProperties with associated values to filter by.</param>

        public static void UpdateDevice(this MobileLabsApi api, string id, Dictionary<string, string> propertiesQuery)
        {
            if (propertiesQuery == null)
            {
                throw new ArgumentNullException("propertiesQuery");
            }

            api.PostJson<Dictionary<string, string>>("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                },
                propertiesQuery,
                false);
        }

        /// <summary>Update the state of a USB hub port. This allows alternative a device&apos;s USB hub port between disconnect, charging, and data modes.</summary>
        /// <param name="id">The ID of the device&apos;s USB hub port to update.</param>
        /// <param name="usbHubPortState">The state to transition the USB hub port to.</param>
        public static void UpdateDeviceUsbPort(this MobileLabsApi api, string id, string usbHubPortState)
        {
            api.Post("/Device/UsbPort",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("update", ""),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("usbHubPortState", usbHubPortState),
                }, false);
        }

        /// <summary>Query the device metrics database for specified metrics for a given device.</summary>
        /// <param name="id">The ID of the device to query metrics for.</param>
        /// <param name="table">Tables to select fields from. Formatted as a comma delineated list of measurement names. Table names are listed in the metrics schema.Example:&amp;table=event, &amp;table=event,logWarning: Referencing more than one table in a single query has a severe performance impact in InfluxDB.</param>
        /// <param name="fields">A list of fields to select. If excluded, all fields from the referenced tables will be returned. Referencing specific fields can drastically decrease the response size. Formatted as a comma delineated list of fields. Field names are listed in the metrics schema.</param>
        /// <param name="aggr">
        /// A list of functions to perform on the referenced fields. When used, &quot;fields&quot; becomes a required argument. Formatted as a comma delineated list.
        /// Each function is implicitly given each listed field as the first argument. The function list is shown in
        /// influxdata.Example: Get the max aggregate of 2 fields. &amp;aggr=max&amp;fields=fieldA,fieldB performs the query as
        /// SELECT max(fieldA), max(fieldB)Example: Get the max aggregate and mean of 2 fields. &amp;aggr=max,mean&amp;fields=fieldA,fieldB performs the query as
        /// SELECT max(fieldA), max(fieldB), mean(fieldA), mean(fieldB)
        /// </param>
        /// <param name="marker">
        /// The name of a marker. When used, the results are limited to the intermediate periods for the most recent specified markers. The marker session is
        /// automatically inserted for the periods of time when a device is retained. Custom markers can be inserted using the startmarker and
        /// stopmarker API actions. When a marker is specified, start and end are ignored.
        /// Example: Get the metrics for the last 5 sessions.
        /// &amp;marker=session&amp;markerLimit=5
        /// </param>
        /// <param name="markerLimit">
        /// The number of number of marker entries to reference. If not specific, defaults to 1. Having a markerLimit greater than 1 produces
        /// multiple timelines in a single result and may not be directly processable. This is a side effect of InfluxDB.
        /// </param>
        /// <param name="markerOffset">The number of markers to skip. For example, if markerLimit is 1, and markerOffset is 3, then the 4th previous marker entry will be used.</param>
        /// <param name="limit">
        /// Limit the result rows to the specified limit. If not set, there is no limit. limit can be used with offset to &quot;page&quot;
        /// results in smaller portions. limit is required if marker, start, and end are not present.
        /// </param>
        /// <param name="offset">The result row to start at. Can only be specified if limit is also specified.</param>
        /// <param name="start"></param>
        /// <param name="end">The time range to limit the query to. Both do not need to be specified. These values are ignored if marker is present.</param>
        /// <param name="groupBy">A field name to group the results by.</param>
        /// <param name="orderBy">
        /// A field name to order the results by. Due to limitations in InfluxDB, at present only the time field is supported. An ordering
        /// direction can be specified after a space in the field name. Ascending is assumed, desc can be specified manually.
        /// Example: Order by time descending. &amp;orderBy=time+desc
        /// </param>
        /// <param name="format">
        /// The format of the result. Possible values are csv and default. If CSV is not given, default is assumed.
        /// default is a pass-through of the JSON returned by InfluxDB. This permits any InfluxDB result processing tool to be used. Documentation
        /// of the format is available on their site: influxdatacsv is a transcoding of the JSON to CSV format. CSV is beneficial in it may be less CPU intensive to process,could consume less bandwidth,
        /// and has compatibility with any CSV processing application.
        /// </param>
        /// <param name="filename">
        /// The filename for the returned document. If not specified, the default is &quot;metrics-&quot; followed by the device&apos;s name. The extension is automatically
        /// set according to the specified format.
        /// </param>
        /// <param name="timeout">
        /// The optional number of seconds to allow the query to run. The default is 120 seconds. This may need to be adjusted for more complex or larger
        /// queries.
        /// </param>
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
                },
                false);
        }

        /// <summary>
        /// Start a metrics marker. The marker must be ended using stopmarker. The marker&apos;s timespan is represented by when the startmarker
        /// and stopmarker calls were made. Markers are used as named reference points into the metrics timeline. Multiple calls to startmarker
        /// can be made before calling stopmarker given each call has a unique name.
        /// </summary>
        /// <param name="id">The ID of the device.</param>
        /// <param name="name">The name of the marker. There are no character limitations.</param>
        public static void StartMarkerDeviceMetrics(this MobileLabsApi api, string id, string name)
        {
            api.Post("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StartMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                }, false);
        }

        /// <summary>End the metrics marker of the same name for the same device as passed to startmarker.</summary>
        /// <param name="id">
        /// deviceConnect ID,
        /// serial number, or
        /// vendor ID
        /// </param>
        /// <param name="name">The name of the marker which was passed to startmarker.</param>
        public static void StopMarkerDeviceMetrics(this MobileLabsApi api, string id, string name)
        {
            api.Post("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "StopMarker"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("name", name),
                }, false);
        }

        /// <summary>Enable or disable passive metric logging for a device. By default, all devices have passive logging enabled. It&apos;s recommended that this be turned off if the performance overhead on the device is detrimental to testing.</summary>
        /// <param name="id">
        /// deviceConnect ID,
        /// serial number, or
        /// vendor ID
        /// </param>
        /// <param name="enable">Set to true if metrics should be passively logged for this device.</param>
        public static void EnabledDeviceMetrics(this MobileLabsApi api, string id, bool enable)
        {
            api.Post("/Device/Metrics",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enabled"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("enable", enable.ToString()),
                }, false);
        }

        /// <summary>Reboot the operating system on the device. The device&apos;s availability will show Offline until the reboot has completed.</summary>
        /// <param name="id">The ID of the device to reboot.</param>
        public static void RebootDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reboot"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Set a device as retained by the authenticated user inside GigaFox. This prevents other users from performing most actions on the device. See the GigaFox user&apos;s guide for more details.</summary>
        /// <param name="id">The ID of the device to retain.</param>
        public static void RetainDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Retain"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Release the retain held on a device.</summary>
        /// <param name="id">The ID of the device to release.</param>
        public static void ReleaseDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Release"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Enable a device to be managed by GigaFox. While a device is disabled, it can not be used but does not count toward the licensed device limit.</summary>
        /// <param name="id">The ID of the device to enable.</param>
        public static void EnableDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Enable"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Disable a device so it is no longer accessible from GigaFox. While a device is disabled, it can not be used but does not count toward the licensed device limit.</summary>
        /// <param name="id">The ID of the device to disable.</param>
        public static void DisableDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Disable"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }

        /// <summary>Reset the state of a device. Resetting device state is to permit increased determinacy of the device&apos;s state between usage or testing sessions.</summary>
        /// <param name="id">The ID of the device to reset.</param>
        /// <param name="uninstallAll">If set to true, all user installed applications on the device will be uninstalled. If false, no applications are uninstalled. If excluded, the default inside GigaFox&apos;s System area is used.</param>
        /// <param name="reboot">If set to true, the device is reboot. If false, no reboot is performed. If excluded, the default inside GigaFox&apos;s System area is used.</param>
        public static void ResetDevice(this MobileLabsApi api, string id, bool? uninstallAll, bool? reboot)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                    new KeyValuePair<string, string>("uninstallAll", uninstallAll == null ? null : uninstallAll.ToString()),
                    new KeyValuePair<string, string>("reboot", reboot == null ? null : reboot.ToString()),
                }, false);
        }

        /// <summary>Reset the state of a device. Resetting device state is to permit increased determinacy of the device&apos;s state between usage or testing sessions.</summary>
        /// <param name="id">The ID of the device to reset.</param>
        public static void ResetDevice(this MobileLabsApi api, string id)
        {
            api.Post("/Device",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("action", "Reset"),
                    new KeyValuePair<string, string>("id", id),
                }, false);
        }
    }
}
