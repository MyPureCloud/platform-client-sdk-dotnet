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
        /// Disable browser log capture for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns></returns>
        
        void DeleteDiagnosticsLogcaptureBrowserUser (string userId);

        /// <summary>
        /// Disable browser log capture for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteDiagnosticsLogcaptureBrowserUserWithHttpInfo (string userId);

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
        /// Get log capture configuration for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>LogCaptureUserConfiguration</returns>
        
        LogCaptureUserConfiguration GetDiagnosticsLogcaptureBrowserUser (string userId);

        /// <summary>
        /// Get log capture configuration for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>ApiResponse of LogCaptureUserConfiguration</returns>
        
        ApiResponse<LogCaptureUserConfiguration> GetDiagnosticsLogcaptureBrowserUserWithHttpInfo (string userId);

        /// <summary>
        /// Get all log capture enabled users for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>PagelessEntityListing</returns>
        
        PagelessEntityListing GetDiagnosticsLogcaptureBrowserUsers (bool? includeExpired = null);

        /// <summary>
        /// Get all log capture enabled users for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>ApiResponse of PagelessEntityListing</returns>
        
        ApiResponse<PagelessEntityListing> GetDiagnosticsLogcaptureBrowserUsersWithHttpInfo (bool? includeExpired = null);

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

        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>LogCaptureQueryResponse</returns>
        
        LogCaptureQueryResponse PostDiagnosticsLogcaptureBrowserEntriesQuery (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null);

        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of LogCaptureQueryResponse</returns>
        
        ApiResponse<LogCaptureQueryResponse> PostDiagnosticsLogcaptureBrowserEntriesQueryWithHttpInfo (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null);

        /// <summary>
        /// Enable log capture for a user or update expiration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>LogCaptureUserConfiguration</returns>
        
        LogCaptureUserConfiguration PostDiagnosticsLogcaptureBrowserUser (string userId, LogCaptureUserConfiguration body = null);

        /// <summary>
        /// Enable log capture for a user or update expiration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of LogCaptureUserConfiguration</returns>
        
        ApiResponse<LogCaptureUserConfiguration> PostDiagnosticsLogcaptureBrowserUserWithHttpInfo (string userId, LogCaptureUserConfiguration body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Disable browser log capture for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteDiagnosticsLogcaptureBrowserUserAsync (string userId);

        /// <summary>
        /// Disable browser log capture for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo (string userId);

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
        /// Get log capture configuration for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>Task of LogCaptureUserConfiguration</returns>
        
        System.Threading.Tasks.Task<LogCaptureUserConfiguration> GetDiagnosticsLogcaptureBrowserUserAsync (string userId);

        /// <summary>
        /// Get log capture configuration for the user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>Task of ApiResponse (LogCaptureUserConfiguration)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LogCaptureUserConfiguration>> GetDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo (string userId);

        /// <summary>
        /// Get all log capture enabled users for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>Task of PagelessEntityListing</returns>
        
        System.Threading.Tasks.Task<PagelessEntityListing> GetDiagnosticsLogcaptureBrowserUsersAsync (bool? includeExpired = null);

        /// <summary>
        /// Get all log capture enabled users for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>Task of ApiResponse (PagelessEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<PagelessEntityListing>> GetDiagnosticsLogcaptureBrowserUsersAsyncWithHttpInfo (bool? includeExpired = null);

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

        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of LogCaptureQueryResponse</returns>
        
        System.Threading.Tasks.Task<LogCaptureQueryResponse> PostDiagnosticsLogcaptureBrowserEntriesQueryAsync (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null);

        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (LogCaptureQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LogCaptureQueryResponse>> PostDiagnosticsLogcaptureBrowserEntriesQueryAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null);

        /// <summary>
        /// Enable log capture for a user or update expiration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of LogCaptureUserConfiguration</returns>
        
        System.Threading.Tasks.Task<LogCaptureUserConfiguration> PostDiagnosticsLogcaptureBrowserUserAsync (string userId, LogCaptureUserConfiguration body = null);

        /// <summary>
        /// Enable log capture for a user or update expiration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (LogCaptureUserConfiguration)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LogCaptureUserConfiguration>> PostDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo (string userId, LogCaptureUserConfiguration body = null);

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
        /// Disable browser log capture for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns></returns>
        
        public void DeleteDiagnosticsLogcaptureBrowserUser (string userId)
        {
             DeleteDiagnosticsLogcaptureBrowserUserWithHttpInfo(userId);
        }

        /// <summary>
        /// Disable browser log capture for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteDiagnosticsLogcaptureBrowserUserWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LogCaptureApi->DeleteDiagnosticsLogcaptureBrowserUser");

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDiagnosticsLogcaptureBrowserUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDiagnosticsLogcaptureBrowserUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Disable browser log capture for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteDiagnosticsLogcaptureBrowserUserAsync (string userId)
        {
             await DeleteDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Disable browser log capture for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to disable browser log capture</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LogCaptureApi->DeleteDiagnosticsLogcaptureBrowserUser");
            

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDiagnosticsLogcaptureBrowserUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDiagnosticsLogcaptureBrowserUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
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
        /// Get log capture configuration for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>LogCaptureUserConfiguration</returns>
        
        public LogCaptureUserConfiguration GetDiagnosticsLogcaptureBrowserUser (string userId)
        {
             ApiResponse<LogCaptureUserConfiguration> localVarResponse = GetDiagnosticsLogcaptureBrowserUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get log capture configuration for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>ApiResponse of LogCaptureUserConfiguration</returns>
        
        public ApiResponse< LogCaptureUserConfiguration > GetDiagnosticsLogcaptureBrowserUserWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LogCaptureApi->GetDiagnosticsLogcaptureBrowserUser");

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureUserConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureUserConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureUserConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get log capture configuration for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>Task of LogCaptureUserConfiguration</returns>
        
        public async System.Threading.Tasks.Task<LogCaptureUserConfiguration> GetDiagnosticsLogcaptureBrowserUserAsync (string userId)
        {
             ApiResponse<LogCaptureUserConfiguration> localVarResponse = await GetDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get log capture configuration for the user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to get browser log capture configuration</param>
        /// <returns>Task of ApiResponse (LogCaptureUserConfiguration)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LogCaptureUserConfiguration>> GetDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LogCaptureApi->GetDiagnosticsLogcaptureBrowserUser");
            

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureUserConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureUserConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureUserConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all log capture enabled users for an org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>PagelessEntityListing</returns>
        
        public PagelessEntityListing GetDiagnosticsLogcaptureBrowserUsers (bool? includeExpired = null)
        {
             ApiResponse<PagelessEntityListing> localVarResponse = GetDiagnosticsLogcaptureBrowserUsersWithHttpInfo(includeExpired);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all log capture enabled users for an org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>ApiResponse of PagelessEntityListing</returns>
        
        public ApiResponse< PagelessEntityListing > GetDiagnosticsLogcaptureBrowserUsersWithHttpInfo (bool? includeExpired = null)
        { 

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users";
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
            if (includeExpired != null) localVarQueryParams.Add(new Tuple<string, string>("includeExpired", this.Configuration.ApiClient.ParameterToString(includeExpired)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagelessEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PagelessEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagelessEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all log capture enabled users for an org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>Task of PagelessEntityListing</returns>
        
        public async System.Threading.Tasks.Task<PagelessEntityListing> GetDiagnosticsLogcaptureBrowserUsersAsync (bool? includeExpired = null)
        {
             ApiResponse<PagelessEntityListing> localVarResponse = await GetDiagnosticsLogcaptureBrowserUsersAsyncWithHttpInfo(includeExpired);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all log capture enabled users for an org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeExpired">Include expired users with log captures still available for search or download (optional, default to false)</param>
        /// <returns>Task of ApiResponse (PagelessEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<PagelessEntityListing>> GetDiagnosticsLogcaptureBrowserUsersAsyncWithHttpInfo (bool? includeExpired = null)
        { 

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users";
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
            if (includeExpired != null) localVarQueryParams.Add(new Tuple<string, string>("includeExpired", this.Configuration.ApiClient.ParameterToString(includeExpired)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDiagnosticsLogcaptureBrowserUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagelessEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PagelessEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagelessEntityListing)),
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



        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>LogCaptureQueryResponse</returns>
        
        public LogCaptureQueryResponse PostDiagnosticsLogcaptureBrowserEntriesQuery (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null)
        {
             ApiResponse<LogCaptureQueryResponse> localVarResponse = PostDiagnosticsLogcaptureBrowserEntriesQueryWithHttpInfo(before, after, pageSize, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of LogCaptureQueryResponse</returns>
        
        public ApiResponse< LogCaptureQueryResponse > PostDiagnosticsLogcaptureBrowserEntriesQueryWithHttpInfo (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null)
        { 

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/entries/query";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of LogCaptureQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<LogCaptureQueryResponse> PostDiagnosticsLogcaptureBrowserEntriesQueryAsync (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null)
        {
             ApiResponse<LogCaptureQueryResponse> localVarResponse = await PostDiagnosticsLogcaptureBrowserEntriesQueryAsyncWithHttpInfo(before, after, pageSize, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (LogCaptureQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LogCaptureQueryResponse>> PostDiagnosticsLogcaptureBrowserEntriesQueryAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null)
        { 

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/entries/query";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserEntriesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Enable log capture for a user or update expiration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>LogCaptureUserConfiguration</returns>
        
        public LogCaptureUserConfiguration PostDiagnosticsLogcaptureBrowserUser (string userId, LogCaptureUserConfiguration body = null)
        {
             ApiResponse<LogCaptureUserConfiguration> localVarResponse = PostDiagnosticsLogcaptureBrowserUserWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enable log capture for a user or update expiration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of LogCaptureUserConfiguration</returns>
        
        public ApiResponse< LogCaptureUserConfiguration > PostDiagnosticsLogcaptureBrowserUserWithHttpInfo (string userId, LogCaptureUserConfiguration body = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LogCaptureApi->PostDiagnosticsLogcaptureBrowserUser");

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureUserConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureUserConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureUserConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Enable log capture for a user or update expiration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of LogCaptureUserConfiguration</returns>
        
        public async System.Threading.Tasks.Task<LogCaptureUserConfiguration> PostDiagnosticsLogcaptureBrowserUserAsync (string userId, LogCaptureUserConfiguration body = null)
        {
             ApiResponse<LogCaptureUserConfiguration> localVarResponse = await PostDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enable log capture for a user or update expiration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to enable browser log capture</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (LogCaptureUserConfiguration)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LogCaptureUserConfiguration>> PostDiagnosticsLogcaptureBrowserUserAsyncWithHttpInfo (string userId, LogCaptureUserConfiguration body = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LogCaptureApi->PostDiagnosticsLogcaptureBrowserUser");
            

            var localVarPath = "/api/v2/diagnostics/logcapture/browser/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDiagnosticsLogcaptureBrowserUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogCaptureUserConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LogCaptureUserConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogCaptureUserConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
