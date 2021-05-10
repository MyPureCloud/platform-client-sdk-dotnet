using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// SDK Logger
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Initializes a new instance of the Logger class
        /// </summary>
        /// <param name="logFilePath">Log file path</param>
        /// <param name="logToConsole">Log to console bool</param>
        /// <param name="logFormat">Log format</param>
        /// <param name="logLevel">Log level</param>
        /// <param name="logResponseBody">Log response body bool</param>
        /// <param name="logRequestBody">Log request body bool</param>
        internal Logger(string logFilePath = null,
                      bool logToConsole = true,
                      LogFormat logFormat = LogFormat.Text,
                      LogLevel logLevel = LogLevel.LNone,
                      bool logResponseBody = false,
                      bool logRequestBody = false
                      )
        {
            this.logFilePath = logFilePath;
            LogToConsole = logToConsole;
            Format = logFormat;
            Level = logLevel;
            LogResponseBody = logResponseBody;
            LogRequestBody = logRequestBody;
        }

        private string logFilePath;

        /// <summary>
        /// Gets or sets the LogFilePath.
        /// </summary>
        /// <value>LogFilePath</value>
        public string LogFilePath {
            get
            {
                return logFilePath;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    try
                    {
                        fs = File.Open(value, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        logFilePath = value;
                    }
                    catch (Exception)
                    {
                        // no-op
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the LogToConsole value.
        /// </summary>
        /// <value>LogToConsole</value>
        public bool LogToConsole { get; set; }

        /// <summary>
        /// Gets or sets the Log Format.
        /// </summary>
        /// <value>Format</value>
        public LogFormat? Format { get; set; }

        /// <summary>
        /// Gets or sets the Log Level.
        /// </summary>
        /// <value>Level</value>
        public LogLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets the LogResponseBody value.
        /// </summary>
        /// <value>LogResponseBody</value>
        public bool LogResponseBody { get; set; }

        /// <summary>
        /// Gets or sets the LogRequestBody value.
        /// </summary>
        /// <value>LogRequestBody</value>
        public bool LogRequestBody { get; set; }

        private FileStream fs;

        /// <summary>
        /// Parses a LogLevel value from a string
        /// </summary>
        /// <param name="logLevel">log level value as a string</param>
        /// <returns>LogLevel</returns>
        internal static LogLevel? LogLevelFromString(string logLevel)
        {
            logLevel = "l" + logLevel;
            try
            {
                LogLevel logLevelValue = (LogLevel) Enum.Parse(typeof(LogLevel), logLevel, true);
                if (Enum.IsDefined(typeof(LogLevel), logLevelValue) | logLevelValue.ToString().Contains(","))
                    return logLevelValue;
                else
                    return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        /// <summary>
        /// Parses a LogFormat value from a string
        /// </summary>
        /// <param name="logFormat">log format value as a string</param>
        /// <returns>LogFormat</returns>
        internal static LogFormat? LogFormatFromString(string logFormat)
        {
            try
            {
                LogFormat logFormatValue = (LogFormat) Enum.Parse(typeof(LogFormat), logFormat, true);
                if (Enum.IsDefined(typeof(LogFormat), logFormatValue) | logFormatValue.ToString().Contains(","))
                    return logFormatValue;
                else
                    return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a trace-level message
        /// </summary>
        /// <param name="method">HTTP Method</param>
        /// <param name="url">URL</param>
        /// <param name="requestBody">Request body</param>
        /// <param name="statusCode">HTTP status code</param>
        /// <param name="requestHeaders">Request headers</param>
        /// <param name="responseHeaders">Response headers</param>
        internal void Trace(string method,
                          string url,
                          object requestBody,
                          int statusCode,
                          Dictionary<String, String> requestHeaders,
                          Dictionary<String, String> responseHeaders)
        {
            LogStatement logStatement = new LogStatement(
                DateTime.UtcNow,
                "trace",
                method,
                url,
                requestHeaders,
                responseHeaders,
                statusCode,
                requestBodyToString(requestBody)
            );

            log(LogLevel.LTrace, logStatement);
        }

        /// <summary>
        /// Logs a debug-level message
        /// </summary>
        /// <param name="method">HTTP Method</param>
        /// <param name="url">URL</param>
        /// <param name="requestBody">Request body</param>
        /// <param name="statusCode">HTTP status code</param>
        /// <param name="requestHeaders">Request headers</param>
        internal void Debug(string method,
                          string url,
                          object requestBody,
                          int statusCode,
                          Dictionary<String, String> requestHeaders)
        {
            LogStatement logStatement = new LogStatement(
                DateTime.UtcNow,
                "debug",
                method,
                url,
                requestHeaders,
                statusCode: statusCode,
                requestBody: requestBodyToString(requestBody)
            );

            log(LogLevel.LDebug, logStatement);
        }

        /// <summary>
        /// Logs an error-level message
        /// </summary>
        /// <param name="method">HTTP Method</param>
        /// <param name="url">URL</param>
        /// <param name="requestBody">Request body</param>
        /// <param name="responseBody">Response body</param>
        /// <param name="statusCode">HTTP status code</param>
        /// <param name="requestHeaders">Request headers</param>
        /// <param name="responseHeaders">Response headers</param>
        internal void Error(string method,
                          string url,
                          object requestBody,
                          string responseBody,
                          int statusCode,
                          Dictionary<String, String> requestHeaders,
                          Dictionary<String, String> responseHeaders)
        {
            LogStatement logStatement = new LogStatement(
                DateTime.UtcNow,
                "error",
                method,
                url,
                requestHeaders,
                responseHeaders,
                statusCode,
                requestBodyToString(requestBody),
                responseBody
            );

            log(LogLevel.LError, logStatement);
        }

        private void log(LogLevel logLevel, LogStatement logStatement)
        {
            if (logLevel >= Level)
            {
                string logString = logStatement.AsString(Format, LogRequestBody, LogResponseBody);
                if (LogToConsole)
                    Console.WriteLine(logString);

                if (fs != null)
                {
                    try
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(String.Format("{0}\n", logString));
                        fs.Write(info, 0, info.Length);
                        fs.Flush();
                    }
                    catch (Exception)
                    {
                        // no-op
                    }
                }
            }
        }

        private static string requestBodyToString(object requestBody)
        {
            if (requestBody != null)
            {
                if (requestBody.GetType() == typeof(String))
                    return requestBody.ToString();
                else if (requestBody.GetType() == typeof(byte[]))
                    return System.Text.Encoding.UTF8.GetString((byte[])requestBody);
            }

            return null;
        }
    }

    /// <summary>
    /// LogFormat
    /// </summary>
    /// <value>LogFormat</value>
    public enum LogFormat
    {
        /// <summary>
        /// Enum JSON
        /// </summary>
        JSON,
        /// <summary>
        /// Enum Text
        /// </summary>
        Text
    }

    /// <summary>
    /// LogLevel
    /// </summary>
    /// <value>LogLevel</value>
    public enum LogLevel
    {
        /// <summary>
        /// Enum LTrace
        /// </summary>
        LTrace,
        /// <summary>
        /// Enum LDebug
        /// </summary>
        LDebug,
        /// <summary>
        /// Enum LError
        /// </summary>
        LError,
        /// <summary>
        /// Enum LNone
        /// </summary>
        LNone
    }

    /// <summary>
    /// LogStatement
    /// </summary>
    class LogStatement
    {
        /// <summary>
        /// Initializes a new instance of the Logger LogStatement
        /// </summary>
        /// <param name="date">date</param>
        /// <param name="level">level</param>
        /// <param name="method">method</param>
        /// <param name="url">url</param>
        /// <param name="requestHeaders">requestHeaders</param>
        /// <param name="responseHeaders">responseHeaders</param>
        /// <param name="statusCode">statusCode</param>
        /// <param name="requestBody">requestBody</param>
        /// <param name="responseBody">responseBody</param>
        public LogStatement(DateTime date,
                            string level = null,
                            string method = null,
                            string url = null,
                            Dictionary<String, String> requestHeaders = null,
                            Dictionary<String, String> responseHeaders = null,
                            int statusCode = 0,
                            string requestBody = null,
                            string responseBody = null
        )
        {
            this.date = date;
            this.level = level;
            this.method = method;
            this.url = url;
            this.requestHeaders = requestHeaders;
            this.responseHeaders = responseHeaders;
            this.correlationId = getCorrelationId(responseHeaders);
            this.statusCode = statusCode;
            this.requestBody = requestBody;
            this.responseBody = responseBody;
        }

        [JsonProperty]
        private DateTime date;
        [JsonProperty]
        private string level;
        [JsonProperty]
        private string method;
        [JsonProperty]
        private string url;
        [JsonProperty]
        private Dictionary<String, String> requestHeaders;
        [JsonProperty]
        private Dictionary<String, String> responseHeaders;
        [JsonProperty]
        private string correlationId;
        [JsonProperty]
        private int statusCode;
        [JsonProperty]
        private string requestBody;
        [JsonProperty]
        private string responseBody;

        /// <summary>
        /// Returns a string representation of the log statement
        /// </summary>
        /// <param name="logFormat">Log format</param>
        /// <param name="logRequestBody">Log request body bool</param>
        /// <param name="logResponseBody">Log response body bool</param>
        /// <return>String representation of the log statement</return>
        public string AsString(LogFormat? logFormat, bool logRequestBody, bool logResponseBody)
        {
            requestHeaders["Authorization"] = "[REDACTED]";

            if (!logRequestBody)
                requestBody = null;
            if (!logResponseBody)
                responseBody = null;

            if (logFormat == LogFormat.JSON)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                };

                return JsonConvert.SerializeObject(this, settings);
            }

            return String.Format(@"{0}: {1}
=== REQUEST ==={2}{3}{4}{5}
=== RESPONSE ==={6}{7}{8}{9}", level.ToUpper(),
                            date,
                            formatValue("URL", url),
                            formatValue("Method", method),
                            formatValue("Headers", formatHeaders(requestHeaders)),
                            formatValue("Body", requestBody),

                            formatValue("Status", String.Format("{0}", statusCode)),
                            formatValue("Headers", formatHeaders(responseHeaders)),
                            formatValue("CorrelationId", correlationId),
                            formatValue("Body", responseBody));
        }

        private string formatValue(string name, string value)
        {
            return String.IsNullOrEmpty(value) ? "" : String.Format("\n{0}: {1}", name, value);
        }

        private string formatHeaders(Dictionary<String, String> headers)
        {
            if (headers == null)
                return "";

            string result = "";
            foreach(var item in headers)
                result += String.Format("\n\t{0}: {1}", item.Key, item.Value);

            return result;
        }

        private string getCorrelationId(Dictionary<String, String> headers)
        {
            if (headers == null)
                return "";

            string correlationId = "";
            headers.TryGetValue("ININ-Correlation-Id", out correlationId);

            return correlationId;
        }
    }
}