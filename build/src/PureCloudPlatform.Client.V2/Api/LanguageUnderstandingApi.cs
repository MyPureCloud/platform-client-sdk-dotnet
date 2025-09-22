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
        /// Delete a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns></returns>
        
        void DeleteLanguageunderstandingMiner (string minerId);

        /// <summary>
        /// Delete a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteLanguageunderstandingMinerWithHttpInfo (string minerId);

        /// <summary>
        /// Delete a draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns></returns>
        
        void DeleteLanguageunderstandingMinerDraft (string minerId, string draftId);

        /// <summary>
        /// Delete a draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteLanguageunderstandingMinerDraftWithHttpInfo (string minerId, string draftId);

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
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>NluFeedbackListing</returns>
        
        NluFeedbackListing GetLanguageunderstandingDomainFeedback (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null);

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
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of NluFeedbackListing</returns>
        
        ApiResponse<NluFeedbackListing> GetLanguageunderstandingDomainFeedbackWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null);

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
        /// Get list of all ignored phrases of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>IgnoredMinedPhraseListing</returns>
        
        IgnoredMinedPhraseListing GetLanguageunderstandingIgnorephrase (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get list of all ignored phrases of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>ApiResponse of IgnoredMinedPhraseListing</returns>
        
        ApiResponse<IgnoredMinedPhraseListing> GetLanguageunderstandingIgnorephraseWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get list of all ignored topics of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>IgnoredMinedTopicListing</returns>
        
        IgnoredMinedTopicListing GetLanguageunderstandingIgnoretopic (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get list of all ignored topics of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>ApiResponse of IgnoredMinedTopicListing</returns>
        
        ApiResponse<IgnoredMinedTopicListing> GetLanguageunderstandingIgnoretopicWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get information about a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Miner</returns>
        
        Miner GetLanguageunderstandingMiner (string minerId);

        /// <summary>
        /// Get information about a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of Miner</returns>
        
        ApiResponse<Miner> GetLanguageunderstandingMinerWithHttpInfo (string minerId);

        /// <summary>
        /// Get information about a draft.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>Draft</returns>
        
        Draft GetLanguageunderstandingMinerDraft (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null);

        /// <summary>
        /// Get information about a draft.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>ApiResponse of Draft</returns>
        
        ApiResponse<Draft> GetLanguageunderstandingMinerDraftWithHttpInfo (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null);

        /// <summary>
        /// Retrieve the list of drafts created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>DraftListing</returns>
        
        DraftListing GetLanguageunderstandingMinerDrafts (string minerId);

        /// <summary>
        /// Retrieve the list of drafts created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of DraftListing</returns>
        
        ApiResponse<DraftListing> GetLanguageunderstandingMinerDraftsWithHttpInfo (string minerId);

        /// <summary>
        /// Get information about a mined intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>MinerIntent</returns>
        
        MinerIntent GetLanguageunderstandingMinerIntent (string minerId, string intentId, string expand = null);

        /// <summary>
        /// Get information about a mined intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>ApiResponse of MinerIntent</returns>
        
        ApiResponse<MinerIntent> GetLanguageunderstandingMinerIntentWithHttpInfo (string minerId, string intentId, string expand = null);

        /// <summary>
        /// Retrieve a list of mined intents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>MinedIntentsListing</returns>
        
        MinedIntentsListing GetLanguageunderstandingMinerIntents (string minerId, string expand = null);

        /// <summary>
        /// Retrieve a list of mined intents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>ApiResponse of MinedIntentsListing</returns>
        
        ApiResponse<MinedIntentsListing> GetLanguageunderstandingMinerIntentsWithHttpInfo (string minerId, string expand = null);

        /// <summary>
        /// Retrieves details of a particular topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>MinerTopic</returns>
        
        MinerTopic GetLanguageunderstandingMinerTopic (string minerId, string topicId, string expand = null);

        /// <summary>
        /// Retrieves details of a particular topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>ApiResponse of MinerTopic</returns>
        
        ApiResponse<MinerTopic> GetLanguageunderstandingMinerTopicWithHttpInfo (string minerId, string topicId, string expand = null);

        /// <summary>
        /// Retrieves utterances related to a phrase in a topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>MinerTopicPhrase</returns>
        
        MinerTopicPhrase GetLanguageunderstandingMinerTopicPhrase (string minerId, string topicId, string phraseId);

        /// <summary>
        /// Retrieves utterances related to a phrase in a topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>ApiResponse of MinerTopicPhrase</returns>
        
        ApiResponse<MinerTopicPhrase> GetLanguageunderstandingMinerTopicPhraseWithHttpInfo (string minerId, string topicId, string phraseId);

        /// <summary>
        /// Retrieve a list of mined topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>MinerTopicsListing</returns>
        
        MinerTopicsListing GetLanguageunderstandingMinerTopics (string minerId);

        /// <summary>
        /// Retrieve a list of mined topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of MinerTopicsListing</returns>
        
        ApiResponse<MinerTopicsListing> GetLanguageunderstandingMinerTopicsWithHttpInfo (string minerId);

        /// <summary>
        /// Retrieve the list of miners created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>MinerListing</returns>
        
        MinerListing GetLanguageunderstandingMiners (string minerType = null);

        /// <summary>
        /// Retrieve the list of miners created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>ApiResponse of MinerListing</returns>
        
        ApiResponse<MinerListing> GetLanguageunderstandingMinersWithHttpInfo (string minerType = null);

        /// <summary>
        /// Get Organization Configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>NluOrganization</returns>
        
        NluOrganization GetLanguageunderstandingSettings ();

        /// <summary>
        /// Get Organization Configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of NluOrganization</returns>
        
        ApiResponse<NluOrganization> GetLanguageunderstandingSettingsWithHttpInfo ();

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
        /// Save information for the draft. Either topic draft or intent draft should be sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Draft</returns>
        
        Draft PatchLanguageunderstandingMinerDraft (string minerId, string draftId, DraftRequest body = null);

        /// <summary>
        /// Save information for the draft. Either topic draft or intent draft should be sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Draft</returns>
        
        ApiResponse<Draft> PatchLanguageunderstandingMinerDraftWithHttpInfo (string minerId, string draftId, DraftRequest body = null);

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
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>NluDomainVersion</returns>
        
        NluDomainVersion PostLanguageunderstandingDomainVersions (string domainId, NluDomainVersion body, bool? includeUtterances = null);

        /// <summary>
        /// Create an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        
        ApiResponse<NluDomainVersion> PostLanguageunderstandingDomainVersionsWithHttpInfo (string domainId, NluDomainVersion body, bool? includeUtterances = null);

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
        /// Add phrases to the ignored phrases list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>IgnorePhrasesResponse</returns>
        
        IgnorePhrasesResponse PostLanguageunderstandingIgnorephrase (string languageCode, IgnorePhrasesRequest body);

        /// <summary>
        /// Add phrases to the ignored phrases list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>ApiResponse of IgnorePhrasesResponse</returns>
        
        ApiResponse<IgnorePhrasesResponse> PostLanguageunderstandingIgnorephraseWithHttpInfo (string languageCode, IgnorePhrasesRequest body);

        /// <summary>
        /// Delete ignored phrases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns></returns>
        
        void PostLanguageunderstandingIgnorephraseRemove (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Delete ignored phrases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostLanguageunderstandingIgnorephraseRemoveWithHttpInfo (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Add topics to the ignored topics list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>IgnoreTopicsResponse</returns>
        
        IgnoreTopicsResponse PostLanguageunderstandingIgnoretopic (string languageCode, IgnoreTopicsRequest body);

        /// <summary>
        /// Add topics to the ignored topics list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>ApiResponse of IgnoreTopicsResponse</returns>
        
        ApiResponse<IgnoreTopicsResponse> PostLanguageunderstandingIgnoretopicWithHttpInfo (string languageCode, IgnoreTopicsRequest body);

        /// <summary>
        /// Delete ignored topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns></returns>
        
        void PostLanguageunderstandingIgnoretopicRemove (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Delete ignored topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostLanguageunderstandingIgnoretopicRemoveWithHttpInfo (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Create a new draft resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>Draft</returns>
        
        Draft PostLanguageunderstandingMinerDrafts (string minerId, Draft body);

        /// <summary>
        /// Create a new draft resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>ApiResponse of Draft</returns>
        
        ApiResponse<Draft> PostLanguageunderstandingMinerDraftsWithHttpInfo (string minerId, Draft body);

        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Miner</returns>
        
        Miner PostLanguageunderstandingMinerExecute (string minerId, MinerExecuteRequest body = null);

        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Miner</returns>
        
        ApiResponse<Miner> PostLanguageunderstandingMinerExecuteWithHttpInfo (string minerId, MinerExecuteRequest body = null);

        /// <summary>
        /// Create a unique miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>Miner</returns>
        
        Miner PostLanguageunderstandingMiners (Miner body);

        /// <summary>
        /// Create a unique miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>ApiResponse of Miner</returns>
        
        ApiResponse<Miner> PostLanguageunderstandingMinersWithHttpInfo (Miner body);

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
        /// Delete a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteLanguageunderstandingMinerAsync (string minerId);

        /// <summary>
        /// Delete a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingMinerAsyncWithHttpInfo (string minerId);

        /// <summary>
        /// Delete a draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteLanguageunderstandingMinerDraftAsync (string minerId, string draftId);

        /// <summary>
        /// Delete a draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingMinerDraftAsyncWithHttpInfo (string minerId, string draftId);

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
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of NluFeedbackListing</returns>
        
        System.Threading.Tasks.Task<NluFeedbackListing> GetLanguageunderstandingDomainFeedbackAsync (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null);

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
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (NluFeedbackListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<NluFeedbackListing>> GetLanguageunderstandingDomainFeedbackAsyncWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null);

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
        /// Get list of all ignored phrases of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of IgnoredMinedPhraseListing</returns>
        
        System.Threading.Tasks.Task<IgnoredMinedPhraseListing> GetLanguageunderstandingIgnorephraseAsync (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get list of all ignored phrases of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of ApiResponse (IgnoredMinedPhraseListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IgnoredMinedPhraseListing>> GetLanguageunderstandingIgnorephraseAsyncWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get list of all ignored topics of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of IgnoredMinedTopicListing</returns>
        
        System.Threading.Tasks.Task<IgnoredMinedTopicListing> GetLanguageunderstandingIgnoretopicAsync (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get list of all ignored topics of the specified language code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of ApiResponse (IgnoredMinedTopicListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IgnoredMinedTopicListing>> GetLanguageunderstandingIgnoretopicAsyncWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get information about a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of Miner</returns>
        
        System.Threading.Tasks.Task<Miner> GetLanguageunderstandingMinerAsync (string minerId);

        /// <summary>
        /// Get information about a miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse (Miner)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Miner>> GetLanguageunderstandingMinerAsyncWithHttpInfo (string minerId);

        /// <summary>
        /// Get information about a draft.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>Task of Draft</returns>
        
        System.Threading.Tasks.Task<Draft> GetLanguageunderstandingMinerDraftAsync (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null);

        /// <summary>
        /// Get information about a draft.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>Task of ApiResponse (Draft)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Draft>> GetLanguageunderstandingMinerDraftAsyncWithHttpInfo (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null);

        /// <summary>
        /// Retrieve the list of drafts created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of DraftListing</returns>
        
        System.Threading.Tasks.Task<DraftListing> GetLanguageunderstandingMinerDraftsAsync (string minerId);

        /// <summary>
        /// Retrieve the list of drafts created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse (DraftListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DraftListing>> GetLanguageunderstandingMinerDraftsAsyncWithHttpInfo (string minerId);

        /// <summary>
        /// Get information about a mined intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>Task of MinerIntent</returns>
        
        System.Threading.Tasks.Task<MinerIntent> GetLanguageunderstandingMinerIntentAsync (string minerId, string intentId, string expand = null);

        /// <summary>
        /// Get information about a mined intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>Task of ApiResponse (MinerIntent)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MinerIntent>> GetLanguageunderstandingMinerIntentAsyncWithHttpInfo (string minerId, string intentId, string expand = null);

        /// <summary>
        /// Retrieve a list of mined intents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>Task of MinedIntentsListing</returns>
        
        System.Threading.Tasks.Task<MinedIntentsListing> GetLanguageunderstandingMinerIntentsAsync (string minerId, string expand = null);

        /// <summary>
        /// Retrieve a list of mined intents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>Task of ApiResponse (MinedIntentsListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MinedIntentsListing>> GetLanguageunderstandingMinerIntentsAsyncWithHttpInfo (string minerId, string expand = null);

        /// <summary>
        /// Retrieves details of a particular topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>Task of MinerTopic</returns>
        
        System.Threading.Tasks.Task<MinerTopic> GetLanguageunderstandingMinerTopicAsync (string minerId, string topicId, string expand = null);

        /// <summary>
        /// Retrieves details of a particular topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>Task of ApiResponse (MinerTopic)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MinerTopic>> GetLanguageunderstandingMinerTopicAsyncWithHttpInfo (string minerId, string topicId, string expand = null);

        /// <summary>
        /// Retrieves utterances related to a phrase in a topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>Task of MinerTopicPhrase</returns>
        
        System.Threading.Tasks.Task<MinerTopicPhrase> GetLanguageunderstandingMinerTopicPhraseAsync (string minerId, string topicId, string phraseId);

        /// <summary>
        /// Retrieves utterances related to a phrase in a topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>Task of ApiResponse (MinerTopicPhrase)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MinerTopicPhrase>> GetLanguageunderstandingMinerTopicPhraseAsyncWithHttpInfo (string minerId, string topicId, string phraseId);

        /// <summary>
        /// Retrieve a list of mined topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of MinerTopicsListing</returns>
        
        System.Threading.Tasks.Task<MinerTopicsListing> GetLanguageunderstandingMinerTopicsAsync (string minerId);

        /// <summary>
        /// Retrieve a list of mined topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse (MinerTopicsListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MinerTopicsListing>> GetLanguageunderstandingMinerTopicsAsyncWithHttpInfo (string minerId);

        /// <summary>
        /// Retrieve the list of miners created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>Task of MinerListing</returns>
        
        System.Threading.Tasks.Task<MinerListing> GetLanguageunderstandingMinersAsync (string minerType = null);

        /// <summary>
        /// Retrieve the list of miners created.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>Task of ApiResponse (MinerListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MinerListing>> GetLanguageunderstandingMinersAsyncWithHttpInfo (string minerType = null);

        /// <summary>
        /// Get Organization Configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NluOrganization</returns>
        
        System.Threading.Tasks.Task<NluOrganization> GetLanguageunderstandingSettingsAsync ();

        /// <summary>
        /// Get Organization Configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NluOrganization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<NluOrganization>> GetLanguageunderstandingSettingsAsyncWithHttpInfo ();

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
        /// Save information for the draft. Either topic draft or intent draft should be sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Draft</returns>
        
        System.Threading.Tasks.Task<Draft> PatchLanguageunderstandingMinerDraftAsync (string minerId, string draftId, DraftRequest body = null);

        /// <summary>
        /// Save information for the draft. Either topic draft or intent draft should be sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Draft)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Draft>> PatchLanguageunderstandingMinerDraftAsyncWithHttpInfo (string minerId, string draftId, DraftRequest body = null);

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
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of NluDomainVersion</returns>
        
        System.Threading.Tasks.Task<NluDomainVersion> PostLanguageunderstandingDomainVersionsAsync (string domainId, NluDomainVersion body, bool? includeUtterances = null);

        /// <summary>
        /// Create an NLU Domain Version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PostLanguageunderstandingDomainVersionsAsyncWithHttpInfo (string domainId, NluDomainVersion body, bool? includeUtterances = null);

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
        /// Add phrases to the ignored phrases list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>Task of IgnorePhrasesResponse</returns>
        
        System.Threading.Tasks.Task<IgnorePhrasesResponse> PostLanguageunderstandingIgnorephraseAsync (string languageCode, IgnorePhrasesRequest body);

        /// <summary>
        /// Add phrases to the ignored phrases list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>Task of ApiResponse (IgnorePhrasesResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IgnorePhrasesResponse>> PostLanguageunderstandingIgnorephraseAsyncWithHttpInfo (string languageCode, IgnorePhrasesRequest body);

        /// <summary>
        /// Delete ignored phrases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostLanguageunderstandingIgnorephraseRemoveAsync (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Delete ignored phrases
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostLanguageunderstandingIgnorephraseRemoveAsyncWithHttpInfo (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Add topics to the ignored topics list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>Task of IgnoreTopicsResponse</returns>
        
        System.Threading.Tasks.Task<IgnoreTopicsResponse> PostLanguageunderstandingIgnoretopicAsync (string languageCode, IgnoreTopicsRequest body);

        /// <summary>
        /// Add topics to the ignored topics list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>Task of ApiResponse (IgnoreTopicsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IgnoreTopicsResponse>> PostLanguageunderstandingIgnoretopicAsyncWithHttpInfo (string languageCode, IgnoreTopicsRequest body);

        /// <summary>
        /// Delete ignored topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostLanguageunderstandingIgnoretopicRemoveAsync (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Delete ignored topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostLanguageunderstandingIgnoretopicRemoveAsyncWithHttpInfo (string languageCode, RemoveEntitiesRequest body);

        /// <summary>
        /// Create a new draft resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>Task of Draft</returns>
        
        System.Threading.Tasks.Task<Draft> PostLanguageunderstandingMinerDraftsAsync (string minerId, Draft body);

        /// <summary>
        /// Create a new draft resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>Task of ApiResponse (Draft)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Draft>> PostLanguageunderstandingMinerDraftsAsyncWithHttpInfo (string minerId, Draft body);

        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Miner</returns>
        
        System.Threading.Tasks.Task<Miner> PostLanguageunderstandingMinerExecuteAsync (string minerId, MinerExecuteRequest body = null);

        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Miner)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Miner>> PostLanguageunderstandingMinerExecuteAsyncWithHttpInfo (string minerId, MinerExecuteRequest body = null);

        /// <summary>
        /// Create a unique miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>Task of Miner</returns>
        
        System.Threading.Tasks.Task<Miner> PostLanguageunderstandingMinersAsync (Miner body);

        /// <summary>
        /// Create a unique miner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>Task of ApiResponse (Miner)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Miner>> PostLanguageunderstandingMinersAsyncWithHttpInfo (Miner body);

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
        /// Delete an NLU Domain. 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Delete a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns></returns>
        
        public void DeleteLanguageunderstandingMiner (string minerId)
        {
             DeleteLanguageunderstandingMinerWithHttpInfo(minerId);
        }

        /// <summary>
        /// Delete a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteLanguageunderstandingMinerWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingMiner");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMiner: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMiner: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteLanguageunderstandingMinerAsync (string minerId)
        {
             await DeleteLanguageunderstandingMinerAsyncWithHttpInfo(minerId);

        }

        /// <summary>
        /// Delete a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingMinerAsyncWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingMiner");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMiner: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMiner: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns></returns>
        
        public void DeleteLanguageunderstandingMinerDraft (string minerId, string draftId)
        {
             DeleteLanguageunderstandingMinerDraftWithHttpInfo(minerId, draftId);
        }

        /// <summary>
        /// Delete a draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteLanguageunderstandingMinerDraftWithHttpInfo (string minerId, string draftId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingMinerDraft");
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new ApiException(400, "Missing required parameter 'draftId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingMinerDraft");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (draftId != null) localVarPathParams.Add("draftId", this.Configuration.ApiClient.ParameterToString(draftId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMinerDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMinerDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteLanguageunderstandingMinerDraftAsync (string minerId, string draftId)
        {
             await DeleteLanguageunderstandingMinerDraftAsyncWithHttpInfo(minerId, draftId);

        }

        /// <summary>
        /// Delete a draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageunderstandingMinerDraftAsyncWithHttpInfo (string minerId, string draftId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingMinerDraft");
            
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new ApiException(400, "Missing required parameter 'draftId' when calling LanguageUnderstandingApi->DeleteLanguageunderstandingMinerDraft");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (draftId != null) localVarPathParams.Add("draftId", this.Configuration.ApiClient.ParameterToString(draftId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMinerDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguageunderstandingMinerDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Find an NLU Domain. 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>NluFeedbackListing</returns>
        
        public NluFeedbackListing GetLanguageunderstandingDomainFeedback (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null)
        {
             ApiResponse<NluFeedbackListing> localVarResponse = GetLanguageunderstandingDomainFeedbackWithHttpInfo(domainId, intentName, assessment, dateStart, dateEnd, includeDeleted, language, pageNumber, pageSize, enableCursorPagination, includeTrainingUtterances, after, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all feedback in the given NLU Domain Version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of NluFeedbackListing</returns>
        
        public ApiResponse< NluFeedbackListing > GetLanguageunderstandingDomainFeedbackWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedback");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (intentName != null) localVarQueryParams.Add(new Tuple<string, string>("intentName", this.Configuration.ApiClient.ParameterToString(intentName)));
            if (assessment != null) localVarQueryParams.Add(new Tuple<string, string>("assessment", this.Configuration.ApiClient.ParameterToString(assessment)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (enableCursorPagination != null) localVarQueryParams.Add(new Tuple<string, string>("enableCursorPagination", this.Configuration.ApiClient.ParameterToString(enableCursorPagination)));
            if (includeTrainingUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrainingUtterances", this.Configuration.ApiClient.ParameterToString(includeTrainingUtterances)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of NluFeedbackListing</returns>
        
        public async System.Threading.Tasks.Task<NluFeedbackListing> GetLanguageunderstandingDomainFeedbackAsync (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null)
        {
             ApiResponse<NluFeedbackListing> localVarResponse = await GetLanguageunderstandingDomainFeedbackAsyncWithHttpInfo(domainId, intentName, assessment, dateStart, dateEnd, includeDeleted, language, pageNumber, pageSize, enableCursorPagination, includeTrainingUtterances, after, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all feedback in the given NLU Domain Version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="intentName">The top intent name to retrieve feedback for. (optional)</param>
        /// <param name="assessment">The top assessment to retrieve feedback for. (optional)</param>
        /// <param name="dateStart">Begin of time window as ISO-8601 date. (optional)</param>
        /// <param name="dateEnd">End of time window as ISO-8601 date. (optional)</param>
        /// <param name="includeDeleted">Whether to include soft-deleted items in the result. (optional)</param>
        /// <param name="language">Whether to filter response based on the language, e.g. en-us, pt-br. (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="enableCursorPagination">Enable Cursor Pagination (optional, default to false)</param>
        /// <param name="includeTrainingUtterances">Include Training Utterances. By default they&#39;re included. (optional, default to true)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true (optional)</param>
        /// <param name="fields">Fields and properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (NluFeedbackListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NluFeedbackListing>> GetLanguageunderstandingDomainFeedbackAsyncWithHttpInfo (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, List<string> fields = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->GetLanguageunderstandingDomainFeedback");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/feedback";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (intentName != null) localVarQueryParams.Add(new Tuple<string, string>("intentName", this.Configuration.ApiClient.ParameterToString(intentName)));
            if (assessment != null) localVarQueryParams.Add(new Tuple<string, string>("assessment", this.Configuration.ApiClient.ParameterToString(assessment)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (enableCursorPagination != null) localVarQueryParams.Add(new Tuple<string, string>("enableCursorPagination", this.Configuration.ApiClient.ParameterToString(enableCursorPagination)));
            if (includeTrainingUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrainingUtterances", this.Configuration.ApiClient.ParameterToString(includeTrainingUtterances)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of NluDomainListing</returns>
        
        public ApiResponse< NluDomainListing > GetLanguageunderstandingDomainsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/languageunderstanding/domains";
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
        /// 
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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (NluDomainListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainListing>> GetLanguageunderstandingDomainsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/languageunderstanding/domains";
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
        /// Get list of all ignored phrases of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>IgnoredMinedPhraseListing</returns>
        
        public IgnoredMinedPhraseListing GetLanguageunderstandingIgnorephrase (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        {
             ApiResponse<IgnoredMinedPhraseListing> localVarResponse = GetLanguageunderstandingIgnorephraseWithHttpInfo(languageCode, pageSize, pageNumber, text, sortOrder, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of all ignored phrases of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>ApiResponse of IgnoredMinedPhraseListing</returns>
        
        public ApiResponse< IgnoredMinedPhraseListing > GetLanguageunderstandingIgnorephraseWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->GetLanguageunderstandingIgnorephrase");

            var localVarPath = "/api/v2/languageunderstanding/ignorephrases/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (text != null) localVarQueryParams.Add(new Tuple<string, string>("text", this.Configuration.ApiClient.ParameterToString(text)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnorephrase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnorephrase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnoredMinedPhraseListing>(localVarStatusCode,
                localVarHeaders,
                (IgnoredMinedPhraseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnoredMinedPhraseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get list of all ignored phrases of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of IgnoredMinedPhraseListing</returns>
        
        public async System.Threading.Tasks.Task<IgnoredMinedPhraseListing> GetLanguageunderstandingIgnorephraseAsync (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        {
             ApiResponse<IgnoredMinedPhraseListing> localVarResponse = await GetLanguageunderstandingIgnorephraseAsyncWithHttpInfo(languageCode, pageSize, pageNumber, text, sortOrder, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of all ignored phrases of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The phrase text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of ApiResponse (IgnoredMinedPhraseListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IgnoredMinedPhraseListing>> GetLanguageunderstandingIgnorephraseAsyncWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->GetLanguageunderstandingIgnorephrase");
            

            var localVarPath = "/api/v2/languageunderstanding/ignorephrases/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (text != null) localVarQueryParams.Add(new Tuple<string, string>("text", this.Configuration.ApiClient.ParameterToString(text)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnorephrase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnorephrase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnoredMinedPhraseListing>(localVarStatusCode,
                localVarHeaders,
                (IgnoredMinedPhraseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnoredMinedPhraseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get list of all ignored topics of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>IgnoredMinedTopicListing</returns>
        
        public IgnoredMinedTopicListing GetLanguageunderstandingIgnoretopic (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        {
             ApiResponse<IgnoredMinedTopicListing> localVarResponse = GetLanguageunderstandingIgnoretopicWithHttpInfo(languageCode, pageSize, pageNumber, text, sortOrder, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of all ignored topics of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>ApiResponse of IgnoredMinedTopicListing</returns>
        
        public ApiResponse< IgnoredMinedTopicListing > GetLanguageunderstandingIgnoretopicWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->GetLanguageunderstandingIgnoretopic");

            var localVarPath = "/api/v2/languageunderstanding/ignoretopics/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (text != null) localVarQueryParams.Add(new Tuple<string, string>("text", this.Configuration.ApiClient.ParameterToString(text)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnoretopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnoretopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnoredMinedTopicListing>(localVarStatusCode,
                localVarHeaders,
                (IgnoredMinedTopicListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnoredMinedTopicListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get list of all ignored topics of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of IgnoredMinedTopicListing</returns>
        
        public async System.Threading.Tasks.Task<IgnoredMinedTopicListing> GetLanguageunderstandingIgnoretopicAsync (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        {
             ApiResponse<IgnoredMinedTopicListing> localVarResponse = await GetLanguageunderstandingIgnoretopicAsyncWithHttpInfo(languageCode, pageSize, pageNumber, text, sortOrder, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of all ignored topics of the specified language code 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 200. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="text">The topic text filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to desc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to dateModified)</param>
        /// <returns>Task of ApiResponse (IgnoredMinedTopicListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IgnoredMinedTopicListing>> GetLanguageunderstandingIgnoretopicAsyncWithHttpInfo (string languageCode, int? pageSize = null, int? pageNumber = null, string text = null, string sortOrder = null, string sortBy = null)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->GetLanguageunderstandingIgnoretopic");
            

            var localVarPath = "/api/v2/languageunderstanding/ignoretopics/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (text != null) localVarQueryParams.Add(new Tuple<string, string>("text", this.Configuration.ApiClient.ParameterToString(text)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnoretopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingIgnoretopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnoredMinedTopicListing>(localVarStatusCode,
                localVarHeaders,
                (IgnoredMinedTopicListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnoredMinedTopicListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get information about a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Miner</returns>
        
        public Miner GetLanguageunderstandingMiner (string minerId)
        {
             ApiResponse<Miner> localVarResponse = GetLanguageunderstandingMinerWithHttpInfo(minerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of Miner</returns>
        
        public ApiResponse< Miner > GetLanguageunderstandingMinerWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMiner");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiner: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiner: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Miner>(localVarStatusCode,
                localVarHeaders,
                (Miner) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Miner)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get information about a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of Miner</returns>
        
        public async System.Threading.Tasks.Task<Miner> GetLanguageunderstandingMinerAsync (string minerId)
        {
             ApiResponse<Miner> localVarResponse = await GetLanguageunderstandingMinerAsyncWithHttpInfo(minerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about a miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse (Miner)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Miner>> GetLanguageunderstandingMinerAsyncWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMiner");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiner: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiner: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Miner>(localVarStatusCode,
                localVarHeaders,
                (Miner) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Miner)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get information about a draft. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>Draft</returns>
        
        public Draft GetLanguageunderstandingMinerDraft (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null)
        {
             ApiResponse<Draft> localVarResponse = GetLanguageunderstandingMinerDraftWithHttpInfo(minerId, draftId, draftIntentId, draftTopicId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about a draft. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>ApiResponse of Draft</returns>
        
        public ApiResponse< Draft > GetLanguageunderstandingMinerDraftWithHttpInfo (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerDraft");
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new ApiException(400, "Missing required parameter 'draftId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerDraft");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (draftId != null) localVarPathParams.Add("draftId", this.Configuration.ApiClient.ParameterToString(draftId));

            // Query params
            if (draftIntentId != null) localVarQueryParams.Add(new Tuple<string, string>("draftIntentId", this.Configuration.ApiClient.ParameterToString(draftIntentId)));
            if (draftTopicId != null) localVarQueryParams.Add(new Tuple<string, string>("draftTopicId", this.Configuration.ApiClient.ParameterToString(draftTopicId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Draft>(localVarStatusCode,
                localVarHeaders,
                (Draft) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Draft)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get information about a draft. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>Task of Draft</returns>
        
        public async System.Threading.Tasks.Task<Draft> GetLanguageunderstandingMinerDraftAsync (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null)
        {
             ApiResponse<Draft> localVarResponse = await GetLanguageunderstandingMinerDraftAsyncWithHttpInfo(minerId, draftId, draftIntentId, draftTopicId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about a draft. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="draftIntentId">Parameter to filter a specific intent. (optional)</param>
        /// <param name="draftTopicId">Parameter to filter a specific topic. (optional)</param>
        /// <returns>Task of ApiResponse (Draft)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Draft>> GetLanguageunderstandingMinerDraftAsyncWithHttpInfo (string minerId, string draftId, string draftIntentId = null, string draftTopicId = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerDraft");
            
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new ApiException(400, "Missing required parameter 'draftId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerDraft");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (draftId != null) localVarPathParams.Add("draftId", this.Configuration.ApiClient.ParameterToString(draftId));

            // Query params
            if (draftIntentId != null) localVarQueryParams.Add(new Tuple<string, string>("draftIntentId", this.Configuration.ApiClient.ParameterToString(draftIntentId)));
            if (draftTopicId != null) localVarQueryParams.Add(new Tuple<string, string>("draftTopicId", this.Configuration.ApiClient.ParameterToString(draftTopicId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Draft>(localVarStatusCode,
                localVarHeaders,
                (Draft) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Draft)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve the list of drafts created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>DraftListing</returns>
        
        public DraftListing GetLanguageunderstandingMinerDrafts (string minerId)
        {
             ApiResponse<DraftListing> localVarResponse = GetLanguageunderstandingMinerDraftsWithHttpInfo(minerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the list of drafts created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of DraftListing</returns>
        
        public ApiResponse< DraftListing > GetLanguageunderstandingMinerDraftsWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerDrafts");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DraftListing>(localVarStatusCode,
                localVarHeaders,
                (DraftListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DraftListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve the list of drafts created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of DraftListing</returns>
        
        public async System.Threading.Tasks.Task<DraftListing> GetLanguageunderstandingMinerDraftsAsync (string minerId)
        {
             ApiResponse<DraftListing> localVarResponse = await GetLanguageunderstandingMinerDraftsAsyncWithHttpInfo(minerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the list of drafts created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse (DraftListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DraftListing>> GetLanguageunderstandingMinerDraftsAsyncWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerDrafts");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DraftListing>(localVarStatusCode,
                localVarHeaders,
                (DraftListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DraftListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get information about a mined intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>MinerIntent</returns>
        
        public MinerIntent GetLanguageunderstandingMinerIntent (string minerId, string intentId, string expand = null)
        {
             ApiResponse<MinerIntent> localVarResponse = GetLanguageunderstandingMinerIntentWithHttpInfo(minerId, intentId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about a mined intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>ApiResponse of MinerIntent</returns>
        
        public ApiResponse< MinerIntent > GetLanguageunderstandingMinerIntentWithHttpInfo (string minerId, string intentId, string expand = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerIntent");
            // verify the required parameter 'intentId' is set
            if (intentId == null)
                throw new ApiException(400, "Missing required parameter 'intentId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerIntent");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/intents/{intentId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (intentId != null) localVarPathParams.Add("intentId", this.Configuration.ApiClient.ParameterToString(intentId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerIntent>(localVarStatusCode,
                localVarHeaders,
                (MinerIntent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerIntent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get information about a mined intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>Task of MinerIntent</returns>
        
        public async System.Threading.Tasks.Task<MinerIntent> GetLanguageunderstandingMinerIntentAsync (string minerId, string intentId, string expand = null)
        {
             ApiResponse<MinerIntent> localVarResponse = await GetLanguageunderstandingMinerIntentAsyncWithHttpInfo(minerId, intentId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about a mined intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="intentId">The ID of the intent to be retrieved.</param>
        /// <param name="expand">Option to fetch utterances (optional)</param>
        /// <returns>Task of ApiResponse (MinerIntent)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MinerIntent>> GetLanguageunderstandingMinerIntentAsyncWithHttpInfo (string minerId, string intentId, string expand = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerIntent");
            
            // verify the required parameter 'intentId' is set
            if (intentId == null)
                throw new ApiException(400, "Missing required parameter 'intentId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerIntent");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/intents/{intentId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (intentId != null) localVarPathParams.Add("intentId", this.Configuration.ApiClient.ParameterToString(intentId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerIntent>(localVarStatusCode,
                localVarHeaders,
                (MinerIntent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerIntent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of mined intents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>MinedIntentsListing</returns>
        
        public MinedIntentsListing GetLanguageunderstandingMinerIntents (string minerId, string expand = null)
        {
             ApiResponse<MinedIntentsListing> localVarResponse = GetLanguageunderstandingMinerIntentsWithHttpInfo(minerId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of mined intents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>ApiResponse of MinedIntentsListing</returns>
        
        public ApiResponse< MinedIntentsListing > GetLanguageunderstandingMinerIntentsWithHttpInfo (string minerId, string expand = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerIntents");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/intents";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinedIntentsListing>(localVarStatusCode,
                localVarHeaders,
                (MinedIntentsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinedIntentsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of mined intents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>Task of MinedIntentsListing</returns>
        
        public async System.Threading.Tasks.Task<MinedIntentsListing> GetLanguageunderstandingMinerIntentsAsync (string minerId, string expand = null)
        {
             ApiResponse<MinedIntentsListing> localVarResponse = await GetLanguageunderstandingMinerIntentsAsyncWithHttpInfo(minerId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of mined intents. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="expand">Option to fetch utterances. (optional)</param>
        /// <returns>Task of ApiResponse (MinedIntentsListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MinedIntentsListing>> GetLanguageunderstandingMinerIntentsAsyncWithHttpInfo (string minerId, string expand = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerIntents");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/intents";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerIntents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinedIntentsListing>(localVarStatusCode,
                localVarHeaders,
                (MinedIntentsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinedIntentsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves details of a particular topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>MinerTopic</returns>
        
        public MinerTopic GetLanguageunderstandingMinerTopic (string minerId, string topicId, string expand = null)
        {
             ApiResponse<MinerTopic> localVarResponse = GetLanguageunderstandingMinerTopicWithHttpInfo(minerId, topicId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves details of a particular topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>ApiResponse of MinerTopic</returns>
        
        public ApiResponse< MinerTopic > GetLanguageunderstandingMinerTopicWithHttpInfo (string minerId, string topicId, string expand = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopic");
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopic");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/topics/{topicId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerTopic>(localVarStatusCode,
                localVarHeaders,
                (MinerTopic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerTopic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves details of a particular topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>Task of MinerTopic</returns>
        
        public async System.Threading.Tasks.Task<MinerTopic> GetLanguageunderstandingMinerTopicAsync (string minerId, string topicId, string expand = null)
        {
             ApiResponse<MinerTopic> localVarResponse = await GetLanguageunderstandingMinerTopicAsyncWithHttpInfo(minerId, topicId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves details of a particular topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="expand">Option to fetch phrases (optional)</param>
        /// <returns>Task of ApiResponse (MinerTopic)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MinerTopic>> GetLanguageunderstandingMinerTopicAsyncWithHttpInfo (string minerId, string topicId, string expand = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopic");
            
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopic");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/topics/{topicId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerTopic>(localVarStatusCode,
                localVarHeaders,
                (MinerTopic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerTopic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves utterances related to a phrase in a topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>MinerTopicPhrase</returns>
        
        public MinerTopicPhrase GetLanguageunderstandingMinerTopicPhrase (string minerId, string topicId, string phraseId)
        {
             ApiResponse<MinerTopicPhrase> localVarResponse = GetLanguageunderstandingMinerTopicPhraseWithHttpInfo(minerId, topicId, phraseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves utterances related to a phrase in a topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>ApiResponse of MinerTopicPhrase</returns>
        
        public ApiResponse< MinerTopicPhrase > GetLanguageunderstandingMinerTopicPhraseWithHttpInfo (string minerId, string topicId, string phraseId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopicPhrase");
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopicPhrase");
            // verify the required parameter 'phraseId' is set
            if (phraseId == null)
                throw new ApiException(400, "Missing required parameter 'phraseId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopicPhrase");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/topics/{topicId}/phrases/{phraseId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (phraseId != null) localVarPathParams.Add("phraseId", this.Configuration.ApiClient.ParameterToString(phraseId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopicPhrase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopicPhrase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerTopicPhrase>(localVarStatusCode,
                localVarHeaders,
                (MinerTopicPhrase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerTopicPhrase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves utterances related to a phrase in a topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>Task of MinerTopicPhrase</returns>
        
        public async System.Threading.Tasks.Task<MinerTopicPhrase> GetLanguageunderstandingMinerTopicPhraseAsync (string minerId, string topicId, string phraseId)
        {
             ApiResponse<MinerTopicPhrase> localVarResponse = await GetLanguageunderstandingMinerTopicPhraseAsyncWithHttpInfo(minerId, topicId, phraseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves utterances related to a phrase in a topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="topicId">The ID of the topic to be retrieved.</param>
        /// <param name="phraseId">The ID of the phrase to be retrieved.</param>
        /// <returns>Task of ApiResponse (MinerTopicPhrase)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MinerTopicPhrase>> GetLanguageunderstandingMinerTopicPhraseAsyncWithHttpInfo (string minerId, string topicId, string phraseId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopicPhrase");
            
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopicPhrase");
            
            // verify the required parameter 'phraseId' is set
            if (phraseId == null)
                throw new ApiException(400, "Missing required parameter 'phraseId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopicPhrase");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/topics/{topicId}/phrases/{phraseId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (phraseId != null) localVarPathParams.Add("phraseId", this.Configuration.ApiClient.ParameterToString(phraseId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopicPhrase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopicPhrase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerTopicPhrase>(localVarStatusCode,
                localVarHeaders,
                (MinerTopicPhrase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerTopicPhrase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of mined topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>MinerTopicsListing</returns>
        
        public MinerTopicsListing GetLanguageunderstandingMinerTopics (string minerId)
        {
             ApiResponse<MinerTopicsListing> localVarResponse = GetLanguageunderstandingMinerTopicsWithHttpInfo(minerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of mined topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>ApiResponse of MinerTopicsListing</returns>
        
        public ApiResponse< MinerTopicsListing > GetLanguageunderstandingMinerTopicsWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopics");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/topics";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerTopicsListing>(localVarStatusCode,
                localVarHeaders,
                (MinerTopicsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerTopicsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of mined topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of MinerTopicsListing</returns>
        
        public async System.Threading.Tasks.Task<MinerTopicsListing> GetLanguageunderstandingMinerTopicsAsync (string minerId)
        {
             ApiResponse<MinerTopicsListing> localVarResponse = await GetLanguageunderstandingMinerTopicsAsyncWithHttpInfo(minerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of mined topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <returns>Task of ApiResponse (MinerTopicsListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MinerTopicsListing>> GetLanguageunderstandingMinerTopicsAsyncWithHttpInfo (string minerId)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->GetLanguageunderstandingMinerTopics");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/topics";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMinerTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerTopicsListing>(localVarStatusCode,
                localVarHeaders,
                (MinerTopicsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerTopicsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve the list of miners created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>MinerListing</returns>
        
        public MinerListing GetLanguageunderstandingMiners (string minerType = null)
        {
             ApiResponse<MinerListing> localVarResponse = GetLanguageunderstandingMinersWithHttpInfo(minerType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the list of miners created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>ApiResponse of MinerListing</returns>
        
        public ApiResponse< MinerListing > GetLanguageunderstandingMinersWithHttpInfo (string minerType = null)
        { 

            var localVarPath = "/api/v2/languageunderstanding/miners";
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
            if (minerType != null) localVarQueryParams.Add(new Tuple<string, string>("minerType", this.Configuration.ApiClient.ParameterToString(minerType)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiners: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiners: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerListing>(localVarStatusCode,
                localVarHeaders,
                (MinerListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve the list of miners created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>Task of MinerListing</returns>
        
        public async System.Threading.Tasks.Task<MinerListing> GetLanguageunderstandingMinersAsync (string minerType = null)
        {
             ApiResponse<MinerListing> localVarResponse = await GetLanguageunderstandingMinersAsyncWithHttpInfo(minerType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the list of miners created. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerType">Type of miner, either intent or topic (optional)</param>
        /// <returns>Task of ApiResponse (MinerListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MinerListing>> GetLanguageunderstandingMinersAsyncWithHttpInfo (string minerType = null)
        { 

            var localVarPath = "/api/v2/languageunderstanding/miners";
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
            if (minerType != null) localVarQueryParams.Add(new Tuple<string, string>("minerType", this.Configuration.ApiClient.ParameterToString(minerType)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiners: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingMiners: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinerListing>(localVarStatusCode,
                localVarHeaders,
                (MinerListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinerListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Organization Configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>NluOrganization</returns>
        
        public NluOrganization GetLanguageunderstandingSettings ()
        {
             ApiResponse<NluOrganization> localVarResponse = GetLanguageunderstandingSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Organization Configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of NluOrganization</returns>
        
        public ApiResponse< NluOrganization > GetLanguageunderstandingSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/languageunderstanding/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluOrganization>(localVarStatusCode,
                localVarHeaders,
                (NluOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Organization Configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NluOrganization</returns>
        
        public async System.Threading.Tasks.Task<NluOrganization> GetLanguageunderstandingSettingsAsync ()
        {
             ApiResponse<NluOrganization> localVarResponse = await GetLanguageunderstandingSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Organization Configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NluOrganization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NluOrganization>> GetLanguageunderstandingSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/languageunderstanding/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageunderstandingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NluOrganization>(localVarStatusCode,
                localVarHeaders,
                (NluOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NluOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an NLU Domain. 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Save information for the draft. Either topic draft or intent draft should be sent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Draft</returns>
        
        public Draft PatchLanguageunderstandingMinerDraft (string minerId, string draftId, DraftRequest body = null)
        {
             ApiResponse<Draft> localVarResponse = PatchLanguageunderstandingMinerDraftWithHttpInfo(minerId, draftId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Save information for the draft. Either topic draft or intent draft should be sent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Draft</returns>
        
        public ApiResponse< Draft > PatchLanguageunderstandingMinerDraftWithHttpInfo (string minerId, string draftId, DraftRequest body = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->PatchLanguageunderstandingMinerDraft");
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new ApiException(400, "Missing required parameter 'draftId' when calling LanguageUnderstandingApi->PatchLanguageunderstandingMinerDraft");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (draftId != null) localVarPathParams.Add("draftId", this.Configuration.ApiClient.ParameterToString(draftId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingMinerDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingMinerDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Draft>(localVarStatusCode,
                localVarHeaders,
                (Draft) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Draft)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Save information for the draft. Either topic draft or intent draft should be sent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Draft</returns>
        
        public async System.Threading.Tasks.Task<Draft> PatchLanguageunderstandingMinerDraftAsync (string minerId, string draftId, DraftRequest body = null)
        {
             ApiResponse<Draft> localVarResponse = await PatchLanguageunderstandingMinerDraftAsyncWithHttpInfo(minerId, draftId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Save information for the draft. Either topic draft or intent draft should be sent. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="draftId">Draft ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Draft)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Draft>> PatchLanguageunderstandingMinerDraftAsyncWithHttpInfo (string minerId, string draftId, DraftRequest body = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->PatchLanguageunderstandingMinerDraft");
            
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new ApiException(400, "Missing required parameter 'draftId' when calling LanguageUnderstandingApi->PatchLanguageunderstandingMinerDraft");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId}";
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
            if (minerId != null) localVarPathParams.Add("minerId", this.Configuration.ApiClient.ParameterToString(minerId));
            if (draftId != null) localVarPathParams.Add("draftId", this.Configuration.ApiClient.ParameterToString(draftId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingMinerDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchLanguageunderstandingMinerDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Draft>(localVarStatusCode,
                localVarHeaders,
                (Draft) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Draft)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create feedback for the NLU Domain Version. 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>NluDomainVersion</returns>
        
        public NluDomainVersion PostLanguageunderstandingDomainVersions (string domainId, NluDomainVersion body, bool? includeUtterances = null)
        {
             ApiResponse<NluDomainVersion> localVarResponse = PostLanguageunderstandingDomainVersionsWithHttpInfo(domainId, body, includeUtterances);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an NLU Domain Version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>ApiResponse of NluDomainVersion</returns>
        
        public ApiResponse< NluDomainVersion > PostLanguageunderstandingDomainVersionsWithHttpInfo (string domainId, NluDomainVersion body, bool? includeUtterances = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (includeUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeUtterances", this.Configuration.ApiClient.ParameterToString(includeUtterances)));

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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of NluDomainVersion</returns>
        
        public async System.Threading.Tasks.Task<NluDomainVersion> PostLanguageunderstandingDomainVersionsAsync (string domainId, NluDomainVersion body, bool? includeUtterances = null)
        {
             ApiResponse<NluDomainVersion> localVarResponse = await PostLanguageunderstandingDomainVersionsAsyncWithHttpInfo(domainId, body, includeUtterances);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an NLU Domain Version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">ID of the NLU domain.</param>
        /// <param name="body">The NLU Domain Version to create.</param>
        /// <param name="includeUtterances">Whether utterances for intent definition should be included when marshalling response. (optional)</param>
        /// <returns>Task of ApiResponse (NluDomainVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NluDomainVersion>> PostLanguageunderstandingDomainVersionsAsyncWithHttpInfo (string domainId, NluDomainVersion body, bool? includeUtterances = null)
        { 
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingDomainVersions");
            

            var localVarPath = "/api/v2/languageunderstanding/domains/{domainId}/versions";
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
            if (domainId != null) localVarPathParams.Add("domainId", this.Configuration.ApiClient.ParameterToString(domainId));

            // Query params
            if (includeUtterances != null) localVarQueryParams.Add(new Tuple<string, string>("includeUtterances", this.Configuration.ApiClient.ParameterToString(includeUtterances)));

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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// Add phrases to the ignored phrases list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>IgnorePhrasesResponse</returns>
        
        public IgnorePhrasesResponse PostLanguageunderstandingIgnorephrase (string languageCode, IgnorePhrasesRequest body)
        {
             ApiResponse<IgnorePhrasesResponse> localVarResponse = PostLanguageunderstandingIgnorephraseWithHttpInfo(languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add phrases to the ignored phrases list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>ApiResponse of IgnorePhrasesResponse</returns>
        
        public ApiResponse< IgnorePhrasesResponse > PostLanguageunderstandingIgnorephraseWithHttpInfo (string languageCode, IgnorePhrasesRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephrase");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephrase");

            var localVarPath = "/api/v2/languageunderstanding/ignorephrases/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephrase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephrase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnorePhrasesResponse>(localVarStatusCode,
                localVarHeaders,
                (IgnorePhrasesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnorePhrasesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add phrases to the ignored phrases list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>Task of IgnorePhrasesResponse</returns>
        
        public async System.Threading.Tasks.Task<IgnorePhrasesResponse> PostLanguageunderstandingIgnorephraseAsync (string languageCode, IgnorePhrasesRequest body)
        {
             ApiResponse<IgnorePhrasesResponse> localVarResponse = await PostLanguageunderstandingIgnorephraseAsyncWithHttpInfo(languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add phrases to the ignored phrases list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing phrases to be ignored</param>
        /// <returns>Task of ApiResponse (IgnorePhrasesResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IgnorePhrasesResponse>> PostLanguageunderstandingIgnorephraseAsyncWithHttpInfo (string languageCode, IgnorePhrasesRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephrase");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephrase");
            

            var localVarPath = "/api/v2/languageunderstanding/ignorephrases/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephrase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephrase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnorePhrasesResponse>(localVarStatusCode,
                localVarHeaders,
                (IgnorePhrasesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnorePhrasesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete ignored phrases 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns></returns>
        
        public void PostLanguageunderstandingIgnorephraseRemove (string languageCode, RemoveEntitiesRequest body)
        {
             PostLanguageunderstandingIgnorephraseRemoveWithHttpInfo(languageCode, body);
        }

        /// <summary>
        /// Delete ignored phrases 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostLanguageunderstandingIgnorephraseRemoveWithHttpInfo (string languageCode, RemoveEntitiesRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephraseRemove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephraseRemove");

            var localVarPath = "/api/v2/languageunderstanding/ignorephrases/{languageCode}/remove";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephraseRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephraseRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete ignored phrases 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostLanguageunderstandingIgnorephraseRemoveAsync (string languageCode, RemoveEntitiesRequest body)
        {
             await PostLanguageunderstandingIgnorephraseRemoveAsyncWithHttpInfo(languageCode, body);

        }

        /// <summary>
        /// Delete ignored phrases 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostLanguageunderstandingIgnorephraseRemoveAsyncWithHttpInfo (string languageCode, RemoveEntitiesRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephraseRemove");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnorephraseRemove");
            

            var localVarPath = "/api/v2/languageunderstanding/ignorephrases/{languageCode}/remove";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephraseRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnorephraseRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add topics to the ignored topics list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>IgnoreTopicsResponse</returns>
        
        public IgnoreTopicsResponse PostLanguageunderstandingIgnoretopic (string languageCode, IgnoreTopicsRequest body)
        {
             ApiResponse<IgnoreTopicsResponse> localVarResponse = PostLanguageunderstandingIgnoretopicWithHttpInfo(languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add topics to the ignored topics list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>ApiResponse of IgnoreTopicsResponse</returns>
        
        public ApiResponse< IgnoreTopicsResponse > PostLanguageunderstandingIgnoretopicWithHttpInfo (string languageCode, IgnoreTopicsRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopic");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopic");

            var localVarPath = "/api/v2/languageunderstanding/ignoretopics/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnoreTopicsResponse>(localVarStatusCode,
                localVarHeaders,
                (IgnoreTopicsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnoreTopicsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add topics to the ignored topics list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>Task of IgnoreTopicsResponse</returns>
        
        public async System.Threading.Tasks.Task<IgnoreTopicsResponse> PostLanguageunderstandingIgnoretopicAsync (string languageCode, IgnoreTopicsRequest body)
        {
             ApiResponse<IgnoreTopicsResponse> localVarResponse = await PostLanguageunderstandingIgnoretopicAsyncWithHttpInfo(languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add topics to the ignored topics list 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing topics to be ignored</param>
        /// <returns>Task of ApiResponse (IgnoreTopicsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IgnoreTopicsResponse>> PostLanguageunderstandingIgnoretopicAsyncWithHttpInfo (string languageCode, IgnoreTopicsRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopic");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopic");
            

            var localVarPath = "/api/v2/languageunderstanding/ignoretopics/{languageCode}";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IgnoreTopicsResponse>(localVarStatusCode,
                localVarHeaders,
                (IgnoreTopicsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IgnoreTopicsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete ignored topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns></returns>
        
        public void PostLanguageunderstandingIgnoretopicRemove (string languageCode, RemoveEntitiesRequest body)
        {
             PostLanguageunderstandingIgnoretopicRemoveWithHttpInfo(languageCode, body);
        }

        /// <summary>
        /// Delete ignored topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostLanguageunderstandingIgnoretopicRemoveWithHttpInfo (string languageCode, RemoveEntitiesRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopicRemove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopicRemove");

            var localVarPath = "/api/v2/languageunderstanding/ignoretopics/{languageCode}/remove";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopicRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopicRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete ignored topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostLanguageunderstandingIgnoretopicRemoveAsync (string languageCode, RemoveEntitiesRequest body)
        {
             await PostLanguageunderstandingIgnoretopicRemoveAsyncWithHttpInfo(languageCode, body);

        }

        /// <summary>
        /// Delete ignored topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Language Code</param>
        /// <param name="body">Request body containing entities to be removed</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostLanguageunderstandingIgnoretopicRemoveAsyncWithHttpInfo (string languageCode, RemoveEntitiesRequest body)
        { 
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopicRemove");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingIgnoretopicRemove");
            

            var localVarPath = "/api/v2/languageunderstanding/ignoretopics/{languageCode}/remove";
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
            if (languageCode != null) localVarPathParams.Add("languageCode", this.Configuration.ApiClient.ParameterToString(languageCode));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopicRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingIgnoretopicRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new draft resource. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>Draft</returns>
        
        public Draft PostLanguageunderstandingMinerDrafts (string minerId, Draft body)
        {
             ApiResponse<Draft> localVarResponse = PostLanguageunderstandingMinerDraftsWithHttpInfo(minerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new draft resource. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>ApiResponse of Draft</returns>
        
        public ApiResponse< Draft > PostLanguageunderstandingMinerDraftsWithHttpInfo (string minerId, Draft body)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->PostLanguageunderstandingMinerDrafts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingMinerDrafts");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Draft>(localVarStatusCode,
                localVarHeaders,
                (Draft) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Draft)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new draft resource. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>Task of Draft</returns>
        
        public async System.Threading.Tasks.Task<Draft> PostLanguageunderstandingMinerDraftsAsync (string minerId, Draft body)
        {
             ApiResponse<Draft> localVarResponse = await PostLanguageunderstandingMinerDraftsAsyncWithHttpInfo(minerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new draft resource. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body">Details for creating draft resource</param>
        /// <returns>Task of ApiResponse (Draft)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Draft>> PostLanguageunderstandingMinerDraftsAsyncWithHttpInfo (string minerId, Draft body)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->PostLanguageunderstandingMinerDrafts");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingMinerDrafts");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/drafts";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Draft>(localVarStatusCode,
                localVarHeaders,
                (Draft) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Draft)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Miner</returns>
        
        public Miner PostLanguageunderstandingMinerExecute (string minerId, MinerExecuteRequest body = null)
        {
             ApiResponse<Miner> localVarResponse = PostLanguageunderstandingMinerExecuteWithHttpInfo(minerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Miner</returns>
        
        public ApiResponse< Miner > PostLanguageunderstandingMinerExecuteWithHttpInfo (string minerId, MinerExecuteRequest body = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->PostLanguageunderstandingMinerExecute");

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/execute";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Miner>(localVarStatusCode,
                localVarHeaders,
                (Miner) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Miner)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Miner</returns>
        
        public async System.Threading.Tasks.Task<Miner> PostLanguageunderstandingMinerExecuteAsync (string minerId, MinerExecuteRequest body = null)
        {
             ApiResponse<Miner> localVarResponse = await PostLanguageunderstandingMinerExecuteAsyncWithHttpInfo(minerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="minerId">Miner ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Miner)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Miner>> PostLanguageunderstandingMinerExecuteAsyncWithHttpInfo (string minerId, MinerExecuteRequest body = null)
        { 
            // verify the required parameter 'minerId' is set
            if (minerId == null)
                throw new ApiException(400, "Missing required parameter 'minerId' when calling LanguageUnderstandingApi->PostLanguageunderstandingMinerExecute");
            

            var localVarPath = "/api/v2/languageunderstanding/miners/{minerId}/execute";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMinerExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Miner>(localVarStatusCode,
                localVarHeaders,
                (Miner) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Miner)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a unique miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>Miner</returns>
        
        public Miner PostLanguageunderstandingMiners (Miner body)
        {
             ApiResponse<Miner> localVarResponse = PostLanguageunderstandingMinersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a unique miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>ApiResponse of Miner</returns>
        
        public ApiResponse< Miner > PostLanguageunderstandingMinersWithHttpInfo (Miner body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingMiners");

            var localVarPath = "/api/v2/languageunderstanding/miners";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMiners: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMiners: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Miner>(localVarStatusCode,
                localVarHeaders,
                (Miner) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Miner)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a unique miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>Task of Miner</returns>
        
        public async System.Threading.Tasks.Task<Miner> PostLanguageunderstandingMinersAsync (Miner body)
        {
             ApiResponse<Miner> localVarResponse = await PostLanguageunderstandingMinersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a unique miner. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details for creating a new miner resource.</param>
        /// <returns>Task of ApiResponse (Miner)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Miner>> PostLanguageunderstandingMinersAsyncWithHttpInfo (Miner body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguageUnderstandingApi->PostLanguageunderstandingMiners");
            

            var localVarPath = "/api/v2/languageunderstanding/miners";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMiners: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguageunderstandingMiners: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Miner>(localVarStatusCode,
                localVarHeaders,
                (Miner) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Miner)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an NLU Domain Version. 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
