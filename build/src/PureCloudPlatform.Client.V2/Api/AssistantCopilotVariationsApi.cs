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
    public interface IAssistantCopilotVariationsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns></returns>
        
        void DeleteAssistantVariation (string assistantId, string variationId);

        /// <summary>
        /// Delete assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAssistantVariationWithHttpInfo (string assistantId, string variationId);

        /// <summary>
        /// Get assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>AssistantCopilotVariation</returns>
        
        AssistantCopilotVariation GetAssistantVariation (string assistantId, string variationId);

        /// <summary>
        /// Get assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>ApiResponse of AssistantCopilotVariation</returns>
        
        ApiResponse<AssistantCopilotVariation> GetAssistantVariationWithHttpInfo (string assistantId, string variationId);

        /// <summary>
        /// Get variations of an assistant copilot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>AssistantCopilotVariationListing</returns>
        
        AssistantCopilotVariationListing GetAssistantVariations (string assistantId);

        /// <summary>
        /// Get variations of an assistant copilot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>ApiResponse of AssistantCopilotVariationListing</returns>
        
        ApiResponse<AssistantCopilotVariationListing> GetAssistantVariationsWithHttpInfo (string assistantId);

        /// <summary>
        /// Create assistant copilot variation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantCopilotVariation</returns>
        
        AssistantCopilotVariation PostAssistantVariations (string assistantId, AssistantCopilotVariation body);

        /// <summary>
        /// Create assistant copilot variation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantCopilotVariation</returns>
        
        ApiResponse<AssistantCopilotVariation> PostAssistantVariationsWithHttpInfo (string assistantId, AssistantCopilotVariation body);

        /// <summary>
        /// Update assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantCopilotVariation</returns>
        
        AssistantCopilotVariation PutAssistantVariation (string assistantId, string variationId, AssistantCopilotVariation body);

        /// <summary>
        /// Update assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantCopilotVariation</returns>
        
        ApiResponse<AssistantCopilotVariation> PutAssistantVariationWithHttpInfo (string assistantId, string variationId, AssistantCopilotVariation body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAssistantVariationAsync (string assistantId, string variationId);

        /// <summary>
        /// Delete assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantVariationAsyncWithHttpInfo (string assistantId, string variationId);

        /// <summary>
        /// Get assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of AssistantCopilotVariation</returns>
        
        System.Threading.Tasks.Task<AssistantCopilotVariation> GetAssistantVariationAsync (string assistantId, string variationId);

        /// <summary>
        /// Get assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariation>> GetAssistantVariationAsyncWithHttpInfo (string assistantId, string variationId);

        /// <summary>
        /// Get variations of an assistant copilot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of AssistantCopilotVariationListing</returns>
        
        System.Threading.Tasks.Task<AssistantCopilotVariationListing> GetAssistantVariationsAsync (string assistantId);

        /// <summary>
        /// Get variations of an assistant copilot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariationListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariationListing>> GetAssistantVariationsAsyncWithHttpInfo (string assistantId);

        /// <summary>
        /// Create assistant copilot variation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantCopilotVariation</returns>
        
        System.Threading.Tasks.Task<AssistantCopilotVariation> PostAssistantVariationsAsync (string assistantId, AssistantCopilotVariation body);

        /// <summary>
        /// Create assistant copilot variation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariation>> PostAssistantVariationsAsyncWithHttpInfo (string assistantId, AssistantCopilotVariation body);

        /// <summary>
        /// Update assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantCopilotVariation</returns>
        
        System.Threading.Tasks.Task<AssistantCopilotVariation> PutAssistantVariationAsync (string assistantId, string variationId, AssistantCopilotVariation body);

        /// <summary>
        /// Update assistant copilot variation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariation>> PutAssistantVariationAsyncWithHttpInfo (string assistantId, string variationId, AssistantCopilotVariation body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AssistantCopilotVariationsApi : IAssistantCopilotVariationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantCopilotVariationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssistantCopilotVariationsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantCopilotVariationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AssistantCopilotVariationsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns></returns>
        
        public void DeleteAssistantVariation (string assistantId, string variationId)
        {
             DeleteAssistantVariationWithHttpInfo(assistantId, variationId);
        }

        /// <summary>
        /// Delete assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAssistantVariationWithHttpInfo (string assistantId, string variationId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->DeleteAssistantVariation");
            // verify the required parameter 'variationId' is set
            if (variationId == null)
                throw new ApiException(400, "Missing required parameter 'variationId' when calling AssistantCopilotVariationsApi->DeleteAssistantVariation");

            var localVarPath = "/api/v2/assistants/{assistantId}/variations/{variationId}";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (variationId != null) localVarPathParams.Add("variationId", this.Configuration.ApiClient.ParameterToString(variationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantVariation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantVariation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAssistantVariationAsync (string assistantId, string variationId)
        {
             await DeleteAssistantVariationAsyncWithHttpInfo(assistantId, variationId);

        }

        /// <summary>
        /// Delete assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantVariationAsyncWithHttpInfo (string assistantId, string variationId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->DeleteAssistantVariation");
            
            // verify the required parameter 'variationId' is set
            if (variationId == null)
                throw new ApiException(400, "Missing required parameter 'variationId' when calling AssistantCopilotVariationsApi->DeleteAssistantVariation");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/variations/{variationId}";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (variationId != null) localVarPathParams.Add("variationId", this.Configuration.ApiClient.ParameterToString(variationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantVariation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantVariation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>AssistantCopilotVariation</returns>
        
        public AssistantCopilotVariation GetAssistantVariation (string assistantId, string variationId)
        {
             ApiResponse<AssistantCopilotVariation> localVarResponse = GetAssistantVariationWithHttpInfo(assistantId, variationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>ApiResponse of AssistantCopilotVariation</returns>
        
        public ApiResponse< AssistantCopilotVariation > GetAssistantVariationWithHttpInfo (string assistantId, string variationId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->GetAssistantVariation");
            // verify the required parameter 'variationId' is set
            if (variationId == null)
                throw new ApiException(400, "Missing required parameter 'variationId' when calling AssistantCopilotVariationsApi->GetAssistantVariation");

            var localVarPath = "/api/v2/assistants/{assistantId}/variations/{variationId}";
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
            if (variationId != null) localVarPathParams.Add("variationId", this.Configuration.ApiClient.ParameterToString(variationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariation>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of AssistantCopilotVariation</returns>
        
        public async System.Threading.Tasks.Task<AssistantCopilotVariation> GetAssistantVariationAsync (string assistantId, string variationId)
        {
             ApiResponse<AssistantCopilotVariation> localVarResponse = await GetAssistantVariationAsyncWithHttpInfo(assistantId, variationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariation>> GetAssistantVariationAsyncWithHttpInfo (string assistantId, string variationId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->GetAssistantVariation");
            
            // verify the required parameter 'variationId' is set
            if (variationId == null)
                throw new ApiException(400, "Missing required parameter 'variationId' when calling AssistantCopilotVariationsApi->GetAssistantVariation");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/variations/{variationId}";
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
            if (variationId != null) localVarPathParams.Add("variationId", this.Configuration.ApiClient.ParameterToString(variationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariation>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get variations of an assistant copilot 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>AssistantCopilotVariationListing</returns>
        
        public AssistantCopilotVariationListing GetAssistantVariations (string assistantId)
        {
             ApiResponse<AssistantCopilotVariationListing> localVarResponse = GetAssistantVariationsWithHttpInfo(assistantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get variations of an assistant copilot 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>ApiResponse of AssistantCopilotVariationListing</returns>
        
        public ApiResponse< AssistantCopilotVariationListing > GetAssistantVariationsWithHttpInfo (string assistantId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->GetAssistantVariations");

            var localVarPath = "/api/v2/assistants/{assistantId}/variations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariationListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get variations of an assistant copilot 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of AssistantCopilotVariationListing</returns>
        
        public async System.Threading.Tasks.Task<AssistantCopilotVariationListing> GetAssistantVariationsAsync (string assistantId)
        {
             ApiResponse<AssistantCopilotVariationListing> localVarResponse = await GetAssistantVariationsAsyncWithHttpInfo(assistantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get variations of an assistant copilot 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariationListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariationListing>> GetAssistantVariationsAsyncWithHttpInfo (string assistantId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->GetAssistantVariations");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/variations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantVariations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariationListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create assistant copilot variation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantCopilotVariation</returns>
        
        public AssistantCopilotVariation PostAssistantVariations (string assistantId, AssistantCopilotVariation body)
        {
             ApiResponse<AssistantCopilotVariation> localVarResponse = PostAssistantVariationsWithHttpInfo(assistantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create assistant copilot variation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantCopilotVariation</returns>
        
        public ApiResponse< AssistantCopilotVariation > PostAssistantVariationsWithHttpInfo (string assistantId, AssistantCopilotVariation body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->PostAssistantVariations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssistantCopilotVariationsApi->PostAssistantVariations");

            var localVarPath = "/api/v2/assistants/{assistantId}/variations";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantVariations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantVariations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariation>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create assistant copilot variation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantCopilotVariation</returns>
        
        public async System.Threading.Tasks.Task<AssistantCopilotVariation> PostAssistantVariationsAsync (string assistantId, AssistantCopilotVariation body)
        {
             ApiResponse<AssistantCopilotVariation> localVarResponse = await PostAssistantVariationsAsyncWithHttpInfo(assistantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create assistant copilot variation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariation>> PostAssistantVariationsAsyncWithHttpInfo (string assistantId, AssistantCopilotVariation body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->PostAssistantVariations");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssistantCopilotVariationsApi->PostAssistantVariations");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/variations";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantVariations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantVariations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariation>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantCopilotVariation</returns>
        
        public AssistantCopilotVariation PutAssistantVariation (string assistantId, string variationId, AssistantCopilotVariation body)
        {
             ApiResponse<AssistantCopilotVariation> localVarResponse = PutAssistantVariationWithHttpInfo(assistantId, variationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantCopilotVariation</returns>
        
        public ApiResponse< AssistantCopilotVariation > PutAssistantVariationWithHttpInfo (string assistantId, string variationId, AssistantCopilotVariation body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->PutAssistantVariation");
            // verify the required parameter 'variationId' is set
            if (variationId == null)
                throw new ApiException(400, "Missing required parameter 'variationId' when calling AssistantCopilotVariationsApi->PutAssistantVariation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssistantCopilotVariationsApi->PutAssistantVariation");

            var localVarPath = "/api/v2/assistants/{assistantId}/variations/{variationId}";
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
            if (variationId != null) localVarPathParams.Add("variationId", this.Configuration.ApiClient.ParameterToString(variationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantVariation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantVariation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariation>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantCopilotVariation</returns>
        
        public async System.Threading.Tasks.Task<AssistantCopilotVariation> PutAssistantVariationAsync (string assistantId, string variationId, AssistantCopilotVariation body)
        {
             ApiResponse<AssistantCopilotVariation> localVarResponse = await PutAssistantVariationAsyncWithHttpInfo(assistantId, variationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update assistant copilot variation by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="variationId">Variation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantCopilotVariation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantCopilotVariation>> PutAssistantVariationAsyncWithHttpInfo (string assistantId, string variationId, AssistantCopilotVariation body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AssistantCopilotVariationsApi->PutAssistantVariation");
            
            // verify the required parameter 'variationId' is set
            if (variationId == null)
                throw new ApiException(400, "Missing required parameter 'variationId' when calling AssistantCopilotVariationsApi->PutAssistantVariation");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssistantCopilotVariationsApi->PutAssistantVariation");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/variations/{variationId}";
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
            if (variationId != null) localVarPathParams.Add("variationId", this.Configuration.ApiClient.ParameterToString(variationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantVariation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantVariation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantCopilotVariation>(localVarStatusCode,
                localVarHeaders,
                (AssistantCopilotVariation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantCopilotVariation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
