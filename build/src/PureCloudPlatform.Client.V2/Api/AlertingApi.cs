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
    public interface IAlertingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        void DeleteAlertingInteractionstatsAlert (string alertId);

        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAlertingInteractionstatsAlertWithHttpInfo (string alertId);

        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        void DeleteAlertingInteractionstatsRule (string ruleId);

        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAlertingInteractionstatsRuleWithHttpInfo (string ruleId);

        /// <summary>
        /// Gets active alert count for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ActiveAlertCount</returns>
        ActiveAlertCount GetAlertingAlertsActive ();

        /// <summary>
        /// Gets active alert count for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ActiveAlertCount</returns>
        ApiResponse<ActiveAlertCount> GetAlertingAlertsActiveWithHttpInfo ();

        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsAlert</returns>
        InteractionStatsAlert GetAlertingInteractionstatsAlert (string alertId, List<string> expand = null);

        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsAlert</returns>
        ApiResponse<InteractionStatsAlert> GetAlertingInteractionstatsAlertWithHttpInfo (string alertId, List<string> expand = null);

        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsAlertContainer</returns>
        InteractionStatsAlertContainer GetAlertingInteractionstatsAlerts (List<string> expand = null);

        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsAlertContainer</returns>
        ApiResponse<InteractionStatsAlertContainer> GetAlertingInteractionstatsAlertsWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnreadMetric</returns>
        UnreadMetric GetAlertingInteractionstatsAlertsUnread ();

        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnreadMetric</returns>
        ApiResponse<UnreadMetric> GetAlertingInteractionstatsAlertsUnreadWithHttpInfo ();

        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        InteractionStatsRule GetAlertingInteractionstatsRule (string ruleId, List<string> expand = null);

        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        ApiResponse<InteractionStatsRule> GetAlertingInteractionstatsRuleWithHttpInfo (string ruleId, List<string> expand = null);

        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRuleContainer</returns>
        InteractionStatsRuleContainer GetAlertingInteractionstatsRules (List<string> expand = null);

        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRuleContainer</returns>
        ApiResponse<InteractionStatsRuleContainer> GetAlertingInteractionstatsRulesWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        InteractionStatsRule PostAlertingInteractionstatsRules (InteractionStatsRule body, List<string> expand = null);

        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        ApiResponse<InteractionStatsRule> PostAlertingInteractionstatsRulesWithHttpInfo (InteractionStatsRule body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>UnreadStatus</returns>
        UnreadStatus PutAlertingInteractionstatsAlert (string alertId, UnreadStatus body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of UnreadStatus</returns>
        ApiResponse<UnreadStatus> PutAlertingInteractionstatsAlertWithHttpInfo (string alertId, UnreadStatus body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        InteractionStatsRule PutAlertingInteractionstatsRule (string ruleId, InteractionStatsRule body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        ApiResponse<InteractionStatsRule> PutAlertingInteractionstatsRuleWithHttpInfo (string ruleId, InteractionStatsRule body, List<string> expand = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAlertingInteractionstatsAlertAsync (string alertId);

        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingInteractionstatsAlertAsyncWithHttpInfo (string alertId);

        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAlertingInteractionstatsRuleAsync (string ruleId);

        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingInteractionstatsRuleAsyncWithHttpInfo (string ruleId);

        /// <summary>
        /// Gets active alert count for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ActiveAlertCount</returns>
        System.Threading.Tasks.Task<ActiveAlertCount> GetAlertingAlertsActiveAsync ();

        /// <summary>
        /// Gets active alert count for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ActiveAlertCount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActiveAlertCount>> GetAlertingAlertsActiveAsyncWithHttpInfo ();

        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsAlert</returns>
        System.Threading.Tasks.Task<InteractionStatsAlert> GetAlertingInteractionstatsAlertAsync (string alertId, List<string> expand = null);

        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsAlert)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlert>> GetAlertingInteractionstatsAlertAsyncWithHttpInfo (string alertId, List<string> expand = null);

        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsAlertContainer</returns>
        System.Threading.Tasks.Task<InteractionStatsAlertContainer> GetAlertingInteractionstatsAlertsAsync (List<string> expand = null);

        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsAlertContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlertContainer>> GetAlertingInteractionstatsAlertsAsyncWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnreadMetric</returns>
        System.Threading.Tasks.Task<UnreadMetric> GetAlertingInteractionstatsAlertsUnreadAsync ();

        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> GetAlertingInteractionstatsAlertsUnreadAsyncWithHttpInfo ();

        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        System.Threading.Tasks.Task<InteractionStatsRule> GetAlertingInteractionstatsRuleAsync (string ruleId, List<string> expand = null);

        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> GetAlertingInteractionstatsRuleAsyncWithHttpInfo (string ruleId, List<string> expand = null);

        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRuleContainer</returns>
        System.Threading.Tasks.Task<InteractionStatsRuleContainer> GetAlertingInteractionstatsRulesAsync (List<string> expand = null);

        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRuleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRuleContainer>> GetAlertingInteractionstatsRulesAsyncWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        System.Threading.Tasks.Task<InteractionStatsRule> PostAlertingInteractionstatsRulesAsync (InteractionStatsRule body, List<string> expand = null);

        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PostAlertingInteractionstatsRulesAsyncWithHttpInfo (InteractionStatsRule body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of UnreadStatus</returns>
        System.Threading.Tasks.Task<UnreadStatus> PutAlertingInteractionstatsAlertAsync (string alertId, UnreadStatus body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (UnreadStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadStatus>> PutAlertingInteractionstatsAlertAsyncWithHttpInfo (string alertId, UnreadStatus body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        System.Threading.Tasks.Task<InteractionStatsRule> PutAlertingInteractionstatsRuleAsync (string ruleId, InteractionStatsRule body, List<string> expand = null);

        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PutAlertingInteractionstatsRuleAsyncWithHttpInfo (string ruleId, InteractionStatsRule body, List<string> expand = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlertingApi : IAlertingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlertingApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlertingApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        public void DeleteAlertingInteractionstatsAlert (string alertId)
        {
             DeleteAlertingInteractionstatsAlertWithHttpInfo(alertId);
        }

        /// <summary>
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAlertingInteractionstatsAlertWithHttpInfo (string alertId)
        { 
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->DeleteAlertingInteractionstatsAlert");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (alertId != null) localVarPathParams.Add("alertId", this.Configuration.ApiClient.ParameterToString(alertId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAlertingInteractionstatsAlertAsync (string alertId)
        {
             await DeleteAlertingInteractionstatsAlertAsyncWithHttpInfo(alertId);

        }

        /// <summary>
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingInteractionstatsAlertAsyncWithHttpInfo (string alertId)
        { 
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->DeleteAlertingInteractionstatsAlert");
            

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (alertId != null) localVarPathParams.Add("alertId", this.Configuration.ApiClient.ParameterToString(alertId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        public void DeleteAlertingInteractionstatsRule (string ruleId)
        {
             DeleteAlertingInteractionstatsRuleWithHttpInfo(ruleId);
        }

        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAlertingInteractionstatsRuleWithHttpInfo (string ruleId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->DeleteAlertingInteractionstatsRule");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAlertingInteractionstatsRuleAsync (string ruleId)
        {
             await DeleteAlertingInteractionstatsRuleAsyncWithHttpInfo(ruleId);

        }

        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingInteractionstatsRuleAsyncWithHttpInfo (string ruleId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->DeleteAlertingInteractionstatsRule");
            

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAlertingInteractionstatsRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets active alert count for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ActiveAlertCount</returns>
        public ActiveAlertCount GetAlertingAlertsActive ()
        {
             ApiResponse<ActiveAlertCount> localVarResponse = GetAlertingAlertsActiveWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets active alert count for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ActiveAlertCount</returns>
        public ApiResponse< ActiveAlertCount > GetAlertingAlertsActiveWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/alerting/alerts/active";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingAlertsActive: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingAlertsActive: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActiveAlertCount>(localVarStatusCode,
                localVarHeaders,
                (ActiveAlertCount) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActiveAlertCount)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets active alert count for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ActiveAlertCount</returns>
        public async System.Threading.Tasks.Task<ActiveAlertCount> GetAlertingAlertsActiveAsync ()
        {
             ApiResponse<ActiveAlertCount> localVarResponse = await GetAlertingAlertsActiveAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets active alert count for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ActiveAlertCount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActiveAlertCount>> GetAlertingAlertsActiveAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/alerting/alerts/active";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingAlertsActive: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingAlertsActive: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActiveAlertCount>(localVarStatusCode,
                localVarHeaders,
                (ActiveAlertCount) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActiveAlertCount)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsAlert</returns>
        public InteractionStatsAlert GetAlertingInteractionstatsAlert (string alertId, List<string> expand = null)
        {
             ApiResponse<InteractionStatsAlert> localVarResponse = GetAlertingInteractionstatsAlertWithHttpInfo(alertId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsAlert</returns>
        public ApiResponse< InteractionStatsAlert > GetAlertingInteractionstatsAlertWithHttpInfo (string alertId, List<string> expand = null)
        { 
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->GetAlertingInteractionstatsAlert");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (alertId != null) localVarPathParams.Add("alertId", this.Configuration.ApiClient.ParameterToString(alertId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlert>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsAlert) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlert)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsAlert</returns>
        public async System.Threading.Tasks.Task<InteractionStatsAlert> GetAlertingInteractionstatsAlertAsync (string alertId, List<string> expand = null)
        {
             ApiResponse<InteractionStatsAlert> localVarResponse = await GetAlertingInteractionstatsAlertAsyncWithHttpInfo(alertId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsAlert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlert>> GetAlertingInteractionstatsAlertAsyncWithHttpInfo (string alertId, List<string> expand = null)
        { 
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->GetAlertingInteractionstatsAlert");
            

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (alertId != null) localVarPathParams.Add("alertId", this.Configuration.ApiClient.ParameterToString(alertId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlert>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsAlert) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlert)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsAlertContainer</returns>
        public InteractionStatsAlertContainer GetAlertingInteractionstatsAlerts (List<string> expand = null)
        {
             ApiResponse<InteractionStatsAlertContainer> localVarResponse = GetAlertingInteractionstatsAlertsWithHttpInfo(expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsAlertContainer</returns>
        public ApiResponse< InteractionStatsAlertContainer > GetAlertingInteractionstatsAlertsWithHttpInfo (List<string> expand = null)
        { 

            var localVarPath = "/api/v2/alerting/interactionstats/alerts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlerts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlerts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlertContainer>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsAlertContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlertContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsAlertContainer</returns>
        public async System.Threading.Tasks.Task<InteractionStatsAlertContainer> GetAlertingInteractionstatsAlertsAsync (List<string> expand = null)
        {
             ApiResponse<InteractionStatsAlertContainer> localVarResponse = await GetAlertingInteractionstatsAlertsAsyncWithHttpInfo(expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsAlertContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlertContainer>> GetAlertingInteractionstatsAlertsAsyncWithHttpInfo (List<string> expand = null)
        { 

            var localVarPath = "/api/v2/alerting/interactionstats/alerts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlerts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlerts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlertContainer>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsAlertContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlertContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnreadMetric</returns>
        public UnreadMetric GetAlertingInteractionstatsAlertsUnread ()
        {
             ApiResponse<UnreadMetric> localVarResponse = GetAlertingInteractionstatsAlertsUnreadWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnreadMetric</returns>
        public ApiResponse< UnreadMetric > GetAlertingInteractionstatsAlertsUnreadWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/unread";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlertsUnread: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlertsUnread: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarHeaders,
                (UnreadMetric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnreadMetric</returns>
        public async System.Threading.Tasks.Task<UnreadMetric> GetAlertingInteractionstatsAlertsUnreadAsync ()
        {
             ApiResponse<UnreadMetric> localVarResponse = await GetAlertingInteractionstatsAlertsUnreadAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> GetAlertingInteractionstatsAlertsUnreadAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/unread";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlertsUnread: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsAlertsUnread: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarHeaders,
                (UnreadMetric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        public InteractionStatsRule GetAlertingInteractionstatsRule (string ruleId, List<string> expand = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = GetAlertingInteractionstatsRuleWithHttpInfo(ruleId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        public ApiResponse< InteractionStatsRule > GetAlertingInteractionstatsRuleWithHttpInfo (string ruleId, List<string> expand = null)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->GetAlertingInteractionstatsRule");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRule> GetAlertingInteractionstatsRuleAsync (string ruleId, List<string> expand = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = await GetAlertingInteractionstatsRuleAsyncWithHttpInfo(ruleId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> GetAlertingInteractionstatsRuleAsyncWithHttpInfo (string ruleId, List<string> expand = null)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->GetAlertingInteractionstatsRule");
            

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRuleContainer</returns>
        public InteractionStatsRuleContainer GetAlertingInteractionstatsRules (List<string> expand = null)
        {
             ApiResponse<InteractionStatsRuleContainer> localVarResponse = GetAlertingInteractionstatsRulesWithHttpInfo(expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRuleContainer</returns>
        public ApiResponse< InteractionStatsRuleContainer > GetAlertingInteractionstatsRulesWithHttpInfo (List<string> expand = null)
        { 

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRuleContainer>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRuleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRuleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRuleContainer</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRuleContainer> GetAlertingInteractionstatsRulesAsync (List<string> expand = null)
        {
             ApiResponse<InteractionStatsRuleContainer> localVarResponse = await GetAlertingInteractionstatsRulesAsyncWithHttpInfo(expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRuleContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRuleContainer>> GetAlertingInteractionstatsRulesAsyncWithHttpInfo (List<string> expand = null)
        { 

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAlertingInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRuleContainer>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRuleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRuleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        public InteractionStatsRule PostAlertingInteractionstatsRules (InteractionStatsRule body, List<string> expand = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = PostAlertingInteractionstatsRulesWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        public ApiResponse< InteractionStatsRule > PostAlertingInteractionstatsRulesWithHttpInfo (InteractionStatsRule body, List<string> expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PostAlertingInteractionstatsRules");

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PostAlertingInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAlertingInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRule> PostAlertingInteractionstatsRulesAsync (InteractionStatsRule body, List<string> expand = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = await PostAlertingInteractionstatsRulesAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PostAlertingInteractionstatsRulesAsyncWithHttpInfo (InteractionStatsRule body, List<string> expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PostAlertingInteractionstatsRules");
            

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PostAlertingInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAlertingInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>UnreadStatus</returns>
        public UnreadStatus PutAlertingInteractionstatsAlert (string alertId, UnreadStatus body, List<string> expand = null)
        {
             ApiResponse<UnreadStatus> localVarResponse = PutAlertingInteractionstatsAlertWithHttpInfo(alertId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of UnreadStatus</returns>
        public ApiResponse< UnreadStatus > PutAlertingInteractionstatsAlertWithHttpInfo (string alertId, UnreadStatus body, List<string> expand = null)
        { 
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PutAlertingInteractionstatsAlert");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PutAlertingInteractionstatsAlert");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (alertId != null) localVarPathParams.Add("alertId", this.Configuration.ApiClient.ParameterToString(alertId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadStatus>(localVarStatusCode,
                localVarHeaders,
                (UnreadStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of UnreadStatus</returns>
        public async System.Threading.Tasks.Task<UnreadStatus> PutAlertingInteractionstatsAlertAsync (string alertId, UnreadStatus body, List<string> expand = null)
        {
             ApiResponse<UnreadStatus> localVarResponse = await PutAlertingInteractionstatsAlertAsyncWithHttpInfo(alertId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (UnreadStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadStatus>> PutAlertingInteractionstatsAlertAsyncWithHttpInfo (string alertId, UnreadStatus body, List<string> expand = null)
        { 
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PutAlertingInteractionstatsAlert");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PutAlertingInteractionstatsAlert");
            

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (alertId != null) localVarPathParams.Add("alertId", this.Configuration.ApiClient.ParameterToString(alertId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsAlert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsAlert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadStatus>(localVarStatusCode,
                localVarHeaders,
                (UnreadStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        public InteractionStatsRule PutAlertingInteractionstatsRule (string ruleId, InteractionStatsRule body, List<string> expand = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = PutAlertingInteractionstatsRuleWithHttpInfo(ruleId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        public ApiResponse< InteractionStatsRule > PutAlertingInteractionstatsRuleWithHttpInfo (string ruleId, InteractionStatsRule body, List<string> expand = null)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->PutAlertingInteractionstatsRule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PutAlertingInteractionstatsRule");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRule> PutAlertingInteractionstatsRuleAsync (string ruleId, InteractionStatsRule body, List<string> expand = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = await PutAlertingInteractionstatsRuleAsyncWithHttpInfo(ruleId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PutAlertingInteractionstatsRuleAsyncWithHttpInfo (string ruleId, InteractionStatsRule body, List<string> expand = null)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->PutAlertingInteractionstatsRule");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AlertingApi->PutAlertingInteractionstatsRule");
            

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAlertingInteractionstatsRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarHeaders,
                (InteractionStatsRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
