using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobileLabs.DeviceConnect.RestApi.v1.EndPoint;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MobileLabs.DeviceConnect.RestApi
{
    public class MobileLabsApi
    {
        private static readonly JsonSerializerSettings _jsonSettings =
            new JsonSerializerSettings();

        private readonly string _username;
        private readonly string _apikey;
        private readonly Uri _serveruri;

        static MobileLabsApi()
        {
            _jsonSettings.Converters.Add(
                TimeSpanAsMillisecondsConverter.Converter);
        }

        public MobileLabsApi(string username, string apikey, string serveraddress)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException("username");
            }

            if (string.IsNullOrWhiteSpace(apikey))
            {
                throw new ArgumentNullException("apikey");
            }

            if (string.IsNullOrWhiteSpace(serveraddress))
            {
                throw new ArgumentNullException("serveraddress");
            }

            if (!serveraddress.StartsWith("http://") &&
                !serveraddress.StartsWith("https://"))
            {
                throw new ArgumentOutOfRangeException("serveraddress", serveraddress,
                    "Expected protocol://address, example: http://deviceConnect.server");
            }

            if (!Uri.TryCreate(serveraddress, UriKind.Absolute, out _serveruri))
            {
                throw new ArgumentOutOfRangeException(
                    "serveraddress", serveraddress,
                    "Unable to parse server address.");
            }

            _username = username;
            _apikey = apikey;
        }

        private static string CleanUrl(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection)
        {
            return GetUrlWithContent(url.TrimStart('/'), nameValueCollection);
        }

        private string BaseUrl(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection)
        {
            return new Uri(_serveruri, "/apiv1/" +
                CleanUrl(url, nameValueCollection)).ToString();
        }

        public async Task<T> RequestAsync<T>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection,
            bool isAsync,
            CancellationToken cancel)
        {
            using (var client = new HttpClient())
            using (cancel.Register(DisposeHttpClient, client))
            {
                AddAuth(client);

                using (var response = await client
                    .GetAsync(CleanUrl(url, nameValueCollection), cancel))
                {
                    return await HandleJsonResponseAsync<T>(
                        response, isAsync, cancel);
                }
            }
        }

        public T Request<T>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection,
            bool isAsync)
        {
            var client = (HttpWebRequest)WebRequest
                .Create(BaseUrl(url, nameValueCollection));
            AddAuth(client);

            using (var response = (HttpWebResponse)client.GetResponse())
            {
                return HandleJsonResponse<T>(response, isAsync);
            }
        }

        public async Task<T> PostAsync<T>(string url,
            byte[] byteContent, bool isAsync, CancellationToken cancel)
        {
            using (var client = new HttpClient())
            using (cancel.Register(DisposeHttpClient, client))
            {
                AddAuth(client);

                using (var content = new ByteArrayContent(byteContent))
                using (var response = await client
                    .PostAsync(CleanUrl(url, null), content, cancel))
                {
                    return await HandleJsonResponseAsync<T>(
                        response, isAsync, cancel);
                }
            }
        }

        public T Post<T>(string url, byte[] byteContent, bool isAsync)
        {
            var client = (HttpWebRequest)WebRequest.Create(BaseUrl(url, null));
            AddAuth(client);

            client.Method = "POST";
            client.ContentType = "application/x-www-form-urlencoded";
            client.ContentLength = byteContent.Length;

            using (var requestStream = client.GetRequestStream())
            {
                requestStream.Write(byteContent, 0, byteContent.Length);
            }

            using (var response = (HttpWebResponse)client.GetResponse())
            {
                return HandleJsonResponse<T>(response, isAsync);
            }
        }

        public async Task<T> PostAsync<T>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection,
            bool isAsync,
            CancellationToken cancel)
        {
            using (var client = new HttpClient())
            using (cancel.Register(DisposeHttpClient, client))
            {
                AddAuth(client);

                using (var content = new FormUrlEncodedContent(nameValueCollection))
                using (var response = await client
                    .PostAsync(CleanUrl(url, null), content, cancel))
                {
                    return await HandleJsonResponseAsync<T>(
                        response, isAsync, cancel);
                }
            }
        }

        public T Post<T>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection,
            bool isAsync)
        {
            var client = (HttpWebRequest)WebRequest.Create(BaseUrl(url, null));
            AddAuth(client);

            var byteContent = GetContentByteArray(nameValueCollection);
            client.Method = "POST";
            client.ContentType = "application/x-www-form-urlencoded";
            client.ContentLength = byteContent.Length;

            using (var requestStream = client.GetRequestStream())
            {
                requestStream.Write(byteContent, 0, byteContent.Length);
            }

            using (var response = (HttpWebResponse)client.GetResponse())
            {
                return HandleJsonResponse<T>(response, isAsync);
            }
        }

        public async Task<TOut> PostJsonAsync<TOut, TIn>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> arguments,
            TIn content,
            bool isAsync,
            CancellationToken cancel)
        {
            using (var client = new HttpClient())
            using (cancel.Register(DisposeHttpClient, client))
            {
                AddAuth(client);

                var serialized = JsonConvert.SerializeObject(content);
                using (var httpContent = new StringContent(
                    serialized, Encoding.UTF8, "application/json"))
                using (var response = await client
                    .PostAsync(CleanUrl(url, arguments), httpContent, cancel))
                {
                    return await HandleJsonResponseAsync<TOut>(
                        response, isAsync, cancel);
                }
            }
        }

        public TOut PostJson<TOut, TIn>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> arguments,
            TIn content,
            bool isAsync)
        {
            var client = (HttpWebRequest)WebRequest.Create(BaseUrl(url, arguments));
            AddAuth(client);

            var serialized = JsonConvert.SerializeObject(content);
            var httpContent = Encoding.UTF8.GetBytes(serialized);

            client.Method = "POST";
            client.ContentType = "application/json";
            client.ContentLength = httpContent.Length;

            using (var requestStream = client.GetRequestStream())
            {
                requestStream.Write(httpContent, 0, httpContent.Length);
            }

            using (var response = (HttpWebResponse)client.GetResponse())
            {
                return HandleJsonResponse<TOut>(response, isAsync);
            }
        }

        private static Dictionary<string, string> CompressArguments(
            IReadOnlyCollection<KeyValuePair<string, string>> arguments,
            Dictionary<string, string> content)
        {
            var form = new Dictionary<string, string>();

            if (content != null)
            {
                foreach (var kv in content)
                {
                    form[kv.Key] = kv.Value;
                }
            }

            if (arguments != null)
            {
                foreach (var kv in arguments)
                {
                    form[kv.Key] = kv.Value;
                }
            }

            return form;
        }

        public async Task<TOut> RequestJsonAsync<TOut>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> arguments,
            Dictionary<string, string> content,
            bool isAsync,
            CancellationToken cancel)
        {
            var form = CompressArguments(arguments, content);

            using (var client = new HttpClient())
            using (cancel.Register(DisposeHttpClient, client))
            {
                AddAuth(client);

                using (var response = await client
                    .GetAsync(CleanUrl(url, form), cancel))
                {
                    return await HandleJsonResponseAsync<TOut>(
                        response, isAsync, cancel);
                }
            }
        }

        public TOut RequestJson<TOut>(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> arguments,
            Dictionary<string, string> content,
            bool isAsync)
        {
            var form = CompressArguments(arguments, content);
            var client = (HttpWebRequest)WebRequest
                .Create(BaseUrl(url, form));
            AddAuth(client);

            using (var response = (HttpWebResponse)client.GetResponse())
            {
                return HandleJsonResponse<TOut>(response, isAsync);
            }
        }

        public async Task<T> PostFileAsync<T>(
            string url, string filename, bool isAsync, CancellationToken cancel)
        {
            using (var fs = File.OpenRead(filename))
            using (var client = new HttpClient())
            using (cancel.Register(DisposeHttpClient, client))
            {
                AddAuth(client);
                var genGuid = Guid.NewGuid().ToString();
                using (var httpContent = new MultipartFormDataContent(genGuid))
                {
                    httpContent.Add(new StreamContent(fs),
                        genGuid, Path.GetFileName(filename));
                    using (var response = await client
                        .PostAsync(CleanUrl(url, null), httpContent, cancel))
                    {
                        return await HandleJsonResponseAsync<T>(
                            response, isAsync, cancel);
                    }
                }
            }
        }

        public T PostFile<T>(string url, string filename, bool isAsync)
        {
            var fileTask = PostFileAsync<T>(
                url, filename, isAsync, CancellationToken.None);

            var taskThread = new Thread(() => fileTask.Wait())
            {
                IsBackground = true,
                Name = "MobileLabsApi.PostFile"
            };

            taskThread.Start();
            taskThread.Join();

            return fileTask.Result;
        }

        struct AsyncResponse
        {
            public Guid AsyncResponseId { get; set; }
        }

        private static Guid ReadAsyncResponse(string responseBody)
        {
            var asyncResponse = Deserialize<OperationResult<AsyncResponse>>(
                responseBody);

            if (!asyncResponse.IsSuccess)
            {
                throw new IOException(asyncResponse.ErrorMessage);
            }

            return asyncResponse.Data.AsyncResponseId;
        }

        private static bool HandleAsyncStatus<T>(
            AsyncStatusModel status, out T result)
        {
            if (status.IsComplete)
            {
                result = ((JObject)status.Data).ToObject<T>();
                return true;
            }

            result = default(T);
            return false;
        }

        private async Task<T> HandleJsonResponseAsync<T>(
            HttpResponseMessage response,
            bool isAsync,
            CancellationToken cancel)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ArgumentOutOfRangeException("http-status",
                    response.StatusCode,
                    response.ReasonPhrase + "\n" + responseBody);
            }

            if (isAsync)
            {
                var id = ReadAsyncResponse(responseBody);

                while (true)
                {
                    cancel.ThrowIfCancellationRequested();

                    var status = await this.GetAsyncAsync(id, cancel);

                    T output;
                    if (HandleAsyncStatus(status, out output))
                    {
                        return output;
                    }

                    await Task.Delay(500, cancel);
                }
            }

            return Deserialize<T>(responseBody);
        }

        private T HandleJsonResponse<T>(
            HttpWebResponse response, bool isAsync)
        {
            using (var respStream = response.GetResponseStream())
            using (var readStream = new StreamReader(respStream, Encoding.UTF8))
            {
                var responseBody = readStream.ReadToEnd();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentOutOfRangeException("http-status",
                        response.StatusCode,
                        response.StatusDescription + "\n" + responseBody);
                }

                if (isAsync)
                {
                    var id = ReadAsyncResponse(responseBody);

                    while (true)
                    {
                        var status = this.GetAsync(id);

                        T output;
                        if (HandleAsyncStatus(status, out output))
                        {
                            return output;
                        }

                        Thread.Sleep(500);
                    }
                }

                return Deserialize<T>(responseBody);
            }
        }

        private static void DisposeHttpClient(object client)
        {
            (client as HttpClient).Dispose();
        }

        private static T Deserialize<T>(string input)
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)input;
            }

            return JsonConvert.DeserializeObject<T>(input, _jsonSettings);
        }

        private void AddAuth(HttpClient client)
        {
            // The url passed to the HttpClient must not have a / prefix,
            // but the baseurl must have a / postfix.
            client.BaseAddress = new Uri(_serveruri, "/apiv1/");

            var header = new AuthenticationHeaderValue(
                "Basic", GetAuthBase64String());

            client.DefaultRequestHeaders.Authorization = header;
        }

        private void AddAuth(HttpWebRequest client)
        {
            client.Headers.Add(
                "Authorization",
                "Basic " + GetAuthBase64String());
        }

        private string GetAuthBase64String()
        {
            var iso = Encoding.GetEncoding("ISO-8859-1");
            var isoBytes = iso.GetBytes(_username + ":" + _apikey);
            return Convert.ToBase64String(isoBytes);
        }

        #region MIT Licensed Content

        //These functions are modified versions of those found within FormUrlEncodedContent within corefx

        // Licensed to the .NET Foundation under one or more agreements.
        // The .NET Foundation licenses this file to you under the MIT license.
        // See the LICENSE file in the project root for more information.

        private static string GetUrlWithContent(string url,
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection)
        {
            if (nameValueCollection == null)
            {
                return url;
            }

            if (nameValueCollection.Count == 0)
            {
                return url;
            }

            return url + "?" + EncodeNameValueCollection(nameValueCollection);
        }

        private static string EncodeNameValueCollection(
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection)
        {
            if (nameValueCollection == null ||
                nameValueCollection.Count == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            foreach (var pair in nameValueCollection)
            {
                if (builder.Length > 0)
                {
                    builder.Append('&');
                }

                builder.Append(Encode(pair.Key));
                builder.Append('=');
                builder.Append(Encode(pair.Value));
            }

            return builder.ToString();
        }

        private static byte[] GetContentByteArray(
            IReadOnlyCollection<KeyValuePair<string, string>> nameValueCollection)
        {
            if (nameValueCollection == null)
            {
                throw new ArgumentNullException(nameof(nameValueCollection));
            }

            return Encoding.UTF8.GetBytes(
                EncodeNameValueCollection(nameValueCollection));
        }

        private static string Encode(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }
            // Escape spaces as '+'.
            return Uri.EscapeDataString(data).Replace("%20", "+");
        }
        #endregion
    }

    public class TimeSpanAsMillisecondsConverter : JsonConverter
    {
        public static readonly TimeSpanAsMillisecondsConverter Converter =
            new TimeSpanAsMillisecondsConverter();

        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            var ts = value is TimeSpan?
                ? (TimeSpan?)value
                : null;

            var asString = ts.HasValue
                ? ts.Value.TotalMilliseconds
                : 0;

            serializer.Serialize(writer, asString);
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var value = serializer.Deserialize<double>(reader);
            return TimeSpan.FromMilliseconds(value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) ||
                objectType == typeof(TimeSpan?);
        }
    }
}