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
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>Program</returns>
        Program GetSpeechandtextanalyticsProgram (string programId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>ApiResponse of Program</returns>
        ApiResponse<Program> GetSpeechandtextanalyticsProgramWithHttpInfo (string programId);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>Topic</returns>
        Topic GetSpeechandtextanalyticsTopic (string topicId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>ApiResponse of Topic</returns>
        ApiResponse<Topic> GetSpeechandtextanalyticsTopicWithHttpInfo (string topicId);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Topic</returns>
        Topic PostSpeechandtextanalyticsTopics (CreateTopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>ApiResponse of Topic</returns>
        ApiResponse<Topic> PostSpeechandtextanalyticsTopicsWithHttpInfo (CreateTopicRequest body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>Task of Program</returns>
        System.Threading.Tasks.Task<Program> GetSpeechandtextanalyticsProgramAsync (string programId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        System.Threading.Tasks.Task<ApiResponse<Program>> GetSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>Task of Topic</returns>
        System.Threading.Tasks.Task<Topic> GetSpeechandtextanalyticsTopicAsync (string topicId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Topic>> GetSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of Topic</returns>
        System.Threading.Tasks.Task<Topic> PostSpeechandtextanalyticsTopicsAsync (CreateTopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Topic>> PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo (CreateTopicRequest body);
        
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
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>Program</returns>
        public Program GetSpeechandtextanalyticsProgram (string programId)
        {
             ApiResponse<Program> localVarResponse = GetSpeechandtextanalyticsProgramWithHttpInfo(programId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>ApiResponse of Program</returns>
        public ApiResponse< Program > GetSpeechandtextanalyticsProgramWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>Task of Program</returns>
        public async System.Threading.Tasks.Task<Program> GetSpeechandtextanalyticsProgramAsync (string programId)
        {
             ApiResponse<Program> localVarResponse = await GetSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the topic to get</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Program>> GetSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>Topic</returns>
        public Topic GetSpeechandtextanalyticsTopic (string topicId)
        {
             ApiResponse<Topic> localVarResponse = GetSpeechandtextanalyticsTopicWithHttpInfo(topicId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>ApiResponse of Topic</returns>
        public ApiResponse< Topic > GetSpeechandtextanalyticsTopicWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>Task of Topic</returns>
        public async System.Threading.Tasks.Task<Topic> GetSpeechandtextanalyticsTopicAsync (string topicId)
        {
             ApiResponse<Topic> localVarResponse = await GetSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic to get</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> GetSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Topic</returns>
        public Topic PostSpeechandtextanalyticsTopics (CreateTopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = PostSpeechandtextanalyticsTopicsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>ApiResponse of Topic</returns>
        public ApiResponse< Topic > PostSpeechandtextanalyticsTopicsWithHttpInfo (CreateTopicRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopics");

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of Topic</returns>
        public async System.Threading.Tasks.Task<Topic> PostSpeechandtextanalyticsTopicsAsync (CreateTopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = await PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo (CreateTopicRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopics");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
