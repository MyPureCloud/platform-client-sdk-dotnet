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
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ActivityCodeContainer</returns>
        ActivityCodeContainer GetWorkforcemanagementManagementunitActivitycodes (string muId);

        /// <summary>
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ActivityCodeContainer</returns>
        ApiResponse<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId);
        
        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>ApiResponse of WfmIntradayQueueListing</returns>
        ApiResponse<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo (string muId, string date);
        
        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for a given user
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
        /// Get a list of time off requests for a given user
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>WfmUserEntityListing</returns>
        WfmUserEntityListing GetWorkforcemanagementManagementunitUsers (string muId);

        /// <summary>
        /// Get agents in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of WfmUserEntityListing</returns>
        ApiResponse<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersWithHttpInfo (string muId);
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ManagementUnitListing</returns>
        ManagementUnitListing GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        ApiResponse<ManagementUnitListing> GetWorkforcemanagementManagementunitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);
        
        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse PatchWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);

        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> PatchWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);
        
        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ActivityCode</returns>
        ActivityCode PostWorkforcemanagementManagementunitActivitycodes (string muId, CreateActivityCodeRequest body = null);

        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        ApiResponse<ActivityCode> PostWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId, CreateActivityCodeRequest body = null);
        
        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of IntradayResponse</returns>
        ApiResponse<IntradayResponse> PostWorkforcemanagementManagementunitIntradayWithHttpInfo (string muId, IntradayQueryDataCommand body = null);
        
        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        UserScheduleContainer PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null);

        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        ApiResponse<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo (string muId, UserListScheduleRequestBody body = null);
        
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
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ActivityCodeContainer</returns>
        System.Threading.Tasks.Task<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesAsync (string muId);

        /// <summary>
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ActivityCodeContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCodeContainer>> GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="date">ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23</param>
        /// <returns>Task of ApiResponse (WfmIntradayQueueListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmIntradayQueueListing>> GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo (string muId, string date);
        
        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> GetWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for a given user
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
        /// Get a list of time off requests for a given user
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of WfmUserEntityListing</returns>
        System.Threading.Tasks.Task<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersAsync (string muId);

        /// <summary>
        /// Get agents in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (WfmUserEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmUserEntityListing>> GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);
        
        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);

        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);
        
        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ActivityCode</returns>
        System.Threading.Tasks.Task<ActivityCode> PostWorkforcemanagementManagementunitActivitycodesAsync (string muId, CreateActivityCodeRequest body = null);

        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCode>> PostWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId, CreateActivityCodeRequest body = null);
        
        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (IntradayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntradayResponse>> PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo (string muId, IntradayQueryDataCommand body = null);
        
        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchAsync (string muId, UserListScheduleRequestBody body = null);

        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo (string muId, UserListScheduleRequestBody body = null);
        
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
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
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
        public WorkforceManagementApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserScheduleAdherence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserScheduleAdherence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserScheduleAdherence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserScheduleAdherence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserScheduleAdherence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserScheduleAdherence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ActivityCodeContainer</returns>
        public ActivityCodeContainer GetWorkforcemanagementManagementunitActivitycodes (string muId)
        {
             ApiResponse<ActivityCodeContainer> localVarResponse = GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo(muId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCodeContainer>(localVarStatusCode,
                localVarHeaders,
                (ActivityCodeContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCodeContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ActivityCodeContainer</returns>
        public async System.Threading.Tasks.Task<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesAsync (string muId)
        {
             ApiResponse<ActivityCodeContainer> localVarResponse = await GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo(muId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCodeContainer>(localVarStatusCode,
                localVarHeaders,
                (ActivityCodeContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCodeContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (date != null) localVarQueryParams.Add(new Tuple<string, string>("date", this.Configuration.ApiClient.ParameterToString(date)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmIntradayQueueListing>(localVarStatusCode,
                localVarHeaders,
                (WfmIntradayQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmIntradayQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (date != null) localVarQueryParams.Add(new Tuple<string, string>("date", this.Configuration.ApiClient.ParameterToString(date)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmIntradayQueueListing>(localVarStatusCode,
                localVarHeaders,
                (WfmIntradayQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmIntradayQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId)
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> GetWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId)
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of time off requests for a given user 
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
        /// Get a list of time off requests for a given user 
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", this.Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of time off requests for a given user 
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
        /// Get a list of time off requests for a given user 
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", this.Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get agents in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmUserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WfmUserEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmUserEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get agents in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmUserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WfmUserEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmUserEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ManagementUnitListing</returns>
        public ManagementUnitListing GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = GetWorkforcemanagementManagementunitsWithHttpInfo(pageSize, pageNumber, expand, feature, divisionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        public ApiResponse< ManagementUnitListing > GetWorkforcemanagementManagementunitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (feature != null) localVarQueryParams.Add(new Tuple<string, string>("feature", this.Configuration.ApiClient.ParameterToString(feature)));
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        public async System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = await GetWorkforcemanagementManagementunitsAsyncWithHttpInfo(pageSize, pageNumber, expand, feature, divisionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (feature != null) localVarQueryParams.Add(new Tuple<string, string>("feature", this.Configuration.ApiClient.ParameterToString(feature)));
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse PatchWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = PatchWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo(muId, userId, timeOffRequestId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > PatchWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");

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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await PatchWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo(muId, userId, timeOffRequestId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            

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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ActivityCode</returns>
        public ActivityCode PostWorkforcemanagementManagementunitActivitycodes (string muId, CreateActivityCodeRequest body = null)
        {
             ApiResponse<ActivityCode> localVarResponse = PostWorkforcemanagementManagementunitActivitycodesWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        public ApiResponse< ActivityCode > PostWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId, CreateActivityCodeRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitActivitycodes");

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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ActivityCode</returns>
        public async System.Threading.Tasks.Task<ActivityCode> PostWorkforcemanagementManagementunitActivitycodesAsync (string muId, CreateActivityCodeRequest body = null)
        {
             ApiResponse<ActivityCode> localVarResponse = await PostWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCode>> PostWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId, CreateActivityCodeRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitActivitycodes");
            

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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Request a historical adherence report 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Request a historical adherence report 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntradayResponse>(localVarStatusCode,
                localVarHeaders,
                (IntradayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntradayResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntradayResponse>(localVarStatusCode,
                localVarHeaders,
                (IntradayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntradayResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        public UserScheduleContainer PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        public async System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchAsync (string muId, UserListScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = await PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
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
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
