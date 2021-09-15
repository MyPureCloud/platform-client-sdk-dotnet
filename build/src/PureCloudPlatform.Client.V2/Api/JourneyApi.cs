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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of ActionMapListing</returns>
        ApiResponse<ActionMapListing> GetJourneyActionmapsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of ActionTemplateListing</returns>
        ApiResponse<ActionTemplateListing> GetJourneyActiontemplatesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>ApiResponse of OutcomeListing</returns>
        ApiResponse<OutcomeListing> GetJourneyOutcomesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Outcome</returns>
        Outcome PostJourneyOutcomes (Outcome body = null);

        /// <summary>
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Outcome</returns>
        ApiResponse<Outcome> PostJourneyOutcomesWithHttpInfo (Outcome body = null);
        
        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>JourneySegment</returns>
        JourneySegment PostJourneySegments (JourneySegment body = null);

        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        ApiResponse<JourneySegment> PostJourneySegmentsWithHttpInfo (JourneySegment body = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
        /// <param name="filterValue">Value to filter by. Requires &#39;filterValue&#39; to also be set. (optional)</param>
        /// <param name="actionMapIds">IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional)</param>
        /// <param name="queryFields">Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (ActionMapListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActionMapListing>> GetJourneyActionmapsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
        /// <param name="mediaType">Media type (optional)</param>
        /// <param name="state">Action template state. (optional)</param>
        /// <param name="queryFields">ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (ActionTemplateListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActionTemplateListing>> GetJourneyActiontemplatesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="outcomeIds">IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional)</param>
        /// <param name="queryFields">Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. (optional)</param>
        /// <param name="queryValue">Value to query on. Requires &#39;queryFields&#39; to also be set. (optional)</param>
        /// <returns>Task of ApiResponse (OutcomeListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutcomeListing>> GetJourneyOutcomesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null);
        
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Outcome</returns>
        System.Threading.Tasks.Task<Outcome> PostJourneyOutcomesAsync (Outcome body = null);

        /// <summary>
        /// Create an outcome.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        System.Threading.Tasks.Task<ApiResponse<Outcome>> PostJourneyOutcomesAsyncWithHttpInfo (Outcome body = null);
        
        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of JourneySegment</returns>
        System.Threading.Tasks.Task<JourneySegment> PostJourneySegmentsAsync (JourneySegment body = null);

        /// <summary>
        /// Create a segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        System.Threading.Tasks.Task<ApiResponse<JourneySegment>> PostJourneySegmentsAsyncWithHttpInfo (JourneySegment body = null);
        
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
        /// Delete single action map. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Delete a segment. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Retrieve a single action map. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
        /// <param name="filterField">Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Retrieve a single action target. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy=name,-createdDate). (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Retrieve a single outcome. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Retrieve a single segment. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy=displayName,-createdDate). (optional)</param>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Retrieve latest outcome score associated with a session for all outcomes. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Update single action map. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Query for journey aggregates 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Create a single action template. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Create an outcome. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Outcome</returns>
        public Outcome PostJourneyOutcomes (Outcome body = null)
        {
             ApiResponse<Outcome> localVarResponse = PostJourneyOutcomesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an outcome. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Outcome</returns>
        public ApiResponse< Outcome > PostJourneyOutcomesWithHttpInfo (Outcome body = null)
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Outcome</returns>
        public async System.Threading.Tasks.Task<Outcome> PostJourneyOutcomesAsync (Outcome body = null)
        {
             ApiResponse<Outcome> localVarResponse = await PostJourneyOutcomesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an outcome. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Outcome)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Outcome>> PostJourneyOutcomesAsyncWithHttpInfo (Outcome body = null)
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Create a segment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>JourneySegment</returns>
        public JourneySegment PostJourneySegments (JourneySegment body = null)
        {
             ApiResponse<JourneySegment> localVarResponse = PostJourneySegmentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a segment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of JourneySegment</returns>
        public ApiResponse< JourneySegment > PostJourneySegmentsWithHttpInfo (JourneySegment body = null)
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of JourneySegment</returns>
        public async System.Threading.Tasks.Task<JourneySegment> PostJourneySegmentsAsync (JourneySegment body = null)
        {
             ApiResponse<JourneySegment> localVarResponse = await PostJourneySegmentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a segment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (JourneySegment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JourneySegment>> PostJourneySegmentsAsyncWithHttpInfo (JourneySegment body = null)
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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

        
        
    }
    
}
