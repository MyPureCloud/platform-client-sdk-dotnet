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
    public interface ILanguageUnderstandingApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns></returns>
        void DeleteLanguageunderstandingDomain (string domainId);

        /// <summary>
        /// Delete an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLanguageunderstandingDomainWithHttpInfo (string domainId);
        
        /// <summary>
        /// Delete the feedback on the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns></returns>
        void DeleteLanguageunderstandingDomainFeedbackFeedbackId (string domainId, string feedbackId);

        /// <summary>
        /// Delete the feedback on the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLanguageunderstandingDomainFeedbackFeedbackIdWithHttpInfo (string domainId, string feedbackId);
        
        /// <summary>
        /// Delete an NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns></returns>
        void DeleteLanguageunderstandingDomainVersion (string domainId, string domainVersionId);

        /// <summary>
        /// Delete an NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLanguageunderstandingDomainVersionWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Find an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>NluDomain</returns>
        NluDomain GetLanguageunderstandingDomain (string domainId);

        /// <summary>
        /// Find an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>ApiResponse of NluDomain</returns>
        ApiResponse<NluDomain> GetLanguageunderstandingDomainWithHttpInfo (string domainId);
        
        /// <summary>
        /// Get all feedback in the given NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>NluFeedbackListing</returns>
        NluFeedbackListing GetLanguageunderstandingDomainFeedback (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null);

        /// <summary>
        /// Get all feedback in the given NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of NluFeedbackListing</returns>
        ApiResponse<NluFeedbackListing> GetLanguageunderstandingDomainFeedbackWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null);
        
        /// <summary>
        /// Find a Feedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>NluFeedbackResponse</returns>
        NluFeedbackResponse GetLanguageunderstandingDomainFeedbackFeedbackId (string domainId, string feedbackId, List<string> fields = null);

        /// <summary>
        /// Find a Feedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of NluFeedbackResponse</returns>
        ApiResponse<NluFeedbackResponse> GetLanguageunderstandingDomainFeedbackFeedbackIdWithHttpInfo (string domainId, string feedbackId, List<string> fields = null);
        
        /// <summary>
        /// Find an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>NluDomainVersion</returns>
        NluDomainVersion GetLanguageunderstandingDomainVersion (string domainId, string domainVersionId, bool? includeUtterances = null);

        /// <summary>
        /// Find an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        ApiResponse<NluDomainVersion> GetLanguageunderstandingDomainVersionWithHttpInfo (string domainId, string domainVersionId, bool? includeUtterances = null);
        
        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>NluDomainVersionQualityReport</returns>
        NluDomainVersionQualityReport GetLanguageunderstandingDomainVersionReport (string domainId, string domainVersionId);

        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of NluDomainVersionQualityReport</returns>
        ApiResponse<NluDomainVersionQualityReport> GetLanguageunderstandingDomainVersionReportWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Get all NLU Domain Versions for a given Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>NluDomainVersionListing</returns>
        NluDomainVersionListing GetLanguageunderstandingDomainVersions (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all NLU Domain Versions for a given Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of NluDomainVersionListing</returns>
        ApiResponse<NluDomainVersionListing> GetLanguageunderstandingDomainVersionsWithHttpInfo (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get all NLU Domains.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>NluDomainListing</returns>
        NluDomainListing GetLanguageunderstandingDomains (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all NLU Domains.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of NluDomainListing</returns>
        ApiResponse<NluDomainListing> GetLanguageunderstandingDomainsWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Update an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>NluDomain</returns>
        NluDomain PatchLanguageunderstandingDomain (string domainId, NluDomain body);

        /// <summary>
        /// Update an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>ApiResponse of NluDomain</returns>
        ApiResponse<NluDomain> PatchLanguageunderstandingDomainWithHttpInfo (string domainId, NluDomain body);
        
        /// <summary>
        /// Create feedback for the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>NluFeedbackResponse</returns>
        NluFeedbackResponse PostLanguageunderstandingDomainFeedback (string domainId, NluFeedbackRequest body);

        /// <summary>
        /// Create feedback for the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>ApiResponse of NluFeedbackResponse</returns>
        ApiResponse<NluFeedbackResponse> PostLanguageunderstandingDomainFeedbackWithHttpInfo (string domainId, NluFeedbackRequest body);
        
        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>NluDetectionResponse</returns>
        NluDetectionResponse PostLanguageunderstandingDomainVersionDetect (string domainId, string domainVersionId, NluDetectionRequest body);

        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>ApiResponse of NluDetectionResponse</returns>
        ApiResponse<NluDetectionResponse> PostLanguageunderstandingDomainVersionDetectWithHttpInfo (string domainId, string domainVersionId, NluDetectionRequest body);
        
        /// <summary>
        /// Publish the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>NluDomainVersion</returns>
        NluDomainVersion PostLanguageunderstandingDomainVersionPublish (string domainId, string domainVersionId);

        /// <summary>
        /// Publish the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        ApiResponse<NluDomainVersion> PostLanguageunderstandingDomainVersionPublishWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Train the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>NluDomainVersionTrainingResponse</returns>
        NluDomainVersionTrainingResponse PostLanguageunderstandingDomainVersionTrain (string domainId, string domainVersionId);

        /// <summary>
        /// Train the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of NluDomainVersionTrainingResponse</returns>
        ApiResponse<NluDomainVersionTrainingResponse> PostLanguageunderstandingDomainVersionTrainWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Create an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>NluDomainVersion</returns>
        NluDomainVersion PostLanguageunderstandingDomainVersions (string domainId, NluDomainVersion body);

        /// <summary>
        /// Create an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        ApiResponse<NluDomainVersion> PostLanguageunderstandingDomainVersionsWithHttpInfo (string domainId, NluDomainVersion body);
        
        /// <summary>
        /// Create an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>NluDomain</returns>
        NluDomain PostLanguageunderstandingDomains (NluDomain body);

        /// <summary>
        /// Create an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>ApiResponse of NluDomain</returns>
        ApiResponse<NluDomain> PostLanguageunderstandingDomainsWithHttpInfo (NluDomain body);
        
        /// <summary>
        /// Update an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>NluDomainVersion</returns>
        NluDomainVersion PutLanguageunderstandingDomainVersion (string domainId, string domainVersionId, NluDomainVersion body);

        /// <summary>
        /// Update an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        ApiResponse<NluDomainVersion> PutLanguageunderstandingDomainVersionWithHttpInfo (string domainId, string domainVersionId, NluDomainVersion body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLanguageunderstandingDomainAsync (string domainId);

        /// <summary>
        /// Delete an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingDomainAsyncWithHttpInfo (string domainId);
        
        /// <summary>
        /// Delete the feedback on the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLanguageunderstandingDomainFeedbackFeedbackIdAsync (string domainId, string feedbackId);

        /// <summary>
        /// Delete the feedback on the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingDomainFeedbackFeedbackIdAsyncWithHttpInfo (string domainId, string feedbackId);
        
        /// <summary>
        /// Delete an NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLanguageunderstandingDomainVersionAsync (string domainId, string domainVersionId);

        /// <summary>
        /// Delete an NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingDomainVersionAsyncWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Find an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of NluDomain</returns>
        System.Threading.Tasks.Task<NluDomain> GetLanguageunderstandingDomainAsync (string domainId);

        /// <summary>
        /// Find an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of ApiResponse (NluDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomain>> GetLanguageunderstandingDomainAsyncWithHttpInfo (string domainId);
        
        /// <summary>
        /// Get all feedback in the given NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of NluFeedbackListing</returns>
        System.Threading.Tasks.Task<NluFeedbackListing> GetLanguageunderstandingDomainFeedbackAsync (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null);

        /// <summary>
        /// Get all feedback in the given NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (NluFeedbackListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluFeedbackListing>> GetLanguageunderstandingDomainFeedbackAsyncWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null);
        
        /// <summary>
        /// Find a Feedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of NluFeedbackResponse</returns>
        System.Threading.Tasks.Task<NluFeedbackResponse> GetLanguageunderstandingDomainFeedbackFeedbackIdAsync (string domainId, string feedbackId, List<string> fields = null);

        /// <summary>
        /// Find a Feedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (NluFeedbackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluFeedbackResponse>> GetLanguageunderstandingDomainFeedbackFeedbackIdAsyncWithHttpInfo (string domainId, string feedbackId, List<string> fields = null);
        
        /// <summary>
        /// Find an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of NluDomainVersion</returns>
        System.Threading.Tasks.Task<NluDomainVersion> GetLanguageunderstandingDomainVersionAsync (string domainId, string domainVersionId, bool? includeUtterances = null);

        /// <summary>
        /// Find an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> GetLanguageunderstandingDomainVersionAsyncWithHttpInfo (string domainId, string domainVersionId, bool? includeUtterances = null);
        
        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of NluDomainVersionQualityReport</returns>
        System.Threading.Tasks.Task<NluDomainVersionQualityReport> GetLanguageunderstandingDomainVersionReportAsync (string domainId, string domainVersionId);

        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersionQualityReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersionQualityReport>> GetLanguageunderstandingDomainVersionReportAsyncWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Get all NLU Domain Versions for a given Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of NluDomainVersionListing</returns>
        System.Threading.Tasks.Task<NluDomainVersionListing> GetLanguageunderstandingDomainVersionsAsync (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all NLU Domain Versions for a given Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (NluDomainVersionListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersionListing>> GetLanguageunderstandingDomainVersionsAsyncWithHttpInfo (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get all NLU Domains.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of NluDomainListing</returns>
        System.Threading.Tasks.Task<NluDomainListing> GetLanguageunderstandingDomainsAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all NLU Domains.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (NluDomainListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainListing>> GetLanguageunderstandingDomainsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Update an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>Task of NluDomain</returns>
        System.Threading.Tasks.Task<NluDomain> PatchLanguageunderstandingDomainAsync (string domainId, NluDomain body);

        /// <summary>
        /// Update an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>Task of ApiResponse (NluDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomain>> PatchLanguageunderstandingDomainAsyncWithHttpInfo (string domainId, NluDomain body);
        
        /// <summary>
        /// Create feedback for the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>Task of NluFeedbackResponse</returns>
        System.Threading.Tasks.Task<NluFeedbackResponse> PostLanguageunderstandingDomainFeedbackAsync (string domainId, NluFeedbackRequest body);

        /// <summary>
        /// Create feedback for the NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>Task of ApiResponse (NluFeedbackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluFeedbackResponse>> PostLanguageunderstandingDomainFeedbackAsyncWithHttpInfo (string domainId, NluFeedbackRequest body);
        
        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>Task of NluDetectionResponse</returns>
        System.Threading.Tasks.Task<NluDetectionResponse> PostLanguageunderstandingDomainVersionDetectAsync (string domainId, string domainVersionId, NluDetectionRequest body);

        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>Task of ApiResponse (NluDetectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDetectionResponse>> PostLanguageunderstandingDomainVersionDetectAsyncWithHttpInfo (string domainId, string domainVersionId, NluDetectionRequest body);
        
        /// <summary>
        /// Publish the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of NluDomainVersion</returns>
        System.Threading.Tasks.Task<NluDomainVersion> PostLanguageunderstandingDomainVersionPublishAsync (string domainId, string domainVersionId);

        /// <summary>
        /// Publish the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PostLanguageunderstandingDomainVersionPublishAsyncWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Train the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of NluDomainVersionTrainingResponse</returns>
        System.Threading.Tasks.Task<NluDomainVersionTrainingResponse> PostLanguageunderstandingDomainVersionTrainAsync (string domainId, string domainVersionId);

        /// <summary>
        /// Train the draft NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersionTrainingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersionTrainingResponse>> PostLanguageunderstandingDomainVersionTrainAsyncWithHttpInfo (string domainId, string domainVersionId);
        
        /// <summary>
        /// Create an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>Task of NluDomainVersion</returns>
        System.Threading.Tasks.Task<NluDomainVersion> PostLanguageunderstandingDomainVersionsAsync (string domainId, NluDomainVersion body);

        /// <summary>
        /// Create an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PostLanguageunderstandingDomainVersionsAsyncWithHttpInfo (string domainId, NluDomainVersion body);
        
        /// <summary>
        /// Create an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>Task of NluDomain</returns>
        System.Threading.Tasks.Task<NluDomain> PostLanguageunderstandingDomainsAsync (NluDomain body);

        /// <summary>
        /// Create an NLU Domain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>Task of ApiResponse (NluDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomain>> PostLanguageunderstandingDomainsAsyncWithHttpInfo (NluDomain body);
        
        /// <summary>
        /// Update an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>Task of NluDomainVersion</returns>
        System.Threading.Tasks.Task<NluDomainVersion> PutLanguageunderstandingDomainVersionAsync (string domainId, string domainVersionId, NluDomainVersion body);

        /// <summary>
        /// Update an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PutLanguageunderstandingDomainVersionAsyncWithHttpInfo (string domainId, string domainVersionId, NluDomainVersion body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LanguageUnderstandingApi : ILanguageUnderstandingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageUnderstandingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LanguageUnderstandingApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageUnderstandingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanguageUnderstandingApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns></returns>
        public void DeleteLanguageunderstandingDomain (string domainId)
        {
             DeleteLanguageunderstandingDomainWithHttpInfo(domainId);
        }

        /// <summary>
        /// Delete an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLanguageunderstandingDomainWithHttpInfo (string domainId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomain");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLanguageunderstandingDomainAsync (string domainId)
        {
             await DeleteLanguageunderstandingDomainAsyncWithHttpInfo(domainId);

        }

        /// <summary>
        /// Delete an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingDomainAsyncWithHttpInfo (string domainId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomain");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete the feedback on the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns></returns>
        public void DeleteLanguageunderstandingDomainFeedbackFeedbackId (string domainId, string feedbackId)
        {
             DeleteLanguageunderstandingDomainFeedbackFeedbackIdWithHttpInfo(domainId, feedbackId);
        }

        /// <summary>
        /// Delete the feedback on the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLanguageunderstandingDomainFeedbackFeedbackIdWithHttpInfo (string domainId, string feedbackId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainFeedbackFeedbackId");
            // verify the required parameter 'feedbackId' is set
            if (feedbackId == null)
                throw new ApiException(400, "Missing required parameter 'feedbackId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainFeedbackFeedbackId");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback/{feedbackId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (feedbackId != null) localVarPathParams.Add("feedbackId", this.Configuration.ApiClient.ParameterToString(feedbackId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete the feedback on the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLanguageunderstandingDomainFeedbackFeedbackIdAsync (string domainId, string feedbackId)
        {
             await DeleteLanguageunderstandingDomainFeedbackFeedbackIdAsyncWithHttpInfo(domainId, feedbackId);

        }

        /// <summary>
        /// Delete the feedback on the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingDomainFeedbackFeedbackIdAsyncWithHttpInfo (string domainId, string feedbackId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainFeedbackFeedbackId");
            
            // verify the required parameter 'feedbackId' is set
            if (feedbackId == null)
                throw new ApiException(400, "Missing required parameter 'feedbackId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainFeedbackFeedbackId");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback/{feedbackId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (feedbackId != null) localVarPathParams.Add("feedbackId", this.Configuration.ApiClient.ParameterToString(feedbackId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete an NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns></returns>
        public void DeleteLanguageunderstandingDomainVersion (string domainId, string domainVersionId)
        {
             DeleteLanguageunderstandingDomainVersionWithHttpInfo(domainId, domainVersionId);
        }

        /// <summary>
        /// Delete an NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLanguageunderstandingDomainVersionWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainVersion");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainVersion");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete an NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLanguageunderstandingDomainVersionAsync (string domainId, string domainVersionId)
        {
             await DeleteLanguageunderstandingDomainVersionAsyncWithHttpInfo(domainId, domainVersionId);

        }

        /// <summary>
        /// Delete an NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingDomainVersionAsyncWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainVersion");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingDomainVersion");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingDomainVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Find an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>NluDomain</returns>
        public NluDomain GetLanguageunderstandingDomain (string domainId)
        {
             ApiResponse<NluDomain> localVarResponse = GetLanguageunderstandingDomainWithHttpInfo(domainId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>ApiResponse of NluDomain</returns>
        public ApiResponse< NluDomain > GetLanguageunderstandingDomainWithHttpInfo (string domainId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomain");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomain>(localVarStatusCode,
                localVarHeaders,
                (NluDomain) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomain)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Find an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of NluDomain</returns>
        public async System.Threading.Tasks.Task<NluDomain> GetLanguageunderstandingDomainAsync (string domainId)
        {
             ApiResponse<NluDomain> localVarResponse = await GetLanguageunderstandingDomainAsyncWithHttpInfo(domainId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <returns>Task of ApiResponse (NluDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomain>> GetLanguageunderstandingDomainAsyncWithHttpInfo (string domainId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomain");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomain>(localVarStatusCode,
                localVarHeaders,
                (NluDomain) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomain)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get all feedback in the given NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>NluFeedbackListing</returns>
        public NluFeedbackListing GetLanguageunderstandingDomainFeedback (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null)
        {
             ApiResponse<NluFeedbackListing> localVarResponse = GetLanguageunderstandingDomainFeedbackWithHttpInfo(domainId, intentName, assessment, dateStart, dateEnd, includeDeleted, pageNumber, pageSize, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all feedback in the given NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of NluFeedbackListing</returns>
        public ApiResponse< NluFeedbackListing > GetLanguageunderstandingDomainFeedbackWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedback");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (intentName != null) localVarQueryParams.Add(new Tuple<string, string>("intentName", this.Configuration.ApiClient.ParameterToString(intentName)));
            if (assessment != null) localVarQueryParams.Add(new Tuple<string, string>("assessment", this.Configuration.ApiClient.ParameterToString(assessment)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (fields != null) fields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("fields", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluFeedbackListing>(localVarStatusCode,
                localVarHeaders,
                (NluFeedbackListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluFeedbackListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get all feedback in the given NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of NluFeedbackListing</returns>
        public async System.Threading.Tasks.Task<NluFeedbackListing> GetLanguageunderstandingDomainFeedbackAsync (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null)
        {
             ApiResponse<NluFeedbackListing> localVarResponse = await GetLanguageunderstandingDomainFeedbackAsyncWithHttpInfo(domainId, intentName, assessment, dateStart, dateEnd, includeDeleted, pageNumber, pageSize, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all feedback in the given NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (NluFeedbackListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluFeedbackListing>> GetLanguageunderstandingDomainFeedbackAsyncWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, List<string> fields = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedback");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (intentName != null) localVarQueryParams.Add(new Tuple<string, string>("intentName", this.Configuration.ApiClient.ParameterToString(intentName)));
            if (assessment != null) localVarQueryParams.Add(new Tuple<string, string>("assessment", this.Configuration.ApiClient.ParameterToString(assessment)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (fields != null) fields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("fields", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluFeedbackListing>(localVarStatusCode,
                localVarHeaders,
                (NluFeedbackListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluFeedbackListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Find a Feedback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>NluFeedbackResponse</returns>
        public NluFeedbackResponse GetLanguageunderstandingDomainFeedbackFeedbackId (string domainId, string feedbackId, List<string> fields = null)
        {
             ApiResponse<NluFeedbackResponse> localVarResponse = GetLanguageunderstandingDomainFeedbackFeedbackIdWithHttpInfo(domainId, feedbackId, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find a Feedback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of NluFeedbackResponse</returns>
        public ApiResponse< NluFeedbackResponse > GetLanguageunderstandingDomainFeedbackFeedbackIdWithHttpInfo (string domainId, string feedbackId, List<string> fields = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedbackFeedbackId");
            // verify the required parameter 'feedbackId' is set
            if (feedbackId == null)
                throw new ApiException(400, "Missing required parameter 'feedbackId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedbackFeedbackId");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback/{feedbackId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (feedbackId != null) localVarPathParams.Add("feedbackId", this.Configuration.ApiClient.ParameterToString(feedbackId));

            // Query params
            if (fields != null) fields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("fields", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluFeedbackResponse>(localVarStatusCode,
                localVarHeaders,
                (NluFeedbackResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluFeedbackResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Find a Feedback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of NluFeedbackResponse</returns>
        public async System.Threading.Tasks.Task<NluFeedbackResponse> GetLanguageunderstandingDomainFeedbackFeedbackIdAsync (string domainId, string feedbackId, List<string> fields = null)
        {
             ApiResponse<NluFeedbackResponse> localVarResponse = await GetLanguageunderstandingDomainFeedbackFeedbackIdAsyncWithHttpInfo(domainId, feedbackId, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find a Feedback 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="feedbackId">ID of the Feedback</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (NluFeedbackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluFeedbackResponse>> GetLanguageunderstandingDomainFeedbackFeedbackIdAsyncWithHttpInfo (string domainId, string feedbackId, List<string> fields = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedbackFeedbackId");
            
            // verify the required parameter 'feedbackId' is set
            if (feedbackId == null)
                throw new ApiException(400, "Missing required parameter 'feedbackId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedbackFeedbackId");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback/{feedbackId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (feedbackId != null) localVarPathParams.Add("feedbackId", this.Configuration.ApiClient.ParameterToString(feedbackId));

            // Query params
            if (fields != null) fields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("fields", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainFeedbackFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluFeedbackResponse>(localVarStatusCode,
                localVarHeaders,
                (NluFeedbackResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluFeedbackResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Find an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>NluDomainVersion</returns>
        public NluDomainVersion GetLanguageunderstandingDomainVersion (string domainId, string domainVersionId, bool? includeUtterances = null)
        {
             ApiResponse<NluDomainVersion> localVarResponse = GetLanguageunderstandingDomainVersionWithHttpInfo(domainId, domainVersionId, includeUtterances);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        public ApiResponse< NluDomainVersion > GetLanguageunderstandingDomainVersionWithHttpInfo (string domainId, string domainVersionId, bool? includeUtterances = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersion");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersion");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

            // Query params
            if (includeUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeUtterances", this.Configuration.ApiClient.ParameterToString(includeUtterances)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Find an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of NluDomainVersion</returns>
        public async System.Threading.Tasks.Task<NluDomainVersion> GetLanguageunderstandingDomainVersionAsync (string domainId, string domainVersionId, bool? includeUtterances = null)
        {
             ApiResponse<NluDomainVersion> localVarResponse = await GetLanguageunderstandingDomainVersionAsyncWithHttpInfo(domainId, domainVersionId, includeUtterances);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> GetLanguageunderstandingDomainVersionAsyncWithHttpInfo (string domainId, string domainVersionId, bool? includeUtterances = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersion");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersion");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

            // Query params
            if (includeUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeUtterances", this.Configuration.ApiClient.ParameterToString(includeUtterances)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>NluDomainVersionQualityReport</returns>
        public NluDomainVersionQualityReport GetLanguageunderstandingDomainVersionReport (string domainId, string domainVersionId)
        {
             ApiResponse<NluDomainVersionQualityReport> localVarResponse = GetLanguageunderstandingDomainVersionReportWithHttpInfo(domainId, domainVersionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of NluDomainVersionQualityReport</returns>
        public ApiResponse< NluDomainVersionQualityReport > GetLanguageunderstandingDomainVersionReportWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersionReport");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersionReport");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/report";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersionReport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersionReport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersionQualityReport>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersionQualityReport) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersionQualityReport)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of NluDomainVersionQualityReport</returns>
        public async System.Threading.Tasks.Task<NluDomainVersionQualityReport> GetLanguageunderstandingDomainVersionReportAsync (string domainId, string domainVersionId)
        {
             ApiResponse<NluDomainVersionQualityReport> localVarResponse = await GetLanguageunderstandingDomainVersionReportAsyncWithHttpInfo(domainId, domainVersionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieved quality report for the specified NLU Domain Version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersionQualityReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersionQualityReport>> GetLanguageunderstandingDomainVersionReportAsyncWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersionReport");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersionReport");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/report";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersionReport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersionReport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersionQualityReport>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersionQualityReport) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersionQualityReport)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get all NLU Domain Versions for a given Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>NluDomainVersionListing</returns>
        public NluDomainVersionListing GetLanguageunderstandingDomainVersions (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<NluDomainVersionListing> localVarResponse = GetLanguageunderstandingDomainVersionsWithHttpInfo(domainId, includeUtterances, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all NLU Domain Versions for a given Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of NluDomainVersionListing</returns>
        public ApiResponse< NluDomainVersionListing > GetLanguageunderstandingDomainVersionsWithHttpInfo (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersions");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (includeUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeUtterances", this.Configuration.ApiClient.ParameterToString(includeUtterances)));
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersionListing>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get all NLU Domain Versions for a given Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of NluDomainVersionListing</returns>
        public async System.Threading.Tasks.Task<NluDomainVersionListing> GetLanguageunderstandingDomainVersionsAsync (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<NluDomainVersionListing> localVarResponse = await GetLanguageunderstandingDomainVersionsAsyncWithHttpInfo(domainId, includeUtterances, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all NLU Domain Versions for a given Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (NluDomainVersionListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersionListing>> GetLanguageunderstandingDomainVersionsAsyncWithHttpInfo (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainVersions");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (includeUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeUtterances", this.Configuration.ApiClient.ParameterToString(includeUtterances)));
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomainVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersionListing>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get all NLU Domains. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>NluDomainListing</returns>
        public NluDomainListing GetLanguageunderstandingDomains (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<NluDomainListing> localVarResponse = GetLanguageunderstandingDomainsWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all NLU Domains. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of NluDomainListing</returns>
        public ApiResponse< NluDomainListing > GetLanguageunderstandingDomainsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/languageunderstanding/domains";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomains: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainListing>(localVarStatusCode,
                localVarHeaders,
                (NluDomainListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get all NLU Domains. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of NluDomainListing</returns>
        public async System.Threading.Tasks.Task<NluDomainListing> GetLanguageunderstandingDomainsAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<NluDomainListing> localVarResponse = await GetLanguageunderstandingDomainsAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all NLU Domains. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (NluDomainListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainListing>> GetLanguageunderstandingDomainsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/languageunderstanding/domains";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomains: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainListing>(localVarStatusCode,
                localVarHeaders,
                (NluDomainListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>NluDomain</returns>
        public NluDomain PatchLanguageunderstandingDomain (string domainId, NluDomain body)
        {
             ApiResponse<NluDomain> localVarResponse = PatchLanguageunderstandingDomainWithHttpInfo(domainId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>ApiResponse of NluDomain</returns>
        public ApiResponse< NluDomain > PatchLanguageunderstandingDomainWithHttpInfo (string domainId, NluDomain body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PatchLanguageunderstandingDomain");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PatchLanguageunderstandingDomain");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingDomain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingDomain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomain>(localVarStatusCode,
                localVarHeaders,
                (NluDomain) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomain)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>Task of NluDomain</returns>
        public async System.Threading.Tasks.Task<NluDomain> PatchLanguageunderstandingDomainAsync (string domainId, NluDomain body)
        {
             ApiResponse<NluDomain> localVarResponse = await PatchLanguageunderstandingDomainAsyncWithHttpInfo(domainId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The updated NLU Domain.</param>
        /// <returns>Task of ApiResponse (NluDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomain>> PatchLanguageunderstandingDomainAsyncWithHttpInfo (string domainId, NluDomain body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PatchLanguageunderstandingDomain");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PatchLanguageunderstandingDomain");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingDomain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingDomain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomain>(localVarStatusCode,
                localVarHeaders,
                (NluDomain) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomain)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create feedback for the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>NluFeedbackResponse</returns>
        public NluFeedbackResponse PostLanguageunderstandingDomainFeedback (string domainId, NluFeedbackRequest body)
        {
             ApiResponse<NluFeedbackResponse> localVarResponse = PostLanguageunderstandingDomainFeedbackWithHttpInfo(domainId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create feedback for the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>ApiResponse of NluFeedbackResponse</returns>
        public ApiResponse< NluFeedbackResponse > PostLanguageunderstandingDomainFeedbackWithHttpInfo (string domainId, NluFeedbackRequest body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainFeedback");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainFeedback");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainFeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainFeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluFeedbackResponse>(localVarStatusCode,
                localVarHeaders,
                (NluFeedbackResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluFeedbackResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create feedback for the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>Task of NluFeedbackResponse</returns>
        public async System.Threading.Tasks.Task<NluFeedbackResponse> PostLanguageunderstandingDomainFeedbackAsync (string domainId, NluFeedbackRequest body)
        {
             ApiResponse<NluFeedbackResponse> localVarResponse = await PostLanguageunderstandingDomainFeedbackAsyncWithHttpInfo(domainId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create feedback for the NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The Feedback to create.</param>
        /// <returns>Task of ApiResponse (NluFeedbackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluFeedbackResponse>> PostLanguageunderstandingDomainFeedbackAsyncWithHttpInfo (string domainId, NluFeedbackRequest body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainFeedback");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainFeedback");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainFeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainFeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluFeedbackResponse>(localVarStatusCode,
                localVarHeaders,
                (NluFeedbackResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluFeedbackResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>NluDetectionResponse</returns>
        public NluDetectionResponse PostLanguageunderstandingDomainVersionDetect (string domainId, string domainVersionId, NluDetectionRequest body)
        {
             ApiResponse<NluDetectionResponse> localVarResponse = PostLanguageunderstandingDomainVersionDetectWithHttpInfo(domainId, domainVersionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>ApiResponse of NluDetectionResponse</returns>
        public ApiResponse< NluDetectionResponse > PostLanguageunderstandingDomainVersionDetectWithHttpInfo (string domainId, string domainVersionId, NluDetectionRequest body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionDetect");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionDetect");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionDetect");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/detect";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionDetect: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionDetect: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDetectionResponse>(localVarStatusCode,
                localVarHeaders,
                (NluDetectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDetectionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>Task of NluDetectionResponse</returns>
        public async System.Threading.Tasks.Task<NluDetectionResponse> PostLanguageunderstandingDomainVersionDetectAsync (string domainId, string domainVersionId, NluDetectionRequest body)
        {
             ApiResponse<NluDetectionResponse> localVarResponse = await PostLanguageunderstandingDomainVersionDetectAsyncWithHttpInfo(domainId, domainVersionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detect intent, entities, etc. in the submitted text using the specified NLU domain version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The input data to perform detection on.</param>
        /// <returns>Task of ApiResponse (NluDetectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDetectionResponse>> PostLanguageunderstandingDomainVersionDetectAsyncWithHttpInfo (string domainId, string domainVersionId, NluDetectionRequest body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionDetect");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionDetect");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionDetect");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/detect";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionDetect: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionDetect: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDetectionResponse>(localVarStatusCode,
                localVarHeaders,
                (NluDetectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDetectionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Publish the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>NluDomainVersion</returns>
        public NluDomainVersion PostLanguageunderstandingDomainVersionPublish (string domainId, string domainVersionId)
        {
             ApiResponse<NluDomainVersion> localVarResponse = PostLanguageunderstandingDomainVersionPublishWithHttpInfo(domainId, domainVersionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        public ApiResponse< NluDomainVersion > PostLanguageunderstandingDomainVersionPublishWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionPublish");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionPublish");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/publish";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Publish the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of NluDomainVersion</returns>
        public async System.Threading.Tasks.Task<NluDomainVersion> PostLanguageunderstandingDomainVersionPublishAsync (string domainId, string domainVersionId)
        {
             ApiResponse<NluDomainVersion> localVarResponse = await PostLanguageunderstandingDomainVersionPublishAsyncWithHttpInfo(domainId, domainVersionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PostLanguageunderstandingDomainVersionPublishAsyncWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionPublish");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionPublish");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/publish";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Train the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>NluDomainVersionTrainingResponse</returns>
        public NluDomainVersionTrainingResponse PostLanguageunderstandingDomainVersionTrain (string domainId, string domainVersionId)
        {
             ApiResponse<NluDomainVersionTrainingResponse> localVarResponse = PostLanguageunderstandingDomainVersionTrainWithHttpInfo(domainId, domainVersionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Train the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>ApiResponse of NluDomainVersionTrainingResponse</returns>
        public ApiResponse< NluDomainVersionTrainingResponse > PostLanguageunderstandingDomainVersionTrainWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionTrain");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionTrain");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/train";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionTrain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionTrain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersionTrainingResponse>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersionTrainingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersionTrainingResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Train the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of NluDomainVersionTrainingResponse</returns>
        public async System.Threading.Tasks.Task<NluDomainVersionTrainingResponse> PostLanguageunderstandingDomainVersionTrainAsync (string domainId, string domainVersionId)
        {
             ApiResponse<NluDomainVersionTrainingResponse> localVarResponse = await PostLanguageunderstandingDomainVersionTrainAsyncWithHttpInfo(domainId, domainVersionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Train the draft NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersionTrainingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersionTrainingResponse>> PostLanguageunderstandingDomainVersionTrainAsyncWithHttpInfo (string domainId, string domainVersionId)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionTrain");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersionTrain");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/train";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionTrain: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersionTrain: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersionTrainingResponse>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersionTrainingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersionTrainingResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>NluDomainVersion</returns>
        public NluDomainVersion PostLanguageunderstandingDomainVersions (string domainId, NluDomainVersion body)
        {
             ApiResponse<NluDomainVersion> localVarResponse = PostLanguageunderstandingDomainVersionsWithHttpInfo(domainId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        public ApiResponse< NluDomainVersion > PostLanguageunderstandingDomainVersionsWithHttpInfo (string domainId, NluDomainVersion body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>Task of NluDomainVersion</returns>
        public async System.Threading.Tasks.Task<NluDomainVersion> PostLanguageunderstandingDomainVersionsAsync (string domainId, NluDomainVersion body)
        {
             ApiResponse<NluDomainVersion> localVarResponse = await PostLanguageunderstandingDomainVersionsAsyncWithHttpInfo(domainId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PostLanguageunderstandingDomainVersionsAsyncWithHttpInfo (string domainId, NluDomainVersion body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomainVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>NluDomain</returns>
        public NluDomain PostLanguageunderstandingDomains (NluDomain body)
        {
             ApiResponse<NluDomain> localVarResponse = PostLanguageunderstandingDomainsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>ApiResponse of NluDomain</returns>
        public ApiResponse< NluDomain > PostLanguageunderstandingDomainsWithHttpInfo (NluDomain body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomains");

            var localVarPath = "/api/v2/languageunderstanding/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomains: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomain>(localVarStatusCode,
                localVarHeaders,
                (NluDomain) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomain)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>Task of NluDomain</returns>
        public async System.Threading.Tasks.Task<NluDomain> PostLanguageunderstandingDomainsAsync (NluDomain body)
        {
             ApiResponse<NluDomain> localVarResponse = await PostLanguageunderstandingDomainsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an NLU Domain. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The NLU Domain to create.</param>
        /// <returns>Task of ApiResponse (NluDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomain>> PostLanguageunderstandingDomainsAsyncWithHttpInfo (NluDomain body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomains");
            

            var localVarPath = "/api/v2/languageunderstanding/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomains: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomain>(localVarStatusCode,
                localVarHeaders,
                (NluDomain) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomain)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>NluDomainVersion</returns>
        public NluDomainVersion PutLanguageunderstandingDomainVersion (string domainId, string domainVersionId, NluDomainVersion body)
        {
             ApiResponse<NluDomainVersion> localVarResponse = PutLanguageunderstandingDomainVersionWithHttpInfo(domainId, domainVersionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        public ApiResponse< NluDomainVersion > PutLanguageunderstandingDomainVersionWithHttpInfo (string domainId, string domainVersionId, NluDomainVersion body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PutLanguageunderstandingDomainVersion");
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PutLanguageunderstandingDomainVersion");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PutLanguageunderstandingDomainVersion");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutLanguageunderstandingDomainVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLanguageunderstandingDomainVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>Task of NluDomainVersion</returns>
        public async System.Threading.Tasks.Task<NluDomainVersion> PutLanguageunderstandingDomainVersionAsync (string domainId, string domainVersionId, NluDomainVersion body)
        {
             ApiResponse<NluDomainVersion> localVarResponse = await PutLanguageunderstandingDomainVersionAsyncWithHttpInfo(domainId, domainVersionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an NLU Domain Version. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="domainVersionId">ID of the NLU domain version.</param>
        /// <param name="body">The updated NLU Domain Version.</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PutLanguageunderstandingDomainVersionAsyncWithHttpInfo (string domainId, string domainVersionId, NluDomainVersion body)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PutLanguageunderstandingDomainVersion");
            
            // verify the required parameter 'domainVersionId' is set
            if (domainVersionId == null)
                throw new ApiException(400, "Missing required parameter 'domainVersionId' when calling LanguageUnderstandingApi->PutLanguageunderstandingDomainVersion");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PutLanguageunderstandingDomainVersion");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));
            if (domainVersionId != null) localVarPathParams.Add("domainVersionId", this.Configuration.ApiClient.ParameterToString(domainVersionId));

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutLanguageunderstandingDomainVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLanguageunderstandingDomainVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluDomainVersion>(localVarStatusCode,
                localVarHeaders,
                (NluDomainVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluDomainVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
