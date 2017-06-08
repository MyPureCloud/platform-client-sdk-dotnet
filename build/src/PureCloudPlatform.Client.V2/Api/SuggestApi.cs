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
    public interface ISuggestApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search using the q64 value returned from a previous search.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse GetSearch (string q64, List<string> expand = null, bool? profile = null);

        /// <summary>
        /// Search using the q64 value returned from a previous search.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> GetSearchWithHttpInfo (string q64, List<string> expand = null, bool? profile = null);
        
        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse GetSearchSuggest (string q64, List<string> expand = null, bool? profile = null);

        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> GetSearchSuggestWithHttpInfo (string q64, List<string> expand = null, bool? profile = null);
        
        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse PostSearch (SearchRequest body, bool? profile = null);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> PostSearchWithHttpInfo (SearchRequest body, bool? profile = null);
        
        /// <summary>
        /// Suggest resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse PostSearchSuggest (SuggestSearchRequest body, bool? profile = null);

        /// <summary>
        /// Suggest resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> PostSearchSuggestWithHttpInfo (SuggestSearchRequest body, bool? profile = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search using the q64 value returned from a previous search.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSearchAsync (string q64, List<string> expand = null, bool? profile = null);

        /// <summary>
        /// Search using the q64 value returned from a previous search.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSearchAsyncWithHttpInfo (string q64, List<string> expand = null, bool? profile = null);
        
        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSearchSuggestAsync (string q64, List<string> expand = null, bool? profile = null);

        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSearchSuggestAsyncWithHttpInfo (string q64, List<string> expand = null, bool? profile = null);
        
        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSearchAsync (SearchRequest body, bool? profile = null);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSearchAsyncWithHttpInfo (SearchRequest body, bool? profile = null);
        
        /// <summary>
        /// Suggest resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSearchSuggestAsync (SuggestSearchRequest body, bool? profile = null);

        /// <summary>
        /// Suggest resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSearchSuggestAsyncWithHttpInfo (SuggestSearchRequest body, bool? profile = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SuggestApi : ISuggestApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SuggestApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SuggestApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
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
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Search using the q64 value returned from a previous search. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse GetSearch (string q64, List<string> expand = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = GetSearchWithHttpInfo(q64, expand, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search using the q64 value returned from a previous search. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > GetSearchWithHttpInfo (string q64, List<string> expand = null, bool? profile = null)
        {
            
            
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling SuggestApi->GetSearch");
            
            
            
            
            
            

            var localVarPath = "/api/v2/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        /// <summary>
        /// Search using the q64 value returned from a previous search. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSearchAsync (string q64, List<string> expand = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await GetSearchAsyncWithHttpInfo(q64, expand, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search using the q64 value returned from a previous search. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSearchAsyncWithHttpInfo (string q64, List<string> expand = null, bool? profile = null)
        {
            
            
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling SuggestApi->GetSearch");
            
            
            
            
            
            

            var localVarPath = "/api/v2/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        
        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse GetSearchSuggest (string q64, List<string> expand = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = GetSearchSuggestWithHttpInfo(q64, expand, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > GetSearchSuggestWithHttpInfo (string q64, List<string> expand = null, bool? profile = null)
        {
            
            
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling SuggestApi->GetSearchSuggest");
            
            
            
            
            
            

            var localVarPath = "/api/v2/search/suggest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSearchSuggestAsync (string q64, List<string> expand = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await GetSearchSuggestAsyncWithHttpInfo(q64, expand, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Suggest resources using the q64 value returned from a previous suggest query. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSearchSuggestAsyncWithHttpInfo (string q64, List<string> expand = null, bool? profile = null)
        {
            
            
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling SuggestApi->GetSearchSuggest");
            
            
            
            
            
            

            var localVarPath = "/api/v2/search/suggest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        
        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse PostSearch (SearchRequest body, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = PostSearchWithHttpInfo(body, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > PostSearchWithHttpInfo (SearchRequest body, bool? profile = null)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SuggestApi->PostSearch");
            
            
            
            

            var localVarPath = "/api/v2/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSearchAsync (SearchRequest body, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostSearchAsyncWithHttpInfo(body, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSearchAsyncWithHttpInfo (SearchRequest body, bool? profile = null)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SuggestApi->PostSearch");
            
            
            
            

            var localVarPath = "/api/v2/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        
        /// <summary>
        /// Suggest resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse PostSearchSuggest (SuggestSearchRequest body, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = PostSearchSuggestWithHttpInfo(body, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Suggest resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > PostSearchSuggestWithHttpInfo (SuggestSearchRequest body, bool? profile = null)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SuggestApi->PostSearchSuggest");
            
            
            
            

            var localVarPath = "/api/v2/search/suggest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        /// <summary>
        /// Suggest resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSearchSuggestAsync (SuggestSearchRequest body, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostSearchSuggestAsyncWithHttpInfo(body, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Suggest resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <param name="profile">profile (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSearchSuggestAsyncWithHttpInfo (SuggestSearchRequest body, bool? profile = null)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SuggestApi->PostSearchSuggest");
            
            
            
            

            var localVarPath = "/api/v2/search/suggest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearchSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        
        
    }
    
}
