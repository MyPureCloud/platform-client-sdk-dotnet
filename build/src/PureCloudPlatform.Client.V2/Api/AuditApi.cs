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
        /// <param name="pageSize">Page size (optional, default to 25)</param>
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
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AuditQueryExecutionResultsResponse</returns>
        ApiResponse<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);
        
        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AuditQueryExecutionStatusResponse</returns>
        AuditQueryExecutionStatusResponse PostAuditsQuery (AuditQueryRequest body);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AuditQueryExecutionStatusResponse</returns>
        ApiResponse<AuditQueryExecutionStatusResponse> PostAuditsQueryWithHttpInfo (AuditQueryRequest body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        /// <param name="pageSize">Page size (optional, default to 25)</param>
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
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionResultsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionResultsResponse>> GetAuditsQueryTransactionIdResultsAsyncWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);
        
        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AuditQueryExecutionStatusResponse</returns>
        System.Threading.Tasks.Task<AuditQueryExecutionStatusResponse> PostAuditsQueryAsync (AuditQueryRequest body);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AuditQueryExecutionStatusResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditQueryExecutionStatusResponse>> PostAuditsQueryAsyncWithHttpInfo (AuditQueryRequest body);
        
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
        /// Get status of audit query execution 
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AuditQueryExecutionResultsResponse</returns>
        public AuditQueryExecutionResultsResponse GetAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<AuditQueryExecutionResultsResponse> localVarResponse = GetAuditsQueryTransactionIdResultsWithHttpInfo(transactionId, cursor, pageSize, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results of audit query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AuditQueryExecutionResultsResponse</returns>
        public async System.Threading.Tasks.Task<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsAsync (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<AuditQueryExecutionResultsResponse> localVarResponse = await GetAuditsQueryTransactionIdResultsAsyncWithHttpInfo(transactionId, cursor, pageSize, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results of audit query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
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

        
        
    }
    
}
