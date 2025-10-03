using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using PureCloudPlatform.Client.V2.Extensions;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient
    {
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration and base path (https://api.mypurecloud.com).
        /// </summary>
        public ApiClient()
        {
            // Use TLS 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Configuration = Configuration.Default;
            
            ClientOptions = new ClientRestOptions();
            ClientOptions.BaseUrl = new Uri("https://api.mypurecloud.com");
            RetryConfig = DEFAULT_RETRY_CONFIG;
            AddSerializerSettings();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path (https://api.mypurecloud.com).
        /// </summary>
        /// <param name="config">An instance of Configuration.</param>
        public ApiClient(Configuration config = null)
        {
            // Use TLS 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (config == null)
                Configuration = Configuration.Default;
            else
                Configuration = config;

            ClientOptions = new ClientRestOptions();
            ClientOptions.BaseUrl = new Uri("https://api.mypurecloud.com");

            RetryConfig = DEFAULT_RETRY_CONFIG;
            AddSerializerSettings();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(String basePath = "https://api.mypurecloud.com")
        {
            // Use TLS 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (String.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");

            ClientOptions = new ClientRestOptions();
            ClientOptions.BaseUrl = new Uri(basePath);

            RetryConfig = DEFAULT_RETRY_CONFIG;
            Configuration = Configuration.Default;
            AddSerializerSettings();
        }

        private void AddSerializerSettings()
        {
            serializerSettings.Converters.Add(new Iso8601DateTimeConverter());
            serializerSettings.Converters.Add(new UpgradeSdkEnumConverter());
        }

        /// <summary>
        /// Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The default API client.</value>
        [Obsolete("ApiClient.Default is deprecated, please use 'Configuration.Default.ApiClient' instead.")]
        public static ApiClient Default;

        /// <summary>
        /// Gets or sets the Configuration.
        /// </summary>
        /// <value>An instance of the Configuration.</value>
        public Configuration Configuration { get; set; }

        private RetryConfiguration retryConfig;
        ///<Summary>
        /// Gets or Sets the Retry Configuration
        ///</Summary>
        public RetryConfiguration RetryConfig {
            get
            {
                return this.retryConfig;
            }
            set
            {
                this.retryConfig = value;
            }
        }
        private static readonly RetryConfiguration DEFAULT_RETRY_CONFIG = new RetryConfiguration();

        private GatewayConfiguration gatewayConfig;
        ///<Summary>
        /// Gets or Sets the Gateway Configuration
        ///</Summary>
        public GatewayConfiguration GatewayConfig {
            get
            {
                return this.gatewayConfig;
            }
            set
            {
                if (value != null) {
                    this.gatewayConfig = value;
                } else {
                    // Reset
                    this.gatewayConfig = null;
                }
            }
        }

        private AbstractHttpClient httpClient;
        ///<Summary>
        /// Gets or Sets the HttpClient
        ///</Summary>
        public AbstractHttpClient HttpClient {
            get
            {
                if (httpClient != null) {
                    return this.httpClient;
                } else {
                    httpClient = new DefaultHttpClient(ClientOptions, Configuration);
                    return this.httpClient;
                }
            }
            set
            {
                if (!(value is AbstractHttpClient)) {
                    throw new ArgumentException("httpclient must be an instance of AbstractHttpClient. See DefaultltHttpClient for a prototype");
                }
                httpClient = value;
            }
        }

        ///<Summary>
        /// Sets the ApiClients X509 certificate
        ///</Summary>
        public void SetMTLSCertificates(string certPath, string certPass)
        {
            var cert = new X509Certificate2(
                certPath,
                certPass,
                X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable
            );

            ClientOptions.LocalClientCertificates = new X509CertificateCollection();
            ClientOptions.LocalClientCertificates.Add(cert);
        }

        ///<Summary>
        /// Gets the Login or the API Uri based on Configuration and Gateway Configuration
        ///</Summary>
        public Uri GetConfUri(String pathType, Uri baseUri) {
            if (pathType.Equals("login")) {
                if (this.GatewayConfig == null || String.IsNullOrEmpty(this.GatewayConfig.Host)) {
                    var regex = new Regex(@"://(api)\.");
                    var authUrl = regex.Replace(baseUri.ToString(), "://login.");
                    return new Uri(authUrl);
                } else {
                    String confUrl = this.GatewayConfig.Protocol + "://" + this.GatewayConfig.Host;
                    if (this.GatewayConfig.Port > 0) confUrl = confUrl + ":" + this.GatewayConfig.Port.ToString();
                    if (!String.IsNullOrEmpty(this.GatewayConfig.PathParamsLogin)) {
                        if (this.GatewayConfig.PathParamsLogin.StartsWith("/")) {
                            confUrl = confUrl + this.GatewayConfig.PathParamsLogin;
                        } else {
                            confUrl = confUrl + "/" + this.GatewayConfig.PathParamsLogin;
                        }
                    }
                    return new Uri(confUrl);
                }
            } else {
                if (this.GatewayConfig == null || String.IsNullOrEmpty(this.GatewayConfig.Host)) {
                    return baseUri;
                } else {
                    String confUrl = this.GatewayConfig.Protocol + "://" + this.GatewayConfig.Host;
                    if (this.GatewayConfig.Port > 0) confUrl = confUrl + ":" + this.GatewayConfig.Port.ToString();
                    if (!String.IsNullOrEmpty(this.GatewayConfig.PathParamsApi)) {
                        if (this.GatewayConfig.PathParamsApi.StartsWith("/")) {
                            confUrl = confUrl + this.GatewayConfig.PathParamsApi;
                        } else {
                            confUrl = confUrl + "/" + this.GatewayConfig.PathParamsApi;
                        }
                    }
                    return new Uri(confUrl);
                }
            }
        }

        ///<Summary>
        /// Set Gateway Configuration and credentials
        ///</Summary>
        public void SetGateway(String host,
            String protocol,
            int port,
            String pathParamsLogin,
            String pathParamsApi,
            String username,
            String password) {
            this.GatewayConfig = new GatewayConfiguration(host, protocol, port, pathParamsLogin, pathParamsApi, username, password);
        }

        ///<Summary>
        /// Set Gateway Configuration
        ///</Summary>
        public void SetGateway(String host,
            String protocol,
            int port,
            String pathParamsLogin,
            String pathParamsApi) {
            this.GatewayConfig = new GatewayConfiguration(host, protocol, port, pathParamsLogin, pathParamsApi);
        }
        

        // These fields are only applicable to the Code Authorization OAuth flow:
        ///<Summary>
        /// Defines if Code Authorization is used
        ///</Summary>
        public bool UsingCodeAuth { get; set; }
        ///<Summary>
        /// OAuth Client Id
        ///</Summary>
        public string ClientId { get; set; }
        ///<Summary>
        /// OUuth Client Secret
        ///</Summary>
        public string ClientSecret { get; set; }

        private void HandleExpiredAccessToken()
        {
            if (Monitor.TryEnter(Configuration, 0))
            {
                try
                {
                    Extensions.AuthExtensions.PostToken(this, ClientId, ClientSecret, authorizationCode: Configuration.AuthTokenInfo.RefreshToken, isRefreshRequest: true);
                }
                catch (Exception e)
                {
                    throw new ApiException(500, e.Message);
                }
                finally
                {
                    Monitor.Exit(Configuration);
                }
            }
            else
            {
                // Abort with error if we have waited the configured time and refresh still isn't complete
                if (!Monitor.TryEnter(Configuration, TimeSpan.FromSeconds(Configuration.RefreshTokenWaitTime))) {
                    throw new ApiException(500, $"Token refresh took longer than {Configuration.RefreshTokenWaitTime} seconds");
                }
                else
                {
                    Monitor.Exit(Configuration);
                }
            }
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <returns>Object</returns>
        public Object CallApi(
            String path, String method, List<Tuple<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, IFileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            var requestOptions = new HttpRequestOptions(
                url: path,
                method: method,
                queryParams: queryParams,
                headerParams: headerParams,
                formParams: formParams,
                fileParams: fileParams,
                pathParams: pathParams,
                postBody: postBody,
                contentType: contentType
            );

            // Set SDK version
            requestOptions.AddHeaderParam("purecloud-sdk", "245.0.0");

            Retry retry = new Retry(this.RetryConfig);
            
            ClientOptions.Prefix = "api";

            IHttpResponse response;

            do
            {
                response = HttpClient.Execute(requestOptions);
                Configuration.Logger.Debug(method, path, postBody, (int)response.StatusCode, headerParams);
                Configuration.Logger.Trace(method, path, postBody, (int)response.StatusCode, headerParams, response.Headers ?? new Dictionary<string, string>());

            } while(retry.ShouldRetry(response));

            if (UsingCodeAuth && Configuration.ShouldRefreshAccessToken)
            {
                int statusCode = (int) response.StatusCode;
                if (statusCode == 401)
                {
                    HandleExpiredAccessToken();
                    headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    return CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
                }
            }

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
                Configuration.Logger.Error(method, path, postBody, response.Content, (int)response.StatusCode, headerParams, response.Headers ?? new Dictionary<string, string>());

            return (Object) response;
        }
        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async System.Threading.Tasks.Task<Object> CallApiAsync(
            String path, String method, List<Tuple<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, IFileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            var requestOptions = new HttpRequestOptions(
                url: path,
                method: method,
                queryParams: queryParams,
                headerParams: headerParams,
                formParams: formParams,
                fileParams: fileParams,
                pathParams: pathParams,
                postBody: postBody,
                contentType: contentType
            );

            Retry retry = new Retry(this.RetryConfig);
            
            ClientOptions.Prefix = "api";

            IHttpResponse response;

            do
            {
                response = await HttpClient.ExecuteAsync(requestOptions);
                Configuration.Logger.Debug(method, path, postBody, (int)response.StatusCode, headerParams);
                Configuration.Logger.Trace(method, path, postBody, (int)response.StatusCode, headerParams, response.Headers ?? new Dictionary<string, string>());
            
            } while(retry.ShouldRetry(response));

            if (UsingCodeAuth && Configuration.ShouldRefreshAccessToken)
            {
                int statusCode = (int) response.StatusCode;
                if (statusCode == 401)
                {
                    HandleExpiredAccessToken();
                    headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    return await CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
                }
            }

            return (Object)response;
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return UrlEncode(str);
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is DateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTimeOffset)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is IList)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in (IList)obj)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append(",");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else if (obj is bool)
            {
                return Convert.ToString(obj).ToLower();
            }
            else
                return Convert.ToString (obj);
        }

        /// <summary>
        /// Creates a restclient with a base path string input
        /// </summary>
        /// <returns>Return changed from RestClient to Void . Since no purpose to expose underlying RestClient to Consumer and 
        ///  design changed to One Restclient per API</returns>
        public void setBasePath(String basePath){
            if (String.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");
                
                ClientOptions.BaseUrl = new Uri(basePath);
                

        }
        /// <summary>
        /// Creates a restclient with a PureCloudRegionHost string input
        /// </summary>
        /// <returns>Return changed from RestClient to Void . Since no purpose to expose underlying RestClient to Consumer and 
        ///  design changed to One Restclient per API</returns>
        public void setBasePath(PureCloudRegionHosts region){
             setBasePath(region.GetDescription());
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(IHttpResponse response, Type type)
        {
            Dictionary<string, string> headers = response.Headers;
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            if (type == typeof(Stream))
            {
                if (headers != null)
                {
                    var filePath = String.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, response.RawBytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(response.RawBytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public String Serialize(object obj)
        {
            try
            {
                if (obj != null){
                    return obj is string str ? str : JsonConvert.SerializeObject(obj);
                } else {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public String SelectHeaderContentType(String[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            if (contentTypes.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public String SelectHeaderAccept(String[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return String.Join(",", accepts);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="source">Object to be casted</param>
        /// <param name="dest">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic source, Type dest)
        {
            return Convert.ChangeType(source, dest);
        }

        /// <summary>
        /// Convert stream to byte array
        /// Credit/Ref: http://stackoverflow.com/a/221941/677735
        /// </summary>
        /// <param name="input">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream input)
        {
            byte[] buffer = new byte[16*1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">String to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return filename;
            }
        }

        ///<Summary>
        /// Retry Configuration class
        ///</Summary>
        public class RetryConfiguration
        {
            private long backoffIntervalMs = 300000L;
            private long retryAfterDefaultMs = 3000L;
            private int maxRetryTimeSec = 0;
            private int retryMax = 5;

            ///<Summary>
            /// BackOff Interval (Ms)
            ///</Summary>
            public long BackOffIntervalMs
            {
                get
                {
                    return backoffIntervalMs;
                }

                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("BackOffIntervalMs should be a positive integer");
                    }
                    this.backoffIntervalMs = value;
                }
            }

            ///<Summary>
            /// RetryAfter Default (Ms)
            ///</Summary>
            public long RetryAfterDefaultMs
            {
                get
                {
                    return retryAfterDefaultMs;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("RetryAfterDefaultMs should be a positive integer");
                    }
                    this.retryAfterDefaultMs = value;
                }
            }

            ///<Summary>
            /// Max RetryTime (Sec)
            ///</Summary>
           public int MaxRetryTimeSec
            {
                get
                {
                    return maxRetryTimeSec;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("MaxRetryTimeSec should be a positive integer");
                    }
                    this.maxRetryTimeSec = value;
                }
            }

            ///<Summary>
            /// Retry Max
            ///</Summary>
            public int RetryMax
            {
                get
                {
                    return retryMax;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("RetryMax should be a positive integer");
                    }
                    this.retryMax = value;
                }
            }
        }

        ///<Summary>
        /// Gateway Configuration class
        ///</Summary>
        public class GatewayConfiguration
        {

            // Gateway Host
            private String host = null;

            // Gateway Protocol
            private String protocol = "https";

            // Gateway Port
            private int port = -1;

            // Gateway Path Param for Login
            private String pathParamsLogin = "";

            // Gateway Path Param for API
            private String pathParamsApi = "";

            // Gateway Username (future)
            private String username = null;

            // Gateway Password (future)
            private String password = null;

            ///<Summary>
            /// GatewayConfiguration default constructor
            ///</Summary>
            public GatewayConfiguration()
            {
                this.protocol = "https";
                this.port = -1;
                this.pathParamsLogin = "";
                this.pathParamsApi = "";
            }

            ///<Summary>
            /// GatewayConfiguration constructor with configuration and credentials
            ///</Summary>
            public GatewayConfiguration(String host,
                String protocol,
                int port,
                String pathParamsLogin,
                String pathParamsApi,
                String username,
                String password)
            {
                this.Host = host;
                this.Protocol = protocol;
                this.Port = port;
                this.PathParamsLogin = pathParamsLogin;
                this.PathParamsApi = pathParamsApi;
                this.Username = username;
                this.Password = password;
            }

            ///<Summary>
            /// GatewayConfiguration constructor with configuration
            ///</Summary>
            public GatewayConfiguration(String host,
                String protocol,
                int port,
                String pathParamsLogin,
                String pathParamsApi)
            {
                this.Host = host;
                this.Protocol = protocol;
                this.Port = port;
                this.PathParamsLogin = pathParamsLogin;
                this.PathParamsApi = pathParamsApi;
            }

            ///<Summary>
            /// Gateway Host
            ///</Summary>
            public String Host
            {
                get
                {
                    return this.host;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value)) {
                        this.host = value;
                    }
                }
            }

            ///<Summary>
            /// Gateway Protocol
            ///</Summary>
            public String Protocol
            {
                get
                {
                    return this.protocol;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value)) {
                        this.protocol = value;
                    } else {
                        this.protocol = "https";
                    }
                }
            }

            ///<Summary>
            /// Gateway Port
            ///</Summary>
            public int Port
            {
                get
                {
                    return this.port;
                }
                set
                {
                    if (value > -1) {
                        this.port = value;
                    } else {
                        this.port = -1;
                    }
                }
            }

            ///<Summary>
            /// Gateway Path Params for Login
            ///</Summary>
            public String PathParamsLogin
            {
                get
                {
                    return this.pathParamsLogin;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value)) {
                        this.pathParamsLogin = value;
                        if (this.pathParamsLogin.EndsWith("/")) {
                            this.pathParamsLogin = this.pathParamsLogin.Substring(0, this.pathParamsLogin.Length-1);
                        }
                    } else {
                        this.pathParamsLogin = "";
                    }
                }
            }

            ///<Summary>
            /// Gateway Path Params for Api
            ///</Summary>
            public String PathParamsApi
            {
                get
                {
                    return this.pathParamsApi;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value)) {
                        this.pathParamsApi = value;
                        if (this.pathParamsApi.EndsWith("/")) {
                            this.pathParamsApi = this.pathParamsApi.Substring(0, this.pathParamsApi.Length-1);
                        }
                    } else {
                        this.pathParamsApi = "";
                    }
                }
            }

            ///<Summary>
            /// Username
            ///</Summary>
            public String Username
            {
                get
                {
                    return this.username;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value)) {
                        this.username = value;
                    }
                }
            }

            ///<Summary>
            /// Password
            ///</Summary>
            public String Password
            {
                get
                {
                    return this.password;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value)) {
                        this.password = value;
                    }
                }
            }
        }

        ///<Summary>
        /// ClientOptions
        ///</Summary>
        public ClientRestOptions ClientOptions { get; set; }
        
        private class Retry
        {
            private long backoffIntervalMs;
            private long retryAfterDefaultMs;
            private int maxRetryTimeSec;
            private int maxRetriesBeforeBackoff = 5;
            private int retryCountBeforeBackOff = 0;
            private int retryMax = 5;
            private int retryCount;
            private long retryAfterMs;
            private Stopwatch stopwatch;
            private long defaultMaxRetry = 180000;

            private readonly List<int> statusCodes = new List<int>() { 429, 502, 503, 504 };

            public Retry(RetryConfiguration retryConfiguration)
            {
                this.backoffIntervalMs = retryConfiguration.BackOffIntervalMs;
                this.retryAfterDefaultMs = retryConfiguration.RetryAfterDefaultMs;
                this.maxRetryTimeSec = retryConfiguration.MaxRetryTimeSec;
                this.retryMax = retryConfiguration.RetryMax;
                stopwatch = Stopwatch.StartNew();
            }

            /// <summary>
            /// Check if retryable
            /// </summary>
            /// <param name="response">IHttpResponse</param>
            /// <returns>bool</returns>
            public bool ShouldRetry(IHttpResponse response)
            {
                if (stopwatch.ElapsedMilliseconds < maxRetryTimeSec * 1000L && statusCodes.Contains((int)response.StatusCode) && retryCount <= retryMax)
                {
                   var retryAfterHeader = response.Headers
    .Select(header => new 
    { 
        Key = header.Key,
        Value = header.Value,
    })
    .FirstOrDefault(header => header.Key.Equals("Retry-After"));

                    if (retryAfterHeader != null && Int32.TryParse(retryAfterHeader.Value, out int retryAfterSec))
                    {
                        retryAfterMs =  retryAfterSec * 1000;
                    }
                    else
                    {
                        retryAfterMs = retryAfterDefaultMs;
                    }
                    //If status code is 429 then wait until retry-after time and retry. OR If status code is retryable then for the first 5 times: wait until retry-after time and retry.
                    if ((int)response.StatusCode == 429 || retryCountBeforeBackOff++ < maxRetriesBeforeBackoff)
                    {
                        // Some APIs started sending in daily max limit breach with 429 and retry-after that can be anywhere from few minutes to hours. It is not a pausible option
                        // to retry in such scenarios. For DotNet SDK this retry Max time is set to 3 Minutes.
                        if (retryAfterMs > defaultMaxRetry) {
                           return false;
                        }
                        retryCount++;
                        return waitBeforeRetry(retryAfterMs);
                    }

                    //If status code is 50x then wait for every 3 Sec and retry until 5 minutes then after wait for every 9 Sec and retry until next 5 minutes afterwards wait for every 27 Sec and retry.
                    retryCount++;
                    return waitBeforeRetry(getWaitTimeExp(Math.Min(3, Math.Floor(stopwatch.ElapsedMilliseconds / backoffIntervalMs * 1.0) + 1)));
                }
                stopwatch.Stop();
                return false;
            }

            private bool waitBeforeRetry(long retryAfterMs)
            {
                try
                {
                    Thread.Sleep((int) retryAfterMs);
                }
                catch (ThreadInterruptedException)
                {
                    Thread.CurrentThread.Interrupt();
                }
                return true;
            }

            private long getWaitTimeExp(double bucketCount)
            {
                return (long)Math.Pow(3, bucketCount) * 1000L;
            }
        }
    }
}
