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
    public interface IRecordingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns></returns>
        void DeleteConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteConversationRecordingAnnotationWithHttpInfo (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        OrphanRecording DeleteOrphanrecording (string orphanId);

        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        ApiResponse<OrphanRecording> DeleteOrphanrecordingWithHttpInfo (string orphanId);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns></returns>
        void DeleteRecordingCrossplatformMediaretentionpolicies (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRecordingCrossplatformMediaretentionpoliciesWithHttpInfo (string ids);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns></returns>
        void DeleteRecordingCrossplatformMediaretentionpolicy (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Delete the recording bulk job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns></returns>
        void DeleteRecordingJob (string jobId);

        /// <summary>
        /// Delete the recording bulk job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRecordingJobWithHttpInfo (string jobId);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns></returns>
        void DeleteRecordingMediaretentionpolicies (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRecordingMediaretentionpoliciesWithHttpInfo (string ids);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns></returns>
        void DeleteRecordingMediaretentionpolicy (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRecordingMediaretentionpolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Recording</returns>
        Recording GetConversationRecording (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> GetConversationRecordingWithHttpInfo (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Annotation</returns>
        Annotation GetConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> GetConversationRecordingAnnotationWithHttpInfo (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        List<Annotation> GetConversationRecordingAnnotations (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        ApiResponse<List<Annotation>> GetConversationRecordingAnnotationsWithHttpInfo (string conversationId, string recordingId);

        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>List&lt;RecordingMetadata&gt;</returns>
        List<RecordingMetadata> GetConversationRecordingmetadata (string conversationId);

        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of List&lt;RecordingMetadata&gt;</returns>
        ApiResponse<List<RecordingMetadata>> GetConversationRecordingmetadataWithHttpInfo (string conversationId);

        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>RecordingMetadata</returns>
        RecordingMetadata GetConversationRecordingmetadataRecordingId (string conversationId, string recordingId);

        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of RecordingMetadata</returns>
        ApiResponse<RecordingMetadata> GetConversationRecordingmetadataRecordingIdWithHttpInfo (string conversationId, string recordingId);

        /// <summary>
        /// Get all of a Conversation's Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        List<Recording> GetConversationRecordings (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null);

        /// <summary>
        /// Get all of a Conversation's Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        ApiResponse<List<Recording>> GetConversationRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        OrphanRecording GetOrphanrecording (string orphanId);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        ApiResponse<OrphanRecording> GetOrphanrecordingWithHttpInfo (string orphanId);

        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Recording</returns>
        Recording GetOrphanrecordingMedia (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> GetOrphanrecordingMediaWithHttpInfo (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>OrphanRecordingListing</returns>
        OrphanRecordingListing GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null);

        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>ApiResponse of OrphanRecordingListing</returns>
        ApiResponse<OrphanRecordingListing> GetOrphanrecordingsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null);

        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>BatchDownloadJobStatusResult</returns>
        BatchDownloadJobStatusResult GetRecordingBatchrequest (string jobId);

        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of BatchDownloadJobStatusResult</returns>
        ApiResponse<BatchDownloadJobStatusResult> GetRecordingBatchrequestWithHttpInfo (string jobId);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        PolicyEntityListing GetRecordingCrossplatformMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        ApiResponse<PolicyEntityListing> GetRecordingCrossplatformMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>CrossPlatformPolicy</returns>
        CrossPlatformPolicy GetRecordingCrossplatformMediaretentionpolicy (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        ApiResponse<CrossPlatformPolicy> GetRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Get the status of the job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>RecordingJob</returns>
        RecordingJob GetRecordingJob (string jobId);

        /// <summary>
        /// Get the status of the job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of RecordingJob</returns>
        ApiResponse<RecordingJob> GetRecordingJobWithHttpInfo (string jobId);

        /// <summary>
        /// Get IDs of recordings that the bulk job failed for
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>FailedRecordingEntityListing</returns>
        FailedRecordingEntityListing GetRecordingJobFailedrecordings (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get IDs of recordings that the bulk job failed for
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>ApiResponse of FailedRecordingEntityListing</returns>
        ApiResponse<FailedRecordingEntityListing> GetRecordingJobFailedrecordingsWithHttpInfo (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get the status of all jobs within the user's organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>RecordingJobEntityListing</returns>
        RecordingJobEntityListing GetRecordingJobs (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get the status of all jobs within the user's organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>ApiResponse of RecordingJobEntityListing</returns>
        ApiResponse<RecordingJobEntityListing> GetRecordingJobsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        RecordingEncryptionConfiguration GetRecordingKeyconfiguration (string keyConfigurationId);

        /// <summary>
        /// Get the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        ApiResponse<RecordingEncryptionConfiguration> GetRecordingKeyconfigurationWithHttpInfo (string keyConfigurationId);

        /// <summary>
        /// Get a list of key configurations data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RecordingEncryptionConfigurationListing</returns>
        RecordingEncryptionConfigurationListing GetRecordingKeyconfigurations ();

        /// <summary>
        /// Get a list of key configurations data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RecordingEncryptionConfigurationListing</returns>
        ApiResponse<RecordingEncryptionConfigurationListing> GetRecordingKeyconfigurationsWithHttpInfo ();

        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        LocalEncryptionConfiguration GetRecordingLocalkeysSetting (string settingsId);

        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        ApiResponse<LocalEncryptionConfiguration> GetRecordingLocalkeysSettingWithHttpInfo (string settingsId);

        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LocalEncryptionConfigurationListing</returns>
        LocalEncryptionConfigurationListing GetRecordingLocalkeysSettings ();

        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LocalEncryptionConfigurationListing</returns>
        ApiResponse<LocalEncryptionConfigurationListing> GetRecordingLocalkeysSettingsWithHttpInfo ();

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        PolicyEntityListing GetRecordingMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        ApiResponse<PolicyEntityListing> GetRecordingMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        Policy GetRecordingMediaretentionpolicy (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetRecordingMediaretentionpolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        EncryptionKeyEntityListing GetRecordingRecordingkeys (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        ApiResponse<EncryptionKeyEntityListing> GetRecordingRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule GetRecordingRecordingkeysRotationschedule ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> GetRecordingRecordingkeysRotationscheduleWithHttpInfo ();

        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>RecordingSettings</returns>
        RecordingSettings GetRecordingSettings (bool? createDefault = null);

        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        ApiResponse<RecordingSettings> GetRecordingSettingsWithHttpInfo (bool? createDefault = null);

        /// <summary>
        /// Query for recording retention data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>RecordingRetentionCursorEntityListing</returns>
        RecordingRetentionCursorEntityListing GetRecordingsRetentionQuery (int? retentionThresholdDays, string cursor = null, int? pageSize = null);

        /// <summary>
        /// Query for recording retention data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>ApiResponse of RecordingRetentionCursorEntityListing</returns>
        ApiResponse<RecordingRetentionCursorEntityListing> GetRecordingsRetentionQueryWithHttpInfo (int? retentionThresholdDays, string cursor = null, int? pageSize = null);

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ScreenRecordingSessionListing</returns>
        ScreenRecordingSessionListing GetRecordingsScreensessions (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ScreenRecordingSessionListing</returns>
        ApiResponse<ScreenRecordingSessionListing> GetRecordingsScreensessionsWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>CrossPlatformPolicy</returns>
        CrossPlatformPolicy PatchRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicyUpdate body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        ApiResponse<CrossPlatformPolicy> PatchRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId, CrossPlatformPolicyUpdate body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchRecordingMediaretentionpolicy (string policyId, PolicyUpdate body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchRecordingMediaretentionpolicyWithHttpInfo (string policyId, PolicyUpdate body);

        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchRecordingsScreensession (string recordingSessionId, ScreenRecordingSessionRequest body = null);

        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchRecordingsScreensessionWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        Annotation PostConversationRecordingAnnotations (string conversationId, string recordingId, Annotation body);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> PostConversationRecordingAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body);

        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>BatchDownloadJobSubmissionResult</returns>
        BatchDownloadJobSubmissionResult PostRecordingBatchrequests (BatchDownloadJobSubmission body);

        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>ApiResponse of BatchDownloadJobSubmissionResult</returns>
        ApiResponse<BatchDownloadJobSubmissionResult> PostRecordingBatchrequestsWithHttpInfo (BatchDownloadJobSubmission body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>CrossPlatformPolicy</returns>
        CrossPlatformPolicy PostRecordingCrossplatformMediaretentionpolicies (CrossPlatformPolicyCreate body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        ApiResponse<CrossPlatformPolicy> PostRecordingCrossplatformMediaretentionpoliciesWithHttpInfo (CrossPlatformPolicyCreate body);

        /// <summary>
        /// Create a recording bulk job.
        /// </summary>
        /// <remarks>
        /// Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>RecordingJob</returns>
        RecordingJob PostRecordingJobs (RecordingJobsQuery body);

        /// <summary>
        /// Create a recording bulk job.
        /// </summary>
        /// <remarks>
        /// Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of RecordingJob</returns>
        ApiResponse<RecordingJob> PostRecordingJobsWithHttpInfo (RecordingJobsQuery body);

        /// <summary>
        /// Setup configurations for encryption key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        RecordingEncryptionConfiguration PostRecordingKeyconfigurations (RecordingEncryptionConfiguration body);

        /// <summary>
        /// Setup configurations for encryption key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        ApiResponse<RecordingEncryptionConfiguration> PostRecordingKeyconfigurationsWithHttpInfo (RecordingEncryptionConfiguration body);

        /// <summary>
        /// Validate encryption key configurations without saving it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        RecordingEncryptionConfiguration PostRecordingKeyconfigurationsValidate (RecordingEncryptionConfiguration body);

        /// <summary>
        /// Validate encryption key configurations without saving it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        ApiResponse<RecordingEncryptionConfiguration> PostRecordingKeyconfigurationsValidateWithHttpInfo (RecordingEncryptionConfiguration body);

        /// <summary>
        /// create a local key management recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>EncryptionKey</returns>
        EncryptionKey PostRecordingLocalkeys (LocalEncryptionKeyRequest body);

        /// <summary>
        /// create a local key management recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> PostRecordingLocalkeysWithHttpInfo (LocalEncryptionKeyRequest body);

        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        LocalEncryptionConfiguration PostRecordingLocalkeysSettings (LocalEncryptionConfiguration body);

        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        ApiResponse<LocalEncryptionConfiguration> PostRecordingLocalkeysSettingsWithHttpInfo (LocalEncryptionConfiguration body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PostRecordingMediaretentionpolicies (PolicyCreate body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PostRecordingMediaretentionpoliciesWithHttpInfo (PolicyCreate body);

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        EncryptionKey PostRecordingRecordingkeys ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> PostRecordingRecordingkeysWithHttpInfo ();

        /// <summary>
        /// Get a list of conversations with protected recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>List&lt;AddressableEntityRef&gt;</returns>
        List<AddressableEntityRef> PostRecordingsDeletionprotection (ConversationDeletionProtectionQuery body);

        /// <summary>
        /// Get a list of conversations with protected recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>ApiResponse of List&lt;AddressableEntityRef&gt;</returns>
        ApiResponse<List<AddressableEntityRef>> PostRecordingsDeletionprotectionWithHttpInfo (ConversationDeletionProtectionQuery body);

        /// <summary>
        /// Acknowledge a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns></returns>
        void PostRecordingsScreensessionsAcknowledge (AcknowledgeScreenRecordingRequest body);

        /// <summary>
        /// Acknowledge a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostRecordingsScreensessionsAcknowledgeWithHttpInfo (AcknowledgeScreenRecordingRequest body);

        /// <summary>
        /// Provide meta-data a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns></returns>
        void PostRecordingsScreensessionsMetadata (ScreenRecordingMetaDataRequest body);

        /// <summary>
        /// Provide meta-data a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostRecordingsScreensessionsMetadataWithHttpInfo (ScreenRecordingMetaDataRequest body);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>Recording</returns>
        Recording PutConversationRecording (string conversationId, string recordingId, Recording body, bool? clearExport = null);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> PutConversationRecordingWithHttpInfo (string conversationId, string recordingId, Recording body, bool? clearExport = null);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        Annotation PutConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId, Annotation body);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> PutConversationRecordingAnnotationWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body);

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Recording</returns>
        Recording PutOrphanrecording (string orphanId, OrphanUpdateRequest body = null);

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> PutOrphanrecordingWithHttpInfo (string orphanId, OrphanUpdateRequest body = null);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>CrossPlatformPolicy</returns>
        CrossPlatformPolicy PutRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicy body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        ApiResponse<CrossPlatformPolicy> PutRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId, CrossPlatformPolicy body);

        /// <summary>
        /// Execute the recording bulk job.
        /// </summary>
        /// <remarks>
        /// A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>RecordingJob</returns>
        RecordingJob PutRecordingJob (string jobId, ExecuteRecordingJobsQuery body);

        /// <summary>
        /// Execute the recording bulk job.
        /// </summary>
        /// <remarks>
        /// A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of RecordingJob</returns>
        ApiResponse<RecordingJob> PutRecordingJobWithHttpInfo (string jobId, ExecuteRecordingJobsQuery body);

        /// <summary>
        /// Update the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        RecordingEncryptionConfiguration PutRecordingKeyconfiguration (string keyConfigurationId, RecordingEncryptionConfiguration body);

        /// <summary>
        /// Update the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        ApiResponse<RecordingEncryptionConfiguration> PutRecordingKeyconfigurationWithHttpInfo (string keyConfigurationId, RecordingEncryptionConfiguration body);

        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        LocalEncryptionConfiguration PutRecordingLocalkeysSetting (string settingsId, LocalEncryptionConfiguration body);

        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        ApiResponse<LocalEncryptionConfiguration> PutRecordingLocalkeysSettingWithHttpInfo (string settingsId, LocalEncryptionConfiguration body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PutRecordingMediaretentionpolicy (string policyId, Policy body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PutRecordingMediaretentionpolicyWithHttpInfo (string policyId, Policy body);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule PutRecordingRecordingkeysRotationschedule (KeyRotationSchedule body);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> PutRecordingRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body);

        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>RecordingSettings</returns>
        RecordingSettings PutRecordingSettings (RecordingSettings body);

        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        ApiResponse<RecordingSettings> PutRecordingSettingsWithHttpInfo (RecordingSettings body);

        /// <summary>
        /// Apply or revoke recording protection for conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PutRecordingsDeletionprotection (bool? protect = null, ConversationDeletionProtectionQuery body = null);

        /// <summary>
        /// Apply or revoke recording protection for conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutRecordingsDeletionprotectionWithHttpInfo (bool? protect = null, ConversationDeletionProtectionQuery body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteConversationRecordingAnnotationAsync (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationRecordingAnnotationAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        System.Threading.Tasks.Task<OrphanRecording> DeleteOrphanrecordingAsync (string orphanId);

        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> DeleteOrphanrecordingAsyncWithHttpInfo (string orphanId);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRecordingCrossplatformMediaretentionpoliciesAsync (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo (string ids);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRecordingCrossplatformMediaretentionpolicyAsync (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId);

        /// <summary>
        /// Delete the recording bulk job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRecordingJobAsync (string jobId);

        /// <summary>
        /// Delete the recording bulk job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRecordingMediaretentionpoliciesAsync (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingMediaretentionpoliciesAsyncWithHttpInfo (string ids);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRecordingMediaretentionpolicyAsync (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> GetConversationRecordingAsync (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> GetConversationRecordingAsyncWithHttpInfo (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> GetConversationRecordingAnnotationAsync (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationRecordingAnnotationAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        System.Threading.Tasks.Task<List<Annotation>> GetConversationRecordingAnnotationsAsync (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationRecordingAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId);

        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of List&lt;RecordingMetadata&gt;</returns>
        System.Threading.Tasks.Task<List<RecordingMetadata>> GetConversationRecordingmetadataAsync (string conversationId);

        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse (List&lt;RecordingMetadata&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RecordingMetadata>>> GetConversationRecordingmetadataAsyncWithHttpInfo (string conversationId);

        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of RecordingMetadata</returns>
        System.Threading.Tasks.Task<RecordingMetadata> GetConversationRecordingmetadataRecordingIdAsync (string conversationId, string recordingId);

        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (RecordingMetadata)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingMetadata>> GetConversationRecordingmetadataRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId);

        /// <summary>
        /// Get all of a Conversation's Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        System.Threading.Tasks.Task<List<Recording>> GetConversationRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null);

        /// <summary>
        /// Get all of a Conversation's Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        System.Threading.Tasks.Task<OrphanRecording> GetOrphanrecordingAsync (string orphanId);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> GetOrphanrecordingAsyncWithHttpInfo (string orphanId);

        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> GetOrphanrecordingMediaAsync (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> GetOrphanrecordingMediaAsyncWithHttpInfo (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null);

        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>Task of OrphanRecordingListing</returns>
        System.Threading.Tasks.Task<OrphanRecordingListing> GetOrphanrecordingsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null);

        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>Task of ApiResponse (OrphanRecordingListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecordingListing>> GetOrphanrecordingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null);

        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of BatchDownloadJobStatusResult</returns>
        System.Threading.Tasks.Task<BatchDownloadJobStatusResult> GetRecordingBatchrequestAsync (string jobId);

        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (BatchDownloadJobStatusResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<BatchDownloadJobStatusResult>> GetRecordingBatchrequestAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        System.Threading.Tasks.Task<PolicyEntityListing> GetRecordingCrossplatformMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        System.Threading.Tasks.Task<CrossPlatformPolicy> GetRecordingCrossplatformMediaretentionpolicyAsync (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> GetRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId);

        /// <summary>
        /// Get the status of the job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of RecordingJob</returns>
        System.Threading.Tasks.Task<RecordingJob> GetRecordingJobAsync (string jobId);

        /// <summary>
        /// Get the status of the job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (RecordingJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingJob>> GetRecordingJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get IDs of recordings that the bulk job failed for
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of FailedRecordingEntityListing</returns>
        System.Threading.Tasks.Task<FailedRecordingEntityListing> GetRecordingJobFailedrecordingsAsync (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get IDs of recordings that the bulk job failed for
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of ApiResponse (FailedRecordingEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FailedRecordingEntityListing>> GetRecordingJobFailedrecordingsAsyncWithHttpInfo (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get the status of all jobs within the user's organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of RecordingJobEntityListing</returns>
        System.Threading.Tasks.Task<RecordingJobEntityListing> GetRecordingJobsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get the status of all jobs within the user's organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of ApiResponse (RecordingJobEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingJobEntityListing>> GetRecordingJobsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null);

        /// <summary>
        /// Get the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<RecordingEncryptionConfiguration> GetRecordingKeyconfigurationAsync (string keyConfigurationId);

        /// <summary>
        /// Get the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> GetRecordingKeyconfigurationAsyncWithHttpInfo (string keyConfigurationId);

        /// <summary>
        /// Get a list of key configurations data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RecordingEncryptionConfigurationListing</returns>
        System.Threading.Tasks.Task<RecordingEncryptionConfigurationListing> GetRecordingKeyconfigurationsAsync ();

        /// <summary>
        /// Get a list of key configurations data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfigurationListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfigurationListing>> GetRecordingKeyconfigurationsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfiguration> GetRecordingLocalkeysSettingAsync (string settingsId);

        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> GetRecordingLocalkeysSettingAsyncWithHttpInfo (string settingsId);

        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LocalEncryptionConfigurationListing</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfigurationListing> GetRecordingLocalkeysSettingsAsync ();

        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LocalEncryptionConfigurationListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfigurationListing>> GetRecordingLocalkeysSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        System.Threading.Tasks.Task<PolicyEntityListing> GetRecordingMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRecordingMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetRecordingMediaretentionpolicyAsync (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingRecordingkeysAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingRecordingkeysRotationscheduleAsync ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingRecordingkeysRotationscheduleAsyncWithHttpInfo ();

        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of RecordingSettings</returns>
        System.Threading.Tasks.Task<RecordingSettings> GetRecordingSettingsAsync (bool? createDefault = null);

        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> GetRecordingSettingsAsyncWithHttpInfo (bool? createDefault = null);

        /// <summary>
        /// Query for recording retention data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>Task of RecordingRetentionCursorEntityListing</returns>
        System.Threading.Tasks.Task<RecordingRetentionCursorEntityListing> GetRecordingsRetentionQueryAsync (int? retentionThresholdDays, string cursor = null, int? pageSize = null);

        /// <summary>
        /// Query for recording retention data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (RecordingRetentionCursorEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingRetentionCursorEntityListing>> GetRecordingsRetentionQueryAsyncWithHttpInfo (int? retentionThresholdDays, string cursor = null, int? pageSize = null);

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ScreenRecordingSessionListing</returns>
        System.Threading.Tasks.Task<ScreenRecordingSessionListing> GetRecordingsScreensessionsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ScreenRecordingSessionListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScreenRecordingSessionListing>> GetRecordingsScreensessionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        System.Threading.Tasks.Task<CrossPlatformPolicy> PatchRecordingCrossplatformMediaretentionpolicyAsync (string policyId, CrossPlatformPolicyUpdate body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> PatchRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId, CrossPlatformPolicyUpdate body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchRecordingMediaretentionpolicyAsync (string policyId, PolicyUpdate body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId, PolicyUpdate body);

        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchRecordingsScreensessionAsync (string recordingSessionId, ScreenRecordingSessionRequest body = null);

        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchRecordingsScreensessionAsyncWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> PostConversationRecordingAnnotationsAsync (string conversationId, string recordingId, Annotation body);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> PostConversationRecordingAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body);

        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>Task of BatchDownloadJobSubmissionResult</returns>
        System.Threading.Tasks.Task<BatchDownloadJobSubmissionResult> PostRecordingBatchrequestsAsync (BatchDownloadJobSubmission body);

        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>Task of ApiResponse (BatchDownloadJobSubmissionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<BatchDownloadJobSubmissionResult>> PostRecordingBatchrequestsAsyncWithHttpInfo (BatchDownloadJobSubmission body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        System.Threading.Tasks.Task<CrossPlatformPolicy> PostRecordingCrossplatformMediaretentionpoliciesAsync (CrossPlatformPolicyCreate body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> PostRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo (CrossPlatformPolicyCreate body);

        /// <summary>
        /// Create a recording bulk job.
        /// </summary>
        /// <remarks>
        /// Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of RecordingJob</returns>
        System.Threading.Tasks.Task<RecordingJob> PostRecordingJobsAsync (RecordingJobsQuery body);

        /// <summary>
        /// Create a recording bulk job.
        /// </summary>
        /// <remarks>
        /// Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (RecordingJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingJob>> PostRecordingJobsAsyncWithHttpInfo (RecordingJobsQuery body);

        /// <summary>
        /// Setup configurations for encryption key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<RecordingEncryptionConfiguration> PostRecordingKeyconfigurationsAsync (RecordingEncryptionConfiguration body);

        /// <summary>
        /// Setup configurations for encryption key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> PostRecordingKeyconfigurationsAsyncWithHttpInfo (RecordingEncryptionConfiguration body);

        /// <summary>
        /// Validate encryption key configurations without saving it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<RecordingEncryptionConfiguration> PostRecordingKeyconfigurationsValidateAsync (RecordingEncryptionConfiguration body);

        /// <summary>
        /// Validate encryption key configurations without saving it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> PostRecordingKeyconfigurationsValidateAsyncWithHttpInfo (RecordingEncryptionConfiguration body);

        /// <summary>
        /// create a local key management recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> PostRecordingLocalkeysAsync (LocalEncryptionKeyRequest body);

        /// <summary>
        /// create a local key management recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingLocalkeysAsyncWithHttpInfo (LocalEncryptionKeyRequest body);

        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfiguration> PostRecordingLocalkeysSettingsAsync (LocalEncryptionConfiguration body);

        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PostRecordingLocalkeysSettingsAsyncWithHttpInfo (LocalEncryptionConfiguration body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PostRecordingMediaretentionpoliciesAsync (PolicyCreate body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PostRecordingMediaretentionpoliciesAsyncWithHttpInfo (PolicyCreate body);

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> PostRecordingRecordingkeysAsync ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingRecordingkeysAsyncWithHttpInfo ();

        /// <summary>
        /// Get a list of conversations with protected recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>Task of List&lt;AddressableEntityRef&gt;</returns>
        System.Threading.Tasks.Task<List<AddressableEntityRef>> PostRecordingsDeletionprotectionAsync (ConversationDeletionProtectionQuery body);

        /// <summary>
        /// Get a list of conversations with protected recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>Task of ApiResponse (List&lt;AddressableEntityRef&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AddressableEntityRef>>> PostRecordingsDeletionprotectionAsyncWithHttpInfo (ConversationDeletionProtectionQuery body);

        /// <summary>
        /// Acknowledge a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostRecordingsScreensessionsAcknowledgeAsync (AcknowledgeScreenRecordingRequest body);

        /// <summary>
        /// Acknowledge a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostRecordingsScreensessionsAcknowledgeAsyncWithHttpInfo (AcknowledgeScreenRecordingRequest body);

        /// <summary>
        /// Provide meta-data a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostRecordingsScreensessionsMetadataAsync (ScreenRecordingMetaDataRequest body);

        /// <summary>
        /// Provide meta-data a screen recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostRecordingsScreensessionsMetadataAsyncWithHttpInfo (ScreenRecordingMetaDataRequest body);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> PutConversationRecordingAsync (string conversationId, string recordingId, Recording body, bool? clearExport = null);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> PutConversationRecordingAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, bool? clearExport = null);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> PutConversationRecordingAnnotationAsync (string conversationId, string recordingId, string annotationId, Annotation body);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> PutConversationRecordingAnnotationAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body);

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> PutOrphanrecordingAsync (string orphanId, OrphanUpdateRequest body = null);

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> PutOrphanrecordingAsyncWithHttpInfo (string orphanId, OrphanUpdateRequest body = null);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        System.Threading.Tasks.Task<CrossPlatformPolicy> PutRecordingCrossplatformMediaretentionpolicyAsync (string policyId, CrossPlatformPolicy body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> PutRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId, CrossPlatformPolicy body);

        /// <summary>
        /// Execute the recording bulk job.
        /// </summary>
        /// <remarks>
        /// A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>Task of RecordingJob</returns>
        System.Threading.Tasks.Task<RecordingJob> PutRecordingJobAsync (string jobId, ExecuteRecordingJobsQuery body);

        /// <summary>
        /// Execute the recording bulk job.
        /// </summary>
        /// <remarks>
        /// A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (RecordingJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingJob>> PutRecordingJobAsyncWithHttpInfo (string jobId, ExecuteRecordingJobsQuery body);

        /// <summary>
        /// Update the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<RecordingEncryptionConfiguration> PutRecordingKeyconfigurationAsync (string keyConfigurationId, RecordingEncryptionConfiguration body);

        /// <summary>
        /// Update the encryption key configurations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> PutRecordingKeyconfigurationAsyncWithHttpInfo (string keyConfigurationId, RecordingEncryptionConfiguration body);

        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfiguration> PutRecordingLocalkeysSettingAsync (string settingsId, LocalEncryptionConfiguration body);

        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PutRecordingLocalkeysSettingAsyncWithHttpInfo (string settingsId, LocalEncryptionConfiguration body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PutRecordingMediaretentionpolicyAsync (string policyId, Policy body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// Policy does not work retroactively
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PutRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId, Policy body);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingRecordingkeysRotationscheduleAsync (KeyRotationSchedule body);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body);

        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of RecordingSettings</returns>
        System.Threading.Tasks.Task<RecordingSettings> PutRecordingSettingsAsync (RecordingSettings body);

        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> PutRecordingSettingsAsyncWithHttpInfo (RecordingSettings body);

        /// <summary>
        /// Apply or revoke recording protection for conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutRecordingsDeletionprotectionAsync (bool? protect = null, ConversationDeletionProtectionQuery body = null);

        /// <summary>
        /// Apply or revoke recording protection for conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutRecordingsDeletionprotectionAsyncWithHttpInfo (bool? protect = null, ConversationDeletionProtectionQuery body = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecordingApi : IRecordingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecordingApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecordingApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns></returns>
        public void DeleteConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId)
        {
             DeleteConversationRecordingAnnotationWithHttpInfo(conversationId, recordingId, annotationId);
        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationRecordingAnnotationWithHttpInfo (string conversationId, string recordingId, string annotationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->DeleteConversationRecordingAnnotation");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->DeleteConversationRecordingAnnotation");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->DeleteConversationRecordingAnnotation");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationRecordingAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationRecordingAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteConversationRecordingAnnotationAsync (string conversationId, string recordingId, string annotationId)
        {
             await DeleteConversationRecordingAnnotationAsyncWithHttpInfo(conversationId, recordingId, annotationId);

        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationRecordingAnnotationAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->DeleteConversationRecordingAnnotation");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->DeleteConversationRecordingAnnotation");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->DeleteConversationRecordingAnnotation");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationRecordingAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationRecordingAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        public OrphanRecording DeleteOrphanrecording (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = DeleteOrphanrecordingWithHttpInfo(orphanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        public ApiResponse< OrphanRecording > DeleteOrphanrecordingWithHttpInfo (string orphanId)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->DeleteOrphanrecording");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanrecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanrecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarHeaders,
                (OrphanRecording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        public async System.Threading.Tasks.Task<OrphanRecording> DeleteOrphanrecordingAsync (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = await DeleteOrphanrecordingAsyncWithHttpInfo(orphanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> DeleteOrphanrecordingAsyncWithHttpInfo (string orphanId)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->DeleteOrphanrecording");
            

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanrecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanrecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarHeaders,
                (OrphanRecording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns></returns>
        public void DeleteRecordingCrossplatformMediaretentionpolicies (string ids)
        {
             DeleteRecordingCrossplatformMediaretentionpoliciesWithHttpInfo(ids);
        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRecordingCrossplatformMediaretentionpoliciesWithHttpInfo (string ids)
        { 
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling RecordingApi->DeleteRecordingCrossplatformMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies";
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
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRecordingCrossplatformMediaretentionpoliciesAsync (string ids)
        {
             await DeleteRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo(ids);

        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo (string ids)
        { 
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling RecordingApi->DeleteRecordingCrossplatformMediaretentionpolicies");
            

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies";
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
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns></returns>
        public void DeleteRecordingCrossplatformMediaretentionpolicy (string policyId)
        {
             DeleteRecordingCrossplatformMediaretentionpolicyWithHttpInfo(policyId);
        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->DeleteRecordingCrossplatformMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRecordingCrossplatformMediaretentionpolicyAsync (string policyId)
        {
             await DeleteRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo(policyId);

        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->DeleteRecordingCrossplatformMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete the recording bulk job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns></returns>
        public void DeleteRecordingJob (string jobId)
        {
             DeleteRecordingJobWithHttpInfo(jobId);
        }

        /// <summary>
        /// Delete the recording bulk job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRecordingJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->DeleteRecordingJob");

            var localVarPath = "/api/v2/recording/jobs/{jobId}";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete the recording bulk job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRecordingJobAsync (string jobId)
        {
             await DeleteRecordingJobAsyncWithHttpInfo(jobId);

        }

        /// <summary>
        /// Delete the recording bulk job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->DeleteRecordingJob");
            

            var localVarPath = "/api/v2/recording/jobs/{jobId}";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns></returns>
        public void DeleteRecordingMediaretentionpolicies (string ids)
        {
             DeleteRecordingMediaretentionpoliciesWithHttpInfo(ids);
        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRecordingMediaretentionpoliciesWithHttpInfo (string ids)
        { 
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling RecordingApi->DeleteRecordingMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRecordingMediaretentionpoliciesAsync (string ids)
        {
             await DeleteRecordingMediaretentionpoliciesAsyncWithHttpInfo(ids);

        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingMediaretentionpoliciesAsyncWithHttpInfo (string ids)
        { 
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling RecordingApi->DeleteRecordingMediaretentionpolicies");
            

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns></returns>
        public void DeleteRecordingMediaretentionpolicy (string policyId)
        {
             DeleteRecordingMediaretentionpolicyWithHttpInfo(policyId);
        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRecordingMediaretentionpolicyWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->DeleteRecordingMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRecordingMediaretentionpolicyAsync (string policyId)
        {
             await DeleteRecordingMediaretentionpolicyAsyncWithHttpInfo(policyId);

        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->DeleteRecordingMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Recording</returns>
        public Recording GetConversationRecording (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        {
             ApiResponse<Recording> localVarResponse = GetConversationRecordingWithHttpInfo(conversationId, recordingId, formatId, emailFormatId, chatFormatId, messageFormatId, download, fileName, locale, mediaFormats);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > GetConversationRecordingWithHttpInfo (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecording");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecording");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

            // Query params
            if (formatId != null) localVarQueryParams.Add(new Tuple<string, string>("formatId", this.Configuration.ApiClient.ParameterToString(formatId)));
            if (emailFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("emailFormatId", this.Configuration.ApiClient.ParameterToString(emailFormatId)));
            if (chatFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("chatFormatId", this.Configuration.ApiClient.ParameterToString(chatFormatId)));
            if (messageFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("messageFormatId", this.Configuration.ApiClient.ParameterToString(messageFormatId)));
            if (download != null) localVarQueryParams.Add(new Tuple<string, string>("download", this.Configuration.ApiClient.ParameterToString(download)));
            if (fileName != null) localVarQueryParams.Add(new Tuple<string, string>("fileName", this.Configuration.ApiClient.ParameterToString(fileName)));
            if (locale != null) localVarQueryParams.Add(new Tuple<string, string>("locale", this.Configuration.ApiClient.ParameterToString(locale)));
            if (mediaFormats != null) mediaFormats.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("mediaFormats", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> GetConversationRecordingAsync (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        {
             ApiResponse<Recording> localVarResponse = await GetConversationRecordingAsyncWithHttpInfo(conversationId, recordingId, formatId, emailFormatId, chatFormatId, messageFormatId, download, fileName, locale, mediaFormats);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. Valid values:EML,NONE (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording. Valid values:true,false (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> GetConversationRecordingAsyncWithHttpInfo (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecording");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecording");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

            // Query params
            if (formatId != null) localVarQueryParams.Add(new Tuple<string, string>("formatId", this.Configuration.ApiClient.ParameterToString(formatId)));
            if (emailFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("emailFormatId", this.Configuration.ApiClient.ParameterToString(emailFormatId)));
            if (chatFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("chatFormatId", this.Configuration.ApiClient.ParameterToString(chatFormatId)));
            if (messageFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("messageFormatId", this.Configuration.ApiClient.ParameterToString(messageFormatId)));
            if (download != null) localVarQueryParams.Add(new Tuple<string, string>("download", this.Configuration.ApiClient.ParameterToString(download)));
            if (fileName != null) localVarQueryParams.Add(new Tuple<string, string>("fileName", this.Configuration.ApiClient.ParameterToString(fileName)));
            if (locale != null) localVarQueryParams.Add(new Tuple<string, string>("locale", this.Configuration.ApiClient.ParameterToString(locale)));
            if (mediaFormats != null) mediaFormats.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("mediaFormats", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Annotation</returns>
        public Annotation GetConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> localVarResponse = GetConversationRecordingAnnotationWithHttpInfo(conversationId, recordingId, annotationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > GetConversationRecordingAnnotationWithHttpInfo (string conversationId, string recordingId, string annotationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingAnnotation");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecordingAnnotation");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->GetConversationRecordingAnnotation");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarHeaders,
                (Annotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> GetConversationRecordingAnnotationAsync (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> localVarResponse = await GetConversationRecordingAnnotationAsyncWithHttpInfo(conversationId, recordingId, annotationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationRecordingAnnotationAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingAnnotation");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecordingAnnotation");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->GetConversationRecordingAnnotation");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarHeaders,
                (Annotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        public List<Annotation> GetConversationRecordingAnnotations (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = GetConversationRecordingAnnotationsWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        public ApiResponse< List<Annotation> > GetConversationRecordingAnnotationsWithHttpInfo (string conversationId, string recordingId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecordingAnnotations");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarHeaders,
                (List<Annotation>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Annotation>> GetConversationRecordingAnnotationsAsync (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = await GetConversationRecordingAnnotationsAsyncWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationRecordingAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingAnnotations");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecordingAnnotations");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarHeaders,
                (List<Annotation>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>List&lt;RecordingMetadata&gt;</returns>
        public List<RecordingMetadata> GetConversationRecordingmetadata (string conversationId)
        {
             ApiResponse<List<RecordingMetadata>> localVarResponse = GetConversationRecordingmetadataWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of List&lt;RecordingMetadata&gt;</returns>
        public ApiResponse< List<RecordingMetadata> > GetConversationRecordingmetadataWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingmetadata");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordingmetadata";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<RecordingMetadata>>(localVarStatusCode,
                localVarHeaders,
                (List<RecordingMetadata>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RecordingMetadata>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of List&lt;RecordingMetadata&gt;</returns>
        public async System.Threading.Tasks.Task<List<RecordingMetadata>> GetConversationRecordingmetadataAsync (string conversationId)
        {
             ApiResponse<List<RecordingMetadata>> localVarResponse = await GetConversationRecordingmetadataAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if recording:recording:view permission is missing. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse (List&lt;RecordingMetadata&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RecordingMetadata>>> GetConversationRecordingmetadataAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingmetadata");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordingmetadata";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<RecordingMetadata>>(localVarStatusCode,
                localVarHeaders,
                (List<RecordingMetadata>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RecordingMetadata>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>RecordingMetadata</returns>
        public RecordingMetadata GetConversationRecordingmetadataRecordingId (string conversationId, string recordingId)
        {
             ApiResponse<RecordingMetadata> localVarResponse = GetConversationRecordingmetadataRecordingIdWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of RecordingMetadata</returns>
        public ApiResponse< RecordingMetadata > GetConversationRecordingmetadataRecordingIdWithHttpInfo (string conversationId, string recordingId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingmetadataRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecordingmetadataRecordingId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordingmetadata/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadataRecordingId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadataRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingMetadata>(localVarStatusCode,
                localVarHeaders,
                (RecordingMetadata) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingMetadata)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of RecordingMetadata</returns>
        public async System.Threading.Tasks.Task<RecordingMetadata> GetConversationRecordingmetadataRecordingIdAsync (string conversationId, string recordingId)
        {
             ApiResponse<RecordingMetadata> localVarResponse = await GetConversationRecordingmetadataRecordingIdAsyncWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get metadata for a specific recording. Does not return playable media. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (RecordingMetadata)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingMetadata>> GetConversationRecordingmetadataRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordingmetadataRecordingId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationRecordingmetadataRecordingId");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordingmetadata/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadataRecordingId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordingmetadataRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingMetadata>(localVarStatusCode,
                localVarHeaders,
                (RecordingMetadata) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingMetadata)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all of a Conversation's Recordings. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        public List<Recording> GetConversationRecordings (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null)
        {
             ApiResponse<List<Recording>> localVarResponse = GetConversationRecordingsWithHttpInfo(conversationId, maxWaitMs, formatId, mediaFormats);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all of a Conversation's Recordings. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        public ApiResponse< List<Recording> > GetConversationRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordings");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings";
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
            if (maxWaitMs != null) localVarQueryParams.Add(new Tuple<string, string>("maxWaitMs", this.Configuration.ApiClient.ParameterToString(maxWaitMs)));
            if (formatId != null) localVarQueryParams.Add(new Tuple<string, string>("formatId", this.Configuration.ApiClient.ParameterToString(formatId)));
            if (mediaFormats != null) mediaFormats.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("mediaFormats", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarHeaders,
                (List<Recording>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all of a Conversation's Recordings. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        public async System.Threading.Tasks.Task<List<Recording>> GetConversationRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null)
        {
             ApiResponse<List<Recording>> localVarResponse = await GetConversationRecordingsAsyncWithHttpInfo(conversationId, maxWaitMs, formatId, mediaFormats);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all of a Conversation's Recordings. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional, default to WEBM)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationRecordings");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings";
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
            if (maxWaitMs != null) localVarQueryParams.Add(new Tuple<string, string>("maxWaitMs", this.Configuration.ApiClient.ParameterToString(maxWaitMs)));
            if (formatId != null) localVarQueryParams.Add(new Tuple<string, string>("formatId", this.Configuration.ApiClient.ParameterToString(formatId)));
            if (mediaFormats != null) mediaFormats.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("mediaFormats", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarHeaders,
                (List<Recording>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        public OrphanRecording GetOrphanrecording (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = GetOrphanrecordingWithHttpInfo(orphanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        public ApiResponse< OrphanRecording > GetOrphanrecordingWithHttpInfo (string orphanId)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanrecording");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarHeaders,
                (OrphanRecording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        public async System.Threading.Tasks.Task<OrphanRecording> GetOrphanrecordingAsync (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = await GetOrphanrecordingAsyncWithHttpInfo(orphanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> GetOrphanrecordingAsyncWithHttpInfo (string orphanId)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanrecording");
            

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarHeaders,
                (OrphanRecording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Recording</returns>
        public Recording GetOrphanrecordingMedia (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        {
             ApiResponse<Recording> localVarResponse = GetOrphanrecordingMediaWithHttpInfo(orphanId, formatId, emailFormatId, chatFormatId, messageFormatId, download, fileName, locale, mediaFormats);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > GetOrphanrecordingMediaWithHttpInfo (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanrecordingMedia");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}/media";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

            // Query params
            if (formatId != null) localVarQueryParams.Add(new Tuple<string, string>("formatId", this.Configuration.ApiClient.ParameterToString(formatId)));
            if (emailFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("emailFormatId", this.Configuration.ApiClient.ParameterToString(emailFormatId)));
            if (chatFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("chatFormatId", this.Configuration.ApiClient.ParameterToString(chatFormatId)));
            if (messageFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("messageFormatId", this.Configuration.ApiClient.ParameterToString(messageFormatId)));
            if (download != null) localVarQueryParams.Add(new Tuple<string, string>("download", this.Configuration.ApiClient.ParameterToString(download)));
            if (fileName != null) localVarQueryParams.Add(new Tuple<string, string>("fileName", this.Configuration.ApiClient.ParameterToString(fileName)));
            if (locale != null) localVarQueryParams.Add(new Tuple<string, string>("locale", this.Configuration.ApiClient.ParameterToString(locale)));
            if (mediaFormats != null) mediaFormats.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("mediaFormats", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordingMedia: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordingMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> GetOrphanrecordingMediaAsync (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        {
             ApiResponse<Recording> localVarResponse = await GetOrphanrecordingMediaAsyncWithHttpInfo(orphanId, formatId, emailFormatId, chatFormatId, messageFormatId, download, fileName, locale, mediaFormats);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="emailFormatId">The desired media format when downloading an email recording. (optional, default to EML)</param>
        /// <param name="chatFormatId">The desired media format when downloading a chat recording. (optional, default to ZIP)</param>
        /// <param name="messageFormatId">The desired media format when downloading a message recording. (optional, default to ZIP)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <param name="locale">The locale for the requested file when downloading, as an ISO 639-1 code (optional)</param>
        /// <param name="mediaFormats">All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> GetOrphanrecordingMediaAsyncWithHttpInfo (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanrecordingMedia");
            

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}/media";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

            // Query params
            if (formatId != null) localVarQueryParams.Add(new Tuple<string, string>("formatId", this.Configuration.ApiClient.ParameterToString(formatId)));
            if (emailFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("emailFormatId", this.Configuration.ApiClient.ParameterToString(emailFormatId)));
            if (chatFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("chatFormatId", this.Configuration.ApiClient.ParameterToString(chatFormatId)));
            if (messageFormatId != null) localVarQueryParams.Add(new Tuple<string, string>("messageFormatId", this.Configuration.ApiClient.ParameterToString(messageFormatId)));
            if (download != null) localVarQueryParams.Add(new Tuple<string, string>("download", this.Configuration.ApiClient.ParameterToString(download)));
            if (fileName != null) localVarQueryParams.Add(new Tuple<string, string>("fileName", this.Configuration.ApiClient.ParameterToString(fileName)));
            if (locale != null) localVarQueryParams.Add(new Tuple<string, string>("locale", this.Configuration.ApiClient.ParameterToString(locale)));
            if (mediaFormats != null) mediaFormats.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("mediaFormats", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordingMedia: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordingMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>OrphanRecordingListing</returns>
        public OrphanRecordingListing GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null)
        {
             ApiResponse<OrphanRecordingListing> localVarResponse = GetOrphanrecordingsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, hasConversation, media);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>ApiResponse of OrphanRecordingListing</returns>
        public ApiResponse< OrphanRecordingListing > GetOrphanrecordingsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null)
        { 

            var localVarPath = "/api/v2/orphanrecordings";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (hasConversation != null) localVarQueryParams.Add(new Tuple<string, string>("hasConversation", this.Configuration.ApiClient.ParameterToString(hasConversation)));
            if (media != null) localVarQueryParams.Add(new Tuple<string, string>("media", this.Configuration.ApiClient.ParameterToString(media)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecordingListing>(localVarStatusCode,
                localVarHeaders,
                (OrphanRecordingListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecordingListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>Task of OrphanRecordingListing</returns>
        public async System.Threading.Tasks.Task<OrphanRecordingListing> GetOrphanrecordingsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null)
        {
             ApiResponse<OrphanRecordingListing> localVarResponse = await GetOrphanrecordingsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, hasConversation, media);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <param name="media">Filter resulting orphans based on their media type (optional)</param>
        /// <returns>Task of ApiResponse (OrphanRecordingListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecordingListing>> GetOrphanrecordingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null)
        { 

            var localVarPath = "/api/v2/orphanrecordings";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (hasConversation != null) localVarQueryParams.Add(new Tuple<string, string>("hasConversation", this.Configuration.ApiClient.ParameterToString(hasConversation)));
            if (media != null) localVarQueryParams.Add(new Tuple<string, string>("media", this.Configuration.ApiClient.ParameterToString(media)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecordingListing>(localVarStatusCode,
                localVarHeaders,
                (OrphanRecordingListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecordingListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>BatchDownloadJobStatusResult</returns>
        public BatchDownloadJobStatusResult GetRecordingBatchrequest (string jobId)
        {
             ApiResponse<BatchDownloadJobStatusResult> localVarResponse = GetRecordingBatchrequestWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of BatchDownloadJobStatusResult</returns>
        public ApiResponse< BatchDownloadJobStatusResult > GetRecordingBatchrequestWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->GetRecordingBatchrequest");

            var localVarPath = "/api/v2/recording/batchrequests/{jobId}";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingBatchrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingBatchrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BatchDownloadJobStatusResult>(localVarStatusCode,
                localVarHeaders,
                (BatchDownloadJobStatusResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchDownloadJobStatusResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of BatchDownloadJobStatusResult</returns>
        public async System.Threading.Tasks.Task<BatchDownloadJobStatusResult> GetRecordingBatchrequestAsync (string jobId)
        {
             ApiResponse<BatchDownloadJobStatusResult> localVarResponse = await GetRecordingBatchrequestAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status and results for a batch request job, only the user that submitted the job may retrieve results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (BatchDownloadJobStatusResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BatchDownloadJobStatusResult>> GetRecordingBatchrequestAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->GetRecordingBatchrequest");
            

            var localVarPath = "/api/v2/recording/batchrequests/{jobId}";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingBatchrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingBatchrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BatchDownloadJobStatusResult>(localVarStatusCode,
                localVarHeaders,
                (BatchDownloadJobStatusResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchDownloadJobStatusResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        public PolicyEntityListing GetRecordingCrossplatformMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = GetRecordingCrossplatformMediaretentionpoliciesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors, deleteDaysThreshold);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        public ApiResponse< PolicyEntityListing > GetRecordingCrossplatformMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        { 

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (enabled != null) localVarQueryParams.Add(new Tuple<string, string>("enabled", this.Configuration.ApiClient.ParameterToString(enabled)));
            if (summary != null) localVarQueryParams.Add(new Tuple<string, string>("summary", this.Configuration.ApiClient.ParameterToString(summary)));
            if (hasErrors != null) localVarQueryParams.Add(new Tuple<string, string>("hasErrors", this.Configuration.ApiClient.ParameterToString(hasErrors)));
            if (deleteDaysThreshold != null) localVarQueryParams.Add(new Tuple<string, string>("deleteDaysThreshold", this.Configuration.ApiClient.ParameterToString(deleteDaysThreshold)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        public async System.Threading.Tasks.Task<PolicyEntityListing> GetRecordingCrossplatformMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = await GetRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors, deleteDaysThreshold);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        { 

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (enabled != null) localVarQueryParams.Add(new Tuple<string, string>("enabled", this.Configuration.ApiClient.ParameterToString(enabled)));
            if (summary != null) localVarQueryParams.Add(new Tuple<string, string>("summary", this.Configuration.ApiClient.ParameterToString(summary)));
            if (hasErrors != null) localVarQueryParams.Add(new Tuple<string, string>("hasErrors", this.Configuration.ApiClient.ParameterToString(hasErrors)));
            if (deleteDaysThreshold != null) localVarQueryParams.Add(new Tuple<string, string>("deleteDaysThreshold", this.Configuration.ApiClient.ParameterToString(deleteDaysThreshold)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>CrossPlatformPolicy</returns>
        public CrossPlatformPolicy GetRecordingCrossplatformMediaretentionpolicy (string policyId)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = GetRecordingCrossplatformMediaretentionpolicyWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        public ApiResponse< CrossPlatformPolicy > GetRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->GetRecordingCrossplatformMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        public async System.Threading.Tasks.Task<CrossPlatformPolicy> GetRecordingCrossplatformMediaretentionpolicyAsync (string policyId)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = await GetRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> GetRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->GetRecordingCrossplatformMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status of the job associated with the job id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>RecordingJob</returns>
        public RecordingJob GetRecordingJob (string jobId)
        {
             ApiResponse<RecordingJob> localVarResponse = GetRecordingJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the job associated with the job id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of RecordingJob</returns>
        public ApiResponse< RecordingJob > GetRecordingJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->GetRecordingJob");

            var localVarPath = "/api/v2/recording/jobs/{jobId}";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJob>(localVarStatusCode,
                localVarHeaders,
                (RecordingJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status of the job associated with the job id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of RecordingJob</returns>
        public async System.Threading.Tasks.Task<RecordingJob> GetRecordingJobAsync (string jobId)
        {
             ApiResponse<RecordingJob> localVarResponse = await GetRecordingJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of the job associated with the job id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (RecordingJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingJob>> GetRecordingJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->GetRecordingJob");
            

            var localVarPath = "/api/v2/recording/jobs/{jobId}";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJob>(localVarStatusCode,
                localVarHeaders,
                (RecordingJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get IDs of recordings that the bulk job failed for 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>FailedRecordingEntityListing</returns>
        public FailedRecordingEntityListing GetRecordingJobFailedrecordings (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null)
        {
             ApiResponse<FailedRecordingEntityListing> localVarResponse = GetRecordingJobFailedrecordingsWithHttpInfo(jobId, pageSize, pageNumber, includeTotal, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IDs of recordings that the bulk job failed for 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>ApiResponse of FailedRecordingEntityListing</returns>
        public ApiResponse< FailedRecordingEntityListing > GetRecordingJobFailedrecordingsWithHttpInfo (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->GetRecordingJobFailedrecordings");

            var localVarPath = "/api/v2/recording/jobs/{jobId}/failedrecordings";
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
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (includeTotal != null) localVarQueryParams.Add(new Tuple<string, string>("includeTotal", this.Configuration.ApiClient.ParameterToString(includeTotal)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobFailedrecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobFailedrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FailedRecordingEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FailedRecordingEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FailedRecordingEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get IDs of recordings that the bulk job failed for 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of FailedRecordingEntityListing</returns>
        public async System.Threading.Tasks.Task<FailedRecordingEntityListing> GetRecordingJobFailedrecordingsAsync (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null)
        {
             ApiResponse<FailedRecordingEntityListing> localVarResponse = await GetRecordingJobFailedrecordingsAsyncWithHttpInfo(jobId, pageSize, pageNumber, includeTotal, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IDs of recordings that the bulk job failed for 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="pageSize">Page size. Maximum is 100. (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of ApiResponse (FailedRecordingEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FailedRecordingEntityListing>> GetRecordingJobFailedrecordingsAsyncWithHttpInfo (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->GetRecordingJobFailedrecordings");
            

            var localVarPath = "/api/v2/recording/jobs/{jobId}/failedrecordings";
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
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (includeTotal != null) localVarQueryParams.Add(new Tuple<string, string>("includeTotal", this.Configuration.ApiClient.ParameterToString(includeTotal)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobFailedrecordings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobFailedrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FailedRecordingEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FailedRecordingEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FailedRecordingEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status of all jobs within the user's organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>RecordingJobEntityListing</returns>
        public RecordingJobEntityListing GetRecordingJobs (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null)
        {
             ApiResponse<RecordingJobEntityListing> localVarResponse = GetRecordingJobsWithHttpInfo(pageSize, pageNumber, sortBy, state, showOnlyMyJobs, jobType, includeTotal, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of all jobs within the user's organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>ApiResponse of RecordingJobEntityListing</returns>
        public ApiResponse< RecordingJobEntityListing > GetRecordingJobsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/recording/jobs";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));
            if (showOnlyMyJobs != null) localVarQueryParams.Add(new Tuple<string, string>("showOnlyMyJobs", this.Configuration.ApiClient.ParameterToString(showOnlyMyJobs)));
            if (jobType != null) localVarQueryParams.Add(new Tuple<string, string>("jobType", this.Configuration.ApiClient.ParameterToString(jobType)));
            if (includeTotal != null) localVarQueryParams.Add(new Tuple<string, string>("includeTotal", this.Configuration.ApiClient.ParameterToString(includeTotal)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJobEntityListing>(localVarStatusCode,
                localVarHeaders,
                (RecordingJobEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJobEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status of all jobs within the user's organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of RecordingJobEntityListing</returns>
        public async System.Threading.Tasks.Task<RecordingJobEntityListing> GetRecordingJobsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null)
        {
             ApiResponse<RecordingJobEntityListing> localVarResponse = await GetRecordingJobsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, state, showOnlyMyJobs, jobType, includeTotal, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of all jobs within the user's organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to userId)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="showOnlyMyJobs">Show only my jobs (optional)</param>
        /// <param name="jobType">Job Type (Can be left empty for both) (optional)</param>
        /// <param name="includeTotal">If false, cursor will be used to locate the page instead of pageNumber. (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <returns>Task of ApiResponse (RecordingJobEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingJobEntityListing>> GetRecordingJobsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/recording/jobs";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));
            if (showOnlyMyJobs != null) localVarQueryParams.Add(new Tuple<string, string>("showOnlyMyJobs", this.Configuration.ApiClient.ParameterToString(showOnlyMyJobs)));
            if (jobType != null) localVarQueryParams.Add(new Tuple<string, string>("jobType", this.Configuration.ApiClient.ParameterToString(jobType)));
            if (includeTotal != null) localVarQueryParams.Add(new Tuple<string, string>("includeTotal", this.Configuration.ApiClient.ParameterToString(includeTotal)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJobEntityListing>(localVarStatusCode,
                localVarHeaders,
                (RecordingJobEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJobEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        public RecordingEncryptionConfiguration GetRecordingKeyconfiguration (string keyConfigurationId)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = GetRecordingKeyconfigurationWithHttpInfo(keyConfigurationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        public ApiResponse< RecordingEncryptionConfiguration > GetRecordingKeyconfigurationWithHttpInfo (string keyConfigurationId)
        { 
            // verify the required parameter 'keyConfigurationId' is set
            if (keyConfigurationId == null)
                throw new ApiException(400, "Missing required parameter 'keyConfigurationId' when calling RecordingApi->GetRecordingKeyconfiguration");

            var localVarPath = "/api/v2/recording/keyconfigurations/{keyConfigurationId}";
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
            if (keyConfigurationId != null) localVarPathParams.Add("keyConfigurationId", this.Configuration.ApiClient.ParameterToString(keyConfigurationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<RecordingEncryptionConfiguration> GetRecordingKeyconfigurationAsync (string keyConfigurationId)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = await GetRecordingKeyconfigurationAsyncWithHttpInfo(keyConfigurationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> GetRecordingKeyconfigurationAsyncWithHttpInfo (string keyConfigurationId)
        { 
            // verify the required parameter 'keyConfigurationId' is set
            if (keyConfigurationId == null)
                throw new ApiException(400, "Missing required parameter 'keyConfigurationId' when calling RecordingApi->GetRecordingKeyconfiguration");
            

            var localVarPath = "/api/v2/recording/keyconfigurations/{keyConfigurationId}";
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
            if (keyConfigurationId != null) localVarPathParams.Add("keyConfigurationId", this.Configuration.ApiClient.ParameterToString(keyConfigurationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of key configurations data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RecordingEncryptionConfigurationListing</returns>
        public RecordingEncryptionConfigurationListing GetRecordingKeyconfigurations ()
        {
             ApiResponse<RecordingEncryptionConfigurationListing> localVarResponse = GetRecordingKeyconfigurationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of key configurations data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RecordingEncryptionConfigurationListing</returns>
        public ApiResponse< RecordingEncryptionConfigurationListing > GetRecordingKeyconfigurationsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/keyconfigurations";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfigurationListing>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfigurationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfigurationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of key configurations data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RecordingEncryptionConfigurationListing</returns>
        public async System.Threading.Tasks.Task<RecordingEncryptionConfigurationListing> GetRecordingKeyconfigurationsAsync ()
        {
             ApiResponse<RecordingEncryptionConfigurationListing> localVarResponse = await GetRecordingKeyconfigurationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of key configurations data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfigurationListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfigurationListing>> GetRecordingKeyconfigurationsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/keyconfigurations";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingKeyconfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfigurationListing>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfigurationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfigurationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        public LocalEncryptionConfiguration GetRecordingLocalkeysSetting (string settingsId)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = GetRecordingLocalkeysSettingWithHttpInfo(settingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        public ApiResponse< LocalEncryptionConfiguration > GetRecordingLocalkeysSettingWithHttpInfo (string settingsId)
        { 
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->GetRecordingLocalkeysSetting");

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", this.Configuration.ApiClient.ParameterToString(settingsId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfiguration> GetRecordingLocalkeysSettingAsync (string settingsId)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = await GetRecordingLocalkeysSettingAsyncWithHttpInfo(settingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> GetRecordingLocalkeysSettingAsyncWithHttpInfo (string settingsId)
        { 
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->GetRecordingLocalkeysSetting");
            

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", this.Configuration.ApiClient.ParameterToString(settingsId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LocalEncryptionConfigurationListing</returns>
        public LocalEncryptionConfigurationListing GetRecordingLocalkeysSettings ()
        {
             ApiResponse<LocalEncryptionConfigurationListing> localVarResponse = GetRecordingLocalkeysSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LocalEncryptionConfigurationListing</returns>
        public ApiResponse< LocalEncryptionConfigurationListing > GetRecordingLocalkeysSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfigurationListing>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfigurationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfigurationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LocalEncryptionConfigurationListing</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfigurationListing> GetRecordingLocalkeysSettingsAsync ()
        {
             ApiResponse<LocalEncryptionConfigurationListing> localVarResponse = await GetRecordingLocalkeysSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// gets a list local key settings data. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LocalEncryptionConfigurationListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfigurationListing>> GetRecordingLocalkeysSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfigurationListing>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfigurationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfigurationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        public PolicyEntityListing GetRecordingMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = GetRecordingMediaretentionpoliciesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors, deleteDaysThreshold);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        public ApiResponse< PolicyEntityListing > GetRecordingMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        { 

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (enabled != null) localVarQueryParams.Add(new Tuple<string, string>("enabled", this.Configuration.ApiClient.ParameterToString(enabled)));
            if (summary != null) localVarQueryParams.Add(new Tuple<string, string>("summary", this.Configuration.ApiClient.ParameterToString(summary)));
            if (hasErrors != null) localVarQueryParams.Add(new Tuple<string, string>("hasErrors", this.Configuration.ApiClient.ParameterToString(hasErrors)));
            if (deleteDaysThreshold != null) localVarQueryParams.Add(new Tuple<string, string>("deleteDaysThreshold", this.Configuration.ApiClient.ParameterToString(deleteDaysThreshold)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        public async System.Threading.Tasks.Task<PolicyEntityListing> GetRecordingMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = await GetRecordingMediaretentionpoliciesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors, deleteDaysThreshold);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <param name="deleteDaysThreshold">provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRecordingMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)
        { 

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (enabled != null) localVarQueryParams.Add(new Tuple<string, string>("enabled", this.Configuration.ApiClient.ParameterToString(enabled)));
            if (summary != null) localVarQueryParams.Add(new Tuple<string, string>("summary", this.Configuration.ApiClient.ParameterToString(summary)));
            if (hasErrors != null) localVarQueryParams.Add(new Tuple<string, string>("hasErrors", this.Configuration.ApiClient.ParameterToString(hasErrors)));
            if (deleteDaysThreshold != null) localVarQueryParams.Add(new Tuple<string, string>("deleteDaysThreshold", this.Configuration.ApiClient.ParameterToString(deleteDaysThreshold)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        public Policy GetRecordingMediaretentionpolicy (string policyId)
        {
             ApiResponse<Policy> localVarResponse = GetRecordingMediaretentionpolicyWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetRecordingMediaretentionpolicyWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->GetRecordingMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetRecordingMediaretentionpolicyAsync (string policyId)
        {
             ApiResponse<Policy> localVarResponse = await GetRecordingMediaretentionpolicyAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->GetRecordingMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        public EncryptionKeyEntityListing GetRecordingRecordingkeys (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = GetRecordingRecordingkeysWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        public ApiResponse< EncryptionKeyEntityListing > GetRecordingRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/recording/recordingkeys";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EncryptionKeyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        public async System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingRecordingkeysAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = await GetRecordingRecordingkeysAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/recording/recordingkeys";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EncryptionKeyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule GetRecordingRecordingkeysRotationschedule ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = GetRecordingRecordingkeysRotationscheduleWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > GetRecordingRecordingkeysRotationscheduleWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarHeaders,
                (KeyRotationSchedule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingRecordingkeysRotationscheduleAsync ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await GetRecordingRecordingkeysRotationscheduleAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingRecordingkeysRotationscheduleAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarHeaders,
                (KeyRotationSchedule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>RecordingSettings</returns>
        public RecordingSettings GetRecordingSettings (bool? createDefault = null)
        {
             ApiResponse<RecordingSettings> localVarResponse = GetRecordingSettingsWithHttpInfo(createDefault);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        public ApiResponse< RecordingSettings > GetRecordingSettingsWithHttpInfo (bool? createDefault = null)
        { 

            var localVarPath = "/api/v2/recording/settings";
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
            if (createDefault != null) localVarQueryParams.Add(new Tuple<string, string>("createDefault", this.Configuration.ApiClient.ParameterToString(createDefault)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarHeaders,
                (RecordingSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of RecordingSettings</returns>
        public async System.Threading.Tasks.Task<RecordingSettings> GetRecordingSettingsAsync (bool? createDefault = null)
        {
             ApiResponse<RecordingSettings> localVarResponse = await GetRecordingSettingsAsyncWithHttpInfo(createDefault);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> GetRecordingSettingsAsyncWithHttpInfo (bool? createDefault = null)
        { 

            var localVarPath = "/api/v2/recording/settings";
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
            if (createDefault != null) localVarQueryParams.Add(new Tuple<string, string>("createDefault", this.Configuration.ApiClient.ParameterToString(createDefault)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarHeaders,
                (RecordingSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for recording retention data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>RecordingRetentionCursorEntityListing</returns>
        public RecordingRetentionCursorEntityListing GetRecordingsRetentionQuery (int? retentionThresholdDays, string cursor = null, int? pageSize = null)
        {
             ApiResponse<RecordingRetentionCursorEntityListing> localVarResponse = GetRecordingsRetentionQueryWithHttpInfo(retentionThresholdDays, cursor, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for recording retention data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>ApiResponse of RecordingRetentionCursorEntityListing</returns>
        public ApiResponse< RecordingRetentionCursorEntityListing > GetRecordingsRetentionQueryWithHttpInfo (int? retentionThresholdDays, string cursor = null, int? pageSize = null)
        { 
            // verify the required parameter 'retentionThresholdDays' is set
            if (retentionThresholdDays == null)
                throw new ApiException(400, "Missing required parameter 'retentionThresholdDays' when calling RecordingApi->GetRecordingsRetentionQuery");

            var localVarPath = "/api/v2/recordings/retention/query";
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
            if (retentionThresholdDays != null) localVarQueryParams.Add(new Tuple<string, string>("retentionThresholdDays", this.Configuration.ApiClient.ParameterToString(retentionThresholdDays)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsRetentionQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsRetentionQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingRetentionCursorEntityListing>(localVarStatusCode,
                localVarHeaders,
                (RecordingRetentionCursorEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingRetentionCursorEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for recording retention data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>Task of RecordingRetentionCursorEntityListing</returns>
        public async System.Threading.Tasks.Task<RecordingRetentionCursorEntityListing> GetRecordingsRetentionQueryAsync (int? retentionThresholdDays, string cursor = null, int? pageSize = null)
        {
             ApiResponse<RecordingRetentionCursorEntityListing> localVarResponse = await GetRecordingsRetentionQueryAsyncWithHttpInfo(retentionThresholdDays, cursor, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for recording retention data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="retentionThresholdDays">Fetch retention data for recordings retained for more days than the provided value.</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size. Maximum is 500. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (RecordingRetentionCursorEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingRetentionCursorEntityListing>> GetRecordingsRetentionQueryAsyncWithHttpInfo (int? retentionThresholdDays, string cursor = null, int? pageSize = null)
        { 
            // verify the required parameter 'retentionThresholdDays' is set
            if (retentionThresholdDays == null)
                throw new ApiException(400, "Missing required parameter 'retentionThresholdDays' when calling RecordingApi->GetRecordingsRetentionQuery");
            

            var localVarPath = "/api/v2/recordings/retention/query";
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
            if (retentionThresholdDays != null) localVarQueryParams.Add(new Tuple<string, string>("retentionThresholdDays", this.Configuration.ApiClient.ParameterToString(retentionThresholdDays)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsRetentionQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsRetentionQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingRetentionCursorEntityListing>(localVarStatusCode,
                localVarHeaders,
                (RecordingRetentionCursorEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingRetentionCursorEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ScreenRecordingSessionListing</returns>
        public ScreenRecordingSessionListing GetRecordingsScreensessions (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ScreenRecordingSessionListing> localVarResponse = GetRecordingsScreensessionsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ScreenRecordingSessionListing</returns>
        public ApiResponse< ScreenRecordingSessionListing > GetRecordingsScreensessionsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/recordings/screensessions";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsScreensessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsScreensessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenRecordingSessionListing>(localVarStatusCode,
                localVarHeaders,
                (ScreenRecordingSessionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenRecordingSessionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ScreenRecordingSessionListing</returns>
        public async System.Threading.Tasks.Task<ScreenRecordingSessionListing> GetRecordingsScreensessionsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ScreenRecordingSessionListing> localVarResponse = await GetRecordingsScreensessionsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ScreenRecordingSessionListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScreenRecordingSessionListing>> GetRecordingsScreensessionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/recordings/screensessions";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsScreensessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingsScreensessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenRecordingSessionListing>(localVarStatusCode,
                localVarHeaders,
                (ScreenRecordingSessionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenRecordingSessionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>CrossPlatformPolicy</returns>
        public CrossPlatformPolicy PatchRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicyUpdate body)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = PatchRecordingCrossplatformMediaretentionpolicyWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        public ApiResponse< CrossPlatformPolicy > PatchRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId, CrossPlatformPolicyUpdate body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PatchRecordingCrossplatformMediaretentionpolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PatchRecordingCrossplatformMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        public async System.Threading.Tasks.Task<CrossPlatformPolicy> PatchRecordingCrossplatformMediaretentionpolicyAsync (string policyId, CrossPlatformPolicyUpdate body)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = await PatchRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> PatchRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId, CrossPlatformPolicyUpdate body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PatchRecordingCrossplatformMediaretentionpolicy");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PatchRecordingCrossplatformMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        public Policy PatchRecordingMediaretentionpolicy (string policyId, PolicyUpdate body)
        {
             ApiResponse<Policy> localVarResponse = PatchRecordingMediaretentionpolicyWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchRecordingMediaretentionpolicyWithHttpInfo (string policyId, PolicyUpdate body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PatchRecordingMediaretentionpolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PatchRecordingMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PatchRecordingMediaretentionpolicyAsync (string policyId, PolicyUpdate body)
        {
             ApiResponse<Policy> localVarResponse = await PatchRecordingMediaretentionpolicyAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId, PolicyUpdate body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PatchRecordingMediaretentionpolicy");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PatchRecordingMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchRecordingsScreensession (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        {
             PatchRecordingsScreensessionWithHttpInfo(recordingSessionId, body);
        }

        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchRecordingsScreensessionWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        { 
            // verify the required parameter 'recordingSessionId' is set
            if (recordingSessionId == null)
                throw new ApiException(400, "Missing required parameter 'recordingSessionId' when calling RecordingApi->PatchRecordingsScreensession");

            var localVarPath = "/api/v2/recordings/screensessions/{recordingSessionId}";
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
            if (recordingSessionId != null) localVarPathParams.Add("recordingSessionId", this.Configuration.ApiClient.ParameterToString(recordingSessionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingsScreensession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingsScreensession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchRecordingsScreensessionAsync (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        {
             await PatchRecordingsScreensessionAsyncWithHttpInfo(recordingSessionId, body);

        }

        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchRecordingsScreensessionAsyncWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        { 
            // verify the required parameter 'recordingSessionId' is set
            if (recordingSessionId == null)
                throw new ApiException(400, "Missing required parameter 'recordingSessionId' when calling RecordingApi->PatchRecordingsScreensession");
            

            var localVarPath = "/api/v2/recordings/screensessions/{recordingSessionId}";
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
            if (recordingSessionId != null) localVarPathParams.Add("recordingSessionId", this.Configuration.ApiClient.ParameterToString(recordingSessionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingsScreensession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRecordingsScreensession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        public Annotation PostConversationRecordingAnnotations (string conversationId, string recordingId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = PostConversationRecordingAnnotationsWithHttpInfo(conversationId, recordingId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > PostConversationRecordingAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PostConversationRecordingAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PostConversationRecordingAnnotations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostConversationRecordingAnnotations");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationRecordingAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationRecordingAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarHeaders,
                (Annotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> PostConversationRecordingAnnotationsAsync (string conversationId, string recordingId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = await PostConversationRecordingAnnotationsAsyncWithHttpInfo(conversationId, recordingId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> PostConversationRecordingAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PostConversationRecordingAnnotations");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PostConversationRecordingAnnotations");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostConversationRecordingAnnotations");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationRecordingAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationRecordingAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarHeaders,
                (Annotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>BatchDownloadJobSubmissionResult</returns>
        public BatchDownloadJobSubmissionResult PostRecordingBatchrequests (BatchDownloadJobSubmission body)
        {
             ApiResponse<BatchDownloadJobSubmissionResult> localVarResponse = PostRecordingBatchrequestsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>ApiResponse of BatchDownloadJobSubmissionResult</returns>
        public ApiResponse< BatchDownloadJobSubmissionResult > PostRecordingBatchrequestsWithHttpInfo (BatchDownloadJobSubmission body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingBatchrequests");

            var localVarPath = "/api/v2/recording/batchrequests";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingBatchrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingBatchrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BatchDownloadJobSubmissionResult>(localVarStatusCode,
                localVarHeaders,
                (BatchDownloadJobSubmissionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchDownloadJobSubmissionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>Task of BatchDownloadJobSubmissionResult</returns>
        public async System.Threading.Tasks.Task<BatchDownloadJobSubmissionResult> PostRecordingBatchrequestsAsync (BatchDownloadJobSubmission body)
        {
             ApiResponse<BatchDownloadJobSubmissionResult> localVarResponse = await PostRecordingBatchrequestsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Job submission criteria</param>
        /// <returns>Task of ApiResponse (BatchDownloadJobSubmissionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BatchDownloadJobSubmissionResult>> PostRecordingBatchrequestsAsyncWithHttpInfo (BatchDownloadJobSubmission body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingBatchrequests");
            

            var localVarPath = "/api/v2/recording/batchrequests";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingBatchrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingBatchrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BatchDownloadJobSubmissionResult>(localVarStatusCode,
                localVarHeaders,
                (BatchDownloadJobSubmissionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchDownloadJobSubmissionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>CrossPlatformPolicy</returns>
        public CrossPlatformPolicy PostRecordingCrossplatformMediaretentionpolicies (CrossPlatformPolicyCreate body)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = PostRecordingCrossplatformMediaretentionpoliciesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        public ApiResponse< CrossPlatformPolicy > PostRecordingCrossplatformMediaretentionpoliciesWithHttpInfo (CrossPlatformPolicyCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingCrossplatformMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        public async System.Threading.Tasks.Task<CrossPlatformPolicy> PostRecordingCrossplatformMediaretentionpoliciesAsync (CrossPlatformPolicyCreate body)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = await PostRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> PostRecordingCrossplatformMediaretentionpoliciesAsyncWithHttpInfo (CrossPlatformPolicyCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingCrossplatformMediaretentionpolicies");
            

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingCrossplatformMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a recording bulk job. Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>RecordingJob</returns>
        public RecordingJob PostRecordingJobs (RecordingJobsQuery body)
        {
             ApiResponse<RecordingJob> localVarResponse = PostRecordingJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a recording bulk job. Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of RecordingJob</returns>
        public ApiResponse< RecordingJob > PostRecordingJobsWithHttpInfo (RecordingJobsQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingJobs");

            var localVarPath = "/api/v2/recording/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJob>(localVarStatusCode,
                localVarHeaders,
                (RecordingJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a recording bulk job. Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of RecordingJob</returns>
        public async System.Threading.Tasks.Task<RecordingJob> PostRecordingJobsAsync (RecordingJobsQuery body)
        {
             ApiResponse<RecordingJob> localVarResponse = await PostRecordingJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a recording bulk job. Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (RecordingJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingJob>> PostRecordingJobsAsyncWithHttpInfo (RecordingJobsQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingJobs");
            

            var localVarPath = "/api/v2/recording/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJob>(localVarStatusCode,
                localVarHeaders,
                (RecordingJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Setup configurations for encryption key creation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        public RecordingEncryptionConfiguration PostRecordingKeyconfigurations (RecordingEncryptionConfiguration body)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = PostRecordingKeyconfigurationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Setup configurations for encryption key creation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        public ApiResponse< RecordingEncryptionConfiguration > PostRecordingKeyconfigurationsWithHttpInfo (RecordingEncryptionConfiguration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingKeyconfigurations");

            var localVarPath = "/api/v2/recording/keyconfigurations";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Setup configurations for encryption key creation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<RecordingEncryptionConfiguration> PostRecordingKeyconfigurationsAsync (RecordingEncryptionConfiguration body)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = await PostRecordingKeyconfigurationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Setup configurations for encryption key creation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> PostRecordingKeyconfigurationsAsyncWithHttpInfo (RecordingEncryptionConfiguration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingKeyconfigurations");
            

            var localVarPath = "/api/v2/recording/keyconfigurations";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Validate encryption key configurations without saving it 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        public RecordingEncryptionConfiguration PostRecordingKeyconfigurationsValidate (RecordingEncryptionConfiguration body)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = PostRecordingKeyconfigurationsValidateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate encryption key configurations without saving it 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        public ApiResponse< RecordingEncryptionConfiguration > PostRecordingKeyconfigurationsValidateWithHttpInfo (RecordingEncryptionConfiguration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingKeyconfigurationsValidate");

            var localVarPath = "/api/v2/recording/keyconfigurations/validate";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurationsValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurationsValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Validate encryption key configurations without saving it 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<RecordingEncryptionConfiguration> PostRecordingKeyconfigurationsValidateAsync (RecordingEncryptionConfiguration body)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = await PostRecordingKeyconfigurationsValidateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate encryption key configurations without saving it 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Encryption Configuration</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> PostRecordingKeyconfigurationsValidateAsyncWithHttpInfo (RecordingEncryptionConfiguration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingKeyconfigurationsValidate");
            

            var localVarPath = "/api/v2/recording/keyconfigurations/validate";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurationsValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingKeyconfigurationsValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// create a local key management recording key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey PostRecordingLocalkeys (LocalEncryptionKeyRequest body)
        {
             ApiResponse<EncryptionKey> localVarResponse = PostRecordingLocalkeysWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// create a local key management recording key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > PostRecordingLocalkeysWithHttpInfo (LocalEncryptionKeyRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingLocalkeys");

            var localVarPath = "/api/v2/recording/localkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarHeaders,
                (EncryptionKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// create a local key management recording key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> PostRecordingLocalkeysAsync (LocalEncryptionKeyRequest body)
        {
             ApiResponse<EncryptionKey> localVarResponse = await PostRecordingLocalkeysAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// create a local key management recording key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingLocalkeysAsyncWithHttpInfo (LocalEncryptionKeyRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingLocalkeys");
            

            var localVarPath = "/api/v2/recording/localkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarHeaders,
                (EncryptionKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        public LocalEncryptionConfiguration PostRecordingLocalkeysSettings (LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = PostRecordingLocalkeysSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        public ApiResponse< LocalEncryptionConfiguration > PostRecordingLocalkeysSettingsWithHttpInfo (LocalEncryptionConfiguration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingLocalkeysSettings");

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfiguration> PostRecordingLocalkeysSettingsAsync (LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = await PostRecordingLocalkeysSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// create settings for local key creation. Replaced by API recording/keyconfigurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PostRecordingLocalkeysSettingsAsyncWithHttpInfo (LocalEncryptionConfiguration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingLocalkeysSettings");
            

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        public Policy PostRecordingMediaretentionpolicies (PolicyCreate body)
        {
             ApiResponse<Policy> localVarResponse = PostRecordingMediaretentionpoliciesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PostRecordingMediaretentionpoliciesWithHttpInfo (PolicyCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PostRecordingMediaretentionpoliciesAsync (PolicyCreate body)
        {
             ApiResponse<Policy> localVarResponse = await PostRecordingMediaretentionpoliciesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PostRecordingMediaretentionpoliciesAsyncWithHttpInfo (PolicyCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingMediaretentionpolicies");
            

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey PostRecordingRecordingkeys ()
        {
             ApiResponse<EncryptionKey> localVarResponse = PostRecordingRecordingkeysWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > PostRecordingRecordingkeysWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/recordingkeys";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingRecordingkeys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarHeaders,
                (EncryptionKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> PostRecordingRecordingkeysAsync ()
        {
             ApiResponse<EncryptionKey> localVarResponse = await PostRecordingRecordingkeysAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingRecordingkeysAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/recording/recordingkeys";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingRecordingkeys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarHeaders,
                (EncryptionKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of conversations with protected recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>List&lt;AddressableEntityRef&gt;</returns>
        public List<AddressableEntityRef> PostRecordingsDeletionprotection (ConversationDeletionProtectionQuery body)
        {
             ApiResponse<List<AddressableEntityRef>> localVarResponse = PostRecordingsDeletionprotectionWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of conversations with protected recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>ApiResponse of List&lt;AddressableEntityRef&gt;</returns>
        public ApiResponse< List<AddressableEntityRef> > PostRecordingsDeletionprotectionWithHttpInfo (ConversationDeletionProtectionQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingsDeletionprotection");

            var localVarPath = "/api/v2/recordings/deletionprotection";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsDeletionprotection: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsDeletionprotection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AddressableEntityRef>>(localVarStatusCode,
                localVarHeaders,
                (List<AddressableEntityRef>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AddressableEntityRef>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of conversations with protected recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>Task of List&lt;AddressableEntityRef&gt;</returns>
        public async System.Threading.Tasks.Task<List<AddressableEntityRef>> PostRecordingsDeletionprotectionAsync (ConversationDeletionProtectionQuery body)
        {
             ApiResponse<List<AddressableEntityRef>> localVarResponse = await PostRecordingsDeletionprotectionAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of conversations with protected recordings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">conversationIds</param>
        /// <returns>Task of ApiResponse (List&lt;AddressableEntityRef&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AddressableEntityRef>>> PostRecordingsDeletionprotectionAsyncWithHttpInfo (ConversationDeletionProtectionQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingsDeletionprotection");
            

            var localVarPath = "/api/v2/recordings/deletionprotection";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsDeletionprotection: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsDeletionprotection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AddressableEntityRef>>(localVarStatusCode,
                localVarHeaders,
                (List<AddressableEntityRef>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AddressableEntityRef>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Acknowledge a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns></returns>
        public void PostRecordingsScreensessionsAcknowledge (AcknowledgeScreenRecordingRequest body)
        {
             PostRecordingsScreensessionsAcknowledgeWithHttpInfo(body);
        }

        /// <summary>
        /// Acknowledge a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostRecordingsScreensessionsAcknowledgeWithHttpInfo (AcknowledgeScreenRecordingRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingsScreensessionsAcknowledge");

            var localVarPath = "/api/v2/recordings/screensessions/acknowledge";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsAcknowledge: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsAcknowledge: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Acknowledge a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostRecordingsScreensessionsAcknowledgeAsync (AcknowledgeScreenRecordingRequest body)
        {
             await PostRecordingsScreensessionsAcknowledgeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Acknowledge a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AcknowledgeScreenRecordingRequest</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostRecordingsScreensessionsAcknowledgeAsyncWithHttpInfo (AcknowledgeScreenRecordingRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingsScreensessionsAcknowledge");
            

            var localVarPath = "/api/v2/recordings/screensessions/acknowledge";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsAcknowledge: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsAcknowledge: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Provide meta-data a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns></returns>
        public void PostRecordingsScreensessionsMetadata (ScreenRecordingMetaDataRequest body)
        {
             PostRecordingsScreensessionsMetadataWithHttpInfo(body);
        }

        /// <summary>
        /// Provide meta-data a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostRecordingsScreensessionsMetadataWithHttpInfo (ScreenRecordingMetaDataRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingsScreensessionsMetadata");

            var localVarPath = "/api/v2/recordings/screensessions/metadata";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsMetadata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsMetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Provide meta-data a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostRecordingsScreensessionsMetadataAsync (ScreenRecordingMetaDataRequest body)
        {
             await PostRecordingsScreensessionsMetadataAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Provide meta-data a screen recording. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ScreenRecordingMetaDataRequest</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostRecordingsScreensessionsMetadataAsyncWithHttpInfo (ScreenRecordingMetaDataRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostRecordingsScreensessionsMetadata");
            

            var localVarPath = "/api/v2/recordings/screensessions/metadata";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsMetadata: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingsScreensessionsMetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>Recording</returns>
        public Recording PutConversationRecording (string conversationId, string recordingId, Recording body, bool? clearExport = null)
        {
             ApiResponse<Recording> localVarResponse = PutConversationRecordingWithHttpInfo(conversationId, recordingId, body, clearExport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > PutConversationRecordingWithHttpInfo (string conversationId, string recordingId, Recording body, bool? clearExport = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationRecording");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationRecording");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationRecording");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

            // Query params
            if (clearExport != null) localVarQueryParams.Add(new Tuple<string, string>("clearExport", this.Configuration.ApiClient.ParameterToString(clearExport)));

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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> PutConversationRecordingAsync (string conversationId, string recordingId, Recording body, bool? clearExport = null)
        {
             ApiResponse<Recording> localVarResponse = await PutConversationRecordingAsyncWithHttpInfo(conversationId, recordingId, body, clearExport);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="clearExport">Whether to clear the pending export for the recording (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> PutConversationRecordingAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, bool? clearExport = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationRecording");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationRecording");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationRecording");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));

            // Query params
            if (clearExport != null) localVarQueryParams.Add(new Tuple<string, string>("clearExport", this.Configuration.ApiClient.ParameterToString(clearExport)));

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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        public Annotation PutConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = PutConversationRecordingAnnotationWithHttpInfo(conversationId, recordingId, annotationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > PutConversationRecordingAnnotationWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationRecordingAnnotation");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationRecordingAnnotation");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->PutConversationRecordingAnnotation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationRecordingAnnotation");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecordingAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecordingAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarHeaders,
                (Annotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> PutConversationRecordingAnnotationAsync (string conversationId, string recordingId, string annotationId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = await PutConversationRecordingAnnotationAsyncWithHttpInfo(conversationId, recordingId, annotationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> PutConversationRecordingAnnotationAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationRecordingAnnotation");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationRecordingAnnotation");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->PutConversationRecordingAnnotation");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationRecordingAnnotation");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", this.Configuration.ApiClient.ParameterToString(recordingId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecordingAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationRecordingAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarHeaders,
                (Annotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Recording</returns>
        public Recording PutOrphanrecording (string orphanId, OrphanUpdateRequest body = null)
        {
             ApiResponse<Recording> localVarResponse = PutOrphanrecordingWithHttpInfo(orphanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > PutOrphanrecordingWithHttpInfo (string orphanId, OrphanUpdateRequest body = null)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->PutOrphanrecording");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanrecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanrecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> PutOrphanrecordingAsync (string orphanId, OrphanUpdateRequest body = null)
        {
             ApiResponse<Recording> localVarResponse = await PutOrphanrecordingAsyncWithHttpInfo(orphanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> PutOrphanrecordingAsyncWithHttpInfo (string orphanId, OrphanUpdateRequest body = null)
        { 
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->PutOrphanrecording");
            

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", this.Configuration.ApiClient.ParameterToString(orphanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanrecording: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanrecording: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarHeaders,
                (Recording) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>CrossPlatformPolicy</returns>
        public CrossPlatformPolicy PutRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicy body)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = PutRecordingCrossplatformMediaretentionpolicyWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of CrossPlatformPolicy</returns>
        public ApiResponse< CrossPlatformPolicy > PutRecordingCrossplatformMediaretentionpolicyWithHttpInfo (string policyId, CrossPlatformPolicy body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PutRecordingCrossplatformMediaretentionpolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingCrossplatformMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of CrossPlatformPolicy</returns>
        public async System.Threading.Tasks.Task<CrossPlatformPolicy> PutRecordingCrossplatformMediaretentionpolicyAsync (string policyId, CrossPlatformPolicy body)
        {
             ApiResponse<CrossPlatformPolicy> localVarResponse = await PutRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (CrossPlatformPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CrossPlatformPolicy>> PutRecordingCrossplatformMediaretentionpolicyAsyncWithHttpInfo (string policyId, CrossPlatformPolicy body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PutRecordingCrossplatformMediaretentionpolicy");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingCrossplatformMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/crossplatform/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingCrossplatformMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CrossPlatformPolicy>(localVarStatusCode,
                localVarHeaders,
                (CrossPlatformPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CrossPlatformPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Execute the recording bulk job. A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>RecordingJob</returns>
        public RecordingJob PutRecordingJob (string jobId, ExecuteRecordingJobsQuery body)
        {
             ApiResponse<RecordingJob> localVarResponse = PutRecordingJobWithHttpInfo(jobId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Execute the recording bulk job. A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of RecordingJob</returns>
        public ApiResponse< RecordingJob > PutRecordingJobWithHttpInfo (string jobId, ExecuteRecordingJobsQuery body)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->PutRecordingJob");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingJob");

            var localVarPath = "/api/v2/recording/jobs/{jobId}";
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
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJob>(localVarStatusCode,
                localVarHeaders,
                (RecordingJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Execute the recording bulk job. A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>Task of RecordingJob</returns>
        public async System.Threading.Tasks.Task<RecordingJob> PutRecordingJobAsync (string jobId, ExecuteRecordingJobsQuery body)
        {
             ApiResponse<RecordingJob> localVarResponse = await PutRecordingJobAsyncWithHttpInfo(jobId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Execute the recording bulk job. A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (RecordingJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingJob>> PutRecordingJobAsyncWithHttpInfo (string jobId, ExecuteRecordingJobsQuery body)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling RecordingApi->PutRecordingJob");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingJob");
            

            var localVarPath = "/api/v2/recording/jobs/{jobId}";
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
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingJob>(localVarStatusCode,
                localVarHeaders,
                (RecordingJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>RecordingEncryptionConfiguration</returns>
        public RecordingEncryptionConfiguration PutRecordingKeyconfiguration (string keyConfigurationId, RecordingEncryptionConfiguration body)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = PutRecordingKeyconfigurationWithHttpInfo(keyConfigurationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>ApiResponse of RecordingEncryptionConfiguration</returns>
        public ApiResponse< RecordingEncryptionConfiguration > PutRecordingKeyconfigurationWithHttpInfo (string keyConfigurationId, RecordingEncryptionConfiguration body)
        { 
            // verify the required parameter 'keyConfigurationId' is set
            if (keyConfigurationId == null)
                throw new ApiException(400, "Missing required parameter 'keyConfigurationId' when calling RecordingApi->PutRecordingKeyconfiguration");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingKeyconfiguration");

            var localVarPath = "/api/v2/recording/keyconfigurations/{keyConfigurationId}";
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
            if (keyConfigurationId != null) localVarPathParams.Add("keyConfigurationId", this.Configuration.ApiClient.ParameterToString(keyConfigurationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingKeyconfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingKeyconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>Task of RecordingEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<RecordingEncryptionConfiguration> PutRecordingKeyconfigurationAsync (string keyConfigurationId, RecordingEncryptionConfiguration body)
        {
             ApiResponse<RecordingEncryptionConfiguration> localVarResponse = await PutRecordingKeyconfigurationAsyncWithHttpInfo(keyConfigurationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the encryption key configurations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyConfigurationId">Key Configurations Id</param>
        /// <param name="body">Encryption key configuration metadata</param>
        /// <returns>Task of ApiResponse (RecordingEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingEncryptionConfiguration>> PutRecordingKeyconfigurationAsyncWithHttpInfo (string keyConfigurationId, RecordingEncryptionConfiguration body)
        { 
            // verify the required parameter 'keyConfigurationId' is set
            if (keyConfigurationId == null)
                throw new ApiException(400, "Missing required parameter 'keyConfigurationId' when calling RecordingApi->PutRecordingKeyconfiguration");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingKeyconfiguration");
            

            var localVarPath = "/api/v2/recording/keyconfigurations/{keyConfigurationId}";
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
            if (keyConfigurationId != null) localVarPathParams.Add("keyConfigurationId", this.Configuration.ApiClient.ParameterToString(keyConfigurationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingKeyconfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingKeyconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (RecordingEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        public LocalEncryptionConfiguration PutRecordingLocalkeysSetting (string settingsId, LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = PutRecordingLocalkeysSettingWithHttpInfo(settingsId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        public ApiResponse< LocalEncryptionConfiguration > PutRecordingLocalkeysSettingWithHttpInfo (string settingsId, LocalEncryptionConfiguration body)
        { 
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->PutRecordingLocalkeysSetting");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingLocalkeysSetting");

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", this.Configuration.ApiClient.ParameterToString(settingsId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingLocalkeysSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingLocalkeysSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfiguration> PutRecordingLocalkeysSettingAsync (string settingsId, LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = await PutRecordingLocalkeysSettingAsyncWithHttpInfo(settingsId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the local encryption settings. Replaced by API recording/keyconfigurations/{keyConfigurationId} 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PutRecordingLocalkeysSettingAsyncWithHttpInfo (string settingsId, LocalEncryptionConfiguration body)
        { 
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->PutRecordingLocalkeysSetting");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingLocalkeysSetting");
            

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", this.Configuration.ApiClient.ParameterToString(settingsId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingLocalkeysSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingLocalkeysSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarHeaders,
                (LocalEncryptionConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        public Policy PutRecordingMediaretentionpolicy (string policyId, Policy body)
        {
             ApiResponse<Policy> localVarResponse = PutRecordingMediaretentionpolicyWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PutRecordingMediaretentionpolicyWithHttpInfo (string policyId, Policy body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PutRecordingMediaretentionpolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingMediaretentionpolicy");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PutRecordingMediaretentionpolicyAsync (string policyId, Policy body)
        {
             ApiResponse<Policy> localVarResponse = await PutRecordingMediaretentionpolicyAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a media retention policy Policy does not work retroactively
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PutRecordingMediaretentionpolicyAsyncWithHttpInfo (string policyId, Policy body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PutRecordingMediaretentionpolicy");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingMediaretentionpolicy");
            

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingMediaretentionpolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingMediaretentionpolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarHeaders,
                (Policy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule PutRecordingRecordingkeysRotationschedule (KeyRotationSchedule body)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = PutRecordingRecordingkeysRotationscheduleWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > PutRecordingRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingRecordingkeysRotationschedule");

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarHeaders,
                (KeyRotationSchedule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingRecordingkeysRotationscheduleAsync (KeyRotationSchedule body)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await PutRecordingRecordingkeysRotationscheduleAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingRecordingkeysRotationschedule");
            

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarHeaders,
                (KeyRotationSchedule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>RecordingSettings</returns>
        public RecordingSettings PutRecordingSettings (RecordingSettings body)
        {
             ApiResponse<RecordingSettings> localVarResponse = PutRecordingSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        public ApiResponse< RecordingSettings > PutRecordingSettingsWithHttpInfo (RecordingSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingSettings");

            var localVarPath = "/api/v2/recording/settings";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarHeaders,
                (RecordingSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of RecordingSettings</returns>
        public async System.Threading.Tasks.Task<RecordingSettings> PutRecordingSettingsAsync (RecordingSettings body)
        {
             ApiResponse<RecordingSettings> localVarResponse = await PutRecordingSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> PutRecordingSettingsAsyncWithHttpInfo (RecordingSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingSettings");
            

            var localVarPath = "/api/v2/recording/settings";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarHeaders,
                (RecordingSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Apply or revoke recording protection for conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PutRecordingsDeletionprotection (bool? protect = null, ConversationDeletionProtectionQuery body = null)
        {
             PutRecordingsDeletionprotectionWithHttpInfo(protect, body);
        }

        /// <summary>
        /// Apply or revoke recording protection for conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutRecordingsDeletionprotectionWithHttpInfo (bool? protect = null, ConversationDeletionProtectionQuery body = null)
        { 

            var localVarPath = "/api/v2/recordings/deletionprotection";
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
            if (protect != null) localVarQueryParams.Add(new Tuple<string, string>("protect", this.Configuration.ApiClient.ParameterToString(protect)));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingsDeletionprotection: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingsDeletionprotection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Apply or revoke recording protection for conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PutRecordingsDeletionprotectionAsync (bool? protect = null, ConversationDeletionProtectionQuery body = null)
        {
             await PutRecordingsDeletionprotectionAsyncWithHttpInfo(protect, body);

        }

        /// <summary>
        /// Apply or revoke recording protection for conversations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protect">Check for apply, uncheck for revoke (each action requires the respective permission) (optional, default to true)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutRecordingsDeletionprotectionAsyncWithHttpInfo (bool? protect = null, ConversationDeletionProtectionQuery body = null)
        { 

            var localVarPath = "/api/v2/recordings/deletionprotection";
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
            if (protect != null) localVarQueryParams.Add(new Tuple<string, string>("protect", this.Configuration.ApiClient.ParameterToString(protect)));

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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingsDeletionprotection: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingsDeletionprotection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
