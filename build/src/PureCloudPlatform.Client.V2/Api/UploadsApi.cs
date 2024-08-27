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
    public interface IUploadsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get content upload from URL job status
        /// </summary>
        /// <remarks>
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>GetUploadSourceUrlJobStatusResponse</returns>
        
        GetUploadSourceUrlJobStatusResponse GetKnowledgeKnowledgebaseUploadsUrlsJob (string knowledgeBaseId, string jobId);

        /// <summary>
        /// Get content upload from URL job status
        /// </summary>
        /// <remarks>
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>ApiResponse of GetUploadSourceUrlJobStatusResponse</returns>
        
        ApiResponse<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobWithHttpInfo (string knowledgeBaseId, string jobId);

        /// <summary>
        /// Create upload presigned URL for draft function package file.
        /// </summary>
        /// <remarks>
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>FunctionUploadResponse</returns>
        
        FunctionUploadResponse PostIntegrationsActionDraftFunctionUpload (string actionId, FunctionUploadRequest body);

        /// <summary>
        /// Create upload presigned URL for draft function package file.
        /// </summary>
        /// <remarks>
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>ApiResponse of FunctionUploadResponse</returns>
        
        ApiResponse<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadWithHttpInfo (string actionId, FunctionUploadRequest body);

        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        UploadUrlResponse PostKnowledgeDocumentuploads (UploadUrlRequest body);

        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        ApiResponse<UploadUrlResponse> PostKnowledgeDocumentuploadsWithHttpInfo (UploadUrlRequest body);

        /// <summary>
        /// Create content upload from URL job
        /// </summary>
        /// <remarks>
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>CreateUploadSourceUrlJobResponse</returns>
        
        CreateUploadSourceUrlJobResponse PostKnowledgeKnowledgebaseUploadsUrlsJobs (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

        /// <summary>
        /// Create content upload from URL job
        /// </summary>
        /// <remarks>
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>ApiResponse of CreateUploadSourceUrlJobResponse</returns>
        
        ApiResponse<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsWithHttpInfo (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        UploadUrlResponse PostLanguageunderstandingMinerUploads (string minerId, Object body);

        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        ApiResponse<UploadUrlResponse> PostLanguageunderstandingMinerUploadsWithHttpInfo (string minerId, Object body);

        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        UploadUrlResponse PostUploadsLearningCoverart (LearningCoverArtUploadUrlRequest body);

        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        ApiResponse<UploadUrlResponse> PostUploadsLearningCoverartWithHttpInfo (LearningCoverArtUploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a public asset image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        UploadUrlResponse PostUploadsPublicassetsImages (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a public asset image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        ApiResponse<UploadUrlResponse> PostUploadsPublicassetsImagesWithHttpInfo (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a recording file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        UploadUrlResponse PostUploadsRecordings (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a recording file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        ApiResponse<UploadUrlResponse> PostUploadsRecordingsWithHttpInfo (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        UploadUrlResponse PostUploadsWorkforcemanagementHistoricaldataCsv (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        ApiResponse<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvWithHttpInfo (UploadUrlRequest body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get content upload from URL job status
        /// </summary>
        /// <remarks>
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>Task of GetUploadSourceUrlJobStatusResponse</returns>
        
        System.Threading.Tasks.Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobAsync (string knowledgeBaseId, string jobId);

        /// <summary>
        /// Get content upload from URL job status
        /// </summary>
        /// <remarks>
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>Task of ApiResponse (GetUploadSourceUrlJobStatusResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GetUploadSourceUrlJobStatusResponse>> GetKnowledgeKnowledgebaseUploadsUrlsJobAsyncWithHttpInfo (string knowledgeBaseId, string jobId);

        /// <summary>
        /// Create upload presigned URL for draft function package file.
        /// </summary>
        /// <remarks>
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>Task of FunctionUploadResponse</returns>
        
        System.Threading.Tasks.Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync (string actionId, FunctionUploadRequest body);

        /// <summary>
        /// Create upload presigned URL for draft function package file.
        /// </summary>
        /// <remarks>
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>Task of ApiResponse (FunctionUploadResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FunctionUploadResponse>> PostIntegrationsActionDraftFunctionUploadAsyncWithHttpInfo (string actionId, FunctionUploadRequest body);

        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        System.Threading.Tasks.Task<UploadUrlResponse> PostKnowledgeDocumentuploadsAsync (UploadUrlRequest body);

        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostKnowledgeDocumentuploadsAsyncWithHttpInfo (UploadUrlRequest body);

        /// <summary>
        /// Create content upload from URL job
        /// </summary>
        /// <remarks>
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>Task of CreateUploadSourceUrlJobResponse</returns>
        
        System.Threading.Tasks.Task<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

        /// <summary>
        /// Create content upload from URL job
        /// </summary>
        /// <remarks>
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>Task of ApiResponse (CreateUploadSourceUrlJobResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CreateUploadSourceUrlJobResponse>> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsyncWithHttpInfo (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body);

        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        System.Threading.Tasks.Task<UploadUrlResponse> PostLanguageunderstandingMinerUploadsAsync (string minerId, Object body);

        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostLanguageunderstandingMinerUploadsAsyncWithHttpInfo (string minerId, Object body);

        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsLearningCoverartAsync (LearningCoverArtUploadUrlRequest body);

        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsLearningCoverartAsyncWithHttpInfo (LearningCoverArtUploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a public asset image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsPublicassetsImagesAsync (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a public asset image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsPublicassetsImagesAsyncWithHttpInfo (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a recording file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsRecordingsAsync (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading a recording file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsRecordingsAsyncWithHttpInfo (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvAsync (UploadUrlRequest body);

        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsWorkforcemanagementHistoricaldataCsvAsyncWithHttpInfo (UploadUrlRequest body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UploadsApi : IUploadsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UploadsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UploadsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get content upload from URL job status 
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>GetUploadSourceUrlJobStatusResponse</returns>
        
        public GetUploadSourceUrlJobStatusResponse GetKnowledgeKnowledgebaseUploadsUrlsJob (string knowledgeBaseId, string jobId)
        {
             ApiResponse<GetUploadSourceUrlJobStatusResponse> localVarResponse = GetKnowledgeKnowledgebaseUploadsUrlsJobWithHttpInfo(knowledgeBaseId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get content upload from URL job status 
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>ApiResponse of GetUploadSourceUrlJobStatusResponse</returns>
        
        public ApiResponse< GetUploadSourceUrlJobStatusResponse > GetKnowledgeKnowledgebaseUploadsUrlsJobWithHttpInfo (string knowledgeBaseId, string jobId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId}";
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetUploadSourceUrlJobStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (GetUploadSourceUrlJobStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetUploadSourceUrlJobStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get content upload from URL job status 
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>Task of GetUploadSourceUrlJobStatusResponse</returns>
        
        public async System.Threading.Tasks.Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobAsync (string knowledgeBaseId, string jobId)
        {
             ApiResponse<GetUploadSourceUrlJobStatusResponse> localVarResponse = await GetKnowledgeKnowledgebaseUploadsUrlsJobAsyncWithHttpInfo(knowledgeBaseId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get content upload from URL job status 
        /// 
        /// GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="jobId">Upload job ID</param>
        /// <returns>Task of ApiResponse (GetUploadSourceUrlJobStatusResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GetUploadSourceUrlJobStatusResponse>> GetKnowledgeKnowledgebaseUploadsUrlsJobAsyncWithHttpInfo (string knowledgeBaseId, string jobId)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling UploadsApi->GetKnowledgeKnowledgebaseUploadsUrlsJob");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId}";
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetKnowledgeKnowledgebaseUploadsUrlsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetUploadSourceUrlJobStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (GetUploadSourceUrlJobStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetUploadSourceUrlJobStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create upload presigned URL for draft function package file. 
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>FunctionUploadResponse</returns>
        
        public FunctionUploadResponse PostIntegrationsActionDraftFunctionUpload (string actionId, FunctionUploadRequest body)
        {
             ApiResponse<FunctionUploadResponse> localVarResponse = PostIntegrationsActionDraftFunctionUploadWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create upload presigned URL for draft function package file. 
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>ApiResponse of FunctionUploadResponse</returns>
        
        public ApiResponse< FunctionUploadResponse > PostIntegrationsActionDraftFunctionUploadWithHttpInfo (string actionId, FunctionUploadRequest body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/function/upload";
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FunctionUploadResponse>(localVarStatusCode,
                localVarHeaders,
                (FunctionUploadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunctionUploadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create upload presigned URL for draft function package file. 
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>Task of FunctionUploadResponse</returns>
        
        public async System.Threading.Tasks.Task<FunctionUploadResponse> PostIntegrationsActionDraftFunctionUploadAsync (string actionId, FunctionUploadRequest body)
        {
             ApiResponse<FunctionUploadResponse> localVarResponse = await PostIntegrationsActionDraftFunctionUploadAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create upload presigned URL for draft function package file. 
        /// 
        /// PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to request URL upload.</param>
        /// <returns>Task of ApiResponse (FunctionUploadResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FunctionUploadResponse>> PostIntegrationsActionDraftFunctionUploadAsyncWithHttpInfo (string actionId, FunctionUploadRequest body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostIntegrationsActionDraftFunctionUpload");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/function/upload";
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftFunctionUpload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FunctionUploadResponse>(localVarStatusCode,
                localVarHeaders,
                (FunctionUploadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunctionUploadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        public UploadUrlResponse PostKnowledgeDocumentuploads (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = PostKnowledgeDocumentuploadsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        public ApiResponse< UploadUrlResponse > PostKnowledgeDocumentuploadsWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeDocumentuploads");

            var localVarPath = "/api/v2/knowledge/documentuploads";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UploadUrlResponse> PostKnowledgeDocumentuploadsAsync (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = await PostKnowledgeDocumentuploadsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a presigned URL for uploading a knowledge import file with a set of documents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostKnowledgeDocumentuploadsAsyncWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeDocumentuploads");
            

            var localVarPath = "/api/v2/knowledge/documentuploads";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeDocumentuploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create content upload from URL job 
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>CreateUploadSourceUrlJobResponse</returns>
        
        public CreateUploadSourceUrlJobResponse PostKnowledgeKnowledgebaseUploadsUrlsJobs (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
        {
             ApiResponse<CreateUploadSourceUrlJobResponse> localVarResponse = PostKnowledgeKnowledgebaseUploadsUrlsJobsWithHttpInfo(knowledgeBaseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create content upload from URL job 
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>ApiResponse of CreateUploadSourceUrlJobResponse</returns>
        
        public ApiResponse< CreateUploadSourceUrlJobResponse > PostKnowledgeKnowledgebaseUploadsUrlsJobsWithHttpInfo (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs";
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateUploadSourceUrlJobResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateUploadSourceUrlJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateUploadSourceUrlJobResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create content upload from URL job 
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>Task of CreateUploadSourceUrlJobResponse</returns>
        
        public async System.Threading.Tasks.Task<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
        {
             ApiResponse<CreateUploadSourceUrlJobResponse> localVarResponse = await PostKnowledgeKnowledgebaseUploadsUrlsJobsAsyncWithHttpInfo(knowledgeBaseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create content upload from URL job 
        /// 
        /// PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="knowledgeBaseId">Knowledge base ID</param>
        /// <param name="body">uploadRequest</param>
        /// <returns>Task of ApiResponse (CreateUploadSourceUrlJobResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CreateUploadSourceUrlJobResponse>> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsyncWithHttpInfo (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)
        { 
            // verify the required parameter 'knowledgeBaseId' is set
            if (knowledgeBaseId == null)
                throw new ApiException(400, "Missing required parameter 'knowledgeBaseId' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostKnowledgeKnowledgebaseUploadsUrlsJobs");
            

            var localVarPath = "/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs";
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
            if (knowledgeBaseId != null) localVarPathParams.Add("knowledgeBaseId", this.Configuration.ApiClient.ParameterToString(knowledgeBaseId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateUploadSourceUrlJobResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateUploadSourceUrlJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateUploadSourceUrlJobResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        public UploadUrlResponse PostLanguageunderstandingMinerUploads (string minerId, Object body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = PostLanguageunderstandingMinerUploadsWithHttpInfo(minerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        public ApiResponse< UploadUrlResponse > PostLanguageunderstandingMinerUploadsWithHttpInfo (string minerId, Object body)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostLanguageunderstandingMinerUploads");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/uploads";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UploadUrlResponse> PostLanguageunderstandingMinerUploadsAsync (string minerId, Object body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = await PostLanguageunderstandingMinerUploadsAsyncWithHttpInfo(minerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostLanguageunderstandingMinerUploadsAsyncWithHttpInfo (string minerId, Object body)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostLanguageunderstandingMinerUploads");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/uploads";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        public UploadUrlResponse PostUploadsLearningCoverart (LearningCoverArtUploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsLearningCoverartWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        public ApiResponse< UploadUrlResponse > PostUploadsLearningCoverartWithHttpInfo (LearningCoverArtUploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsLearningCoverart");

            var localVarPath = "/api/v2/uploads/learning/coverart";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsLearningCoverartAsync (LearningCoverArtUploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsLearningCoverartAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generates pre-signed URL to upload cover art for learning modules 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsLearningCoverartAsyncWithHttpInfo (LearningCoverArtUploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsLearningCoverart");
            

            var localVarPath = "/api/v2/uploads/learning/coverart";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsLearningCoverart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates presigned url for uploading a public asset image 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        public UploadUrlResponse PostUploadsPublicassetsImages (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsPublicassetsImagesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates presigned url for uploading a public asset image 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        public ApiResponse< UploadUrlResponse > PostUploadsPublicassetsImagesWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsPublicassetsImages");

            var localVarPath = "/api/v2/uploads/publicassets/images";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates presigned url for uploading a public asset image 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsPublicassetsImagesAsync (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsPublicassetsImagesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates presigned url for uploading a public asset image 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsPublicassetsImagesAsyncWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsPublicassetsImages");
            

            var localVarPath = "/api/v2/uploads/publicassets/images";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsPublicassetsImages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates presigned url for uploading a recording file 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        public UploadUrlResponse PostUploadsRecordings (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsRecordingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates presigned url for uploading a recording file 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        public ApiResponse< UploadUrlResponse > PostUploadsRecordingsWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsRecordings");

            var localVarPath = "/api/v2/uploads/recordings";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates presigned url for uploading a recording file 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsRecordingsAsync (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsRecordingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates presigned url for uploading a recording file 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsRecordingsAsyncWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsRecordings");
            

            var localVarPath = "/api/v2/uploads/recordings";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>UploadUrlResponse</returns>
        
        public UploadUrlResponse PostUploadsWorkforcemanagementHistoricaldataCsv (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = PostUploadsWorkforcemanagementHistoricaldataCsvWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of UploadUrlResponse</returns>
        
        public ApiResponse< UploadUrlResponse > PostUploadsWorkforcemanagementHistoricaldataCsvWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsWorkforcemanagementHistoricaldataCsv");

            var localVarPath = "/api/v2/uploads/workforcemanagement/historicaldata/csv";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of UploadUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<UploadUrlResponse> PostUploadsWorkforcemanagementHistoricaldataCsvAsync (UploadUrlRequest body)
        {
             ApiResponse<UploadUrlResponse> localVarResponse = await PostUploadsWorkforcemanagementHistoricaldataCsvAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates presigned url for uploading WFM historical data file. Requires data in csv format. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (UploadUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UploadUrlResponse>> PostUploadsWorkforcemanagementHistoricaldataCsvAsyncWithHttpInfo (UploadUrlRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UploadsApi->PostUploadsWorkforcemanagementHistoricaldataCsv");
            

            var localVarPath = "/api/v2/uploads/workforcemanagement/historicaldata/csv";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUploadsWorkforcemanagementHistoricaldataCsv: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UploadUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (UploadUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
