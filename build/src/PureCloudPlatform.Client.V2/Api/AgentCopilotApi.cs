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
    public interface IAgentCopilotApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get copilot configuration of an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Copilot</returns>
        
        Copilot GetAssistantCopilot (string assistantId);

        /// <summary>
        /// Get copilot configuration of an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>ApiResponse of Copilot</returns>
        
        ApiResponse<Copilot> GetAssistantCopilotWithHttpInfo (string assistantId);

        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>LanguageSupportResponse</returns>
        
        LanguageSupportResponse GetAssistantsCopilotFeaturesupport (string language = null);

        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>ApiResponse of LanguageSupportResponse</returns>
        
        ApiResponse<LanguageSupportResponse> GetAssistantsCopilotFeaturesupportWithHttpInfo (string language = null);

        /// <summary>
        /// Update agent copilot configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Copilot</returns>
        
        Copilot PutAssistantCopilot (string assistantId, Copilot body);

        /// <summary>
        /// Update agent copilot configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Copilot</returns>
        
        ApiResponse<Copilot> PutAssistantCopilotWithHttpInfo (string assistantId, Copilot body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get copilot configuration of an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of Copilot</returns>
        
        System.Threading.Tasks.Task<Copilot> GetAssistantCopilotAsync (string assistantId);

        /// <summary>
        /// Get copilot configuration of an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of ApiResponse (Copilot)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Copilot>> GetAssistantCopilotAsyncWithHttpInfo (string assistantId);

        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>Task of LanguageSupportResponse</returns>
        
        System.Threading.Tasks.Task<LanguageSupportResponse> GetAssistantsCopilotFeaturesupportAsync (string language = null);

        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>Task of ApiResponse (LanguageSupportResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LanguageSupportResponse>> GetAssistantsCopilotFeaturesupportAsyncWithHttpInfo (string language = null);

        /// <summary>
        /// Update agent copilot configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Copilot</returns>
        
        System.Threading.Tasks.Task<Copilot> PutAssistantCopilotAsync (string assistantId, Copilot body);

        /// <summary>
        /// Update agent copilot configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Copilot)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Copilot>> PutAssistantCopilotAsyncWithHttpInfo (string assistantId, Copilot body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AgentCopilotApi : IAgentCopilotApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCopilotApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgentCopilotApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCopilotApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgentCopilotApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get copilot configuration of an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Copilot</returns>
        
        public Copilot GetAssistantCopilot (string assistantId)
        {
             ApiResponse<Copilot> localVarResponse = GetAssistantCopilotWithHttpInfo(assistantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get copilot configuration of an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>ApiResponse of Copilot</returns>
        
        public ApiResponse< Copilot > GetAssistantCopilotWithHttpInfo (string assistantId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->GetAssistantCopilot");

            var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Copilot>(localVarStatusCode,
                localVarHeaders,
                (Copilot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get copilot configuration of an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of Copilot</returns>
        
        public async System.Threading.Tasks.Task<Copilot> GetAssistantCopilotAsync (string assistantId)
        {
             ApiResponse<Copilot> localVarResponse = await GetAssistantCopilotAsyncWithHttpInfo(assistantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get copilot configuration of an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of ApiResponse (Copilot)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Copilot>> GetAssistantCopilotAsyncWithHttpInfo (string assistantId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->GetAssistantCopilot");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Copilot>(localVarStatusCode,
                localVarHeaders,
                (Copilot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>LanguageSupportResponse</returns>
        
        public LanguageSupportResponse GetAssistantsCopilotFeaturesupport (string language = null)
        {
             ApiResponse<LanguageSupportResponse> localVarResponse = GetAssistantsCopilotFeaturesupportWithHttpInfo(language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>ApiResponse of LanguageSupportResponse</returns>
        
        public ApiResponse< LanguageSupportResponse > GetAssistantsCopilotFeaturesupportWithHttpInfo (string language = null)
        { 

            var localVarPath = "/api/v2/assistants/copilot/featuresupport";
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
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsCopilotFeaturesupport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsCopilotFeaturesupport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LanguageSupportResponse>(localVarStatusCode,
                localVarHeaders,
                (LanguageSupportResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageSupportResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>Task of LanguageSupportResponse</returns>
        
        public async System.Threading.Tasks.Task<LanguageSupportResponse> GetAssistantsCopilotFeaturesupportAsync (string language = null)
        {
             ApiResponse<LanguageSupportResponse> localVarResponse = await GetAssistantsCopilotFeaturesupportAsyncWithHttpInfo(language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about the support of features for all the languages or only for a certain language. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Which language are the features supported for (optional)</param>
        /// <returns>Task of ApiResponse (LanguageSupportResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LanguageSupportResponse>> GetAssistantsCopilotFeaturesupportAsyncWithHttpInfo (string language = null)
        { 

            var localVarPath = "/api/v2/assistants/copilot/featuresupport";
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
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsCopilotFeaturesupport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsCopilotFeaturesupport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LanguageSupportResponse>(localVarStatusCode,
                localVarHeaders,
                (LanguageSupportResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageSupportResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update agent copilot configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Copilot</returns>
        
        public Copilot PutAssistantCopilot (string assistantId, Copilot body)
        {
             ApiResponse<Copilot> localVarResponse = PutAssistantCopilotWithHttpInfo(assistantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update agent copilot configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Copilot</returns>
        
        public ApiResponse< Copilot > PutAssistantCopilotWithHttpInfo (string assistantId, Copilot body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->PutAssistantCopilot");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentCopilotApi->PutAssistantCopilot");

            var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
            var localVarHttpMethod = "Put";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Copilot>(localVarStatusCode,
                localVarHeaders,
                (Copilot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update agent copilot configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Copilot</returns>
        
        public async System.Threading.Tasks.Task<Copilot> PutAssistantCopilotAsync (string assistantId, Copilot body)
        {
             ApiResponse<Copilot> localVarResponse = await PutAssistantCopilotAsyncWithHttpInfo(assistantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update agent copilot configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Copilot)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Copilot>> PutAssistantCopilotAsyncWithHttpInfo (string assistantId, Copilot body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentCopilotApi->PutAssistantCopilot");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentCopilotApi->PutAssistantCopilot");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/copilot";
            var localVarHttpMethod = "Put";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantCopilot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Copilot>(localVarStatusCode,
                localVarHeaders,
                (Copilot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Copilot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
