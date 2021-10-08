using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Security.Cryptography;
using PureCloudPlatform.Client.V2.Extensions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using IniParser;
using IniParser.Model;
using IniParser.Exceptions;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Initializes a new instance of the Configuration class with different settings
        /// </summary>
        /// <param name="apiClient">Api client</param>
        /// <param name="defaultHeader">Dictionary of default HTTP header</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="accessToken">accessToken</param>
        /// <param name="apiKey">Dictionary of API key</param>
        /// <param name="apiKeyPrefix">Dictionary of API key prefix</param>
        /// <param name="tempFolderPath">Temp folder path</param>
        /// <param name="dateTimeFormat">DateTime format string</param>
        /// <param name="timeout">HTTP connection timeout (in milliseconds)</param>
        /// <param name="shouldRefreshAccessToken">ShouldRefreshAccessToken</param>
        /// <param name="refreshTokenWaitTime">Refresh token wait time in seconds</param>
        /// <param name="userAgent">HTTP user agent</param>
        /// <param name="configFilePath">Config file path</param>
        /// <param name="autoReloadConfig">AutoReloadConfig</param>
        public Configuration(ApiClient apiClient = null,
                             Dictionary<String, String> defaultHeader = null,
                             string username = null,
                             string password = null,
                             string accessToken = null,
                             Dictionary<String, String> apiKey = null,
                             Dictionary<String, String> apiKeyPrefix = null,
                             string tempFolderPath = null,
                             string dateTimeFormat = null,
                             int timeout = 100000,
                             bool shouldRefreshAccessToken = true,
                             int refreshTokenWaitTime = 10,
                             string userAgent = "PureCloud SDK/dotnet",
                             string configFilePath = null,
                             bool autoReloadConfig = true
                            )
        {
            setApiClientUsingDefault(apiClient);

            Username = username;
            Password = password;
            AuthTokenInfo = new AuthTokenInfo();
            AccessToken = accessToken;
            UserAgent = userAgent;

            if (defaultHeader != null)
                DefaultHeader = defaultHeader;
            if (apiKey != null)
                ApiKey = apiKey;
            if (apiKeyPrefix != null)
                ApiKeyPrefix = apiKeyPrefix;

            TempFolderPath = tempFolderPath;
            DateTimeFormat = dateTimeFormat;
            Timeout = timeout;
            ShouldRefreshAccessToken = shouldRefreshAccessToken;
            RefreshTokenWaitTime = refreshTokenWaitTime;

            Logger = new Logger();

            if (String.IsNullOrEmpty(configFilePath))
            {
                string homePath = (Environment.OSVersion.Platform == PlatformID.Unix ||
                                Environment.OSVersion.Platform == PlatformID.MacOSX)
                    ? Environment.GetEnvironmentVariable("HOME")
                    : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
                ConfigFilePath = Path.Combine(homePath, ".genesysclouddotnet", "config");
            }
            else
            {
                ConfigFilePath = configFilePath;
            }

            AutoReloadConfig = autoReloadConfig;

            if (AutoReloadConfig)
            {
                ThreadStart configCheckerRef = new ThreadStart(runConfigChecker);
                Thread configCheckerThread = new Thread(configCheckerRef);
                configCheckerThread.IsBackground = true;
                configCheckerThread.Start();
            }
        }

        /// <summary>
        /// Initializes a new instance of the Configuration class.
        /// </summary>
        /// <param name="apiClient">Api client.</param>
        public Configuration(ApiClient apiClient)
        {
            setApiClientUsingDefault(apiClient);
        }

        private void applyConfigFromFile()
        {
            ConfigurationParser parser = new ConfigurationParser(ConfigFilePath);
            if (!parser.Read())
                return;

            // Logging
            string logLevel = parser.GetString("logging", "log_level");
            if (!String.IsNullOrEmpty(logLevel))
                Logger.Level = Logger.LogLevelFromString(logLevel);

            string logFormat = parser.GetString("logging", "log_format");
            if (!String.IsNullOrEmpty(logFormat))
                Logger.Format = Logger.LogFormatFromString(logFormat);

            if (!String.IsNullOrEmpty(parser.GetString("logging", "log_to_console")))
                Logger.LogToConsole = parser.GetBool("logging", "log_to_console");

            string logFilePath = parser.GetString("logging", "log_file_path");
            if (!String.IsNullOrEmpty(logFilePath))
                Logger.LogFilePath = logFilePath;

            if (!String.IsNullOrEmpty(parser.GetString("logging", "log_request_body")))
                Logger.LogRequestBody = parser.GetBool("logging", "log_request_body");

            if (!String.IsNullOrEmpty(parser.GetString("logging", "log_response_body")))
                Logger.LogResponseBody = parser.GetBool("logging", "log_response_body");

            // General
            string host = parser.GetString("general", "host");
            if (!String.IsNullOrEmpty(host))
                ApiClient.setBasePath(host);

            if (!String.IsNullOrEmpty(parser.GetString("general", "live_reload_config")))
                AutoReloadConfig = parser.GetBool("general", "live_reload_config");

            // Re-authentication
            if (!String.IsNullOrEmpty(parser.GetString("reauthentication", "refresh_access_token")))
                ShouldRefreshAccessToken = parser.GetBool("reauthentication", "refresh_access_token");

            if (!String.IsNullOrEmpty(parser.GetString("reauthentication", "refresh_token_wait_max")))
                RefreshTokenWaitTime = parser.GetInt("reauthentication", "refresh_token_wait_max");

            // Retry
            if (!String.IsNullOrEmpty(parser.GetString("retry", "retry_wait_max")))
                ApiClient.RetryConfig.MaxRetryTimeSec = parser.GetInt("retry", "retry_wait_max");

            if (!String.IsNullOrEmpty(parser.GetString("retry", "retry_max")))
                ApiClient.RetryConfig.RetryMax = parser.GetInt("retry", "retry_max");
        }

        private void runConfigChecker()
        {
            try
            {
                var configDir = Path.GetDirectoryName(ConfigFilePath);
                var configFile = Path.GetFileName(ConfigFilePath);
                while (!Directory.Exists(configDir))
                {
                    configDir = Path.GetDirectoryName(configDir);
                    if (configDir == "") return;
                }
            
                watcher = new FileSystemWatcher()
                {
                    Path = configDir,
                    IncludeSubdirectories = true,
                    Filter = configFile,
                    EnableRaisingEvents = true
                };
                onChangedHandler = new FileSystemEventHandler(onChanged);
                watcher.Changed += onChangedHandler;
            }
            catch (Exception e)
            {
                // no-op
            }
        }

        private void onChanged(object source, FileSystemEventArgs e)
        {
            if (!AutoReloadConfig)
            {
                watcher.Changed -= onChangedHandler;
                return;
            }
            applyConfigFromFile();
        }

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "132.0.0";

        /// <summary>
        /// Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static Configuration Default = new Configuration();

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        /// <value>Timeout.</value>
        public int Timeout
        {
            get { return ApiClient.RestClient.Timeout; }

            set
            {
                if (ApiClient != null)
                    ApiClient.RestClient.Timeout = value;
            }
        }

        /// <summary>
        /// Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The API client.</value>
        public ApiClient ApiClient;

        /// <summary>
        /// Set the ApiClient using Default or ApiClient instance.
        /// </summary>
        /// <param name="apiClient">An instance of ApiClient.</param>
        /// <returns></returns>
        public void setApiClientUsingDefault (ApiClient apiClient = null)
        {
            AuthTokenInfo = new AuthTokenInfo();
            if (apiClient == null)
            {
                if (Default != null && Default.ApiClient == null)
                    Default.ApiClient = new ApiClient(this);

                ApiClient = Default != null ? Default.ApiClient : new ApiClient(this);
            }
            else
            {
                if (Default != null && Default.ApiClient == null)
                    Default.ApiClient = apiClient;

                ApiClient = apiClient;
            }
        }

        private Dictionary<String, String> _defaultHeaderMap = new Dictionary<String, String>();

        /// <summary>
        /// Gets or sets the default header.
        /// </summary>
        public Dictionary<String, String> DefaultHeader
        {
            get { return _defaultHeaderMap; }

            set
            {
                _defaultHeaderMap = value;
            }
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap.Add(key, value);
        }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public String UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public String Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public String Password { get; set; }

        /// <summary>
        /// Gets or sets the AuthTokenInfo for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public AuthTokenInfo AuthTokenInfo { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public String AccessToken
        {
            get
            { 
                return AuthTokenInfo.AccessToken;
            }

            set
            {
                AuthTokenInfo.AccessToken = value;
            }
        }

        /// <summary>
        /// Gets or sets the flag to indicate whether the access token should be refreshed transparently when using the Code Authorization flow.
        /// </summary>
        /// <value>The access token transparent refresh flag.</value>
        public bool ShouldRefreshAccessToken { get; set; }

        /// <summary>
        /// The amount of time other threads will wait for a thread to request a new access token when it expires.
        /// </summary>
        /// <value>The access token transparent refresh flag.</value>
        public int RefreshTokenWaitTime { get; set; }

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public Dictionary<String, String> ApiKey = new Dictionary<String, String>();

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public Dictionary<String, String> ApiKeyPrefix = new Dictionary<String, String>();

        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix (string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            ApiKey.TryGetValue (apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (ApiKeyPrefix.TryGetValue (apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }

        private string _tempFolderPath = Path.GetTempPath();

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public String TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _tempFolderPath = value;
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                    Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value  + Path.DirectorySeparatorChar;
            }
        }

        private const string ISO8601_DATETIME_FORMAT = "o";

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public String DateTimeFormat
        {
            get
            {
                return _dateTimeFormat;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the Logger.
        /// </summary>
        /// <value>Instance of Logger.</value>
        public Logger Logger { get; set; }

        private string configFilePath;

        /// <summary>
        /// Gets or sets the ConfigFilePath value.
        /// </summary>
        /// <value>ConfigFilePath</value>
        public string ConfigFilePath { get { return configFilePath; }
            set
            {
                configFilePath = value;
                applyConfigFromFile();
            }
        }

        /// <summary>
        /// Gets or sets the AutoReloadConfig value.
        /// </summary>
        /// <value>AutoReloadConfig</value>
        public bool AutoReloadConfig { get; set; }

        private FileSystemWatcher watcher;

        private FileSystemEventHandler onChangedHandler;

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static String ToDebugReport()
        {
            String report = "C# SDK (PureCloudPlatform.Client.V2) Debug Report:\n";
            
            report += "    OS: " + Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + Assembly
                     .GetExecutingAssembly()
                     .GetReferencedAssemblies()
                     .Where(x => x.Name == "System.Core").First().Version.ToString()  + "\n";
            
            report += "    Version of the API: v2\n";
            report += "    SDK Package Version: 132.0.0\n";

            return report;
        }

        private class ConfigurationParser
        {
            public ConfigurationParser(string filePath)
            {
                _filePath = filePath;
                _fileFormat = FileFormat.Invalid;
            }

            private string _filePath;

            private FileFormat _fileFormat;

            private IniData _iniData;

            private JObject _jsonData;

            public bool Read()
            {
                try
                {
                    var parser = new FileIniDataParser();
                    _iniData = parser.ReadFile(_filePath);
                    _fileFormat = FileFormat.INI;
                }
                catch (ParsingException e)
                {
                    if (e.GetBaseException().GetType() == typeof(FileNotFoundException))
                    {
                        return false;
                    }
                    else
                    {
                        try
                        {
                            _jsonData = JObject.Parse(File.ReadAllText(_filePath));
                            _fileFormat = FileFormat.JSON;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public string GetString(string section, string key)
            {
                switch (_fileFormat)
                {
                    case FileFormat.INI:
                        return getIniString(section, key);
                    case FileFormat.JSON:
                        return getJsonString(section, key);
                }

                return "";
            }

            public bool GetBool(string section, string key)
            {
                switch (_fileFormat)
                {
                    case FileFormat.INI:
                        return getIniBool(section, key);
                    case FileFormat.JSON:
                        return getJsonBool(section, key);
                }

                return false;
            }

            public int GetInt(string section, string key)
            {
                switch (_fileFormat)
                {
                    case FileFormat.INI:
                        return getIniInt(section, key);
                    case FileFormat.JSON:
                        return getJsonInt(section, key);
                }

                return -1;
            }

            private string getJsonString(string section, string key)
            {
                try
                {
                    JObject sectionData = (JObject) _jsonData.GetValue(section);
                    return sectionData.GetValue(key).ToString().Trim();
                }
                catch (Exception)
                {
                    return "";
                }
            }

            private bool getJsonBool(string section, string key)
            {
                try
                {
                    JObject sectionData = (JObject) _jsonData.GetValue(section);
                    return sectionData.GetValue(key).ToObject<Boolean>();
                }
                catch (Exception)
                {
                    return false;
                }
            }

            private int getJsonInt(string section, string key)
            {
                try
                {
                    JObject sectionData = (JObject) _jsonData.GetValue(section);
                    return sectionData.GetValue(key).ToObject<Int32>();
                }
                catch (Exception)
                {
                    return -1;
                }
            }

            private string getIniString(string section, string key)
            {
                try
                {
                    return _iniData[section][key].Trim().ToLower();
                } catch (Exception) {
                    return "";
                }
            }

            private bool getIniBool(string section, string key)
            {
                try
                {
                    return Boolean.Parse(getIniString(section, key));
                } catch (Exception) {
                    return false;
                }
            }

            private int getIniInt(string section, string key)
            {
                try
                {
                    return Int32.Parse(getIniString(section, key));
                } catch (Exception) {
                    return -1;
                }
            }

            private enum FileFormat
            {
                INI,
                JSON,
                Invalid
            }
        }
    }
}