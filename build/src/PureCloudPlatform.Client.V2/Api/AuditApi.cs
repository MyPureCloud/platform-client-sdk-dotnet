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
    public interface IAuditApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get service mapping information used in realtime audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuditQueryServiceMapping</returns>
        
        AuditQueryServiceMapping GetAuditsQueryRealtimeServicemapping ();

        /// <summary>
        /// Get service mapping information used in realtime audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuditQueryServiceMapping</returns>
        
        ApiResponse<AuditQueryServiceMapping> GetAuditsQueryRealtimeServicemappingWithHttpInfo ();

        /// <summary>
        /// Get service mapping information used in audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuditQueryServiceMapping</returns>
        
        AuditQueryServiceMapping GetAuditsQueryServicemapping ();

        /// <summary>
        /// Get service mapping information used in audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuditQueryServiceMapping</returns>
        
        ApiResponse<AuditQueryServiceMapping> GetAuditsQueryServicemappingWithHttpInfo ();

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>AuditQueryExecutionStatusResponse</returns>
        
        AuditQueryExecutionStatusResponse GetAuditsQueryTransactionId (string transactionId);

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>ApiResponse of AuditQueryExecutionStatusResponse</returns>
        
        ApiResponse<AuditQueryExecutionStatusResponse> GetAuditsQueryTransactionIdWithHttpInfo (string transactionId);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AuditQueryExecutionResultsResponse</returns>
        
        AuditQueryExecutionResultsResponse GetAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AuditQueryExecutionResultsResponse</returns>
        
        ApiResponse<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AuditQueryExecutionStatusResponse</returns>
        
        AuditQueryExecutionStatusResponse PostAuditsQuery (AuditQueryRequest body);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AuditQueryExecutionStatusResponse</returns>
        
        ApiResponse<AuditQueryExecutionStatusResponse> PostAuditsQueryWithHttpInfo (AuditQueryRequest body);

        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits.
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AuditRealtimeQueryResultsResponse</returns>
        
        AuditRealtimeQueryResultsResponse PostAuditsQueryRealtime (AuditRealtimeQueryRequest body, List<string> expand = null);

        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits.
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AuditRealtimeQueryResultsResponse</returns>
        
        ApiResponse<AuditRealtimeQueryResultsResponse> PostAuditsQueryRealtimeWithHttpInfo (AuditRealtimeQueryRequest body, List<string> expand = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get service mapping information used in realtime audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuditQueryServiceMapping</returns>
        
        System.Threading.Tasks.Task<AuditQueryServiceMapping> GetAuditsQueryRealtimeServicemappingAsync ();

        /// <summary>
        /// Get service mapping information used in realtime audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuditQueryServiceMapping)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuditQueryServiceMapping>> GetAuditsQueryRealtimeServicemappingAsyncWithHttpInfo ();

        /// <summary>
        /// Get service mapping information used in audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuditQueryServiceMapping</returns>
        
        System.Threading.Tasks.Task<AuditQueryServiceMapping> GetAuditsQueryServicemappingAsync ();

        /// <summary>
        /// Get service mapping information used in audits.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuditQueryServiceMapping)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuditQueryServiceMapping>> GetAuditsQueryServicemappingAsyncWithHttpInfo ();

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of AuditQueryExecutionStatusResponse</returns>
        
        System.Threading.Tasks.Task<AuditQueryExecutionStatusResponse> GetAuditsQueryTransactionIdAsync (string transactionId);

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionStatusResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionStatusResponse>> GetAuditsQueryTransactionIdAsyncWithHttpInfo (string transactionId);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AuditQueryExecutionResultsResponse</returns>
        
        System.Threading.Tasks.Task<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsAsync (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionResultsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionResultsResponse>> GetAuditsQueryTransactionIdResultsAsyncWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AuditQueryExecutionStatusResponse</returns>
        
        System.Threading.Tasks.Task<AuditQueryExecutionStatusResponse> PostAuditsQueryAsync (AuditQueryRequest body);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionStatusResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionStatusResponse>> PostAuditsQueryAsyncWithHttpInfo (AuditQueryRequest body);

        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits.
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AuditRealtimeQueryResultsResponse</returns>
        
        System.Threading.Tasks.Task<AuditRealtimeQueryResultsResponse> PostAuditsQueryRealtimeAsync (AuditRealtimeQueryRequest body, List<string> expand = null);

        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits.
        /// </summary>
        /// <remarks>
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AuditRealtimeQueryResultsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuditRealtimeQueryResultsResponse>> PostAuditsQueryRealtimeAsyncWithHttpInfo (AuditRealtimeQueryRequest body, List<string> expand = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuditApi : IAuditApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        /// Get service mapping information used in realtime audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuditQueryServiceMapping</returns>
        
        public AuditQueryServiceMapping GetAuditsQueryRealtimeServicemapping ()
        {
             ApiResponse<AuditQueryServiceMapping> localVarResponse = GetAuditsQueryRealtimeServicemappingWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get service mapping information used in realtime audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuditQueryServiceMapping</returns>
        
        public ApiResponse< AuditQueryServiceMapping > GetAuditsQueryRealtimeServicemappingWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/audits/query/realtime/servicemapping";
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


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryRealtimeServicemapping: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryRealtimeServicemapping: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryServiceMapping>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryServiceMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryServiceMapping)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get service mapping information used in realtime audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuditQueryServiceMapping</returns>
        
        public async System.Threading.Tasks.Task<AuditQueryServiceMapping> GetAuditsQueryRealtimeServicemappingAsync ()
        {
             ApiResponse<AuditQueryServiceMapping> localVarResponse = await GetAuditsQueryRealtimeServicemappingAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get service mapping information used in realtime audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuditQueryServiceMapping)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuditQueryServiceMapping>> GetAuditsQueryRealtimeServicemappingAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/audits/query/realtime/servicemapping";
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


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryRealtimeServicemapping: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryRealtimeServicemapping: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryServiceMapping>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryServiceMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryServiceMapping)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get service mapping information used in audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuditQueryServiceMapping</returns>
        
        public AuditQueryServiceMapping GetAuditsQueryServicemapping ()
        {
             ApiResponse<AuditQueryServiceMapping> localVarResponse = GetAuditsQueryServicemappingWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get service mapping information used in audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuditQueryServiceMapping</returns>
        
        public ApiResponse< AuditQueryServiceMapping > GetAuditsQueryServicemappingWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/audits/query/servicemapping";
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


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryServicemapping: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryServicemapping: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryServiceMapping>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryServiceMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryServiceMapping)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get service mapping information used in audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuditQueryServiceMapping</returns>
        
        public async System.Threading.Tasks.Task<AuditQueryServiceMapping> GetAuditsQueryServicemappingAsync ()
        {
             ApiResponse<AuditQueryServiceMapping> localVarResponse = await GetAuditsQueryServicemappingAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get service mapping information used in audits. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuditQueryServiceMapping)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuditQueryServiceMapping>> GetAuditsQueryServicemappingAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/audits/query/servicemapping";
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


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryServicemapping: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryServicemapping: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryServiceMapping>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryServiceMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryServiceMapping)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>AuditQueryExecutionStatusResponse</returns>
        
        public AuditQueryExecutionStatusResponse GetAuditsQueryTransactionId (string transactionId)
        {
             ApiResponse<AuditQueryExecutionStatusResponse> localVarResponse = GetAuditsQueryTransactionIdWithHttpInfo(transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>ApiResponse of AuditQueryExecutionStatusResponse</returns>
        
        public ApiResponse< AuditQueryExecutionStatusResponse > GetAuditsQueryTransactionIdWithHttpInfo (string transactionId)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling AuditApi->GetAuditsQueryTransactionId");

            var localVarPath = "/api/v2/audits/query/{transactionId}";
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
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of AuditQueryExecutionStatusResponse</returns>
        
        public async System.Threading.Tasks.Task<AuditQueryExecutionStatusResponse> GetAuditsQueryTransactionIdAsync (string transactionId)
        {
             ApiResponse<AuditQueryExecutionStatusResponse> localVarResponse = await GetAuditsQueryTransactionIdAsyncWithHttpInfo(transactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionStatusResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionStatusResponse>> GetAuditsQueryTransactionIdAsyncWithHttpInfo (string transactionId)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling AuditApi->GetAuditsQueryTransactionId");
            

            var localVarPath = "/api/v2/audits/query/{transactionId}";
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
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AuditQueryExecutionResultsResponse</returns>
        
        public AuditQueryExecutionResultsResponse GetAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<AuditQueryExecutionResultsResponse> localVarResponse = GetAuditsQueryTransactionIdResultsWithHttpInfo(transactionId, cursor, pageSize, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AuditQueryExecutionResultsResponse</returns>
        
        public ApiResponse< AuditQueryExecutionResultsResponse > GetAuditsQueryTransactionIdResultsWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling AuditApi->GetAuditsQueryTransactionIdResults");

            var localVarPath = "/api/v2/audits/query/{transactionId}/results";
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
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

            // Query params
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionIdResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionIdResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryExecutionResultsResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryExecutionResultsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryExecutionResultsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AuditQueryExecutionResultsResponse</returns>
        
        public async System.Threading.Tasks.Task<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsAsync (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<AuditQueryExecutionResultsResponse> localVarResponse = await GetAuditsQueryTransactionIdResultsAsyncWithHttpInfo(transactionId, cursor, pageSize, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionResultsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionResultsResponse>> GetAuditsQueryTransactionIdResultsAsyncWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling AuditApi->GetAuditsQueryTransactionIdResults");
            

            var localVarPath = "/api/v2/audits/query/{transactionId}/results";
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
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

            // Query params
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionIdResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuditsQueryTransactionIdResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryExecutionResultsResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryExecutionResultsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryExecutionResultsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create audit query execution 
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AuditQueryExecutionStatusResponse</returns>
        
        public AuditQueryExecutionStatusResponse PostAuditsQuery (AuditQueryRequest body)
        {
             ApiResponse<AuditQueryExecutionStatusResponse> localVarResponse = PostAuditsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create audit query execution 
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AuditQueryExecutionStatusResponse</returns>
        
        public ApiResponse< AuditQueryExecutionStatusResponse > PostAuditsQueryWithHttpInfo (AuditQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuditApi->PostAuditsQuery");

            var localVarPath = "/api/v2/audits/query";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create audit query execution 
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AuditQueryExecutionStatusResponse</returns>
        
        public async System.Threading.Tasks.Task<AuditQueryExecutionStatusResponse> PostAuditsQueryAsync (AuditQueryRequest body)
        {
             ApiResponse<AuditQueryExecutionStatusResponse> localVarResponse = await PostAuditsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create audit query execution 
        /// Use /api/v2/audits/query/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionStatusResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionStatusResponse>> PostAuditsQueryAsyncWithHttpInfo (AuditQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuditApi->PostAuditsQuery");
            

            var localVarPath = "/api/v2/audits/query";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits. 
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AuditRealtimeQueryResultsResponse</returns>
        
        public AuditRealtimeQueryResultsResponse PostAuditsQueryRealtime (AuditRealtimeQueryRequest body, List<string> expand = null)
        {
             ApiResponse<AuditRealtimeQueryResultsResponse> localVarResponse = PostAuditsQueryRealtimeWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits. 
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AuditRealtimeQueryResultsResponse</returns>
        
        public ApiResponse< AuditRealtimeQueryResultsResponse > PostAuditsQueryRealtimeWithHttpInfo (AuditRealtimeQueryRequest body, List<string> expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuditApi->PostAuditsQueryRealtime");

            var localVarPath = "/api/v2/audits/query/realtime";
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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQueryRealtime: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQueryRealtime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditRealtimeQueryResultsResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditRealtimeQueryResultsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditRealtimeQueryResultsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits. 
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AuditRealtimeQueryResultsResponse</returns>
        
        public async System.Threading.Tasks.Task<AuditRealtimeQueryResultsResponse> PostAuditsQueryRealtimeAsync (AuditRealtimeQueryRequest body, List<string> expand = null)
        {
             ApiResponse<AuditRealtimeQueryResultsResponse> localVarResponse = await PostAuditsQueryRealtimeAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits. 
        /// Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AuditRealtimeQueryResultsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuditRealtimeQueryResultsResponse>> PostAuditsQueryRealtimeAsyncWithHttpInfo (AuditRealtimeQueryRequest body, List<string> expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuditApi->PostAuditsQueryRealtime");
            

            var localVarPath = "/api/v2/audits/query/realtime";
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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQueryRealtime: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditsQueryRealtime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditRealtimeQueryResultsResponse>(localVarStatusCode,
                localVarHeaders,
                (AuditRealtimeQueryResultsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditRealtimeQueryResultsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
