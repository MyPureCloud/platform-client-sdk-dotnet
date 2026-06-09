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
    public interface ITelephonyApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns></returns>
        
        void DeleteTelephonyOrganizationLinkTargetOrganizationId (string targetOrganizationId);

        /// <summary>
        /// Delete a link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTelephonyOrganizationLinkTargetOrganizationIdWithHttpInfo (string targetOrganizationId);

        /// <summary>
        /// Get an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>AgentGreeting</returns>
        
        AgentGreeting GetTelephonyAgentGreetings (string agentId);

        /// <summary>
        /// Get an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>ApiResponse of AgentGreeting</returns>
        
        ApiResponse<AgentGreeting> GetTelephonyAgentGreetingsWithHttpInfo (string agentId);

        /// <summary>
        /// Get the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SelfAgentGreeting</returns>
        
        SelfAgentGreeting GetTelephonyAgentsGreetingsMe ();

        /// <summary>
        /// Get the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SelfAgentGreeting</returns>
        
        ApiResponse<SelfAgentGreeting> GetTelephonyAgentsGreetingsMeWithHttpInfo ();

        /// <summary>
        /// Get the concurrent call metrics for a given organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>OrganizationCallMetrics</returns>
        
        OrganizationCallMetrics GetTelephonyCallsMetrics (string metricType = null);

        /// <summary>
        /// Get the concurrent call metrics for a given organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>ApiResponse of OrganizationCallMetrics</returns>
        
        ApiResponse<OrganizationCallMetrics> GetTelephonyCallsMetricsWithHttpInfo (string metricType = null);

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MediaRegions</returns>
        
        MediaRegions GetTelephonyMediaregions ();

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MediaRegions</returns>
        
        ApiResponse<MediaRegions> GetTelephonyMediaregionsWithHttpInfo ();

        /// <summary>
        /// Get Number Routings by organizationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>NumberRoutingListing</returns>
        
        NumberRoutingListing GetTelephonyNumbersRouting (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null);

        /// <summary>
        /// Get Number Routings by organizationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>ApiResponse of NumberRoutingListing</returns>
        
        ApiResponse<NumberRoutingListing> GetTelephonyNumbersRoutingWithHttpInfo (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null);

        /// <summary>
        /// Get organization links
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;OrganizationLinkResponse&gt;</returns>
        
        List<OrganizationLinkResponse> GetTelephonyOrganizationLink ();

        /// <summary>
        /// Get organization links
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;OrganizationLinkResponse&gt;</returns>
        
        ApiResponse<List<OrganizationLinkResponse>> GetTelephonyOrganizationLinkWithHttpInfo ();

        /// <summary>
        /// Get all the replica regions by primary region
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RegionResponse&gt;</returns>
        
        List<RegionResponse> GetTelephonyOrganizationLinkRegions ();

        /// <summary>
        /// Get all the replica regions by primary region
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RegionResponse&gt;</returns>
        
        ApiResponse<List<RegionResponse>> GetTelephonyOrganizationLinkRegionsWithHttpInfo ();

        /// <summary>
        /// Get the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TelephonySettings</returns>
        
        TelephonySettings GetTelephonySettings ();

        /// <summary>
        /// Get the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TelephonySettings</returns>
        
        ApiResponse<TelephonySettings> GetTelephonySettingsWithHttpInfo ();

        /// <summary>
        /// Get a SIP message.
        /// </summary>
        /// <remarks>
        /// Get the raw form of the SIP message
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>Callmessage</returns>
        
        Callmessage GetTelephonySipmessagesConversation (string conversationId);

        /// <summary>
        /// Get a SIP message.
        /// </summary>
        /// <remarks>
        /// Get the raw form of the SIP message
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>ApiResponse of Callmessage</returns>
        
        ApiResponse<Callmessage> GetTelephonySipmessagesConversationWithHttpInfo (string conversationId);

        /// <summary>
        /// Get SIP headers.
        /// </summary>
        /// <remarks>
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>Callheader</returns>
        
        Callheader GetTelephonySipmessagesConversationHeaders (string conversationId, List<string> keys = null);

        /// <summary>
        /// Get SIP headers.
        /// </summary>
        /// <remarks>
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>ApiResponse of Callheader</returns>
        
        ApiResponse<Callheader> GetTelephonySipmessagesConversationHeadersWithHttpInfo (string conversationId, List<string> keys = null);

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>SipSearchResult</returns>
        
        SipSearchResult GetTelephonySiptraces (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>ApiResponse of SipSearchResult</returns>
        
        ApiResponse<SipSearchResult> GetTelephonySiptracesWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>SignedUrlResponse</returns>
        
        SignedUrlResponse GetTelephonySiptracesDownloadDownloadId (string downloadId);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>ApiResponse of SignedUrlResponse</returns>
        
        ApiResponse<SignedUrlResponse> GetTelephonySiptracesDownloadDownloadIdWithHttpInfo (string downloadId);

        /// <summary>
        /// Approving a requested link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns></returns>
        
        void PatchTelephonyOrganizationLinkApproveRequestingOrganizationId (string requestingOrganizationId, OrganizationLinkApprovalRequest body);

        /// <summary>
        /// Approving a requested link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdWithHttpInfo (string requestingOrganizationId, OrganizationLinkApprovalRequest body);

        /// <summary>
        /// Update the routing of numbers for one or multiple organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns></returns>
        
        void PostTelephonyNumbersRouting (List<NumberRoutingRequest> body);

        /// <summary>
        /// Update the routing of numbers for one or multiple organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostTelephonyNumbersRoutingWithHttpInfo (List<NumberRoutingRequest> body);

        /// <summary>
        /// Re-route all numbers on an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns></returns>
        
        void PostTelephonyNumbersRoutingAll (DisasterRecoveryAllRoutingRequest body);

        /// <summary>
        /// Re-route all numbers on an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostTelephonyNumbersRoutingAllWithHttpInfo (DisasterRecoveryAllRoutingRequest body);

        /// <summary>
        /// Reset routing for organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns></returns>
        
        void PostTelephonyNumbersRoutingReset (NumberRoutingResetOrganizationRequest body);

        /// <summary>
        /// Reset routing for organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostTelephonyNumbersRoutingResetWithHttpInfo (NumberRoutingResetOrganizationRequest body);

        /// <summary>
        /// Create a link with an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>OrganizationLink</returns>
        
        OrganizationLink PostTelephonyOrganizationLink (CreateOrganizationLink body);

        /// <summary>
        /// Create a link with an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>ApiResponse of OrganizationLink</returns>
        
        ApiResponse<OrganizationLink> PostTelephonyOrganizationLinkWithHttpInfo (CreateOrganizationLink body);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>SipDownloadResponse</returns>
        
        SipDownloadResponse PostTelephonySiptracesDownload (SIPSearchPublicRequest sIPSearchPublicRequest);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>ApiResponse of SipDownloadResponse</returns>
        
        ApiResponse<SipDownloadResponse> PostTelephonySiptracesDownloadWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest);

        /// <summary>
        /// Updates an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>AgentGreeting</returns>
        
        AgentGreeting PutTelephonyAgentGreetings (string agentId, AgentGreeting body);

        /// <summary>
        /// Updates an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>ApiResponse of AgentGreeting</returns>
        
        ApiResponse<AgentGreeting> PutTelephonyAgentGreetingsWithHttpInfo (string agentId, AgentGreeting body);

        /// <summary>
        /// Updates the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>SelfAgentGreeting</returns>
        
        SelfAgentGreeting PutTelephonyAgentsGreetingsMe (SelfAgentGreeting body);

        /// <summary>
        /// Updates the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>ApiResponse of SelfAgentGreeting</returns>
        
        ApiResponse<SelfAgentGreeting> PutTelephonyAgentsGreetingsMeWithHttpInfo (SelfAgentGreeting body);

        /// <summary>
        /// Update the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>TelephonySettings</returns>
        
        TelephonySettings PutTelephonySettings (TelephonySettings body);

        /// <summary>
        /// Update the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>ApiResponse of TelephonySettings</returns>
        
        ApiResponse<TelephonySettings> PutTelephonySettingsWithHttpInfo (TelephonySettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTelephonyOrganizationLinkTargetOrganizationIdAsync (string targetOrganizationId);

        /// <summary>
        /// Delete a link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTelephonyOrganizationLinkTargetOrganizationIdAsyncWithHttpInfo (string targetOrganizationId);

        /// <summary>
        /// Get an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>Task of AgentGreeting</returns>
        
        System.Threading.Tasks.Task<AgentGreeting> GetTelephonyAgentGreetingsAsync (string agentId);

        /// <summary>
        /// Get an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>Task of ApiResponse (AgentGreeting)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentGreeting>> GetTelephonyAgentGreetingsAsyncWithHttpInfo (string agentId);

        /// <summary>
        /// Get the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SelfAgentGreeting</returns>
        
        System.Threading.Tasks.Task<SelfAgentGreeting> GetTelephonyAgentsGreetingsMeAsync ();

        /// <summary>
        /// Get the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SelfAgentGreeting)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SelfAgentGreeting>> GetTelephonyAgentsGreetingsMeAsyncWithHttpInfo ();

        /// <summary>
        /// Get the concurrent call metrics for a given organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>Task of OrganizationCallMetrics</returns>
        
        System.Threading.Tasks.Task<OrganizationCallMetrics> GetTelephonyCallsMetricsAsync (string metricType = null);

        /// <summary>
        /// Get the concurrent call metrics for a given organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>Task of ApiResponse (OrganizationCallMetrics)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OrganizationCallMetrics>> GetTelephonyCallsMetricsAsyncWithHttpInfo (string metricType = null);

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MediaRegions</returns>
        
        System.Threading.Tasks.Task<MediaRegions> GetTelephonyMediaregionsAsync ();

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MediaRegions)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MediaRegions>> GetTelephonyMediaregionsAsyncWithHttpInfo ();

        /// <summary>
        /// Get Number Routings by organizationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>Task of NumberRoutingListing</returns>
        
        System.Threading.Tasks.Task<NumberRoutingListing> GetTelephonyNumbersRoutingAsync (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null);

        /// <summary>
        /// Get Number Routings by organizationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>Task of ApiResponse (NumberRoutingListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<NumberRoutingListing>> GetTelephonyNumbersRoutingAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null);

        /// <summary>
        /// Get organization links
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;OrganizationLinkResponse&gt;</returns>
        
        System.Threading.Tasks.Task<List<OrganizationLinkResponse>> GetTelephonyOrganizationLinkAsync ();

        /// <summary>
        /// Get organization links
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;OrganizationLinkResponse&gt;)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<List<OrganizationLinkResponse>>> GetTelephonyOrganizationLinkAsyncWithHttpInfo ();

        /// <summary>
        /// Get all the replica regions by primary region
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RegionResponse&gt;</returns>
        
        System.Threading.Tasks.Task<List<RegionResponse>> GetTelephonyOrganizationLinkRegionsAsync ();

        /// <summary>
        /// Get all the replica regions by primary region
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RegionResponse&gt;)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<List<RegionResponse>>> GetTelephonyOrganizationLinkRegionsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TelephonySettings</returns>
        
        System.Threading.Tasks.Task<TelephonySettings> GetTelephonySettingsAsync ();

        /// <summary>
        /// Get the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TelephonySettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TelephonySettings>> GetTelephonySettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get a SIP message.
        /// </summary>
        /// <remarks>
        /// Get the raw form of the SIP message
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>Task of Callmessage</returns>
        
        System.Threading.Tasks.Task<Callmessage> GetTelephonySipmessagesConversationAsync (string conversationId);

        /// <summary>
        /// Get a SIP message.
        /// </summary>
        /// <remarks>
        /// Get the raw form of the SIP message
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>Task of ApiResponse (Callmessage)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Callmessage>> GetTelephonySipmessagesConversationAsyncWithHttpInfo (string conversationId);

        /// <summary>
        /// Get SIP headers.
        /// </summary>
        /// <remarks>
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>Task of Callheader</returns>
        
        System.Threading.Tasks.Task<Callheader> GetTelephonySipmessagesConversationHeadersAsync (string conversationId, List<string> keys = null);

        /// <summary>
        /// Get SIP headers.
        /// </summary>
        /// <remarks>
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>Task of ApiResponse (Callheader)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Callheader>> GetTelephonySipmessagesConversationHeadersAsyncWithHttpInfo (string conversationId, List<string> keys = null);

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of SipSearchResult</returns>
        
        System.Threading.Tasks.Task<SipSearchResult> GetTelephonySiptracesAsync (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of ApiResponse (SipSearchResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SipSearchResult>> GetTelephonySiptracesAsyncWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of SignedUrlResponse</returns>
        
        System.Threading.Tasks.Task<SignedUrlResponse> GetTelephonySiptracesDownloadDownloadIdAsync (string downloadId);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of ApiResponse (SignedUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SignedUrlResponse>> GetTelephonySiptracesDownloadDownloadIdAsyncWithHttpInfo (string downloadId);

        /// <summary>
        /// Approving a requested link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdAsync (string requestingOrganizationId, OrganizationLinkApprovalRequest body);

        /// <summary>
        /// Approving a requested link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdAsyncWithHttpInfo (string requestingOrganizationId, OrganizationLinkApprovalRequest body);

        /// <summary>
        /// Update the routing of numbers for one or multiple organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostTelephonyNumbersRoutingAsync (List<NumberRoutingRequest> body);

        /// <summary>
        /// Update the routing of numbers for one or multiple organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyNumbersRoutingAsyncWithHttpInfo (List<NumberRoutingRequest> body);

        /// <summary>
        /// Re-route all numbers on an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostTelephonyNumbersRoutingAllAsync (DisasterRecoveryAllRoutingRequest body);

        /// <summary>
        /// Re-route all numbers on an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyNumbersRoutingAllAsyncWithHttpInfo (DisasterRecoveryAllRoutingRequest body);

        /// <summary>
        /// Reset routing for organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostTelephonyNumbersRoutingResetAsync (NumberRoutingResetOrganizationRequest body);

        /// <summary>
        /// Reset routing for organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyNumbersRoutingResetAsyncWithHttpInfo (NumberRoutingResetOrganizationRequest body);

        /// <summary>
        /// Create a link with an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>Task of OrganizationLink</returns>
        
        System.Threading.Tasks.Task<OrganizationLink> PostTelephonyOrganizationLinkAsync (CreateOrganizationLink body);

        /// <summary>
        /// Create a link with an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>Task of ApiResponse (OrganizationLink)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OrganizationLink>> PostTelephonyOrganizationLinkAsyncWithHttpInfo (CreateOrganizationLink body);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of SipDownloadResponse</returns>
        
        System.Threading.Tasks.Task<SipDownloadResponse> PostTelephonySiptracesDownloadAsync (SIPSearchPublicRequest sIPSearchPublicRequest);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of ApiResponse (SipDownloadResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SipDownloadResponse>> PostTelephonySiptracesDownloadAsyncWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest);

        /// <summary>
        /// Updates an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of AgentGreeting</returns>
        
        System.Threading.Tasks.Task<AgentGreeting> PutTelephonyAgentGreetingsAsync (string agentId, AgentGreeting body);

        /// <summary>
        /// Updates an agent&#39;s greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of ApiResponse (AgentGreeting)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentGreeting>> PutTelephonyAgentGreetingsAsyncWithHttpInfo (string agentId, AgentGreeting body);

        /// <summary>
        /// Updates the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of SelfAgentGreeting</returns>
        
        System.Threading.Tasks.Task<SelfAgentGreeting> PutTelephonyAgentsGreetingsMeAsync (SelfAgentGreeting body);

        /// <summary>
        /// Updates the agent&#39;s own greetings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of ApiResponse (SelfAgentGreeting)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SelfAgentGreeting>> PutTelephonyAgentsGreetingsMeAsyncWithHttpInfo (SelfAgentGreeting body);

        /// <summary>
        /// Update the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>Task of TelephonySettings</returns>
        
        System.Threading.Tasks.Task<TelephonySettings> PutTelephonySettingsAsync (TelephonySettings body);

        /// <summary>
        /// Update the global telephony configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>Task of ApiResponse (TelephonySettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TelephonySettings>> PutTelephonySettingsAsyncWithHttpInfo (TelephonySettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TelephonyApi : ITelephonyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelephonyApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelephonyApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns></returns>
        
        public void DeleteTelephonyOrganizationLinkTargetOrganizationId (string targetOrganizationId)
        {
             DeleteTelephonyOrganizationLinkTargetOrganizationIdWithHttpInfo(targetOrganizationId);
        }

        /// <summary>
        /// Delete a link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTelephonyOrganizationLinkTargetOrganizationIdWithHttpInfo (string targetOrganizationId)
        { 
            // verify the required parameter 'targetOrganizationId' is set
            if (targetOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'targetOrganizationId' when calling TelephonyApi->DeleteTelephonyOrganizationLinkTargetOrganizationId");

            var localVarPath = "/api/v2/telephony/organization/link/{targetOrganizationId}";
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
            if (targetOrganizationId != null) localVarPathParams.Add("targetOrganizationId", this.Configuration.ApiClient.ParameterToString(targetOrganizationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteTelephonyOrganizationLinkTargetOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteTelephonyOrganizationLinkTargetOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTelephonyOrganizationLinkTargetOrganizationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTelephonyOrganizationLinkTargetOrganizationIdAsync (string targetOrganizationId)
        {
             await DeleteTelephonyOrganizationLinkTargetOrganizationIdAsyncWithHttpInfo(targetOrganizationId);

        }

        /// <summary>
        /// Delete a link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetOrganizationId">targetOrganizationId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTelephonyOrganizationLinkTargetOrganizationIdAsyncWithHttpInfo (string targetOrganizationId)
        { 
            // verify the required parameter 'targetOrganizationId' is set
            if (targetOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'targetOrganizationId' when calling TelephonyApi->DeleteTelephonyOrganizationLinkTargetOrganizationId");
            

            var localVarPath = "/api/v2/telephony/organization/link/{targetOrganizationId}";
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
            if (targetOrganizationId != null) localVarPathParams.Add("targetOrganizationId", this.Configuration.ApiClient.ParameterToString(targetOrganizationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteTelephonyOrganizationLinkTargetOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteTelephonyOrganizationLinkTargetOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTelephonyOrganizationLinkTargetOrganizationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>AgentGreeting</returns>
        
        public AgentGreeting GetTelephonyAgentGreetings (string agentId)
        {
             ApiResponse<AgentGreeting> localVarResponse = GetTelephonyAgentGreetingsWithHttpInfo(agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>ApiResponse of AgentGreeting</returns>
        
        public ApiResponse< AgentGreeting > GetTelephonyAgentGreetingsWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling TelephonyApi->GetTelephonyAgentGreetings");

            var localVarPath = "/api/v2/telephony/agents/{agentId}/greetings";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (AgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>Task of AgentGreeting</returns>
        
        public async System.Threading.Tasks.Task<AgentGreeting> GetTelephonyAgentGreetingsAsync (string agentId)
        {
             ApiResponse<AgentGreeting> localVarResponse = await GetTelephonyAgentGreetingsAsyncWithHttpInfo(agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <returns>Task of ApiResponse (AgentGreeting)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentGreeting>> GetTelephonyAgentGreetingsAsyncWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling TelephonyApi->GetTelephonyAgentGreetings");
            

            var localVarPath = "/api/v2/telephony/agents/{agentId}/greetings";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (AgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SelfAgentGreeting</returns>
        
        public SelfAgentGreeting GetTelephonyAgentsGreetingsMe ()
        {
             ApiResponse<SelfAgentGreeting> localVarResponse = GetTelephonyAgentsGreetingsMeWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SelfAgentGreeting</returns>
        
        public ApiResponse< SelfAgentGreeting > GetTelephonyAgentsGreetingsMeWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/agents/greetings/me";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentsGreetingsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SelfAgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (SelfAgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelfAgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SelfAgentGreeting</returns>
        
        public async System.Threading.Tasks.Task<SelfAgentGreeting> GetTelephonyAgentsGreetingsMeAsync ()
        {
             ApiResponse<SelfAgentGreeting> localVarResponse = await GetTelephonyAgentsGreetingsMeAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SelfAgentGreeting)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SelfAgentGreeting>> GetTelephonyAgentsGreetingsMeAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/agents/greetings/me";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyAgentsGreetingsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SelfAgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (SelfAgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelfAgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the concurrent call metrics for a given organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>OrganizationCallMetrics</returns>
        
        public OrganizationCallMetrics GetTelephonyCallsMetrics (string metricType = null)
        {
             ApiResponse<OrganizationCallMetrics> localVarResponse = GetTelephonyCallsMetricsWithHttpInfo(metricType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the concurrent call metrics for a given organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>ApiResponse of OrganizationCallMetrics</returns>
        
        public ApiResponse< OrganizationCallMetrics > GetTelephonyCallsMetricsWithHttpInfo (string metricType = null)
        { 

            var localVarPath = "/api/v2/telephony/calls/metrics";
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
            if (metricType != null) localVarQueryParams.Add(new Tuple<string, string>("metricType", this.Configuration.ApiClient.ParameterToString(metricType)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyCallsMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyCallsMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyCallsMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationCallMetrics>(localVarStatusCode,
                localVarHeaders,
                (OrganizationCallMetrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationCallMetrics)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the concurrent call metrics for a given organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>Task of OrganizationCallMetrics</returns>
        
        public async System.Threading.Tasks.Task<OrganizationCallMetrics> GetTelephonyCallsMetricsAsync (string metricType = null)
        {
             ApiResponse<OrganizationCallMetrics> localVarResponse = await GetTelephonyCallsMetricsAsyncWithHttpInfo(metricType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the concurrent call metrics for a given organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricType">Flag to indicate metric type to fetch. (optional, default to cloud)</param>
        /// <returns>Task of ApiResponse (OrganizationCallMetrics)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationCallMetrics>> GetTelephonyCallsMetricsAsyncWithHttpInfo (string metricType = null)
        { 

            var localVarPath = "/api/v2/telephony/calls/metrics";
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
            if (metricType != null) localVarQueryParams.Add(new Tuple<string, string>("metricType", this.Configuration.ApiClient.ParameterToString(metricType)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyCallsMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyCallsMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyCallsMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationCallMetrics>(localVarStatusCode,
                localVarHeaders,
                (OrganizationCallMetrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationCallMetrics)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MediaRegions</returns>
        
        public MediaRegions GetTelephonyMediaregions ()
        {
             ApiResponse<MediaRegions> localVarResponse = GetTelephonyMediaregionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MediaRegions</returns>
        
        public ApiResponse< MediaRegions > GetTelephonyMediaregionsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/mediaregions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyMediaregions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MediaRegions>(localVarStatusCode,
                localVarHeaders,
                (MediaRegions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MediaRegions)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MediaRegions</returns>
        
        public async System.Threading.Tasks.Task<MediaRegions> GetTelephonyMediaregionsAsync ()
        {
             ApiResponse<MediaRegions> localVarResponse = await GetTelephonyMediaregionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MediaRegions)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MediaRegions>> GetTelephonyMediaregionsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/mediaregions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyMediaregions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MediaRegions>(localVarStatusCode,
                localVarHeaders,
                (MediaRegions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MediaRegions)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Number Routings by organizationId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>NumberRoutingListing</returns>
        
        public NumberRoutingListing GetTelephonyNumbersRouting (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null)
        {
             ApiResponse<NumberRoutingListing> localVarResponse = GetTelephonyNumbersRoutingWithHttpInfo(before, after, pageSize, numberId, activeRoutingOrganizationId, ownerOrganizationId, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Number Routings by organizationId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>ApiResponse of NumberRoutingListing</returns>
        
        public ApiResponse< NumberRoutingListing > GetTelephonyNumbersRoutingWithHttpInfo (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null)
        { 

            var localVarPath = "/api/v2/telephony/numbers/routing";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (numberId != null) localVarQueryParams.Add(new Tuple<string, string>("numberId", this.Configuration.ApiClient.ParameterToString(numberId)));
            if (activeRoutingOrganizationId != null) localVarQueryParams.Add(new Tuple<string, string>("activeRoutingOrganizationId", this.Configuration.ApiClient.ParameterToString(activeRoutingOrganizationId)));
            if (ownerOrganizationId != null) localVarQueryParams.Add(new Tuple<string, string>("ownerOrganizationId", this.Configuration.ApiClient.ParameterToString(ownerOrganizationId)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyNumbersRouting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NumberRoutingListing>(localVarStatusCode,
                localVarHeaders,
                (NumberRoutingListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NumberRoutingListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Number Routings by organizationId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>Task of NumberRoutingListing</returns>
        
        public async System.Threading.Tasks.Task<NumberRoutingListing> GetTelephonyNumbersRoutingAsync (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null)
        {
             ApiResponse<NumberRoutingListing> localVarResponse = await GetTelephonyNumbersRoutingAsyncWithHttpInfo(before, after, pageSize, numberId, activeRoutingOrganizationId, ownerOrganizationId, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Number Routings by organizationId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="numberId">numberId (optional)</param>
        /// <param name="activeRoutingOrganizationId">activeRoutingOrganizationId (optional)</param>
        /// <param name="ownerOrganizationId">ownerOrganizationId (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <returns>Task of ApiResponse (NumberRoutingListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NumberRoutingListing>> GetTelephonyNumbersRoutingAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null)
        { 

            var localVarPath = "/api/v2/telephony/numbers/routing";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (numberId != null) localVarQueryParams.Add(new Tuple<string, string>("numberId", this.Configuration.ApiClient.ParameterToString(numberId)));
            if (activeRoutingOrganizationId != null) localVarQueryParams.Add(new Tuple<string, string>("activeRoutingOrganizationId", this.Configuration.ApiClient.ParameterToString(activeRoutingOrganizationId)));
            if (ownerOrganizationId != null) localVarQueryParams.Add(new Tuple<string, string>("ownerOrganizationId", this.Configuration.ApiClient.ParameterToString(ownerOrganizationId)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyNumbersRouting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NumberRoutingListing>(localVarStatusCode,
                localVarHeaders,
                (NumberRoutingListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NumberRoutingListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get organization links 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;OrganizationLinkResponse&gt;</returns>
        
        public List<OrganizationLinkResponse> GetTelephonyOrganizationLink ()
        {
             ApiResponse<List<OrganizationLinkResponse>> localVarResponse = GetTelephonyOrganizationLinkWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get organization links 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;OrganizationLinkResponse&gt;</returns>
        
        public ApiResponse< List<OrganizationLinkResponse> > GetTelephonyOrganizationLinkWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/organization/link";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLink: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OrganizationLinkResponse>>(localVarStatusCode,
                localVarHeaders,
                (List<OrganizationLinkResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrganizationLinkResponse>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get organization links 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;OrganizationLinkResponse&gt;</returns>
        
        public async System.Threading.Tasks.Task<List<OrganizationLinkResponse>> GetTelephonyOrganizationLinkAsync ()
        {
             ApiResponse<List<OrganizationLinkResponse>> localVarResponse = await GetTelephonyOrganizationLinkAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get organization links 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;OrganizationLinkResponse&gt;)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<List<OrganizationLinkResponse>>> GetTelephonyOrganizationLinkAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/organization/link";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLink: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OrganizationLinkResponse>>(localVarStatusCode,
                localVarHeaders,
                (List<OrganizationLinkResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrganizationLinkResponse>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all the replica regions by primary region 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RegionResponse&gt;</returns>
        
        public List<RegionResponse> GetTelephonyOrganizationLinkRegions ()
        {
             ApiResponse<List<RegionResponse>> localVarResponse = GetTelephonyOrganizationLinkRegionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the replica regions by primary region 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RegionResponse&gt;</returns>
        
        public ApiResponse< List<RegionResponse> > GetTelephonyOrganizationLinkRegionsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/organization/link/regions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLinkRegions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyOrganizationLinkRegions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLinkRegions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<RegionResponse>>(localVarStatusCode,
                localVarHeaders,
                (List<RegionResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RegionResponse>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all the replica regions by primary region 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RegionResponse&gt;</returns>
        
        public async System.Threading.Tasks.Task<List<RegionResponse>> GetTelephonyOrganizationLinkRegionsAsync ()
        {
             ApiResponse<List<RegionResponse>> localVarResponse = await GetTelephonyOrganizationLinkRegionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all the replica regions by primary region 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RegionResponse&gt;)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<List<RegionResponse>>> GetTelephonyOrganizationLinkRegionsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/organization/link/regions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLinkRegions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonyOrganizationLinkRegions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyOrganizationLinkRegions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<RegionResponse>>(localVarStatusCode,
                localVarHeaders,
                (List<RegionResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RegionResponse>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TelephonySettings</returns>
        
        public TelephonySettings GetTelephonySettings ()
        {
             ApiResponse<TelephonySettings> localVarResponse = GetTelephonySettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TelephonySettings</returns>
        
        public ApiResponse< TelephonySettings > GetTelephonySettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelephonySettings>(localVarStatusCode,
                localVarHeaders,
                (TelephonySettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelephonySettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TelephonySettings</returns>
        
        public async System.Threading.Tasks.Task<TelephonySettings> GetTelephonySettingsAsync ()
        {
             ApiResponse<TelephonySettings> localVarResponse = await GetTelephonySettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TelephonySettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TelephonySettings>> GetTelephonySettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelephonySettings>(localVarStatusCode,
                localVarHeaders,
                (TelephonySettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelephonySettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a SIP message. 
        /// Get the raw form of the SIP message
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>Callmessage</returns>
        
        public Callmessage GetTelephonySipmessagesConversation (string conversationId)
        {
             ApiResponse<Callmessage> localVarResponse = GetTelephonySipmessagesConversationWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a SIP message. 
        /// Get the raw form of the SIP message
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>ApiResponse of Callmessage</returns>
        
        public ApiResponse< Callmessage > GetTelephonySipmessagesConversationWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling TelephonyApi->GetTelephonySipmessagesConversation");

            var localVarPath = "/api/v2/telephony/sipmessages/conversations/{conversationId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySipmessagesConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Callmessage>(localVarStatusCode,
                localVarHeaders,
                (Callmessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Callmessage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a SIP message. 
        /// Get the raw form of the SIP message
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>Task of Callmessage</returns>
        
        public async System.Threading.Tasks.Task<Callmessage> GetTelephonySipmessagesConversationAsync (string conversationId)
        {
             ApiResponse<Callmessage> localVarResponse = await GetTelephonySipmessagesConversationAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a SIP message. 
        /// Get the raw form of the SIP message
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <returns>Task of ApiResponse (Callmessage)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Callmessage>> GetTelephonySipmessagesConversationAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling TelephonyApi->GetTelephonySipmessagesConversation");
            

            var localVarPath = "/api/v2/telephony/sipmessages/conversations/{conversationId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySipmessagesConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Callmessage>(localVarStatusCode,
                localVarHeaders,
                (Callmessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Callmessage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get SIP headers. 
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>Callheader</returns>
        
        public Callheader GetTelephonySipmessagesConversationHeaders (string conversationId, List<string> keys = null)
        {
             ApiResponse<Callheader> localVarResponse = GetTelephonySipmessagesConversationHeadersWithHttpInfo(conversationId, keys);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get SIP headers. 
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>ApiResponse of Callheader</returns>
        
        public ApiResponse< Callheader > GetTelephonySipmessagesConversationHeadersWithHttpInfo (string conversationId, List<string> keys = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling TelephonyApi->GetTelephonySipmessagesConversationHeaders");

            var localVarPath = "/api/v2/telephony/sipmessages/conversations/{conversationId}/headers";
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
            if (keys != null) keys.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("keys", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversationHeaders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySipmessagesConversationHeaders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversationHeaders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Callheader>(localVarStatusCode,
                localVarHeaders,
                (Callheader) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Callheader)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get SIP headers. 
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>Task of Callheader</returns>
        
        public async System.Threading.Tasks.Task<Callheader> GetTelephonySipmessagesConversationHeadersAsync (string conversationId, List<string> keys = null)
        {
             ApiResponse<Callheader> localVarResponse = await GetTelephonySipmessagesConversationHeadersAsyncWithHttpInfo(conversationId, keys);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get SIP headers. 
        /// Get parsed SIP headers. Returns specific headers if key query parameters are added.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation id</param>
        /// <param name="keys">comma-separated list of header identifiers to query. e.g. ruri,to,from (optional)</param>
        /// <returns>Task of ApiResponse (Callheader)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Callheader>> GetTelephonySipmessagesConversationHeadersAsyncWithHttpInfo (string conversationId, List<string> keys = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling TelephonyApi->GetTelephonySipmessagesConversationHeaders");
            

            var localVarPath = "/api/v2/telephony/sipmessages/conversations/{conversationId}/headers";
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
            if (keys != null) keys.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("keys", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversationHeaders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySipmessagesConversationHeaders: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySipmessagesConversationHeaders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Callheader>(localVarStatusCode,
                localVarHeaders,
                (Callheader) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Callheader)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>SipSearchResult</returns>
        
        public SipSearchResult GetTelephonySiptraces (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        {
             ApiResponse<SipSearchResult> localVarResponse = GetTelephonySiptracesWithHttpInfo(dateStart, dateEnd, callId, toUser, fromUser, conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>ApiResponse of SipSearchResult</returns>
        
        public ApiResponse< SipSearchResult > GetTelephonySiptracesWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        { 
            // verify the required parameter 'dateStart' is set
            if (dateStart == null)
                throw new ApiException(400, "Missing required parameter 'dateStart' when calling TelephonyApi->GetTelephonySiptraces");
            // verify the required parameter 'dateEnd' is set
            if (dateEnd == null)
                throw new ApiException(400, "Missing required parameter 'dateEnd' when calling TelephonyApi->GetTelephonySiptraces");

            var localVarPath = "/api/v2/telephony/siptraces";
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
            if (callId != null) localVarQueryParams.Add(new Tuple<string, string>("callId", this.Configuration.ApiClient.ParameterToString(callId)));
            if (toUser != null) localVarQueryParams.Add(new Tuple<string, string>("toUser", this.Configuration.ApiClient.ParameterToString(toUser)));
            if (fromUser != null) localVarQueryParams.Add(new Tuple<string, string>("fromUser", this.Configuration.ApiClient.ParameterToString(fromUser)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySiptraces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipSearchResult>(localVarStatusCode,
                localVarHeaders,
                (SipSearchResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipSearchResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of SipSearchResult</returns>
        
        public async System.Threading.Tasks.Task<SipSearchResult> GetTelephonySiptracesAsync (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        {
             ApiResponse<SipSearchResult> localVarResponse = await GetTelephonySiptracesAsyncWithHttpInfo(dateStart, dateEnd, callId, toUser, fromUser, conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of ApiResponse (SipSearchResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SipSearchResult>> GetTelephonySiptracesAsyncWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        { 
            // verify the required parameter 'dateStart' is set
            if (dateStart == null)
                throw new ApiException(400, "Missing required parameter 'dateStart' when calling TelephonyApi->GetTelephonySiptraces");
            
            // verify the required parameter 'dateEnd' is set
            if (dateEnd == null)
                throw new ApiException(400, "Missing required parameter 'dateEnd' when calling TelephonyApi->GetTelephonySiptraces");
            

            var localVarPath = "/api/v2/telephony/siptraces";
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
            if (callId != null) localVarQueryParams.Add(new Tuple<string, string>("callId", this.Configuration.ApiClient.ParameterToString(callId)));
            if (toUser != null) localVarQueryParams.Add(new Tuple<string, string>("toUser", this.Configuration.ApiClient.ParameterToString(toUser)));
            if (fromUser != null) localVarQueryParams.Add(new Tuple<string, string>("fromUser", this.Configuration.ApiClient.ParameterToString(fromUser)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySiptraces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipSearchResult>(localVarStatusCode,
                localVarHeaders,
                (SipSearchResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipSearchResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>SignedUrlResponse</returns>
        
        public SignedUrlResponse GetTelephonySiptracesDownloadDownloadId (string downloadId)
        {
             ApiResponse<SignedUrlResponse> localVarResponse = GetTelephonySiptracesDownloadDownloadIdWithHttpInfo(downloadId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>ApiResponse of SignedUrlResponse</returns>
        
        public ApiResponse< SignedUrlResponse > GetTelephonySiptracesDownloadDownloadIdWithHttpInfo (string downloadId)
        { 
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling TelephonyApi->GetTelephonySiptracesDownloadDownloadId");

            var localVarPath = "/api/v2/telephony/siptraces/download/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", this.Configuration.ApiClient.ParameterToString(downloadId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignedUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (SignedUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignedUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of SignedUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<SignedUrlResponse> GetTelephonySiptracesDownloadDownloadIdAsync (string downloadId)
        {
             ApiResponse<SignedUrlResponse> localVarResponse = await GetTelephonySiptracesDownloadDownloadIdAsyncWithHttpInfo(downloadId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of ApiResponse (SignedUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SignedUrlResponse>> GetTelephonySiptracesDownloadDownloadIdAsyncWithHttpInfo (string downloadId)
        { 
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling TelephonyApi->GetTelephonySiptracesDownloadDownloadId");
            

            var localVarPath = "/api/v2/telephony/siptraces/download/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", this.Configuration.ApiClient.ParameterToString(downloadId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignedUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (SignedUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignedUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Approving a requested link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns></returns>
        
        public void PatchTelephonyOrganizationLinkApproveRequestingOrganizationId (string requestingOrganizationId, OrganizationLinkApprovalRequest body)
        {
             PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdWithHttpInfo(requestingOrganizationId, body);
        }

        /// <summary>
        /// Approving a requested link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdWithHttpInfo (string requestingOrganizationId, OrganizationLinkApprovalRequest body)
        { 
            // verify the required parameter 'requestingOrganizationId' is set
            if (requestingOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'requestingOrganizationId' when calling TelephonyApi->PatchTelephonyOrganizationLinkApproveRequestingOrganizationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PatchTelephonyOrganizationLinkApproveRequestingOrganizationId");

            var localVarPath = "/api/v2/telephony/organization/link/approve/{requestingOrganizationId}";
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
            if (requestingOrganizationId != null) localVarPathParams.Add("requestingOrganizationId", this.Configuration.ApiClient.ParameterToString(requestingOrganizationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Approving a requested link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdAsync (string requestingOrganizationId, OrganizationLinkApprovalRequest body)
        {
             await PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdAsyncWithHttpInfo(requestingOrganizationId, body);

        }

        /// <summary>
        /// Approving a requested link 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestingOrganizationId">requestingOrganizationId</param>
        /// <param name="body">Approval request body</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdAsyncWithHttpInfo (string requestingOrganizationId, OrganizationLinkApprovalRequest body)
        { 
            // verify the required parameter 'requestingOrganizationId' is set
            if (requestingOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'requestingOrganizationId' when calling TelephonyApi->PatchTelephonyOrganizationLinkApproveRequestingOrganizationId");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PatchTelephonyOrganizationLinkApproveRequestingOrganizationId");
            

            var localVarPath = "/api/v2/telephony/organization/link/approve/{requestingOrganizationId}";
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
            if (requestingOrganizationId != null) localVarPathParams.Add("requestingOrganizationId", this.Configuration.ApiClient.ParameterToString(requestingOrganizationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the routing of numbers for one or multiple organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns></returns>
        
        public void PostTelephonyNumbersRouting (List<NumberRoutingRequest> body)
        {
             PostTelephonyNumbersRoutingWithHttpInfo(body);
        }

        /// <summary>
        /// Update the routing of numbers for one or multiple organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostTelephonyNumbersRoutingWithHttpInfo (List<NumberRoutingRequest> body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyNumbersRouting");

            var localVarPath = "/api/v2/telephony/numbers/routing";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRouting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the routing of numbers for one or multiple organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostTelephonyNumbersRoutingAsync (List<NumberRoutingRequest> body)
        {
             await PostTelephonyNumbersRoutingAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update the routing of numbers for one or multiple organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">drRoutingList</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyNumbersRoutingAsyncWithHttpInfo (List<NumberRoutingRequest> body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyNumbersRouting");
            

            var localVarPath = "/api/v2/telephony/numbers/routing";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyNumbersRouting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRouting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Re-route all numbers on an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns></returns>
        
        public void PostTelephonyNumbersRoutingAll (DisasterRecoveryAllRoutingRequest body)
        {
             PostTelephonyNumbersRoutingAllWithHttpInfo(body);
        }

        /// <summary>
        /// Re-route all numbers on an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostTelephonyNumbersRoutingAllWithHttpInfo (DisasterRecoveryAllRoutingRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyNumbersRoutingAll");

            var localVarPath = "/api/v2/telephony/numbers/routing/all";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyNumbersRoutingAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Re-route all numbers on an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostTelephonyNumbersRoutingAllAsync (DisasterRecoveryAllRoutingRequest body)
        {
             await PostTelephonyNumbersRoutingAllAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Re-route all numbers on an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for all routing request body</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyNumbersRoutingAllAsyncWithHttpInfo (DisasterRecoveryAllRoutingRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyNumbersRoutingAll");
            

            var localVarPath = "/api/v2/telephony/numbers/routing/all";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyNumbersRoutingAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Reset routing for organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns></returns>
        
        public void PostTelephonyNumbersRoutingReset (NumberRoutingResetOrganizationRequest body)
        {
             PostTelephonyNumbersRoutingResetWithHttpInfo(body);
        }

        /// <summary>
        /// Reset routing for organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostTelephonyNumbersRoutingResetWithHttpInfo (NumberRoutingResetOrganizationRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyNumbersRoutingReset");

            var localVarPath = "/api/v2/telephony/numbers/routing/reset";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingReset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyNumbersRoutingReset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingReset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Reset routing for organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostTelephonyNumbersRoutingResetAsync (NumberRoutingResetOrganizationRequest body)
        {
             await PostTelephonyNumbersRoutingResetAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reset routing for organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Value for bulk routing request body</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyNumbersRoutingResetAsyncWithHttpInfo (NumberRoutingResetOrganizationRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyNumbersRoutingReset");
            

            var localVarPath = "/api/v2/telephony/numbers/routing/reset";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingReset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyNumbersRoutingReset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyNumbersRoutingReset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a link with an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>OrganizationLink</returns>
        
        public OrganizationLink PostTelephonyOrganizationLink (CreateOrganizationLink body)
        {
             ApiResponse<OrganizationLink> localVarResponse = PostTelephonyOrganizationLinkWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a link with an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>ApiResponse of OrganizationLink</returns>
        
        public ApiResponse< OrganizationLink > PostTelephonyOrganizationLinkWithHttpInfo (CreateOrganizationLink body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyOrganizationLink");

            var localVarPath = "/api/v2/telephony/organization/link";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyOrganizationLink: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationLink>(localVarStatusCode,
                localVarHeaders,
                (OrganizationLink) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationLink)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a link with an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>Task of OrganizationLink</returns>
        
        public async System.Threading.Tasks.Task<OrganizationLink> PostTelephonyOrganizationLinkAsync (CreateOrganizationLink body)
        {
             ApiResponse<OrganizationLink> localVarResponse = await PostTelephonyOrganizationLinkAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a link with an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateLinkOrg body</param>
        /// <returns>Task of ApiResponse (OrganizationLink)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationLink>> PostTelephonyOrganizationLinkAsyncWithHttpInfo (CreateOrganizationLink body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PostTelephonyOrganizationLink");
            

            var localVarPath = "/api/v2/telephony/organization/link";
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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonyOrganizationLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonyOrganizationLink: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationLink>(localVarStatusCode,
                localVarHeaders,
                (OrganizationLink) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationLink)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>SipDownloadResponse</returns>
        
        public SipDownloadResponse PostTelephonySiptracesDownload (SIPSearchPublicRequest sIPSearchPublicRequest)
        {
             ApiResponse<SipDownloadResponse> localVarResponse = PostTelephonySiptracesDownloadWithHttpInfo(sIPSearchPublicRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>ApiResponse of SipDownloadResponse</returns>
        
        public ApiResponse< SipDownloadResponse > PostTelephonySiptracesDownloadWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest)
        { 
            // verify the required parameter 'sIPSearchPublicRequest' is set
            if (sIPSearchPublicRequest == null)
                throw new ApiException(400, "Missing required parameter 'sIPSearchPublicRequest' when calling TelephonyApi->PostTelephonySiptracesDownload");

            var localVarPath = "/api/v2/telephony/siptraces/download";
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
            if (sIPSearchPublicRequest != null && sIPSearchPublicRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(sIPSearchPublicRequest); // http body (model) parameter
            else
                localVarPostBody = sIPSearchPublicRequest; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonySiptracesDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipDownloadResponse>(localVarStatusCode,
                localVarHeaders,
                (SipDownloadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipDownloadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of SipDownloadResponse</returns>
        
        public async System.Threading.Tasks.Task<SipDownloadResponse> PostTelephonySiptracesDownloadAsync (SIPSearchPublicRequest sIPSearchPublicRequest)
        {
             ApiResponse<SipDownloadResponse> localVarResponse = await PostTelephonySiptracesDownloadAsyncWithHttpInfo(sIPSearchPublicRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of ApiResponse (SipDownloadResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SipDownloadResponse>> PostTelephonySiptracesDownloadAsyncWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest)
        { 
            // verify the required parameter 'sIPSearchPublicRequest' is set
            if (sIPSearchPublicRequest == null)
                throw new ApiException(400, "Missing required parameter 'sIPSearchPublicRequest' when calling TelephonyApi->PostTelephonySiptracesDownload");
            

            var localVarPath = "/api/v2/telephony/siptraces/download";
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
            if (sIPSearchPublicRequest != null && sIPSearchPublicRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(sIPSearchPublicRequest); // http body (model) parameter
            else
                localVarPostBody = sIPSearchPublicRequest; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostTelephonySiptracesDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipDownloadResponse>(localVarStatusCode,
                localVarHeaders,
                (SipDownloadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipDownloadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>AgentGreeting</returns>
        
        public AgentGreeting PutTelephonyAgentGreetings (string agentId, AgentGreeting body)
        {
             ApiResponse<AgentGreeting> localVarResponse = PutTelephonyAgentGreetingsWithHttpInfo(agentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>ApiResponse of AgentGreeting</returns>
        
        public ApiResponse< AgentGreeting > PutTelephonyAgentGreetingsWithHttpInfo (string agentId, AgentGreeting body)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling TelephonyApi->PutTelephonyAgentGreetings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PutTelephonyAgentGreetings");

            var localVarPath = "/api/v2/telephony/agents/{agentId}/greetings";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (AgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of AgentGreeting</returns>
        
        public async System.Threading.Tasks.Task<AgentGreeting> PutTelephonyAgentGreetingsAsync (string agentId, AgentGreeting body)
        {
             ApiResponse<AgentGreeting> localVarResponse = await PutTelephonyAgentGreetingsAsyncWithHttpInfo(agentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates an agent&#39;s greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">User ID</param>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of ApiResponse (AgentGreeting)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentGreeting>> PutTelephonyAgentGreetingsAsyncWithHttpInfo (string agentId, AgentGreeting body)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling TelephonyApi->PutTelephonyAgentGreetings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PutTelephonyAgentGreetings");
            

            var localVarPath = "/api/v2/telephony/agents/{agentId}/greetings";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutTelephonyAgentGreetings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (AgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>SelfAgentGreeting</returns>
        
        public SelfAgentGreeting PutTelephonyAgentsGreetingsMe (SelfAgentGreeting body)
        {
             ApiResponse<SelfAgentGreeting> localVarResponse = PutTelephonyAgentsGreetingsMeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>ApiResponse of SelfAgentGreeting</returns>
        
        public ApiResponse< SelfAgentGreeting > PutTelephonyAgentsGreetingsMeWithHttpInfo (SelfAgentGreeting body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PutTelephonyAgentsGreetingsMe");

            var localVarPath = "/api/v2/telephony/agents/greetings/me";
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
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentsGreetingsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SelfAgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (SelfAgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelfAgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of SelfAgentGreeting</returns>
        
        public async System.Threading.Tasks.Task<SelfAgentGreeting> PutTelephonyAgentsGreetingsMeAsync (SelfAgentGreeting body)
        {
             ApiResponse<SelfAgentGreeting> localVarResponse = await PutTelephonyAgentsGreetingsMeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates the agent&#39;s own greetings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Agent Greeting</param>
        /// <returns>Task of ApiResponse (SelfAgentGreeting)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SelfAgentGreeting>> PutTelephonyAgentsGreetingsMeAsyncWithHttpInfo (SelfAgentGreeting body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PutTelephonyAgentsGreetingsMe");
            

            var localVarPath = "/api/v2/telephony/agents/greetings/me";
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
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutTelephonyAgentsGreetingsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonyAgentsGreetingsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SelfAgentGreeting>(localVarStatusCode,
                localVarHeaders,
                (SelfAgentGreeting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelfAgentGreeting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>TelephonySettings</returns>
        
        public TelephonySettings PutTelephonySettings (TelephonySettings body)
        {
             ApiResponse<TelephonySettings> localVarResponse = PutTelephonySettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>ApiResponse of TelephonySettings</returns>
        
        public ApiResponse< TelephonySettings > PutTelephonySettingsWithHttpInfo (TelephonySettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PutTelephonySettings");

            var localVarPath = "/api/v2/telephony/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonySettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelephonySettings>(localVarStatusCode,
                localVarHeaders,
                (TelephonySettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelephonySettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>Task of TelephonySettings</returns>
        
        public async System.Threading.Tasks.Task<TelephonySettings> PutTelephonySettingsAsync (TelephonySettings body)
        {
             ApiResponse<TelephonySettings> localVarResponse = await PutTelephonySettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the global telephony configuration. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Telephony</param>
        /// <returns>Task of ApiResponse (TelephonySettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TelephonySettings>> PutTelephonySettingsAsyncWithHttpInfo (TelephonySettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelephonyApi->PutTelephonySettings");
            

            var localVarPath = "/api/v2/telephony/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutTelephonySettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTelephonySettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelephonySettings>(localVarStatusCode,
                localVarHeaders,
                (TelephonySettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelephonySettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
