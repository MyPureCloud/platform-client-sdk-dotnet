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
    public interface IUsageApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiUsageQueryResult</returns>
        
        ApiUsageQueryResult GetOauthClientUsageQueryResult (string executionId, string clientId);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of ApiUsageQueryResult</returns>
        
        ApiResponse<ApiUsageQueryResult> GetOauthClientUsageQueryResultWithHttpInfo (string executionId, string clientId);

        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>UsageExecutionResult</returns>
        
        UsageExecutionResult GetOauthClientUsageSummary (string clientId, string days = null);

        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        
        ApiResponse<UsageExecutionResult> GetOauthClientUsageSummaryWithHttpInfo (string clientId, string days = null);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>ApiUsageQueryResult</returns>
        
        ApiUsageQueryResult GetUsageQueryExecutionIdResults (string executionId);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>ApiResponse of ApiUsageQueryResult</returns>
        
        ApiResponse<ApiUsageQueryResult> GetUsageQueryExecutionIdResultsWithHttpInfo (string executionId);

        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>UsageExecutionResult</returns>
        
        UsageExecutionResult PostOauthClientUsageQuery (string clientId, ApiUsageQuery body);

        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        
        ApiResponse<UsageExecutionResult> PostOauthClientUsageQueryWithHttpInfo (string clientId, ApiUsageQuery body);

        /// <summary>
        /// Query organization API Usage - 
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>UsageExecutionResult</returns>
        
        UsageExecutionResult PostUsageQuery (ApiUsageQuery body);

        /// <summary>
        /// Query organization API Usage - 
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        
        ApiResponse<UsageExecutionResult> PostUsageQueryWithHttpInfo (ApiUsageQuery body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiUsageQueryResult</returns>
        
        System.Threading.Tasks.Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync (string executionId, string clientId);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (ApiUsageQueryResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ApiUsageQueryResult>> GetOauthClientUsageQueryResultAsyncWithHttpInfo (string executionId, string clientId);

        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>Task of UsageExecutionResult</returns>
        
        System.Threading.Tasks.Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync (string clientId, string days = null);

        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> GetOauthClientUsageSummaryAsyncWithHttpInfo (string clientId, string days = null);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>Task of ApiUsageQueryResult</returns>
        
        System.Threading.Tasks.Task<ApiUsageQueryResult> GetUsageQueryExecutionIdResultsAsync (string executionId);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>Task of ApiResponse (ApiUsageQueryResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ApiUsageQueryResult>> GetUsageQueryExecutionIdResultsAsyncWithHttpInfo (string executionId);

        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of UsageExecutionResult</returns>
        
        System.Threading.Tasks.Task<UsageExecutionResult> PostOauthClientUsageQueryAsync (string clientId, ApiUsageQuery body);

        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> PostOauthClientUsageQueryAsyncWithHttpInfo (string clientId, ApiUsageQuery body);

        /// <summary>
        /// Query organization API Usage - 
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>Task of UsageExecutionResult</returns>
        
        System.Threading.Tasks.Task<UsageExecutionResult> PostUsageQueryAsync (ApiUsageQuery body);

        /// <summary>
        /// Query organization API Usage - 
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> PostUsageQueryAsyncWithHttpInfo (ApiUsageQuery body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsageApi : IUsageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsageApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsageApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiUsageQueryResult</returns>
        
        public ApiUsageQueryResult GetOauthClientUsageQueryResult (string executionId, string clientId)
        {
             ApiResponse<ApiUsageQueryResult> localVarResponse = GetOauthClientUsageQueryResultWithHttpInfo(executionId, clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of ApiUsageQueryResult</returns>
        
        public ApiResponse< ApiUsageQueryResult > GetOauthClientUsageQueryResultWithHttpInfo (string executionId, string clientId)
        { 
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling UsageApi->GetOauthClientUsageQueryResult");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsageApi->GetOauthClientUsageQueryResult");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query/results/{executionId}";
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
            if (executionId != null) localVarPathParams.Add("executionId", this.Configuration.ApiClient.ParameterToString(executionId));
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiUsageQueryResult>(localVarStatusCode,
                localVarHeaders,
                (ApiUsageQueryResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiUsageQueryResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiUsageQueryResult</returns>
        
        public async System.Threading.Tasks.Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync (string executionId, string clientId)
        {
             ApiResponse<ApiUsageQueryResult> localVarResponse = await GetOauthClientUsageQueryResultAsyncWithHttpInfo(executionId, clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (ApiUsageQueryResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ApiUsageQueryResult>> GetOauthClientUsageQueryResultAsyncWithHttpInfo (string executionId, string clientId)
        { 
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling UsageApi->GetOauthClientUsageQueryResult");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsageApi->GetOauthClientUsageQueryResult");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query/results/{executionId}";
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
            if (executionId != null) localVarPathParams.Add("executionId", this.Configuration.ApiClient.ParameterToString(executionId));
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiUsageQueryResult>(localVarStatusCode,
                localVarHeaders,
                (ApiUsageQueryResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiUsageQueryResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>UsageExecutionResult</returns>
        
        public UsageExecutionResult GetOauthClientUsageSummary (string clientId, string days = null)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = GetOauthClientUsageSummaryWithHttpInfo(clientId, days);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        
        public ApiResponse< UsageExecutionResult > GetOauthClientUsageSummaryWithHttpInfo (string clientId, string days = null)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsageApi->GetOauthClientUsageSummary");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/summary";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

            // Query params
            if (days != null) localVarQueryParams.Add(new Tuple<string, string>("days", this.Configuration.ApiClient.ParameterToString(days)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>Task of UsageExecutionResult</returns>
        
        public async System.Threading.Tasks.Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync (string clientId, string days = null)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = await GetOauthClientUsageSummaryAsyncWithHttpInfo(clientId, days);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to "7")</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> GetOauthClientUsageSummaryAsyncWithHttpInfo (string clientId, string days = null)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsageApi->GetOauthClientUsageSummary");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/summary";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

            // Query params
            if (days != null) localVarQueryParams.Add(new Tuple<string, string>("days", this.Configuration.ApiClient.ParameterToString(days)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>ApiUsageQueryResult</returns>
        
        public ApiUsageQueryResult GetUsageQueryExecutionIdResults (string executionId)
        {
             ApiResponse<ApiUsageQueryResult> localVarResponse = GetUsageQueryExecutionIdResultsWithHttpInfo(executionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>ApiResponse of ApiUsageQueryResult</returns>
        
        public ApiResponse< ApiUsageQueryResult > GetUsageQueryExecutionIdResultsWithHttpInfo (string executionId)
        { 
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling UsageApi->GetUsageQueryExecutionIdResults");

            var localVarPath = "/api/v2/usage/query/{executionId}/results";
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
            if (executionId != null) localVarPathParams.Add("executionId", this.Configuration.ApiClient.ParameterToString(executionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsageQueryExecutionIdResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsageQueryExecutionIdResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiUsageQueryResult>(localVarStatusCode,
                localVarHeaders,
                (ApiUsageQueryResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiUsageQueryResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>Task of ApiUsageQueryResult</returns>
        
        public async System.Threading.Tasks.Task<ApiUsageQueryResult> GetUsageQueryExecutionIdResultsAsync (string executionId)
        {
             ApiResponse<ApiUsageQueryResult> localVarResponse = await GetUsageQueryExecutionIdResultsAsyncWithHttpInfo(executionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <returns>Task of ApiResponse (ApiUsageQueryResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ApiUsageQueryResult>> GetUsageQueryExecutionIdResultsAsyncWithHttpInfo (string executionId)
        { 
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling UsageApi->GetUsageQueryExecutionIdResults");
            

            var localVarPath = "/api/v2/usage/query/{executionId}/results";
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
            if (executionId != null) localVarPathParams.Add("executionId", this.Configuration.ApiClient.ParameterToString(executionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsageQueryExecutionIdResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsageQueryExecutionIdResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiUsageQueryResult>(localVarStatusCode,
                localVarHeaders,
                (ApiUsageQueryResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiUsageQueryResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>UsageExecutionResult</returns>
        
        public UsageExecutionResult PostOauthClientUsageQuery (string clientId, ApiUsageQuery body)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = PostOauthClientUsageQueryWithHttpInfo(clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        
        public ApiResponse< UsageExecutionResult > PostOauthClientUsageQueryWithHttpInfo (string clientId, ApiUsageQuery body)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsageApi->PostOauthClientUsageQuery");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsageApi->PostOauthClientUsageQuery");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of UsageExecutionResult</returns>
        
        public async System.Threading.Tasks.Task<UsageExecutionResult> PostOauthClientUsageQueryAsync (string clientId, ApiUsageQuery body)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = await PostOauthClientUsageQueryAsyncWithHttpInfo(clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> PostOauthClientUsageQueryAsyncWithHttpInfo (string clientId, ApiUsageQuery body)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsageApi->PostOauthClientUsageQuery");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsageApi->PostOauthClientUsageQuery");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query organization API Usage -  After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>UsageExecutionResult</returns>
        
        public UsageExecutionResult PostUsageQuery (ApiUsageQuery body)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = PostUsageQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query organization API Usage -  After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        
        public ApiResponse< UsageExecutionResult > PostUsageQueryWithHttpInfo (ApiUsageQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsageApi->PostUsageQuery");

            var localVarPath = "/api/v2/usage/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsageQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsageQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query organization API Usage -  After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>Task of UsageExecutionResult</returns>
        
        public async System.Threading.Tasks.Task<UsageExecutionResult> PostUsageQueryAsync (ApiUsageQuery body)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = await PostUsageQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query organization API Usage -  After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Query</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> PostUsageQueryAsyncWithHttpInfo (ApiUsageQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsageApi->PostUsageQuery");
            

            var localVarPath = "/api/v2/usage/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsageQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsageQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
