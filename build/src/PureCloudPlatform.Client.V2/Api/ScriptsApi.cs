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
    public interface IScriptsApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        Script GetScript (string scriptId);

        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> GetScriptWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        Page GetScriptPage (string scriptId, string pageId);

        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> GetScriptPageWithHttpInfo (string scriptId, string pageId);
        
        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        List<Page> GetScriptPages (string scriptId);

        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        ApiResponse<List<Page>> GetScriptPagesWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        ScriptEntityListing GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        ApiResponse<ScriptEntityListing> GetScriptsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        ScriptEntityListing GetScriptsPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);

        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        ApiResponse<ScriptEntityListing> GetScriptsPublishedWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);
        
        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        Script GetScriptsPublishedScriptId (string scriptId);

        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> GetScriptsPublishedScriptIdWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        Page GetScriptsPublishedScriptIdPage (string scriptId, string pageId);

        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> GetScriptsPublishedScriptIdPageWithHttpInfo (string scriptId, string pageId);
        
        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        List<Page> GetScriptsPublishedScriptIdPages (string scriptId);

        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        ApiResponse<List<Page>> GetScriptsPublishedScriptIdPagesWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>Object</returns>
        Object GetScriptsPublishedScriptIdVariables (string scriptId, string input = null, string output = null, string type = null);

        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetScriptsPublishedScriptIdVariablesWithHttpInfo (string scriptId, string input = null, string output = null, string type = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> GetScriptAsync (string scriptId);

        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> GetScriptAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> GetScriptPageAsync (string scriptId, string pageId);

        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> GetScriptPageAsyncWithHttpInfo (string scriptId, string pageId);
        
        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        System.Threading.Tasks.Task<List<Page>> GetScriptPagesAsync (string scriptId);

        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetScriptPagesAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        System.Threading.Tasks.Task<ScriptEntityListing> GetScriptsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetScriptsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        System.Threading.Tasks.Task<ScriptEntityListing> GetScriptsPublishedAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);

        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetScriptsPublishedAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);
        
        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> GetScriptsPublishedScriptIdAsync (string scriptId);

        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> GetScriptsPublishedScriptIdAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> GetScriptsPublishedScriptIdPageAsync (string scriptId, string pageId);

        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> GetScriptsPublishedScriptIdPageAsyncWithHttpInfo (string scriptId, string pageId);
        
        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        System.Threading.Tasks.Task<List<Page>> GetScriptsPublishedScriptIdPagesAsync (string scriptId);

        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetScriptsPublishedScriptIdPagesAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetScriptsPublishedScriptIdVariablesAsync (string scriptId, string input = null, string output = null, string type = null);

        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetScriptsPublishedScriptIdVariablesAsyncWithHttpInfo (string scriptId, string input = null, string output = null, string type = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScriptsApi : IScriptsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScriptsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScriptsApi(Configuration configuration = null)
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
        /// Get a script 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        public Script GetScript (string scriptId)
        {
             ApiResponse<Script> localVarResponse = GetScriptWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > GetScriptWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScript");
            
            

            var localVarPath = "/api/v2/scripts/{scriptId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScript: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScript: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarHeaders,
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        
        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> GetScriptAsync (string scriptId)
        {
             ApiResponse<Script> localVarResponse = await GetScriptAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> GetScriptAsyncWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScript");
            
            

            var localVarPath = "/api/v2/scripts/{scriptId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScript: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScript: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarHeaders,
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        
        
        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        public Page GetScriptPage (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = GetScriptPageWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > GetScriptPageWithHttpInfo (string scriptId, string pageId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPage");
            
            
            
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptPage");
            
            

            var localVarPath = "/api/v2/scripts/{scriptId}/pages/{pageId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarHeaders,
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        
        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> GetScriptPageAsync (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = await GetScriptPageAsyncWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> GetScriptPageAsyncWithHttpInfo (string scriptId, string pageId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPage");
            
            
            
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptPage");
            
            

            var localVarPath = "/api/v2/scripts/{scriptId}/pages/{pageId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarHeaders,
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        
        
        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        public List<Page> GetScriptPages (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = GetScriptPagesWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        public ApiResponse< List<Page> > GetScriptPagesWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPages");
            
            

            var localVarPath = "/api/v2/scripts/{scriptId}/pages";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarHeaders,
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        
        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        public async System.Threading.Tasks.Task<List<Page>> GetScriptPagesAsync (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = await GetScriptPagesAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetScriptPagesAsyncWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptPages");
            
            

            var localVarPath = "/api/v2/scripts/{scriptId}/pages";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarHeaders,
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        
        
        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > GetScriptsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/scripts";
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter
            
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> GetScriptsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetScriptsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/scripts";
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter
            
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing GetScriptsPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsPublishedWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > GetScriptsPublishedWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/scripts/published";
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        
        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> GetScriptsPublishedAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsPublishedAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetScriptsPublishedAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/scripts/published";
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        public Script GetScriptsPublishedScriptId (string scriptId)
        {
             ApiResponse<Script> localVarResponse = GetScriptsPublishedScriptIdWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > GetScriptsPublishedScriptIdWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptId");
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarHeaders,
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        
        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> GetScriptsPublishedScriptIdAsync (string scriptId)
        {
             ApiResponse<Script> localVarResponse = await GetScriptsPublishedScriptIdAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> GetScriptsPublishedScriptIdAsyncWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptId");
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarHeaders,
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        
        
        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        public Page GetScriptsPublishedScriptIdPage (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = GetScriptsPublishedScriptIdPageWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > GetScriptsPublishedScriptIdPageWithHttpInfo (string scriptId, string pageId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
            
            
            
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages/{pageId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarHeaders,
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        
        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> GetScriptsPublishedScriptIdPageAsync (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = await GetScriptsPublishedScriptIdPageAsyncWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> GetScriptsPublishedScriptIdPageAsyncWithHttpInfo (string scriptId, string pageId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
            
            
            
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptsPublishedScriptIdPage");
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages/{pageId}";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarHeaders,
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        
        
        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        public List<Page> GetScriptsPublishedScriptIdPages (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = GetScriptsPublishedScriptIdPagesWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        public ApiResponse< List<Page> > GetScriptsPublishedScriptIdPagesWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPages");
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarHeaders,
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        
        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        public async System.Threading.Tasks.Task<List<Page>> GetScriptsPublishedScriptIdPagesAsync (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = await GetScriptsPublishedScriptIdPagesAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetScriptsPublishedScriptIdPagesAsyncWithHttpInfo (string scriptId)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdPages");
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarHeaders,
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        
        
        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>Object</returns>
        public Object GetScriptsPublishedScriptIdVariables (string scriptId, string input = null, string output = null, string type = null)
        {
             ApiResponse<Object> localVarResponse = GetScriptsPublishedScriptIdVariablesWithHttpInfo(scriptId, input, output, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetScriptsPublishedScriptIdVariablesWithHttpInfo (string scriptId, string input = null, string output = null, string type = null)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdVariables");
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}/variables";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            if (input != null) localVarQueryParams.Add("input", Configuration.ApiClient.ParameterToString(input)); // query parameter
            
            if (output != null) localVarQueryParams.Add("output", Configuration.ApiClient.ParameterToString(output)); // query parameter
            
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetScriptsPublishedScriptIdVariablesAsync (string scriptId, string input = null, string output = null, string type = null)
        {
             ApiResponse<Object> localVarResponse = await GetScriptsPublishedScriptIdVariablesAsyncWithHttpInfo(scriptId, input, output, type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="input">input (optional)</param>
        /// <param name="output">output (optional)</param>
        /// <param name="type">type (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetScriptsPublishedScriptIdVariablesAsyncWithHttpInfo (string scriptId, string input = null, string output = null, string type = null)
        {
            
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptsPublishedScriptIdVariables");
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/scripts/published/{scriptId}/variables";
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
            
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            if (input != null) localVarQueryParams.Add("input", Configuration.ApiClient.ParameterToString(input)); // query parameter
            
            if (output != null) localVarQueryParams.Add("output", Configuration.ApiClient.ParameterToString(output)); // query parameter
            
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptsPublishedScriptIdVariables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        
    }
    
}
