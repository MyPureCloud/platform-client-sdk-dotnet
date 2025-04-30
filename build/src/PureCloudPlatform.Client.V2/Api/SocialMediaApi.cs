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
    public interface ISocialMediaApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns></returns>
        
        void DeleteSocialmediaEscalationrule (string escalationRuleId);

        /// <summary>
        /// Delete an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSocialmediaEscalationruleWithHttpInfo (string escalationRuleId);

        /// <summary>
        /// Delete a social media message.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns></returns>
        
        void DeleteSocialmediaMessage (string messageId);

        /// <summary>
        /// Delete a social media message.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSocialmediaMessageWithHttpInfo (string messageId);

        /// <summary>
        /// Delete a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns></returns>
        
        void DeleteSocialmediaTopic (string topicId, bool? hardDelete = null);

        /// <summary>
        /// Delete a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSocialmediaTopicWithHttpInfo (string topicId, bool? hardDelete = null);

        /// <summary>
        /// Delete a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns></returns>
        
        void DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Delete a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Delete a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns></returns>
        
        void DeleteSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? hardDelete = null);

        /// <summary>
        /// Delete a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, bool? hardDelete = null);

        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns></returns>
        
        void DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Get status for async query for social media aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        AsyncQueryStatus GetSocialmediaAnalyticsAggregatesJob (string jobId);

        /// <summary>
        /// Get status for async query for social media aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        ApiResponse<AsyncQueryStatus> GetSocialmediaAnalyticsAggregatesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async social media query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>SocialMediaAsyncAggregateQueryResponse</returns>
        
        SocialMediaAsyncAggregateQueryResponse GetSocialmediaAnalyticsAggregatesJobResults (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async social media query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of SocialMediaAsyncAggregateQueryResponse</returns>
        
        ApiResponse<SocialMediaAsyncAggregateQueryResponse> GetSocialmediaAnalyticsAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Get status for async query for social media messages job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        AsyncQueryStatus GetSocialmediaAnalyticsMessagesJob (string jobId);

        /// <summary>
        /// Get status for async query for social media messages job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        ApiResponse<AsyncQueryStatus> GetSocialmediaAnalyticsMessagesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async social media messages query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>SocialMediaAsyncDetailQueryResponse</returns>
        
        SocialMediaAsyncDetailQueryResponse GetSocialmediaAnalyticsMessagesJobResults (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async social media messages query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of SocialMediaAsyncDetailQueryResponse</returns>
        
        ApiResponse<SocialMediaAsyncDetailQueryResponse> GetSocialmediaAnalyticsMessagesJobResultsWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Get a single escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>EscalationRuleResponse</returns>
        
        EscalationRuleResponse GetSocialmediaEscalationrule (string escalationRuleId);

        /// <summary>
        /// Get a single escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>ApiResponse of EscalationRuleResponse</returns>
        
        ApiResponse<EscalationRuleResponse> GetSocialmediaEscalationruleWithHttpInfo (string escalationRuleId);

        /// <summary>
        /// Retrieve all escalation rules for a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>SocialEscalationResponseEntityListing</returns>
        
        SocialEscalationResponseEntityListing GetSocialmediaEscalationrules (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve all escalation rules for a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of SocialEscalationResponseEntityListing</returns>
        
        ApiResponse<SocialEscalationResponseEntityListing> GetSocialmediaEscalationrulesWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a single social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>SocialTopicResponse</returns>
        
        SocialTopicResponse GetSocialmediaTopic (string topicId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponse</returns>
        
        ApiResponse<SocialTopicResponse> GetSocialmediaTopicWithHttpInfo (string topicId, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>DataIngestionRuleResponseEntityListing</returns>
        
        DataIngestionRuleResponseEntityListing GetSocialmediaTopicDataingestionrules (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of DataIngestionRuleResponseEntityListing</returns>
        
        ApiResponse<DataIngestionRuleResponseEntityListing> GetSocialmediaTopicDataingestionrulesWithHttpInfo (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        FacebookDataIngestionRuleResponse GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        ApiResponse<FacebookDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>FacebookDataIngestionRuleVersionResponse</returns>
        
        FacebookDataIngestionRuleVersionResponse GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleVersionResponse</returns>
        
        ApiResponse<FacebookDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionWithHttpInfo (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get the Facebook data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>FacebookDataIngestionRuleVersionResponseEntityListing</returns>
        
        FacebookDataIngestionRuleVersionResponseEntityListing GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get the Facebook data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleVersionResponseEntityListing</returns>
        
        ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsWithHttpInfo (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get a single open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        OpenDataIngestionRuleResponse GetSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        ApiResponse<OpenDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Open data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>OpenDataIngestionRuleVersionResponse</returns>
        
        OpenDataIngestionRuleVersionResponse GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Open data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleVersionResponse</returns>
        
        ApiResponse<OpenDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionWithHttpInfo (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>OpenDataIngestionRuleVersionResponseEntityListing</returns>
        
        OpenDataIngestionRuleVersionResponseEntityListing GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleVersionResponseEntityListing</returns>
        
        ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsWithHttpInfo (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        TwitterDataIngestionRuleResponse GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        ApiResponse<TwitterDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>TwitterDataIngestionRuleVersionResponse</returns>
        
        TwitterDataIngestionRuleVersionResponse GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleVersionResponse</returns>
        
        ApiResponse<TwitterDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionWithHttpInfo (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>TwitterDataIngestionRuleVersionResponseEntityListing</returns>
        
        TwitterDataIngestionRuleVersionResponseEntityListing GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleVersionResponseEntityListing</returns>
        
        ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsWithHttpInfo (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>SocialTopicResponseEntityListing</returns>
        
        SocialTopicResponseEntityListing GetSocialmediaTopics (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponseEntityListing</returns>
        
        ApiResponse<SocialTopicResponseEntityListing> GetSocialmediaTopicsWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null);

        /// <summary>
        /// Update a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SocialTopicResponse</returns>
        
        SocialTopicResponse PatchSocialmediaTopic (string topicId, SocialTopicPatchRequest body = null);

        /// <summary>
        /// Update a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponse</returns>
        
        ApiResponse<SocialTopicResponse> PatchSocialmediaTopicWithHttpInfo (string topicId, SocialTopicPatchRequest body = null);

        /// <summary>
        /// Update the status of a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        FacebookDataIngestionRuleResponse PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        ApiResponse<FacebookDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        OpenDataIngestionRuleResponse PatchSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        ApiResponse<OpenDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        TwitterDataIngestionRuleResponse PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        ApiResponse<TwitterDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Query for social media aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        AsyncQueryResponse PostSocialmediaAnalyticsAggregatesJobs (SocialMediaAsyncAggregationQuery body);

        /// <summary>
        /// Query for social media aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        ApiResponse<AsyncQueryResponse> PostSocialmediaAnalyticsAggregatesJobsWithHttpInfo (SocialMediaAsyncAggregationQuery body);

        /// <summary>
        /// Query for social media messages asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        AsyncQueryResponse PostSocialmediaAnalyticsMessagesJobs (SocialMediaAsyncDetailQuery body);

        /// <summary>
        /// Query for social media messages asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        ApiResponse<AsyncQueryResponse> PostSocialmediaAnalyticsMessagesJobsWithHttpInfo (SocialMediaAsyncDetailQuery body);

        /// <summary>
        /// Create an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EscalationRuleResponse</returns>
        
        EscalationRuleResponse PostSocialmediaEscalationrules (EscalationRuleRequest body = null);

        /// <summary>
        /// Create an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EscalationRuleResponse</returns>
        
        ApiResponse<EscalationRuleResponse> PostSocialmediaEscalationrulesWithHttpInfo (EscalationRuleRequest body = null);

        /// <summary>
        /// Escalate message to a conversation manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ManualEscalationResponse</returns>
        
        ManualEscalationResponse PostSocialmediaEscalationsMessages (string divisionId, ManualEscalationRequest body = null);

        /// <summary>
        /// Escalate message to a conversation manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ManualEscalationResponse</returns>
        
        ApiResponse<ManualEscalationResponse> PostSocialmediaEscalationsMessagesWithHttpInfo (string divisionId, ManualEscalationRequest body = null);

        /// <summary>
        /// Create an Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        FacebookDataIngestionRuleResponse PostSocialmediaTopicDataingestionrulesFacebook (string topicId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        ApiResponse<FacebookDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesFacebookWithHttpInfo (string topicId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        OpenDataIngestionRuleResponse PostSocialmediaTopicDataingestionrulesOpen (string topicId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        ApiResponse<OpenDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesOpenWithHttpInfo (string topicId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an twitter data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        TwitterDataIngestionRuleResponse PostSocialmediaTopicDataingestionrulesTwitter (string topicId, TwitterDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an twitter data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        ApiResponse<TwitterDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesTwitterWithHttpInfo (string topicId, TwitterDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SocialTopicResponse</returns>
        
        SocialTopicResponse PostSocialmediaTopics (SocialTopicRequest body = null);

        /// <summary>
        /// Create a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponse</returns>
        
        ApiResponse<SocialTopicResponse> PostSocialmediaTopicsWithHttpInfo (SocialTopicRequest body = null);

        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>TwitterDataHistoricalTweetResponse</returns>
        
        TwitterDataHistoricalTweetResponse PostSocialmediaTwitterHistoricalTweets (TwitterDataHistoricalTweetRequest body);

        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>ApiResponse of TwitterDataHistoricalTweetResponse</returns>
        
        ApiResponse<TwitterDataHistoricalTweetResponse> PostSocialmediaTwitterHistoricalTweetsWithHttpInfo (TwitterDataHistoricalTweetRequest body);

        /// <summary>
        /// Update the escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EscalationRuleResponse</returns>
        
        EscalationRuleResponse PutSocialmediaEscalationrule (string escalationRuleId, EscalationRuleRequest body = null);

        /// <summary>
        /// Update the escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EscalationRuleResponse</returns>
        
        ApiResponse<EscalationRuleResponse> PutSocialmediaEscalationruleWithHttpInfo (string escalationRuleId, EscalationRuleRequest body = null);

        /// <summary>
        /// Update the Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        FacebookDataIngestionRuleResponse PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        ApiResponse<FacebookDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        OpenDataIngestionRuleResponse PutSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        ApiResponse<OpenDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        TwitterDataIngestionRuleResponse PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        ApiResponse<TwitterDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSocialmediaEscalationruleAsync (string escalationRuleId);

        /// <summary>
        /// Delete an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaEscalationruleAsyncWithHttpInfo (string escalationRuleId);

        /// <summary>
        /// Delete a social media message.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSocialmediaMessageAsync (string messageId);

        /// <summary>
        /// Delete a social media message.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaMessageAsyncWithHttpInfo (string messageId);

        /// <summary>
        /// Delete a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSocialmediaTopicAsync (string topicId, bool? hardDelete = null);

        /// <summary>
        /// Delete a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicAsyncWithHttpInfo (string topicId, bool? hardDelete = null);

        /// <summary>
        /// Delete a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Delete a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Delete a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, bool? hardDelete = null);

        /// <summary>
        /// Delete a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, bool? hardDelete = null);

        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? hardDelete = null);

        /// <summary>
        /// Get status for async query for social media aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        System.Threading.Tasks.Task<AsyncQueryStatus> GetSocialmediaAnalyticsAggregatesJobAsync (string jobId);

        /// <summary>
        /// Get status for async query for social media aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetSocialmediaAnalyticsAggregatesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async social media query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of SocialMediaAsyncAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<SocialMediaAsyncAggregateQueryResponse> GetSocialmediaAnalyticsAggregatesJobResultsAsync (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async social media query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (SocialMediaAsyncAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialMediaAsyncAggregateQueryResponse>> GetSocialmediaAnalyticsAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Get status for async query for social media messages job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        System.Threading.Tasks.Task<AsyncQueryStatus> GetSocialmediaAnalyticsMessagesJobAsync (string jobId);

        /// <summary>
        /// Get status for async query for social media messages job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetSocialmediaAnalyticsMessagesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async social media messages query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of SocialMediaAsyncDetailQueryResponse</returns>
        
        System.Threading.Tasks.Task<SocialMediaAsyncDetailQueryResponse> GetSocialmediaAnalyticsMessagesJobResultsAsync (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async social media messages query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (SocialMediaAsyncDetailQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialMediaAsyncDetailQueryResponse>> GetSocialmediaAnalyticsMessagesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Get a single escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of EscalationRuleResponse</returns>
        
        System.Threading.Tasks.Task<EscalationRuleResponse> GetSocialmediaEscalationruleAsync (string escalationRuleId);

        /// <summary>
        /// Get a single escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of ApiResponse (EscalationRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EscalationRuleResponse>> GetSocialmediaEscalationruleAsyncWithHttpInfo (string escalationRuleId);

        /// <summary>
        /// Retrieve all escalation rules for a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of SocialEscalationResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<SocialEscalationResponseEntityListing> GetSocialmediaEscalationrulesAsync (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve all escalation rules for a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (SocialEscalationResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialEscalationResponseEntityListing>> GetSocialmediaEscalationrulesAsyncWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a single social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of SocialTopicResponse</returns>
        
        System.Threading.Tasks.Task<SocialTopicResponse> GetSocialmediaTopicAsync (string topicId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialTopicResponse>> GetSocialmediaTopicAsyncWithHttpInfo (string topicId, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of DataIngestionRuleResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<DataIngestionRuleResponseEntityListing> GetSocialmediaTopicDataingestionrulesAsync (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (DataIngestionRuleResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataIngestionRuleResponseEntityListing>> GetSocialmediaTopicDataingestionrulesAsyncWithHttpInfo (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleVersionResponse</returns>
        
        System.Threading.Tasks.Task<FacebookDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionAsync (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Facebook data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleVersionResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleVersionResponse>> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get the Facebook data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleVersionResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<FacebookDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsAsync (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get the Facebook data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleVersionResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing>> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get a single open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> GetSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Open data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleVersionResponse</returns>
        
        System.Threading.Tasks.Task<OpenDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionAsync (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get a single Open data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleVersionResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleVersionResponse>> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionAsyncWithHttpInfo (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleVersionResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<OpenDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsAsync (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleVersionResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing>> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsAsyncWithHttpInfo (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleVersionResponse</returns>
        
        System.Threading.Tasks.Task<TwitterDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionAsync (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleVersionResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleVersionResponse>> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleVersionResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<TwitterDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsAsync (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Get the Open data ingestion rule versions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleVersionResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing>> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of SocialTopicResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<SocialTopicResponseEntityListing> GetSocialmediaTopicsAsync (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null);

        /// <summary>
        /// Retrieve all social topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialTopicResponseEntityListing>> GetSocialmediaTopicsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null);

        /// <summary>
        /// Update a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SocialTopicResponse</returns>
        
        System.Threading.Tasks.Task<SocialTopicResponse> PatchSocialmediaTopicAsync (string topicId, SocialTopicPatchRequest body = null);

        /// <summary>
        /// Update a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialTopicResponse>> PatchSocialmediaTopicAsyncWithHttpInfo (string topicId, SocialTopicPatchRequest body = null);

        /// <summary>
        /// Update the status of a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> PatchSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null);

        /// <summary>
        /// Query for social media aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        System.Threading.Tasks.Task<AsyncQueryResponse> PostSocialmediaAnalyticsAggregatesJobsAsync (SocialMediaAsyncAggregationQuery body);

        /// <summary>
        /// Query for social media aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostSocialmediaAnalyticsAggregatesJobsAsyncWithHttpInfo (SocialMediaAsyncAggregationQuery body);

        /// <summary>
        /// Query for social media messages asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        System.Threading.Tasks.Task<AsyncQueryResponse> PostSocialmediaAnalyticsMessagesJobsAsync (SocialMediaAsyncDetailQuery body);

        /// <summary>
        /// Query for social media messages asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostSocialmediaAnalyticsMessagesJobsAsyncWithHttpInfo (SocialMediaAsyncDetailQuery body);

        /// <summary>
        /// Create an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EscalationRuleResponse</returns>
        
        System.Threading.Tasks.Task<EscalationRuleResponse> PostSocialmediaEscalationrulesAsync (EscalationRuleRequest body = null);

        /// <summary>
        /// Create an escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EscalationRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EscalationRuleResponse>> PostSocialmediaEscalationrulesAsyncWithHttpInfo (EscalationRuleRequest body = null);

        /// <summary>
        /// Escalate message to a conversation manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ManualEscalationResponse</returns>
        
        System.Threading.Tasks.Task<ManualEscalationResponse> PostSocialmediaEscalationsMessagesAsync (string divisionId, ManualEscalationRequest body = null);

        /// <summary>
        /// Escalate message to a conversation manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ManualEscalationResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ManualEscalationResponse>> PostSocialmediaEscalationsMessagesAsyncWithHttpInfo (string divisionId, ManualEscalationRequest body = null);

        /// <summary>
        /// Create an Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesFacebookAsync (string topicId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> PostSocialmediaTopicDataingestionrulesFacebookAsyncWithHttpInfo (string topicId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesOpenAsync (string topicId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> PostSocialmediaTopicDataingestionrulesOpenAsyncWithHttpInfo (string topicId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an twitter data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesTwitterAsync (string topicId, TwitterDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create an twitter data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> PostSocialmediaTopicDataingestionrulesTwitterAsyncWithHttpInfo (string topicId, TwitterDataIngestionRuleRequest body = null);

        /// <summary>
        /// Create a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SocialTopicResponse</returns>
        
        System.Threading.Tasks.Task<SocialTopicResponse> PostSocialmediaTopicsAsync (SocialTopicRequest body = null);

        /// <summary>
        /// Create a social topic.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SocialTopicResponse>> PostSocialmediaTopicsAsyncWithHttpInfo (SocialTopicRequest body = null);

        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>Task of TwitterDataHistoricalTweetResponse</returns>
        
        System.Threading.Tasks.Task<TwitterDataHistoricalTweetResponse> PostSocialmediaTwitterHistoricalTweetsAsync (TwitterDataHistoricalTweetRequest body);

        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>Task of ApiResponse (TwitterDataHistoricalTweetResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataHistoricalTweetResponse>> PostSocialmediaTwitterHistoricalTweetsAsyncWithHttpInfo (TwitterDataHistoricalTweetRequest body);

        /// <summary>
        /// Update the escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EscalationRuleResponse</returns>
        
        System.Threading.Tasks.Task<EscalationRuleResponse> PutSocialmediaEscalationruleAsync (string escalationRuleId, EscalationRuleRequest body = null);

        /// <summary>
        /// Update the escalation rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EscalationRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EscalationRuleResponse>> PutSocialmediaEscalationruleAsyncWithHttpInfo (string escalationRuleId, EscalationRuleRequest body = null);

        /// <summary>
        /// Update the Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the Facebook data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the open data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> PutSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, OpenDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null);

        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SocialMediaApi : ISocialMediaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SocialMediaApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SocialMediaApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns></returns>
        
        public void DeleteSocialmediaEscalationrule (string escalationRuleId)
        {
             DeleteSocialmediaEscalationruleWithHttpInfo(escalationRuleId);
        }

        /// <summary>
        /// Delete an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSocialmediaEscalationruleWithHttpInfo (string escalationRuleId)
        { 
            // verify the required parameter 'escalationRuleId' is set
            if (escalationRuleId == null)
                throw new ApiException(400, "Missing required parameter 'escalationRuleId' when calling SocialMediaApi->DeleteSocialmediaEscalationrule");

            var localVarPath = "/api/v2/socialmedia/escalationrules/{escalationRuleId}";
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
            if (escalationRuleId != null) localVarPathParams.Add("escalationRuleId", this.Configuration.ApiClient.ParameterToString(escalationRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaEscalationrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaEscalationrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSocialmediaEscalationruleAsync (string escalationRuleId)
        {
             await DeleteSocialmediaEscalationruleAsyncWithHttpInfo(escalationRuleId);

        }

        /// <summary>
        /// Delete an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaEscalationruleAsyncWithHttpInfo (string escalationRuleId)
        { 
            // verify the required parameter 'escalationRuleId' is set
            if (escalationRuleId == null)
                throw new ApiException(400, "Missing required parameter 'escalationRuleId' when calling SocialMediaApi->DeleteSocialmediaEscalationrule");
            

            var localVarPath = "/api/v2/socialmedia/escalationrules/{escalationRuleId}";
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
            if (escalationRuleId != null) localVarPathParams.Add("escalationRuleId", this.Configuration.ApiClient.ParameterToString(escalationRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaEscalationrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaEscalationrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a social media message. 
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns></returns>
        
        public void DeleteSocialmediaMessage (string messageId)
        {
             DeleteSocialmediaMessageWithHttpInfo(messageId);
        }

        /// <summary>
        /// Delete a social media message. 
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSocialmediaMessageWithHttpInfo (string messageId)
        { 
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling SocialMediaApi->DeleteSocialmediaMessage");

            var localVarPath = "/api/v2/socialmedia/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a social media message. 
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSocialmediaMessageAsync (string messageId)
        {
             await DeleteSocialmediaMessageAsyncWithHttpInfo(messageId);

        }

        /// <summary>
        /// Delete a social media message. 
        /// 
        /// DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaMessageAsyncWithHttpInfo (string messageId)
        { 
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling SocialMediaApi->DeleteSocialmediaMessage");
            

            var localVarPath = "/api/v2/socialmedia/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns></returns>
        
        public void DeleteSocialmediaTopic (string topicId, bool? hardDelete = null)
        {
             DeleteSocialmediaTopicWithHttpInfo(topicId, hardDelete);
        }

        /// <summary>
        /// Delete a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSocialmediaTopicWithHttpInfo (string topicId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopic");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}";
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
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSocialmediaTopicAsync (string topicId, bool? hardDelete = null)
        {
             await DeleteSocialmediaTopicAsyncWithHttpInfo(topicId, hardDelete);

        }

        /// <summary>
        /// Delete a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="hardDelete">Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicAsyncWithHttpInfo (string topicId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopic");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}";
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
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns></returns>
        
        public void DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? hardDelete = null)
        {
             DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo(topicId, facebookIngestionRuleId, hardDelete);
        }

        /// <summary>
        /// Delete a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

            // Query params
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, bool? hardDelete = null)
        {
             await DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo(topicId, facebookIngestionRuleId, hardDelete);

        }

        /// <summary>
        /// Delete a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

            // Query params
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a open data ingestion rule. 
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns></returns>
        
        public void DeleteSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? hardDelete = null)
        {
             DeleteSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo(topicId, openId, hardDelete);
        }

        /// <summary>
        /// Delete a open data ingestion rule. 
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesOpenOpenId");
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesOpenOpenId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

            // Query params
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a open data ingestion rule. 
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, bool? hardDelete = null)
        {
             await DeleteSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo(topicId, openId, hardDelete);

        }

        /// <summary>
        /// Delete a open data ingestion rule. 
        /// 
        /// DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="hardDelete">Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesOpenOpenId");
            
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesOpenOpenId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

            // Query params
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns></returns>
        
        public void DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, bool? hardDelete = null)
        {
             DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo(topicId, twitterIngestionRuleId, hardDelete);
        }

        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

            // Query params
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, bool? hardDelete = null)
        {
             await DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo(topicId, twitterIngestionRuleId, hardDelete);

        }

        /// <summary>
        /// Delete a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="hardDelete">Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? hardDelete = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

            // Query params
            if (hardDelete != null) localVarQueryParams.Add(new Tuple<string, string>("hardDelete", this.Configuration.ApiClient.ParameterToString(hardDelete)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status for async query for social media aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        public AsyncQueryStatus GetSocialmediaAnalyticsAggregatesJob (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = GetSocialmediaAnalyticsAggregatesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status for async query for social media aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        public ApiResponse< AsyncQueryStatus > GetSocialmediaAnalyticsAggregatesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsAggregatesJob");

            var localVarPath = "/api/v2/socialmedia/analytics/aggregates/jobs/{jobId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status for async query for social media aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryStatus> GetSocialmediaAnalyticsAggregatesJobAsync (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = await GetSocialmediaAnalyticsAggregatesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status for async query for social media aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetSocialmediaAnalyticsAggregatesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsAggregatesJob");
            

            var localVarPath = "/api/v2/socialmedia/analytics/aggregates/jobs/{jobId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a page of results for an async social media query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>SocialMediaAsyncAggregateQueryResponse</returns>
        
        public SocialMediaAsyncAggregateQueryResponse GetSocialmediaAnalyticsAggregatesJobResults (string jobId, string cursor = null)
        {
             ApiResponse<SocialMediaAsyncAggregateQueryResponse> localVarResponse = GetSocialmediaAnalyticsAggregatesJobResultsWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a page of results for an async social media query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of SocialMediaAsyncAggregateQueryResponse</returns>
        
        public ApiResponse< SocialMediaAsyncAggregateQueryResponse > GetSocialmediaAnalyticsAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsAggregatesJobResults");

            var localVarPath = "/api/v2/socialmedia/analytics/aggregates/jobs/{jobId}/results";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialMediaAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialMediaAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialMediaAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a page of results for an async social media query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of SocialMediaAsyncAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<SocialMediaAsyncAggregateQueryResponse> GetSocialmediaAnalyticsAggregatesJobResultsAsync (string jobId, string cursor = null)
        {
             ApiResponse<SocialMediaAsyncAggregateQueryResponse> localVarResponse = await GetSocialmediaAnalyticsAggregatesJobResultsAsyncWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a page of results for an async social media query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (SocialMediaAsyncAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialMediaAsyncAggregateQueryResponse>> GetSocialmediaAnalyticsAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsAggregatesJobResults");
            

            var localVarPath = "/api/v2/socialmedia/analytics/aggregates/jobs/{jobId}/results";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialMediaAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialMediaAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialMediaAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status for async query for social media messages job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        public AsyncQueryStatus GetSocialmediaAnalyticsMessagesJob (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = GetSocialmediaAnalyticsMessagesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status for async query for social media messages job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        public ApiResponse< AsyncQueryStatus > GetSocialmediaAnalyticsMessagesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsMessagesJob");

            var localVarPath = "/api/v2/socialmedia/analytics/messages/jobs/{jobId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status for async query for social media messages job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryStatus> GetSocialmediaAnalyticsMessagesJobAsync (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = await GetSocialmediaAnalyticsMessagesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status for async query for social media messages job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetSocialmediaAnalyticsMessagesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsMessagesJob");
            

            var localVarPath = "/api/v2/socialmedia/analytics/messages/jobs/{jobId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a page of results for an async social media messages query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>SocialMediaAsyncDetailQueryResponse</returns>
        
        public SocialMediaAsyncDetailQueryResponse GetSocialmediaAnalyticsMessagesJobResults (string jobId, string cursor = null)
        {
             ApiResponse<SocialMediaAsyncDetailQueryResponse> localVarResponse = GetSocialmediaAnalyticsMessagesJobResultsWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a page of results for an async social media messages query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of SocialMediaAsyncDetailQueryResponse</returns>
        
        public ApiResponse< SocialMediaAsyncDetailQueryResponse > GetSocialmediaAnalyticsMessagesJobResultsWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsMessagesJobResults");

            var localVarPath = "/api/v2/socialmedia/analytics/messages/jobs/{jobId}/results";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialMediaAsyncDetailQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialMediaAsyncDetailQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialMediaAsyncDetailQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a page of results for an async social media messages query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of SocialMediaAsyncDetailQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<SocialMediaAsyncDetailQueryResponse> GetSocialmediaAnalyticsMessagesJobResultsAsync (string jobId, string cursor = null)
        {
             ApiResponse<SocialMediaAsyncDetailQueryResponse> localVarResponse = await GetSocialmediaAnalyticsMessagesJobResultsAsyncWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a page of results for an async social media messages query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (SocialMediaAsyncDetailQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialMediaAsyncDetailQueryResponse>> GetSocialmediaAnalyticsMessagesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SocialMediaApi->GetSocialmediaAnalyticsMessagesJobResults");
            

            var localVarPath = "/api/v2/socialmedia/analytics/messages/jobs/{jobId}/results";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaAnalyticsMessagesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialMediaAsyncDetailQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialMediaAsyncDetailQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialMediaAsyncDetailQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>EscalationRuleResponse</returns>
        
        public EscalationRuleResponse GetSocialmediaEscalationrule (string escalationRuleId)
        {
             ApiResponse<EscalationRuleResponse> localVarResponse = GetSocialmediaEscalationruleWithHttpInfo(escalationRuleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>ApiResponse of EscalationRuleResponse</returns>
        
        public ApiResponse< EscalationRuleResponse > GetSocialmediaEscalationruleWithHttpInfo (string escalationRuleId)
        { 
            // verify the required parameter 'escalationRuleId' is set
            if (escalationRuleId == null)
                throw new ApiException(400, "Missing required parameter 'escalationRuleId' when calling SocialMediaApi->GetSocialmediaEscalationrule");

            var localVarPath = "/api/v2/socialmedia/escalationrules/{escalationRuleId}";
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
            if (escalationRuleId != null) localVarPathParams.Add("escalationRuleId", this.Configuration.ApiClient.ParameterToString(escalationRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EscalationRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (EscalationRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EscalationRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of EscalationRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<EscalationRuleResponse> GetSocialmediaEscalationruleAsync (string escalationRuleId)
        {
             ApiResponse<EscalationRuleResponse> localVarResponse = await GetSocialmediaEscalationruleAsyncWithHttpInfo(escalationRuleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <returns>Task of ApiResponse (EscalationRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EscalationRuleResponse>> GetSocialmediaEscalationruleAsyncWithHttpInfo (string escalationRuleId)
        { 
            // verify the required parameter 'escalationRuleId' is set
            if (escalationRuleId == null)
                throw new ApiException(400, "Missing required parameter 'escalationRuleId' when calling SocialMediaApi->GetSocialmediaEscalationrule");
            

            var localVarPath = "/api/v2/socialmedia/escalationrules/{escalationRuleId}";
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
            if (escalationRuleId != null) localVarPathParams.Add("escalationRuleId", this.Configuration.ApiClient.ParameterToString(escalationRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EscalationRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (EscalationRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EscalationRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all escalation rules for a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>SocialEscalationResponseEntityListing</returns>
        
        public SocialEscalationResponseEntityListing GetSocialmediaEscalationrules (string divisionId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<SocialEscalationResponseEntityListing> localVarResponse = GetSocialmediaEscalationrulesWithHttpInfo(divisionId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all escalation rules for a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of SocialEscalationResponseEntityListing</returns>
        
        public ApiResponse< SocialEscalationResponseEntityListing > GetSocialmediaEscalationrulesWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling SocialMediaApi->GetSocialmediaEscalationrules");

            var localVarPath = "/api/v2/socialmedia/escalationrules";
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
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialEscalationResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SocialEscalationResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialEscalationResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all escalation rules for a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of SocialEscalationResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SocialEscalationResponseEntityListing> GetSocialmediaEscalationrulesAsync (string divisionId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<SocialEscalationResponseEntityListing> localVarResponse = await GetSocialmediaEscalationrulesAsyncWithHttpInfo(divisionId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all escalation rules for a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (SocialEscalationResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialEscalationResponseEntityListing>> GetSocialmediaEscalationrulesAsyncWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling SocialMediaApi->GetSocialmediaEscalationrules");
            

            var localVarPath = "/api/v2/socialmedia/escalationrules";
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
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaEscalationrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialEscalationResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SocialEscalationResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialEscalationResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>SocialTopicResponse</returns>
        
        public SocialTopicResponse GetSocialmediaTopic (string topicId, bool? includeDeleted = null)
        {
             ApiResponse<SocialTopicResponse> localVarResponse = GetSocialmediaTopicWithHttpInfo(topicId, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponse</returns>
        
        public ApiResponse< SocialTopicResponse > GetSocialmediaTopicWithHttpInfo (string topicId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopic");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}";
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
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of SocialTopicResponse</returns>
        
        public async System.Threading.Tasks.Task<SocialTopicResponse> GetSocialmediaTopicAsync (string topicId, bool? includeDeleted = null)
        {
             ApiResponse<SocialTopicResponse> localVarResponse = await GetSocialmediaTopicAsyncWithHttpInfo(topicId, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialTopicResponse>> GetSocialmediaTopicAsyncWithHttpInfo (string topicId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopic");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}";
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
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>DataIngestionRuleResponseEntityListing</returns>
        
        public DataIngestionRuleResponseEntityListing GetSocialmediaTopicDataingestionrules (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<DataIngestionRuleResponseEntityListing> localVarResponse = GetSocialmediaTopicDataingestionrulesWithHttpInfo(topicId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of DataIngestionRuleResponseEntityListing</returns>
        
        public ApiResponse< DataIngestionRuleResponseEntityListing > GetSocialmediaTopicDataingestionrulesWithHttpInfo (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrules");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules";
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
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataIngestionRuleResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DataIngestionRuleResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataIngestionRuleResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of DataIngestionRuleResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<DataIngestionRuleResponseEntityListing> GetSocialmediaTopicDataingestionrulesAsync (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<DataIngestionRuleResponseEntityListing> localVarResponse = await GetSocialmediaTopicDataingestionrulesAsyncWithHttpInfo(topicId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all social topic data ingestion rules with pagination. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (DataIngestionRuleResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataIngestionRuleResponseEntityListing>> GetSocialmediaTopicDataingestionrulesAsyncWithHttpInfo (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrules");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules";
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
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataIngestionRuleResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DataIngestionRuleResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataIngestionRuleResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        public FacebookDataIngestionRuleResponse GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo(topicId, facebookIngestionRuleId, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        public ApiResponse< FacebookDataIngestionRuleResponse > GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = await GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo(topicId, facebookIngestionRuleId, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single Facebook data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>FacebookDataIngestionRuleVersionResponse</returns>
        
        public FacebookDataIngestionRuleVersionResponse GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        {
             ApiResponse<FacebookDataIngestionRuleVersionResponse> localVarResponse = GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionWithHttpInfo(topicId, facebookIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single Facebook data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleVersionResponse</returns>
        
        public ApiResponse< FacebookDataIngestionRuleVersionResponse > GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionWithHttpInfo (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion");
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion");
            // verify the required parameter 'dataIngestionRuleVersion' is set
            if (dataIngestionRuleVersion == null)
                throw new ApiException(400, "Missing required parameter 'dataIngestionRuleVersion' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions/{dataIngestionRuleVersion}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));
            if (dataIngestionRuleVersion != null) localVarPathParams.Add("dataIngestionRuleVersion", this.Configuration.ApiClient.ParameterToString(dataIngestionRuleVersion));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleVersionResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleVersionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleVersionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single Facebook data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleVersionResponse</returns>
        
        public async System.Threading.Tasks.Task<FacebookDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionAsync (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        {
             ApiResponse<FacebookDataIngestionRuleVersionResponse> localVarResponse = await GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionAsyncWithHttpInfo(topicId, facebookIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single Facebook data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleVersionResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleVersionResponse>> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion");
            
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion");
            
            // verify the required parameter 'dataIngestionRuleVersion' is set
            if (dataIngestionRuleVersion == null)
                throw new ApiException(400, "Missing required parameter 'dataIngestionRuleVersion' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions/{dataIngestionRuleVersion}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));
            if (dataIngestionRuleVersion != null) localVarPathParams.Add("dataIngestionRuleVersion", this.Configuration.ApiClient.ParameterToString(dataIngestionRuleVersion));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleVersionResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleVersionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleVersionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the Facebook data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>FacebookDataIngestionRuleVersionResponseEntityListing</returns>
        
        public FacebookDataIngestionRuleVersionResponseEntityListing GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing> localVarResponse = GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsWithHttpInfo(topicId, facebookIngestionRuleId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Facebook data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleVersionResponseEntityListing</returns>
        
        public ApiResponse< FacebookDataIngestionRuleVersionResponseEntityListing > GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsWithHttpInfo (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions");
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleVersionResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleVersionResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the Facebook data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleVersionResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<FacebookDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsAsync (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing> localVarResponse = await GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsAsyncWithHttpInfo(topicId, facebookIngestionRuleId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Facebook data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleVersionResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing>> GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions");
            
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleVersionResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleVersionResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleVersionResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single open data ingestion rule. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        public OpenDataIngestionRuleResponse GetSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? includeDeleted = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = GetSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo(topicId, openId, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single open data ingestion rule. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        public ApiResponse< OpenDataIngestionRuleResponse > GetSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenId");
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single open data ingestion rule. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, bool? includeDeleted = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = await GetSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo(topicId, openId, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single open data ingestion rule. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> GetSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenId");
            
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single Open data ingestion rule version. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>OpenDataIngestionRuleVersionResponse</returns>
        
        public OpenDataIngestionRuleVersionResponse GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        {
             ApiResponse<OpenDataIngestionRuleVersionResponse> localVarResponse = GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionWithHttpInfo(topicId, openId, dataIngestionRuleVersion, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single Open data ingestion rule version. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleVersionResponse</returns>
        
        public ApiResponse< OpenDataIngestionRuleVersionResponse > GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionWithHttpInfo (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion");
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion");
            // verify the required parameter 'dataIngestionRuleVersion' is set
            if (dataIngestionRuleVersion == null)
                throw new ApiException(400, "Missing required parameter 'dataIngestionRuleVersion' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions/{dataIngestionRuleVersion}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));
            if (dataIngestionRuleVersion != null) localVarPathParams.Add("dataIngestionRuleVersion", this.Configuration.ApiClient.ParameterToString(dataIngestionRuleVersion));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleVersionResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleVersionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleVersionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single Open data ingestion rule version. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleVersionResponse</returns>
        
        public async System.Threading.Tasks.Task<OpenDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionAsync (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        {
             ApiResponse<OpenDataIngestionRuleVersionResponse> localVarResponse = await GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionAsyncWithHttpInfo(topicId, openId, dataIngestionRuleVersion, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single Open data ingestion rule version. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleVersionResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleVersionResponse>> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionAsyncWithHttpInfo (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion");
            
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion");
            
            // verify the required parameter 'dataIngestionRuleVersion' is set
            if (dataIngestionRuleVersion == null)
                throw new ApiException(400, "Missing required parameter 'dataIngestionRuleVersion' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions/{dataIngestionRuleVersion}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));
            if (dataIngestionRuleVersion != null) localVarPathParams.Add("dataIngestionRuleVersion", this.Configuration.ApiClient.ParameterToString(dataIngestionRuleVersion));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleVersionResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleVersionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleVersionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>OpenDataIngestionRuleVersionResponseEntityListing</returns>
        
        public OpenDataIngestionRuleVersionResponseEntityListing GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing> localVarResponse = GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsWithHttpInfo(topicId, openId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleVersionResponseEntityListing</returns>
        
        public ApiResponse< OpenDataIngestionRuleVersionResponseEntityListing > GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsWithHttpInfo (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions");
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleVersionResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleVersionResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleVersionResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<OpenDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsAsync (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing> localVarResponse = await GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsAsyncWithHttpInfo(topicId, openId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleVersionResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing>> GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsAsyncWithHttpInfo (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions");
            
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleVersionResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleVersionResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleVersionResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        public TwitterDataIngestionRuleResponse GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo(topicId, twitterIngestionRuleId, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        public ApiResponse< TwitterDataIngestionRuleResponse > GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = await GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo(topicId, twitterIngestionRuleId, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>TwitterDataIngestionRuleVersionResponse</returns>
        
        public TwitterDataIngestionRuleVersionResponse GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        {
             ApiResponse<TwitterDataIngestionRuleVersionResponse> localVarResponse = GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionWithHttpInfo(topicId, twitterIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleVersionResponse</returns>
        
        public ApiResponse< TwitterDataIngestionRuleVersionResponse > GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionWithHttpInfo (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion");
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion");
            // verify the required parameter 'dataIngestionRuleVersion' is set
            if (dataIngestionRuleVersion == null)
                throw new ApiException(400, "Missing required parameter 'dataIngestionRuleVersion' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions/{dataIngestionRuleVersion}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));
            if (dataIngestionRuleVersion != null) localVarPathParams.Add("dataIngestionRuleVersion", this.Configuration.ApiClient.ParameterToString(dataIngestionRuleVersion));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleVersionResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleVersionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleVersionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleVersionResponse</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataIngestionRuleVersionResponse> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionAsync (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        {
             ApiResponse<TwitterDataIngestionRuleVersionResponse> localVarResponse = await GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionAsyncWithHttpInfo(topicId, twitterIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single X (formally Twitter) data ingestion rule version. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="dataIngestionRuleVersion">version</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted item in the result. (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleVersionResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleVersionResponse>> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion");
            
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion");
            
            // verify the required parameter 'dataIngestionRuleVersion' is set
            if (dataIngestionRuleVersion == null)
                throw new ApiException(400, "Missing required parameter 'dataIngestionRuleVersion' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions/{dataIngestionRuleVersion}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));
            if (dataIngestionRuleVersion != null) localVarPathParams.Add("dataIngestionRuleVersion", this.Configuration.ApiClient.ParameterToString(dataIngestionRuleVersion));

            // Query params
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleVersionResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleVersionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleVersionResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>TwitterDataIngestionRuleVersionResponseEntityListing</returns>
        
        public TwitterDataIngestionRuleVersionResponseEntityListing GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing> localVarResponse = GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsWithHttpInfo(topicId, twitterIngestionRuleId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleVersionResponseEntityListing</returns>
        
        public ApiResponse< TwitterDataIngestionRuleVersionResponseEntityListing > GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsWithHttpInfo (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions");
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleVersionResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleVersionResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleVersionResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataIngestionRuleVersionResponseEntityListing> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsAsync (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        {
             ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing> localVarResponse = await GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsAsyncWithHttpInfo(topicId, twitterIngestionRuleId, pageNumber, pageSize, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Open data ingestion rule versions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleVersionResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing>> GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions");
            
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleVersionResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleVersionResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleVersionResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all social topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>SocialTopicResponseEntityListing</returns>
        
        public SocialTopicResponseEntityListing GetSocialmediaTopics (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null)
        {
             ApiResponse<SocialTopicResponseEntityListing> localVarResponse = GetSocialmediaTopicsWithHttpInfo(pageNumber, pageSize, divisionIds, includeDeleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all social topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponseEntityListing</returns>
        
        public ApiResponse< SocialTopicResponseEntityListing > GetSocialmediaTopicsWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null)
        { 

            var localVarPath = "/api/v2/socialmedia/topics";
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
            if (divisionIds != null) divisionIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all social topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of SocialTopicResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SocialTopicResponseEntityListing> GetSocialmediaTopicsAsync (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null)
        {
             ApiResponse<SocialTopicResponseEntityListing> localVarResponse = await GetSocialmediaTopicsAsyncWithHttpInfo(pageNumber, pageSize, divisionIds, includeDeleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all social topics. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="divisionIds">One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional)</param>
        /// <param name="includeDeleted">Determines whether to include soft-deleted items in the result. (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialTopicResponseEntityListing>> GetSocialmediaTopicsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null)
        { 

            var localVarPath = "/api/v2/socialmedia/topics";
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
            if (divisionIds != null) divisionIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (includeDeleted != null) localVarQueryParams.Add(new Tuple<string, string>("includeDeleted", this.Configuration.ApiClient.ParameterToString(includeDeleted)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSocialmediaTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SocialTopicResponse</returns>
        
        public SocialTopicResponse PatchSocialmediaTopic (string topicId, SocialTopicPatchRequest body = null)
        {
             ApiResponse<SocialTopicResponse> localVarResponse = PatchSocialmediaTopicWithHttpInfo(topicId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponse</returns>
        
        public ApiResponse< SocialTopicResponse > PatchSocialmediaTopicWithHttpInfo (string topicId, SocialTopicPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopic");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}";
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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SocialTopicResponse</returns>
        
        public async System.Threading.Tasks.Task<SocialTopicResponse> PatchSocialmediaTopicAsync (string topicId, SocialTopicPatchRequest body = null)
        {
             ApiResponse<SocialTopicResponse> localVarResponse = await PatchSocialmediaTopicAsyncWithHttpInfo(topicId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialTopicResponse>> PatchSocialmediaTopicAsyncWithHttpInfo (string topicId, SocialTopicPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopic");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}";
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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the status of a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        public FacebookDataIngestionRuleResponse PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo(topicId, facebookIngestionRuleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the status of a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        public ApiResponse< FacebookDataIngestionRuleResponse > PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the status of a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = await PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo(topicId, facebookIngestionRuleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the status of a Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the status of a open data ingestion rule. 
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        public OpenDataIngestionRuleResponse PatchSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = PatchSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo(topicId, openId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the status of a open data ingestion rule. 
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        public ApiResponse< OpenDataIngestionRuleResponse > PatchSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesOpenOpenId");
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesOpenOpenId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the status of a open data ingestion rule. 
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = await PatchSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo(topicId, openId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the status of a open data ingestion rule. 
        /// 
        /// PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> PatchSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesOpenOpenId");
            
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesOpenOpenId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        public TwitterDataIngestionRuleResponse PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo(topicId, twitterIngestionRuleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        public ApiResponse< TwitterDataIngestionRuleResponse > PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = await PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo(topicId, twitterIngestionRuleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the status of a X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for social media aggregates asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        public AsyncQueryResponse PostSocialmediaAnalyticsAggregatesJobs (SocialMediaAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = PostSocialmediaAnalyticsAggregatesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for social media aggregates asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        public ApiResponse< AsyncQueryResponse > PostSocialmediaAnalyticsAggregatesJobsWithHttpInfo (SocialMediaAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SocialMediaApi->PostSocialmediaAnalyticsAggregatesJobs");

            var localVarPath = "/api/v2/socialmedia/analytics/aggregates/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for social media aggregates asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryResponse> PostSocialmediaAnalyticsAggregatesJobsAsync (SocialMediaAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = await PostSocialmediaAnalyticsAggregatesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for social media aggregates asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostSocialmediaAnalyticsAggregatesJobsAsyncWithHttpInfo (SocialMediaAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SocialMediaApi->PostSocialmediaAnalyticsAggregatesJobs");
            

            var localVarPath = "/api/v2/socialmedia/analytics/aggregates/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for social media messages asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        public AsyncQueryResponse PostSocialmediaAnalyticsMessagesJobs (SocialMediaAsyncDetailQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = PostSocialmediaAnalyticsMessagesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for social media messages asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        public ApiResponse< AsyncQueryResponse > PostSocialmediaAnalyticsMessagesJobsWithHttpInfo (SocialMediaAsyncDetailQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SocialMediaApi->PostSocialmediaAnalyticsMessagesJobs");

            var localVarPath = "/api/v2/socialmedia/analytics/messages/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsMessagesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsMessagesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for social media messages asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryResponse> PostSocialmediaAnalyticsMessagesJobsAsync (SocialMediaAsyncDetailQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = await PostSocialmediaAnalyticsMessagesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for social media messages asynchronously 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostSocialmediaAnalyticsMessagesJobsAsyncWithHttpInfo (SocialMediaAsyncDetailQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SocialMediaApi->PostSocialmediaAnalyticsMessagesJobs");
            

            var localVarPath = "/api/v2/socialmedia/analytics/messages/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsMessagesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaAnalyticsMessagesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EscalationRuleResponse</returns>
        
        public EscalationRuleResponse PostSocialmediaEscalationrules (EscalationRuleRequest body = null)
        {
             ApiResponse<EscalationRuleResponse> localVarResponse = PostSocialmediaEscalationrulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EscalationRuleResponse</returns>
        
        public ApiResponse< EscalationRuleResponse > PostSocialmediaEscalationrulesWithHttpInfo (EscalationRuleRequest body = null)
        { 

            var localVarPath = "/api/v2/socialmedia/escalationrules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EscalationRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (EscalationRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EscalationRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EscalationRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<EscalationRuleResponse> PostSocialmediaEscalationrulesAsync (EscalationRuleRequest body = null)
        {
             ApiResponse<EscalationRuleResponse> localVarResponse = await PostSocialmediaEscalationrulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EscalationRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EscalationRuleResponse>> PostSocialmediaEscalationrulesAsyncWithHttpInfo (EscalationRuleRequest body = null)
        { 

            var localVarPath = "/api/v2/socialmedia/escalationrules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EscalationRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (EscalationRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EscalationRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Escalate message to a conversation manually 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ManualEscalationResponse</returns>
        
        public ManualEscalationResponse PostSocialmediaEscalationsMessages (string divisionId, ManualEscalationRequest body = null)
        {
             ApiResponse<ManualEscalationResponse> localVarResponse = PostSocialmediaEscalationsMessagesWithHttpInfo(divisionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Escalate message to a conversation manually 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ManualEscalationResponse</returns>
        
        public ApiResponse< ManualEscalationResponse > PostSocialmediaEscalationsMessagesWithHttpInfo (string divisionId, ManualEscalationRequest body = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling SocialMediaApi->PostSocialmediaEscalationsMessages");

            var localVarPath = "/api/v2/socialmedia/escalations/messages";
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
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationsMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationsMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManualEscalationResponse>(localVarStatusCode,
                localVarHeaders,
                (ManualEscalationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManualEscalationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Escalate message to a conversation manually 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ManualEscalationResponse</returns>
        
        public async System.Threading.Tasks.Task<ManualEscalationResponse> PostSocialmediaEscalationsMessagesAsync (string divisionId, ManualEscalationRequest body = null)
        {
             ApiResponse<ManualEscalationResponse> localVarResponse = await PostSocialmediaEscalationsMessagesAsyncWithHttpInfo(divisionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Escalate message to a conversation manually 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">One division ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ManualEscalationResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ManualEscalationResponse>> PostSocialmediaEscalationsMessagesAsyncWithHttpInfo (string divisionId, ManualEscalationRequest body = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling SocialMediaApi->PostSocialmediaEscalationsMessages");
            

            var localVarPath = "/api/v2/socialmedia/escalations/messages";
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
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationsMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaEscalationsMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManualEscalationResponse>(localVarStatusCode,
                localVarHeaders,
                (ManualEscalationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManualEscalationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        public FacebookDataIngestionRuleResponse PostSocialmediaTopicDataingestionrulesFacebook (string topicId, FacebookDataIngestionRuleRequest body = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = PostSocialmediaTopicDataingestionrulesFacebookWithHttpInfo(topicId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        public ApiResponse< FacebookDataIngestionRuleResponse > PostSocialmediaTopicDataingestionrulesFacebookWithHttpInfo (string topicId, FacebookDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PostSocialmediaTopicDataingestionrulesFacebook");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesFacebook: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesFacebook: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesFacebookAsync (string topicId, FacebookDataIngestionRuleRequest body = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = await PostSocialmediaTopicDataingestionrulesFacebookAsyncWithHttpInfo(topicId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> PostSocialmediaTopicDataingestionrulesFacebookAsyncWithHttpInfo (string topicId, FacebookDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PostSocialmediaTopicDataingestionrulesFacebook");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesFacebook: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesFacebook: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an open data ingestion rule. 
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        public OpenDataIngestionRuleResponse PostSocialmediaTopicDataingestionrulesOpen (string topicId, OpenDataIngestionRuleRequest body = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = PostSocialmediaTopicDataingestionrulesOpenWithHttpInfo(topicId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an open data ingestion rule. 
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        public ApiResponse< OpenDataIngestionRuleResponse > PostSocialmediaTopicDataingestionrulesOpenWithHttpInfo (string topicId, OpenDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PostSocialmediaTopicDataingestionrulesOpen");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesOpen: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesOpen: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an open data ingestion rule. 
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesOpenAsync (string topicId, OpenDataIngestionRuleRequest body = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = await PostSocialmediaTopicDataingestionrulesOpenAsyncWithHttpInfo(topicId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an open data ingestion rule. 
        /// 
        /// PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> PostSocialmediaTopicDataingestionrulesOpenAsyncWithHttpInfo (string topicId, OpenDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PostSocialmediaTopicDataingestionrulesOpen");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesOpen: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesOpen: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an twitter data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        public TwitterDataIngestionRuleResponse PostSocialmediaTopicDataingestionrulesTwitter (string topicId, TwitterDataIngestionRuleRequest body = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = PostSocialmediaTopicDataingestionrulesTwitterWithHttpInfo(topicId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an twitter data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        public ApiResponse< TwitterDataIngestionRuleResponse > PostSocialmediaTopicDataingestionrulesTwitterWithHttpInfo (string topicId, TwitterDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PostSocialmediaTopicDataingestionrulesTwitter");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesTwitter: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesTwitter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an twitter data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> PostSocialmediaTopicDataingestionrulesTwitterAsync (string topicId, TwitterDataIngestionRuleRequest body = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = await PostSocialmediaTopicDataingestionrulesTwitterAsyncWithHttpInfo(topicId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an twitter data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> PostSocialmediaTopicDataingestionrulesTwitterAsyncWithHttpInfo (string topicId, TwitterDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PostSocialmediaTopicDataingestionrulesTwitter");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesTwitter: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopicDataingestionrulesTwitter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SocialTopicResponse</returns>
        
        public SocialTopicResponse PostSocialmediaTopics (SocialTopicRequest body = null)
        {
             ApiResponse<SocialTopicResponse> localVarResponse = PostSocialmediaTopicsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SocialTopicResponse</returns>
        
        public ApiResponse< SocialTopicResponse > PostSocialmediaTopicsWithHttpInfo (SocialTopicRequest body = null)
        { 

            var localVarPath = "/api/v2/socialmedia/topics";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SocialTopicResponse</returns>
        
        public async System.Threading.Tasks.Task<SocialTopicResponse> PostSocialmediaTopicsAsync (SocialTopicRequest body = null)
        {
             ApiResponse<SocialTopicResponse> localVarResponse = await PostSocialmediaTopicsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a social topic. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SocialTopicResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SocialTopicResponse>> PostSocialmediaTopicsAsyncWithHttpInfo (SocialTopicRequest body = null)
        { 

            var localVarPath = "/api/v2/socialmedia/topics";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialTopicResponse>(localVarStatusCode,
                localVarHeaders,
                (SocialTopicResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialTopicResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>TwitterDataHistoricalTweetResponse</returns>
        
        public TwitterDataHistoricalTweetResponse PostSocialmediaTwitterHistoricalTweets (TwitterDataHistoricalTweetRequest body)
        {
             ApiResponse<TwitterDataHistoricalTweetResponse> localVarResponse = PostSocialmediaTwitterHistoricalTweetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>ApiResponse of TwitterDataHistoricalTweetResponse</returns>
        
        public ApiResponse< TwitterDataHistoricalTweetResponse > PostSocialmediaTwitterHistoricalTweetsWithHttpInfo (TwitterDataHistoricalTweetRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SocialMediaApi->PostSocialmediaTwitterHistoricalTweets");

            var localVarPath = "/api/v2/socialmedia/twitter/historical/tweets";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTwitterHistoricalTweets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTwitterHistoricalTweets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataHistoricalTweetResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataHistoricalTweetResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataHistoricalTweetResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>Task of TwitterDataHistoricalTweetResponse</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataHistoricalTweetResponse> PostSocialmediaTwitterHistoricalTweetsAsync (TwitterDataHistoricalTweetRequest body)
        {
             ApiResponse<TwitterDataHistoricalTweetResponse> localVarResponse = await PostSocialmediaTwitterHistoricalTweetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterDataHistoricalTweetRequest</param>
        /// <returns>Task of ApiResponse (TwitterDataHistoricalTweetResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataHistoricalTweetResponse>> PostSocialmediaTwitterHistoricalTweetsAsyncWithHttpInfo (TwitterDataHistoricalTweetRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SocialMediaApi->PostSocialmediaTwitterHistoricalTweets");
            

            var localVarPath = "/api/v2/socialmedia/twitter/historical/tweets";
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
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTwitterHistoricalTweets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSocialmediaTwitterHistoricalTweets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataHistoricalTweetResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataHistoricalTweetResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataHistoricalTweetResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EscalationRuleResponse</returns>
        
        public EscalationRuleResponse PutSocialmediaEscalationrule (string escalationRuleId, EscalationRuleRequest body = null)
        {
             ApiResponse<EscalationRuleResponse> localVarResponse = PutSocialmediaEscalationruleWithHttpInfo(escalationRuleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EscalationRuleResponse</returns>
        
        public ApiResponse< EscalationRuleResponse > PutSocialmediaEscalationruleWithHttpInfo (string escalationRuleId, EscalationRuleRequest body = null)
        { 
            // verify the required parameter 'escalationRuleId' is set
            if (escalationRuleId == null)
                throw new ApiException(400, "Missing required parameter 'escalationRuleId' when calling SocialMediaApi->PutSocialmediaEscalationrule");

            var localVarPath = "/api/v2/socialmedia/escalationrules/{escalationRuleId}";
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
            if (escalationRuleId != null) localVarPathParams.Add("escalationRuleId", this.Configuration.ApiClient.ParameterToString(escalationRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaEscalationrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaEscalationrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EscalationRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (EscalationRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EscalationRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EscalationRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<EscalationRuleResponse> PutSocialmediaEscalationruleAsync (string escalationRuleId, EscalationRuleRequest body = null)
        {
             ApiResponse<EscalationRuleResponse> localVarResponse = await PutSocialmediaEscalationruleAsyncWithHttpInfo(escalationRuleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the escalation rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="escalationRuleId">escalationRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EscalationRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EscalationRuleResponse>> PutSocialmediaEscalationruleAsyncWithHttpInfo (string escalationRuleId, EscalationRuleRequest body = null)
        { 
            // verify the required parameter 'escalationRuleId' is set
            if (escalationRuleId == null)
                throw new ApiException(400, "Missing required parameter 'escalationRuleId' when calling SocialMediaApi->PutSocialmediaEscalationrule");
            

            var localVarPath = "/api/v2/socialmedia/escalationrules/{escalationRuleId}";
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
            if (escalationRuleId != null) localVarPathParams.Add("escalationRuleId", this.Configuration.ApiClient.ParameterToString(escalationRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaEscalationrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaEscalationrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EscalationRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (EscalationRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EscalationRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FacebookDataIngestionRuleResponse</returns>
        
        public FacebookDataIngestionRuleResponse PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo(topicId, facebookIngestionRuleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FacebookDataIngestionRuleResponse</returns>
        
        public ApiResponse< FacebookDataIngestionRuleResponse > PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdWithHttpInfo (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FacebookDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<FacebookDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsync (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null)
        {
             ApiResponse<FacebookDataIngestionRuleResponse> localVarResponse = await PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo(topicId, facebookIngestionRuleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Facebook data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="facebookIngestionRuleId">facebookIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FacebookDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FacebookDataIngestionRuleResponse>> PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdAsyncWithHttpInfo (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            
            // verify the required parameter 'facebookIngestionRuleId' is set
            if (facebookIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'facebookIngestionRuleId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}";
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
            if (facebookIngestionRuleId != null) localVarPathParams.Add("facebookIngestionRuleId", this.Configuration.ApiClient.ParameterToString(facebookIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FacebookDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (FacebookDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacebookDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the open data ingestion rule. 
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>OpenDataIngestionRuleResponse</returns>
        
        public OpenDataIngestionRuleResponse PutSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, OpenDataIngestionRuleRequest body = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = PutSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo(topicId, openId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the open data ingestion rule. 
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OpenDataIngestionRuleResponse</returns>
        
        public ApiResponse< OpenDataIngestionRuleResponse > PutSocialmediaTopicDataingestionrulesOpenOpenIdWithHttpInfo (string topicId, string openId, OpenDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesOpenOpenId");
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesOpenOpenId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the open data ingestion rule. 
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OpenDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<OpenDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesOpenOpenIdAsync (string topicId, string openId, OpenDataIngestionRuleRequest body = null)
        {
             ApiResponse<OpenDataIngestionRuleResponse> localVarResponse = await PutSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo(topicId, openId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the open data ingestion rule. 
        /// 
        /// PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="openId">openId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OpenDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OpenDataIngestionRuleResponse>> PutSocialmediaTopicDataingestionrulesOpenOpenIdAsyncWithHttpInfo (string topicId, string openId, OpenDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesOpenOpenId");
            
            // verify the required parameter 'openId' is set
            if (openId == null)
                throw new ApiException(400, "Missing required parameter 'openId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesOpenOpenId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}";
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
            if (openId != null) localVarPathParams.Add("openId", this.Configuration.ApiClient.ParameterToString(openId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesOpenOpenId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OpenDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (OpenDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TwitterDataIngestionRuleResponse</returns>
        
        public TwitterDataIngestionRuleResponse PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo(topicId, twitterIngestionRuleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TwitterDataIngestionRuleResponse</returns>
        
        public ApiResponse< TwitterDataIngestionRuleResponse > PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdWithHttpInfo (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TwitterDataIngestionRuleResponse</returns>
        
        public async System.Threading.Tasks.Task<TwitterDataIngestionRuleResponse> PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsync (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null)
        {
             ApiResponse<TwitterDataIngestionRuleResponse> localVarResponse = await PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo(topicId, twitterIngestionRuleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the X (formally Twitter) data ingestion rule. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">topicId</param>
        /// <param name="twitterIngestionRuleId">twitterIngestionRuleId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TwitterDataIngestionRuleResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TwitterDataIngestionRuleResponse>> PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdAsyncWithHttpInfo (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            
            // verify the required parameter 'twitterIngestionRuleId' is set
            if (twitterIngestionRuleId == null)
                throw new ApiException(400, "Missing required parameter 'twitterIngestionRuleId' when calling SocialMediaApi->PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId");
            

            var localVarPath = "/api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}";
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
            if (twitterIngestionRuleId != null) localVarPathParams.Add("twitterIngestionRuleId", this.Configuration.ApiClient.ParameterToString(twitterIngestionRuleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterDataIngestionRuleResponse>(localVarStatusCode,
                localVarHeaders,
                (TwitterDataIngestionRuleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterDataIngestionRuleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
