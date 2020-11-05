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
        /// Retrieve segment assignments by customer ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>SegmentAssignmentListing</returns>
        SegmentAssignmentListing GetJourneyCustomerCustomerIdSegments (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);

        /// <summary>
        /// Retrieve segment assignments by customer ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>ApiResponse of SegmentAssignmentListing</returns>
        ApiResponse<SegmentAssignmentListing> GetJourneyCustomerCustomerIdSegmentsWithHttpInfo (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);
        
        /// <summary>
        /// Retrieve segment assignments by external contact ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>SegmentAssignmentListing</returns>
        SegmentAssignmentListing GetJourneyExternalcontactSegments (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);

        /// <summary>
        /// Retrieve segment assignments by external contact ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>ApiResponse of SegmentAssignmentListing</returns>
        ApiResponse<SegmentAssignmentListing> GetJourneyExternalcontactSegmentsWithHttpInfo (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);
        
        /// <summary>
        /// Retrieve segment assignments by session ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>SegmentAssignmentListing</returns>
        SegmentAssignmentListing GetJourneySessionSegments (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);

        /// <summary>
        /// Retrieve segment assignments by session ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>ApiResponse of SegmentAssignmentListing</returns>
        ApiResponse<SegmentAssignmentListing> GetJourneySessionSegmentsWithHttpInfo (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);
        
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
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PostJourneyExternalcontactSegments (string externalContactId, List<SegmentAssignmentsUpdate> body = null);

        /// <summary>
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostJourneyExternalcontactSegmentsWithHttpInfo (string externalContactId, List<SegmentAssignmentsUpdate> body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        /// Retrieve segment assignments by customer ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of SegmentAssignmentListing</returns>
        System.Threading.Tasks.Task<SegmentAssignmentListing> GetJourneyCustomerCustomerIdSegmentsAsync (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);

        /// <summary>
        /// Retrieve segment assignments by customer ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentAssignmentListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SegmentAssignmentListing>> GetJourneyCustomerCustomerIdSegmentsAsyncWithHttpInfo (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);
        
        /// <summary>
        /// Retrieve segment assignments by external contact ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of SegmentAssignmentListing</returns>
        System.Threading.Tasks.Task<SegmentAssignmentListing> GetJourneyExternalcontactSegmentsAsync (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);

        /// <summary>
        /// Retrieve segment assignments by external contact ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentAssignmentListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SegmentAssignmentListing>> GetJourneyExternalcontactSegmentsAsyncWithHttpInfo (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);
        
        /// <summary>
        /// Retrieve segment assignments by session ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of SegmentAssignmentListing</returns>
        System.Threading.Tasks.Task<SegmentAssignmentListing> GetJourneySessionSegmentsAsync (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);

        /// <summary>
        /// Retrieve segment assignments by session ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentAssignmentListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SegmentAssignmentListing>> GetJourneySessionSegmentsAsyncWithHttpInfo (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null);
        
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
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostJourneyExternalcontactSegmentsAsync (string externalContactId, List<SegmentAssignmentsUpdate> body = null);

        /// <summary>
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostJourneyExternalcontactSegmentsAsyncWithHttpInfo (string externalContactId, List<SegmentAssignmentsUpdate> body = null);
        
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
        /// Retrieve segment assignments by customer ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>SegmentAssignmentListing</returns>
        public SegmentAssignmentListing GetJourneyCustomerCustomerIdSegments (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        {
             ApiResponse<SegmentAssignmentListing> localVarResponse = GetJourneyCustomerCustomerIdSegmentsWithHttpInfo(customerIdType, customerId, pageSize, after, segmentScope, assignmentState);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve segment assignments by customer ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>ApiResponse of SegmentAssignmentListing</returns>
        public ApiResponse< SegmentAssignmentListing > GetJourneyCustomerCustomerIdSegmentsWithHttpInfo (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        { 
            // verify the required parameter 'customerIdType' is set
            if (customerIdType == null)
                throw new ApiException(400, "Missing required parameter 'customerIdType' when calling JourneyApi->GetJourneyCustomerCustomerIdSegments");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling JourneyApi->GetJourneyCustomerCustomerIdSegments");

            var localVarPath = "/api/v2/journey/customers/{customerIdType}/{customerId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (customerIdType != null) localVarPathParams.Add("customerIdType", this.Configuration.ApiClient.ParameterToString(customerIdType));
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (segmentScope != null) localVarQueryParams.Add(new Tuple<string, string>("segmentScope", this.Configuration.ApiClient.ParameterToString(segmentScope)));
            if (assignmentState != null) localVarQueryParams.Add(new Tuple<string, string>("assignmentState", this.Configuration.ApiClient.ParameterToString(assignmentState)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyCustomerCustomerIdSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyCustomerCustomerIdSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve segment assignments by customer ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of SegmentAssignmentListing</returns>
        public async System.Threading.Tasks.Task<SegmentAssignmentListing> GetJourneyCustomerCustomerIdSegmentsAsync (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        {
             ApiResponse<SegmentAssignmentListing> localVarResponse = await GetJourneyCustomerCustomerIdSegmentsAsyncWithHttpInfo(customerIdType, customerId, pageSize, after, segmentScope, assignmentState);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve segment assignments by customer ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIdType">Type of ID used to identify customer (e.g. email, cookie, and phone).</param>
        /// <param name="customerId">Primary identifier of the customer to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentAssignmentListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SegmentAssignmentListing>> GetJourneyCustomerCustomerIdSegmentsAsyncWithHttpInfo (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        { 
            // verify the required parameter 'customerIdType' is set
            if (customerIdType == null)
                throw new ApiException(400, "Missing required parameter 'customerIdType' when calling JourneyApi->GetJourneyCustomerCustomerIdSegments");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling JourneyApi->GetJourneyCustomerCustomerIdSegments");
            

            var localVarPath = "/api/v2/journey/customers/{customerIdType}/{customerId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (customerIdType != null) localVarPathParams.Add("customerIdType", this.Configuration.ApiClient.ParameterToString(customerIdType));
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (segmentScope != null) localVarQueryParams.Add(new Tuple<string, string>("segmentScope", this.Configuration.ApiClient.ParameterToString(segmentScope)));
            if (assignmentState != null) localVarQueryParams.Add(new Tuple<string, string>("assignmentState", this.Configuration.ApiClient.ParameterToString(assignmentState)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyCustomerCustomerIdSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyCustomerCustomerIdSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve segment assignments by external contact ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>SegmentAssignmentListing</returns>
        public SegmentAssignmentListing GetJourneyExternalcontactSegments (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        {
             ApiResponse<SegmentAssignmentListing> localVarResponse = GetJourneyExternalcontactSegmentsWithHttpInfo(externalContactId, pageSize, after, segmentScope, assignmentState);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve segment assignments by external contact ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>ApiResponse of SegmentAssignmentListing</returns>
        public ApiResponse< SegmentAssignmentListing > GetJourneyExternalcontactSegmentsWithHttpInfo (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling JourneyApi->GetJourneyExternalcontactSegments");

            var localVarPath = "/api/v2/journey/externalcontacts/{externalContactId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (segmentScope != null) localVarQueryParams.Add(new Tuple<string, string>("segmentScope", this.Configuration.ApiClient.ParameterToString(segmentScope)));
            if (assignmentState != null) localVarQueryParams.Add(new Tuple<string, string>("assignmentState", this.Configuration.ApiClient.ParameterToString(assignmentState)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyExternalcontactSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyExternalcontactSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve segment assignments by external contact ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of SegmentAssignmentListing</returns>
        public async System.Threading.Tasks.Task<SegmentAssignmentListing> GetJourneyExternalcontactSegmentsAsync (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        {
             ApiResponse<SegmentAssignmentListing> localVarResponse = await GetJourneyExternalcontactSegmentsAsyncWithHttpInfo(externalContactId, pageSize, after, segmentScope, assignmentState);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve segment assignments by external contact ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentAssignmentListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SegmentAssignmentListing>> GetJourneyExternalcontactSegmentsAsyncWithHttpInfo (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling JourneyApi->GetJourneyExternalcontactSegments");
            

            var localVarPath = "/api/v2/journey/externalcontacts/{externalContactId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (segmentScope != null) localVarQueryParams.Add(new Tuple<string, string>("segmentScope", this.Configuration.ApiClient.ParameterToString(segmentScope)));
            if (assignmentState != null) localVarQueryParams.Add(new Tuple<string, string>("assignmentState", this.Configuration.ApiClient.ParameterToString(assignmentState)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyExternalcontactSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneyExternalcontactSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve segment assignments by session ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>SegmentAssignmentListing</returns>
        public SegmentAssignmentListing GetJourneySessionSegments (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        {
             ApiResponse<SegmentAssignmentListing> localVarResponse = GetJourneySessionSegmentsWithHttpInfo(sessionId, pageSize, after, segmentScope, assignmentState);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve segment assignments by session ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>ApiResponse of SegmentAssignmentListing</returns>
        public ApiResponse< SegmentAssignmentListing > GetJourneySessionSegmentsWithHttpInfo (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySessionSegments");

            var localVarPath = "/api/v2/journey/sessions/{sessionId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (segmentScope != null) localVarQueryParams.Add(new Tuple<string, string>("segmentScope", this.Configuration.ApiClient.ParameterToString(segmentScope)));
            if (assignmentState != null) localVarQueryParams.Add(new Tuple<string, string>("assignmentState", this.Configuration.ApiClient.ParameterToString(assignmentState)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve segment assignments by session ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of SegmentAssignmentListing</returns>
        public async System.Threading.Tasks.Task<SegmentAssignmentListing> GetJourneySessionSegmentsAsync (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        {
             ApiResponse<SegmentAssignmentListing> localVarResponse = await GetJourneySessionSegmentsAsyncWithHttpInfo(sessionId, pageSize, after, segmentScope, assignmentState);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve segment assignments by session ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">ID of the session to query for segment assignments.</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="segmentScope">Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional)</param>
        /// <param name="assignmentState">Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional)</param>
        /// <returns>Task of ApiResponse (SegmentAssignmentListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SegmentAssignmentListing>> GetJourneySessionSegmentsAsyncWithHttpInfo (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling JourneyApi->GetJourneySessionSegments");
            

            var localVarPath = "/api/v2/journey/sessions/{sessionId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (segmentScope != null) localVarQueryParams.Add(new Tuple<string, string>("segmentScope", this.Configuration.ApiClient.ParameterToString(segmentScope)));
            if (assignmentState != null) localVarQueryParams.Add(new Tuple<string, string>("assignmentState", this.Configuration.ApiClient.ParameterToString(assignmentState)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJourneySessionSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SegmentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (SegmentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SegmentAssignmentListing)),
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
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PostJourneyExternalcontactSegments (string externalContactId, List<SegmentAssignmentsUpdate> body = null)
        {
             PostJourneyExternalcontactSegmentsWithHttpInfo(externalContactId, body);
        }

        /// <summary>
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostJourneyExternalcontactSegmentsWithHttpInfo (string externalContactId, List<SegmentAssignmentsUpdate> body = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling JourneyApi->PostJourneyExternalcontactSegments");

            var localVarPath = "/api/v2/journey/externalcontacts/{externalContactId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyExternalcontactSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyExternalcontactSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostJourneyExternalcontactSegmentsAsync (string externalContactId, List<SegmentAssignmentsUpdate> body = null)
        {
             await PostJourneyExternalcontactSegmentsAsyncWithHttpInfo(externalContactId, body);

        }

        /// <summary>
        /// Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">ID of the external contact to query for segment assignments.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostJourneyExternalcontactSegmentsAsyncWithHttpInfo (string externalContactId, List<SegmentAssignmentsUpdate> body = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling JourneyApi->PostJourneyExternalcontactSegments");
            

            var localVarPath = "/api/v2/journey/externalcontacts/{externalContactId}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyExternalcontactSegments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostJourneyExternalcontactSegments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
