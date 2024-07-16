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
    public interface IJourneyApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns></returns>
        
        void DeleteJourneyActionmap (string actionMapId);

        /// <summary>
        /// Delete single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteJourneyActionmapWithHttpInfo (string actionMapId);

        /// <summary>
        /// Delete a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns></returns>
        
        void DeleteJourneyActiontemplate (string actionTemplateId, bool? hardDelete = null);

        /// <summary>
        /// Delete a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteJourneyActiontemplateWithHttpInfo (string actionTemplateId, bool? hardDelete = null);

        /// <summary>
        /// Delete an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns></returns>
        
        void DeleteJourneyOutcome (string outcomeId);

        /// <summary>
        /// Delete an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteJourneyOutcomeWithHttpInfo (string outcomeId);

        /// <summary>
        /// Delete an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns></returns>
        
        void DeleteJourneyOutcomesPredictor (string predictorId);

        /// <summary>
        /// Delete an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteJourneyOutcomesPredictorWithHttpInfo (string predictorId);

        /// <summary>
        /// Delete a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns></returns>
        
        void DeleteJourneySegment (string segmentId);

        /// <summary>
        /// Delete a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteJourneySegmentWithHttpInfo (string segmentId);

        /// <summary>
        /// Delete a Journey View by ID
        /// </summary>
        /// <remarks>
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns></returns>
        
        void DeleteJourneyView (string viewId);

        /// <summary>
        /// Delete a Journey View by ID
        /// </summary>
        /// <remarks>
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteJourneyViewWithHttpInfo (string viewId);

        /// <summary>
        /// Get status for async query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        AsyncQueryStatus GetAnalyticsJourneysAggregatesJob (string jobId);

        /// <summary>
        /// Get status for async query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        ApiResponse<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>JourneyAsyncAggregateQueryResponse</returns>
        
        JourneyAsyncAggregateQueryResponse GetAnalyticsJourneysAggregatesJobResults (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of JourneyAsyncAggregateQueryResponse</returns>
        
        ApiResponse<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>SessionListing</returns>
        
        SessionListing GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>ApiResponse of SessionListing</returns>
        
        ApiResponse<SessionListing> GetExternalcontactsContactJourneySessionsWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Retrieve a single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>ActionMap</returns>
        
        ActionMap GetJourneyActionmap (string actionMapId);

        /// <summary>
        /// Retrieve a single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>ApiResponse of ActionMap</returns>
        
        ApiResponse<ActionMap> GetJourneyActionmapWithHttpInfo (string actionMapId);

        /// <summary>
        /// Retrieve all action maps.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ActionMapListing</returns>
        
        ActionMapListing GetJourneyActionmaps (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all action maps.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of ActionMapListing</returns>
        
        ApiResponse<ActionMapListing> GetJourneyActionmapsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Get status of job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>string</returns>
        
        string GetJourneyActionmapsEstimatesJob (string jobId);

        /// <summary>
        /// Get status of job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of string</returns>
        
        ApiResponse<string> GetJourneyActionmapsEstimatesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Get estimates from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ActionMapEstimateResult</returns>
        
        ActionMapEstimateResult GetJourneyActionmapsEstimatesJobResults (string jobId);

        /// <summary>
        /// Get estimates from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of ActionMapEstimateResult</returns>
        
        ApiResponse<ActionMapEstimateResult> GetJourneyActionmapsEstimatesJobResultsWithHttpInfo (string jobId);

        /// <summary>
        /// Retrieve a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>ActionTarget</returns>
        
        ActionTarget GetJourneyActiontarget (string actionTargetId);

        /// <summary>
        /// Retrieve a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>ApiResponse of ActionTarget</returns>
        
        ApiResponse<ActionTarget> GetJourneyActiontargetWithHttpInfo (string actionTargetId);

        /// <summary>
        /// Retrieve all action targets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ActionTargetListing</returns>
        
        ActionTargetListing GetJourneyActiontargets (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve all action targets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ActionTargetListing</returns>
        
        ApiResponse<ActionTargetListing> GetJourneyActiontargetsWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>ActionTemplate</returns>
        
        ActionTemplate GetJourneyActiontemplate (string actionTemplateId);

        /// <summary>
        /// Retrieve a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>ApiResponse of ActionTemplate</returns>
        
        ApiResponse<ActionTemplate> GetJourneyActiontemplateWithHttpInfo (string actionTemplateId);

        /// <summary>
        /// Retrieve all action templates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ActionTemplateListing</returns>
        
        ActionTemplateListing GetJourneyActiontemplates (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all action templates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of ActionTemplateListing</returns>
        
        ApiResponse<ActionTemplateListing> GetJourneyActiontemplatesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Send a ping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>DeploymentPing</returns>
        
        DeploymentPing GetJourneyDeploymentCustomerPing (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null);

        /// <summary>
        /// Send a ping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>ApiResponse of DeploymentPing</returns>
        
        ApiResponse<DeploymentPing> GetJourneyDeploymentCustomerPingWithHttpInfo (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null);

        /// <summary>
        /// Retrieve a single outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Outcome</returns>
        
        Outcome GetJourneyOutcome (string outcomeId);

        /// <summary>
        /// Retrieve a single outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>ApiResponse of Outcome</returns>
        
        ApiResponse<Outcome> GetJourneyOutcomeWithHttpInfo (string outcomeId);

        /// <summary>
        /// Retrieve all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>OutcomeListing</returns>
        
        OutcomeListing GetJourneyOutcomes (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of OutcomeListing</returns>
        
        ApiResponse<OutcomeListing> GetJourneyOutcomesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Get job status.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>OutcomeAttributionJobStateResponse</returns>
        
        OutcomeAttributionJobStateResponse GetJourneyOutcomesAttributionsJob (string jobId);

        /// <summary>
        /// Get job status.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of OutcomeAttributionJobStateResponse</returns>
        
        ApiResponse<OutcomeAttributionJobStateResponse> GetJourneyOutcomesAttributionsJobWithHttpInfo (string jobId);

        /// <summary>
        /// Get outcome attribution entities from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>OutcomeAttributionResponseListing</returns>
        
        OutcomeAttributionResponseListing GetJourneyOutcomesAttributionsJobResults (string jobId);

        /// <summary>
        /// Get outcome attribution entities from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of OutcomeAttributionResponseListing</returns>
        
        ApiResponse<OutcomeAttributionResponseListing> GetJourneyOutcomesAttributionsJobResultsWithHttpInfo (string jobId);

        /// <summary>
        /// Retrieve a single outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>OutcomePredictor</returns>
        
        OutcomePredictor GetJourneyOutcomesPredictor (string predictorId);

        /// <summary>
        /// Retrieve a single outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>ApiResponse of OutcomePredictor</returns>
        
        ApiResponse<OutcomePredictor> GetJourneyOutcomesPredictorWithHttpInfo (string predictorId);

        /// <summary>
        /// Retrieve all outcome predictors.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OutcomePredictorListing</returns>
        
        OutcomePredictorListing GetJourneyOutcomesPredictors ();

        /// <summary>
        /// Retrieve all outcome predictors.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OutcomePredictorListing</returns>
        
        ApiResponse<OutcomePredictorListing> GetJourneyOutcomesPredictorsWithHttpInfo ();

        /// <summary>
        /// Retrieve a single segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>JourneySegment</returns>
        
        JourneySegment GetJourneySegment (string segmentId);

        /// <summary>
        /// Retrieve a single segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        
        ApiResponse<JourneySegment> GetJourneySegmentWithHttpInfo (string segmentId);

        /// <summary>
        /// Retrieve all segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>SegmentListing</returns>
        
        SegmentListing GetJourneySegments (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of SegmentListing</returns>
        
        ApiResponse<SegmentListing> GetJourneySegmentsWithHttpInfo (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve a single session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Session</returns>
        
        Session GetJourneySession (string sessionId);

        /// <summary>
        /// Retrieve a single session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>ApiResponse of Session</returns>
        
        ApiResponse<Session> GetJourneySessionWithHttpInfo (string sessionId);

        /// <summary>
        /// Retrieve all events for a given session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>EventListing</returns>
        
        EventListing GetJourneySessionEvents (string sessionId, string pageSize = null, string after = null, string eventType = null);

        /// <summary>
        /// Retrieve all events for a given session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>ApiResponse of EventListing</returns>
        
        ApiResponse<EventListing> GetJourneySessionEventsWithHttpInfo (string sessionId, string pageSize = null, string after = null, string eventType = null);

        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>OutcomeScoresResult</returns>
        
        OutcomeScoresResult GetJourneySessionOutcomescores (string sessionId);

        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>ApiResponse of OutcomeScoresResult</returns>
        
        ApiResponse<OutcomeScoresResult> GetJourneySessionOutcomescoresWithHttpInfo (string sessionId);

        /// <summary>
        /// Get a Journey View by ID
        /// </summary>
        /// <remarks>
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>JourneyView</returns>
        
        JourneyView GetJourneyView (string viewId);

        /// <summary>
        /// Get a Journey View by ID
        /// </summary>
        /// <remarks>
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        ApiResponse<JourneyView> GetJourneyViewWithHttpInfo (string viewId);

        /// <summary>
        /// Get a Journey View by ID and version
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>JourneyView</returns>
        
        JourneyView GetJourneyViewVersion (string viewId, string versionId);

        /// <summary>
        /// Get a Journey View by ID and version
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        ApiResponse<JourneyView> GetJourneyViewVersionWithHttpInfo (string viewId, string versionId);

        /// <summary>
        /// Get the job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>JourneyViewJob</returns>
        
        JourneyViewJob GetJourneyViewVersionJob (string viewId, string journeyVersionId, string jobId);

        /// <summary>
        /// Get the job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>ApiResponse of JourneyViewJob</returns>
        
        ApiResponse<JourneyViewJob> GetJourneyViewVersionJobWithHttpInfo (string viewId, string journeyVersionId, string jobId);

        /// <summary>
        /// Get the result of a job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>JourneyViewResult</returns>
        
        JourneyViewResult GetJourneyViewVersionJobResults (string viewId, string journeyViewVersion, string jobId);

        /// <summary>
        /// Get the result of a job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>ApiResponse of JourneyViewResult</returns>
        
        ApiResponse<JourneyViewResult> GetJourneyViewVersionJobResultsWithHttpInfo (string viewId, string journeyViewVersion, string jobId);

        /// <summary>
        /// Get the latest job of a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>JourneyViewJob</returns>
        
        JourneyViewJob GetJourneyViewVersionJobsLatest (string viewId, string journeyVersionId);

        /// <summary>
        /// Get the latest job of a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>ApiResponse of JourneyViewJob</returns>
        
        ApiResponse<JourneyViewJob> GetJourneyViewVersionJobsLatestWithHttpInfo (string viewId, string journeyVersionId);

        /// <summary>
        /// Get a list of Journey Views
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>JourneyViewListing</returns>
        
        JourneyViewListing GetJourneyViews ();

        /// <summary>
        /// Get a list of Journey Views
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of JourneyViewListing</returns>
        
        ApiResponse<JourneyViewListing> GetJourneyViewsWithHttpInfo ();

        /// <summary>
        /// Get an Event Definition
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>JourneyEventDefinition</returns>
        
        JourneyEventDefinition GetJourneyViewsEventdefinition (string eventDefinitionId);

        /// <summary>
        /// Get an Event Definition
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>ApiResponse of JourneyEventDefinition</returns>
        
        ApiResponse<JourneyEventDefinition> GetJourneyViewsEventdefinitionWithHttpInfo (string eventDefinitionId);

        /// <summary>
        /// Get a list of Event Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>JourneyEventDefinitionListing</returns>
        
        JourneyEventDefinitionListing GetJourneyViewsEventdefinitions ();

        /// <summary>
        /// Get a list of Event Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of JourneyEventDefinitionListing</returns>
        
        ApiResponse<JourneyEventDefinitionListing> GetJourneyViewsEventdefinitionsWithHttpInfo ();

        /// <summary>
        /// Get the jobs for an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>JourneyViewJobListing</returns>
        
        JourneyViewJobListing GetJourneyViewsJobs (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null);

        /// <summary>
        /// Get the jobs for an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>ApiResponse of JourneyViewJobListing</returns>
        
        ApiResponse<JourneyViewJobListing> GetJourneyViewsJobsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null);

        /// <summary>
        /// Update single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionMap</returns>
        
        ActionMap PatchJourneyActionmap (string actionMapId, PatchActionMap body = null);

        /// <summary>
        /// Update single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionMap</returns>
        
        ApiResponse<ActionMap> PatchJourneyActionmapWithHttpInfo (string actionMapId, PatchActionMap body = null);

        /// <summary>
        /// Update a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionTarget</returns>
        
        ActionTarget PatchJourneyActiontarget (string actionTargetId, PatchActionTarget body = null);

        /// <summary>
        /// Update a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionTarget</returns>
        
        ApiResponse<ActionTarget> PatchJourneyActiontargetWithHttpInfo (string actionTargetId, PatchActionTarget body = null);

        /// <summary>
        /// Update a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionTemplate</returns>
        
        ActionTemplate PatchJourneyActiontemplate (string actionTemplateId, PatchActionTemplate body = null);

        /// <summary>
        /// Update a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionTemplate</returns>
        
        ApiResponse<ActionTemplate> PatchJourneyActiontemplateWithHttpInfo (string actionTemplateId, PatchActionTemplate body = null);

        /// <summary>
        /// Update an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Outcome</returns>
        
        Outcome PatchJourneyOutcome (string outcomeId, PatchOutcome body = null);

        /// <summary>
        /// Update an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Outcome</returns>
        
        ApiResponse<Outcome> PatchJourneyOutcomeWithHttpInfo (string outcomeId, PatchOutcome body = null);

        /// <summary>
        /// Update a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>JourneySegment</returns>
        
        JourneySegment PatchJourneySegment (string segmentId, PatchSegment body = null);

        /// <summary>
        /// Update a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        
        ApiResponse<JourneySegment> PatchJourneySegmentWithHttpInfo (string segmentId, PatchSegment body = null);

        /// <summary>
        /// Query for journey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        AsyncQueryResponse PostAnalyticsJourneysAggregatesJobs (JourneyAsyncAggregationQuery body);

        /// <summary>
        /// Query for journey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        ApiResponse<AsyncQueryResponse> PostAnalyticsJourneysAggregatesJobsWithHttpInfo (JourneyAsyncAggregationQuery body);

        /// <summary>
        /// Query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>JourneyAggregateQueryResponse</returns>
        
        JourneyAggregateQueryResponse PostAnalyticsJourneysAggregatesQuery (JourneyAggregationQuery body);

        /// <summary>
        /// Query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of JourneyAggregateQueryResponse</returns>
        
        ApiResponse<JourneyAggregateQueryResponse> PostAnalyticsJourneysAggregatesQueryWithHttpInfo (JourneyAggregationQuery body);

        /// <summary>
        /// Create an action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionMap</returns>
        
        ActionMap PostJourneyActionmaps (ActionMap body = null);

        /// <summary>
        /// Create an action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionMap</returns>
        
        ApiResponse<ActionMap> PostJourneyActionmapsWithHttpInfo (ActionMap body = null);

        /// <summary>
        /// Query for estimates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>EstimateJobAsyncResponse</returns>
        
        EstimateJobAsyncResponse PostJourneyActionmapsEstimatesJobs (ActionMapEstimateRequest body);

        /// <summary>
        /// Query for estimates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>ApiResponse of EstimateJobAsyncResponse</returns>
        
        ApiResponse<EstimateJobAsyncResponse> PostJourneyActionmapsEstimatesJobsWithHttpInfo (ActionMapEstimateRequest body);

        /// <summary>
        /// Create a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionTemplate</returns>
        
        ActionTemplate PostJourneyActiontemplates (ActionTemplate body = null);

        /// <summary>
        /// Create a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionTemplate</returns>
        
        ApiResponse<ActionTemplate> PostJourneyActiontemplatesWithHttpInfo (ActionTemplate body = null);

        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        
        void PostJourneyDeploymentActionevent (string deploymentId, ActionEventRequest body);

        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostJourneyDeploymentActioneventWithHttpInfo (string deploymentId, ActionEventRequest body);

        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>AppEventResponse</returns>
        
        AppEventResponse PostJourneyDeploymentAppevents (string deploymentId, AppEventRequest body = null);

        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AppEventResponse</returns>
        
        ApiResponse<AppEventResponse> PostJourneyDeploymentAppeventsWithHttpInfo (string deploymentId, AppEventRequest body = null);

        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WebEventResponse</returns>
        
        WebEventResponse PostJourneyDeploymentWebevents (string deploymentId, WebEventRequest body = null);

        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of WebEventResponse</returns>
        
        ApiResponse<WebEventResponse> PostJourneyDeploymentWebeventsWithHttpInfo (string deploymentId, WebEventRequest body = null);

        /// <summary>
        /// Query for flow paths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>FlowPaths</returns>
        
        FlowPaths PostJourneyFlowsPathsQuery (FlowPathsQuery body = null);

        /// <summary>
        /// Query for flow paths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FlowPaths</returns>
        
        ApiResponse<FlowPaths> PostJourneyFlowsPathsQueryWithHttpInfo (FlowPathsQuery body = null);

        /// <summary>
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Outcome</returns>
        
        Outcome PostJourneyOutcomes (OutcomeRequest body = null);

        /// <summary>
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Outcome</returns>
        
        ApiResponse<Outcome> PostJourneyOutcomesWithHttpInfo (OutcomeRequest body = null);

        /// <summary>
        /// Create Outcome Attributions
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>OutcomeAttributionAsyncResponse</returns>
        
        OutcomeAttributionAsyncResponse PostJourneyOutcomesAttributionsJobs (OutcomeAttributionListing body = null);

        /// <summary>
        /// Create Outcome Attributions
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>ApiResponse of OutcomeAttributionAsyncResponse</returns>
        
        ApiResponse<OutcomeAttributionAsyncResponse> PostJourneyOutcomesAttributionsJobsWithHttpInfo (OutcomeAttributionListing body = null);

        /// <summary>
        /// Create an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>OutcomePredictor</returns>
        
        OutcomePredictor PostJourneyOutcomesPredictors (OutcomePredictorRequest body = null);

        /// <summary>
        /// Create an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OutcomePredictor</returns>
        
        ApiResponse<OutcomePredictor> PostJourneyOutcomesPredictorsWithHttpInfo (OutcomePredictorRequest body = null);

        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>JourneySegment</returns>
        
        JourneySegment PostJourneySegments (JourneySegmentRequest body = null);

        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        
        ApiResponse<JourneySegment> PostJourneySegmentsWithHttpInfo (JourneySegmentRequest body = null);

        /// <summary>
        /// Submit a job request for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>JourneyViewJob</returns>
        
        JourneyViewJob PostJourneyViewVersionJobs (string viewId, string journeyVersionId);

        /// <summary>
        /// Submit a job request for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>ApiResponse of JourneyViewJob</returns>
        
        ApiResponse<JourneyViewJob> PostJourneyViewVersionJobsWithHttpInfo (string viewId, string journeyVersionId);

        /// <summary>
        /// Update a Journey View by ID
        /// </summary>
        /// <remarks>
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>JourneyView</returns>
        
        JourneyView PostJourneyViewVersions (string viewId, JourneyView body);

        /// <summary>
        /// Update a Journey View by ID
        /// </summary>
        /// <remarks>
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        ApiResponse<JourneyView> PostJourneyViewVersionsWithHttpInfo (string viewId, JourneyView body);

        /// <summary>
        /// Create a new Journey View
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>JourneyView</returns>
        
        JourneyView PostJourneyViews (JourneyView body);

        /// <summary>
        /// Create a new Journey View
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        ApiResponse<JourneyView> PostJourneyViewsWithHttpInfo (JourneyView body);

        /// <summary>
        /// Validate whether an encoding exist for a label/value combination.
        /// </summary>
        /// <remarks>
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EntityListing</returns>
        
        EntityListing PostJourneyViewsEncodingsValidate (List<Label> body = null);

        /// <summary>
        /// Validate whether an encoding exist for a label/value combination.
        /// </summary>
        /// <remarks>
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EntityListing</returns>
        
        ApiResponse<EntityListing> PostJourneyViewsEncodingsValidateWithHttpInfo (List<Label> body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteJourneyActionmapAsync (string actionMapId);

        /// <summary>
        /// Delete single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyActionmapAsyncWithHttpInfo (string actionMapId);

        /// <summary>
        /// Delete a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteJourneyActiontemplateAsync (string actionTemplateId, bool? hardDelete = null);

        /// <summary>
        /// Delete a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyActiontemplateAsyncWithHttpInfo (string actionTemplateId, bool? hardDelete = null);

        /// <summary>
        /// Delete an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteJourneyOutcomeAsync (string outcomeId);

        /// <summary>
        /// Delete an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyOutcomeAsyncWithHttpInfo (string outcomeId);

        /// <summary>
        /// Delete an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteJourneyOutcomesPredictorAsync (string predictorId);

        /// <summary>
        /// Delete an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyOutcomesPredictorAsyncWithHttpInfo (string predictorId);

        /// <summary>
        /// Delete a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteJourneySegmentAsync (string segmentId);

        /// <summary>
        /// Delete a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneySegmentAsyncWithHttpInfo (string segmentId);

        /// <summary>
        /// Delete a Journey View by ID
        /// </summary>
        /// <remarks>
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteJourneyViewAsync (string viewId);

        /// <summary>
        /// Delete a Journey View by ID
        /// </summary>
        /// <remarks>
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyViewAsyncWithHttpInfo (string viewId);

        /// <summary>
        /// Get status for async query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        System.Threading.Tasks.Task<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobAsync (string jobId);

        /// <summary>
        /// Get status for async query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsJourneysAggregatesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of JourneyAsyncAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsAsync (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (JourneyAsyncAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyAsyncAggregateQueryResponse>> GetAnalyticsJourneysAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of SessionListing</returns>
        
        System.Threading.Tasks.Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of ApiResponse (SessionListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SessionListing>> GetExternalcontactsContactJourneySessionsAsyncWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Retrieve a single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of ActionMap</returns>
        
        System.Threading.Tasks.Task<ActionMap> GetJourneyActionmapAsync (string actionMapId);

        /// <summary>
        /// Retrieve a single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of ApiResponse (ActionMap)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionMap>> GetJourneyActionmapAsyncWithHttpInfo (string actionMapId);

        /// <summary>
        /// Retrieve all action maps.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ActionMapListing</returns>
        
        System.Threading.Tasks.Task<ActionMapListing> GetJourneyActionmapsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all action maps.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (ActionMapListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionMapListing>> GetJourneyActionmapsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Get status of job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of string</returns>
        
        System.Threading.Tasks.Task<string> GetJourneyActionmapsEstimatesJobAsync (string jobId);

        /// <summary>
        /// Get status of job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<string>> GetJourneyActionmapsEstimatesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get estimates from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ActionMapEstimateResult</returns>
        
        System.Threading.Tasks.Task<ActionMapEstimateResult> GetJourneyActionmapsEstimatesJobResultsAsync (string jobId);

        /// <summary>
        /// Get estimates from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (ActionMapEstimateResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionMapEstimateResult>> GetJourneyActionmapsEstimatesJobResultsAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Retrieve a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>Task of ActionTarget</returns>
        
        System.Threading.Tasks.Task<ActionTarget> GetJourneyActiontargetAsync (string actionTargetId);

        /// <summary>
        /// Retrieve a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>Task of ApiResponse (ActionTarget)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTarget>> GetJourneyActiontargetAsyncWithHttpInfo (string actionTargetId);

        /// <summary>
        /// Retrieve all action targets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ActionTargetListing</returns>
        
        System.Threading.Tasks.Task<ActionTargetListing> GetJourneyActiontargetsAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve all action targets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ActionTargetListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTargetListing>> GetJourneyActiontargetsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>Task of ActionTemplate</returns>
        
        System.Threading.Tasks.Task<ActionTemplate> GetJourneyActiontemplateAsync (string actionTemplateId);

        /// <summary>
        /// Retrieve a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>Task of ApiResponse (ActionTemplate)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTemplate>> GetJourneyActiontemplateAsyncWithHttpInfo (string actionTemplateId);

        /// <summary>
        /// Retrieve all action templates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ActionTemplateListing</returns>
        
        System.Threading.Tasks.Task<ActionTemplateListing> GetJourneyActiontemplatesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all action templates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplateListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTemplateListing>> GetJourneyActiontemplatesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Send a ping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>Task of DeploymentPing</returns>
        
        System.Threading.Tasks.Task<DeploymentPing> GetJourneyDeploymentCustomerPingAsync (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null);

        /// <summary>
        /// Send a ping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>Task of ApiResponse (DeploymentPing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DeploymentPing>> GetJourneyDeploymentCustomerPingAsyncWithHttpInfo (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null);

        /// <summary>
        /// Retrieve a single outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of Outcome</returns>
        
        System.Threading.Tasks.Task<Outcome> GetJourneyOutcomeAsync (string outcomeId);

        /// <summary>
        /// Retrieve a single outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Outcome>> GetJourneyOutcomeAsyncWithHttpInfo (string outcomeId);

        /// <summary>
        /// Retrieve all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of OutcomeListing</returns>
        
        System.Threading.Tasks.Task<OutcomeListing> GetJourneyOutcomesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (OutcomeListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomeListing>> GetJourneyOutcomesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Get job status.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of OutcomeAttributionJobStateResponse</returns>
        
        System.Threading.Tasks.Task<OutcomeAttributionJobStateResponse> GetJourneyOutcomesAttributionsJobAsync (string jobId);

        /// <summary>
        /// Get job status.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (OutcomeAttributionJobStateResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomeAttributionJobStateResponse>> GetJourneyOutcomesAttributionsJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get outcome attribution entities from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of OutcomeAttributionResponseListing</returns>
        
        System.Threading.Tasks.Task<OutcomeAttributionResponseListing> GetJourneyOutcomesAttributionsJobResultsAsync (string jobId);

        /// <summary>
        /// Get outcome attribution entities from completed job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (OutcomeAttributionResponseListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomeAttributionResponseListing>> GetJourneyOutcomesAttributionsJobResultsAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Retrieve a single outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of OutcomePredictor</returns>
        
        System.Threading.Tasks.Task<OutcomePredictor> GetJourneyOutcomesPredictorAsync (string predictorId);

        /// <summary>
        /// Retrieve a single outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of ApiResponse (OutcomePredictor)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomePredictor>> GetJourneyOutcomesPredictorAsyncWithHttpInfo (string predictorId);

        /// <summary>
        /// Retrieve all outcome predictors.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OutcomePredictorListing</returns>
        
        System.Threading.Tasks.Task<OutcomePredictorListing> GetJourneyOutcomesPredictorsAsync ();

        /// <summary>
        /// Retrieve all outcome predictors.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OutcomePredictorListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomePredictorListing>> GetJourneyOutcomesPredictorsAsyncWithHttpInfo ();

        /// <summary>
        /// Retrieve a single segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of JourneySegment</returns>
        
        System.Threading.Tasks.Task<JourneySegment> GetJourneySegmentAsync (string segmentId);

        /// <summary>
        /// Retrieve a single segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneySegment>> GetJourneySegmentAsyncWithHttpInfo (string segmentId);

        /// <summary>
        /// Retrieve all segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of SegmentListing</returns>
        
        System.Threading.Tasks.Task<SegmentListing> GetJourneySegmentsAsync (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve all segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SegmentListing>> GetJourneySegmentsAsyncWithHttpInfo (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null);

        /// <summary>
        /// Retrieve a single session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of Session</returns>
        
        System.Threading.Tasks.Task<Session> GetJourneySessionAsync (string sessionId);

        /// <summary>
        /// Retrieve a single session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of ApiResponse (Session)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Session>> GetJourneySessionAsyncWithHttpInfo (string sessionId);

        /// <summary>
        /// Retrieve all events for a given session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>Task of EventListing</returns>
        
        System.Threading.Tasks.Task<EventListing> GetJourneySessionEventsAsync (string sessionId, string pageSize = null, string after = null, string eventType = null);

        /// <summary>
        /// Retrieve all events for a given session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>Task of ApiResponse (EventListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EventListing>> GetJourneySessionEventsAsyncWithHttpInfo (string sessionId, string pageSize = null, string after = null, string eventType = null);

        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of OutcomeScoresResult</returns>
        
        System.Threading.Tasks.Task<OutcomeScoresResult> GetJourneySessionOutcomescoresAsync (string sessionId);

        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of ApiResponse (OutcomeScoresResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomeScoresResult>> GetJourneySessionOutcomescoresAsyncWithHttpInfo (string sessionId);

        /// <summary>
        /// Get a Journey View by ID
        /// </summary>
        /// <remarks>
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of JourneyView</returns>
        
        System.Threading.Tasks.Task<JourneyView> GetJourneyViewAsync (string viewId);

        /// <summary>
        /// Get a Journey View by ID
        /// </summary>
        /// <remarks>
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyView>> GetJourneyViewAsyncWithHttpInfo (string viewId);

        /// <summary>
        /// Get a Journey View by ID and version
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>Task of JourneyView</returns>
        
        System.Threading.Tasks.Task<JourneyView> GetJourneyViewVersionAsync (string viewId, string versionId);

        /// <summary>
        /// Get a Journey View by ID and version
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyView>> GetJourneyViewVersionAsyncWithHttpInfo (string viewId, string versionId);

        /// <summary>
        /// Get the job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>Task of JourneyViewJob</returns>
        
        System.Threading.Tasks.Task<JourneyViewJob> GetJourneyViewVersionJobAsync (string viewId, string journeyVersionId, string jobId);

        /// <summary>
        /// Get the job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>Task of ApiResponse (JourneyViewJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyViewJob>> GetJourneyViewVersionJobAsyncWithHttpInfo (string viewId, string journeyVersionId, string jobId);

        /// <summary>
        /// Get the result of a job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>Task of JourneyViewResult</returns>
        
        System.Threading.Tasks.Task<JourneyViewResult> GetJourneyViewVersionJobResultsAsync (string viewId, string journeyViewVersion, string jobId);

        /// <summary>
        /// Get the result of a job for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>Task of ApiResponse (JourneyViewResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyViewResult>> GetJourneyViewVersionJobResultsAsyncWithHttpInfo (string viewId, string journeyViewVersion, string jobId);

        /// <summary>
        /// Get the latest job of a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of JourneyViewJob</returns>
        
        System.Threading.Tasks.Task<JourneyViewJob> GetJourneyViewVersionJobsLatestAsync (string viewId, string journeyVersionId);

        /// <summary>
        /// Get the latest job of a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of ApiResponse (JourneyViewJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyViewJob>> GetJourneyViewVersionJobsLatestAsyncWithHttpInfo (string viewId, string journeyVersionId);

        /// <summary>
        /// Get a list of Journey Views
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of JourneyViewListing</returns>
        
        System.Threading.Tasks.Task<JourneyViewListing> GetJourneyViewsAsync ();

        /// <summary>
        /// Get a list of Journey Views
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (JourneyViewListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyViewListing>> GetJourneyViewsAsyncWithHttpInfo ();

        /// <summary>
        /// Get an Event Definition
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>Task of JourneyEventDefinition</returns>
        
        System.Threading.Tasks.Task<JourneyEventDefinition> GetJourneyViewsEventdefinitionAsync (string eventDefinitionId);

        /// <summary>
        /// Get an Event Definition
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>Task of ApiResponse (JourneyEventDefinition)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyEventDefinition>> GetJourneyViewsEventdefinitionAsyncWithHttpInfo (string eventDefinitionId);

        /// <summary>
        /// Get a list of Event Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of JourneyEventDefinitionListing</returns>
        
        System.Threading.Tasks.Task<JourneyEventDefinitionListing> GetJourneyViewsEventdefinitionsAsync ();

        /// <summary>
        /// Get a list of Event Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (JourneyEventDefinitionListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyEventDefinitionListing>> GetJourneyViewsEventdefinitionsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the jobs for an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>Task of JourneyViewJobListing</returns>
        
        System.Threading.Tasks.Task<JourneyViewJobListing> GetJourneyViewsJobsAsync (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null);

        /// <summary>
        /// Get the jobs for an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>Task of ApiResponse (JourneyViewJobListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyViewJobListing>> GetJourneyViewsJobsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null);

        /// <summary>
        /// Update single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionMap</returns>
        
        System.Threading.Tasks.Task<ActionMap> PatchJourneyActionmapAsync (string actionMapId, PatchActionMap body = null);

        /// <summary>
        /// Update single action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionMap)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionMap>> PatchJourneyActionmapAsyncWithHttpInfo (string actionMapId, PatchActionMap body = null);

        /// <summary>
        /// Update a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionTarget</returns>
        
        System.Threading.Tasks.Task<ActionTarget> PatchJourneyActiontargetAsync (string actionTargetId, PatchActionTarget body = null);

        /// <summary>
        /// Update a single action target.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionTarget)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTarget>> PatchJourneyActiontargetAsyncWithHttpInfo (string actionTargetId, PatchActionTarget body = null);

        /// <summary>
        /// Update a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionTemplate</returns>
        
        System.Threading.Tasks.Task<ActionTemplate> PatchJourneyActiontemplateAsync (string actionTemplateId, PatchActionTemplate body = null);

        /// <summary>
        /// Update a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplate)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTemplate>> PatchJourneyActiontemplateAsyncWithHttpInfo (string actionTemplateId, PatchActionTemplate body = null);

        /// <summary>
        /// Update an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Outcome</returns>
        
        System.Threading.Tasks.Task<Outcome> PatchJourneyOutcomeAsync (string outcomeId, PatchOutcome body = null);

        /// <summary>
        /// Update an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Outcome>> PatchJourneyOutcomeAsyncWithHttpInfo (string outcomeId, PatchOutcome body = null);

        /// <summary>
        /// Update a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of JourneySegment</returns>
        
        System.Threading.Tasks.Task<JourneySegment> PatchJourneySegmentAsync (string segmentId, PatchSegment body = null);

        /// <summary>
        /// Update a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneySegment>> PatchJourneySegmentAsyncWithHttpInfo (string segmentId, PatchSegment body = null);

        /// <summary>
        /// Query for journey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        System.Threading.Tasks.Task<AsyncQueryResponse> PostAnalyticsJourneysAggregatesJobsAsync (JourneyAsyncAggregationQuery body);

        /// <summary>
        /// Query for journey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsJourneysAggregatesJobsAsyncWithHttpInfo (JourneyAsyncAggregationQuery body);

        /// <summary>
        /// Query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of JourneyAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<JourneyAggregateQueryResponse> PostAnalyticsJourneysAggregatesQueryAsync (JourneyAggregationQuery body);

        /// <summary>
        /// Query for journey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (JourneyAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyAggregateQueryResponse>> PostAnalyticsJourneysAggregatesQueryAsyncWithHttpInfo (JourneyAggregationQuery body);

        /// <summary>
        /// Create an action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionMap</returns>
        
        System.Threading.Tasks.Task<ActionMap> PostJourneyActionmapsAsync (ActionMap body = null);

        /// <summary>
        /// Create an action map.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionMap)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionMap>> PostJourneyActionmapsAsyncWithHttpInfo (ActionMap body = null);

        /// <summary>
        /// Query for estimates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>Task of EstimateJobAsyncResponse</returns>
        
        System.Threading.Tasks.Task<EstimateJobAsyncResponse> PostJourneyActionmapsEstimatesJobsAsync (ActionMapEstimateRequest body);

        /// <summary>
        /// Query for estimates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>Task of ApiResponse (EstimateJobAsyncResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EstimateJobAsyncResponse>> PostJourneyActionmapsEstimatesJobsAsyncWithHttpInfo (ActionMapEstimateRequest body);

        /// <summary>
        /// Create a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionTemplate</returns>
        
        System.Threading.Tasks.Task<ActionTemplate> PostJourneyActiontemplatesAsync (ActionTemplate body = null);

        /// <summary>
        /// Create a single action template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplate)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ActionTemplate>> PostJourneyActiontemplatesAsyncWithHttpInfo (ActionTemplate body = null);

        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostJourneyDeploymentActioneventAsync (string deploymentId, ActionEventRequest body);

        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostJourneyDeploymentActioneventAsyncWithHttpInfo (string deploymentId, ActionEventRequest body);

        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AppEventResponse</returns>
        
        System.Threading.Tasks.Task<AppEventResponse> PostJourneyDeploymentAppeventsAsync (string deploymentId, AppEventRequest body = null);

        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AppEventResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AppEventResponse>> PostJourneyDeploymentAppeventsAsyncWithHttpInfo (string deploymentId, AppEventRequest body = null);

        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of WebEventResponse</returns>
        
        System.Threading.Tasks.Task<WebEventResponse> PostJourneyDeploymentWebeventsAsync (string deploymentId, WebEventRequest body = null);

        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (WebEventResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebEventResponse>> PostJourneyDeploymentWebeventsAsyncWithHttpInfo (string deploymentId, WebEventRequest body = null);

        /// <summary>
        /// Query for flow paths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FlowPaths</returns>
        
        System.Threading.Tasks.Task<FlowPaths> PostJourneyFlowsPathsQueryAsync (FlowPathsQuery body = null);

        /// <summary>
        /// Query for flow paths.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FlowPaths)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FlowPaths>> PostJourneyFlowsPathsQueryAsyncWithHttpInfo (FlowPathsQuery body = null);

        /// <summary>
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Outcome</returns>
        
        System.Threading.Tasks.Task<Outcome> PostJourneyOutcomesAsync (OutcomeRequest body = null);

        /// <summary>
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Outcome>> PostJourneyOutcomesAsyncWithHttpInfo (OutcomeRequest body = null);

        /// <summary>
        /// Create Outcome Attributions
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>Task of OutcomeAttributionAsyncResponse</returns>
        
        System.Threading.Tasks.Task<OutcomeAttributionAsyncResponse> PostJourneyOutcomesAttributionsJobsAsync (OutcomeAttributionListing body = null);

        /// <summary>
        /// Create Outcome Attributions
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>Task of ApiResponse (OutcomeAttributionAsyncResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomeAttributionAsyncResponse>> PostJourneyOutcomesAttributionsJobsAsyncWithHttpInfo (OutcomeAttributionListing body = null);

        /// <summary>
        /// Create an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OutcomePredictor</returns>
        
        System.Threading.Tasks.Task<OutcomePredictor> PostJourneyOutcomesPredictorsAsync (OutcomePredictorRequest body = null);

        /// <summary>
        /// Create an outcome predictor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OutcomePredictor)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OutcomePredictor>> PostJourneyOutcomesPredictorsAsyncWithHttpInfo (OutcomePredictorRequest body = null);

        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of JourneySegment</returns>
        
        System.Threading.Tasks.Task<JourneySegment> PostJourneySegmentsAsync (JourneySegmentRequest body = null);

        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneySegment>> PostJourneySegmentsAsyncWithHttpInfo (JourneySegmentRequest body = null);

        /// <summary>
        /// Submit a job request for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of JourneyViewJob</returns>
        
        System.Threading.Tasks.Task<JourneyViewJob> PostJourneyViewVersionJobsAsync (string viewId, string journeyVersionId);

        /// <summary>
        /// Submit a job request for a journey view version.
        /// </summary>
        /// <remarks>
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of ApiResponse (JourneyViewJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyViewJob>> PostJourneyViewVersionJobsAsyncWithHttpInfo (string viewId, string journeyVersionId);

        /// <summary>
        /// Update a Journey View by ID
        /// </summary>
        /// <remarks>
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of JourneyView</returns>
        
        System.Threading.Tasks.Task<JourneyView> PostJourneyViewVersionsAsync (string viewId, JourneyView body);

        /// <summary>
        /// Update a Journey View by ID
        /// </summary>
        /// <remarks>
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyView>> PostJourneyViewVersionsAsyncWithHttpInfo (string viewId, JourneyView body);

        /// <summary>
        /// Create a new Journey View
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of JourneyView</returns>
        
        System.Threading.Tasks.Task<JourneyView> PostJourneyViewsAsync (JourneyView body);

        /// <summary>
        /// Create a new Journey View
        /// </summary>
        /// <remarks>
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<JourneyView>> PostJourneyViewsAsyncWithHttpInfo (JourneyView body);

        /// <summary>
        /// Validate whether an encoding exist for a label/value combination.
        /// </summary>
        /// <remarks>
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EntityListing</returns>
        
        System.Threading.Tasks.Task<EntityListing> PostJourneyViewsEncodingsValidateAsync (List<Label> body = null);

        /// <summary>
        /// Validate whether an encoding exist for a label/value combination.
        /// </summary>
        /// <remarks>
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EntityListing>> PostJourneyViewsEncodingsValidateAsyncWithHttpInfo (List<Label> body = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JourneyApi : IJourneyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JourneyApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JourneyApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns></returns>
        
        public void DeleteJourneyActionmap (string actionMapId)
        {
             DeleteJourneyActionmapWithHttpInfo(actionMapId);
        }

        /// <summary>
        /// Delete single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteJourneyActionmapWithHttpInfo (string actionMapId)
        { 
            // verify the required parameter 'actionMapId' is set
            if (actionMapId == null)
                throw new ApiException(400, "Missing required parameter 'actionMapId' when calling JourneyApi->DeleteJourneyActionmap");

            var localVarPath = "/api/v2/journey/actionmaps/{actionMapId}";
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
            if (actionMapId != null) localVarPathParams.Add("actionMapId", this.Configuration.ApiClient.ParameterToString(actionMapId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActionmap: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActionmap: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteJourneyActionmapAsync (string actionMapId)
        {
             await DeleteJourneyActionmapAsyncWithHttpInfo(actionMapId);

        }

        /// <summary>
        /// Delete single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyActionmapAsyncWithHttpInfo (string actionMapId)
        { 
            // verify the required parameter 'actionMapId' is set
            if (actionMapId == null)
                throw new ApiException(400, "Missing required parameter 'actionMapId' when calling JourneyApi->DeleteJourneyActionmap");
            

            var localVarPath = "/api/v2/journey/actionmaps/{actionMapId}";
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
            if (actionMapId != null) localVarPathParams.Add("actionMapId", this.Configuration.ApiClient.ParameterToString(actionMapId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActionmap: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActionmap: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns></returns>
        
        public void DeleteJourneyActiontemplate (string actionTemplateId, bool? hardDelete = null)
        {
             DeleteJourneyActiontemplateWithHttpInfo(actionTemplateId, hardDelete);
        }

        /// <summary>
        /// Delete a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteJourneyActiontemplateWithHttpInfo (string actionTemplateId, bool? hardDelete = null)
        { 
            // verify the required parameter 'actionTemplateId' is set
            if (actionTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'actionTemplateId' when calling JourneyApi->DeleteJourneyActiontemplate");

            var localVarPath = "/api/v2/journey/actiontemplates/{actionTemplateId}";
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
            if (actionTemplateId != null) localVarPathParams.Add("actionTemplateId", this.Configuration.ApiClient.ParameterToString(actionTemplateId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActiontemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActiontemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteJourneyActiontemplateAsync (string actionTemplateId, bool? hardDelete = null)
        {
             await DeleteJourneyActiontemplateAsyncWithHttpInfo(actionTemplateId, hardDelete);

        }

        /// <summary>
        /// Delete a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="hardDelete">Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyActiontemplateAsyncWithHttpInfo (string actionTemplateId, bool? hardDelete = null)
        { 
            // verify the required parameter 'actionTemplateId' is set
            if (actionTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'actionTemplateId' when calling JourneyApi->DeleteJourneyActiontemplate");
            

            var localVarPath = "/api/v2/journey/actiontemplates/{actionTemplateId}";
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
            if (actionTemplateId != null) localVarPathParams.Add("actionTemplateId", this.Configuration.ApiClient.ParameterToString(actionTemplateId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActiontemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyActiontemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns></returns>
        
        public void DeleteJourneyOutcome (string outcomeId)
        {
             DeleteJourneyOutcomeWithHttpInfo(outcomeId);
        }

        /// <summary>
        /// Delete an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteJourneyOutcomeWithHttpInfo (string outcomeId)
        { 
            // verify the required parameter 'outcomeId' is set
            if (outcomeId == null)
                throw new ApiException(400, "Missing required parameter 'outcomeId' when calling JourneyApi->DeleteJourneyOutcome");

            var localVarPath = "/api/v2/journey/outcomes/{outcomeId}";
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
            if (outcomeId != null) localVarPathParams.Add("outcomeId", this.Configuration.ApiClient.ParameterToString(outcomeId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteJourneyOutcomeAsync (string outcomeId)
        {
             await DeleteJourneyOutcomeAsyncWithHttpInfo(outcomeId);

        }

        /// <summary>
        /// Delete an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyOutcomeAsyncWithHttpInfo (string outcomeId)
        { 
            // verify the required parameter 'outcomeId' is set
            if (outcomeId == null)
                throw new ApiException(400, "Missing required parameter 'outcomeId' when calling JourneyApi->DeleteJourneyOutcome");
            

            var localVarPath = "/api/v2/journey/outcomes/{outcomeId}";
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
            if (outcomeId != null) localVarPathParams.Add("outcomeId", this.Configuration.ApiClient.ParameterToString(outcomeId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns></returns>
        
        public void DeleteJourneyOutcomesPredictor (string predictorId)
        {
             DeleteJourneyOutcomesPredictorWithHttpInfo(predictorId);
        }

        /// <summary>
        /// Delete an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteJourneyOutcomesPredictorWithHttpInfo (string predictorId)
        { 
            // verify the required parameter 'predictorId' is set
            if (predictorId == null)
                throw new ApiException(400, "Missing required parameter 'predictorId' when calling JourneyApi->DeleteJourneyOutcomesPredictor");

            var localVarPath = "/api/v2/journey/outcomes/predictors/{predictorId}";
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
            if (predictorId != null) localVarPathParams.Add("predictorId", this.Configuration.ApiClient.ParameterToString(predictorId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcomesPredictor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcomesPredictor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteJourneyOutcomesPredictorAsync (string predictorId)
        {
             await DeleteJourneyOutcomesPredictorAsyncWithHttpInfo(predictorId);

        }

        /// <summary>
        /// Delete an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyOutcomesPredictorAsyncWithHttpInfo (string predictorId)
        { 
            // verify the required parameter 'predictorId' is set
            if (predictorId == null)
                throw new ApiException(400, "Missing required parameter 'predictorId' when calling JourneyApi->DeleteJourneyOutcomesPredictor");
            

            var localVarPath = "/api/v2/journey/outcomes/predictors/{predictorId}";
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
            if (predictorId != null) localVarPathParams.Add("predictorId", this.Configuration.ApiClient.ParameterToString(predictorId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcomesPredictor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyOutcomesPredictor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns></returns>
        
        public void DeleteJourneySegment (string segmentId)
        {
             DeleteJourneySegmentWithHttpInfo(segmentId);
        }

        /// <summary>
        /// Delete a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteJourneySegmentWithHttpInfo (string segmentId)
        { 
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling JourneyApi->DeleteJourneySegment");

            var localVarPath = "/api/v2/journey/segments/{segmentId}";
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
            if (segmentId != null) localVarPathParams.Add("segmentId", this.Configuration.ApiClient.ParameterToString(segmentId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneySegment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneySegment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteJourneySegmentAsync (string segmentId)
        {
             await DeleteJourneySegmentAsyncWithHttpInfo(segmentId);

        }

        /// <summary>
        /// Delete a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneySegmentAsyncWithHttpInfo (string segmentId)
        { 
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling JourneyApi->DeleteJourneySegment");
            

            var localVarPath = "/api/v2/journey/segments/{segmentId}";
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
            if (segmentId != null) localVarPathParams.Add("segmentId", this.Configuration.ApiClient.ParameterToString(segmentId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneySegment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneySegment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Journey View by ID 
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns></returns>
        
        public void DeleteJourneyView (string viewId)
        {
             DeleteJourneyViewWithHttpInfo(viewId);
        }

        /// <summary>
        /// Delete a Journey View by ID 
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteJourneyViewWithHttpInfo (string viewId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->DeleteJourneyView");

            var localVarPath = "/api/v2/journey/views/{viewId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyView: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyView: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Journey View by ID 
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteJourneyViewAsync (string viewId)
        {
             await DeleteJourneyViewAsyncWithHttpInfo(viewId);

        }

        /// <summary>
        /// Delete a Journey View by ID 
        /// deletes all versions
        /// DeleteJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJourneyViewAsyncWithHttpInfo (string viewId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->DeleteJourneyView");
            

            var localVarPath = "/api/v2/journey/views/{viewId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyView: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJourneyView: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status for async query for journey aggregates 
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        public AsyncQueryStatus GetAnalyticsJourneysAggregatesJob (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = GetAnalyticsJourneysAggregatesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status for async query for journey aggregates 
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        public ApiResponse< AsyncQueryStatus > GetAnalyticsJourneysAggregatesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetAnalyticsJourneysAggregatesJob");

            var localVarPath = "/api/v2/analytics/journeys/aggregates/jobs/{jobId}";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status for async query for journey aggregates 
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobAsync (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = await GetAnalyticsJourneysAggregatesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status for async query for journey aggregates 
        /// 
        /// GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsJourneysAggregatesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetAnalyticsJourneysAggregatesJob");
            

            var localVarPath = "/api/v2/analytics/journeys/aggregates/jobs/{jobId}";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>JourneyAsyncAggregateQueryResponse</returns>
        
        public JourneyAsyncAggregateQueryResponse GetAnalyticsJourneysAggregatesJobResults (string jobId, string cursor = null)
        {
             ApiResponse<JourneyAsyncAggregateQueryResponse> localVarResponse = GetAnalyticsJourneysAggregatesJobResultsWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of JourneyAsyncAggregateQueryResponse</returns>
        
        public ApiResponse< JourneyAsyncAggregateQueryResponse > GetAnalyticsJourneysAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetAnalyticsJourneysAggregatesJobResults");

            var localVarPath = "/api/v2/analytics/journeys/aggregates/jobs/{jobId}/results";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (JourneyAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of JourneyAsyncAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsAsync (string jobId, string cursor = null)
        {
             ApiResponse<JourneyAsyncAggregateQueryResponse> localVarResponse = await GetAnalyticsJourneysAggregatesJobResultsAsyncWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (JourneyAsyncAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyAsyncAggregateQueryResponse>> GetAnalyticsJourneysAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetAnalyticsJourneysAggregatesJobResults");
            

            var localVarPath = "/api/v2/analytics/journeys/aggregates/jobs/{jobId}/results";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsJourneysAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (JourneyAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>SessionListing</returns>
        
        public SessionListing GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        {
             ApiResponse<SessionListing> localVarResponse = GetExternalcontactsContactJourneySessionsWithHttpInfo(contactId, pageSize, after, includeMerged);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>ApiResponse of SessionListing</returns>
        
        public ApiResponse< SessionListing > GetExternalcontactsContactJourneySessionsWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling JourneyApi->GetExternalcontactsContactJourneySessions");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/journey/sessions";
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
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (includeMerged != null) localVarQueryParams.Add(new Tuple<string, string>("includeMerged", this.Configuration.ApiClient.ParameterToString(includeMerged)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SessionListing>(localVarStatusCode,
                localVarHeaders,
                (SessionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SessionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of SessionListing</returns>
        
        public async System.Threading.Tasks.Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        {
             ApiResponse<SessionListing> localVarResponse = await GetExternalcontactsContactJourneySessionsAsyncWithHttpInfo(contactId, pageSize, after, includeMerged);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of ApiResponse (SessionListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SessionListing>> GetExternalcontactsContactJourneySessionsAsyncWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling JourneyApi->GetExternalcontactsContactJourneySessions");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/journey/sessions";
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
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (includeMerged != null) localVarQueryParams.Add(new Tuple<string, string>("includeMerged", this.Configuration.ApiClient.ParameterToString(includeMerged)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SessionListing>(localVarStatusCode,
                localVarHeaders,
                (SessionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SessionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>ActionMap</returns>
        
        public ActionMap GetJourneyActionmap (string actionMapId)
        {
             ApiResponse<ActionMap> localVarResponse = GetJourneyActionmapWithHttpInfo(actionMapId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>ApiResponse of ActionMap</returns>
        
        public ApiResponse< ActionMap > GetJourneyActionmapWithHttpInfo (string actionMapId)
        { 
            // verify the required parameter 'actionMapId' is set
            if (actionMapId == null)
                throw new ApiException(400, "Missing required parameter 'actionMapId' when calling JourneyApi->GetJourneyActionmap");

            var localVarPath = "/api/v2/journey/actionmaps/{actionMapId}";
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
            if (actionMapId != null) localVarPathParams.Add("actionMapId", this.Configuration.ApiClient.ParameterToString(actionMapId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmap: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmap: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMap>(localVarStatusCode,
                localVarHeaders,
                (ActionMap) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMap)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of ActionMap</returns>
        
        public async System.Threading.Tasks.Task<ActionMap> GetJourneyActionmapAsync (string actionMapId)
        {
             ApiResponse<ActionMap> localVarResponse = await GetJourneyActionmapAsyncWithHttpInfo(actionMapId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <returns>Task of ApiResponse (ActionMap)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionMap>> GetJourneyActionmapAsyncWithHttpInfo (string actionMapId)
        { 
            // verify the required parameter 'actionMapId' is set
            if (actionMapId == null)
                throw new ApiException(400, "Missing required parameter 'actionMapId' when calling JourneyApi->GetJourneyActionmap");
            

            var localVarPath = "/api/v2/journey/actionmaps/{actionMapId}";
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
            if (actionMapId != null) localVarPathParams.Add("actionMapId", this.Configuration.ApiClient.ParameterToString(actionMapId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmap: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmap: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMap>(localVarStatusCode,
                localVarHeaders,
                (ActionMap) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMap)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all action maps. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ActionMapListing</returns>
        
        public ActionMapListing GetJourneyActionmaps (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<ActionMapListing> localVarResponse = GetJourneyActionmapsWithHttpInfo(pageNumber, pageSize, sortBy, filterField, filterValue, actionMapIds, queryFields, queryValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all action maps. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of ActionMapListing</returns>
        
        public ApiResponse< ActionMapListing > GetJourneyActionmapsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/actionmaps";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (filterField != null) localVarQueryParams.Add(new Tuple<string, string>("filterField", this.Configuration.ApiClient.ParameterToString(filterField)));
            if (filterValue != null) localVarQueryParams.Add(new Tuple<string, string>("filterValue", this.Configuration.ApiClient.ParameterToString(filterValue)));
            if (actionMapIds != null) actionMapIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("actionMapIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmaps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmaps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMapListing>(localVarStatusCode,
                localVarHeaders,
                (ActionMapListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMapListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all action maps. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ActionMapListing</returns>
        
        public async System.Threading.Tasks.Task<ActionMapListing> GetJourneyActionmapsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<ActionMapListing> localVarResponse = await GetJourneyActionmapsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, filterField, filterValue, actionMapIds, queryFields, queryValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all action maps. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (ActionMapListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionMapListing>> GetJourneyActionmapsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/actionmaps";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (filterField != null) localVarQueryParams.Add(new Tuple<string, string>("filterField", this.Configuration.ApiClient.ParameterToString(filterField)));
            if (filterValue != null) localVarQueryParams.Add(new Tuple<string, string>("filterValue", this.Configuration.ApiClient.ParameterToString(filterValue)));
            if (actionMapIds != null) actionMapIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("actionMapIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmaps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmaps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMapListing>(localVarStatusCode,
                localVarHeaders,
                (ActionMapListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMapListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status of job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>string</returns>
        
        public string GetJourneyActionmapsEstimatesJob (string jobId)
        {
             ApiResponse<string> localVarResponse = GetJourneyActionmapsEstimatesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status of job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of string</returns>
        
        public ApiResponse< string > GetJourneyActionmapsEstimatesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyActionmapsEstimatesJob");

            var localVarPath = "/api/v2/journey/actionmaps/estimates/jobs/{jobId}";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status of job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of string</returns>
        
        public async System.Threading.Tasks.Task<string> GetJourneyActionmapsEstimatesJobAsync (string jobId)
        {
             ApiResponse<string> localVarResponse = await GetJourneyActionmapsEstimatesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status of job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetJourneyActionmapsEstimatesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyActionmapsEstimatesJob");
            

            var localVarPath = "/api/v2/journey/actionmaps/estimates/jobs/{jobId}";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get estimates from completed job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ActionMapEstimateResult</returns>
        
        public ActionMapEstimateResult GetJourneyActionmapsEstimatesJobResults (string jobId)
        {
             ApiResponse<ActionMapEstimateResult> localVarResponse = GetJourneyActionmapsEstimatesJobResultsWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get estimates from completed job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of ActionMapEstimateResult</returns>
        
        public ApiResponse< ActionMapEstimateResult > GetJourneyActionmapsEstimatesJobResultsWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyActionmapsEstimatesJobResults");

            var localVarPath = "/api/v2/journey/actionmaps/estimates/jobs/{jobId}/results";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMapEstimateResult>(localVarStatusCode,
                localVarHeaders,
                (ActionMapEstimateResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMapEstimateResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get estimates from completed job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ActionMapEstimateResult</returns>
        
        public async System.Threading.Tasks.Task<ActionMapEstimateResult> GetJourneyActionmapsEstimatesJobResultsAsync (string jobId)
        {
             ApiResponse<ActionMapEstimateResult> localVarResponse = await GetJourneyActionmapsEstimatesJobResultsAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get estimates from completed job. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (ActionMapEstimateResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionMapEstimateResult>> GetJourneyActionmapsEstimatesJobResultsAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyActionmapsEstimatesJobResults");
            

            var localVarPath = "/api/v2/journey/actionmaps/estimates/jobs/{jobId}/results";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActionmapsEstimatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMapEstimateResult>(localVarStatusCode,
                localVarHeaders,
                (ActionMapEstimateResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMapEstimateResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>ActionTarget</returns>
        
        public ActionTarget GetJourneyActiontarget (string actionTargetId)
        {
             ApiResponse<ActionTarget> localVarResponse = GetJourneyActiontargetWithHttpInfo(actionTargetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>ApiResponse of ActionTarget</returns>
        
        public ApiResponse< ActionTarget > GetJourneyActiontargetWithHttpInfo (string actionTargetId)
        { 
            // verify the required parameter 'actionTargetId' is set
            if (actionTargetId == null)
                throw new ApiException(400, "Missing required parameter 'actionTargetId' when calling JourneyApi->GetJourneyActiontarget");

            var localVarPath = "/api/v2/journey/actiontargets/{actionTargetId}";
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
            if (actionTargetId != null) localVarPathParams.Add("actionTargetId", this.Configuration.ApiClient.ParameterToString(actionTargetId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTarget>(localVarStatusCode,
                localVarHeaders,
                (ActionTarget) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTarget)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>Task of ActionTarget</returns>
        
        public async System.Threading.Tasks.Task<ActionTarget> GetJourneyActiontargetAsync (string actionTargetId)
        {
             ApiResponse<ActionTarget> localVarResponse = await GetJourneyActiontargetAsyncWithHttpInfo(actionTargetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <returns>Task of ApiResponse (ActionTarget)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTarget>> GetJourneyActiontargetAsyncWithHttpInfo (string actionTargetId)
        { 
            // verify the required parameter 'actionTargetId' is set
            if (actionTargetId == null)
                throw new ApiException(400, "Missing required parameter 'actionTargetId' when calling JourneyApi->GetJourneyActiontarget");
            

            var localVarPath = "/api/v2/journey/actiontargets/{actionTargetId}";
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
            if (actionTargetId != null) localVarPathParams.Add("actionTargetId", this.Configuration.ApiClient.ParameterToString(actionTargetId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTarget>(localVarStatusCode,
                localVarHeaders,
                (ActionTarget) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTarget)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all action targets. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ActionTargetListing</returns>
        
        public ActionTargetListing GetJourneyActiontargets (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ActionTargetListing> localVarResponse = GetJourneyActiontargetsWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all action targets. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ActionTargetListing</returns>
        
        public ApiResponse< ActionTargetListing > GetJourneyActiontargetsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/journey/actiontargets";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontargets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontargets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTargetListing>(localVarStatusCode,
                localVarHeaders,
                (ActionTargetListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTargetListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all action targets. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ActionTargetListing</returns>
        
        public async System.Threading.Tasks.Task<ActionTargetListing> GetJourneyActiontargetsAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ActionTargetListing> localVarResponse = await GetJourneyActiontargetsAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all action targets. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ActionTargetListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTargetListing>> GetJourneyActiontargetsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/journey/actiontargets";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontargets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontargets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTargetListing>(localVarStatusCode,
                localVarHeaders,
                (ActionTargetListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTargetListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>ActionTemplate</returns>
        
        public ActionTemplate GetJourneyActiontemplate (string actionTemplateId)
        {
             ApiResponse<ActionTemplate> localVarResponse = GetJourneyActiontemplateWithHttpInfo(actionTemplateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>ApiResponse of ActionTemplate</returns>
        
        public ApiResponse< ActionTemplate > GetJourneyActiontemplateWithHttpInfo (string actionTemplateId)
        { 
            // verify the required parameter 'actionTemplateId' is set
            if (actionTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'actionTemplateId' when calling JourneyApi->GetJourneyActiontemplate");

            var localVarPath = "/api/v2/journey/actiontemplates/{actionTemplateId}";
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
            if (actionTemplateId != null) localVarPathParams.Add("actionTemplateId", this.Configuration.ApiClient.ParameterToString(actionTemplateId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplate>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>Task of ActionTemplate</returns>
        
        public async System.Threading.Tasks.Task<ActionTemplate> GetJourneyActiontemplateAsync (string actionTemplateId)
        {
             ApiResponse<ActionTemplate> localVarResponse = await GetJourneyActiontemplateAsyncWithHttpInfo(actionTemplateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <returns>Task of ApiResponse (ActionTemplate)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTemplate>> GetJourneyActiontemplateAsyncWithHttpInfo (string actionTemplateId)
        { 
            // verify the required parameter 'actionTemplateId' is set
            if (actionTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'actionTemplateId' when calling JourneyApi->GetJourneyActiontemplate");
            

            var localVarPath = "/api/v2/journey/actiontemplates/{actionTemplateId}";
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
            if (actionTemplateId != null) localVarPathParams.Add("actionTemplateId", this.Configuration.ApiClient.ParameterToString(actionTemplateId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplate>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all action templates. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ActionTemplateListing</returns>
        
        public ActionTemplateListing GetJourneyActiontemplates (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<ActionTemplateListing> localVarResponse = GetJourneyActiontemplatesWithHttpInfo(pageNumber, pageSize, sortBy, mediaType, state, queryFields, queryValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all action templates. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of ActionTemplateListing</returns>
        
        public ApiResponse< ActionTemplateListing > GetJourneyActiontemplatesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/actiontemplates";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (mediaType != null) localVarQueryParams.Add(new Tuple<string, string>("mediaType", this.Configuration.ApiClient.ParameterToString(mediaType)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplates: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplateListing>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplateListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplateListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all action templates. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ActionTemplateListing</returns>
        
        public async System.Threading.Tasks.Task<ActionTemplateListing> GetJourneyActiontemplatesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<ActionTemplateListing> localVarResponse = await GetJourneyActiontemplatesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, mediaType, state, queryFields, queryValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all action templates. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplateListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTemplateListing>> GetJourneyActiontemplatesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/actiontemplates";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (mediaType != null) localVarQueryParams.Add(new Tuple<string, string>("mediaType", this.Configuration.ApiClient.ParameterToString(mediaType)));
            if (state != null) localVarQueryParams.Add(new Tuple<string, string>("state", this.Configuration.ApiClient.ParameterToString(state)));
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplates: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyActiontemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplateListing>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplateListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplateListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a ping. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>DeploymentPing</returns>
        
        public DeploymentPing GetJourneyDeploymentCustomerPing (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null)
        {
             ApiResponse<DeploymentPing> localVarResponse = GetJourneyDeploymentCustomerPingWithHttpInfo(deploymentId, customerCookieId, dl, dt, appNamespace, sessionId, sinceLastBeaconMilliseconds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a ping. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>ApiResponse of DeploymentPing</returns>
        
        public ApiResponse< DeploymentPing > GetJourneyDeploymentCustomerPingWithHttpInfo (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->GetJourneyDeploymentCustomerPing");
            // verify the required parameter 'customerCookieId' is set
            if (customerCookieId == null)
                throw new ApiException(400, "Missing required parameter 'customerCookieId' when calling JourneyApi->GetJourneyDeploymentCustomerPing");

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/customers/{customerCookieId}/ping";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));
            if (customerCookieId != null) localVarPathParams.Add("customerCookieId", this.Configuration.ApiClient.ParameterToString(customerCookieId));

            // Query params
            if (dl != null) localVarQueryParams.Add(new Tuple<string, string>("dl", this.Configuration.ApiClient.ParameterToString(dl)));
            if (dt != null) localVarQueryParams.Add(new Tuple<string, string>("dt", this.Configuration.ApiClient.ParameterToString(dt)));
            if (appNamespace != null) localVarQueryParams.Add(new Tuple<string, string>("appNamespace", this.Configuration.ApiClient.ParameterToString(appNamespace)));
            if (sessionId != null) localVarQueryParams.Add(new Tuple<string, string>("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId)));
            if (sinceLastBeaconMilliseconds != null) localVarQueryParams.Add(new Tuple<string, string>("sinceLastBeaconMilliseconds", this.Configuration.ApiClient.ParameterToString(sinceLastBeaconMilliseconds)));

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyDeploymentCustomerPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyDeploymentCustomerPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeploymentPing>(localVarStatusCode,
                localVarHeaders,
                (DeploymentPing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeploymentPing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a ping. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>Task of DeploymentPing</returns>
        
        public async System.Threading.Tasks.Task<DeploymentPing> GetJourneyDeploymentCustomerPingAsync (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null)
        {
             ApiResponse<DeploymentPing> localVarResponse = await GetJourneyDeploymentCustomerPingAsyncWithHttpInfo(deploymentId, customerCookieId, dl, dt, appNamespace, sessionId, sinceLastBeaconMilliseconds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a ping. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the ping.</param>
        /// <param name="customerCookieId">ID of the customer associated with the ping.</param>
        /// <param name="dl">Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. (optional)</param>
        /// <param name="dt">Document Title.  A human readable name for the page or screen (optional)</param>
        /// <param name="appNamespace">Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional)</param>
        /// <param name="sessionId">UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional)</param>
        /// <param name="sinceLastBeaconMilliseconds">How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional)</param>
        /// <returns>Task of ApiResponse (DeploymentPing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DeploymentPing>> GetJourneyDeploymentCustomerPingAsyncWithHttpInfo (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->GetJourneyDeploymentCustomerPing");
            
            // verify the required parameter 'customerCookieId' is set
            if (customerCookieId == null)
                throw new ApiException(400, "Missing required parameter 'customerCookieId' when calling JourneyApi->GetJourneyDeploymentCustomerPing");
            

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/customers/{customerCookieId}/ping";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));
            if (customerCookieId != null) localVarPathParams.Add("customerCookieId", this.Configuration.ApiClient.ParameterToString(customerCookieId));

            // Query params
            if (dl != null) localVarQueryParams.Add(new Tuple<string, string>("dl", this.Configuration.ApiClient.ParameterToString(dl)));
            if (dt != null) localVarQueryParams.Add(new Tuple<string, string>("dt", this.Configuration.ApiClient.ParameterToString(dt)));
            if (appNamespace != null) localVarQueryParams.Add(new Tuple<string, string>("appNamespace", this.Configuration.ApiClient.ParameterToString(appNamespace)));
            if (sessionId != null) localVarQueryParams.Add(new Tuple<string, string>("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId)));
            if (sinceLastBeaconMilliseconds != null) localVarQueryParams.Add(new Tuple<string, string>("sinceLastBeaconMilliseconds", this.Configuration.ApiClient.ParameterToString(sinceLastBeaconMilliseconds)));

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyDeploymentCustomerPing: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyDeploymentCustomerPing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeploymentPing>(localVarStatusCode,
                localVarHeaders,
                (DeploymentPing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeploymentPing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Outcome</returns>
        
        public Outcome GetJourneyOutcome (string outcomeId)
        {
             ApiResponse<Outcome> localVarResponse = GetJourneyOutcomeWithHttpInfo(outcomeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>ApiResponse of Outcome</returns>
        
        public ApiResponse< Outcome > GetJourneyOutcomeWithHttpInfo (string outcomeId)
        { 
            // verify the required parameter 'outcomeId' is set
            if (outcomeId == null)
                throw new ApiException(400, "Missing required parameter 'outcomeId' when calling JourneyApi->GetJourneyOutcome");

            var localVarPath = "/api/v2/journey/outcomes/{outcomeId}";
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
            if (outcomeId != null) localVarPathParams.Add("outcomeId", this.Configuration.ApiClient.ParameterToString(outcomeId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarHeaders,
                (Outcome) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of Outcome</returns>
        
        public async System.Threading.Tasks.Task<Outcome> GetJourneyOutcomeAsync (string outcomeId)
        {
             ApiResponse<Outcome> localVarResponse = await GetJourneyOutcomeAsyncWithHttpInfo(outcomeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> GetJourneyOutcomeAsyncWithHttpInfo (string outcomeId)
        { 
            // verify the required parameter 'outcomeId' is set
            if (outcomeId == null)
                throw new ApiException(400, "Missing required parameter 'outcomeId' when calling JourneyApi->GetJourneyOutcome");
            

            var localVarPath = "/api/v2/journey/outcomes/{outcomeId}";
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
            if (outcomeId != null) localVarPathParams.Add("outcomeId", this.Configuration.ApiClient.ParameterToString(outcomeId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarHeaders,
                (Outcome) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>OutcomeListing</returns>
        
        public OutcomeListing GetJourneyOutcomes (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<OutcomeListing> localVarResponse = GetJourneyOutcomesWithHttpInfo(pageNumber, pageSize, sortBy, outcomeIds, queryFields, queryValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of OutcomeListing</returns>
        
        public ApiResponse< OutcomeListing > GetJourneyOutcomesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (outcomeIds != null) outcomeIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("outcomeIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeListing>(localVarStatusCode,
                localVarHeaders,
                (OutcomeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of OutcomeListing</returns>
        
        public async System.Threading.Tasks.Task<OutcomeListing> GetJourneyOutcomesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<OutcomeListing> localVarResponse = await GetJourneyOutcomesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, outcomeIds, queryFields, queryValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (OutcomeListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomeListing>> GetJourneyOutcomesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (outcomeIds != null) outcomeIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("outcomeIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeListing>(localVarStatusCode,
                localVarHeaders,
                (OutcomeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get job status. 
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>OutcomeAttributionJobStateResponse</returns>
        
        public OutcomeAttributionJobStateResponse GetJourneyOutcomesAttributionsJob (string jobId)
        {
             ApiResponse<OutcomeAttributionJobStateResponse> localVarResponse = GetJourneyOutcomesAttributionsJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get job status. 
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of OutcomeAttributionJobStateResponse</returns>
        
        public ApiResponse< OutcomeAttributionJobStateResponse > GetJourneyOutcomesAttributionsJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyOutcomesAttributionsJob");

            var localVarPath = "/api/v2/journey/outcomes/attributions/jobs/{jobId}";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeAttributionJobStateResponse>(localVarStatusCode,
                localVarHeaders,
                (OutcomeAttributionJobStateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeAttributionJobStateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get job status. 
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of OutcomeAttributionJobStateResponse</returns>
        
        public async System.Threading.Tasks.Task<OutcomeAttributionJobStateResponse> GetJourneyOutcomesAttributionsJobAsync (string jobId)
        {
             ApiResponse<OutcomeAttributionJobStateResponse> localVarResponse = await GetJourneyOutcomesAttributionsJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get job status. 
        /// 
        /// GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (OutcomeAttributionJobStateResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomeAttributionJobStateResponse>> GetJourneyOutcomesAttributionsJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyOutcomesAttributionsJob");
            

            var localVarPath = "/api/v2/journey/outcomes/attributions/jobs/{jobId}";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeAttributionJobStateResponse>(localVarStatusCode,
                localVarHeaders,
                (OutcomeAttributionJobStateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeAttributionJobStateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get outcome attribution entities from completed job. 
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>OutcomeAttributionResponseListing</returns>
        
        public OutcomeAttributionResponseListing GetJourneyOutcomesAttributionsJobResults (string jobId)
        {
             ApiResponse<OutcomeAttributionResponseListing> localVarResponse = GetJourneyOutcomesAttributionsJobResultsWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get outcome attribution entities from completed job. 
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>ApiResponse of OutcomeAttributionResponseListing</returns>
        
        public ApiResponse< OutcomeAttributionResponseListing > GetJourneyOutcomesAttributionsJobResultsWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyOutcomesAttributionsJobResults");

            var localVarPath = "/api/v2/journey/outcomes/attributions/jobs/{jobId}/results";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeAttributionResponseListing>(localVarStatusCode,
                localVarHeaders,
                (OutcomeAttributionResponseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeAttributionResponseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get outcome attribution entities from completed job. 
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of OutcomeAttributionResponseListing</returns>
        
        public async System.Threading.Tasks.Task<OutcomeAttributionResponseListing> GetJourneyOutcomesAttributionsJobResultsAsync (string jobId)
        {
             ApiResponse<OutcomeAttributionResponseListing> localVarResponse = await GetJourneyOutcomesAttributionsJobResultsAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get outcome attribution entities from completed job. 
        /// 
        /// GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">ID of the job.</param>
        /// <returns>Task of ApiResponse (OutcomeAttributionResponseListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomeAttributionResponseListing>> GetJourneyOutcomesAttributionsJobResultsAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyOutcomesAttributionsJobResults");
            

            var localVarPath = "/api/v2/journey/outcomes/attributions/jobs/{jobId}/results";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesAttributionsJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeAttributionResponseListing>(localVarStatusCode,
                localVarHeaders,
                (OutcomeAttributionResponseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeAttributionResponseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>OutcomePredictor</returns>
        
        public OutcomePredictor GetJourneyOutcomesPredictor (string predictorId)
        {
             ApiResponse<OutcomePredictor> localVarResponse = GetJourneyOutcomesPredictorWithHttpInfo(predictorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>ApiResponse of OutcomePredictor</returns>
        
        public ApiResponse< OutcomePredictor > GetJourneyOutcomesPredictorWithHttpInfo (string predictorId)
        { 
            // verify the required parameter 'predictorId' is set
            if (predictorId == null)
                throw new ApiException(400, "Missing required parameter 'predictorId' when calling JourneyApi->GetJourneyOutcomesPredictor");

            var localVarPath = "/api/v2/journey/outcomes/predictors/{predictorId}";
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
            if (predictorId != null) localVarPathParams.Add("predictorId", this.Configuration.ApiClient.ParameterToString(predictorId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomePredictor>(localVarStatusCode,
                localVarHeaders,
                (OutcomePredictor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomePredictor)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of OutcomePredictor</returns>
        
        public async System.Threading.Tasks.Task<OutcomePredictor> GetJourneyOutcomesPredictorAsync (string predictorId)
        {
             ApiResponse<OutcomePredictor> localVarResponse = await GetJourneyOutcomesPredictorAsyncWithHttpInfo(predictorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predictorId">ID of predictor</param>
        /// <returns>Task of ApiResponse (OutcomePredictor)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomePredictor>> GetJourneyOutcomesPredictorAsyncWithHttpInfo (string predictorId)
        { 
            // verify the required parameter 'predictorId' is set
            if (predictorId == null)
                throw new ApiException(400, "Missing required parameter 'predictorId' when calling JourneyApi->GetJourneyOutcomesPredictor");
            

            var localVarPath = "/api/v2/journey/outcomes/predictors/{predictorId}";
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
            if (predictorId != null) localVarPathParams.Add("predictorId", this.Configuration.ApiClient.ParameterToString(predictorId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomePredictor>(localVarStatusCode,
                localVarHeaders,
                (OutcomePredictor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomePredictor)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all outcome predictors. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OutcomePredictorListing</returns>
        
        public OutcomePredictorListing GetJourneyOutcomesPredictors ()
        {
             ApiResponse<OutcomePredictorListing> localVarResponse = GetJourneyOutcomesPredictorsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all outcome predictors. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OutcomePredictorListing</returns>
        
        public ApiResponse< OutcomePredictorListing > GetJourneyOutcomesPredictorsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/journey/outcomes/predictors";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomePredictorListing>(localVarStatusCode,
                localVarHeaders,
                (OutcomePredictorListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomePredictorListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all outcome predictors. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OutcomePredictorListing</returns>
        
        public async System.Threading.Tasks.Task<OutcomePredictorListing> GetJourneyOutcomesPredictorsAsync ()
        {
             ApiResponse<OutcomePredictorListing> localVarResponse = await GetJourneyOutcomesPredictorsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all outcome predictors. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OutcomePredictorListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomePredictorListing>> GetJourneyOutcomesPredictorsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/journey/outcomes/predictors";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyOutcomesPredictors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomePredictorListing>(localVarStatusCode,
                localVarHeaders,
                (OutcomePredictorListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomePredictorListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>JourneySegment</returns>
        
        public JourneySegment GetJourneySegment (string segmentId)
        {
             ApiResponse<JourneySegment> localVarResponse = GetJourneySegmentWithHttpInfo(segmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        
        public ApiResponse< JourneySegment > GetJourneySegmentWithHttpInfo (string segmentId)
        { 
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling JourneyApi->GetJourneySegment");

            var localVarPath = "/api/v2/journey/segments/{segmentId}";
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
            if (segmentId != null) localVarPathParams.Add("segmentId", this.Configuration.ApiClient.ParameterToString(segmentId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneySegment>(localVarStatusCode,
                localVarHeaders,
                (JourneySegment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneySegment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of JourneySegment</returns>
        
        public async System.Threading.Tasks.Task<JourneySegment> GetJourneySegmentAsync (string segmentId)
        {
             ApiResponse<JourneySegment> localVarResponse = await GetJourneySegmentAsyncWithHttpInfo(segmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneySegment>> GetJourneySegmentAsyncWithHttpInfo (string segmentId)
        { 
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling JourneyApi->GetJourneySegment");
            

            var localVarPath = "/api/v2/journey/segments/{segmentId}";
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
            if (segmentId != null) localVarPathParams.Add("segmentId", this.Configuration.ApiClient.ParameterToString(segmentId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneySegment>(localVarStatusCode,
                localVarHeaders,
                (JourneySegment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneySegment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all segments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>SegmentListing</returns>
        
        public SegmentListing GetJourneySegments (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<SegmentListing> localVarResponse = GetJourneySegmentsWithHttpInfo(sortBy, pageSize, pageNumber, isActive, segmentIds, queryFields, queryValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all segments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of SegmentListing</returns>
        
        public ApiResponse< SegmentListing > GetJourneySegmentsWithHttpInfo (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/segments";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (isActive != null) localVarQueryParams.Add(new Tuple<string, string>("isActive", this.Configuration.ApiClient.ParameterToString(isActive)));
            if (segmentIds != null) segmentIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("segmentIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all segments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of SegmentListing</returns>
        
        public async System.Threading.Tasks.Task<SegmentListing> GetJourneySegmentsAsync (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null)
        {
             ApiResponse<SegmentListing> localVarResponse = await GetJourneySegmentsAsyncWithHttpInfo(sortBy, pageSize, pageNumber, isActive, segmentIds, queryFields, queryValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all segments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="isActive">Determines whether or not to show only active segments. (optional)</param>
        /// <param name="segmentIds">IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional)</param>
        /// <param name="queryFields">Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SegmentListing>> GetJourneySegmentsAsyncWithHttpInfo (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/journey/segments";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (isActive != null) localVarQueryParams.Add(new Tuple<string, string>("isActive", this.Configuration.ApiClient.ParameterToString(isActive)));
            if (segmentIds != null) segmentIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("segmentIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryFields != null) queryFields.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("queryFields", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a single session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Session</returns>
        
        public Session GetJourneySession (string sessionId)
        {
             ApiResponse<Session> localVarResponse = GetJourneySessionWithHttpInfo(sessionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>ApiResponse of Session</returns>
        
        public ApiResponse< Session > GetJourneySessionWithHttpInfo (string sessionId)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySession");

            var localVarPath = "/api/v2/journey/sessions/{sessionId}";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Session>(localVarStatusCode,
                localVarHeaders,
                (Session) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Session)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a single session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of Session</returns>
        
        public async System.Threading.Tasks.Task<Session> GetJourneySessionAsync (string sessionId)
        {
             ApiResponse<Session> localVarResponse = await GetJourneySessionAsyncWithHttpInfo(sessionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a single session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of ApiResponse (Session)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Session>> GetJourneySessionAsyncWithHttpInfo (string sessionId)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySession");
            

            var localVarPath = "/api/v2/journey/sessions/{sessionId}";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Session>(localVarStatusCode,
                localVarHeaders,
                (Session) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Session)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all events for a given session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>EventListing</returns>
        
        public EventListing GetJourneySessionEvents (string sessionId, string pageSize = null, string after = null, string eventType = null)
        {
             ApiResponse<EventListing> localVarResponse = GetJourneySessionEventsWithHttpInfo(sessionId, pageSize, after, eventType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all events for a given session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>ApiResponse of EventListing</returns>
        
        public ApiResponse< EventListing > GetJourneySessionEventsWithHttpInfo (string sessionId, string pageSize = null, string after = null, string eventType = null)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySessionEvents");

            var localVarPath = "/api/v2/journey/sessions/{sessionId}/events";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (eventType != null) localVarQueryParams.Add(new Tuple<string, string>("eventType", this.Configuration.ApiClient.ParameterToString(eventType)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionEvents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionEvents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EventListing>(localVarStatusCode,
                localVarHeaders,
                (EventListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all events for a given session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>Task of EventListing</returns>
        
        public async System.Threading.Tasks.Task<EventListing> GetJourneySessionEventsAsync (string sessionId, string pageSize = null, string after = null, string eventType = null)
        {
             ApiResponse<EventListing> localVarResponse = await GetJourneySessionEventsAsyncWithHttpInfo(sessionId, pageSize, after, eventType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all events for a given session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">System-generated UUID that represents the session the event is a part of.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="eventType">A comma separated list of journey event types to include in the results. (optional)</param>
        /// <returns>Task of ApiResponse (EventListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EventListing>> GetJourneySessionEventsAsyncWithHttpInfo (string sessionId, string pageSize = null, string after = null, string eventType = null)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySessionEvents");
            

            var localVarPath = "/api/v2/journey/sessions/{sessionId}/events";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (eventType != null) localVarQueryParams.Add(new Tuple<string, string>("eventType", this.Configuration.ApiClient.ParameterToString(eventType)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionEvents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionEvents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EventListing>(localVarStatusCode,
                localVarHeaders,
                (EventListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>OutcomeScoresResult</returns>
        
        public OutcomeScoresResult GetJourneySessionOutcomescores (string sessionId)
        {
             ApiResponse<OutcomeScoresResult> localVarResponse = GetJourneySessionOutcomescoresWithHttpInfo(sessionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>ApiResponse of OutcomeScoresResult</returns>
        
        public ApiResponse< OutcomeScoresResult > GetJourneySessionOutcomescoresWithHttpInfo (string sessionId)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySessionOutcomescores");

            var localVarPath = "/api/v2/journey/sessions/{sessionId}/outcomescores";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionOutcomescores: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionOutcomescores: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeScoresResult>(localVarStatusCode,
                localVarHeaders,
                (OutcomeScoresResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeScoresResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of OutcomeScoresResult</returns>
        
        public async System.Threading.Tasks.Task<OutcomeScoresResult> GetJourneySessionOutcomescoresAsync (string sessionId)
        {
             ApiResponse<OutcomeScoresResult> localVarResponse = await GetJourneySessionOutcomescoresAsyncWithHttpInfo(sessionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve latest outcome score associated with a session for all outcomes. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session.</param>
        /// <returns>Task of ApiResponse (OutcomeScoresResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomeScoresResult>> GetJourneySessionOutcomescoresAsyncWithHttpInfo (string sessionId)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySessionOutcomescores");
            

            var localVarPath = "/api/v2/journey/sessions/{sessionId}/outcomescores";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionOutcomescores: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionOutcomescores: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeScoresResult>(localVarStatusCode,
                localVarHeaders,
                (OutcomeScoresResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeScoresResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Journey View by ID 
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>JourneyView</returns>
        
        public JourneyView GetJourneyView (string viewId)
        {
             ApiResponse<JourneyView> localVarResponse = GetJourneyViewWithHttpInfo(viewId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Journey View by ID 
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        public ApiResponse< JourneyView > GetJourneyViewWithHttpInfo (string viewId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyView");

            var localVarPath = "/api/v2/journey/views/{viewId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyView: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyView: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Journey View by ID 
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of JourneyView</returns>
        
        public async System.Threading.Tasks.Task<JourneyView> GetJourneyViewAsync (string viewId)
        {
             ApiResponse<JourneyView> localVarResponse = await GetJourneyViewAsyncWithHttpInfo(viewId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Journey View by ID 
        /// returns the latest version
        /// GetJourneyView is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyView>> GetJourneyViewAsyncWithHttpInfo (string viewId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyView");
            

            var localVarPath = "/api/v2/journey/views/{viewId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyView: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyView: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Journey View by ID and version 
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>JourneyView</returns>
        
        public JourneyView GetJourneyViewVersion (string viewId, string versionId)
        {
             ApiResponse<JourneyView> localVarResponse = GetJourneyViewVersionWithHttpInfo(viewId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Journey View by ID and version 
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        public ApiResponse< JourneyView > GetJourneyViewVersionWithHttpInfo (string viewId, string versionId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling JourneyApi->GetJourneyViewVersion");

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{versionId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Journey View by ID and version 
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>Task of JourneyView</returns>
        
        public async System.Threading.Tasks.Task<JourneyView> GetJourneyViewVersionAsync (string viewId, string versionId)
        {
             ApiResponse<JourneyView> localVarResponse = await GetJourneyViewVersionAsyncWithHttpInfo(viewId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Journey View by ID and version 
        /// 
        /// GetJourneyViewVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="versionId">versionId</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyView>> GetJourneyViewVersionAsyncWithHttpInfo (string viewId, string versionId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling JourneyApi->GetJourneyViewVersion");
            

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{versionId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>JourneyViewJob</returns>
        
        public JourneyViewJob GetJourneyViewVersionJob (string viewId, string journeyVersionId, string jobId)
        {
             ApiResponse<JourneyViewJob> localVarResponse = GetJourneyViewVersionJobWithHttpInfo(viewId, journeyVersionId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>ApiResponse of JourneyViewJob</returns>
        
        public ApiResponse< JourneyViewJob > GetJourneyViewVersionJobWithHttpInfo (string viewId, string journeyVersionId, string jobId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersionJob");
            // verify the required parameter 'journeyVersionId' is set
            if (journeyVersionId == null)
                throw new ApiException(400, "Missing required parameter 'journeyVersionId' when calling JourneyApi->GetJourneyViewVersionJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyViewVersionJob");

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyVersionId != null) localVarPathParams.Add("journeyVersionId", this.Configuration.ApiClient.ParameterToString(journeyVersionId));
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJob>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>Task of JourneyViewJob</returns>
        
        public async System.Threading.Tasks.Task<JourneyViewJob> GetJourneyViewVersionJobAsync (string viewId, string journeyVersionId, string jobId)
        {
             ApiResponse<JourneyViewJob> localVarResponse = await GetJourneyViewVersionJobAsyncWithHttpInfo(viewId, journeyVersionId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <param name="jobId">JobId</param>
        /// <returns>Task of ApiResponse (JourneyViewJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyViewJob>> GetJourneyViewVersionJobAsyncWithHttpInfo (string viewId, string journeyVersionId, string jobId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersionJob");
            
            // verify the required parameter 'journeyVersionId' is set
            if (journeyVersionId == null)
                throw new ApiException(400, "Missing required parameter 'journeyVersionId' when calling JourneyApi->GetJourneyViewVersionJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyViewVersionJob");
            

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyVersionId != null) localVarPathParams.Add("journeyVersionId", this.Configuration.ApiClient.ParameterToString(journeyVersionId));
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJob>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the result of a job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>JourneyViewResult</returns>
        
        public JourneyViewResult GetJourneyViewVersionJobResults (string viewId, string journeyViewVersion, string jobId)
        {
             ApiResponse<JourneyViewResult> localVarResponse = GetJourneyViewVersionJobResultsWithHttpInfo(viewId, journeyViewVersion, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the result of a job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>ApiResponse of JourneyViewResult</returns>
        
        public ApiResponse< JourneyViewResult > GetJourneyViewVersionJobResultsWithHttpInfo (string viewId, string journeyViewVersion, string jobId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersionJobResults");
            // verify the required parameter 'journeyViewVersion' is set
            if (journeyViewVersion == null)
                throw new ApiException(400, "Missing required parameter 'journeyViewVersion' when calling JourneyApi->GetJourneyViewVersionJobResults");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyViewVersionJobResults");

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/jobs/{jobId}/results";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyViewVersion != null) localVarPathParams.Add("journeyViewVersion", this.Configuration.ApiClient.ParameterToString(journeyViewVersion));
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewResult>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the result of a job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>Task of JourneyViewResult</returns>
        
        public async System.Threading.Tasks.Task<JourneyViewResult> GetJourneyViewVersionJobResultsAsync (string viewId, string journeyViewVersion, string jobId)
        {
             ApiResponse<JourneyViewResult> localVarResponse = await GetJourneyViewVersionJobResultsAsyncWithHttpInfo(viewId, journeyViewVersion, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the result of a job for a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">JourneyViewResult id</param>
        /// <param name="journeyViewVersion">Journey View Version</param>
        /// <param name="jobId">Id of the executing job</param>
        /// <returns>Task of ApiResponse (JourneyViewResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyViewResult>> GetJourneyViewVersionJobResultsAsyncWithHttpInfo (string viewId, string journeyViewVersion, string jobId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersionJobResults");
            
            // verify the required parameter 'journeyViewVersion' is set
            if (journeyViewVersion == null)
                throw new ApiException(400, "Missing required parameter 'journeyViewVersion' when calling JourneyApi->GetJourneyViewVersionJobResults");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JourneyApi->GetJourneyViewVersionJobResults");
            

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/jobs/{jobId}/results";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyViewVersion != null) localVarPathParams.Add("journeyViewVersion", this.Configuration.ApiClient.ParameterToString(journeyViewVersion));
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewResult>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the latest job of a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>JourneyViewJob</returns>
        
        public JourneyViewJob GetJourneyViewVersionJobsLatest (string viewId, string journeyVersionId)
        {
             ApiResponse<JourneyViewJob> localVarResponse = GetJourneyViewVersionJobsLatestWithHttpInfo(viewId, journeyVersionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the latest job of a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>ApiResponse of JourneyViewJob</returns>
        
        public ApiResponse< JourneyViewJob > GetJourneyViewVersionJobsLatestWithHttpInfo (string viewId, string journeyVersionId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersionJobsLatest");
            // verify the required parameter 'journeyVersionId' is set
            if (journeyVersionId == null)
                throw new ApiException(400, "Missing required parameter 'journeyVersionId' when calling JourneyApi->GetJourneyViewVersionJobsLatest");

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/latest";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyVersionId != null) localVarPathParams.Add("journeyVersionId", this.Configuration.ApiClient.ParameterToString(journeyVersionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobsLatest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobsLatest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJob>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the latest job of a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of JourneyViewJob</returns>
        
        public async System.Threading.Tasks.Task<JourneyViewJob> GetJourneyViewVersionJobsLatestAsync (string viewId, string journeyVersionId)
        {
             ApiResponse<JourneyViewJob> localVarResponse = await GetJourneyViewVersionJobsLatestAsyncWithHttpInfo(viewId, journeyVersionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the latest job of a journey view version. 
        /// used for long descriptions
        /// GetJourneyViewVersionJobsLatest is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of ApiResponse (JourneyViewJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyViewJob>> GetJourneyViewVersionJobsLatestAsyncWithHttpInfo (string viewId, string journeyVersionId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->GetJourneyViewVersionJobsLatest");
            
            // verify the required parameter 'journeyVersionId' is set
            if (journeyVersionId == null)
                throw new ApiException(400, "Missing required parameter 'journeyVersionId' when calling JourneyApi->GetJourneyViewVersionJobsLatest");
            

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/latest";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyVersionId != null) localVarPathParams.Add("journeyVersionId", this.Configuration.ApiClient.ParameterToString(journeyVersionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobsLatest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewVersionJobsLatest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJob>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Journey Views 
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>JourneyViewListing</returns>
        
        public JourneyViewListing GetJourneyViews ()
        {
             ApiResponse<JourneyViewListing> localVarResponse = GetJourneyViewsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Journey Views 
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of JourneyViewListing</returns>
        
        public ApiResponse< JourneyViewListing > GetJourneyViewsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/journey/views";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewListing>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Journey Views 
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of JourneyViewListing</returns>
        
        public async System.Threading.Tasks.Task<JourneyViewListing> GetJourneyViewsAsync ()
        {
             ApiResponse<JourneyViewListing> localVarResponse = await GetJourneyViewsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Journey Views 
        /// 
        /// GetJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (JourneyViewListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyViewListing>> GetJourneyViewsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/journey/views";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewListing>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an Event Definition 
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>JourneyEventDefinition</returns>
        
        public JourneyEventDefinition GetJourneyViewsEventdefinition (string eventDefinitionId)
        {
             ApiResponse<JourneyEventDefinition> localVarResponse = GetJourneyViewsEventdefinitionWithHttpInfo(eventDefinitionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Event Definition 
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>ApiResponse of JourneyEventDefinition</returns>
        
        public ApiResponse< JourneyEventDefinition > GetJourneyViewsEventdefinitionWithHttpInfo (string eventDefinitionId)
        { 
            // verify the required parameter 'eventDefinitionId' is set
            if (eventDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'eventDefinitionId' when calling JourneyApi->GetJourneyViewsEventdefinition");

            var localVarPath = "/api/v2/journey/views/eventdefinitions/{eventDefinitionId}";
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
            if (eventDefinitionId != null) localVarPathParams.Add("eventDefinitionId", this.Configuration.ApiClient.ParameterToString(eventDefinitionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyEventDefinition>(localVarStatusCode,
                localVarHeaders,
                (JourneyEventDefinition) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyEventDefinition)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an Event Definition 
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>Task of JourneyEventDefinition</returns>
        
        public async System.Threading.Tasks.Task<JourneyEventDefinition> GetJourneyViewsEventdefinitionAsync (string eventDefinitionId)
        {
             ApiResponse<JourneyEventDefinition> localVarResponse = await GetJourneyViewsEventdefinitionAsyncWithHttpInfo(eventDefinitionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an Event Definition 
        /// 
        /// GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventDefinitionId">Event Definition ID</param>
        /// <returns>Task of ApiResponse (JourneyEventDefinition)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyEventDefinition>> GetJourneyViewsEventdefinitionAsyncWithHttpInfo (string eventDefinitionId)
        { 
            // verify the required parameter 'eventDefinitionId' is set
            if (eventDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'eventDefinitionId' when calling JourneyApi->GetJourneyViewsEventdefinition");
            

            var localVarPath = "/api/v2/journey/views/eventdefinitions/{eventDefinitionId}";
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
            if (eventDefinitionId != null) localVarPathParams.Add("eventDefinitionId", this.Configuration.ApiClient.ParameterToString(eventDefinitionId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyEventDefinition>(localVarStatusCode,
                localVarHeaders,
                (JourneyEventDefinition) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyEventDefinition)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Event Definitions 
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>JourneyEventDefinitionListing</returns>
        
        public JourneyEventDefinitionListing GetJourneyViewsEventdefinitions ()
        {
             ApiResponse<JourneyEventDefinitionListing> localVarResponse = GetJourneyViewsEventdefinitionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Event Definitions 
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of JourneyEventDefinitionListing</returns>
        
        public ApiResponse< JourneyEventDefinitionListing > GetJourneyViewsEventdefinitionsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/journey/views/eventdefinitions";
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyEventDefinitionListing>(localVarStatusCode,
                localVarHeaders,
                (JourneyEventDefinitionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyEventDefinitionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Event Definitions 
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of JourneyEventDefinitionListing</returns>
        
        public async System.Threading.Tasks.Task<JourneyEventDefinitionListing> GetJourneyViewsEventdefinitionsAsync ()
        {
             ApiResponse<JourneyEventDefinitionListing> localVarResponse = await GetJourneyViewsEventdefinitionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Event Definitions 
        /// 
        /// GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (JourneyEventDefinitionListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyEventDefinitionListing>> GetJourneyViewsEventdefinitionsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/journey/views/eventdefinitions";
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsEventdefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyEventDefinitionListing>(localVarStatusCode,
                localVarHeaders,
                (JourneyEventDefinitionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyEventDefinitionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the jobs for an organization. 
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>JourneyViewJobListing</returns>
        
        public JourneyViewJobListing GetJourneyViewsJobs (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null)
        {
             ApiResponse<JourneyViewJobListing> localVarResponse = GetJourneyViewsJobsWithHttpInfo(pageNumber, pageSize, interval, statuses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the jobs for an organization. 
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>ApiResponse of JourneyViewJobListing</returns>
        
        public ApiResponse< JourneyViewJobListing > GetJourneyViewsJobsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null)
        { 

            var localVarPath = "/api/v2/journey/views/jobs";
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
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (statuses != null) localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(statuses)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJobListing>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJobListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJobListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the jobs for an organization. 
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>Task of JourneyViewJobListing</returns>
        
        public async System.Threading.Tasks.Task<JourneyViewJobListing> GetJourneyViewsJobsAsync (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null)
        {
             ApiResponse<JourneyViewJobListing> localVarResponse = await GetJourneyViewsJobsAsyncWithHttpInfo(pageNumber, pageSize, interval, statuses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the jobs for an organization. 
        /// 
        /// GetJourneyViewsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">The number of the page to return (optional, default to 1)</param>
        /// <param name="pageSize">Max number of entities to return (optional, default to 25)</param>
        /// <param name="interval">An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional)</param>
        /// <param name="statuses">Job statuses to filter for (optional)</param>
        /// <returns>Task of ApiResponse (JourneyViewJobListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyViewJobListing>> GetJourneyViewsJobsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null)
        { 

            var localVarPath = "/api/v2/journey/views/jobs";
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
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (statuses != null) localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(statuses)));

            // Header params

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyViewsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJobListing>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJobListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJobListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionMap</returns>
        
        public ActionMap PatchJourneyActionmap (string actionMapId, PatchActionMap body = null)
        {
             ApiResponse<ActionMap> localVarResponse = PatchJourneyActionmapWithHttpInfo(actionMapId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionMap</returns>
        
        public ApiResponse< ActionMap > PatchJourneyActionmapWithHttpInfo (string actionMapId, PatchActionMap body = null)
        { 
            // verify the required parameter 'actionMapId' is set
            if (actionMapId == null)
                throw new ApiException(400, "Missing required parameter 'actionMapId' when calling JourneyApi->PatchJourneyActionmap");

            var localVarPath = "/api/v2/journey/actionmaps/{actionMapId}";
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
            if (actionMapId != null) localVarPathParams.Add("actionMapId", this.Configuration.ApiClient.ParameterToString(actionMapId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActionmap: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActionmap: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMap>(localVarStatusCode,
                localVarHeaders,
                (ActionMap) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMap)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionMap</returns>
        
        public async System.Threading.Tasks.Task<ActionMap> PatchJourneyActionmapAsync (string actionMapId, PatchActionMap body = null)
        {
             ApiResponse<ActionMap> localVarResponse = await PatchJourneyActionmapAsyncWithHttpInfo(actionMapId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update single action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionMapId">ID of the action map.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionMap)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionMap>> PatchJourneyActionmapAsyncWithHttpInfo (string actionMapId, PatchActionMap body = null)
        { 
            // verify the required parameter 'actionMapId' is set
            if (actionMapId == null)
                throw new ApiException(400, "Missing required parameter 'actionMapId' when calling JourneyApi->PatchJourneyActionmap");
            

            var localVarPath = "/api/v2/journey/actionmaps/{actionMapId}";
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
            if (actionMapId != null) localVarPathParams.Add("actionMapId", this.Configuration.ApiClient.ParameterToString(actionMapId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActionmap: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActionmap: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMap>(localVarStatusCode,
                localVarHeaders,
                (ActionMap) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMap)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionTarget</returns>
        
        public ActionTarget PatchJourneyActiontarget (string actionTargetId, PatchActionTarget body = null)
        {
             ApiResponse<ActionTarget> localVarResponse = PatchJourneyActiontargetWithHttpInfo(actionTargetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionTarget</returns>
        
        public ApiResponse< ActionTarget > PatchJourneyActiontargetWithHttpInfo (string actionTargetId, PatchActionTarget body = null)
        { 
            // verify the required parameter 'actionTargetId' is set
            if (actionTargetId == null)
                throw new ApiException(400, "Missing required parameter 'actionTargetId' when calling JourneyApi->PatchJourneyActiontarget");

            var localVarPath = "/api/v2/journey/actiontargets/{actionTargetId}";
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
            if (actionTargetId != null) localVarPathParams.Add("actionTargetId", this.Configuration.ApiClient.ParameterToString(actionTargetId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTarget>(localVarStatusCode,
                localVarHeaders,
                (ActionTarget) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTarget)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionTarget</returns>
        
        public async System.Threading.Tasks.Task<ActionTarget> PatchJourneyActiontargetAsync (string actionTargetId, PatchActionTarget body = null)
        {
             ApiResponse<ActionTarget> localVarResponse = await PatchJourneyActiontargetAsyncWithHttpInfo(actionTargetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a single action target. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTargetId">ID of the action target.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionTarget)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTarget>> PatchJourneyActiontargetAsyncWithHttpInfo (string actionTargetId, PatchActionTarget body = null)
        { 
            // verify the required parameter 'actionTargetId' is set
            if (actionTargetId == null)
                throw new ApiException(400, "Missing required parameter 'actionTargetId' when calling JourneyApi->PatchJourneyActiontarget");
            

            var localVarPath = "/api/v2/journey/actiontargets/{actionTargetId}";
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
            if (actionTargetId != null) localVarPathParams.Add("actionTargetId", this.Configuration.ApiClient.ParameterToString(actionTargetId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTarget>(localVarStatusCode,
                localVarHeaders,
                (ActionTarget) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTarget)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionTemplate</returns>
        
        public ActionTemplate PatchJourneyActiontemplate (string actionTemplateId, PatchActionTemplate body = null)
        {
             ApiResponse<ActionTemplate> localVarResponse = PatchJourneyActiontemplateWithHttpInfo(actionTemplateId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionTemplate</returns>
        
        public ApiResponse< ActionTemplate > PatchJourneyActiontemplateWithHttpInfo (string actionTemplateId, PatchActionTemplate body = null)
        { 
            // verify the required parameter 'actionTemplateId' is set
            if (actionTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'actionTemplateId' when calling JourneyApi->PatchJourneyActiontemplate");

            var localVarPath = "/api/v2/journey/actiontemplates/{actionTemplateId}";
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
            if (actionTemplateId != null) localVarPathParams.Add("actionTemplateId", this.Configuration.ApiClient.ParameterToString(actionTemplateId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplate>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionTemplate</returns>
        
        public async System.Threading.Tasks.Task<ActionTemplate> PatchJourneyActiontemplateAsync (string actionTemplateId, PatchActionTemplate body = null)
        {
             ApiResponse<ActionTemplate> localVarResponse = await PatchJourneyActiontemplateAsyncWithHttpInfo(actionTemplateId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionTemplateId">ID of the action template.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplate)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTemplate>> PatchJourneyActiontemplateAsyncWithHttpInfo (string actionTemplateId, PatchActionTemplate body = null)
        { 
            // verify the required parameter 'actionTemplateId' is set
            if (actionTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'actionTemplateId' when calling JourneyApi->PatchJourneyActiontemplate");
            

            var localVarPath = "/api/v2/journey/actiontemplates/{actionTemplateId}";
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
            if (actionTemplateId != null) localVarPathParams.Add("actionTemplateId", this.Configuration.ApiClient.ParameterToString(actionTemplateId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyActiontemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplate>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Outcome</returns>
        
        public Outcome PatchJourneyOutcome (string outcomeId, PatchOutcome body = null)
        {
             ApiResponse<Outcome> localVarResponse = PatchJourneyOutcomeWithHttpInfo(outcomeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Outcome</returns>
        
        public ApiResponse< Outcome > PatchJourneyOutcomeWithHttpInfo (string outcomeId, PatchOutcome body = null)
        { 
            // verify the required parameter 'outcomeId' is set
            if (outcomeId == null)
                throw new ApiException(400, "Missing required parameter 'outcomeId' when calling JourneyApi->PatchJourneyOutcome");

            var localVarPath = "/api/v2/journey/outcomes/{outcomeId}";
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
            if (outcomeId != null) localVarPathParams.Add("outcomeId", this.Configuration.ApiClient.ParameterToString(outcomeId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyOutcome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyOutcome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarHeaders,
                (Outcome) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Outcome</returns>
        
        public async System.Threading.Tasks.Task<Outcome> PatchJourneyOutcomeAsync (string outcomeId, PatchOutcome body = null)
        {
             ApiResponse<Outcome> localVarResponse = await PatchJourneyOutcomeAsyncWithHttpInfo(outcomeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outcomeId">ID of the outcome.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> PatchJourneyOutcomeAsyncWithHttpInfo (string outcomeId, PatchOutcome body = null)
        { 
            // verify the required parameter 'outcomeId' is set
            if (outcomeId == null)
                throw new ApiException(400, "Missing required parameter 'outcomeId' when calling JourneyApi->PatchJourneyOutcome");
            

            var localVarPath = "/api/v2/journey/outcomes/{outcomeId}";
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
            if (outcomeId != null) localVarPathParams.Add("outcomeId", this.Configuration.ApiClient.ParameterToString(outcomeId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyOutcome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneyOutcome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarHeaders,
                (Outcome) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>JourneySegment</returns>
        
        public JourneySegment PatchJourneySegment (string segmentId, PatchSegment body = null)
        {
             ApiResponse<JourneySegment> localVarResponse = PatchJourneySegmentWithHttpInfo(segmentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        
        public ApiResponse< JourneySegment > PatchJourneySegmentWithHttpInfo (string segmentId, PatchSegment body = null)
        { 
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling JourneyApi->PatchJourneySegment");

            var localVarPath = "/api/v2/journey/segments/{segmentId}";
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
            if (segmentId != null) localVarPathParams.Add("segmentId", this.Configuration.ApiClient.ParameterToString(segmentId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneySegment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneySegment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneySegment>(localVarStatusCode,
                localVarHeaders,
                (JourneySegment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneySegment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of JourneySegment</returns>
        
        public async System.Threading.Tasks.Task<JourneySegment> PatchJourneySegmentAsync (string segmentId, PatchSegment body = null)
        {
             ApiResponse<JourneySegment> localVarResponse = await PatchJourneySegmentAsyncWithHttpInfo(segmentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="segmentId">ID of the segment.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneySegment>> PatchJourneySegmentAsyncWithHttpInfo (string segmentId, PatchSegment body = null)
        { 
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling JourneyApi->PatchJourneySegment");
            

            var localVarPath = "/api/v2/journey/segments/{segmentId}";
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
            if (segmentId != null) localVarPathParams.Add("segmentId", this.Configuration.ApiClient.ParameterToString(segmentId));

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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneySegment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchJourneySegment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneySegment>(localVarStatusCode,
                localVarHeaders,
                (JourneySegment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneySegment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for journey aggregates asynchronously 
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        public AsyncQueryResponse PostAnalyticsJourneysAggregatesJobs (JourneyAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = PostAnalyticsJourneysAggregatesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for journey aggregates asynchronously 
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        public ApiResponse< AsyncQueryResponse > PostAnalyticsJourneysAggregatesJobsWithHttpInfo (JourneyAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostAnalyticsJourneysAggregatesJobs");

            var localVarPath = "/api/v2/analytics/journeys/aggregates/jobs";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for journey aggregates asynchronously 
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryResponse> PostAnalyticsJourneysAggregatesJobsAsync (JourneyAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = await PostAnalyticsJourneysAggregatesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for journey aggregates asynchronously 
        /// 
        /// PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsJourneysAggregatesJobsAsyncWithHttpInfo (JourneyAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostAnalyticsJourneysAggregatesJobs");
            

            var localVarPath = "/api/v2/analytics/journeys/aggregates/jobs";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for journey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>JourneyAggregateQueryResponse</returns>
        
        public JourneyAggregateQueryResponse PostAnalyticsJourneysAggregatesQuery (JourneyAggregationQuery body)
        {
             ApiResponse<JourneyAggregateQueryResponse> localVarResponse = PostAnalyticsJourneysAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for journey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of JourneyAggregateQueryResponse</returns>
        
        public ApiResponse< JourneyAggregateQueryResponse > PostAnalyticsJourneysAggregatesQueryWithHttpInfo (JourneyAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostAnalyticsJourneysAggregatesQuery");

            var localVarPath = "/api/v2/analytics/journeys/aggregates/query";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (JourneyAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for journey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of JourneyAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<JourneyAggregateQueryResponse> PostAnalyticsJourneysAggregatesQueryAsync (JourneyAggregationQuery body)
        {
             ApiResponse<JourneyAggregateQueryResponse> localVarResponse = await PostAnalyticsJourneysAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for journey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (JourneyAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyAggregateQueryResponse>> PostAnalyticsJourneysAggregatesQueryAsyncWithHttpInfo (JourneyAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostAnalyticsJourneysAggregatesQuery");
            

            var localVarPath = "/api/v2/analytics/journeys/aggregates/query";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsJourneysAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (JourneyAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionMap</returns>
        
        public ActionMap PostJourneyActionmaps (ActionMap body = null)
        {
             ApiResponse<ActionMap> localVarResponse = PostJourneyActionmapsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionMap</returns>
        
        public ApiResponse< ActionMap > PostJourneyActionmapsWithHttpInfo (ActionMap body = null)
        { 

            var localVarPath = "/api/v2/journey/actionmaps";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmaps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmaps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMap>(localVarStatusCode,
                localVarHeaders,
                (ActionMap) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMap)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionMap</returns>
        
        public async System.Threading.Tasks.Task<ActionMap> PostJourneyActionmapsAsync (ActionMap body = null)
        {
             ApiResponse<ActionMap> localVarResponse = await PostJourneyActionmapsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an action map. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionMap)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionMap>> PostJourneyActionmapsAsyncWithHttpInfo (ActionMap body = null)
        { 

            var localVarPath = "/api/v2/journey/actionmaps";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmaps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmaps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionMap>(localVarStatusCode,
                localVarHeaders,
                (ActionMap) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionMap)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for estimates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>EstimateJobAsyncResponse</returns>
        
        public EstimateJobAsyncResponse PostJourneyActionmapsEstimatesJobs (ActionMapEstimateRequest body)
        {
             ApiResponse<EstimateJobAsyncResponse> localVarResponse = PostJourneyActionmapsEstimatesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for estimates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>ApiResponse of EstimateJobAsyncResponse</returns>
        
        public ApiResponse< EstimateJobAsyncResponse > PostJourneyActionmapsEstimatesJobsWithHttpInfo (ActionMapEstimateRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyActionmapsEstimatesJobs");

            var localVarPath = "/api/v2/journey/actionmaps/estimates/jobs";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmapsEstimatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmapsEstimatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstimateJobAsyncResponse>(localVarStatusCode,
                localVarHeaders,
                (EstimateJobAsyncResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstimateJobAsyncResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for estimates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>Task of EstimateJobAsyncResponse</returns>
        
        public async System.Threading.Tasks.Task<EstimateJobAsyncResponse> PostJourneyActionmapsEstimatesJobsAsync (ActionMapEstimateRequest body)
        {
             ApiResponse<EstimateJobAsyncResponse> localVarResponse = await PostJourneyActionmapsEstimatesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for estimates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">audience estimator request</param>
        /// <returns>Task of ApiResponse (EstimateJobAsyncResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EstimateJobAsyncResponse>> PostJourneyActionmapsEstimatesJobsAsyncWithHttpInfo (ActionMapEstimateRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyActionmapsEstimatesJobs");
            

            var localVarPath = "/api/v2/journey/actionmaps/estimates/jobs";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmapsEstimatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActionmapsEstimatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstimateJobAsyncResponse>(localVarStatusCode,
                localVarHeaders,
                (EstimateJobAsyncResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstimateJobAsyncResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ActionTemplate</returns>
        
        public ActionTemplate PostJourneyActiontemplates (ActionTemplate body = null)
        {
             ApiResponse<ActionTemplate> localVarResponse = PostJourneyActiontemplatesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ActionTemplate</returns>
        
        public ApiResponse< ActionTemplate > PostJourneyActiontemplatesWithHttpInfo (ActionTemplate body = null)
        { 

            var localVarPath = "/api/v2/journey/actiontemplates";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActiontemplates: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActiontemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplate>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ActionTemplate</returns>
        
        public async System.Threading.Tasks.Task<ActionTemplate> PostJourneyActiontemplatesAsync (ActionTemplate body = null)
        {
             ApiResponse<ActionTemplate> localVarResponse = await PostJourneyActiontemplatesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a single action template. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplate)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionTemplate>> PostJourneyActiontemplatesAsyncWithHttpInfo (ActionTemplate body = null)
        { 

            var localVarPath = "/api/v2/journey/actiontemplates";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActiontemplates: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyActiontemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionTemplate>(localVarStatusCode,
                localVarHeaders,
                (ActionTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        
        public void PostJourneyDeploymentActionevent (string deploymentId, ActionEventRequest body)
        {
             PostJourneyDeploymentActioneventWithHttpInfo(deploymentId, body);
        }

        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostJourneyDeploymentActioneventWithHttpInfo (string deploymentId, ActionEventRequest body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->PostJourneyDeploymentActionevent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyDeploymentActionevent");

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/actionevent";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentActionevent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentActionevent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostJourneyDeploymentActioneventAsync (string deploymentId, ActionEventRequest body)
        {
             await PostJourneyDeploymentActioneventAsyncWithHttpInfo(deploymentId, body);

        }

        /// <summary>
        /// Sends an action event, which is used for changing the state of actions that have been offered to the user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the beacon.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostJourneyDeploymentActioneventAsyncWithHttpInfo (string deploymentId, ActionEventRequest body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->PostJourneyDeploymentActionevent");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyDeploymentActionevent");
            

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/actionevent";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentActionevent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentActionevent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>AppEventResponse</returns>
        
        public AppEventResponse PostJourneyDeploymentAppevents (string deploymentId, AppEventRequest body = null)
        {
             ApiResponse<AppEventResponse> localVarResponse = PostJourneyDeploymentAppeventsWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AppEventResponse</returns>
        
        public ApiResponse< AppEventResponse > PostJourneyDeploymentAppeventsWithHttpInfo (string deploymentId, AppEventRequest body = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->PostJourneyDeploymentAppevents");

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/appevents";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentAppevents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentAppevents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AppEventResponse>(localVarStatusCode,
                localVarHeaders,
                (AppEventResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppEventResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AppEventResponse</returns>
        
        public async System.Threading.Tasks.Task<AppEventResponse> PostJourneyDeploymentAppeventsAsync (string deploymentId, AppEventRequest body = null)
        {
             ApiResponse<AppEventResponse> localVarResponse = await PostJourneyDeploymentAppeventsAsyncWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a journey app event, used for tracking customer activity on an application. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the app event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AppEventResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AppEventResponse>> PostJourneyDeploymentAppeventsAsyncWithHttpInfo (string deploymentId, AppEventRequest body = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->PostJourneyDeploymentAppevents");
            

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/appevents";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentAppevents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentAppevents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AppEventResponse>(localVarStatusCode,
                localVarHeaders,
                (AppEventResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppEventResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WebEventResponse</returns>
        
        public WebEventResponse PostJourneyDeploymentWebevents (string deploymentId, WebEventRequest body = null)
        {
             ApiResponse<WebEventResponse> localVarResponse = PostJourneyDeploymentWebeventsWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of WebEventResponse</returns>
        
        public ApiResponse< WebEventResponse > PostJourneyDeploymentWebeventsWithHttpInfo (string deploymentId, WebEventRequest body = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->PostJourneyDeploymentWebevents");

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/webevents";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentWebevents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentWebevents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebEventResponse>(localVarStatusCode,
                localVarHeaders,
                (WebEventResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebEventResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of WebEventResponse</returns>
        
        public async System.Threading.Tasks.Task<WebEventResponse> PostJourneyDeploymentWebeventsAsync (string deploymentId, WebEventRequest body = null)
        {
             ApiResponse<WebEventResponse> localVarResponse = await PostJourneyDeploymentWebeventsAsyncWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a journey web event, used for tracking customer activity on a website. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The ID of the deployment sending the web event.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (WebEventResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebEventResponse>> PostJourneyDeploymentWebeventsAsyncWithHttpInfo (string deploymentId, WebEventRequest body = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling JourneyApi->PostJourneyDeploymentWebevents");
            

            var localVarPath = "/api/v2/journey/deployments/{deploymentId}/webevents";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentWebevents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyDeploymentWebevents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebEventResponse>(localVarStatusCode,
                localVarHeaders,
                (WebEventResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebEventResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for flow paths. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>FlowPaths</returns>
        
        public FlowPaths PostJourneyFlowsPathsQuery (FlowPathsQuery body = null)
        {
             ApiResponse<FlowPaths> localVarResponse = PostJourneyFlowsPathsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for flow paths. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FlowPaths</returns>
        
        public ApiResponse< FlowPaths > PostJourneyFlowsPathsQueryWithHttpInfo (FlowPathsQuery body = null)
        { 

            var localVarPath = "/api/v2/journey/flows/paths/query";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyFlowsPathsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyFlowsPathsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowPaths>(localVarStatusCode,
                localVarHeaders,
                (FlowPaths) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowPaths)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for flow paths. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FlowPaths</returns>
        
        public async System.Threading.Tasks.Task<FlowPaths> PostJourneyFlowsPathsQueryAsync (FlowPathsQuery body = null)
        {
             ApiResponse<FlowPaths> localVarResponse = await PostJourneyFlowsPathsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for flow paths. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FlowPaths)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FlowPaths>> PostJourneyFlowsPathsQueryAsyncWithHttpInfo (FlowPathsQuery body = null)
        { 

            var localVarPath = "/api/v2/journey/flows/paths/query";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyFlowsPathsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyFlowsPathsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowPaths>(localVarStatusCode,
                localVarHeaders,
                (FlowPaths) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowPaths)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Outcome</returns>
        
        public Outcome PostJourneyOutcomes (OutcomeRequest body = null)
        {
             ApiResponse<Outcome> localVarResponse = PostJourneyOutcomesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Outcome</returns>
        
        public ApiResponse< Outcome > PostJourneyOutcomesWithHttpInfo (OutcomeRequest body = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarHeaders,
                (Outcome) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Outcome</returns>
        
        public async System.Threading.Tasks.Task<Outcome> PostJourneyOutcomesAsync (OutcomeRequest body = null)
        {
             ApiResponse<Outcome> localVarResponse = await PostJourneyOutcomesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an outcome. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> PostJourneyOutcomesAsyncWithHttpInfo (OutcomeRequest body = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Outcome>(localVarStatusCode,
                localVarHeaders,
                (Outcome) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Outcome)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create Outcome Attributions 
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>OutcomeAttributionAsyncResponse</returns>
        
        public OutcomeAttributionAsyncResponse PostJourneyOutcomesAttributionsJobs (OutcomeAttributionListing body = null)
        {
             ApiResponse<OutcomeAttributionAsyncResponse> localVarResponse = PostJourneyOutcomesAttributionsJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Outcome Attributions 
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>ApiResponse of OutcomeAttributionAsyncResponse</returns>
        
        public ApiResponse< OutcomeAttributionAsyncResponse > PostJourneyOutcomesAttributionsJobsWithHttpInfo (OutcomeAttributionListing body = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes/attributions/jobs";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesAttributionsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesAttributionsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeAttributionAsyncResponse>(localVarStatusCode,
                localVarHeaders,
                (OutcomeAttributionAsyncResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeAttributionAsyncResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create Outcome Attributions 
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>Task of OutcomeAttributionAsyncResponse</returns>
        
        public async System.Threading.Tasks.Task<OutcomeAttributionAsyncResponse> PostJourneyOutcomesAttributionsJobsAsync (OutcomeAttributionListing body = null)
        {
             ApiResponse<OutcomeAttributionAsyncResponse> localVarResponse = await PostJourneyOutcomesAttributionsJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Outcome Attributions 
        /// 
        /// PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">outcome attribution request (optional)</param>
        /// <returns>Task of ApiResponse (OutcomeAttributionAsyncResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomeAttributionAsyncResponse>> PostJourneyOutcomesAttributionsJobsAsyncWithHttpInfo (OutcomeAttributionListing body = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes/attributions/jobs";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesAttributionsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesAttributionsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomeAttributionAsyncResponse>(localVarStatusCode,
                localVarHeaders,
                (OutcomeAttributionAsyncResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomeAttributionAsyncResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>OutcomePredictor</returns>
        
        public OutcomePredictor PostJourneyOutcomesPredictors (OutcomePredictorRequest body = null)
        {
             ApiResponse<OutcomePredictor> localVarResponse = PostJourneyOutcomesPredictorsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OutcomePredictor</returns>
        
        public ApiResponse< OutcomePredictor > PostJourneyOutcomesPredictorsWithHttpInfo (OutcomePredictorRequest body = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes/predictors";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesPredictors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesPredictors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomePredictor>(localVarStatusCode,
                localVarHeaders,
                (OutcomePredictor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomePredictor)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OutcomePredictor</returns>
        
        public async System.Threading.Tasks.Task<OutcomePredictor> PostJourneyOutcomesPredictorsAsync (OutcomePredictorRequest body = null)
        {
             ApiResponse<OutcomePredictor> localVarResponse = await PostJourneyOutcomesPredictorsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an outcome predictor. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OutcomePredictor)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OutcomePredictor>> PostJourneyOutcomesPredictorsAsyncWithHttpInfo (OutcomePredictorRequest body = null)
        { 

            var localVarPath = "/api/v2/journey/outcomes/predictors";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesPredictors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyOutcomesPredictors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutcomePredictor>(localVarStatusCode,
                localVarHeaders,
                (OutcomePredictor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutcomePredictor)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>JourneySegment</returns>
        
        public JourneySegment PostJourneySegments (JourneySegmentRequest body = null)
        {
             ApiResponse<JourneySegment> localVarResponse = PostJourneySegmentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        
        public ApiResponse< JourneySegment > PostJourneySegmentsWithHttpInfo (JourneySegmentRequest body = null)
        { 

            var localVarPath = "/api/v2/journey/segments";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneySegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneySegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneySegment>(localVarStatusCode,
                localVarHeaders,
                (JourneySegment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneySegment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of JourneySegment</returns>
        
        public async System.Threading.Tasks.Task<JourneySegment> PostJourneySegmentsAsync (JourneySegmentRequest body = null)
        {
             ApiResponse<JourneySegment> localVarResponse = await PostJourneySegmentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a segment. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneySegment>> PostJourneySegmentsAsyncWithHttpInfo (JourneySegmentRequest body = null)
        { 

            var localVarPath = "/api/v2/journey/segments";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneySegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneySegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneySegment>(localVarStatusCode,
                localVarHeaders,
                (JourneySegment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneySegment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Submit a job request for a journey view version. 
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>JourneyViewJob</returns>
        
        public JourneyViewJob PostJourneyViewVersionJobs (string viewId, string journeyVersionId)
        {
             ApiResponse<JourneyViewJob> localVarResponse = PostJourneyViewVersionJobsWithHttpInfo(viewId, journeyVersionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a job request for a journey view version. 
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>ApiResponse of JourneyViewJob</returns>
        
        public ApiResponse< JourneyViewJob > PostJourneyViewVersionJobsWithHttpInfo (string viewId, string journeyVersionId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->PostJourneyViewVersionJobs");
            // verify the required parameter 'journeyVersionId' is set
            if (journeyVersionId == null)
                throw new ApiException(400, "Missing required parameter 'journeyVersionId' when calling JourneyApi->PostJourneyViewVersionJobs");

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyVersionId != null) localVarPathParams.Add("journeyVersionId", this.Configuration.ApiClient.ParameterToString(journeyVersionId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersionJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJob>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Submit a job request for a journey view version. 
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of JourneyViewJob</returns>
        
        public async System.Threading.Tasks.Task<JourneyViewJob> PostJourneyViewVersionJobsAsync (string viewId, string journeyVersionId)
        {
             ApiResponse<JourneyViewJob> localVarResponse = await PostJourneyViewVersionJobsAsyncWithHttpInfo(viewId, journeyVersionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit a job request for a journey view version. 
        /// used for long descriptions
        /// PostJourneyViewVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Journey View Id</param>
        /// <param name="journeyVersionId">Journey View Version</param>
        /// <returns>Task of ApiResponse (JourneyViewJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyViewJob>> PostJourneyViewVersionJobsAsyncWithHttpInfo (string viewId, string journeyVersionId)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->PostJourneyViewVersionJobs");
            
            // verify the required parameter 'journeyVersionId' is set
            if (journeyVersionId == null)
                throw new ApiException(400, "Missing required parameter 'journeyVersionId' when calling JourneyApi->PostJourneyViewVersionJobs");
            

            var localVarPath = "/api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));
            if (journeyVersionId != null) localVarPathParams.Add("journeyVersionId", this.Configuration.ApiClient.ParameterToString(journeyVersionId));

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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersionJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyViewJob>(localVarStatusCode,
                localVarHeaders,
                (JourneyViewJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyViewJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a Journey View by ID 
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>JourneyView</returns>
        
        public JourneyView PostJourneyViewVersions (string viewId, JourneyView body)
        {
             ApiResponse<JourneyView> localVarResponse = PostJourneyViewVersionsWithHttpInfo(viewId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Journey View by ID 
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        public ApiResponse< JourneyView > PostJourneyViewVersionsWithHttpInfo (string viewId, JourneyView body)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->PostJourneyViewVersions");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyViewVersions");

            var localVarPath = "/api/v2/journey/views/{viewId}/versions";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a Journey View by ID 
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of JourneyView</returns>
        
        public async System.Threading.Tasks.Task<JourneyView> PostJourneyViewVersionsAsync (string viewId, JourneyView body)
        {
             ApiResponse<JourneyView> localVarResponse = await PostJourneyViewVersionsAsyncWithHttpInfo(viewId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Journey View by ID 
        /// creates a new version
        /// PostJourneyViewVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyView>> PostJourneyViewVersionsAsyncWithHttpInfo (string viewId, JourneyView body)
        { 
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling JourneyApi->PostJourneyViewVersions");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyViewVersions");
            

            var localVarPath = "/api/v2/journey/views/{viewId}/versions";
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
            if (viewId != null) localVarPathParams.Add("viewId", this.Configuration.ApiClient.ParameterToString(viewId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new Journey View 
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>JourneyView</returns>
        
        public JourneyView PostJourneyViews (JourneyView body)
        {
             ApiResponse<JourneyView> localVarResponse = PostJourneyViewsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Journey View 
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>ApiResponse of JourneyView</returns>
        
        public ApiResponse< JourneyView > PostJourneyViewsWithHttpInfo (JourneyView body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyViews");

            var localVarPath = "/api/v2/journey/views";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new Journey View 
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of JourneyView</returns>
        
        public async System.Threading.Tasks.Task<JourneyView> PostJourneyViewsAsync (JourneyView body)
        {
             ApiResponse<JourneyView> localVarResponse = await PostJourneyViewsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Journey View 
        /// 
        /// PostJourneyViews is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JourneyView</param>
        /// <returns>Task of ApiResponse (JourneyView)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<JourneyView>> PostJourneyViewsAsyncWithHttpInfo (JourneyView body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JourneyApi->PostJourneyViews");
            

            var localVarPath = "/api/v2/journey/views";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JourneyView>(localVarStatusCode,
                localVarHeaders,
                (JourneyView) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JourneyView)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Validate whether an encoding exist for a label/value combination. 
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EntityListing</returns>
        
        public EntityListing PostJourneyViewsEncodingsValidate (List<Label> body = null)
        {
             ApiResponse<EntityListing> localVarResponse = PostJourneyViewsEncodingsValidateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate whether an encoding exist for a label/value combination. 
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EntityListing</returns>
        
        public ApiResponse< EntityListing > PostJourneyViewsEncodingsValidateWithHttpInfo (List<Label> body = null)
        { 

            var localVarPath = "/api/v2/journey/views/encodings/validate";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewsEncodingsValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewsEncodingsValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Validate whether an encoding exist for a label/value combination. 
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EntityListing</returns>
        
        public async System.Threading.Tasks.Task<EntityListing> PostJourneyViewsEncodingsValidateAsync (List<Label> body = null)
        {
             ApiResponse<EntityListing> localVarResponse = await PostJourneyViewsEncodingsValidateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate whether an encoding exist for a label/value combination. 
        /// True indicates a valid encoding
        /// PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EntityListing>> PostJourneyViewsEncodingsValidateAsyncWithHttpInfo (List<Label> body = null)
        { 

            var localVarPath = "/api/v2/journey/views/encodings/validate";
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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewsEncodingsValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyViewsEncodingsValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
