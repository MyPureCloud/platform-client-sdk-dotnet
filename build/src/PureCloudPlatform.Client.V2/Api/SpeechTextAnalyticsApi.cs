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
    public interface ISpeechTextAnalyticsApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ConversationMetrics</returns>
        ConversationMetrics GetSpeechandtextanalyticsConversation (string conversationId);

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ApiResponse of ConversationMetrics</returns>
        ApiResponse<ConversationMetrics> GetSpeechandtextanalyticsConversationWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>TranscriptUrl</returns>
        TranscriptUrl GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId);

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>ApiResponse of TranscriptUrl</returns>
        ApiResponse<TranscriptUrl> GetSpeechandtextanalyticsConversationCommunicationTranscripturlWithHttpInfo (string conversationId, string communicationId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ConversationMetrics</returns>
        System.Threading.Tasks.Task<ConversationMetrics> GetSpeechandtextanalyticsConversationAsync (string conversationId);

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ApiResponse (ConversationMetrics)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationMetrics>> GetSpeechandtextanalyticsConversationAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of TranscriptUrl</returns>
        System.Threading.Tasks.Task<TranscriptUrl> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsync (string conversationId, string communicationId);

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of ApiResponse (TranscriptUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<TranscriptUrl>> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsyncWithHttpInfo (string conversationId, string communicationId);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SpeechTextAnalyticsApi : ISpeechTextAnalyticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTextAnalyticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SpeechTextAnalyticsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTextAnalyticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SpeechTextAnalyticsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ConversationMetrics</returns>
        public ConversationMetrics GetSpeechandtextanalyticsConversation (string conversationId)
        {
             ApiResponse<ConversationMetrics> localVarResponse = GetSpeechandtextanalyticsConversationWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ApiResponse of ConversationMetrics</returns>
        public ApiResponse< ConversationMetrics > GetSpeechandtextanalyticsConversationWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversation");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}";
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
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationMetrics>(localVarStatusCode,
                localVarHeaders,
                (ConversationMetrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationMetrics)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ConversationMetrics</returns>
        public async System.Threading.Tasks.Task<ConversationMetrics> GetSpeechandtextanalyticsConversationAsync (string conversationId)
        {
             ApiResponse<ConversationMetrics> localVarResponse = await GetSpeechandtextanalyticsConversationAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ApiResponse (ConversationMetrics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationMetrics>> GetSpeechandtextanalyticsConversationAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversation");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}";
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
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationMetrics>(localVarStatusCode,
                localVarHeaders,
                (ConversationMetrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationMetrics)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>TranscriptUrl</returns>
        public TranscriptUrl GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId)
        {
             ApiResponse<TranscriptUrl> localVarResponse = GetSpeechandtextanalyticsConversationCommunicationTranscripturlWithHttpInfo(conversationId, communicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>ApiResponse of TranscriptUrl</returns>
        public ApiResponse< TranscriptUrl > GetSpeechandtextanalyticsConversationCommunicationTranscripturlWithHttpInfo (string conversationId, string communicationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl";
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
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));
            if (communicationId != null) localVarPathParams.Add("communicationId", this.Configuration.ApiClient.ParameterToString(communicationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranscriptUrl>(localVarStatusCode,
                localVarHeaders,
                (TranscriptUrl) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranscriptUrl)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of TranscriptUrl</returns>
        public async System.Threading.Tasks.Task<TranscriptUrl> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsync (string conversationId, string communicationId)
        {
             ApiResponse<TranscriptUrl> localVarResponse = await GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsyncWithHttpInfo(conversationId, communicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of ApiResponse (TranscriptUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TranscriptUrl>> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsyncWithHttpInfo (string conversationId, string communicationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");
            
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl";
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
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));
            if (communicationId != null) localVarPathParams.Add("communicationId", this.Configuration.ApiClient.ParameterToString(communicationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranscriptUrl>(localVarStatusCode,
                localVarHeaders,
                (TranscriptUrl) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranscriptUrl)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
