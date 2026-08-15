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
    public interface IDependenciesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get entities that require the given entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>DependencyEntityListing</returns>
        
        DependencyEntityListing GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        /// <summary>
        /// Get entities that require the given entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>ApiResponse of DependencyEntityListing</returns>
        
        ApiResponse<DependencyEntityListing> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>DependencyCount</returns>
        
        DependencyCount GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts (string entityType, string entityId);

        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>ApiResponse of DependencyCount</returns>
        
        ApiResponse<DependencyCount> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsWithHttpInfo (string entityType, string entityId);

        /// <summary>
        /// Get entities that the given entity requires
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>DependencyEntityListing</returns>
        
        DependencyEntityListing GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        /// <summary>
        /// Get entities that the given entity requires
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>ApiResponse of DependencyEntityListing</returns>
        
        ApiResponse<DependencyEntityListing> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get entities that require the given entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of DependencyEntityListing</returns>
        
        System.Threading.Tasks.Task<DependencyEntityListing> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyAsync (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        /// <summary>
        /// Get entities that require the given entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of ApiResponse (DependencyEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DependencyEntityListing>> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyAsyncWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>Task of DependencyCount</returns>
        
        System.Threading.Tasks.Task<DependencyCount> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsAsync (string entityType, string entityId);

        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>Task of ApiResponse (DependencyCount)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DependencyCount>> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsAsyncWithHttpInfo (string entityType, string entityId);

        /// <summary>
        /// Get entities that the given entity requires
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of DependencyEntityListing</returns>
        
        System.Threading.Tasks.Task<DependencyEntityListing> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresAsync (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        /// <summary>
        /// Get entities that the given entity requires
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of ApiResponse (DependencyEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DependencyEntityListing>> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresAsyncWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DependenciesApi : IDependenciesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependenciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DependenciesApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependenciesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DependenciesApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get entities that require the given entity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>DependencyEntityListing</returns>
        
        public DependencyEntityListing GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        {
             ApiResponse<DependencyEntityListing> localVarResponse = GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyWithHttpInfo(entityType, entityId, pageSize, beforeSourceType, beforeSourceId, afterSourceType, afterSourceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get entities that require the given entity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>ApiResponse of DependencyEntityListing</returns>
        
        public ApiResponse< DependencyEntityListing > GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        { 
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new ApiException(400, "Missing required parameter 'entityType' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby");
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby");

            var localVarPath = "/api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requiredby";
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
            if (entityType != null) localVarPathParams.Add("entityType", this.Configuration.ApiClient.ParameterToString(entityType));
            if (entityId != null) localVarPathParams.Add("entityId", this.Configuration.ApiClient.ParameterToString(entityId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (beforeSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceType", this.Configuration.ApiClient.ParameterToString(beforeSourceType)));
            if (beforeSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceId", this.Configuration.ApiClient.ParameterToString(beforeSourceId)));
            if (afterSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceType", this.Configuration.ApiClient.ParameterToString(afterSourceType)));
            if (afterSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceId", this.Configuration.ApiClient.ParameterToString(afterSourceId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get entities that require the given entity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of DependencyEntityListing</returns>
        
        public async System.Threading.Tasks.Task<DependencyEntityListing> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyAsync (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        {
             ApiResponse<DependencyEntityListing> localVarResponse = await GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyAsyncWithHttpInfo(entityType, entityId, pageSize, beforeSourceType, beforeSourceId, afterSourceType, afterSourceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get entities that require the given entity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of ApiResponse (DependencyEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DependencyEntityListing>> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyAsyncWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        { 
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new ApiException(400, "Missing required parameter 'entityType' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby");
            
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby");
            

            var localVarPath = "/api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requiredby";
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
            if (entityType != null) localVarPathParams.Add("entityType", this.Configuration.ApiClient.ParameterToString(entityType));
            if (entityId != null) localVarPathParams.Add("entityId", this.Configuration.ApiClient.ParameterToString(entityId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (beforeSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceType", this.Configuration.ApiClient.ParameterToString(beforeSourceType)));
            if (beforeSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceId", this.Configuration.ApiClient.ParameterToString(beforeSourceId)));
            if (afterSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceType", this.Configuration.ApiClient.ParameterToString(afterSourceType)));
            if (afterSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceId", this.Configuration.ApiClient.ParameterToString(afterSourceId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>DependencyCount</returns>
        
        public DependencyCount GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts (string entityType, string entityId)
        {
             ApiResponse<DependencyCount> localVarResponse = GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsWithHttpInfo(entityType, entityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>ApiResponse of DependencyCount</returns>
        
        public ApiResponse< DependencyCount > GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsWithHttpInfo (string entityType, string entityId)
        { 
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new ApiException(400, "Missing required parameter 'entityType' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts");
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts");

            var localVarPath = "/api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requiredbycounts";
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
            if (entityType != null) localVarPathParams.Add("entityType", this.Configuration.ApiClient.ParameterToString(entityType));
            if (entityId != null) localVarPathParams.Add("entityId", this.Configuration.ApiClient.ParameterToString(entityId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyCount>(localVarStatusCode,
                localVarHeaders,
                (DependencyCount) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyCount)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>Task of DependencyCount</returns>
        
        public async System.Threading.Tasks.Task<DependencyCount> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsAsync (string entityType, string entityId)
        {
             ApiResponse<DependencyCount> localVarResponse = await GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsAsyncWithHttpInfo(entityType, entityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// An estimated count of entities that depend on this entity, including indirect dependencies. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <returns>Task of ApiResponse (DependencyCount)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DependencyCount>> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsAsyncWithHttpInfo (string entityType, string entityId)
        { 
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new ApiException(400, "Missing required parameter 'entityType' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts");
            
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts");
            

            var localVarPath = "/api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requiredbycounts";
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
            if (entityType != null) localVarPathParams.Add("entityType", this.Configuration.ApiClient.ParameterToString(entityType));
            if (entityId != null) localVarPathParams.Add("entityId", this.Configuration.ApiClient.ParameterToString(entityId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyCount>(localVarStatusCode,
                localVarHeaders,
                (DependencyCount) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyCount)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get entities that the given entity requires 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>DependencyEntityListing</returns>
        
        public DependencyEntityListing GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        {
             ApiResponse<DependencyEntityListing> localVarResponse = GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresWithHttpInfo(entityType, entityId, pageSize, beforeSourceType, beforeSourceId, afterSourceType, afterSourceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get entities that the given entity requires 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>ApiResponse of DependencyEntityListing</returns>
        
        public ApiResponse< DependencyEntityListing > GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        { 
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new ApiException(400, "Missing required parameter 'entityType' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires");
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires");

            var localVarPath = "/api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requires";
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
            if (entityType != null) localVarPathParams.Add("entityType", this.Configuration.ApiClient.ParameterToString(entityType));
            if (entityId != null) localVarPathParams.Add("entityId", this.Configuration.ApiClient.ParameterToString(entityId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (beforeSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceType", this.Configuration.ApiClient.ParameterToString(beforeSourceType)));
            if (beforeSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceId", this.Configuration.ApiClient.ParameterToString(beforeSourceId)));
            if (afterSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceType", this.Configuration.ApiClient.ParameterToString(afterSourceType)));
            if (afterSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceId", this.Configuration.ApiClient.ParameterToString(afterSourceId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get entities that the given entity requires 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of DependencyEntityListing</returns>
        
        public async System.Threading.Tasks.Task<DependencyEntityListing> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresAsync (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        {
             ApiResponse<DependencyEntityListing> localVarResponse = await GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresAsyncWithHttpInfo(entityType, entityId, pageSize, beforeSourceType, beforeSourceId, afterSourceType, afterSourceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get entities that the given entity requires 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type</param>
        /// <param name="entityId">Entity ID</param>
        /// <param name="pageSize">Page size (max 100) (optional, default to "25")</param>
        /// <param name="beforeSourceType">Cursor for previous page (optional)</param>
        /// <param name="beforeSourceId">Cursor for previous page (optional)</param>
        /// <param name="afterSourceType">Cursor for next page (optional)</param>
        /// <param name="afterSourceId">Cursor for next page (optional)</param>
        /// <returns>Task of ApiResponse (DependencyEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DependencyEntityListing>> GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresAsyncWithHttpInfo (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)
        { 
            // verify the required parameter 'entityType' is set
            if (entityType == null)
                throw new ApiException(400, "Missing required parameter 'entityType' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires");
            
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling DependenciesApi->GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires");
            

            var localVarPath = "/api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requires";
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
            if (entityType != null) localVarPathParams.Add("entityType", this.Configuration.ApiClient.ParameterToString(entityType));
            if (entityId != null) localVarPathParams.Add("entityId", this.Configuration.ApiClient.ParameterToString(entityId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (beforeSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceType", this.Configuration.ApiClient.ParameterToString(beforeSourceType)));
            if (beforeSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("beforeSourceId", this.Configuration.ApiClient.ParameterToString(beforeSourceId)));
            if (afterSourceType != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceType", this.Configuration.ApiClient.ParameterToString(afterSourceType)));
            if (afterSourceId != null) localVarQueryParams.Add(new Tuple<string, string>("afterSourceId", this.Configuration.ApiClient.ParameterToString(afterSourceId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
