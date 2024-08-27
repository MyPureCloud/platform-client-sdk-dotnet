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
    public interface ISettingsApi : IApiAccessor
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
        /// Get email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSettings</returns>
        
        EmailSettings GetEmailsSettings ();

        /// <summary>
        /// Get email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSettings</returns>
        
        ApiResponse<EmailSettings> GetEmailsSettingsWithHttpInfo ();

        /// <summary>
        /// Get the execution history enabled setting.
        /// </summary>
        /// <remarks>
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ExecutionDataGlobalSettingsResponse</returns>
        
        ExecutionDataGlobalSettingsResponse GetSettingsExecutiondata ();

        /// <summary>
        /// Get the execution history enabled setting.
        /// </summary>
        /// <remarks>
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ExecutionDataGlobalSettingsResponse</returns>
        
        ApiResponse<ExecutionDataGlobalSettingsResponse> GetSettingsExecutiondataWithHttpInfo ();

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
        /// Patch email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EmailSettings</returns>
        
        EmailSettings PatchEmailsSettings (EmailSettings body = null);

        /// <summary>
        /// Patch email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EmailSettings</returns>
        
        ApiResponse<EmailSettings> PatchEmailsSettingsWithHttpInfo (EmailSettings body = null);

        /// <summary>
        /// Edit the execution history on off setting.
        /// </summary>
        /// <remarks>
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>ExecutionDataGlobalSettingsResponse</returns>
        
        ExecutionDataGlobalSettingsResponse PatchSettingsExecutiondata (ExecutionDataSettingsRequest body);

        /// <summary>
        /// Edit the execution history on off setting.
        /// </summary>
        /// <remarks>
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>ApiResponse of ExecutionDataGlobalSettingsResponse</returns>
        
        ApiResponse<ExecutionDataGlobalSettingsResponse> PatchSettingsExecutiondataWithHttpInfo (ExecutionDataSettingsRequest body);

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
        /// Get email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSettings</returns>
        
        System.Threading.Tasks.Task<EmailSettings> GetEmailsSettingsAsync ();

        /// <summary>
        /// Get email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EmailSettings>> GetEmailsSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the execution history enabled setting.
        /// </summary>
        /// <remarks>
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ExecutionDataGlobalSettingsResponse</returns>
        
        System.Threading.Tasks.Task<ExecutionDataGlobalSettingsResponse> GetSettingsExecutiondataAsync ();

        /// <summary>
        /// Get the execution history enabled setting.
        /// </summary>
        /// <remarks>
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ExecutionDataGlobalSettingsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExecutionDataGlobalSettingsResponse>> GetSettingsExecutiondataAsyncWithHttpInfo ();

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
        /// Patch email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EmailSettings</returns>
        
        System.Threading.Tasks.Task<EmailSettings> PatchEmailsSettingsAsync (EmailSettings body = null);

        /// <summary>
        /// Patch email Contact Center settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EmailSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EmailSettings>> PatchEmailsSettingsAsyncWithHttpInfo (EmailSettings body = null);

        /// <summary>
        /// Edit the execution history on off setting.
        /// </summary>
        /// <remarks>
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>Task of ExecutionDataGlobalSettingsResponse</returns>
        
        System.Threading.Tasks.Task<ExecutionDataGlobalSettingsResponse> PatchSettingsExecutiondataAsync (ExecutionDataSettingsRequest body);

        /// <summary>
        /// Edit the execution history on off setting.
        /// </summary>
        /// <remarks>
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>Task of ApiResponse (ExecutionDataGlobalSettingsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExecutionDataGlobalSettingsResponse>> PatchSettingsExecutiondataAsyncWithHttpInfo (ExecutionDataSettingsRequest body);

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
    public partial class SettingsApi : ISettingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings");

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
        /// Get email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSettings</returns>
        
        public EmailSettings GetEmailsSettings ()
        {
             ApiResponse<EmailSettings> localVarResponse = GetEmailsSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSettings</returns>
        
        public ApiResponse< EmailSettings > GetEmailsSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/emails/settings";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSettings>(localVarStatusCode,
                localVarHeaders,
                (EmailSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSettings</returns>
        
        public async System.Threading.Tasks.Task<EmailSettings> GetEmailsSettingsAsync ()
        {
             ApiResponse<EmailSettings> localVarResponse = await GetEmailsSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EmailSettings>> GetEmailsSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/emails/settings";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSettings>(localVarStatusCode,
                localVarHeaders,
                (EmailSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the execution history enabled setting. 
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ExecutionDataGlobalSettingsResponse</returns>
        
        public ExecutionDataGlobalSettingsResponse GetSettingsExecutiondata ()
        {
             ApiResponse<ExecutionDataGlobalSettingsResponse> localVarResponse = GetSettingsExecutiondataWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the execution history enabled setting. 
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ExecutionDataGlobalSettingsResponse</returns>
        
        public ApiResponse< ExecutionDataGlobalSettingsResponse > GetSettingsExecutiondataWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/settings/executiondata";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSettingsExecutiondata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSettingsExecutiondata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExecutionDataGlobalSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (ExecutionDataGlobalSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExecutionDataGlobalSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the execution history enabled setting. 
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ExecutionDataGlobalSettingsResponse</returns>
        
        public async System.Threading.Tasks.Task<ExecutionDataGlobalSettingsResponse> GetSettingsExecutiondataAsync ()
        {
             ApiResponse<ExecutionDataGlobalSettingsResponse> localVarResponse = await GetSettingsExecutiondataAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the execution history enabled setting. 
        /// Get the execution history enabled setting.
        /// GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ExecutionDataGlobalSettingsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExecutionDataGlobalSettingsResponse>> GetSettingsExecutiondataAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/settings/executiondata";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSettingsExecutiondata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSettingsExecutiondata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExecutionDataGlobalSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (ExecutionDataGlobalSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExecutionDataGlobalSettingsResponse)),
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->GetUsersAgentuiAgentsAutoanswerAgentIdSettings");

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->GetUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
        /// Patch email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EmailSettings</returns>
        
        public EmailSettings PatchEmailsSettings (EmailSettings body = null)
        {
             ApiResponse<EmailSettings> localVarResponse = PatchEmailsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EmailSettings</returns>
        
        public ApiResponse< EmailSettings > PatchEmailsSettingsWithHttpInfo (EmailSettings body = null)
        { 

            var localVarPath = "/api/v2/emails/settings";
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSettings>(localVarStatusCode,
                localVarHeaders,
                (EmailSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EmailSettings</returns>
        
        public async System.Threading.Tasks.Task<EmailSettings> PatchEmailsSettingsAsync (EmailSettings body = null)
        {
             ApiResponse<EmailSettings> localVarResponse = await PatchEmailsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch email Contact Center settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EmailSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EmailSettings>> PatchEmailsSettingsAsyncWithHttpInfo (EmailSettings body = null)
        { 

            var localVarPath = "/api/v2/emails/settings";
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSettings>(localVarStatusCode,
                localVarHeaders,
                (EmailSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Edit the execution history on off setting. 
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>ExecutionDataGlobalSettingsResponse</returns>
        
        public ExecutionDataGlobalSettingsResponse PatchSettingsExecutiondata (ExecutionDataSettingsRequest body)
        {
             ApiResponse<ExecutionDataGlobalSettingsResponse> localVarResponse = PatchSettingsExecutiondataWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit the execution history on off setting. 
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>ApiResponse of ExecutionDataGlobalSettingsResponse</returns>
        
        public ApiResponse< ExecutionDataGlobalSettingsResponse > PatchSettingsExecutiondataWithHttpInfo (ExecutionDataSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SettingsApi->PatchSettingsExecutiondata");

            var localVarPath = "/api/v2/settings/executiondata";
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchSettingsExecutiondata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSettingsExecutiondata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExecutionDataGlobalSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (ExecutionDataGlobalSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExecutionDataGlobalSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Edit the execution history on off setting. 
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>Task of ExecutionDataGlobalSettingsResponse</returns>
        
        public async System.Threading.Tasks.Task<ExecutionDataGlobalSettingsResponse> PatchSettingsExecutiondataAsync (ExecutionDataSettingsRequest body)
        {
             ApiResponse<ExecutionDataGlobalSettingsResponse> localVarResponse = await PatchSettingsExecutiondataAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit the execution history on off setting. 
        /// Edit the execution history on off setting.
        /// PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New Execution Data Setting</param>
        /// <returns>Task of ApiResponse (ExecutionDataGlobalSettingsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExecutionDataGlobalSettingsResponse>> PatchSettingsExecutiondataAsyncWithHttpInfo (ExecutionDataSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SettingsApi->PatchSettingsExecutiondata");
            

            var localVarPath = "/api/v2/settings/executiondata";
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchSettingsExecutiondata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSettingsExecutiondata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExecutionDataGlobalSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (ExecutionDataGlobalSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExecutionDataGlobalSettingsResponse)),
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SettingsApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SettingsApi->PatchUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SettingsApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
                throw new ApiException(400, "Missing required parameter 'agentId' when calling SettingsApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SettingsApi->PutUsersAgentuiAgentsAutoanswerAgentIdSettings");
            

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
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
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
