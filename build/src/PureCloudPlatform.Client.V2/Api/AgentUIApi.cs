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
    public interface IAgentUIApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns></returns>
        
        void DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId);

        /// <summary>
        /// Delete agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId);

        /// <summary>
        /// Get agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>AutoAnswerSettings</returns>
        
        AutoAnswerSettings GetUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId);

        /// <summary>
        /// Get agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>ApiResponse of AutoAnswerSettings</returns>
        
        ApiResponse<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId);

        /// <summary>
        /// Update agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>AutoAnswerSettings</returns>
        
        AutoAnswerSettings PatchUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body);

        /// <summary>
        /// Update agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>ApiResponse of AutoAnswerSettings</returns>
        
        ApiResponse<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId, AutoAnswerSettings body);

        /// <summary>
        /// Set agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>AutoAnswerSettings</returns>
        
        AutoAnswerSettings PutUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body);

        /// <summary>
        /// Set agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>ApiResponse of AutoAnswerSettings</returns>
        
        ApiResponse<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId, AutoAnswerSettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId);

        /// <summary>
        /// Delete agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId);

        /// <summary>
        /// Get agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of AutoAnswerSettings</returns>
        
        System.Threading.Tasks.Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId);

        /// <summary>
        /// Get agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AutoAnswerSettings>> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId);

        /// <summary>
        /// Update agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of AutoAnswerSettings</returns>
        
        System.Threading.Tasks.Task<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId, AutoAnswerSettings body);

        /// <summary>
        /// Update agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AutoAnswerSettings>> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId, AutoAnswerSettings body);

        /// <summary>
        /// Set agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of AutoAnswerSettings</returns>
        
        System.Threading.Tasks.Task<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId, AutoAnswerSettings body);

        /// <summary>
        /// Set agent auto answer settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AutoAnswerSettings>> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId, AutoAnswerSettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AgentUIApi : IAgentUIApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgentUIApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUIApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgentUIApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns></returns>
        
        public void DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId)
        {
             DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId);
        }

        /// <summary>
        /// Delete agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings");

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId)
        {
             await DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId);

        }

        /// <summary>
        /// Delete agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>AutoAnswerSettings</returns>
        
        public AutoAnswerSettings GetUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId)
        {
             ApiResponse<AutoAnswerSettings> localVarResponse = GetUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>ApiResponse of AutoAnswerSettings</returns>
        
        public ApiResponse< AutoAnswerSettings > GetUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->GetUsersAgentuiAgentsAutoanswerAgentIdSettings");

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
                localVarHeaders,
                (AutoAnswerSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of AutoAnswerSettings</returns>
        
        public async System.Threading.Tasks.Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId)
        {
             ApiResponse<AutoAnswerSettings> localVarResponse = await GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AutoAnswerSettings>> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->GetUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
                localVarHeaders,
                (AutoAnswerSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>AutoAnswerSettings</returns>
        
        public AutoAnswerSettings PatchUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body)
        {
             ApiResponse<AutoAnswerSettings> localVarResponse = PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>ApiResponse of AutoAnswerSettings</returns>
        
        public ApiResponse< AutoAnswerSettings > PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId, AutoAnswerSettings body)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
                localVarHeaders,
                (AutoAnswerSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of AutoAnswerSettings</returns>
        
        public async System.Threading.Tasks.Task<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId, AutoAnswerSettings body)
        {
             ApiResponse<AutoAnswerSettings> localVarResponse = await PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AutoAnswerSettings>> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId, AutoAnswerSettings body)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
                localVarHeaders,
                (AutoAnswerSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>AutoAnswerSettings</returns>
        
        public AutoAnswerSettings PutUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body)
        {
             ApiResponse<AutoAnswerSettings> localVarResponse = PutUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo(agentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>ApiResponse of AutoAnswerSettings</returns>
        
        public ApiResponse< AutoAnswerSettings > PutUsersAgentuiAgentsAutoanswerAgentIdSettingsWithHttpInfo (string agentId, AutoAnswerSettings body)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
                localVarHeaders,
                (AutoAnswerSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of AutoAnswerSettings</returns>
        
        public async System.Threading.Tasks.Task<AutoAnswerSettings> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync (string agentId, AutoAnswerSettings body)
        {
             ApiResponse<AutoAnswerSettings> localVarResponse = await PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo(agentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set agent auto answer settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent to apply the auto answer settings to</param>
        /// <param name="body">AutoAnswerSettings</param>
        /// <returns>Task of ApiResponse (AutoAnswerSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AutoAnswerSettings>> PutUsersAgentuiAgentsAutoanswerAgentIdSettingsAsyncWithHttpInfo (string agentId, AutoAnswerSettings body)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentUIApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

            var localVarPath = "/api/v2/users/agentui/agents/autoanswer/{agentId}/settings";
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
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

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
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AutoAnswerSettings>(localVarStatusCode,
                localVarHeaders,
                (AutoAnswerSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AutoAnswerSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
