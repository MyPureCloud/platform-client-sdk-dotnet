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
    public interface IUsersRulesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete an existing users rule
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns></returns>
        
        void DeleteUsersRule (string ruleId);

        /// <summary>
        /// Delete an existing users rule
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteUsersRuleWithHttpInfo (string ruleId);

        /// <summary>
        /// Get a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>UsersRulesRule</returns>
        
        UsersRulesRule GetUsersRule (string ruleId);

        /// <summary>
        /// Get a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>ApiResponse of UsersRulesRule</returns>
        
        ApiResponse<UsersRulesRule> GetUsersRuleWithHttpInfo (string ruleId);

        /// <summary>
        /// Get dependent of a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>UsersRulesDependent</returns>
        
        UsersRulesDependent GetUsersRuleDependentTypeId (string ruleId, string ruleType, string typeId);

        /// <summary>
        /// Get dependent of a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>ApiResponse of UsersRulesDependent</returns>
        
        ApiResponse<UsersRulesDependent> GetUsersRuleDependentTypeIdWithHttpInfo (string ruleId, string ruleType, string typeId);

        /// <summary>
        /// Get dependents for a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>UsersRulesDependentList</returns>
        
        UsersRulesDependentList GetUsersRuleDependents (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get dependents for a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>ApiResponse of UsersRulesDependentList</returns>
        
        ApiResponse<UsersRulesDependentList> GetUsersRuleDependentsWithHttpInfo (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get the list of users rules
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>UsersRulesRuleList</returns>
        
        UsersRulesRuleList GetUsersRules (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null);

        /// <summary>
        /// Get the list of users rules
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of UsersRulesRuleList</returns>
        
        ApiResponse<UsersRulesRuleList> GetUsersRulesWithHttpInfo (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null);

        /// <summary>
        /// Get the settings for a specific users rule type
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>UsersRulesRuleSettings</returns>
        
        UsersRulesRuleSettings GetUsersRulesSetting (string ruleType);

        /// <summary>
        /// Get the settings for a specific users rule type
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>ApiResponse of UsersRulesRuleSettings</returns>
        
        ApiResponse<UsersRulesRuleSettings> GetUsersRulesSettingWithHttpInfo (string ruleType);

        /// <summary>
        /// Update an existing users rule
        /// </summary>
        /// <remarks>
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>UsersRulesRule</returns>
        
        UsersRulesRule PatchUsersRule (string ruleId, UsersRulesUpdateRuleRequest body);

        /// <summary>
        /// Update an existing users rule
        /// </summary>
        /// <remarks>
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>ApiResponse of UsersRulesRule</returns>
        
        ApiResponse<UsersRulesRule> PatchUsersRuleWithHttpInfo (string ruleId, UsersRulesUpdateRuleRequest body);

        /// <summary>
        /// Create a new rule
        /// </summary>
        /// <remarks>
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>UsersRulesRule</returns>
        
        UsersRulesRule PostUsersRules (UsersRulesCreateRuleRequest body);

        /// <summary>
        /// Create a new rule
        /// </summary>
        /// <remarks>
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>ApiResponse of UsersRulesRule</returns>
        
        ApiResponse<UsersRulesRule> PostUsersRulesWithHttpInfo (UsersRulesCreateRuleRequest body);

        /// <summary>
        /// Query the result of a users rule
        /// </summary>
        /// <remarks>
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>UsersRulesQueryResponse</returns>
        
        UsersRulesQueryResponse PostUsersRulesQuery (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Query the result of a users rule
        /// </summary>
        /// <remarks>
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>ApiResponse of UsersRulesQueryResponse</returns>
        
        ApiResponse<UsersRulesQueryResponse> PostUsersRulesQueryWithHttpInfo (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete an existing users rule
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteUsersRuleAsync (string ruleId);

        /// <summary>
        /// Delete an existing users rule
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUsersRuleAsyncWithHttpInfo (string ruleId);

        /// <summary>
        /// Get a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>Task of UsersRulesRule</returns>
        
        System.Threading.Tasks.Task<UsersRulesRule> GetUsersRuleAsync (string ruleId);

        /// <summary>
        /// Get a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>Task of ApiResponse (UsersRulesRule)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesRule>> GetUsersRuleAsyncWithHttpInfo (string ruleId);

        /// <summary>
        /// Get dependent of a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>Task of UsersRulesDependent</returns>
        
        System.Threading.Tasks.Task<UsersRulesDependent> GetUsersRuleDependentTypeIdAsync (string ruleId, string ruleType, string typeId);

        /// <summary>
        /// Get dependent of a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>Task of ApiResponse (UsersRulesDependent)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesDependent>> GetUsersRuleDependentTypeIdAsyncWithHttpInfo (string ruleId, string ruleType, string typeId);

        /// <summary>
        /// Get dependents for a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>Task of UsersRulesDependentList</returns>
        
        System.Threading.Tasks.Task<UsersRulesDependentList> GetUsersRuleDependentsAsync (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get dependents for a users rule
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (UsersRulesDependentList)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesDependentList>> GetUsersRuleDependentsAsyncWithHttpInfo (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get the list of users rules
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>Task of UsersRulesRuleList</returns>
        
        System.Threading.Tasks.Task<UsersRulesRuleList> GetUsersRulesAsync (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null);

        /// <summary>
        /// Get the list of users rules
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (UsersRulesRuleList)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesRuleList>> GetUsersRulesAsyncWithHttpInfo (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null);

        /// <summary>
        /// Get the settings for a specific users rule type
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>Task of UsersRulesRuleSettings</returns>
        
        System.Threading.Tasks.Task<UsersRulesRuleSettings> GetUsersRulesSettingAsync (string ruleType);

        /// <summary>
        /// Get the settings for a specific users rule type
        /// </summary>
        /// <remarks>
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>Task of ApiResponse (UsersRulesRuleSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesRuleSettings>> GetUsersRulesSettingAsyncWithHttpInfo (string ruleType);

        /// <summary>
        /// Update an existing users rule
        /// </summary>
        /// <remarks>
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>Task of UsersRulesRule</returns>
        
        System.Threading.Tasks.Task<UsersRulesRule> PatchUsersRuleAsync (string ruleId, UsersRulesUpdateRuleRequest body);

        /// <summary>
        /// Update an existing users rule
        /// </summary>
        /// <remarks>
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>Task of ApiResponse (UsersRulesRule)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesRule>> PatchUsersRuleAsyncWithHttpInfo (string ruleId, UsersRulesUpdateRuleRequest body);

        /// <summary>
        /// Create a new rule
        /// </summary>
        /// <remarks>
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>Task of UsersRulesRule</returns>
        
        System.Threading.Tasks.Task<UsersRulesRule> PostUsersRulesAsync (UsersRulesCreateRuleRequest body);

        /// <summary>
        /// Create a new rule
        /// </summary>
        /// <remarks>
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>Task of ApiResponse (UsersRulesRule)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesRule>> PostUsersRulesAsyncWithHttpInfo (UsersRulesCreateRuleRequest body);

        /// <summary>
        /// Query the result of a users rule
        /// </summary>
        /// <remarks>
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>Task of UsersRulesQueryResponse</returns>
        
        System.Threading.Tasks.Task<UsersRulesQueryResponse> PostUsersRulesQueryAsync (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Query the result of a users rule
        /// </summary>
        /// <remarks>
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (UsersRulesQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UsersRulesQueryResponse>> PostUsersRulesQueryAsyncWithHttpInfo (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersRulesApi : IUsersRulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersRulesApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersRulesApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete an existing users rule 
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns></returns>
        
        public void DeleteUsersRule (string ruleId)
        {
             DeleteUsersRuleWithHttpInfo(ruleId);
        }

        /// <summary>
        /// Delete an existing users rule 
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteUsersRuleWithHttpInfo (string ruleId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->DeleteUsersRule");

            var localVarPath = "/api/v2/users/rules/{ruleId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an existing users rule 
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteUsersRuleAsync (string ruleId)
        {
             await DeleteUsersRuleAsyncWithHttpInfo(ruleId);

        }

        /// <summary>
        /// Delete an existing users rule 
        /// 
        /// DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The id of the rule</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUsersRuleAsyncWithHttpInfo (string ruleId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->DeleteUsersRule");
            

            var localVarPath = "/api/v2/users/rules/{ruleId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsersRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a users rule 
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>UsersRulesRule</returns>
        
        public UsersRulesRule GetUsersRule (string ruleId)
        {
             ApiResponse<UsersRulesRule> localVarResponse = GetUsersRuleWithHttpInfo(ruleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a users rule 
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>ApiResponse of UsersRulesRule</returns>
        
        public ApiResponse< UsersRulesRule > GetUsersRuleWithHttpInfo (string ruleId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->GetUsersRule");

            var localVarPath = "/api/v2/users/rules/{ruleId}";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRule>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a users rule 
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>Task of UsersRulesRule</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesRule> GetUsersRuleAsync (string ruleId)
        {
             ApiResponse<UsersRulesRule> localVarResponse = await GetUsersRuleAsyncWithHttpInfo(ruleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a users rule 
        /// 
        /// GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to retrieve</param>
        /// <returns>Task of ApiResponse (UsersRulesRule)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesRule>> GetUsersRuleAsyncWithHttpInfo (string ruleId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->GetUsersRule");
            

            var localVarPath = "/api/v2/users/rules/{ruleId}";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRule>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get dependent of a users rule 
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>UsersRulesDependent</returns>
        
        public UsersRulesDependent GetUsersRuleDependentTypeId (string ruleId, string ruleType, string typeId)
        {
             ApiResponse<UsersRulesDependent> localVarResponse = GetUsersRuleDependentTypeIdWithHttpInfo(ruleId, ruleType, typeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dependent of a users rule 
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>ApiResponse of UsersRulesDependent</returns>
        
        public ApiResponse< UsersRulesDependent > GetUsersRuleDependentTypeIdWithHttpInfo (string ruleId, string ruleType, string typeId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->GetUsersRuleDependentTypeId");
            // verify the required parameter 'ruleType' is set
            if (ruleType == null)
                throw new ApiException(400, "Missing required parameter 'ruleType' when calling UsersRulesApi->GetUsersRuleDependentTypeId");
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling UsersRulesApi->GetUsersRuleDependentTypeId");

            var localVarPath = "/api/v2/users/rules/{ruleId}/dependents/{ruleType}/{typeId}";
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
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));
            if (ruleType != null) localVarPathParams.Add("ruleType", this.Configuration.ApiClient.ParameterToString(ruleType));
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependentTypeId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependentTypeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesDependent>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesDependent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesDependent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get dependent of a users rule 
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>Task of UsersRulesDependent</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesDependent> GetUsersRuleDependentTypeIdAsync (string ruleId, string ruleType, string typeId)
        {
             ApiResponse<UsersRulesDependent> localVarResponse = await GetUsersRuleDependentTypeIdAsyncWithHttpInfo(ruleId, ruleType, typeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dependent of a users rule 
        /// 
        /// GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="ruleType">The type of the dependent</param>
        /// <param name="typeId">The type ID of the dependent</param>
        /// <returns>Task of ApiResponse (UsersRulesDependent)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesDependent>> GetUsersRuleDependentTypeIdAsyncWithHttpInfo (string ruleId, string ruleType, string typeId)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->GetUsersRuleDependentTypeId");
            
            // verify the required parameter 'ruleType' is set
            if (ruleType == null)
                throw new ApiException(400, "Missing required parameter 'ruleType' when calling UsersRulesApi->GetUsersRuleDependentTypeId");
            
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling UsersRulesApi->GetUsersRuleDependentTypeId");
            

            var localVarPath = "/api/v2/users/rules/{ruleId}/dependents/{ruleType}/{typeId}";
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
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));
            if (ruleType != null) localVarPathParams.Add("ruleType", this.Configuration.ApiClient.ParameterToString(ruleType));
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependentTypeId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependentTypeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesDependent>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesDependent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesDependent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get dependents for a users rule 
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>UsersRulesDependentList</returns>
        
        public UsersRulesDependentList GetUsersRuleDependents (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<UsersRulesDependentList> localVarResponse = GetUsersRuleDependentsWithHttpInfo(ruleId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dependents for a users rule 
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>ApiResponse of UsersRulesDependentList</returns>
        
        public ApiResponse< UsersRulesDependentList > GetUsersRuleDependentsWithHttpInfo (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->GetUsersRuleDependents");

            var localVarPath = "/api/v2/users/rules/{ruleId}/dependents";
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
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesDependentList>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesDependentList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesDependentList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get dependents for a users rule 
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>Task of UsersRulesDependentList</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesDependentList> GetUsersRuleDependentsAsync (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<UsersRulesDependentList> localVarResponse = await GetUsersRuleDependentsAsyncWithHttpInfo(ruleId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dependents for a users rule 
        /// 
        /// GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule for which to retrieve dependents</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order for dependents (by last run date, then created date) (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (UsersRulesDependentList)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesDependentList>> GetUsersRuleDependentsAsyncWithHttpInfo (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->GetUsersRuleDependents");
            

            var localVarPath = "/api/v2/users/rules/{ruleId}/dependents";
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
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRuleDependents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesDependentList>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesDependentList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesDependentList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of users rules 
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>UsersRulesRuleList</returns>
        
        public UsersRulesRuleList GetUsersRules (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null)
        {
             ApiResponse<UsersRulesRuleList> localVarResponse = GetUsersRulesWithHttpInfo(types, pageNumber, pageSize, expand, enabled, searchTerm, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of users rules 
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of UsersRulesRuleList</returns>
        
        public ApiResponse< UsersRulesRuleList > GetUsersRulesWithHttpInfo (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null)
        { 
            // verify the required parameter 'types' is set
            if (types == null)
                throw new ApiException(400, "Missing required parameter 'types' when calling UsersRulesApi->GetUsersRules");

            var localVarPath = "/api/v2/users/rules";
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
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (enabled != null) localVarQueryParams.Add(new Tuple<string, string>("enabled", this.Configuration.ApiClient.ParameterToString(enabled)));
            if (searchTerm != null) localVarQueryParams.Add(new Tuple<string, string>("searchTerm", this.Configuration.ApiClient.ParameterToString(searchTerm)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRuleList>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRuleList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRuleList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of users rules 
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>Task of UsersRulesRuleList</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesRuleList> GetUsersRulesAsync (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null)
        {
             ApiResponse<UsersRulesRuleList> localVarResponse = await GetUsersRulesAsyncWithHttpInfo(types, pageNumber, pageSize, expand, enabled, searchTerm, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of users rules 
        /// 
        /// GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="types">The types of the rule</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <param name="enabled">Whether to list enabled or disabled rules (optional)</param>
        /// <param name="searchTerm">a search term for finding a rule by name (optional)</param>
        /// <param name="sortOrder">sort rules by name, ascending, descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (UsersRulesRuleList)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesRuleList>> GetUsersRulesAsyncWithHttpInfo (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, bool? enabled = null, string searchTerm = null, string sortOrder = null)
        { 
            // verify the required parameter 'types' is set
            if (types == null)
                throw new ApiException(400, "Missing required parameter 'types' when calling UsersRulesApi->GetUsersRules");
            

            var localVarPath = "/api/v2/users/rules";
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
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (enabled != null) localVarQueryParams.Add(new Tuple<string, string>("enabled", this.Configuration.ApiClient.ParameterToString(enabled)));
            if (searchTerm != null) localVarQueryParams.Add(new Tuple<string, string>("searchTerm", this.Configuration.ApiClient.ParameterToString(searchTerm)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRuleList>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRuleList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRuleList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the settings for a specific users rule type 
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>UsersRulesRuleSettings</returns>
        
        public UsersRulesRuleSettings GetUsersRulesSetting (string ruleType)
        {
             ApiResponse<UsersRulesRuleSettings> localVarResponse = GetUsersRulesSettingWithHttpInfo(ruleType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the settings for a specific users rule type 
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>ApiResponse of UsersRulesRuleSettings</returns>
        
        public ApiResponse< UsersRulesRuleSettings > GetUsersRulesSettingWithHttpInfo (string ruleType)
        { 
            // verify the required parameter 'ruleType' is set
            if (ruleType == null)
                throw new ApiException(400, "Missing required parameter 'ruleType' when calling UsersRulesApi->GetUsersRulesSetting");

            var localVarPath = "/api/v2/users/rules/settings/{ruleType}";
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
            if (ruleType != null) localVarPathParams.Add("ruleType", this.Configuration.ApiClient.ParameterToString(ruleType));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRulesSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRulesSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRuleSettings>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRuleSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRuleSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the settings for a specific users rule type 
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>Task of UsersRulesRuleSettings</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesRuleSettings> GetUsersRulesSettingAsync (string ruleType)
        {
             ApiResponse<UsersRulesRuleSettings> localVarResponse = await GetUsersRulesSettingAsyncWithHttpInfo(ruleType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the settings for a specific users rule type 
        /// 
        /// GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleType">The type of the rule</param>
        /// <returns>Task of ApiResponse (UsersRulesRuleSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesRuleSettings>> GetUsersRulesSettingAsyncWithHttpInfo (string ruleType)
        { 
            // verify the required parameter 'ruleType' is set
            if (ruleType == null)
                throw new ApiException(400, "Missing required parameter 'ruleType' when calling UsersRulesApi->GetUsersRulesSetting");
            

            var localVarPath = "/api/v2/users/rules/settings/{ruleType}";
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
            if (ruleType != null) localVarPathParams.Add("ruleType", this.Configuration.ApiClient.ParameterToString(ruleType));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRulesSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersRulesSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRuleSettings>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRuleSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRuleSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an existing users rule 
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>UsersRulesRule</returns>
        
        public UsersRulesRule PatchUsersRule (string ruleId, UsersRulesUpdateRuleRequest body)
        {
             ApiResponse<UsersRulesRule> localVarResponse = PatchUsersRuleWithHttpInfo(ruleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing users rule 
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>ApiResponse of UsersRulesRule</returns>
        
        public ApiResponse< UsersRulesRule > PatchUsersRuleWithHttpInfo (string ruleId, UsersRulesUpdateRuleRequest body)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->PatchUsersRule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersRulesApi->PatchUsersRule");

            var localVarPath = "/api/v2/users/rules/{ruleId}";
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
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRule>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an existing users rule 
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>Task of UsersRulesRule</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesRule> PatchUsersRuleAsync (string ruleId, UsersRulesUpdateRuleRequest body)
        {
             ApiResponse<UsersRulesRule> localVarResponse = await PatchUsersRuleAsyncWithHttpInfo(ruleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing users rule 
        /// This will update an existing users rule with the specified fields.
        /// PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">The ID of the rule to update</param>
        /// <param name="body">updateRuleRequest</param>
        /// <returns>Task of ApiResponse (UsersRulesRule)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesRule>> PatchUsersRuleAsyncWithHttpInfo (string ruleId, UsersRulesUpdateRuleRequest body)
        { 
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling UsersRulesApi->PatchUsersRule");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersRulesApi->PatchUsersRule");
            

            var localVarPath = "/api/v2/users/rules/{ruleId}";
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
            if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUsersRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRule>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new rule 
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>UsersRulesRule</returns>
        
        public UsersRulesRule PostUsersRules (UsersRulesCreateRuleRequest body)
        {
             ApiResponse<UsersRulesRule> localVarResponse = PostUsersRulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new rule 
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>ApiResponse of UsersRulesRule</returns>
        
        public ApiResponse< UsersRulesRule > PostUsersRulesWithHttpInfo (UsersRulesCreateRuleRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersRulesApi->PostUsersRules");

            var localVarPath = "/api/v2/users/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRule>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new rule 
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>Task of UsersRulesRule</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesRule> PostUsersRulesAsync (UsersRulesCreateRuleRequest body)
        {
             ApiResponse<UsersRulesRule> localVarResponse = await PostUsersRulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new rule 
        /// This will create a new rule with the specified fields.
        /// PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesCreateRuleRequest</param>
        /// <returns>Task of ApiResponse (UsersRulesRule)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesRule>> PostUsersRulesAsyncWithHttpInfo (UsersRulesCreateRuleRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersRulesApi->PostUsersRules");
            

            var localVarPath = "/api/v2/users/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesRule>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query the result of a users rule 
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>UsersRulesQueryResponse</returns>
        
        public UsersRulesQueryResponse PostUsersRulesQuery (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UsersRulesQueryResponse> localVarResponse = PostUsersRulesQueryWithHttpInfo(body, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query the result of a users rule 
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>ApiResponse of UsersRulesQueryResponse</returns>
        
        public ApiResponse< UsersRulesQueryResponse > PostUsersRulesQueryWithHttpInfo (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersRulesApi->PostUsersRulesQuery");

            var localVarPath = "/api/v2/users/rules/query";
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
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRulesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRulesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query the result of a users rule 
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>Task of UsersRulesQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<UsersRulesQueryResponse> PostUsersRulesQueryAsync (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UsersRulesQueryResponse> localVarResponse = await PostUsersRulesQueryAsyncWithHttpInfo(body, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query the result of a users rule 
        /// This will query the result of a rule.
        /// PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">usersRulesQueryRuleRequest</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Number of results per page (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (UsersRulesQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UsersRulesQueryResponse>> PostUsersRulesQueryAsyncWithHttpInfo (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersRulesApi->PostUsersRulesQuery");
            

            var localVarPath = "/api/v2/users/rules/query";
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
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRulesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersRulesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersRulesQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (UsersRulesQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersRulesQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
