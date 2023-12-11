using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILogCaptureApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Gets status of async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>LogCaptureDownloadExecutionResponse</returns>
        
        LogCaptureDownloadExecutionResponse GetDiagnosticsLogcaptureBrowserEntriesDownloadJob (string jobId);

        /// <summary>
        /// Gets status of async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of LogCaptureDownloadExecutionResponse</returns>
        
        ApiResponse<LogCaptureDownloadExecutionResponse> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobWithHttpInfo (string jobId);

        /// <summary>
        /// Creates an async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>LogCaptureDownloadExecutionResponse</returns>
        
        LogCaptureDownloadExecutionResponse PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs (LogCaptureQueryRequest body = null);

        /// <summary>
        /// Creates an async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of LogCaptureDownloadExecutionResponse</returns>
        
        ApiResponse<LogCaptureDownloadExecutionResponse> PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsWithHttpInfo (LogCaptureQueryRequest body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Gets status of async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of LogCaptureDownloadExecutionResponse</returns>
        
        System.Threading.Tasks.Task<LogCaptureDownloadExecutionResponse> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsync (string jobId);

        /// <summary>
        /// Gets status of async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (LogCaptureDownloadExecutionResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LogCaptureDownloadExecutionResponse>> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Creates an async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of LogCaptureDownloadExecutionResponse</returns>
        
        System.Threading.Tasks.Task<LogCaptureDownloadExecutionResponse> PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsync (LogCaptureQueryRequest body = null);

        /// <summary>
        /// Creates an async download execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (LogCaptureDownloadExecutionResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LogCaptureDownloadExecutionResponse>> PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsyncWithHttpInfo (LogCaptureQueryRequest body = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LogCaptureApi : ILogCaptureApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogCaptureApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LogCaptureApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogCaptureApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LogCaptureApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
             return this.Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        /// Gets status of async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>LogCaptureDownloadExecutionResponse</returns>
        
        public LogCaptureDownloadExecutionResponse GetDiagnosticsLogcaptureBrowserEntriesDownloadJob (string jobId)
        {
             ApiResponse<LogCaptureDownloadExecutionResponse> localVarResponse = GetDiagnosticsLogcaptureBrowserEntriesDownloadJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets status of async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of LogCaptureDownloadExecutionResponse</returns>
        
        public ApiResponse< LogCaptureDownloadExecutionResponse > GetDiagnosticsLogcaptureBrowserEntriesDownloadJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling LogCaptureApi->GetDiagnosticsLogcaptureBrowserEntriesDownloadJob");

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/entries/download/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserEntriesDownloadJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserEntriesDownloadJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureDownloadExecutionResponse>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureDownloadExecutionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureDownloadExecutionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets status of async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of LogCaptureDownloadExecutionResponse</returns>
        
        public async System.Threading.Tasks.Task<LogCaptureDownloadExecutionResponse> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsync (string jobId)
        {
             ApiResponse<LogCaptureDownloadExecutionResponse> localVarResponse = await GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets status of async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (LogCaptureDownloadExecutionResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LogCaptureDownloadExecutionResponse>> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling LogCaptureApi->GetDiagnosticsLogcaptureBrowserEntriesDownloadJob");
            

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/entries/download/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserEntriesDownloadJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserEntriesDownloadJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureDownloadExecutionResponse>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureDownloadExecutionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureDownloadExecutionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates an async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>LogCaptureDownloadExecutionResponse</returns>
        
        public LogCaptureDownloadExecutionResponse PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs (LogCaptureQueryRequest body = null)
        {
             ApiResponse<LogCaptureDownloadExecutionResponse> localVarResponse = PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates an async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of LogCaptureDownloadExecutionResponse</returns>
        
        public ApiResponse< LogCaptureDownloadExecutionResponse > PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsWithHttpInfo (LogCaptureQueryRequest body = null)
        { 

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/entries/download/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureDownloadExecutionResponse>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureDownloadExecutionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureDownloadExecutionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates an async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of LogCaptureDownloadExecutionResponse</returns>
        
        public async System.Threading.Tasks.Task<LogCaptureDownloadExecutionResponse> PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsync (LogCaptureQueryRequest body = null)
        {
             ApiResponse<LogCaptureDownloadExecutionResponse> localVarResponse = await PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates an async download execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (LogCaptureDownloadExecutionResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LogCaptureDownloadExecutionResponse>> PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsyncWithHttpInfo (LogCaptureQueryRequest body = null)
        { 

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/entries/download/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureDownloadExecutionResponse>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureDownloadExecutionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureDownloadExecutionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
