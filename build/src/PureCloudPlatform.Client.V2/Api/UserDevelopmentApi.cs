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
    public interface IUserDevelopmentApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get list of Development Activities
        /// </summary>
        /// <remarks>
        /// Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>DevelopmentActivityListing</returns>
        DevelopmentActivityListing GetUsersDevelopmentActivities (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);

        /// <summary>
        /// Get list of Development Activities
        /// </summary>
        /// <remarks>
        /// Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>ApiResponse of DevelopmentActivityListing</returns>
        ApiResponse<DevelopmentActivityListing> GetUsersDevelopmentActivitiesWithHttpInfo (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);
        
        /// <summary>
        /// Get list of Development Activities for current user
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>DevelopmentActivityListing</returns>
        DevelopmentActivityListing GetUsersDevelopmentActivitiesMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);

        /// <summary>
        /// Get list of Development Activities for current user
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>ApiResponse of DevelopmentActivityListing</returns>
        ApiResponse<DevelopmentActivityListing> GetUsersDevelopmentActivitiesMeWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);
        
        /// <summary>
        /// Get a Development Activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>DevelopmentActivity</returns>
        DevelopmentActivity GetUsersDevelopmentActivity (string activityId, string type);

        /// <summary>
        /// Get a Development Activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>ApiResponse of DevelopmentActivity</returns>
        ApiResponse<DevelopmentActivity> GetUsersDevelopmentActivityWithHttpInfo (string activityId, string type);
        
        /// <summary>
        /// Retrieve aggregated development activity data
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>DevelopmentActivityAggregateResponse</returns>
        DevelopmentActivityAggregateResponse PostUsersDevelopmentActivitiesAggregatesQuery (DevelopmentActivityAggregateParam body);

        /// <summary>
        /// Retrieve aggregated development activity data
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>ApiResponse of DevelopmentActivityAggregateResponse</returns>
        ApiResponse<DevelopmentActivityAggregateResponse> PostUsersDevelopmentActivitiesAggregatesQueryWithHttpInfo (DevelopmentActivityAggregateParam body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get list of Development Activities
        /// </summary>
        /// <remarks>
        /// Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of DevelopmentActivityListing</returns>
        System.Threading.Tasks.Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesAsync (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);

        /// <summary>
        /// Get list of Development Activities
        /// </summary>
        /// <remarks>
        /// Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of ApiResponse (DevelopmentActivityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DevelopmentActivityListing>> GetUsersDevelopmentActivitiesAsyncWithHttpInfo (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);
        
        /// <summary>
        /// Get list of Development Activities for current user
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of DevelopmentActivityListing</returns>
        System.Threading.Tasks.Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesMeAsync (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);

        /// <summary>
        /// Get list of Development Activities for current user
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of ApiResponse (DevelopmentActivityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DevelopmentActivityListing>> GetUsersDevelopmentActivitiesMeAsyncWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null);
        
        /// <summary>
        /// Get a Development Activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>Task of DevelopmentActivity</returns>
        System.Threading.Tasks.Task<DevelopmentActivity> GetUsersDevelopmentActivityAsync (string activityId, string type);

        /// <summary>
        /// Get a Development Activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>Task of ApiResponse (DevelopmentActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<DevelopmentActivity>> GetUsersDevelopmentActivityAsyncWithHttpInfo (string activityId, string type);
        
        /// <summary>
        /// Retrieve aggregated development activity data
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of DevelopmentActivityAggregateResponse</returns>
        System.Threading.Tasks.Task<DevelopmentActivityAggregateResponse> PostUsersDevelopmentActivitiesAggregatesQueryAsync (DevelopmentActivityAggregateParam body);

        /// <summary>
        /// Retrieve aggregated development activity data
        /// </summary>
        /// <remarks>
        /// Results are filtered based on the applicable permissions.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of ApiResponse (DevelopmentActivityAggregateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DevelopmentActivityAggregateResponse>> PostUsersDevelopmentActivitiesAggregatesQueryAsyncWithHttpInfo (DevelopmentActivityAggregateParam body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserDevelopmentApi : IUserDevelopmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDevelopmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserDevelopmentApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDevelopmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserDevelopmentApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get list of Development Activities Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>DevelopmentActivityListing</returns>
        public DevelopmentActivityListing GetUsersDevelopmentActivities (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        {
             ApiResponse<DevelopmentActivityListing> localVarResponse = GetUsersDevelopmentActivitiesWithHttpInfo(userId, moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, types, statuses, relationship);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of Development Activities Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>ApiResponse of DevelopmentActivityListing</returns>
        public ApiResponse< DevelopmentActivityListing > GetUsersDevelopmentActivitiesWithHttpInfo (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        { 

            var localVarPath = "/api/v2/users/development/activities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (relationship != null) relationship.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationship", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivities: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivities: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivityListing>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get list of Development Activities Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of DevelopmentActivityListing</returns>
        public async System.Threading.Tasks.Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesAsync (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        {
             ApiResponse<DevelopmentActivityListing> localVarResponse = await GetUsersDevelopmentActivitiesAsyncWithHttpInfo(userId, moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, types, statuses, relationship);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of Development Activities Either moduleId or userId is required. Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional)</param>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of ApiResponse (DevelopmentActivityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DevelopmentActivityListing>> GetUsersDevelopmentActivitiesAsyncWithHttpInfo (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        { 

            var localVarPath = "/api/v2/users/development/activities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (relationship != null) relationship.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationship", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivities: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivities: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivityListing>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get list of Development Activities for current user Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>DevelopmentActivityListing</returns>
        public DevelopmentActivityListing GetUsersDevelopmentActivitiesMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        {
             ApiResponse<DevelopmentActivityListing> localVarResponse = GetUsersDevelopmentActivitiesMeWithHttpInfo(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, types, statuses, relationship);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of Development Activities for current user Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>ApiResponse of DevelopmentActivityListing</returns>
        public ApiResponse< DevelopmentActivityListing > GetUsersDevelopmentActivitiesMeWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        { 

            var localVarPath = "/api/v2/users/development/activities/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (relationship != null) relationship.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationship", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivitiesMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivitiesMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivityListing>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get list of Development Activities for current user Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of DevelopmentActivityListing</returns>
        public async System.Threading.Tasks.Task<DevelopmentActivityListing> GetUsersDevelopmentActivitiesMeAsync (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        {
             ApiResponse<DevelopmentActivityListing> localVarResponse = await GetUsersDevelopmentActivitiesMeAsyncWithHttpInfo(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, types, statuses, relationship);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of Development Activities for current user Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. (optional)</param>
        /// <param name="interval">Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="types">Specifies the activity types. (optional)</param>
        /// <param name="statuses">Specifies the activity statuses to filter by (optional)</param>
        /// <param name="relationship">Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional)</param>
        /// <returns>Task of ApiResponse (DevelopmentActivityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DevelopmentActivityListing>> GetUsersDevelopmentActivitiesMeAsyncWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)
        { 

            var localVarPath = "/api/v2/users/development/activities/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (relationship != null) relationship.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationship", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivitiesMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivitiesMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivityListing>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Development Activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>DevelopmentActivity</returns>
        public DevelopmentActivity GetUsersDevelopmentActivity (string activityId, string type)
        {
             ApiResponse<DevelopmentActivity> localVarResponse = GetUsersDevelopmentActivityWithHttpInfo(activityId, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Development Activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>ApiResponse of DevelopmentActivity</returns>
        public ApiResponse< DevelopmentActivity > GetUsersDevelopmentActivityWithHttpInfo (string activityId, string type)
        { 
            // verify the required parameter 'activityId' is set
            if (activityId == null)
                throw new ApiException(400, "Missing required parameter 'activityId' when calling UserDevelopmentApi->GetUsersDevelopmentActivity");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling UserDevelopmentApi->GetUsersDevelopmentActivity");

            var localVarPath = "/api/v2/users/development/activities/{activityId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (activityId != null) localVarPathParams.Add("activityId", this.Configuration.ApiClient.ParameterToString(activityId));

            // Query params
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivity>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Development Activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>Task of DevelopmentActivity</returns>
        public async System.Threading.Tasks.Task<DevelopmentActivity> GetUsersDevelopmentActivityAsync (string activityId, string type)
        {
             ApiResponse<DevelopmentActivity> localVarResponse = await GetUsersDevelopmentActivityAsyncWithHttpInfo(activityId, type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Development Activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">Specifies the activity ID, maps to either assignment or appointment ID</param>
        /// <param name="type">Specifies the activity type.</param>
        /// <returns>Task of ApiResponse (DevelopmentActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DevelopmentActivity>> GetUsersDevelopmentActivityAsyncWithHttpInfo (string activityId, string type)
        { 
            // verify the required parameter 'activityId' is set
            if (activityId == null)
                throw new ApiException(400, "Missing required parameter 'activityId' when calling UserDevelopmentApi->GetUsersDevelopmentActivity");
            
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling UserDevelopmentApi->GetUsersDevelopmentActivity");
            

            var localVarPath = "/api/v2/users/development/activities/{activityId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (activityId != null) localVarPathParams.Add("activityId", this.Configuration.ApiClient.ParameterToString(activityId));

            // Query params
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersDevelopmentActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivity>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve aggregated development activity data Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>DevelopmentActivityAggregateResponse</returns>
        public DevelopmentActivityAggregateResponse PostUsersDevelopmentActivitiesAggregatesQuery (DevelopmentActivityAggregateParam body)
        {
             ApiResponse<DevelopmentActivityAggregateResponse> localVarResponse = PostUsersDevelopmentActivitiesAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve aggregated development activity data Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>ApiResponse of DevelopmentActivityAggregateResponse</returns>
        public ApiResponse< DevelopmentActivityAggregateResponse > PostUsersDevelopmentActivitiesAggregatesQueryWithHttpInfo (DevelopmentActivityAggregateParam body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UserDevelopmentApi->PostUsersDevelopmentActivitiesAggregatesQuery");

            var localVarPath = "/api/v2/users/development/activities/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersDevelopmentActivitiesAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersDevelopmentActivitiesAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivityAggregateResponse>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivityAggregateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivityAggregateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve aggregated development activity data Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of DevelopmentActivityAggregateResponse</returns>
        public async System.Threading.Tasks.Task<DevelopmentActivityAggregateResponse> PostUsersDevelopmentActivitiesAggregatesQueryAsync (DevelopmentActivityAggregateParam body)
        {
             ApiResponse<DevelopmentActivityAggregateResponse> localVarResponse = await PostUsersDevelopmentActivitiesAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve aggregated development activity data Results are filtered based on the applicable permissions.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of ApiResponse (DevelopmentActivityAggregateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DevelopmentActivityAggregateResponse>> PostUsersDevelopmentActivitiesAggregatesQueryAsyncWithHttpInfo (DevelopmentActivityAggregateParam body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UserDevelopmentApi->PostUsersDevelopmentActivitiesAggregatesQuery");
            

            var localVarPath = "/api/v2/users/development/activities/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersDevelopmentActivitiesAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersDevelopmentActivitiesAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevelopmentActivityAggregateResponse>(localVarStatusCode,
                localVarHeaders,
                (DevelopmentActivityAggregateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevelopmentActivityAggregateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
