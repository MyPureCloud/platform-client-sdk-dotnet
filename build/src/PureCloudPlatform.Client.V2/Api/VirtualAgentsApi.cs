using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVirtualAgentsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Start the deletion of a virtualAgent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>AgenticVirtualAgentJob</returns>
        
        AgenticVirtualAgentJob DeleteAgenticVirtualagentJobs (string virtualAgentId);

        /// <summary>
        /// Start the deletion of a virtualAgent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>ApiResponse of AgenticVirtualAgentJob</returns>
        
        ApiResponse<AgenticVirtualAgentJob> DeleteAgenticVirtualagentJobsWithHttpInfo (string virtualAgentId);

        /// <summary>
        /// Get virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>AgenticVirtualAgent</returns>
        
        AgenticVirtualAgent GetAgenticVirtualagent (string virtualAgentId);

        /// <summary>
        /// Get virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>ApiResponse of AgenticVirtualAgent</returns>
        
        ApiResponse<AgenticVirtualAgent> GetAgenticVirtualagentWithHttpInfo (string virtualAgentId);

        /// <summary>
        /// Get a virtualAgent job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>AgenticVirtualAgentJob</returns>
        
        AgenticVirtualAgentJob GetAgenticVirtualagentJob (string virtualAgentId, string jobId);

        /// <summary>
        /// Get a virtualAgent job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AgenticVirtualAgentJob</returns>
        
        ApiResponse<AgenticVirtualAgentJob> GetAgenticVirtualagentJobWithHttpInfo (string virtualAgentId, string jobId);

        /// <summary>
        /// Get all virtual agents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>AgenticVirtualAgentEntityListing</returns>
        
        AgenticVirtualAgentEntityListing GetAgenticVirtualagents (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all virtual agents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>ApiResponse of AgenticVirtualAgentEntityListing</returns>
        
        ApiResponse<AgenticVirtualAgentEntityListing> GetAgenticVirtualagentsWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Update a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>AgenticVirtualAgent</returns>
        
        AgenticVirtualAgent PatchAgenticVirtualagent (string virtualAgentId, UpdateAgenticVirtualAgent body);

        /// <summary>
        /// Update a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AgenticVirtualAgent</returns>
        
        ApiResponse<AgenticVirtualAgent> PatchAgenticVirtualagentWithHttpInfo (string virtualAgentId, UpdateAgenticVirtualAgent body);

        /// <summary>
        /// Start the publishing of a virtual agent version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>AgenticVirtualAgentVersionPublishJob</returns>
        
        AgenticVirtualAgentVersionPublishJob PostAgenticVirtualagentVersionJobs (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body);

        /// <summary>
        /// Start the publishing of a virtual agent version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AgenticVirtualAgentVersionPublishJob</returns>
        
        ApiResponse<AgenticVirtualAgentVersionPublishJob> PostAgenticVirtualagentVersionJobsWithHttpInfo (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body);

        /// <summary>
        /// Create a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>AgenticVirtualAgent</returns>
        
        AgenticVirtualAgent PostAgenticVirtualagents (CreateAgenticVirtualAgent body);

        /// <summary>
        /// Create a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AgenticVirtualAgent</returns>
        
        ApiResponse<AgenticVirtualAgent> PostAgenticVirtualagentsWithHttpInfo (CreateAgenticVirtualAgent body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Start the deletion of a virtualAgent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of AgenticVirtualAgentJob</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgentJob> DeleteAgenticVirtualagentJobsAsync (string virtualAgentId);

        /// <summary>
        /// Start the deletion of a virtualAgent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentJob>> DeleteAgenticVirtualagentJobsAsyncWithHttpInfo (string virtualAgentId);

        /// <summary>
        /// Get virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of AgenticVirtualAgent</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgent> GetAgenticVirtualagentAsync (string virtualAgentId);

        /// <summary>
        /// Get virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgent)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgent>> GetAgenticVirtualagentAsyncWithHttpInfo (string virtualAgentId);

        /// <summary>
        /// Get a virtualAgent job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AgenticVirtualAgentJob</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgentJob> GetAgenticVirtualagentJobAsync (string virtualAgentId, string jobId);

        /// <summary>
        /// Get a virtualAgent job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentJob>> GetAgenticVirtualagentJobAsyncWithHttpInfo (string virtualAgentId, string jobId);

        /// <summary>
        /// Get all virtual agents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of AgenticVirtualAgentEntityListing</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgentEntityListing> GetAgenticVirtualagentsAsync (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all virtual agents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentEntityListing>> GetAgenticVirtualagentsAsyncWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Update a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AgenticVirtualAgent</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgent> PatchAgenticVirtualagentAsync (string virtualAgentId, UpdateAgenticVirtualAgent body);

        /// <summary>
        /// Update a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgent)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgent>> PatchAgenticVirtualagentAsyncWithHttpInfo (string virtualAgentId, UpdateAgenticVirtualAgent body);

        /// <summary>
        /// Start the publishing of a virtual agent version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AgenticVirtualAgentVersionPublishJob</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgentVersionPublishJob> PostAgenticVirtualagentVersionJobsAsync (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body);

        /// <summary>
        /// Start the publishing of a virtual agent version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentVersionPublishJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentVersionPublishJob>> PostAgenticVirtualagentVersionJobsAsyncWithHttpInfo (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body);

        /// <summary>
        /// Create a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of AgenticVirtualAgent</returns>
        
        System.Threading.Tasks.Task<AgenticVirtualAgent> PostAgenticVirtualagentsAsync (CreateAgenticVirtualAgent body);

        /// <summary>
        /// Create a virtual agent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgent)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgent>> PostAgenticVirtualagentsAsyncWithHttpInfo (CreateAgenticVirtualAgent body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VirtualAgentsApi : IVirtualAgentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualAgentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VirtualAgentsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualAgentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VirtualAgentsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Start the deletion of a virtualAgent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>AgenticVirtualAgentJob</returns>
        
        public AgenticVirtualAgentJob DeleteAgenticVirtualagentJobs (string virtualAgentId)
        {
             ApiResponse<AgenticVirtualAgentJob> localVarResponse = DeleteAgenticVirtualagentJobsWithHttpInfo(virtualAgentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start the deletion of a virtualAgent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>ApiResponse of AgenticVirtualAgentJob</returns>
        
        public ApiResponse< AgenticVirtualAgentJob > DeleteAgenticVirtualagentJobsWithHttpInfo (string virtualAgentId)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->DeleteAgenticVirtualagentJobs");

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}/jobs";
            var localVarHttpMethod = "Delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAgenticVirtualagentJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteAgenticVirtualagentJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAgenticVirtualagentJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentJob>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start the deletion of a virtualAgent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of AgenticVirtualAgentJob</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgentJob> DeleteAgenticVirtualagentJobsAsync (string virtualAgentId)
        {
             ApiResponse<AgenticVirtualAgentJob> localVarResponse = await DeleteAgenticVirtualagentJobsAsyncWithHttpInfo(virtualAgentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start the deletion of a virtualAgent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentJob>> DeleteAgenticVirtualagentJobsAsyncWithHttpInfo (string virtualAgentId)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->DeleteAgenticVirtualagentJobs");
            

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}/jobs";
            var localVarHttpMethod = "Delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAgenticVirtualagentJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteAgenticVirtualagentJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAgenticVirtualagentJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentJob>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>AgenticVirtualAgent</returns>
        
        public AgenticVirtualAgent GetAgenticVirtualagent (string virtualAgentId)
        {
             ApiResponse<AgenticVirtualAgent> localVarResponse = GetAgenticVirtualagentWithHttpInfo(virtualAgentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>ApiResponse of AgenticVirtualAgent</returns>
        
        public ApiResponse< AgenticVirtualAgent > GetAgenticVirtualagentWithHttpInfo (string virtualAgentId)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->GetAgenticVirtualagent");

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgent>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of AgenticVirtualAgent</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgent> GetAgenticVirtualagentAsync (string virtualAgentId)
        {
             ApiResponse<AgenticVirtualAgent> localVarResponse = await GetAgenticVirtualagentAsyncWithHttpInfo(virtualAgentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgent)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgent>> GetAgenticVirtualagentAsyncWithHttpInfo (string virtualAgentId)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->GetAgenticVirtualagent");
            

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgent>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a virtualAgent job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>AgenticVirtualAgentJob</returns>
        
        public AgenticVirtualAgentJob GetAgenticVirtualagentJob (string virtualAgentId, string jobId)
        {
             ApiResponse<AgenticVirtualAgentJob> localVarResponse = GetAgenticVirtualagentJobWithHttpInfo(virtualAgentId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a virtualAgent job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AgenticVirtualAgentJob</returns>
        
        public ApiResponse< AgenticVirtualAgentJob > GetAgenticVirtualagentJobWithHttpInfo (string virtualAgentId, string jobId)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->GetAgenticVirtualagentJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling VirtualAgentsApi->GetAgenticVirtualagentJob");

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}/jobs/{jobId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagentJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetAgenticVirtualagentJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagentJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentJob>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a virtualAgent job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AgenticVirtualAgentJob</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgentJob> GetAgenticVirtualagentJobAsync (string virtualAgentId, string jobId)
        {
             ApiResponse<AgenticVirtualAgentJob> localVarResponse = await GetAgenticVirtualagentJobAsyncWithHttpInfo(virtualAgentId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a virtualAgent job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentJob>> GetAgenticVirtualagentJobAsyncWithHttpInfo (string virtualAgentId, string jobId)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->GetAgenticVirtualagentJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling VirtualAgentsApi->GetAgenticVirtualagentJob");
            

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}/jobs/{jobId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagentJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetAgenticVirtualagentJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagentJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentJob>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all virtual agents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>AgenticVirtualAgentEntityListing</returns>
        
        public AgenticVirtualAgentEntityListing GetAgenticVirtualagents (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AgenticVirtualAgentEntityListing> localVarResponse = GetAgenticVirtualagentsWithHttpInfo(name, nameContains, status, sortBy, sortOrder, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all virtual agents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>ApiResponse of AgenticVirtualAgentEntityListing</returns>
        
        public ApiResponse< AgenticVirtualAgentEntityListing > GetAgenticVirtualagentsWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/agentic/virtualagents";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (nameContains != null) localVarQueryParams.Add(new Tuple<string, string>("nameContains", this.Configuration.ApiClient.ParameterToString(nameContains)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all virtual agents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of AgenticVirtualAgentEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgentEntityListing> GetAgenticVirtualagentsAsync (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AgenticVirtualAgentEntityListing> localVarResponse = await GetAgenticVirtualagentsAsyncWithHttpInfo(name, nameContains, status, sortBy, sortOrder, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all virtual agents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentEntityListing>> GetAgenticVirtualagentsAsyncWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/agentic/virtualagents";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (nameContains != null) localVarQueryParams.Add(new Tuple<string, string>("nameContains", this.Configuration.ApiClient.ParameterToString(nameContains)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgenticVirtualagents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>AgenticVirtualAgent</returns>
        
        public AgenticVirtualAgent PatchAgenticVirtualagent (string virtualAgentId, UpdateAgenticVirtualAgent body)
        {
             ApiResponse<AgenticVirtualAgent> localVarResponse = PatchAgenticVirtualagentWithHttpInfo(virtualAgentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AgenticVirtualAgent</returns>
        
        public ApiResponse< AgenticVirtualAgent > PatchAgenticVirtualagentWithHttpInfo (string virtualAgentId, UpdateAgenticVirtualAgent body)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->PatchAgenticVirtualagent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VirtualAgentsApi->PatchAgenticVirtualagent");

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}";
            var localVarHttpMethod = "Patch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAgenticVirtualagent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgent>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AgenticVirtualAgent</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgent> PatchAgenticVirtualagentAsync (string virtualAgentId, UpdateAgenticVirtualAgent body)
        {
             ApiResponse<AgenticVirtualAgent> localVarResponse = await PatchAgenticVirtualagentAsyncWithHttpInfo(virtualAgentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgent)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgent>> PatchAgenticVirtualagentAsyncWithHttpInfo (string virtualAgentId, UpdateAgenticVirtualAgent body)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->PatchAgenticVirtualagent");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VirtualAgentsApi->PatchAgenticVirtualagent");
            

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}";
            var localVarHttpMethod = "Patch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchAgenticVirtualagent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAgenticVirtualagent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgent>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start the publishing of a virtual agent version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>AgenticVirtualAgentVersionPublishJob</returns>
        
        public AgenticVirtualAgentVersionPublishJob PostAgenticVirtualagentVersionJobs (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body)
        {
             ApiResponse<AgenticVirtualAgentVersionPublishJob> localVarResponse = PostAgenticVirtualagentVersionJobsWithHttpInfo(virtualAgentId, versionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start the publishing of a virtual agent version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AgenticVirtualAgentVersionPublishJob</returns>
        
        public ApiResponse< AgenticVirtualAgentVersionPublishJob > PostAgenticVirtualagentVersionJobsWithHttpInfo (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->PostAgenticVirtualagentVersionJobs");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling VirtualAgentsApi->PostAgenticVirtualagentVersionJobs");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VirtualAgentsApi->PostAgenticVirtualagentVersionJobs");

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}/versions/{versionId}/jobs";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagentVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostAgenticVirtualagentVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagentVersionJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentVersionPublishJob>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentVersionPublishJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentVersionPublishJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start the publishing of a virtual agent version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AgenticVirtualAgentVersionPublishJob</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgentVersionPublishJob> PostAgenticVirtualagentVersionJobsAsync (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body)
        {
             ApiResponse<AgenticVirtualAgentVersionPublishJob> localVarResponse = await PostAgenticVirtualagentVersionJobsAsyncWithHttpInfo(virtualAgentId, versionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start the publishing of a virtual agent version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="virtualAgentId">Virtual Agent ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgentVersionPublishJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgentVersionPublishJob>> PostAgenticVirtualagentVersionJobsAsyncWithHttpInfo (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body)
        { 
            // verify the required parameter 'virtualAgentId' is set
            if (virtualAgentId == null)
                throw new ApiException(400, "Missing required parameter 'virtualAgentId' when calling VirtualAgentsApi->PostAgenticVirtualagentVersionJobs");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling VirtualAgentsApi->PostAgenticVirtualagentVersionJobs");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VirtualAgentsApi->PostAgenticVirtualagentVersionJobs");
            

            var localVarPath = "/api/v2/agentic/virtualagents/{virtualAgentId}/versions/{versionId}/jobs";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (virtualAgentId != null) localVarPathParams.Add("virtualAgentId", this.Configuration.ApiClient.ParameterToString(virtualAgentId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagentVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostAgenticVirtualagentVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagentVersionJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgentVersionPublishJob>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgentVersionPublishJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgentVersionPublishJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>AgenticVirtualAgent</returns>
        
        public AgenticVirtualAgent PostAgenticVirtualagents (CreateAgenticVirtualAgent body)
        {
             ApiResponse<AgenticVirtualAgent> localVarResponse = PostAgenticVirtualagentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AgenticVirtualAgent</returns>
        
        public ApiResponse< AgenticVirtualAgent > PostAgenticVirtualagentsWithHttpInfo (CreateAgenticVirtualAgent body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VirtualAgentsApi->PostAgenticVirtualagents");

            var localVarPath = "/api/v2/agentic/virtualagents";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgent>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of AgenticVirtualAgent</returns>
        
        public async System.Threading.Tasks.Task<AgenticVirtualAgent> PostAgenticVirtualagentsAsync (CreateAgenticVirtualAgent body)
        {
             ApiResponse<AgenticVirtualAgent> localVarResponse = await PostAgenticVirtualagentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a virtual agent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AgenticVirtualAgent)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgenticVirtualAgent>> PostAgenticVirtualagentsAsyncWithHttpInfo (CreateAgenticVirtualAgent body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VirtualAgentsApi->PostAgenticVirtualagents");
            

            var localVarPath = "/api/v2/agentic/virtualagents";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostAgenticVirtualagents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAgenticVirtualagents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgenticVirtualAgent>(localVarStatusCode,
                localVarHeaders,
                (AgenticVirtualAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgenticVirtualAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
