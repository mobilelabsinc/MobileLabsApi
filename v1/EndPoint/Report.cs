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
    public static class ReportEndPoints
    {
        /// <summary>
        /// Fetch an action history report.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetReportHistory&apos;.
        /// </summary>
        /// <param name="applicationId">Return only history for the application with this ID. If excluded, all applications are returned.</param>
        /// <param name="deviceId">Return only history for the specified device. If excluded, all devices are returned.</param>
        /// <param name="userId">Return only history for the user with this ID. If excluded, all users are returned.</param>
        /// <param name="fromDate">Only events newer than the provided date are returned. If excluded, there is no minimum date.</param>
        /// <param name="toDate">Only events older than the provided date are returned. If excluded, there is no maximum date.</param>
        /// <param name="days">Only events newer than this many days old are returned. Used instead of fromDate.</param>
        /// <param name="skip">The numeric starting entry to return the history from. Can be used in conjunction with take to paginate results.</param>
        /// <param name="take">The maximum number of entries to return. Can be used in conjunction with skip to paginate results.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<EventHistory> GetReportHistoryAsync(this MobileLabsApi api, Guid? applicationId, string deviceId, DateTime? fromDate, DateTime? toDate, int? days, Guid? userId, int? skip, int? take, CancellationToken cancel)
        {
            return api.RequestAsync<EventHistory>("/Report/History",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("applicationId", applicationId == null ? null : applicationId.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("fromDate", fromDate == null ? null : fromDate.ToString()),
                    new KeyValuePair<string, string>("toDate", toDate == null ? null : toDate.ToString()),
                    new KeyValuePair<string, string>("days", days == null ? null : days.ToString()),
                    new KeyValuePair<string, string>("userId", userId == null ? null : userId.ToString()),
                    new KeyValuePair<string, string>("skip", skip == null ? null : skip.ToString()),
                    new KeyValuePair<string, string>("take", take == null ? null : take.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch a device usage history report.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetReportUsage&apos;.
        /// </summary>
        /// <param name="applicationId">Return only history for the application with this ID. If excluded, all applications are returned.</param>
        /// <param name="deviceId">Return only history for the specified device. If excluded, all devices are returned.</param>
        /// <param name="userId">Return only history for the user with this ID. If excluded, all users are returned.</param>
        /// <param name="fromDate">Only events newer than the provided date are returned. If excluded, there is no minimum date.</param>
        /// <param name="toDate">Only events older than the provided date are returned. If excluded, there is no maximum date.</param>
        /// <param name="days">Only events newer than this many days old are returned. Used instead of fromDate.</param>
        /// <param name="skip">The numeric starting entry to return the history from. Can be used in conjunction with take to paginate results.</param>
        /// <param name="take">The maximum number of entries to return. Can be used in conjunction with skip to paginate results.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<DeviceUsageHistory> GetReportUsageAsync(this MobileLabsApi api, Guid? applicationId, string deviceId, DateTime? fromDate, DateTime? toDate, int? days, Guid? userId, int? skip, int? take, CancellationToken cancel)
        {
            return api.RequestAsync<DeviceUsageHistory>("/Report/Usage",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("applicationId", applicationId == null ? null : applicationId.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("fromDate", fromDate == null ? null : fromDate.ToString()),
                    new KeyValuePair<string, string>("toDate", toDate == null ? null : toDate.ToString()),
                    new KeyValuePair<string, string>("days", days == null ? null : days.ToString()),
                    new KeyValuePair<string, string>("userId", userId == null ? null : userId.ToString()),
                    new KeyValuePair<string, string>("skip", skip == null ? null : skip.ToString()),
                    new KeyValuePair<string, string>("take", take == null ? null : take.ToString()),
                },
                false, cancel);
        }

        /// <summary>
        /// Fetch device availability and use history.
        /// This is an async method and should only be called from an async method. For non-async code, use &apos;GetReportAvailability&apos;.
        /// </summary>
        /// <param name="days">Only events newer than this many days old are returned. Used instead of fromDate.</param>
        /// <param name="fromDate">Only events newer than the provided date are returned. If excluded, there is no minimum date.</param>
        /// <param name="toDate">Only events older than the provided date are returned. If excluded, there is no maximum date.</param>
        /// <param name="window">Only events within the set period of time. A time period with 30 second intervals would be window=00:00:30.</param>
        /// <param name="cancel">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public static Task<ReportDeviceAvailabilityTimeline[]> GetReportAvailabilityAsync(this MobileLabsApi api, DateTime? fromDate, DateTime? toDate, int? days, TimeSpan? window, CancellationToken cancel)
        {
            return api.RequestAsync<ReportDeviceAvailabilityTimeline[]>("/Report/Availability",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("fromDate", fromDate == null ? null : fromDate.ToString()),
                    new KeyValuePair<string, string>("toDate", toDate == null ? null : toDate.ToString()),
                    new KeyValuePair<string, string>("days", days == null ? null : days.ToString()),
                    new KeyValuePair<string, string>("window", window == null ? null : window.ToString()),
                },
                false, cancel);
        }

        /// <summary>Fetch an action history report.</summary>
        /// <param name="applicationId">Return only history for the application with this ID. If excluded, all applications are returned.</param>
        /// <param name="deviceId">Return only history for the specified device. If excluded, all devices are returned.</param>
        /// <param name="userId">Return only history for the user with this ID. If excluded, all users are returned.</param>
        /// <param name="fromDate">Only events newer than the provided date are returned. If excluded, there is no minimum date.</param>
        /// <param name="toDate">Only events older than the provided date are returned. If excluded, there is no maximum date.</param>
        /// <param name="days">Only events newer than this many days old are returned. Used instead of fromDate.</param>
        /// <param name="skip">The numeric starting entry to return the history from. Can be used in conjunction with take to paginate results.</param>
        /// <param name="take">The maximum number of entries to return. Can be used in conjunction with skip to paginate results.</param>
        public static EventHistory GetReportHistory(this MobileLabsApi api, Guid? applicationId, string deviceId, DateTime? fromDate, DateTime? toDate, int? days, Guid? userId, int? skip, int? take)
        {
            return api.Request<EventHistory>("/Report/History",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("applicationId", applicationId == null ? null : applicationId.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("fromDate", fromDate == null ? null : fromDate.ToString()),
                    new KeyValuePair<string, string>("toDate", toDate == null ? null : toDate.ToString()),
                    new KeyValuePair<string, string>("days", days == null ? null : days.ToString()),
                    new KeyValuePair<string, string>("userId", userId == null ? null : userId.ToString()),
                    new KeyValuePair<string, string>("skip", skip == null ? null : skip.ToString()),
                    new KeyValuePair<string, string>("take", take == null ? null : take.ToString()),
                }, false);
        }

        /// <summary>Fetch a device usage history report.</summary>
        /// <param name="applicationId">Return only history for the application with this ID. If excluded, all applications are returned.</param>
        /// <param name="deviceId">Return only history for the specified device. If excluded, all devices are returned.</param>
        /// <param name="userId">Return only history for the user with this ID. If excluded, all users are returned.</param>
        /// <param name="fromDate">Only events newer than the provided date are returned. If excluded, there is no minimum date.</param>
        /// <param name="toDate">Only events older than the provided date are returned. If excluded, there is no maximum date.</param>
        /// <param name="days">Only events newer than this many days old are returned. Used instead of fromDate.</param>
        /// <param name="skip">The numeric starting entry to return the history from. Can be used in conjunction with take to paginate results.</param>
        /// <param name="take">The maximum number of entries to return. Can be used in conjunction with skip to paginate results.</param>
        public static DeviceUsageHistory GetReportUsage(this MobileLabsApi api, Guid? applicationId, string deviceId, DateTime? fromDate, DateTime? toDate, int? days, Guid? userId, int? skip, int? take)
        {
            return api.Request<DeviceUsageHistory>("/Report/Usage",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("applicationId", applicationId == null ? null : applicationId.ToString()),
                    new KeyValuePair<string, string>("deviceId", deviceId),
                    new KeyValuePair<string, string>("fromDate", fromDate == null ? null : fromDate.ToString()),
                    new KeyValuePair<string, string>("toDate", toDate == null ? null : toDate.ToString()),
                    new KeyValuePair<string, string>("days", days == null ? null : days.ToString()),
                    new KeyValuePair<string, string>("userId", userId == null ? null : userId.ToString()),
                    new KeyValuePair<string, string>("skip", skip == null ? null : skip.ToString()),
                    new KeyValuePair<string, string>("take", take == null ? null : take.ToString()),
                }, false);
        }

        /// <summary>Fetch device availability and use history.</summary>
        /// <param name="days">Only events newer than this many days old are returned. Used instead of fromDate.</param>
        /// <param name="fromDate">Only events newer than the provided date are returned. If excluded, there is no minimum date.</param>
        /// <param name="toDate">Only events older than the provided date are returned. If excluded, there is no maximum date.</param>
        /// <param name="window">Only events within the set period of time. A time period with 30 second intervals would be window=00:00:30.</param>
        public static ReportDeviceAvailabilityTimeline[] GetReportAvailability(this MobileLabsApi api, DateTime? fromDate, DateTime? toDate, int? days, TimeSpan? window)
        {
            return api.Request<ReportDeviceAvailabilityTimeline[]>("/Report/Availability",
                new KeyValuePair<string, string>[] {
                    new KeyValuePair<string, string>("get", ""),
                    new KeyValuePair<string, string>("fromDate", fromDate == null ? null : fromDate.ToString()),
                    new KeyValuePair<string, string>("toDate", toDate == null ? null : toDate.ToString()),
                    new KeyValuePair<string, string>("days", days == null ? null : days.ToString()),
                    new KeyValuePair<string, string>("window", window == null ? null : window.ToString()),
                }, false);
        }
    }
}
