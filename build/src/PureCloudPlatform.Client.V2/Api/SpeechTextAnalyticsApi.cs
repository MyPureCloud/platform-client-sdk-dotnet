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
    public interface ISpeechTextAnalyticsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns></returns>
        
        void DeleteSpeechandtextanalyticsCategory (string categoryId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSpeechandtextanalyticsCategoryWithHttpInfo (string categoryId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns></returns>
        
        void DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo (string dictionaryFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>DeleteProgramResponse</returns>
        
        DeleteProgramResponse DeleteSpeechandtextanalyticsProgram (string programId, bool? forceDelete = null);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>ApiResponse of DeleteProgramResponse</returns>
        
        ApiResponse<DeleteProgramResponse> DeleteSpeechandtextanalyticsProgramWithHttpInfo (string programId, bool? forceDelete = null);

        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        
        void DeleteSpeechandtextanalyticsSentimentfeedback ();

        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSpeechandtextanalyticsSentimentfeedbackWithHttpInfo ();

        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns></returns>
        
        void DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId (string sentimentFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdWithHttpInfo (string sentimentFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns></returns>
        
        void DeleteSpeechandtextanalyticsTopic (string topicId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSpeechandtextanalyticsTopicWithHttpInfo (string topicId);

        /// <summary>
        /// Get the list of Speech and Text Analytics categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>CategoriesEntityListing</returns>
        
        CategoriesEntityListing GetSpeechandtextanalyticsCategories (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null);

        /// <summary>
        /// Get the list of Speech and Text Analytics categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>ApiResponse of CategoriesEntityListing</returns>
        
        ApiResponse<CategoriesEntityListing> GetSpeechandtextanalyticsCategoriesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>StaCategory</returns>
        
        StaCategory GetSpeechandtextanalyticsCategory (string categoryId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>ApiResponse of StaCategory</returns>
        
        ApiResponse<StaCategory> GetSpeechandtextanalyticsCategoryWithHttpInfo (string categoryId);

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
        /// Get the list of detected Speech and Text Analytics categories of conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>ConversationCategoriesEntityListing</returns>
        
        ConversationCategoriesEntityListing GetSpeechandtextanalyticsConversationCategories (string conversationId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of detected Speech and Text Analytics categories of conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>ApiResponse of ConversationCategoriesEntityListing</returns>
        
        ApiResponse<ConversationCategoriesEntityListing> GetSpeechandtextanalyticsConversationCategoriesWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null);

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

        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>TranscriptUrls</returns>
        
        TranscriptUrls GetSpeechandtextanalyticsConversationCommunicationTranscripturls (string conversationId, string communicationId);

        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>ApiResponse of TranscriptUrls</returns>
        
        ApiResponse<TranscriptUrls> GetSpeechandtextanalyticsConversationCommunicationTranscripturlsWithHttpInfo (string conversationId, string communicationId);

        /// <summary>
        /// Get conversation summaries by conversation id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>SpeechTextAnalyticsConversationSummaryListing</returns>
        
        SpeechTextAnalyticsConversationSummaryListing GetSpeechandtextanalyticsConversationSummaries (string conversationId);

        /// <summary>
        /// Get conversation summaries by conversation id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsConversationSummaryListing</returns>
        
        ApiResponse<SpeechTextAnalyticsConversationSummaryListing> GetSpeechandtextanalyticsConversationSummariesWithHttpInfo (string conversationId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>DictionaryFeedbackEntityListing</returns>
        
        DictionaryFeedbackEntityListing GetSpeechandtextanalyticsDictionaryfeedback (string dialect = null, string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>ApiResponse of DictionaryFeedbackEntityListing</returns>
        
        ApiResponse<DictionaryFeedbackEntityListing> GetSpeechandtextanalyticsDictionaryfeedbackWithHttpInfo (string dialect = null, string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>DictionaryFeedback</returns>
        
        DictionaryFeedback GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>ApiResponse of DictionaryFeedback</returns>
        
        ApiResponse<DictionaryFeedback> GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo (string dictionaryFeedbackId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Program</returns>
        
        Program GetSpeechandtextanalyticsProgram (string programId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of Program</returns>
        
        ApiResponse<Program> GetSpeechandtextanalyticsProgramWithHttpInfo (string programId);

        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ProgramMappings</returns>
        
        ProgramMappings GetSpeechandtextanalyticsProgramMappings (string programId);

        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of ProgramMappings</returns>
        
        ApiResponse<ProgramMappings> GetSpeechandtextanalyticsProgramMappingsWithHttpInfo (string programId);

        /// <summary>
        /// Get AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ProgramInsightsSettings</returns>
        
        ProgramInsightsSettings GetSpeechandtextanalyticsProgramSettingsInsights (string programId);

        /// <summary>
        /// Get AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of ProgramInsightsSettings</returns>
        
        ApiResponse<ProgramInsightsSettings> GetSpeechandtextanalyticsProgramSettingsInsightsWithHttpInfo (string programId);

        /// <summary>
        /// Get transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ProgramTranscriptionEngines</returns>
        
        ProgramTranscriptionEngines GetSpeechandtextanalyticsProgramTranscriptionengines (string programId);

        /// <summary>
        /// Get transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of ProgramTranscriptionEngines</returns>
        
        ApiResponse<ProgramTranscriptionEngines> GetSpeechandtextanalyticsProgramTranscriptionenginesWithHttpInfo (string programId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>ProgramsEntityListing</returns>
        
        ProgramsEntityListing GetSpeechandtextanalyticsPrograms (string nextPage = null, int? pageSize = null, string state = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>ApiResponse of ProgramsEntityListing</returns>
        
        ApiResponse<ProgramsEntityListing> GetSpeechandtextanalyticsProgramsWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>GeneralProgramJob</returns>
        
        GeneralProgramJob GetSpeechandtextanalyticsProgramsGeneralJob (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        
        ApiResponse<GeneralProgramJob> GetSpeechandtextanalyticsProgramsGeneralJobWithHttpInfo (string jobId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ProgramsMappingsEntityListing</returns>
        
        ProgramsMappingsEntityListing GetSpeechandtextanalyticsProgramsMappings (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of ProgramsMappingsEntityListing</returns>
        
        ApiResponse<ProgramsMappingsEntityListing> GetSpeechandtextanalyticsProgramsMappingsWithHttpInfo (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ProgramJob</returns>
        
        ProgramJob GetSpeechandtextanalyticsProgramsPublishjob (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        
        ApiResponse<ProgramJob> GetSpeechandtextanalyticsProgramsPublishjobWithHttpInfo (string jobId);

        /// <summary>
        /// Get the list of program AI Insights settings for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>ProgramInsightsSettingsEntityListing</returns>
        
        ProgramInsightsSettingsEntityListing GetSpeechandtextanalyticsProgramsSettingsInsights (int? pageSize = null, int? pageNumber = null, List<string> programIds = null);

        /// <summary>
        /// Get the list of program AI Insights settings for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>ApiResponse of ProgramInsightsSettingsEntityListing</returns>
        
        ApiResponse<ProgramInsightsSettingsEntityListing> GetSpeechandtextanalyticsProgramsSettingsInsightsWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> programIds = null);

        /// <summary>
        /// Get supported dialects for each transcription engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SupportedDialectsEntityListing</returns>
        
        SupportedDialectsEntityListing GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects ();

        /// <summary>
        /// Get supported dialects for each transcription engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SupportedDialectsEntityListing</returns>
        
        ApiResponse<SupportedDialectsEntityListing> GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsWithHttpInfo ();

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>UnpublishedProgramsEntityListing</returns>
        
        UnpublishedProgramsEntityListing GetSpeechandtextanalyticsProgramsUnpublished (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of UnpublishedProgramsEntityListing</returns>
        
        ApiResponse<UnpublishedProgramsEntityListing> GetSpeechandtextanalyticsProgramsUnpublishedWithHttpInfo (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EntityListing</returns>
        
        EntityListing GetSpeechandtextanalyticsSentimentDialects ();

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EntityListing</returns>
        
        ApiResponse<EntityListing> GetSpeechandtextanalyticsSentimentDialectsWithHttpInfo ();

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>SentimentFeedbackEntityListing</returns>
        
        SentimentFeedbackEntityListing GetSpeechandtextanalyticsSentimentfeedback (string dialect = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of SentimentFeedbackEntityListing</returns>
        
        ApiResponse<SentimentFeedbackEntityListing> GetSpeechandtextanalyticsSentimentfeedbackWithHttpInfo (string dialect = null);

        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        
        SpeechTextAnalyticsSettingsResponse GetSpeechandtextanalyticsSettings ();

        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        
        ApiResponse<SpeechTextAnalyticsSettingsResponse> GetSpeechandtextanalyticsSettingsWithHttpInfo ();

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Topic</returns>
        
        Topic GetSpeechandtextanalyticsTopic (string topicId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Topic</returns>
        
        ApiResponse<Topic> GetSpeechandtextanalyticsTopicWithHttpInfo (string topicId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>TopicsEntityListing</returns>
        
        TopicsEntityListing GetSpeechandtextanalyticsTopics (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>ApiResponse of TopicsEntityListing</returns>
        
        ApiResponse<TopicsEntityListing> GetSpeechandtextanalyticsTopicsWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EntityListing</returns>
        
        EntityListing GetSpeechandtextanalyticsTopicsDialects ();

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EntityListing</returns>
        
        ApiResponse<EntityListing> GetSpeechandtextanalyticsTopicsDialectsWithHttpInfo ();

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>GeneralTopicsEntityListing</returns>
        
        GeneralTopicsEntityListing GetSpeechandtextanalyticsTopicsGeneral (string dialect = null);

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of GeneralTopicsEntityListing</returns>
        
        ApiResponse<GeneralTopicsEntityListing> GetSpeechandtextanalyticsTopicsGeneralWithHttpInfo (string dialect = null);

        /// <summary>
        /// Get the list of general topics from the org and the system with their current status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>UnifiedGeneralTopicEntityListing</returns>
        
        UnifiedGeneralTopicEntityListing GetSpeechandtextanalyticsTopicsGeneralStatus (string dialect = null);

        /// <summary>
        /// Get the list of general topics from the org and the system with their current status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of UnifiedGeneralTopicEntityListing</returns>
        
        ApiResponse<UnifiedGeneralTopicEntityListing> GetSpeechandtextanalyticsTopicsGeneralStatusWithHttpInfo (string dialect = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>TopicJob</returns>
        
        TopicJob GetSpeechandtextanalyticsTopicsPublishjob (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>ApiResponse of TopicJob</returns>
        
        ApiResponse<TopicJob> GetSpeechandtextanalyticsTopicsPublishjobWithHttpInfo (string jobId);

        /// <summary>
        /// Translate a single interaction recording (or an email conversation)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>CommunicationTranslationList</returns>
        
        CommunicationTranslationList GetSpeechandtextanalyticsTranslationsLanguageConversation (string languageId, string conversationId, string communicationId = null, string recordingId = null);

        /// <summary>
        /// Translate a single interaction recording (or an email conversation)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>ApiResponse of CommunicationTranslationList</returns>
        
        ApiResponse<CommunicationTranslationList> GetSpeechandtextanalyticsTranslationsLanguageConversationWithHttpInfo (string languageId, string conversationId, string communicationId = null, string recordingId = null);

        /// <summary>
        /// Get supported translation languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TranslateSupportedLanguageList</returns>
        
        TranslateSupportedLanguageList GetSpeechandtextanalyticsTranslationsLanguages ();

        /// <summary>
        /// Get supported translation languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TranslateSupportedLanguageList</returns>
        
        ApiResponse<TranslateSupportedLanguageList> GetSpeechandtextanalyticsTranslationsLanguagesWithHttpInfo ();

        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        
        SpeechTextAnalyticsSettingsResponse PatchSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        
        ApiResponse<SpeechTextAnalyticsSettingsResponse> PatchSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>StaCategory</returns>
        
        StaCategory PostSpeechandtextanalyticsCategories (CategoryRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>ApiResponse of StaCategory</returns>
        
        ApiResponse<StaCategory> PostSpeechandtextanalyticsCategoriesWithHttpInfo (CategoryRequest body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>DictionaryFeedback</returns>
        
        DictionaryFeedback PostSpeechandtextanalyticsDictionaryfeedback (DictionaryFeedback body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>ApiResponse of DictionaryFeedback</returns>
        
        ApiResponse<DictionaryFeedback> PostSpeechandtextanalyticsDictionaryfeedbackWithHttpInfo (DictionaryFeedback body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Program</returns>
        
        Program PostSpeechandtextanalyticsPrograms (ProgramRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>ApiResponse of Program</returns>
        
        ApiResponse<Program> PostSpeechandtextanalyticsProgramsWithHttpInfo (ProgramRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>GeneralProgramJob</returns>
        
        GeneralProgramJob PostSpeechandtextanalyticsProgramsGeneralJobs (GeneralProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        
        ApiResponse<GeneralProgramJob> PostSpeechandtextanalyticsProgramsGeneralJobsWithHttpInfo (GeneralProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ProgramJob</returns>
        
        ProgramJob PostSpeechandtextanalyticsProgramsPublishjobs (ProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        
        ApiResponse<ProgramJob> PostSpeechandtextanalyticsProgramsPublishjobsWithHttpInfo (ProgramJobRequest body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>SentimentFeedback</returns>
        
        SentimentFeedback PostSpeechandtextanalyticsSentimentfeedback (SentimentFeedback body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>ApiResponse of SentimentFeedback</returns>
        
        ApiResponse<SentimentFeedback> PostSpeechandtextanalyticsSentimentfeedbackWithHttpInfo (SentimentFeedback body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Topic</returns>
        
        Topic PostSpeechandtextanalyticsTopics (TopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>ApiResponse of Topic</returns>
        
        ApiResponse<Topic> PostSpeechandtextanalyticsTopicsWithHttpInfo (TopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>TopicJob</returns>
        
        TopicJob PostSpeechandtextanalyticsTopicsPublishjobs (TopicJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>ApiResponse of TopicJob</returns>
        
        ApiResponse<TopicJob> PostSpeechandtextanalyticsTopicsPublishjobsWithHttpInfo (TopicJobRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>JsonSearchResponse</returns>
        
        JsonSearchResponse PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of JsonSearchResponse</returns>
        
        ApiResponse<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo (TranscriptSearchRequest body);

        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>StaCategory</returns>
        
        StaCategory PutSpeechandtextanalyticsCategory (string categoryId, CategoryRequest body);

        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>ApiResponse of StaCategory</returns>
        
        ApiResponse<StaCategory> PutSpeechandtextanalyticsCategoryWithHttpInfo (string categoryId, CategoryRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DictionaryFeedback</returns>
        
        DictionaryFeedback PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId, DictionaryFeedback body = null);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DictionaryFeedback</returns>
        
        ApiResponse<DictionaryFeedback> PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo (string dictionaryFeedbackId, DictionaryFeedback body = null);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Program</returns>
        
        Program PutSpeechandtextanalyticsProgram (string programId, ProgramRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>ApiResponse of Program</returns>
        
        ApiResponse<Program> PutSpeechandtextanalyticsProgramWithHttpInfo (string programId, ProgramRequest body);

        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>ProgramMappings</returns>
        
        ProgramMappings PutSpeechandtextanalyticsProgramMappings (string programId, ProgramMappingsRequest body);

        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>ApiResponse of ProgramMappings</returns>
        
        ApiResponse<ProgramMappings> PutSpeechandtextanalyticsProgramMappingsWithHttpInfo (string programId, ProgramMappingsRequest body);

        /// <summary>
        /// Update AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>ProgramInsightsSettings</returns>
        
        ProgramInsightsSettings PutSpeechandtextanalyticsProgramSettingsInsights (string programId, InsightsSettingsRequest body);

        /// <summary>
        /// Update AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>ApiResponse of ProgramInsightsSettings</returns>
        
        ApiResponse<ProgramInsightsSettings> PutSpeechandtextanalyticsProgramSettingsInsightsWithHttpInfo (string programId, InsightsSettingsRequest body);

        /// <summary>
        /// Update transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>ProgramTranscriptionEngines</returns>
        
        ProgramTranscriptionEngines PutSpeechandtextanalyticsProgramTranscriptionengines (string programId, TranscriptionEnginesRequest body);

        /// <summary>
        /// Update transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>ApiResponse of ProgramTranscriptionEngines</returns>
        
        ApiResponse<ProgramTranscriptionEngines> PutSpeechandtextanalyticsProgramTranscriptionenginesWithHttpInfo (string programId, TranscriptionEnginesRequest body);

        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        
        SpeechTextAnalyticsSettingsResponse PutSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        
        ApiResponse<SpeechTextAnalyticsSettingsResponse> PutSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Topic</returns>
        
        Topic PutSpeechandtextanalyticsTopic (string topicId, TopicRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>ApiResponse of Topic</returns>
        
        ApiResponse<Topic> PutSpeechandtextanalyticsTopicWithHttpInfo (string topicId, TopicRequest body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsCategoryAsync (string categoryId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsCategoryAsyncWithHttpInfo (string categoryId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsync (string dictionaryFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo (string dictionaryFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of DeleteProgramResponse</returns>
        
        System.Threading.Tasks.Task<DeleteProgramResponse> DeleteSpeechandtextanalyticsProgramAsync (string programId, bool? forceDelete = null);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DeleteProgramResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DeleteProgramResponse>> DeleteSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, bool? forceDelete = null);

        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsSentimentfeedbackAsync ();

        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo ();

        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdAsync (string sentimentFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdAsyncWithHttpInfo (string sentimentFeedbackId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsTopicAsync (string topicId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId);

        /// <summary>
        /// Get the list of Speech and Text Analytics categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>Task of CategoriesEntityListing</returns>
        
        System.Threading.Tasks.Task<CategoriesEntityListing> GetSpeechandtextanalyticsCategoriesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null);

        /// <summary>
        /// Get the list of Speech and Text Analytics categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>Task of ApiResponse (CategoriesEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CategoriesEntityListing>> GetSpeechandtextanalyticsCategoriesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of StaCategory</returns>
        
        System.Threading.Tasks.Task<StaCategory> GetSpeechandtextanalyticsCategoryAsync (string categoryId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of ApiResponse (StaCategory)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StaCategory>> GetSpeechandtextanalyticsCategoryAsyncWithHttpInfo (string categoryId);

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
        /// Get the list of detected Speech and Text Analytics categories of conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>Task of ConversationCategoriesEntityListing</returns>
        
        System.Threading.Tasks.Task<ConversationCategoriesEntityListing> GetSpeechandtextanalyticsConversationCategoriesAsync (string conversationId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of detected Speech and Text Analytics categories of conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ConversationCategoriesEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ConversationCategoriesEntityListing>> GetSpeechandtextanalyticsConversationCategoriesAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null);

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

        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of TranscriptUrls</returns>
        
        System.Threading.Tasks.Task<TranscriptUrls> GetSpeechandtextanalyticsConversationCommunicationTranscripturlsAsync (string conversationId, string communicationId);

        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of ApiResponse (TranscriptUrls)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TranscriptUrls>> GetSpeechandtextanalyticsConversationCommunicationTranscripturlsAsyncWithHttpInfo (string conversationId, string communicationId);

        /// <summary>
        /// Get conversation summaries by conversation id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>Task of SpeechTextAnalyticsConversationSummaryListing</returns>
        
        System.Threading.Tasks.Task<SpeechTextAnalyticsConversationSummaryListing> GetSpeechandtextanalyticsConversationSummariesAsync (string conversationId);

        /// <summary>
        /// Get conversation summaries by conversation id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsConversationSummaryListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsConversationSummaryListing>> GetSpeechandtextanalyticsConversationSummariesAsyncWithHttpInfo (string conversationId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>Task of DictionaryFeedbackEntityListing</returns>
        
        System.Threading.Tasks.Task<DictionaryFeedbackEntityListing> GetSpeechandtextanalyticsDictionaryfeedbackAsync (string dialect = null, string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>Task of ApiResponse (DictionaryFeedbackEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DictionaryFeedbackEntityListing>> GetSpeechandtextanalyticsDictionaryfeedbackAsyncWithHttpInfo (string dialect = null, string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of DictionaryFeedback</returns>
        
        System.Threading.Tasks.Task<DictionaryFeedback> GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsync (string dictionaryFeedbackId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of ApiResponse (DictionaryFeedback)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DictionaryFeedback>> GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo (string dictionaryFeedbackId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of Program</returns>
        
        System.Threading.Tasks.Task<Program> GetSpeechandtextanalyticsProgramAsync (string programId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Program>> GetSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId);

        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ProgramMappings</returns>
        
        System.Threading.Tasks.Task<ProgramMappings> GetSpeechandtextanalyticsProgramMappingsAsync (string programId);

        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (ProgramMappings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramMappings>> GetSpeechandtextanalyticsProgramMappingsAsyncWithHttpInfo (string programId);

        /// <summary>
        /// Get AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ProgramInsightsSettings</returns>
        
        System.Threading.Tasks.Task<ProgramInsightsSettings> GetSpeechandtextanalyticsProgramSettingsInsightsAsync (string programId);

        /// <summary>
        /// Get AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (ProgramInsightsSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramInsightsSettings>> GetSpeechandtextanalyticsProgramSettingsInsightsAsyncWithHttpInfo (string programId);

        /// <summary>
        /// Get transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ProgramTranscriptionEngines</returns>
        
        System.Threading.Tasks.Task<ProgramTranscriptionEngines> GetSpeechandtextanalyticsProgramTranscriptionenginesAsync (string programId);

        /// <summary>
        /// Get transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (ProgramTranscriptionEngines)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramTranscriptionEngines>> GetSpeechandtextanalyticsProgramTranscriptionenginesAsyncWithHttpInfo (string programId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>Task of ProgramsEntityListing</returns>
        
        System.Threading.Tasks.Task<ProgramsEntityListing> GetSpeechandtextanalyticsProgramsAsync (string nextPage = null, int? pageSize = null, string state = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>Task of ApiResponse (ProgramsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramsEntityListing>> GetSpeechandtextanalyticsProgramsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of GeneralProgramJob</returns>
        
        System.Threading.Tasks.Task<GeneralProgramJob> GetSpeechandtextanalyticsProgramsGeneralJobAsync (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> GetSpeechandtextanalyticsProgramsGeneralJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ProgramsMappingsEntityListing</returns>
        
        System.Threading.Tasks.Task<ProgramsMappingsEntityListing> GetSpeechandtextanalyticsProgramsMappingsAsync (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (ProgramsMappingsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramsMappingsEntityListing>> GetSpeechandtextanalyticsProgramsMappingsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ProgramJob</returns>
        
        System.Threading.Tasks.Task<ProgramJob> GetSpeechandtextanalyticsProgramsPublishjobAsync (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramJob>> GetSpeechandtextanalyticsProgramsPublishjobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get the list of program AI Insights settings for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>Task of ProgramInsightsSettingsEntityListing</returns>
        
        System.Threading.Tasks.Task<ProgramInsightsSettingsEntityListing> GetSpeechandtextanalyticsProgramsSettingsInsightsAsync (int? pageSize = null, int? pageNumber = null, List<string> programIds = null);

        /// <summary>
        /// Get the list of program AI Insights settings for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>Task of ApiResponse (ProgramInsightsSettingsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramInsightsSettingsEntityListing>> GetSpeechandtextanalyticsProgramsSettingsInsightsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> programIds = null);

        /// <summary>
        /// Get supported dialects for each transcription engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SupportedDialectsEntityListing</returns>
        
        System.Threading.Tasks.Task<SupportedDialectsEntityListing> GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsAsync ();

        /// <summary>
        /// Get supported dialects for each transcription engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SupportedDialectsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SupportedDialectsEntityListing>> GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of UnpublishedProgramsEntityListing</returns>
        
        System.Threading.Tasks.Task<UnpublishedProgramsEntityListing> GetSpeechandtextanalyticsProgramsUnpublishedAsync (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (UnpublishedProgramsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UnpublishedProgramsEntityListing>> GetSpeechandtextanalyticsProgramsUnpublishedAsyncWithHttpInfo (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EntityListing</returns>
        
        System.Threading.Tasks.Task<EntityListing> GetSpeechandtextanalyticsSentimentDialectsAsync ();

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetSpeechandtextanalyticsSentimentDialectsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of SentimentFeedbackEntityListing</returns>
        
        System.Threading.Tasks.Task<SentimentFeedbackEntityListing> GetSpeechandtextanalyticsSentimentfeedbackAsync (string dialect = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (SentimentFeedbackEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SentimentFeedbackEntityListing>> GetSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo (string dialect = null);

        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        
        System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> GetSpeechandtextanalyticsSettingsAsync ();

        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> GetSpeechandtextanalyticsSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of Topic</returns>
        
        System.Threading.Tasks.Task<Topic> GetSpeechandtextanalyticsTopicAsync (string topicId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Topic>> GetSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>Task of TopicsEntityListing</returns>
        
        System.Threading.Tasks.Task<TopicsEntityListing> GetSpeechandtextanalyticsTopicsAsync (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>Task of ApiResponse (TopicsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TopicsEntityListing>> GetSpeechandtextanalyticsTopicsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EntityListing</returns>
        
        System.Threading.Tasks.Task<EntityListing> GetSpeechandtextanalyticsTopicsDialectsAsync ();

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetSpeechandtextanalyticsTopicsDialectsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of GeneralTopicsEntityListing</returns>
        
        System.Threading.Tasks.Task<GeneralTopicsEntityListing> GetSpeechandtextanalyticsTopicsGeneralAsync (string dialect = null);

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (GeneralTopicsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GeneralTopicsEntityListing>> GetSpeechandtextanalyticsTopicsGeneralAsyncWithHttpInfo (string dialect = null);

        /// <summary>
        /// Get the list of general topics from the org and the system with their current status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of UnifiedGeneralTopicEntityListing</returns>
        
        System.Threading.Tasks.Task<UnifiedGeneralTopicEntityListing> GetSpeechandtextanalyticsTopicsGeneralStatusAsync (string dialect = null);

        /// <summary>
        /// Get the list of general topics from the org and the system with their current status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (UnifiedGeneralTopicEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UnifiedGeneralTopicEntityListing>> GetSpeechandtextanalyticsTopicsGeneralStatusAsyncWithHttpInfo (string dialect = null);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of TopicJob</returns>
        
        System.Threading.Tasks.Task<TopicJob> GetSpeechandtextanalyticsTopicsPublishjobAsync (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TopicJob>> GetSpeechandtextanalyticsTopicsPublishjobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Translate a single interaction recording (or an email conversation)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>Task of CommunicationTranslationList</returns>
        
        System.Threading.Tasks.Task<CommunicationTranslationList> GetSpeechandtextanalyticsTranslationsLanguageConversationAsync (string languageId, string conversationId, string communicationId = null, string recordingId = null);

        /// <summary>
        /// Translate a single interaction recording (or an email conversation)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>Task of ApiResponse (CommunicationTranslationList)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CommunicationTranslationList>> GetSpeechandtextanalyticsTranslationsLanguageConversationAsyncWithHttpInfo (string languageId, string conversationId, string communicationId = null, string recordingId = null);

        /// <summary>
        /// Get supported translation languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TranslateSupportedLanguageList</returns>
        
        System.Threading.Tasks.Task<TranslateSupportedLanguageList> GetSpeechandtextanalyticsTranslationsLanguagesAsync ();

        /// <summary>
        /// Get supported translation languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TranslateSupportedLanguageList)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TranslateSupportedLanguageList>> GetSpeechandtextanalyticsTranslationsLanguagesAsyncWithHttpInfo ();

        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        
        System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PatchSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PatchSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>Task of StaCategory</returns>
        
        System.Threading.Tasks.Task<StaCategory> PostSpeechandtextanalyticsCategoriesAsync (CategoryRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>Task of ApiResponse (StaCategory)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StaCategory>> PostSpeechandtextanalyticsCategoriesAsyncWithHttpInfo (CategoryRequest body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>Task of DictionaryFeedback</returns>
        
        System.Threading.Tasks.Task<DictionaryFeedback> PostSpeechandtextanalyticsDictionaryfeedbackAsync (DictionaryFeedback body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>Task of ApiResponse (DictionaryFeedback)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DictionaryFeedback>> PostSpeechandtextanalyticsDictionaryfeedbackAsyncWithHttpInfo (DictionaryFeedback body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of Program</returns>
        
        System.Threading.Tasks.Task<Program> PostSpeechandtextanalyticsProgramsAsync (ProgramRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Program>> PostSpeechandtextanalyticsProgramsAsyncWithHttpInfo (ProgramRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of GeneralProgramJob</returns>
        
        System.Threading.Tasks.Task<GeneralProgramJob> PostSpeechandtextanalyticsProgramsGeneralJobsAsync (GeneralProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> PostSpeechandtextanalyticsProgramsGeneralJobsAsyncWithHttpInfo (GeneralProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ProgramJob</returns>
        
        System.Threading.Tasks.Task<ProgramJob> PostSpeechandtextanalyticsProgramsPublishjobsAsync (ProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramJob>> PostSpeechandtextanalyticsProgramsPublishjobsAsyncWithHttpInfo (ProgramJobRequest body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>Task of SentimentFeedback</returns>
        
        System.Threading.Tasks.Task<SentimentFeedback> PostSpeechandtextanalyticsSentimentfeedbackAsync (SentimentFeedback body);

        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>Task of ApiResponse (SentimentFeedback)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SentimentFeedback>> PostSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo (SentimentFeedback body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of Topic</returns>
        
        System.Threading.Tasks.Task<Topic> PostSpeechandtextanalyticsTopicsAsync (TopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Topic>> PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo (TopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of TopicJob</returns>
        
        System.Threading.Tasks.Task<TopicJob> PostSpeechandtextanalyticsTopicsPublishjobsAsync (TopicJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TopicJob>> PostSpeechandtextanalyticsTopicsPublishjobsAsyncWithHttpInfo (TopicJobRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of JsonSearchResponse</returns>
        
        System.Threading.Tasks.Task<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchAsync (TranscriptSearchRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (JsonSearchResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JsonSearchResponse>> PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo (TranscriptSearchRequest body);

        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>Task of StaCategory</returns>
        
        System.Threading.Tasks.Task<StaCategory> PutSpeechandtextanalyticsCategoryAsync (string categoryId, CategoryRequest body);

        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>Task of ApiResponse (StaCategory)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StaCategory>> PutSpeechandtextanalyticsCategoryAsyncWithHttpInfo (string categoryId, CategoryRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DictionaryFeedback</returns>
        
        System.Threading.Tasks.Task<DictionaryFeedback> PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsync (string dictionaryFeedbackId, DictionaryFeedback body = null);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DictionaryFeedback)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DictionaryFeedback>> PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo (string dictionaryFeedbackId, DictionaryFeedback body = null);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of Program</returns>
        
        System.Threading.Tasks.Task<Program> PutSpeechandtextanalyticsProgramAsync (string programId, ProgramRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Program>> PutSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, ProgramRequest body);

        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>Task of ProgramMappings</returns>
        
        System.Threading.Tasks.Task<ProgramMappings> PutSpeechandtextanalyticsProgramMappingsAsync (string programId, ProgramMappingsRequest body);

        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>Task of ApiResponse (ProgramMappings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramMappings>> PutSpeechandtextanalyticsProgramMappingsAsyncWithHttpInfo (string programId, ProgramMappingsRequest body);

        /// <summary>
        /// Update AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>Task of ProgramInsightsSettings</returns>
        
        System.Threading.Tasks.Task<ProgramInsightsSettings> PutSpeechandtextanalyticsProgramSettingsInsightsAsync (string programId, InsightsSettingsRequest body);

        /// <summary>
        /// Update AI Insights settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>Task of ApiResponse (ProgramInsightsSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramInsightsSettings>> PutSpeechandtextanalyticsProgramSettingsInsightsAsyncWithHttpInfo (string programId, InsightsSettingsRequest body);

        /// <summary>
        /// Update transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>Task of ProgramTranscriptionEngines</returns>
        
        System.Threading.Tasks.Task<ProgramTranscriptionEngines> PutSpeechandtextanalyticsProgramTranscriptionenginesAsync (string programId, TranscriptionEnginesRequest body);

        /// <summary>
        /// Update transcription engine settings of a program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>Task of ApiResponse (ProgramTranscriptionEngines)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ProgramTranscriptionEngines>> PutSpeechandtextanalyticsProgramTranscriptionenginesAsyncWithHttpInfo (string programId, TranscriptionEnginesRequest body);

        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        
        System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PutSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PutSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of Topic</returns>
        
        System.Threading.Tasks.Task<Topic> PutSpeechandtextanalyticsTopicAsync (string topicId, TopicRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Topic>> PutSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId, TopicRequest body);

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
        /// Delete a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns></returns>
        
        public void DeleteSpeechandtextanalyticsCategory (string categoryId)
        {
             DeleteSpeechandtextanalyticsCategoryWithHttpInfo(categoryId);
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSpeechandtextanalyticsCategoryWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsCategory");

            var localVarPath = "/api/v2/speechandtextanalytics/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsCategoryAsync (string categoryId)
        {
             await DeleteSpeechandtextanalyticsCategoryAsyncWithHttpInfo(categoryId);

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsCategoryAsyncWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsCategory");
            

            var localVarPath = "/api/v2/speechandtextanalytics/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns></returns>
        
        public void DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId)
        {
             DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo(dictionaryFeedbackId);
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo (string dictionaryFeedbackId)
        { 
            // verify the required parameter 'dictionaryFeedbackId' is set
            if (dictionaryFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'dictionaryFeedbackId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId");

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId}";
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
            if (dictionaryFeedbackId != null) localVarPathParams.Add("dictionaryFeedbackId", this.Configuration.ApiClient.ParameterToString(dictionaryFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsync (string dictionaryFeedbackId)
        {
             await DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo(dictionaryFeedbackId);

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics DictionaryFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo (string dictionaryFeedbackId)
        { 
            // verify the required parameter 'dictionaryFeedbackId' is set
            if (dictionaryFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'dictionaryFeedbackId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId");
            

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId}";
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
            if (dictionaryFeedbackId != null) localVarPathParams.Add("dictionaryFeedbackId", this.Configuration.ApiClient.ParameterToString(dictionaryFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>DeleteProgramResponse</returns>
        
        public DeleteProgramResponse DeleteSpeechandtextanalyticsProgram (string programId, bool? forceDelete = null)
        {
             ApiResponse<DeleteProgramResponse> localVarResponse = DeleteSpeechandtextanalyticsProgramWithHttpInfo(programId, forceDelete);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>ApiResponse of DeleteProgramResponse</returns>
        
        public ApiResponse< DeleteProgramResponse > DeleteSpeechandtextanalyticsProgramWithHttpInfo (string programId, bool? forceDelete = null)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params
            if (forceDelete != null) localVarQueryParams.Add(new Tuple<string, string>("forceDelete", this.Configuration.ApiClient.ParameterToString(forceDelete)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteProgramResponse>(localVarStatusCode,
                localVarHeaders,
                (DeleteProgramResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteProgramResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of DeleteProgramResponse</returns>
        
        public async System.Threading.Tasks.Task<DeleteProgramResponse> DeleteSpeechandtextanalyticsProgramAsync (string programId, bool? forceDelete = null)
        {
             ApiResponse<DeleteProgramResponse> localVarResponse = await DeleteSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId, forceDelete);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DeleteProgramResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DeleteProgramResponse>> DeleteSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, bool? forceDelete = null)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params
            if (forceDelete != null) localVarQueryParams.Add(new Tuple<string, string>("forceDelete", this.Configuration.ApiClient.ParameterToString(forceDelete)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteProgramResponse>(localVarStatusCode,
                localVarHeaders,
                (DeleteProgramResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteProgramResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        
        public void DeleteSpeechandtextanalyticsSentimentfeedback ()
        {
             DeleteSpeechandtextanalyticsSentimentfeedbackWithHttpInfo();
        }

        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSpeechandtextanalyticsSentimentfeedbackWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsSentimentfeedbackAsync ()
        {
             await DeleteSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete All Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns></returns>
        
        public void DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId (string sentimentFeedbackId)
        {
             DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdWithHttpInfo(sentimentFeedbackId);
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdWithHttpInfo (string sentimentFeedbackId)
        { 
            // verify the required parameter 'sentimentFeedbackId' is set
            if (sentimentFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'sentimentFeedbackId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId");

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback/{sentimentFeedbackId}";
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
            if (sentimentFeedbackId != null) localVarPathParams.Add("sentimentFeedbackId", this.Configuration.ApiClient.ParameterToString(sentimentFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdAsync (string sentimentFeedbackId)
        {
             await DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdAsyncWithHttpInfo(sentimentFeedbackId);

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics SentimentFeedback by Id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sentimentFeedbackId">The Id of the SentimentFeedback</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdAsyncWithHttpInfo (string sentimentFeedbackId)
        { 
            // verify the required parameter 'sentimentFeedbackId' is set
            if (sentimentFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'sentimentFeedbackId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId");
            

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback/{sentimentFeedbackId}";
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
            if (sentimentFeedbackId != null) localVarPathParams.Add("sentimentFeedbackId", this.Configuration.ApiClient.ParameterToString(sentimentFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns></returns>
        
        public void DeleteSpeechandtextanalyticsTopic (string topicId)
        {
             DeleteSpeechandtextanalyticsTopicWithHttpInfo(topicId);
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSpeechandtextanalyticsTopicWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsTopicAsync (string topicId)
        {
             await DeleteSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId);

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech and Text Analytics categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>CategoriesEntityListing</returns>
        
        public CategoriesEntityListing GetSpeechandtextanalyticsCategories (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null)
        {
             ApiResponse<CategoriesEntityListing> localVarResponse = GetSpeechandtextanalyticsCategoriesWithHttpInfo(pageSize, pageNumber, name, sortOrder, sortBy, ids);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech and Text Analytics categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>ApiResponse of CategoriesEntityListing</returns>
        
        public ApiResponse< CategoriesEntityListing > GetSpeechandtextanalyticsCategoriesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/categories";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (ids != null) ids.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoriesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CategoriesEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoriesEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech and Text Analytics categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>Task of CategoriesEntityListing</returns>
        
        public async System.Threading.Tasks.Task<CategoriesEntityListing> GetSpeechandtextanalyticsCategoriesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null)
        {
             ApiResponse<CategoriesEntityListing> localVarResponse = await GetSpeechandtextanalyticsCategoriesAsyncWithHttpInfo(pageSize, pageNumber, name, sortOrder, sortBy, ids);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech and Text Analytics categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 25. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="name">The category name filter applied to the listing (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional, default to asc)</param>
        /// <param name="sortBy">The field to sort by for the listing (optional, default to name)</param>
        /// <param name="ids">Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional)</param>
        /// <returns>Task of ApiResponse (CategoriesEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CategoriesEntityListing>> GetSpeechandtextanalyticsCategoriesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/categories";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (ids != null) ids.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoriesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CategoriesEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoriesEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>StaCategory</returns>
        
        public StaCategory GetSpeechandtextanalyticsCategory (string categoryId)
        {
             ApiResponse<StaCategory> localVarResponse = GetSpeechandtextanalyticsCategoryWithHttpInfo(categoryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>ApiResponse of StaCategory</returns>
        
        public ApiResponse< StaCategory > GetSpeechandtextanalyticsCategoryWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsCategory");

            var localVarPath = "/api/v2/speechandtextanalytics/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StaCategory>(localVarStatusCode,
                localVarHeaders,
                (StaCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StaCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of StaCategory</returns>
        
        public async System.Threading.Tasks.Task<StaCategory> GetSpeechandtextanalyticsCategoryAsync (string categoryId)
        {
             ApiResponse<StaCategory> localVarResponse = await GetSpeechandtextanalyticsCategoryAsyncWithHttpInfo(categoryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics Category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>Task of ApiResponse (StaCategory)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StaCategory>> GetSpeechandtextanalyticsCategoryAsyncWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsCategory");
            

            var localVarPath = "/api/v2/speechandtextanalytics/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StaCategory>(localVarStatusCode,
                localVarHeaders,
                (StaCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StaCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Get the list of detected Speech and Text Analytics categories of conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>ConversationCategoriesEntityListing</returns>
        
        public ConversationCategoriesEntityListing GetSpeechandtextanalyticsConversationCategories (string conversationId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ConversationCategoriesEntityListing> localVarResponse = GetSpeechandtextanalyticsConversationCategoriesWithHttpInfo(conversationId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of detected Speech and Text Analytics categories of conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>ApiResponse of ConversationCategoriesEntityListing</returns>
        
        public ApiResponse< ConversationCategoriesEntityListing > GetSpeechandtextanalyticsConversationCategoriesWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCategories");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/categories";
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
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationCategoriesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConversationCategoriesEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationCategoriesEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of detected Speech and Text Analytics categories of conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>Task of ConversationCategoriesEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ConversationCategoriesEntityListing> GetSpeechandtextanalyticsConversationCategoriesAsync (string conversationId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ConversationCategoriesEntityListing> localVarResponse = await GetSpeechandtextanalyticsConversationCategoriesAsyncWithHttpInfo(conversationId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of detected Speech and Text Analytics categories of conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The id of the conversation</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 50. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ConversationCategoriesEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ConversationCategoriesEntityListing>> GetSpeechandtextanalyticsConversationCategoriesAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCategories");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/categories";
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
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationCategoriesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConversationCategoriesEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationCategoriesEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
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
        /// 
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>TranscriptUrls</returns>
        
        public TranscriptUrls GetSpeechandtextanalyticsConversationCommunicationTranscripturls (string conversationId, string communicationId)
        {
             ApiResponse<TranscriptUrls> localVarResponse = GetSpeechandtextanalyticsConversationCommunicationTranscripturlsWithHttpInfo(conversationId, communicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>ApiResponse of TranscriptUrls</returns>
        
        public ApiResponse< TranscriptUrls > GetSpeechandtextanalyticsConversationCommunicationTranscripturlsWithHttpInfo (string conversationId, string communicationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturls");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturls");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturls";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranscriptUrls>(localVarStatusCode,
                localVarHeaders,
                (TranscriptUrls) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranscriptUrls)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of TranscriptUrls</returns>
        
        public async System.Threading.Tasks.Task<TranscriptUrls> GetSpeechandtextanalyticsConversationCommunicationTranscripturlsAsync (string conversationId, string communicationId)
        {
             ApiResponse<TranscriptUrls> localVarResponse = await GetSpeechandtextanalyticsConversationCommunicationTranscripturlsAsyncWithHttpInfo(conversationId, communicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of ApiResponse (TranscriptUrls)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TranscriptUrls>> GetSpeechandtextanalyticsConversationCommunicationTranscripturlsAsyncWithHttpInfo (string conversationId, string communicationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturls");
            
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturls");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturls";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranscriptUrls>(localVarStatusCode,
                localVarHeaders,
                (TranscriptUrls) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranscriptUrls)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get conversation summaries by conversation id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>SpeechTextAnalyticsConversationSummaryListing</returns>
        
        public SpeechTextAnalyticsConversationSummaryListing GetSpeechandtextanalyticsConversationSummaries (string conversationId)
        {
             ApiResponse<SpeechTextAnalyticsConversationSummaryListing> localVarResponse = GetSpeechandtextanalyticsConversationSummariesWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation summaries by conversation id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsConversationSummaryListing</returns>
        
        public ApiResponse< SpeechTextAnalyticsConversationSummaryListing > GetSpeechandtextanalyticsConversationSummariesWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationSummaries");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/summaries";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationSummaries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationSummaries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsConversationSummaryListing>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsConversationSummaryListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsConversationSummaryListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get conversation summaries by conversation id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>Task of SpeechTextAnalyticsConversationSummaryListing</returns>
        
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsConversationSummaryListing> GetSpeechandtextanalyticsConversationSummariesAsync (string conversationId)
        {
             ApiResponse<SpeechTextAnalyticsConversationSummaryListing> localVarResponse = await GetSpeechandtextanalyticsConversationSummariesAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation summaries by conversation id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">The conversation ID of the summaries</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsConversationSummaryListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsConversationSummaryListing>> GetSpeechandtextanalyticsConversationSummariesAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationSummaries");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/summaries";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationSummaries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationSummaries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsConversationSummaryListing>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsConversationSummaryListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsConversationSummaryListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>DictionaryFeedbackEntityListing</returns>
        
        public DictionaryFeedbackEntityListing GetSpeechandtextanalyticsDictionaryfeedback (string dialect = null, string nextPage = null, int? pageSize = null)
        {
             ApiResponse<DictionaryFeedbackEntityListing> localVarResponse = GetSpeechandtextanalyticsDictionaryfeedbackWithHttpInfo(dialect, nextPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>ApiResponse of DictionaryFeedbackEntityListing</returns>
        
        public ApiResponse< DictionaryFeedbackEntityListing > GetSpeechandtextanalyticsDictionaryfeedbackWithHttpInfo (string dialect = null, string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedbackEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedbackEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedbackEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>Task of DictionaryFeedbackEntityListing</returns>
        
        public async System.Threading.Tasks.Task<DictionaryFeedbackEntityListing> GetSpeechandtextanalyticsDictionaryfeedbackAsync (string dialect = null, string nextPage = null, int? pageSize = null)
        {
             ApiResponse<DictionaryFeedbackEntityListing> localVarResponse = await GetSpeechandtextanalyticsDictionaryfeedbackAsyncWithHttpInfo(dialect, nextPage, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics dictionary feedbacks 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 500)</param>
        /// <returns>Task of ApiResponse (DictionaryFeedbackEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DictionaryFeedbackEntityListing>> GetSpeechandtextanalyticsDictionaryfeedbackAsyncWithHttpInfo (string dialect = null, string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedbackEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedbackEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedbackEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>DictionaryFeedback</returns>
        
        public DictionaryFeedback GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId)
        {
             ApiResponse<DictionaryFeedback> localVarResponse = GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo(dictionaryFeedbackId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>ApiResponse of DictionaryFeedback</returns>
        
        public ApiResponse< DictionaryFeedback > GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo (string dictionaryFeedbackId)
        { 
            // verify the required parameter 'dictionaryFeedbackId' is set
            if (dictionaryFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'dictionaryFeedbackId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId");

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId}";
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
            if (dictionaryFeedbackId != null) localVarPathParams.Add("dictionaryFeedbackId", this.Configuration.ApiClient.ParameterToString(dictionaryFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedback>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of DictionaryFeedback</returns>
        
        public async System.Threading.Tasks.Task<DictionaryFeedback> GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsync (string dictionaryFeedbackId)
        {
             ApiResponse<DictionaryFeedback> localVarResponse = await GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo(dictionaryFeedbackId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <returns>Task of ApiResponse (DictionaryFeedback)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DictionaryFeedback>> GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo (string dictionaryFeedbackId)
        { 
            // verify the required parameter 'dictionaryFeedbackId' is set
            if (dictionaryFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'dictionaryFeedbackId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId");
            

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId}";
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
            if (dictionaryFeedbackId != null) localVarPathParams.Add("dictionaryFeedbackId", this.Configuration.ApiClient.ParameterToString(dictionaryFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedback>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Program</returns>
        
        public Program GetSpeechandtextanalyticsProgram (string programId)
        {
             ApiResponse<Program> localVarResponse = GetSpeechandtextanalyticsProgramWithHttpInfo(programId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of Program</returns>
        
        public ApiResponse< Program > GetSpeechandtextanalyticsProgramWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of Program</returns>
        
        public async System.Threading.Tasks.Task<Program> GetSpeechandtextanalyticsProgramAsync (string programId)
        {
             ApiResponse<Program> localVarResponse = await GetSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Program>> GetSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ProgramMappings</returns>
        
        public ProgramMappings GetSpeechandtextanalyticsProgramMappings (string programId)
        {
             ApiResponse<ProgramMappings> localVarResponse = GetSpeechandtextanalyticsProgramMappingsWithHttpInfo(programId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of ProgramMappings</returns>
        
        public ApiResponse< ProgramMappings > GetSpeechandtextanalyticsProgramMappingsWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramMappings");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/mappings";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramMappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramMappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramMappings>(localVarStatusCode,
                localVarHeaders,
                (ProgramMappings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramMappings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ProgramMappings</returns>
        
        public async System.Threading.Tasks.Task<ProgramMappings> GetSpeechandtextanalyticsProgramMappingsAsync (string programId)
        {
             ApiResponse<ProgramMappings> localVarResponse = await GetSpeechandtextanalyticsProgramMappingsAsyncWithHttpInfo(programId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Speech &amp; Text Analytics program mappings to queues and flows by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (ProgramMappings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramMappings>> GetSpeechandtextanalyticsProgramMappingsAsyncWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramMappings");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/mappings";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramMappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramMappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramMappings>(localVarStatusCode,
                localVarHeaders,
                (ProgramMappings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramMappings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ProgramInsightsSettings</returns>
        
        public ProgramInsightsSettings GetSpeechandtextanalyticsProgramSettingsInsights (string programId)
        {
             ApiResponse<ProgramInsightsSettings> localVarResponse = GetSpeechandtextanalyticsProgramSettingsInsightsWithHttpInfo(programId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of ProgramInsightsSettings</returns>
        
        public ApiResponse< ProgramInsightsSettings > GetSpeechandtextanalyticsProgramSettingsInsightsWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramSettingsInsights");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/settings/insights";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramInsightsSettings>(localVarStatusCode,
                localVarHeaders,
                (ProgramInsightsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramInsightsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ProgramInsightsSettings</returns>
        
        public async System.Threading.Tasks.Task<ProgramInsightsSettings> GetSpeechandtextanalyticsProgramSettingsInsightsAsync (string programId)
        {
             ApiResponse<ProgramInsightsSettings> localVarResponse = await GetSpeechandtextanalyticsProgramSettingsInsightsAsyncWithHttpInfo(programId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (ProgramInsightsSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramInsightsSettings>> GetSpeechandtextanalyticsProgramSettingsInsightsAsyncWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramSettingsInsights");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/settings/insights";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramInsightsSettings>(localVarStatusCode,
                localVarHeaders,
                (ProgramInsightsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramInsightsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ProgramTranscriptionEngines</returns>
        
        public ProgramTranscriptionEngines GetSpeechandtextanalyticsProgramTranscriptionengines (string programId)
        {
             ApiResponse<ProgramTranscriptionEngines> localVarResponse = GetSpeechandtextanalyticsProgramTranscriptionenginesWithHttpInfo(programId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of ProgramTranscriptionEngines</returns>
        
        public ApiResponse< ProgramTranscriptionEngines > GetSpeechandtextanalyticsProgramTranscriptionenginesWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramTranscriptionengines");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramTranscriptionEngines>(localVarStatusCode,
                localVarHeaders,
                (ProgramTranscriptionEngines) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramTranscriptionEngines)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ProgramTranscriptionEngines</returns>
        
        public async System.Threading.Tasks.Task<ProgramTranscriptionEngines> GetSpeechandtextanalyticsProgramTranscriptionenginesAsync (string programId)
        {
             ApiResponse<ProgramTranscriptionEngines> localVarResponse = await GetSpeechandtextanalyticsProgramTranscriptionenginesAsyncWithHttpInfo(programId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (ProgramTranscriptionEngines)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramTranscriptionEngines>> GetSpeechandtextanalyticsProgramTranscriptionenginesAsyncWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramTranscriptionengines");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramTranscriptionEngines>(localVarStatusCode,
                localVarHeaders,
                (ProgramTranscriptionEngines) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramTranscriptionEngines)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>ProgramsEntityListing</returns>
        
        public ProgramsEntityListing GetSpeechandtextanalyticsPrograms (string nextPage = null, int? pageSize = null, string state = null)
        {
             ApiResponse<ProgramsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsWithHttpInfo(nextPage, pageSize, state);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>ApiResponse of ProgramsEntityListing</returns>
        
        public ApiResponse< ProgramsEntityListing > GetSpeechandtextanalyticsProgramsWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>Task of ProgramsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ProgramsEntityListing> GetSpeechandtextanalyticsProgramsAsync (string nextPage = null, int? pageSize = null, string state = null)
        {
             ApiResponse<ProgramsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsAsyncWithHttpInfo(nextPage, pageSize, state);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <param name="state">Program state. Defaults to Latest (optional)</param>
        /// <returns>Task of ApiResponse (ProgramsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramsEntityListing>> GetSpeechandtextanalyticsProgramsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>GeneralProgramJob</returns>
        
        public GeneralProgramJob GetSpeechandtextanalyticsProgramsGeneralJob (string jobId)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = GetSpeechandtextanalyticsProgramsGeneralJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        
        public ApiResponse< GeneralProgramJob > GetSpeechandtextanalyticsProgramsGeneralJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsGeneralJob");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs/{jobId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of GeneralProgramJob</returns>
        
        public async System.Threading.Tasks.Task<GeneralProgramJob> GetSpeechandtextanalyticsProgramsGeneralJobAsync (string jobId)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = await GetSpeechandtextanalyticsProgramsGeneralJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> GetSpeechandtextanalyticsProgramsGeneralJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsGeneralJob");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs/{jobId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ProgramsMappingsEntityListing</returns>
        
        public ProgramsMappingsEntityListing GetSpeechandtextanalyticsProgramsMappings (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<ProgramsMappingsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsMappingsWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of ProgramsMappingsEntityListing</returns>
        
        public ApiResponse< ProgramsMappingsEntityListing > GetSpeechandtextanalyticsProgramsMappingsWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/mappings";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsMappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsMappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramsMappingsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramsMappingsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramsMappingsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ProgramsMappingsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ProgramsMappingsEntityListing> GetSpeechandtextanalyticsProgramsMappingsAsync (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<ProgramsMappingsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsMappingsAsyncWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (ProgramsMappingsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramsMappingsEntityListing>> GetSpeechandtextanalyticsProgramsMappingsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/mappings";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsMappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsMappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramsMappingsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramsMappingsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramsMappingsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ProgramJob</returns>
        
        public ProgramJob GetSpeechandtextanalyticsProgramsPublishjob (string jobId)
        {
             ApiResponse<ProgramJob> localVarResponse = GetSpeechandtextanalyticsProgramsPublishjobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        
        public ApiResponse< ProgramJob > GetSpeechandtextanalyticsProgramsPublishjobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsPublishjob");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs/{jobId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ProgramJob</returns>
        
        public async System.Threading.Tasks.Task<ProgramJob> GetSpeechandtextanalyticsProgramsPublishjobAsync (string jobId)
        {
             ApiResponse<ProgramJob> localVarResponse = await GetSpeechandtextanalyticsProgramsPublishjobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramJob>> GetSpeechandtextanalyticsProgramsPublishjobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsPublishjob");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs/{jobId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of program AI Insights settings for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>ProgramInsightsSettingsEntityListing</returns>
        
        public ProgramInsightsSettingsEntityListing GetSpeechandtextanalyticsProgramsSettingsInsights (int? pageSize = null, int? pageNumber = null, List<string> programIds = null)
        {
             ApiResponse<ProgramInsightsSettingsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsSettingsInsightsWithHttpInfo(pageSize, pageNumber, programIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of program AI Insights settings for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>ApiResponse of ProgramInsightsSettingsEntityListing</returns>
        
        public ApiResponse< ProgramInsightsSettingsEntityListing > GetSpeechandtextanalyticsProgramsSettingsInsightsWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> programIds = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/settings/insights";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (programIds != null) programIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("programIds", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsSettingsInsights: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsSettingsInsights: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramInsightsSettingsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramInsightsSettingsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramInsightsSettingsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of program AI Insights settings for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>Task of ProgramInsightsSettingsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ProgramInsightsSettingsEntityListing> GetSpeechandtextanalyticsProgramsSettingsInsightsAsync (int? pageSize = null, int? pageNumber = null, List<string> programIds = null)
        {
             ApiResponse<ProgramInsightsSettingsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsSettingsInsightsAsyncWithHttpInfo(pageSize, pageNumber, programIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of program AI Insights settings for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to 100)</param>
        /// <param name="pageNumber">The page number for the listing (optional, default to 1)</param>
        /// <param name="programIds">Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional)</param>
        /// <returns>Task of ApiResponse (ProgramInsightsSettingsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramInsightsSettingsEntityListing>> GetSpeechandtextanalyticsProgramsSettingsInsightsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> programIds = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/settings/insights";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (programIds != null) programIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("programIds", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsSettingsInsights: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsSettingsInsights: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramInsightsSettingsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramInsightsSettingsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramInsightsSettingsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get supported dialects for each transcription engine 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SupportedDialectsEntityListing</returns>
        
        public SupportedDialectsEntityListing GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects ()
        {
             ApiResponse<SupportedDialectsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported dialects for each transcription engine 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SupportedDialectsEntityListing</returns>
        
        public ApiResponse< SupportedDialectsEntityListing > GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/transcriptionengines/dialects";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedDialectsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SupportedDialectsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedDialectsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get supported dialects for each transcription engine 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SupportedDialectsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SupportedDialectsEntityListing> GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsAsync ()
        {
             ApiResponse<SupportedDialectsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get supported dialects for each transcription engine 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SupportedDialectsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SupportedDialectsEntityListing>> GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/transcriptionengines/dialects";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedDialectsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SupportedDialectsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedDialectsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>UnpublishedProgramsEntityListing</returns>
        
        public UnpublishedProgramsEntityListing GetSpeechandtextanalyticsProgramsUnpublished (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<UnpublishedProgramsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsUnpublishedWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of UnpublishedProgramsEntityListing</returns>
        
        public ApiResponse< UnpublishedProgramsEntityListing > GetSpeechandtextanalyticsProgramsUnpublishedWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/unpublished";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnpublishedProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UnpublishedProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnpublishedProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of UnpublishedProgramsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<UnpublishedProgramsEntityListing> GetSpeechandtextanalyticsProgramsUnpublishedAsync (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<UnpublishedProgramsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsUnpublishedAsyncWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (UnpublishedProgramsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UnpublishedProgramsEntityListing>> GetSpeechandtextanalyticsProgramsUnpublishedAsyncWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/unpublished";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnpublishedProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UnpublishedProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnpublishedProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EntityListing</returns>
        
        public EntityListing GetSpeechandtextanalyticsSentimentDialects ()
        {
             ApiResponse<EntityListing> localVarResponse = GetSpeechandtextanalyticsSentimentDialectsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EntityListing</returns>
        
        public ApiResponse< EntityListing > GetSpeechandtextanalyticsSentimentDialectsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/sentiment/dialects";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EntityListing</returns>
        
        public async System.Threading.Tasks.Task<EntityListing> GetSpeechandtextanalyticsSentimentDialectsAsync ()
        {
             ApiResponse<EntityListing> localVarResponse = await GetSpeechandtextanalyticsSentimentDialectsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics sentiment supported dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetSpeechandtextanalyticsSentimentDialectsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/sentiment/dialects";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>SentimentFeedbackEntityListing</returns>
        
        public SentimentFeedbackEntityListing GetSpeechandtextanalyticsSentimentfeedback (string dialect = null)
        {
             ApiResponse<SentimentFeedbackEntityListing> localVarResponse = GetSpeechandtextanalyticsSentimentfeedbackWithHttpInfo(dialect);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of SentimentFeedbackEntityListing</returns>
        
        public ApiResponse< SentimentFeedbackEntityListing > GetSpeechandtextanalyticsSentimentfeedbackWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SentimentFeedbackEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SentimentFeedbackEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentimentFeedbackEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of SentimentFeedbackEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SentimentFeedbackEntityListing> GetSpeechandtextanalyticsSentimentfeedbackAsync (string dialect = null)
        {
             ApiResponse<SentimentFeedbackEntityListing> localVarResponse = await GetSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo(dialect);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (SentimentFeedbackEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SentimentFeedbackEntityListing>> GetSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SentimentFeedbackEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SentimentFeedbackEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentimentFeedbackEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        
        public SpeechTextAnalyticsSettingsResponse GetSpeechandtextanalyticsSettings ()
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = GetSpeechandtextanalyticsSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        
        public ApiResponse< SpeechTextAnalyticsSettingsResponse > GetSpeechandtextanalyticsSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> GetSpeechandtextanalyticsSettingsAsync ()
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = await GetSpeechandtextanalyticsSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> GetSpeechandtextanalyticsSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Topic</returns>
        
        public Topic GetSpeechandtextanalyticsTopic (string topicId)
        {
             ApiResponse<Topic> localVarResponse = GetSpeechandtextanalyticsTopicWithHttpInfo(topicId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Topic</returns>
        
        public ApiResponse< Topic > GetSpeechandtextanalyticsTopicWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of Topic</returns>
        
        public async System.Threading.Tasks.Task<Topic> GetSpeechandtextanalyticsTopicAsync (string topicId)
        {
             ApiResponse<Topic> localVarResponse = await GetSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> GetSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Get the list of Speech &amp; Text Analytics topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>TopicsEntityListing</returns>
        
        public TopicsEntityListing GetSpeechandtextanalyticsTopics (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TopicsEntityListing> localVarResponse = GetSpeechandtextanalyticsTopicsWithHttpInfo(nextPage, pageSize, state, name, ids, dialects, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>ApiResponse of TopicsEntityListing</returns>
        
        public ApiResponse< TopicsEntityListing > GetSpeechandtextanalyticsTopicsWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (ids != null) ids.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (dialects != null) dialects.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("dialects", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>Task of TopicsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<TopicsEntityListing> GetSpeechandtextanalyticsTopicsAsync (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TopicsEntityListing> localVarResponse = await GetSpeechandtextanalyticsTopicsAsyncWithHttpInfo(nextPage, pageSize, state, name, ids, dialects, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 500. (optional, default to 20)</param>
        /// <param name="state">Topic state. Defaults to latest (optional)</param>
        /// <param name="name">Case insensitive partial name to filter by (optional)</param>
        /// <param name="ids">Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional)</param>
        /// <param name="dialects">Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional)</param>
        /// <param name="sortBy">Sort results by. Defaults to name (optional)</param>
        /// <param name="sortOrder">Sort order. Defaults to asc (optional)</param>
        /// <returns>Task of ApiResponse (TopicsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TopicsEntityListing>> GetSpeechandtextanalyticsTopicsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (ids != null) ids.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (dialects != null) dialects.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("dialects", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EntityListing</returns>
        
        public EntityListing GetSpeechandtextanalyticsTopicsDialects ()
        {
             ApiResponse<EntityListing> localVarResponse = GetSpeechandtextanalyticsTopicsDialectsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EntityListing</returns>
        
        public ApiResponse< EntityListing > GetSpeechandtextanalyticsTopicsDialectsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/dialects";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EntityListing</returns>
        
        public async System.Threading.Tasks.Task<EntityListing> GetSpeechandtextanalyticsTopicsDialectsAsync ()
        {
             ApiResponse<EntityListing> localVarResponse = await GetSpeechandtextanalyticsTopicsDialectsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics topics dialects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetSpeechandtextanalyticsTopicsDialectsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/dialects";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>GeneralTopicsEntityListing</returns>
        
        public GeneralTopicsEntityListing GetSpeechandtextanalyticsTopicsGeneral (string dialect = null)
        {
             ApiResponse<GeneralTopicsEntityListing> localVarResponse = GetSpeechandtextanalyticsTopicsGeneralWithHttpInfo(dialect);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of GeneralTopicsEntityListing</returns>
        
        public ApiResponse< GeneralTopicsEntityListing > GetSpeechandtextanalyticsTopicsGeneralWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/general";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralTopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (GeneralTopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralTopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of GeneralTopicsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<GeneralTopicsEntityListing> GetSpeechandtextanalyticsTopicsGeneralAsync (string dialect = null)
        {
             ApiResponse<GeneralTopicsEntityListing> localVarResponse = await GetSpeechandtextanalyticsTopicsGeneralAsyncWithHttpInfo(dialect);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (GeneralTopicsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GeneralTopicsEntityListing>> GetSpeechandtextanalyticsTopicsGeneralAsyncWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/general";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralTopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (GeneralTopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralTopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of general topics from the org and the system with their current status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>UnifiedGeneralTopicEntityListing</returns>
        
        public UnifiedGeneralTopicEntityListing GetSpeechandtextanalyticsTopicsGeneralStatus (string dialect = null)
        {
             ApiResponse<UnifiedGeneralTopicEntityListing> localVarResponse = GetSpeechandtextanalyticsTopicsGeneralStatusWithHttpInfo(dialect);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of general topics from the org and the system with their current status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of UnifiedGeneralTopicEntityListing</returns>
        
        public ApiResponse< UnifiedGeneralTopicEntityListing > GetSpeechandtextanalyticsTopicsGeneralStatusWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/general/status";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneralStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneralStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnifiedGeneralTopicEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UnifiedGeneralTopicEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnifiedGeneralTopicEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of general topics from the org and the system with their current status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of UnifiedGeneralTopicEntityListing</returns>
        
        public async System.Threading.Tasks.Task<UnifiedGeneralTopicEntityListing> GetSpeechandtextanalyticsTopicsGeneralStatusAsync (string dialect = null)
        {
             ApiResponse<UnifiedGeneralTopicEntityListing> localVarResponse = await GetSpeechandtextanalyticsTopicsGeneralStatusAsyncWithHttpInfo(dialect);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of general topics from the org and the system with their current status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (UnifiedGeneralTopicEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UnifiedGeneralTopicEntityListing>> GetSpeechandtextanalyticsTopicsGeneralStatusAsyncWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/general/status";
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
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneralStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneralStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnifiedGeneralTopicEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UnifiedGeneralTopicEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnifiedGeneralTopicEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>TopicJob</returns>
        
        public TopicJob GetSpeechandtextanalyticsTopicsPublishjob (string jobId)
        {
             ApiResponse<TopicJob> localVarResponse = GetSpeechandtextanalyticsTopicsPublishjobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>ApiResponse of TopicJob</returns>
        
        public ApiResponse< TopicJob > GetSpeechandtextanalyticsTopicsPublishjobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopicsPublishjob");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs/{jobId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of TopicJob</returns>
        
        public async System.Threading.Tasks.Task<TopicJob> GetSpeechandtextanalyticsTopicsPublishjobAsync (string jobId)
        {
             ApiResponse<TopicJob> localVarResponse = await GetSpeechandtextanalyticsTopicsPublishjobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TopicJob>> GetSpeechandtextanalyticsTopicsPublishjobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopicsPublishjob");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs/{jobId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Translate a single interaction recording (or an email conversation) 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>CommunicationTranslationList</returns>
        
        public CommunicationTranslationList GetSpeechandtextanalyticsTranslationsLanguageConversation (string languageId, string conversationId, string communicationId = null, string recordingId = null)
        {
             ApiResponse<CommunicationTranslationList> localVarResponse = GetSpeechandtextanalyticsTranslationsLanguageConversationWithHttpInfo(languageId, conversationId, communicationId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Translate a single interaction recording (or an email conversation) 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>ApiResponse of CommunicationTranslationList</returns>
        
        public ApiResponse< CommunicationTranslationList > GetSpeechandtextanalyticsTranslationsLanguageConversationWithHttpInfo (string languageId, string conversationId, string communicationId = null, string recordingId = null)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTranslationsLanguageConversation");
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTranslationsLanguageConversation");

            var localVarPath = "/api/v2/speechandtextanalytics/translations/languages/{languageId}/conversations/{conversationId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params
            if (communicationId != null) localVarQueryParams.Add(new Tuple<string, string>("communicationId", this.Configuration.ApiClient.ParameterToString(communicationId)));
            if (recordingId != null) localVarQueryParams.Add(new Tuple<string, string>("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguageConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguageConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommunicationTranslationList>(localVarStatusCode,
                localVarHeaders,
                (CommunicationTranslationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommunicationTranslationList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Translate a single interaction recording (or an email conversation) 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>Task of CommunicationTranslationList</returns>
        
        public async System.Threading.Tasks.Task<CommunicationTranslationList> GetSpeechandtextanalyticsTranslationsLanguageConversationAsync (string languageId, string conversationId, string communicationId = null, string recordingId = null)
        {
             ApiResponse<CommunicationTranslationList> localVarResponse = await GetSpeechandtextanalyticsTranslationsLanguageConversationAsyncWithHttpInfo(languageId, conversationId, communicationId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Translate a single interaction recording (or an email conversation) 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Target translation language</param>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="communicationId">Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional)</param>
        /// <param name="recordingId">Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional)</param>
        /// <returns>Task of ApiResponse (CommunicationTranslationList)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CommunicationTranslationList>> GetSpeechandtextanalyticsTranslationsLanguageConversationAsyncWithHttpInfo (string languageId, string conversationId, string communicationId = null, string recordingId = null)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTranslationsLanguageConversation");
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTranslationsLanguageConversation");
            

            var localVarPath = "/api/v2/speechandtextanalytics/translations/languages/{languageId}/conversations/{conversationId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params
            if (communicationId != null) localVarQueryParams.Add(new Tuple<string, string>("communicationId", this.Configuration.ApiClient.ParameterToString(communicationId)));
            if (recordingId != null) localVarQueryParams.Add(new Tuple<string, string>("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguageConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguageConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommunicationTranslationList>(localVarStatusCode,
                localVarHeaders,
                (CommunicationTranslationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommunicationTranslationList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get supported translation languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TranslateSupportedLanguageList</returns>
        
        public TranslateSupportedLanguageList GetSpeechandtextanalyticsTranslationsLanguages ()
        {
             ApiResponse<TranslateSupportedLanguageList> localVarResponse = GetSpeechandtextanalyticsTranslationsLanguagesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported translation languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TranslateSupportedLanguageList</returns>
        
        public ApiResponse< TranslateSupportedLanguageList > GetSpeechandtextanalyticsTranslationsLanguagesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/translations/languages";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranslateSupportedLanguageList>(localVarStatusCode,
                localVarHeaders,
                (TranslateSupportedLanguageList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranslateSupportedLanguageList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get supported translation languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TranslateSupportedLanguageList</returns>
        
        public async System.Threading.Tasks.Task<TranslateSupportedLanguageList> GetSpeechandtextanalyticsTranslationsLanguagesAsync ()
        {
             ApiResponse<TranslateSupportedLanguageList> localVarResponse = await GetSpeechandtextanalyticsTranslationsLanguagesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get supported translation languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TranslateSupportedLanguageList)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TranslateSupportedLanguageList>> GetSpeechandtextanalyticsTranslationsLanguagesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/translations/languages";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTranslationsLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranslateSupportedLanguageList>(localVarStatusCode,
                localVarHeaders,
                (TranslateSupportedLanguageList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranslateSupportedLanguageList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        
        public SpeechTextAnalyticsSettingsResponse PatchSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = PatchSpeechandtextanalyticsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        
        public ApiResponse< SpeechTextAnalyticsSettingsResponse > PatchSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PatchSpeechandtextanalyticsSettings");

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PatchSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = await PatchSpeechandtextanalyticsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PatchSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PatchSpeechandtextanalyticsSettings");
            

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create new Speech &amp; Text Analytics category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>StaCategory</returns>
        
        public StaCategory PostSpeechandtextanalyticsCategories (CategoryRequest body)
        {
             ApiResponse<StaCategory> localVarResponse = PostSpeechandtextanalyticsCategoriesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>ApiResponse of StaCategory</returns>
        
        public ApiResponse< StaCategory > PostSpeechandtextanalyticsCategoriesWithHttpInfo (CategoryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsCategories");

            var localVarPath = "/api/v2/speechandtextanalytics/categories";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StaCategory>(localVarStatusCode,
                localVarHeaders,
                (StaCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StaCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create new Speech &amp; Text Analytics category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>Task of StaCategory</returns>
        
        public async System.Threading.Tasks.Task<StaCategory> PostSpeechandtextanalyticsCategoriesAsync (CategoryRequest body)
        {
             ApiResponse<StaCategory> localVarResponse = await PostSpeechandtextanalyticsCategoriesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The category to create</param>
        /// <returns>Task of ApiResponse (StaCategory)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StaCategory>> PostSpeechandtextanalyticsCategoriesAsyncWithHttpInfo (CategoryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsCategories");
            

            var localVarPath = "/api/v2/speechandtextanalytics/categories";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StaCategory>(localVarStatusCode,
                localVarHeaders,
                (StaCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StaCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>DictionaryFeedback</returns>
        
        public DictionaryFeedback PostSpeechandtextanalyticsDictionaryfeedback (DictionaryFeedback body)
        {
             ApiResponse<DictionaryFeedback> localVarResponse = PostSpeechandtextanalyticsDictionaryfeedbackWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>ApiResponse of DictionaryFeedback</returns>
        
        public ApiResponse< DictionaryFeedback > PostSpeechandtextanalyticsDictionaryfeedbackWithHttpInfo (DictionaryFeedback body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsDictionaryfeedback");

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedback>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>Task of DictionaryFeedback</returns>
        
        public async System.Threading.Tasks.Task<DictionaryFeedback> PostSpeechandtextanalyticsDictionaryfeedbackAsync (DictionaryFeedback body)
        {
             ApiResponse<DictionaryFeedback> localVarResponse = await PostSpeechandtextanalyticsDictionaryfeedbackAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Speech &amp; Text Analytics DictionaryFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The DictionaryFeedback to create</param>
        /// <returns>Task of ApiResponse (DictionaryFeedback)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DictionaryFeedback>> PostSpeechandtextanalyticsDictionaryfeedbackAsyncWithHttpInfo (DictionaryFeedback body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsDictionaryfeedback");
            

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsDictionaryfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedback>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Program</returns>
        
        public Program PostSpeechandtextanalyticsPrograms (ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = PostSpeechandtextanalyticsProgramsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>ApiResponse of Program</returns>
        
        public ApiResponse< Program > PostSpeechandtextanalyticsProgramsWithHttpInfo (ProgramRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsPrograms");

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of Program</returns>
        
        public async System.Threading.Tasks.Task<Program> PostSpeechandtextanalyticsProgramsAsync (ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = await PostSpeechandtextanalyticsProgramsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Program>> PostSpeechandtextanalyticsProgramsAsyncWithHttpInfo (ProgramRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsPrograms");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>GeneralProgramJob</returns>
        
        public GeneralProgramJob PostSpeechandtextanalyticsProgramsGeneralJobs (GeneralProgramJobRequest body)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = PostSpeechandtextanalyticsProgramsGeneralJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        
        public ApiResponse< GeneralProgramJob > PostSpeechandtextanalyticsProgramsGeneralJobsWithHttpInfo (GeneralProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsGeneralJobs");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of GeneralProgramJob</returns>
        
        public async System.Threading.Tasks.Task<GeneralProgramJob> PostSpeechandtextanalyticsProgramsGeneralJobsAsync (GeneralProgramJobRequest body)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = await PostSpeechandtextanalyticsProgramsGeneralJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> PostSpeechandtextanalyticsProgramsGeneralJobsAsyncWithHttpInfo (GeneralProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsGeneralJobs");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ProgramJob</returns>
        
        public ProgramJob PostSpeechandtextanalyticsProgramsPublishjobs (ProgramJobRequest body)
        {
             ApiResponse<ProgramJob> localVarResponse = PostSpeechandtextanalyticsProgramsPublishjobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        
        public ApiResponse< ProgramJob > PostSpeechandtextanalyticsProgramsPublishjobsWithHttpInfo (ProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsPublishjobs");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ProgramJob</returns>
        
        public async System.Threading.Tasks.Task<ProgramJob> PostSpeechandtextanalyticsProgramsPublishjobsAsync (ProgramJobRequest body)
        {
             ApiResponse<ProgramJob> localVarResponse = await PostSpeechandtextanalyticsProgramsPublishjobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramJob>> PostSpeechandtextanalyticsProgramsPublishjobsAsyncWithHttpInfo (ProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsPublishjobs");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>SentimentFeedback</returns>
        
        public SentimentFeedback PostSpeechandtextanalyticsSentimentfeedback (SentimentFeedback body)
        {
             ApiResponse<SentimentFeedback> localVarResponse = PostSpeechandtextanalyticsSentimentfeedbackWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>ApiResponse of SentimentFeedback</returns>
        
        public ApiResponse< SentimentFeedback > PostSpeechandtextanalyticsSentimentfeedbackWithHttpInfo (SentimentFeedback body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsSentimentfeedback");

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SentimentFeedback>(localVarStatusCode,
                localVarHeaders,
                (SentimentFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentimentFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>Task of SentimentFeedback</returns>
        
        public async System.Threading.Tasks.Task<SentimentFeedback> PostSpeechandtextanalyticsSentimentfeedbackAsync (SentimentFeedback body)
        {
             ApiResponse<SentimentFeedback> localVarResponse = await PostSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Speech &amp; Text Analytics SentimentFeedback 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The SentimentFeedback to create</param>
        /// <returns>Task of ApiResponse (SentimentFeedback)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SentimentFeedback>> PostSpeechandtextanalyticsSentimentfeedbackAsyncWithHttpInfo (SentimentFeedback body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsSentimentfeedback");
            

            var localVarPath = "/api/v2/speechandtextanalytics/sentimentfeedback";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsSentimentfeedback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SentimentFeedback>(localVarStatusCode,
                localVarHeaders,
                (SentimentFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentimentFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Topic</returns>
        
        public Topic PostSpeechandtextanalyticsTopics (TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = PostSpeechandtextanalyticsTopicsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>ApiResponse of Topic</returns>
        
        public ApiResponse< Topic > PostSpeechandtextanalyticsTopicsWithHttpInfo (TopicRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopics");

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
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
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of Topic</returns>
        
        public async System.Threading.Tasks.Task<Topic> PostSpeechandtextanalyticsTopicsAsync (TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = await PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo (TopicRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopics");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
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
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>TopicJob</returns>
        
        public TopicJob PostSpeechandtextanalyticsTopicsPublishjobs (TopicJobRequest body)
        {
             ApiResponse<TopicJob> localVarResponse = PostSpeechandtextanalyticsTopicsPublishjobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>ApiResponse of TopicJob</returns>
        
        public ApiResponse< TopicJob > PostSpeechandtextanalyticsTopicsPublishjobsWithHttpInfo (TopicJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopicsPublishjobs");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of TopicJob</returns>
        
        public async System.Threading.Tasks.Task<TopicJob> PostSpeechandtextanalyticsTopicsPublishjobsAsync (TopicJobRequest body)
        {
             ApiResponse<TopicJob> localVarResponse = await PostSpeechandtextanalyticsTopicsPublishjobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TopicJob>> PostSpeechandtextanalyticsTopicsPublishjobsAsyncWithHttpInfo (TopicJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopicsPublishjobs");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>JsonSearchResponse</returns>
        
        public JsonSearchResponse PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body)
        {
             ApiResponse<JsonSearchResponse> localVarResponse = PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of JsonSearchResponse</returns>
        
        public ApiResponse< JsonSearchResponse > PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo (TranscriptSearchRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTranscriptsSearch");

            var localVarPath = "/api/v2/speechandtextanalytics/transcripts/search";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of JsonSearchResponse</returns>
        
        public async System.Threading.Tasks.Task<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchAsync (TranscriptSearchRequest body)
        {
             ApiResponse<JsonSearchResponse> localVarResponse = await PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (JsonSearchResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JsonSearchResponse>> PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo (TranscriptSearchRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTranscriptsSearch");
            

            var localVarPath = "/api/v2/speechandtextanalytics/transcripts/search";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>StaCategory</returns>
        
        public StaCategory PutSpeechandtextanalyticsCategory (string categoryId, CategoryRequest body)
        {
             ApiResponse<StaCategory> localVarResponse = PutSpeechandtextanalyticsCategoryWithHttpInfo(categoryId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>ApiResponse of StaCategory</returns>
        
        public ApiResponse< StaCategory > PutSpeechandtextanalyticsCategoryWithHttpInfo (string categoryId, CategoryRequest body)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsCategory");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsCategory");

            var localVarPath = "/api/v2/speechandtextanalytics/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StaCategory>(localVarStatusCode,
                localVarHeaders,
                (StaCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StaCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>Task of StaCategory</returns>
        
        public async System.Threading.Tasks.Task<StaCategory> PutSpeechandtextanalyticsCategoryAsync (string categoryId, CategoryRequest body)
        {
             ApiResponse<StaCategory> localVarResponse = await PutSpeechandtextanalyticsCategoryAsyncWithHttpInfo(categoryId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Speech &amp; Text Analytics category by ID 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="body">The updated category</param>
        /// <returns>Task of ApiResponse (StaCategory)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StaCategory>> PutSpeechandtextanalyticsCategoryAsyncWithHttpInfo (string categoryId, CategoryRequest body)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsCategory");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsCategory");
            

            var localVarPath = "/api/v2/speechandtextanalytics/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StaCategory>(localVarStatusCode,
                localVarHeaders,
                (StaCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StaCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DictionaryFeedback</returns>
        
        public DictionaryFeedback PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId, DictionaryFeedback body = null)
        {
             ApiResponse<DictionaryFeedback> localVarResponse = PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo(dictionaryFeedbackId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DictionaryFeedback</returns>
        
        public ApiResponse< DictionaryFeedback > PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdWithHttpInfo (string dictionaryFeedbackId, DictionaryFeedback body = null)
        { 
            // verify the required parameter 'dictionaryFeedbackId' is set
            if (dictionaryFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'dictionaryFeedbackId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId");

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId}";
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
            if (dictionaryFeedbackId != null) localVarPathParams.Add("dictionaryFeedbackId", this.Configuration.ApiClient.ParameterToString(dictionaryFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedback>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DictionaryFeedback</returns>
        
        public async System.Threading.Tasks.Task<DictionaryFeedback> PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsync (string dictionaryFeedbackId, DictionaryFeedback body = null)
        {
             ApiResponse<DictionaryFeedback> localVarResponse = await PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo(dictionaryFeedbackId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics dictionary feedback by id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dictionaryFeedbackId">The Id of the Dictionary Feedback</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DictionaryFeedback)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DictionaryFeedback>> PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdAsyncWithHttpInfo (string dictionaryFeedbackId, DictionaryFeedback body = null)
        { 
            // verify the required parameter 'dictionaryFeedbackId' is set
            if (dictionaryFeedbackId == null)
                throw new ApiException(400, "Missing required parameter 'dictionaryFeedbackId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId");
            

            var localVarPath = "/api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId}";
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
            if (dictionaryFeedbackId != null) localVarPathParams.Add("dictionaryFeedbackId", this.Configuration.ApiClient.ParameterToString(dictionaryFeedbackId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DictionaryFeedback>(localVarStatusCode,
                localVarHeaders,
                (DictionaryFeedback) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DictionaryFeedback)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Program</returns>
        
        public Program PutSpeechandtextanalyticsProgram (string programId, ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = PutSpeechandtextanalyticsProgramWithHttpInfo(programId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>ApiResponse of Program</returns>
        
        public ApiResponse< Program > PutSpeechandtextanalyticsProgramWithHttpInfo (string programId, ProgramRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of Program</returns>
        
        public async System.Threading.Tasks.Task<Program> PutSpeechandtextanalyticsProgramAsync (string programId, ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = await PutSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Program>> PutSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, ProgramRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>ProgramMappings</returns>
        
        public ProgramMappings PutSpeechandtextanalyticsProgramMappings (string programId, ProgramMappingsRequest body)
        {
             ApiResponse<ProgramMappings> localVarResponse = PutSpeechandtextanalyticsProgramMappingsWithHttpInfo(programId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>ApiResponse of ProgramMappings</returns>
        
        public ApiResponse< ProgramMappings > PutSpeechandtextanalyticsProgramMappingsWithHttpInfo (string programId, ProgramMappingsRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramMappings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramMappings");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/mappings";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramMappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramMappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramMappings>(localVarStatusCode,
                localVarHeaders,
                (ProgramMappings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramMappings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>Task of ProgramMappings</returns>
        
        public async System.Threading.Tasks.Task<ProgramMappings> PutSpeechandtextanalyticsProgramMappingsAsync (string programId, ProgramMappingsRequest body)
        {
             ApiResponse<ProgramMappings> localVarResponse = await PutSpeechandtextanalyticsProgramMappingsAsyncWithHttpInfo(programId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set Speech &amp; Text Analytics program mappings to queues and flows 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to set mappings for</param>
        /// <returns>Task of ApiResponse (ProgramMappings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramMappings>> PutSpeechandtextanalyticsProgramMappingsAsyncWithHttpInfo (string programId, ProgramMappingsRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramMappings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramMappings");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/mappings";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramMappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramMappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramMappings>(localVarStatusCode,
                localVarHeaders,
                (ProgramMappings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramMappings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>ProgramInsightsSettings</returns>
        
        public ProgramInsightsSettings PutSpeechandtextanalyticsProgramSettingsInsights (string programId, InsightsSettingsRequest body)
        {
             ApiResponse<ProgramInsightsSettings> localVarResponse = PutSpeechandtextanalyticsProgramSettingsInsightsWithHttpInfo(programId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>ApiResponse of ProgramInsightsSettings</returns>
        
        public ApiResponse< ProgramInsightsSettings > PutSpeechandtextanalyticsProgramSettingsInsightsWithHttpInfo (string programId, InsightsSettingsRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramSettingsInsights");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramSettingsInsights");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/settings/insights";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramInsightsSettings>(localVarStatusCode,
                localVarHeaders,
                (ProgramInsightsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramInsightsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>Task of ProgramInsightsSettings</returns>
        
        public async System.Threading.Tasks.Task<ProgramInsightsSettings> PutSpeechandtextanalyticsProgramSettingsInsightsAsync (string programId, InsightsSettingsRequest body)
        {
             ApiResponse<ProgramInsightsSettings> localVarResponse = await PutSpeechandtextanalyticsProgramSettingsInsightsAsyncWithHttpInfo(programId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update AI Insights settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program AI Insights setting</param>
        /// <returns>Task of ApiResponse (ProgramInsightsSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramInsightsSettings>> PutSpeechandtextanalyticsProgramSettingsInsightsAsyncWithHttpInfo (string programId, InsightsSettingsRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramSettingsInsights");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramSettingsInsights");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/settings/insights";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramSettingsInsights: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramInsightsSettings>(localVarStatusCode,
                localVarHeaders,
                (ProgramInsightsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramInsightsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>ProgramTranscriptionEngines</returns>
        
        public ProgramTranscriptionEngines PutSpeechandtextanalyticsProgramTranscriptionengines (string programId, TranscriptionEnginesRequest body)
        {
             ApiResponse<ProgramTranscriptionEngines> localVarResponse = PutSpeechandtextanalyticsProgramTranscriptionenginesWithHttpInfo(programId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>ApiResponse of ProgramTranscriptionEngines</returns>
        
        public ApiResponse< ProgramTranscriptionEngines > PutSpeechandtextanalyticsProgramTranscriptionenginesWithHttpInfo (string programId, TranscriptionEnginesRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramTranscriptionengines");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramTranscriptionengines");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramTranscriptionEngines>(localVarStatusCode,
                localVarHeaders,
                (ProgramTranscriptionEngines) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramTranscriptionEngines)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>Task of ProgramTranscriptionEngines</returns>
        
        public async System.Threading.Tasks.Task<ProgramTranscriptionEngines> PutSpeechandtextanalyticsProgramTranscriptionenginesAsync (string programId, TranscriptionEnginesRequest body)
        {
             ApiResponse<ProgramTranscriptionEngines> localVarResponse = await PutSpeechandtextanalyticsProgramTranscriptionenginesAsyncWithHttpInfo(programId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update transcription engine settings of a program 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">Program transcription engine setting</param>
        /// <returns>Task of ApiResponse (ProgramTranscriptionEngines)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ProgramTranscriptionEngines>> PutSpeechandtextanalyticsProgramTranscriptionenginesAsyncWithHttpInfo (string programId, TranscriptionEnginesRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramTranscriptionengines");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgramTranscriptionengines");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines";
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
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgramTranscriptionengines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramTranscriptionEngines>(localVarStatusCode,
                localVarHeaders,
                (ProgramTranscriptionEngines) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramTranscriptionEngines)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        
        public SpeechTextAnalyticsSettingsResponse PutSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = PutSpeechandtextanalyticsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        
        public ApiResponse< SpeechTextAnalyticsSettingsResponse > PutSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsSettings");

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PutSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = await PutSpeechandtextanalyticsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PutSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsSettings");
            

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Topic</returns>
        
        public Topic PutSpeechandtextanalyticsTopic (string topicId, TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = PutSpeechandtextanalyticsTopicWithHttpInfo(topicId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>ApiResponse of Topic</returns>
        
        public ApiResponse< Topic > PutSpeechandtextanalyticsTopicWithHttpInfo (string topicId, TopicRequest body)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of Topic</returns>
        
        public async System.Threading.Tasks.Task<Topic> PutSpeechandtextanalyticsTopicAsync (string topicId, TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = await PutSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> PutSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId, TopicRequest body)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
