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
    public interface IWorkforceManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>List&lt;UserScheduleAdherence&gt;</returns>
        List<UserScheduleAdherence> GetWorkforcemanagementAdherence (List<string> userId);

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>ApiResponse of List&lt;UserScheduleAdherence&gt;</returns>
        ApiResponse<List<UserScheduleAdherence>> GetWorkforcemanagementAdherenceWithHttpInfo (List<string> userId);
        
        /// <summary>
        /// Get activity codes corresponding to a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ActivityCodeContainer</returns>
        ActivityCodeContainer GetWorkforcemanagementManagementunitActivitycodes (string muId);

        /// <summary>
        /// Get activity codes corresponding to a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ActivityCodeContainer</returns>
        ApiResponse<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId);
        
        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>WfmIntradayQueueListing</returns>
        WfmIntradayQueueListing GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date);

        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>ApiResponse of WfmIntradayQueueListing</returns>
        ApiResponse<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo (string muId, string date);
        
        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        TimeOffRequest GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        ApiResponse<TimeOffRequest> GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList GetWorkforcemanagementManagementunitUserTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> GetWorkforcemanagementManagementunitUserTimeoffrequestsWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null);
        
        /// <summary>
        /// Get agents in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>WfmUserEntityListing</returns>
        WfmUserEntityListing GetWorkforcemanagementManagementunitUsers (string muId);

        /// <summary>
        /// Get agents in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of WfmUserEntityListing</returns>
        ApiResponse<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersWithHttpInfo (string muId);
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>ManagementUnitListing</returns>
        ManagementUnitListing GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        ApiResponse<ManagementUnitListing> GetWorkforcemanagementManagementunitsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        TimeOffRequest GetWorkforcemanagementTimeoffrequest (string timeOffRequestId);

        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        ApiResponse<TimeOffRequest> GetWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList GetWorkforcemanagementTimeoffrequests (bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> GetWorkforcemanagementTimeoffrequestsWithHttpInfo (bool? recentlyReviewed = null);
        
        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, TimeOffRequestPatch body = null);

        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null);
        
        /// <summary>
        /// Get the management units to which the agents belong
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>List&lt;AgentManagementUnitReference&gt;</returns>
        List<AgentManagementUnitReference> PostWorkforcemanagementAgentsManagementunits (List<string> body = null);

        /// <summary>
        /// Get the management units to which the agents belong
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of List&lt;AgentManagementUnitReference&gt;</returns>
        ApiResponse<List<AgentManagementUnitReference>> PostWorkforcemanagementAgentsManagementunitsWithHttpInfo (List<string> body = null);
        
        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WfmHistoricalAdherenceResponse</returns>
        WfmHistoricalAdherenceResponse PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null);

        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WfmHistoricalAdherenceResponse</returns>
        ApiResponse<WfmHistoricalAdherenceResponse> PostWorkforcemanagementManagementunitHistoricaladherencequeryWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null);
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>IntradayResponse</returns>
        IntradayResponse PostWorkforcemanagementManagementunitIntraday (string muId, IntradayQueryDataCommand body = null);

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of IntradayResponse</returns>
        ApiResponse<IntradayResponse> PostWorkforcemanagementManagementunitIntradayWithHttpInfo (string muId, IntradayQueryDataCommand body = null);
        
        /// <summary>
        /// Get user schedules within the given time range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        UserScheduleContainer PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null);

        /// <summary>
        /// Get user schedules within the given time range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        ApiResponse<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo (string muId, UserListScheduleRequestBody body = null);
        
        /// <summary>
        /// Get a schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        UserScheduleContainer PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null);

        /// <summary>
        /// Get a schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        ApiResponse<UserScheduleContainer> PostWorkforcemanagementSchedulesWithHttpInfo (CurrentUserScheduleRequestBody body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of List&lt;UserScheduleAdherence&gt;</returns>
        System.Threading.Tasks.Task<List<UserScheduleAdherence>> GetWorkforcemanagementAdherenceAsync (List<string> userId);

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of ApiResponse (List&lt;UserScheduleAdherence&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserScheduleAdherence>>> GetWorkforcemanagementAdherenceAsyncWithHttpInfo (List<string> userId);
        
        /// <summary>
        /// Get activity codes corresponding to a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ActivityCodeContainer</returns>
        System.Threading.Tasks.Task<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesAsync (string muId);

        /// <summary>
        /// Get activity codes corresponding to a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ActivityCodeContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCodeContainer>> GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>Task of WfmIntradayQueueListing</returns>
        System.Threading.Tasks.Task<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesAsync (string muId, string date);

        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>Task of ApiResponse (WfmIntradayQueueListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmIntradayQueueListing>> GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo (string muId, string date);
        
        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        System.Threading.Tasks.Task<TimeOffRequest> GetWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsync (string muId, string userId, bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsyncWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null);
        
        /// <summary>
        /// Get agents in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of WfmUserEntityListing</returns>
        System.Threading.Tasks.Task<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersAsync (string muId);

        /// <summary>
        /// Get agents in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (WfmUserEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmUserEntityListing>> GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        System.Threading.Tasks.Task<TimeOffRequest> GetWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId);

        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementTimeoffrequestsAsync (bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo (bool? recentlyReviewed = null);
        
        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId, TimeOffRequestPatch body = null);

        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null);
        
        /// <summary>
        /// Get the management units to which the agents belong
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of List&lt;AgentManagementUnitReference&gt;</returns>
        System.Threading.Tasks.Task<List<AgentManagementUnitReference>> PostWorkforcemanagementAgentsManagementunitsAsync (List<string> body = null);

        /// <summary>
        /// Get the management units to which the agents belong
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;AgentManagementUnitReference&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AgentManagementUnitReference>>> PostWorkforcemanagementAgentsManagementunitsAsyncWithHttpInfo (List<string> body = null);
        
        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WfmHistoricalAdherenceResponse</returns>
        System.Threading.Tasks.Task<WfmHistoricalAdherenceResponse> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsync (string muId, WfmHistoricalAdherenceQuery body = null);

        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WfmHistoricalAdherenceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmHistoricalAdherenceResponse>> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsyncWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null);
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of IntradayResponse</returns>
        System.Threading.Tasks.Task<IntradayResponse> PostWorkforcemanagementManagementunitIntradayAsync (string muId, IntradayQueryDataCommand body = null);

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (IntradayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntradayResponse>> PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo (string muId, IntradayQueryDataCommand body = null);
        
        /// <summary>
        /// Get user schedules within the given time range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchAsync (string muId, UserListScheduleRequestBody body = null);

        /// <summary>
        /// Get user schedules within the given time range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo (string muId, UserListScheduleRequestBody body = null);
        
        /// <summary>
        /// Get a schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementSchedulesAsync (CurrentUserScheduleRequestBody body = null);

        /// <summary>
        /// Get a schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementSchedulesAsyncWithHttpInfo (CurrentUserScheduleRequestBody body = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkforceManagementApi : IWorkforceManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkforceManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkforceManagementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
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
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>List&lt;UserScheduleAdherence&gt;</returns>
        public List<UserScheduleAdherence> GetWorkforcemanagementAdherence (List<string> userId)
        {
             ApiResponse<List<UserScheduleAdherence>> localVarResponse = GetWorkforcemanagementAdherenceWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>ApiResponse of List&lt;UserScheduleAdherence&gt;</returns>
        public ApiResponse< List<UserScheduleAdherence> > GetWorkforcemanagementAdherenceWithHttpInfo (List<string> userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementAdherence");

            var localVarPath = "/api/v2/workforcemanagement/adherence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserScheduleAdherence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserScheduleAdherence>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserScheduleAdherence>)));
            
        }

        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of List&lt;UserScheduleAdherence&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserScheduleAdherence>> GetWorkforcemanagementAdherenceAsync (List<string> userId)
        {
             ApiResponse<List<UserScheduleAdherence>> localVarResponse = await GetWorkforcemanagementAdherenceAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of ApiResponse (List&lt;UserScheduleAdherence&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserScheduleAdherence>>> GetWorkforcemanagementAdherenceAsyncWithHttpInfo (List<string> userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementAdherence");
            

            var localVarPath = "/api/v2/workforcemanagement/adherence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserScheduleAdherence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserScheduleAdherence>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserScheduleAdherence>)));
            
        }

        
        
        /// <summary>
        /// Get activity codes corresponding to a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ActivityCodeContainer</returns>
        public ActivityCodeContainer GetWorkforcemanagementManagementunitActivitycodes (string muId)
        {
             ApiResponse<ActivityCodeContainer> localVarResponse = GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo(muId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get activity codes corresponding to a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ActivityCodeContainer</returns>
        public ApiResponse< ActivityCodeContainer > GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycodes");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCodeContainer>(localVarStatusCode,
                localVarHeaders,
                (ActivityCodeContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCodeContainer)));
            
        }

        
        /// <summary>
        /// Get activity codes corresponding to a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ActivityCodeContainer</returns>
        public async System.Threading.Tasks.Task<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesAsync (string muId)
        {
             ApiResponse<ActivityCodeContainer> localVarResponse = await GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo(muId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get activity codes corresponding to a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ActivityCodeContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCodeContainer>> GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycodes");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCodeContainer>(localVarStatusCode,
                localVarHeaders,
                (ActivityCodeContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCodeContainer)));
            
        }

        
        
        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>WfmIntradayQueueListing</returns>
        public WfmIntradayQueueListing GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date)
        {
             ApiResponse<WfmIntradayQueueListing> localVarResponse = GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo(muId, date);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>ApiResponse of WfmIntradayQueueListing</returns>
        public ApiResponse< WfmIntradayQueueListing > GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo (string muId, string date)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (date != null) localVarQueryParams.Add(new Tuple<string, string>("date", Configuration.ApiClient.ParameterToString(date)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmIntradayQueueListing>(localVarStatusCode,
                localVarHeaders,
                (WfmIntradayQueueListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmIntradayQueueListing)));
            
        }

        
        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>Task of WfmIntradayQueueListing</returns>
        public async System.Threading.Tasks.Task<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesAsync (string muId, string date)
        {
             ApiResponse<WfmIntradayQueueListing> localVarResponse = await GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo(muId, date);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>Task of ApiResponse (WfmIntradayQueueListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmIntradayQueueListing>> GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo (string muId, string date)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");
            
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (date != null) localVarQueryParams.Add(new Tuple<string, string>("date", Configuration.ApiClient.ParameterToString(date)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmIntradayQueueListing>(localVarStatusCode,
                localVarHeaders,
                (WfmIntradayQueueListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmIntradayQueueListing)));
            
        }

        
        
        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        public TimeOffRequest GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        public ApiResponse< TimeOffRequest > GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        
        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        public async System.Threading.Tasks.Task<TimeOffRequest> GetWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = await GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        
        
        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList GetWorkforcemanagementManagementunitUserTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = GetWorkforcemanagementManagementunitUserTimeoffrequestsWithHttpInfo(muId, userId, recentlyReviewed);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > GetWorkforcemanagementManagementunitUserTimeoffrequestsWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        
        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsync (string muId, string userId, bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await GetWorkforcemanagementManagementunitUserTimeoffrequestsAsyncWithHttpInfo(muId, userId, recentlyReviewed);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsyncWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        
        
        /// <summary>
        /// Get agents in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>WfmUserEntityListing</returns>
        public WfmUserEntityListing GetWorkforcemanagementManagementunitUsers (string muId)
        {
             ApiResponse<WfmUserEntityListing> localVarResponse = GetWorkforcemanagementManagementunitUsersWithHttpInfo(muId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get agents in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of WfmUserEntityListing</returns>
        public ApiResponse< WfmUserEntityListing > GetWorkforcemanagementManagementunitUsersWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUsers");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmUserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WfmUserEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmUserEntityListing)));
            
        }

        
        /// <summary>
        /// Get agents in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of WfmUserEntityListing</returns>
        public async System.Threading.Tasks.Task<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersAsync (string muId)
        {
             ApiResponse<WfmUserEntityListing> localVarResponse = await GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo(muId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get agents in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (WfmUserEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmUserEntityListing>> GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUsers");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmUserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WfmUserEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmUserEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>ManagementUnitListing</returns>
        public ManagementUnitListing GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = GetWorkforcemanagementManagementunitsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        public ApiResponse< ManagementUnitListing > GetWorkforcemanagementManagementunitsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)));
            
        }

        
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        public async System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = await GetWorkforcemanagementManagementunitsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)));
            
        }

        
        
        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        public TimeOffRequest GetWorkforcemanagementTimeoffrequest (string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = GetWorkforcemanagementTimeoffrequestWithHttpInfo(timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        public ApiResponse< TimeOffRequest > GetWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        
        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        public async System.Threading.Tasks.Task<TimeOffRequest> GetWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = await GetWorkforcemanagementTimeoffrequestAsyncWithHttpInfo(timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        
        
        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList GetWorkforcemanagementTimeoffrequests (bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = GetWorkforcemanagementTimeoffrequestsWithHttpInfo(recentlyReviewed);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > GetWorkforcemanagementTimeoffrequestsWithHttpInfo (bool? recentlyReviewed = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        
        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementTimeoffrequestsAsync (bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await GetWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo(recentlyReviewed);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo (bool? recentlyReviewed = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        
        
        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, TimeOffRequestPatch body = null)
        {
             PatchWorkforcemanagementTimeoffrequestWithHttpInfo(timeOffRequestId, body);
        }

        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId, TimeOffRequestPatch body = null)
        {
             await PatchWorkforcemanagementTimeoffrequestAsyncWithHttpInfo(timeOffRequestId, body);

        }

        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Get the management units to which the agents belong 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>List&lt;AgentManagementUnitReference&gt;</returns>
        public List<AgentManagementUnitReference> PostWorkforcemanagementAgentsManagementunits (List<string> body = null)
        {
             ApiResponse<List<AgentManagementUnitReference>> localVarResponse = PostWorkforcemanagementAgentsManagementunitsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the management units to which the agents belong 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of List&lt;AgentManagementUnitReference&gt;</returns>
        public ApiResponse< List<AgentManagementUnitReference> > PostWorkforcemanagementAgentsManagementunitsWithHttpInfo (List<string> body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/agents/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAgentsManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAgentsManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AgentManagementUnitReference>>(localVarStatusCode,
                localVarHeaders,
                (List<AgentManagementUnitReference>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AgentManagementUnitReference>)));
            
        }

        
        /// <summary>
        /// Get the management units to which the agents belong 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of List&lt;AgentManagementUnitReference&gt;</returns>
        public async System.Threading.Tasks.Task<List<AgentManagementUnitReference>> PostWorkforcemanagementAgentsManagementunitsAsync (List<string> body = null)
        {
             ApiResponse<List<AgentManagementUnitReference>> localVarResponse = await PostWorkforcemanagementAgentsManagementunitsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the management units to which the agents belong 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;AgentManagementUnitReference&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AgentManagementUnitReference>>> PostWorkforcemanagementAgentsManagementunitsAsyncWithHttpInfo (List<string> body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/agents/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAgentsManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAgentsManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AgentManagementUnitReference>>(localVarStatusCode,
                localVarHeaders,
                (List<AgentManagementUnitReference>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AgentManagementUnitReference>)));
            
        }

        
        
        /// <summary>
        /// Request a historical adherence report 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WfmHistoricalAdherenceResponse</returns>
        public WfmHistoricalAdherenceResponse PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null)
        {
             ApiResponse<WfmHistoricalAdherenceResponse> localVarResponse = PostWorkforcemanagementManagementunitHistoricaladherencequeryWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request a historical adherence report 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WfmHistoricalAdherenceResponse</returns>
        public ApiResponse< WfmHistoricalAdherenceResponse > PostWorkforcemanagementManagementunitHistoricaladherencequeryWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitHistoricaladherencequery");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)));
            
        }

        
        /// <summary>
        /// Request a historical adherence report 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WfmHistoricalAdherenceResponse</returns>
        public async System.Threading.Tasks.Task<WfmHistoricalAdherenceResponse> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsync (string muId, WfmHistoricalAdherenceQuery body = null)
        {
             ApiResponse<WfmHistoricalAdherenceResponse> localVarResponse = await PostWorkforcemanagementManagementunitHistoricaladherencequeryAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request a historical adherence report 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WfmHistoricalAdherenceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmHistoricalAdherenceResponse>> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsyncWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitHistoricaladherencequery");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)));
            
        }

        
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>IntradayResponse</returns>
        public IntradayResponse PostWorkforcemanagementManagementunitIntraday (string muId, IntradayQueryDataCommand body = null)
        {
             ApiResponse<IntradayResponse> localVarResponse = PostWorkforcemanagementManagementunitIntradayWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of IntradayResponse</returns>
        public ApiResponse< IntradayResponse > PostWorkforcemanagementManagementunitIntradayWithHttpInfo (string muId, IntradayQueryDataCommand body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitIntraday");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntradayResponse>(localVarStatusCode,
                localVarHeaders,
                (IntradayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntradayResponse)));
            
        }

        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of IntradayResponse</returns>
        public async System.Threading.Tasks.Task<IntradayResponse> PostWorkforcemanagementManagementunitIntradayAsync (string muId, IntradayQueryDataCommand body = null)
        {
             ApiResponse<IntradayResponse> localVarResponse = await PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (IntradayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntradayResponse>> PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo (string muId, IntradayQueryDataCommand body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitIntraday");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntradayResponse>(localVarStatusCode,
                localVarHeaders,
                (IntradayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntradayResponse)));
            
        }

        
        
        /// <summary>
        /// Get user schedules within the given time range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        public UserScheduleContainer PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user schedules within the given time range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        public ApiResponse< UserScheduleContainer > PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo (string muId, UserListScheduleRequestBody body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitSchedulesSearch");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/schedules/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)));
            
        }

        
        /// <summary>
        /// Get user schedules within the given time range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        public async System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchAsync (string muId, UserListScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = await PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user schedules within the given time range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo (string muId, UserListScheduleRequestBody body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitSchedulesSearch");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/schedules/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)));
            
        }

        
        
        /// <summary>
        /// Get a schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        public UserScheduleContainer PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = PostWorkforcemanagementSchedulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        public ApiResponse< UserScheduleContainer > PostWorkforcemanagementSchedulesWithHttpInfo (CurrentUserScheduleRequestBody body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)));
            
        }

        
        /// <summary>
        /// Get a schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        public async System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementSchedulesAsync (CurrentUserScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = await PostWorkforcemanagementSchedulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementSchedulesAsyncWithHttpInfo (CurrentUserScheduleRequestBody body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)));
            
        }

        
        
    }
    
}
