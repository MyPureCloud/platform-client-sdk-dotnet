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
    public interface IIntegrationsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Integration</returns>
        
        
        Integration DeleteIntegration (string integrationId);

        /// <summary>
        /// Delete integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        ApiResponse<Integration> DeleteIntegrationWithHttpInfo (string integrationId);

        /// <summary>
        /// Delete an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns></returns>
        
        
        void DeleteIntegrationsAction (string actionId);

        /// <summary>
        /// Delete an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        ApiResponse<Object> DeleteIntegrationsActionWithHttpInfo (string actionId);

        /// <summary>
        /// Delete a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns></returns>
        
        
        void DeleteIntegrationsActionDraft (string actionId);

        /// <summary>
        /// Delete a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        ApiResponse<Object> DeleteIntegrationsActionDraftWithHttpInfo (string actionId);

        /// <summary>
        /// Delete a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns></returns>
        
        
        void DeleteIntegrationsCredential (string credentialId);

        /// <summary>
        /// Delete a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        ApiResponse<Object> DeleteIntegrationsCredentialWithHttpInfo (string credentialId);

        /// <summary>
        /// Get integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Integration</returns>
        
        
        Integration GetIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        ApiResponse<Integration> GetIntegrationWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>IntegrationConfiguration</returns>
        
        
        IntegrationConfiguration GetIntegrationConfigCurrent (string integrationId);

        /// <summary>
        /// Get integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>ApiResponse of IntegrationConfiguration</returns>
        
        
        ApiResponse<IntegrationConfiguration> GetIntegrationConfigCurrentWithHttpInfo (string integrationId);

        /// <summary>
        /// List integrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>IntegrationEntityListing</returns>
        
        
        IntegrationEntityListing GetIntegrations (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List integrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of IntegrationEntityListing</returns>
        
        
        ApiResponse<IntegrationEntityListing> GetIntegrationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves a single Action matching id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action GetIntegrationsAction (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieves a single Action matching id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> GetIntegrationsActionWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieve a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action GetIntegrationsActionDraft (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieve a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> GetIntegrationsActionDraftWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieve schema for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>JsonSchemaDocument</returns>
        
        
        JsonSchemaDocument GetIntegrationsActionDraftSchema (string actionId, string fileName);

        /// <summary>
        /// Retrieve schema for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>ApiResponse of JsonSchemaDocument</returns>
        
        
        ApiResponse<JsonSchemaDocument> GetIntegrationsActionDraftSchemaWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Retrieve templates for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>string</returns>
        
        
        string GetIntegrationsActionDraftTemplate (string actionId, string fileName);

        /// <summary>
        /// Retrieve templates for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>ApiResponse of string</returns>
        
        
        ApiResponse<string> GetIntegrationsActionDraftTemplateWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Validate current Draft configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>DraftValidationResult</returns>
        
        
        DraftValidationResult GetIntegrationsActionDraftValidation (string actionId);

        /// <summary>
        /// Validate current Draft configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of DraftValidationResult</returns>
        
        
        ApiResponse<DraftValidationResult> GetIntegrationsActionDraftValidationWithHttpInfo (string actionId);

        /// <summary>
        /// Retrieve schema for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>JsonSchemaDocument</returns>
        
        
        JsonSchemaDocument GetIntegrationsActionSchema (string actionId, string fileName);

        /// <summary>
        /// Retrieve schema for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>ApiResponse of JsonSchemaDocument</returns>
        
        
        ApiResponse<JsonSchemaDocument> GetIntegrationsActionSchemaWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Retrieve text of templates for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>string</returns>
        
        
        string GetIntegrationsActionTemplate (string actionId, string fileName);

        /// <summary>
        /// Retrieve text of templates for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>ApiResponse of string</returns>
        
        
        ApiResponse<string> GetIntegrationsActionTemplateWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ActionEntityListing</returns>
        
        
        ActionEntityListing GetIntegrationsActions (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        
        
        ApiResponse<ActionEntityListing> GetIntegrationsActionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>CategoryEntityListing</returns>
        
        
        CategoryEntityListing GetIntegrationsActionsCategories (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null);

        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>ApiResponse of CategoryEntityListing</returns>
        
        
        ApiResponse<CategoryEntityListing> GetIntegrationsActionsCategoriesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null);

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ActionEntityListing</returns>
        
        
        ActionEntityListing GetIntegrationsActionsDrafts (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        
        
        ApiResponse<ActionEntityListing> GetIntegrationsActionsDraftsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>BotConnectorBot</returns>
        
        
        BotConnectorBot GetIntegrationsBotconnectorIntegrationIdBot (string integrationId, string botId, string version = null);

        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>ApiResponse of BotConnectorBot</returns>
        
        
        ApiResponse<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotWithHttpInfo (string integrationId, string botId, string version = null);

        /// <summary>
        /// Get a list of bot versions for a bot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>BotConnectorBotVersionSummaryEntityListing</returns>
        
        
        BotConnectorBotVersionSummaryEntityListing GetIntegrationsBotconnectorIntegrationIdBotVersions (string integrationId, string botId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of bot versions for a bot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of BotConnectorBotVersionSummaryEntityListing</returns>
        
        
        ApiResponse<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsWithHttpInfo (string integrationId, string botId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>BotList</returns>
        
        
        BotList GetIntegrationsBotconnectorIntegrationIdBots (string integrationId);

        /// <summary>
        /// Get a list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>ApiResponse of BotList</returns>
        
        
        ApiResponse<BotList> GetIntegrationsBotconnectorIntegrationIdBotsWithHttpInfo (string integrationId);

        /// <summary>
        /// Get a summary list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>BotConnectorBotSummaryEntityListing</returns>
        
        
        BotConnectorBotSummaryEntityListing GetIntegrationsBotconnectorIntegrationIdBotsSummaries (string integrationId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a summary list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of BotConnectorBotSummaryEntityListing</returns>
        
        
        ApiResponse<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesWithHttpInfo (string integrationId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// List permitted client app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ClientAppEntityListing</returns>
        
        
        ClientAppEntityListing GetIntegrationsClientapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List permitted client app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of ClientAppEntityListing</returns>
        
        
        ApiResponse<ClientAppEntityListing> GetIntegrationsClientappsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// UC integration client application configuration.
        /// </summary>
        /// <remarks>
        /// This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>UCIntegrationListing</returns>
        
        
        UCIntegrationListing GetIntegrationsClientappsUnifiedcommunications (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// UC integration client application configuration.
        /// </summary>
        /// <remarks>
        /// This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of UCIntegrationListing</returns>
        
        
        ApiResponse<UCIntegrationListing> GetIntegrationsClientappsUnifiedcommunicationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get a single credential with sensitive fields redacted
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Credential</returns>
        
        
        Credential GetIntegrationsCredential (string credentialId);

        /// <summary>
        /// Get a single credential with sensitive fields redacted
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>ApiResponse of Credential</returns>
        
        
        ApiResponse<Credential> GetIntegrationsCredentialWithHttpInfo (string credentialId);

        /// <summary>
        /// List multiple sets of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>CredentialInfoListing</returns>
        
        
        CredentialInfoListing GetIntegrationsCredentials (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// List multiple sets of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of CredentialInfoListing</returns>
        
        
        ApiResponse<CredentialInfoListing> GetIntegrationsCredentialsWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// List all credential types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CredentialTypeListing</returns>
        
        
        CredentialTypeListing GetIntegrationsCredentialsTypes ();

        /// <summary>
        /// List all credential types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CredentialTypeListing</returns>
        
        
        ApiResponse<CredentialTypeListing> GetIntegrationsCredentialsTypesWithHttpInfo ();

        /// <summary>
        /// Get details about a Dialogflow agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>DialogflowAgent</returns>
        
        
        DialogflowAgent GetIntegrationsSpeechDialogflowAgent (string agentId);

        /// <summary>
        /// Get details about a Dialogflow agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>ApiResponse of DialogflowAgent</returns>
        
        
        ApiResponse<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentWithHttpInfo (string agentId);

        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>DialogflowAgentSummaryEntityListing</returns>
        
        
        DialogflowAgentSummaryEntityListing GetIntegrationsSpeechDialogflowAgents (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>ApiResponse of DialogflowAgentSummaryEntityListing</returns>
        
        
        ApiResponse<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get details about a Lex bot alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>LexBotAlias</returns>
        
        
        LexBotAlias GetIntegrationsSpeechLexBotAlias (string aliasId);

        /// <summary>
        /// Get details about a Lex bot alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>ApiResponse of LexBotAlias</returns>
        
        
        ApiResponse<LexBotAlias> GetIntegrationsSpeechLexBotAliasWithHttpInfo (string aliasId);

        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>LexBotAliasEntityListing</returns>
        
        
        LexBotAliasEntityListing GetIntegrationsSpeechLexBotBotIdAliases (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null);

        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>ApiResponse of LexBotAliasEntityListing</returns>
        
        
        ApiResponse<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesWithHttpInfo (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null);

        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>LexBotEntityListing</returns>
        
        
        LexBotEntityListing GetIntegrationsSpeechLexBots (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>ApiResponse of LexBotEntityListing</returns>
        
        
        ApiResponse<LexBotEntityListing> GetIntegrationsSpeechLexBotsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>NuanceBot</returns>
        
        /// Preview Endpoint
        NuanceBot GetIntegrationsSpeechNuanceNuanceIntegrationIdBot (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>ApiResponse of NuanceBot</returns>
        
        /// Preview Endpoint
        ApiResponse<NuanceBot> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null);

        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        AsyncJob GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        ApiResponse<AsyncJob> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobWithHttpInfo (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>NuanceBot</returns>
        
        /// Preview Endpoint
        NuanceBot GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of NuanceBot</returns>
        
        /// Preview Endpoint
        ApiResponse<NuanceBot> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsWithHttpInfo (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration
        /// </summary>
        /// <remarks>
        /// If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        NuanceBotEntityListing GetIntegrationsSpeechNuanceNuanceIntegrationIdBots (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration
        /// </summary>
        /// <remarks>
        /// If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>ApiResponse of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        ApiResponse<NuanceBotEntityListing> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        AsyncJob GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        ApiResponse<AsyncJob> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobWithHttpInfo (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        NuanceBotEntityListing GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        ApiResponse<NuanceBotEntityListing> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsWithHttpInfo (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get details about a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>TtsEngineEntity</returns>
        
        
        TtsEngineEntity GetIntegrationsSpeechTtsEngine (string engineId, bool? includeVoices = null);

        /// <summary>
        /// Get details about a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>ApiResponse of TtsEngineEntity</returns>
        
        
        ApiResponse<TtsEngineEntity> GetIntegrationsSpeechTtsEngineWithHttpInfo (string engineId, bool? includeVoices = null);

        /// <summary>
        /// Get details about a specific voice for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>TtsVoiceEntity</returns>
        
        
        TtsVoiceEntity GetIntegrationsSpeechTtsEngineVoice (string engineId, string voiceId);

        /// <summary>
        /// Get details about a specific voice for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>ApiResponse of TtsVoiceEntity</returns>
        
        
        ApiResponse<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceWithHttpInfo (string engineId, string voiceId);

        /// <summary>
        /// Get a list of voices for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>TtsVoiceEntityListing</returns>
        
        
        TtsVoiceEntityListing GetIntegrationsSpeechTtsEngineVoices (string engineId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of voices for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of TtsVoiceEntityListing</returns>
        
        
        ApiResponse<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesWithHttpInfo (string engineId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of TTS engines enabled for org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>TtsEngineEntityListing</returns>
        
        
        TtsEngineEntityListing GetIntegrationsSpeechTtsEngines (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null);

        /// <summary>
        /// Get a list of TTS engines enabled for org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>ApiResponse of TtsEngineEntityListing</returns>
        
        
        ApiResponse<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesWithHttpInfo (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null);

        /// <summary>
        /// Get TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TtsSettings</returns>
        
        
        TtsSettings GetIntegrationsSpeechTtsSettings ();

        /// <summary>
        /// Get TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TtsSettings</returns>
        
        
        ApiResponse<TtsSettings> GetIntegrationsSpeechTtsSettingsWithHttpInfo ();

        /// <summary>
        /// Get integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>IntegrationType</returns>
        
        
        IntegrationType GetIntegrationsType (string typeId);

        /// <summary>
        /// Get integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>ApiResponse of IntegrationType</returns>
        
        
        ApiResponse<IntegrationType> GetIntegrationsTypeWithHttpInfo (string typeId);

        /// <summary>
        /// Get properties config schema for an integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>JsonSchemaDocument</returns>
        
        
        JsonSchemaDocument GetIntegrationsTypeConfigschema (string typeId, string configType);

        /// <summary>
        /// Get properties config schema for an integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>ApiResponse of JsonSchemaDocument</returns>
        
        
        ApiResponse<JsonSchemaDocument> GetIntegrationsTypeConfigschemaWithHttpInfo (string typeId, string configType);

        /// <summary>
        /// List integration types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>IntegrationTypeEntityListing</returns>
        
        
        IntegrationTypeEntityListing GetIntegrationsTypes (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List integration types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of IntegrationTypeEntityListing</returns>
        
        
        ApiResponse<IntegrationTypeEntityListing> GetIntegrationsTypesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List permitted user app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>UserAppEntityListing</returns>
        
        
        UserAppEntityListing GetIntegrationsUserapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null);

        /// <summary>
        /// List permitted user app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>ApiResponse of UserAppEntityListing</returns>
        
        
        ApiResponse<UserAppEntityListing> GetIntegrationsUserappsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null);

        /// <summary>
        /// Update an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>Integration</returns>
        
        
        Integration PatchIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null);

        /// <summary>
        /// Update an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        ApiResponse<Integration> PatchIntegrationWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null);

        /// <summary>
        /// Patch an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action PatchIntegrationsAction (string actionId, UpdateActionInput body);

        /// <summary>
        /// Patch an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> PatchIntegrationsActionWithHttpInfo (string actionId, UpdateActionInput body);

        /// <summary>
        /// Update an existing Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action PatchIntegrationsActionDraft (string actionId, UpdateDraftInput body);

        /// <summary>
        /// Update an existing Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> PatchIntegrationsActionDraftWithHttpInfo (string actionId, UpdateDraftInput body);

        /// <summary>
        /// Create an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>Integration</returns>
        
        
        Integration PostIntegrations (CreateIntegrationRequest body = null);

        /// <summary>
        /// Create an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        ApiResponse<Integration> PostIntegrationsWithHttpInfo (CreateIntegrationRequest body = null);

        /// <summary>
        /// Create a new Draft from existing Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActionDraft (string actionId);

        /// <summary>
        /// Create a new Draft from existing Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionDraftWithHttpInfo (string actionId);

        /// <summary>
        /// Publish a Draft and make it the active Action configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActionDraftPublish (string actionId, PublishDraftInput body);

        /// <summary>
        /// Publish a Draft and make it the active Action configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionDraftPublishWithHttpInfo (string actionId, PublishDraftInput body);

        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>TestExecutionResult</returns>
        
        
        TestExecutionResult PostIntegrationsActionDraftTest (string actionId, Object body);

        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>ApiResponse of TestExecutionResult</returns>
        
        
        ApiResponse<TestExecutionResult> PostIntegrationsActionDraftTestWithHttpInfo (string actionId, Object body);

        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Object</returns>
        
        
        Object PostIntegrationsActionExecute (string actionId, Object body);

        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>ApiResponse of Object</returns>
        
        
        ApiResponse<Object> PostIntegrationsActionExecuteWithHttpInfo (string actionId, Object body);

        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>TestExecutionResult</returns>
        
        
        TestExecutionResult PostIntegrationsActionTest (string actionId, Object body);

        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>ApiResponse of TestExecutionResult</returns>
        
        
        ApiResponse<TestExecutionResult> PostIntegrationsActionTestWithHttpInfo (string actionId, Object body);

        /// <summary>
        /// Create a new Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActions (PostActionInput body);

        /// <summary>
        /// Create a new Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionsWithHttpInfo (PostActionInput body);

        /// <summary>
        /// Create a new Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActionsDrafts (PostActionInput body);

        /// <summary>
        /// Create a new Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        ApiResponse<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionsDraftsWithHttpInfo (PostActionInput body);

        /// <summary>
        /// Create a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>CredentialInfo</returns>
        
        
        CredentialInfo PostIntegrationsCredentials (Credential body = null);

        /// <summary>
        /// Create a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>ApiResponse of CredentialInfo</returns>
        
        
        ApiResponse<CredentialInfo> PostIntegrationsCredentialsWithHttpInfo (Credential body = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        AsyncJob PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        ApiResponse<AsyncJob> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null);

        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        AsyncJob PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        ApiResponse<AsyncJob> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        
        /// Preview Endpoint
        void PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate (string nuanceIntegrationId, BotExecutionConfiguration settings);

        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        /// Preview Endpoint
        ApiResponse<Object> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateWithHttpInfo (string nuanceIntegrationId, BotExecutionConfiguration settings);

        /// <summary>
        /// Update integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>IntegrationConfiguration</returns>
        
        
        IntegrationConfiguration PutIntegrationConfigCurrent (string integrationId, IntegrationConfiguration body = null);

        /// <summary>
        /// Update integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>ApiResponse of IntegrationConfiguration</returns>
        
        
        ApiResponse<IntegrationConfiguration> PutIntegrationConfigCurrentWithHttpInfo (string integrationId, IntegrationConfiguration body = null);

        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns></returns>
        
        
        void PutIntegrationsBotconnectorIntegrationIdBots (string integrationId, BotList botList);

        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        ApiResponse<Object> PutIntegrationsBotconnectorIntegrationIdBotsWithHttpInfo (string integrationId, BotList botList);

        /// <summary>
        /// Update a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>CredentialInfo</returns>
        
        
        CredentialInfo PutIntegrationsCredential (string credentialId, Credential body = null);

        /// <summary>
        /// Update a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>ApiResponse of CredentialInfo</returns>
        
        
        ApiResponse<CredentialInfo> PutIntegrationsCredentialWithHttpInfo (string credentialId, Credential body = null);

        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        
        /// Preview Endpoint
        void PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings (string nuanceIntegrationId, NuanceBotLaunchSettings settings);

        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        /// Preview Endpoint
        ApiResponse<Object> PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsWithHttpInfo (string nuanceIntegrationId, NuanceBotLaunchSettings settings);

        /// <summary>
        /// Update TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>TtsSettings</returns>
        
        
        TtsSettings PutIntegrationsSpeechTtsSettings (TtsSettings body);

        /// <summary>
        /// Update TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>ApiResponse of TtsSettings</returns>
        
        
        ApiResponse<TtsSettings> PutIntegrationsSpeechTtsSettingsWithHttpInfo (TtsSettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of Integration</returns>
        
        
        System.Threading.Tasks.Task<Integration> DeleteIntegrationAsync (string integrationId);

        /// <summary>
        /// Delete integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Integration>> DeleteIntegrationAsyncWithHttpInfo (string integrationId);

        /// <summary>
        /// Delete an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of void</returns>
        
        
        System.Threading.Tasks.Task DeleteIntegrationsActionAsync (string actionId);

        /// <summary>
        /// Delete an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntegrationsActionAsyncWithHttpInfo (string actionId);

        /// <summary>
        /// Delete a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of void</returns>
        
        
        System.Threading.Tasks.Task DeleteIntegrationsActionDraftAsync (string actionId);

        /// <summary>
        /// Delete a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntegrationsActionDraftAsyncWithHttpInfo (string actionId);

        /// <summary>
        /// Delete a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of void</returns>
        
        
        System.Threading.Tasks.Task DeleteIntegrationsCredentialAsync (string credentialId);

        /// <summary>
        /// Delete a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntegrationsCredentialAsyncWithHttpInfo (string credentialId);

        /// <summary>
        /// Get integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of Integration</returns>
        
        
        System.Threading.Tasks.Task<Integration> GetIntegrationAsync (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Integration>> GetIntegrationAsyncWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of IntegrationConfiguration</returns>
        
        
        System.Threading.Tasks.Task<IntegrationConfiguration> GetIntegrationConfigCurrentAsync (string integrationId);

        /// <summary>
        /// Get integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of ApiResponse (IntegrationConfiguration)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<IntegrationConfiguration>> GetIntegrationConfigCurrentAsyncWithHttpInfo (string integrationId);

        /// <summary>
        /// List integrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of IntegrationEntityListing</returns>
        
        
        System.Threading.Tasks.Task<IntegrationEntityListing> GetIntegrationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List integrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (IntegrationEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<IntegrationEntityListing>> GetIntegrationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves a single Action matching id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> GetIntegrationsActionAsync (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieves a single Action matching id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> GetIntegrationsActionAsyncWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieve a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> GetIntegrationsActionDraftAsync (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieve a Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> GetIntegrationsActionDraftAsyncWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null);

        /// <summary>
        /// Retrieve schema for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>Task of JsonSchemaDocument</returns>
        
        
        System.Threading.Tasks.Task<JsonSchemaDocument> GetIntegrationsActionDraftSchemaAsync (string actionId, string fileName);

        /// <summary>
        /// Retrieve schema for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>Task of ApiResponse (JsonSchemaDocument)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<JsonSchemaDocument>> GetIntegrationsActionDraftSchemaAsyncWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Retrieve templates for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>Task of string</returns>
        
        
        System.Threading.Tasks.Task<string> GetIntegrationsActionDraftTemplateAsync (string actionId, string fileName);

        /// <summary>
        /// Retrieve templates for a Draft based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<string>> GetIntegrationsActionDraftTemplateAsyncWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Validate current Draft configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of DraftValidationResult</returns>
        
        
        System.Threading.Tasks.Task<DraftValidationResult> GetIntegrationsActionDraftValidationAsync (string actionId);

        /// <summary>
        /// Validate current Draft configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse (DraftValidationResult)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<DraftValidationResult>> GetIntegrationsActionDraftValidationAsyncWithHttpInfo (string actionId);

        /// <summary>
        /// Retrieve schema for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>Task of JsonSchemaDocument</returns>
        
        
        System.Threading.Tasks.Task<JsonSchemaDocument> GetIntegrationsActionSchemaAsync (string actionId, string fileName);

        /// <summary>
        /// Retrieve schema for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>Task of ApiResponse (JsonSchemaDocument)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<JsonSchemaDocument>> GetIntegrationsActionSchemaAsyncWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Retrieve text of templates for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>Task of string</returns>
        
        
        System.Threading.Tasks.Task<string> GetIntegrationsActionTemplateAsync (string actionId, string fileName);

        /// <summary>
        /// Retrieve text of templates for an action based on filename.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<string>> GetIntegrationsActionTemplateAsyncWithHttpInfo (string actionId, string fileName);

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ActionEntityListing</returns>
        
        
        System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsAsync (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>Task of CategoryEntityListing</returns>
        
        
        System.Threading.Tasks.Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null);

        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<CategoryEntityListing>> GetIntegrationsActionsCategoriesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null);

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ActionEntityListing</returns>
        
        
        System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsDraftsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null);

        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>Task of BotConnectorBot</returns>
        
        
        System.Threading.Tasks.Task<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotAsync (string integrationId, string botId, string version = null);

        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>Task of ApiResponse (BotConnectorBot)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<BotConnectorBot>> GetIntegrationsBotconnectorIntegrationIdBotAsyncWithHttpInfo (string integrationId, string botId, string version = null);

        /// <summary>
        /// Get a list of bot versions for a bot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of BotConnectorBotVersionSummaryEntityListing</returns>
        
        
        System.Threading.Tasks.Task<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsync (string integrationId, string botId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of bot versions for a bot
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (BotConnectorBotVersionSummaryEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<BotConnectorBotVersionSummaryEntityListing>> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsyncWithHttpInfo (string integrationId, string botId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>Task of BotList</returns>
        
        
        System.Threading.Tasks.Task<BotList> GetIntegrationsBotconnectorIntegrationIdBotsAsync (string integrationId);

        /// <summary>
        /// Get a list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>Task of ApiResponse (BotList)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<BotList>> GetIntegrationsBotconnectorIntegrationIdBotsAsyncWithHttpInfo (string integrationId);

        /// <summary>
        /// Get a summary list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of BotConnectorBotSummaryEntityListing</returns>
        
        
        System.Threading.Tasks.Task<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsync (string integrationId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a summary list of botConnector bots for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (BotConnectorBotSummaryEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<BotConnectorBotSummaryEntityListing>> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsyncWithHttpInfo (string integrationId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// List permitted client app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ClientAppEntityListing</returns>
        
        
        System.Threading.Tasks.Task<ClientAppEntityListing> GetIntegrationsClientappsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List permitted client app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (ClientAppEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<ClientAppEntityListing>> GetIntegrationsClientappsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// UC integration client application configuration.
        /// </summary>
        /// <remarks>
        /// This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of UCIntegrationListing</returns>
        
        
        System.Threading.Tasks.Task<UCIntegrationListing> GetIntegrationsClientappsUnifiedcommunicationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// UC integration client application configuration.
        /// </summary>
        /// <remarks>
        /// This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (UCIntegrationListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<UCIntegrationListing>> GetIntegrationsClientappsUnifiedcommunicationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get a single credential with sensitive fields redacted
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of Credential</returns>
        
        
        System.Threading.Tasks.Task<Credential> GetIntegrationsCredentialAsync (string credentialId);

        /// <summary>
        /// Get a single credential with sensitive fields redacted
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of ApiResponse (Credential)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Credential>> GetIntegrationsCredentialAsyncWithHttpInfo (string credentialId);

        /// <summary>
        /// List multiple sets of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of CredentialInfoListing</returns>
        
        
        System.Threading.Tasks.Task<CredentialInfoListing> GetIntegrationsCredentialsAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// List multiple sets of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (CredentialInfoListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<CredentialInfoListing>> GetIntegrationsCredentialsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// List all credential types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CredentialTypeListing</returns>
        
        
        System.Threading.Tasks.Task<CredentialTypeListing> GetIntegrationsCredentialsTypesAsync ();

        /// <summary>
        /// List all credential types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CredentialTypeListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<CredentialTypeListing>> GetIntegrationsCredentialsTypesAsyncWithHttpInfo ();

        /// <summary>
        /// Get details about a Dialogflow agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>Task of DialogflowAgent</returns>
        
        
        System.Threading.Tasks.Task<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentAsync (string agentId);

        /// <summary>
        /// Get details about a Dialogflow agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>Task of ApiResponse (DialogflowAgent)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<DialogflowAgent>> GetIntegrationsSpeechDialogflowAgentAsyncWithHttpInfo (string agentId);

        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>Task of DialogflowAgentSummaryEntityListing</returns>
        
        
        System.Threading.Tasks.Task<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsAsync (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>Task of ApiResponse (DialogflowAgentSummaryEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<DialogflowAgentSummaryEntityListing>> GetIntegrationsSpeechDialogflowAgentsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get details about a Lex bot alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>Task of LexBotAlias</returns>
        
        
        System.Threading.Tasks.Task<LexBotAlias> GetIntegrationsSpeechLexBotAliasAsync (string aliasId);

        /// <summary>
        /// Get details about a Lex bot alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>Task of ApiResponse (LexBotAlias)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<LexBotAlias>> GetIntegrationsSpeechLexBotAliasAsyncWithHttpInfo (string aliasId);

        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>Task of LexBotAliasEntityListing</returns>
        
        
        System.Threading.Tasks.Task<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesAsync (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null);

        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>Task of ApiResponse (LexBotAliasEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<LexBotAliasEntityListing>> GetIntegrationsSpeechLexBotBotIdAliasesAsyncWithHttpInfo (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null);

        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>Task of LexBotEntityListing</returns>
        
        
        System.Threading.Tasks.Task<LexBotEntityListing> GetIntegrationsSpeechLexBotsAsync (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>Task of ApiResponse (LexBotEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<LexBotEntityListing>> GetIntegrationsSpeechLexBotsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>Task of NuanceBot</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<NuanceBot> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotAsync (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>Task of ApiResponse (NuanceBot)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<NuanceBot>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotAsyncWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null);

        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<AsyncJob> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobAsync (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<AsyncJob>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobAsyncWithHttpInfo (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of NuanceBot</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<NuanceBot> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsAsync (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (NuanceBot)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<NuanceBot>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsAsyncWithHttpInfo (string nuanceIntegrationId, string botId, string jobId);

        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration
        /// </summary>
        /// <remarks>
        /// If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsAsync (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration
        /// </summary>
        /// <remarks>
        /// If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of ApiResponse (NuanceBotEntityListing)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<NuanceBotEntityListing>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsAsyncWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<AsyncJob> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobAsync (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<AsyncJob>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobAsyncWithHttpInfo (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsAsync (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (NuanceBotEntityListing)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<NuanceBotEntityListing>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsAsyncWithHttpInfo (string nuanceIntegrationId, string jobId);

        /// <summary>
        /// Get details about a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>Task of TtsEngineEntity</returns>
        
        
        System.Threading.Tasks.Task<TtsEngineEntity> GetIntegrationsSpeechTtsEngineAsync (string engineId, bool? includeVoices = null);

        /// <summary>
        /// Get details about a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TtsEngineEntity)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TtsEngineEntity>> GetIntegrationsSpeechTtsEngineAsyncWithHttpInfo (string engineId, bool? includeVoices = null);

        /// <summary>
        /// Get details about a specific voice for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>Task of TtsVoiceEntity</returns>
        
        
        System.Threading.Tasks.Task<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceAsync (string engineId, string voiceId);

        /// <summary>
        /// Get details about a specific voice for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>Task of ApiResponse (TtsVoiceEntity)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TtsVoiceEntity>> GetIntegrationsSpeechTtsEngineVoiceAsyncWithHttpInfo (string engineId, string voiceId);

        /// <summary>
        /// Get a list of voices for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of TtsVoiceEntityListing</returns>
        
        
        System.Threading.Tasks.Task<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesAsync (string engineId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of voices for a TTS engine
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (TtsVoiceEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TtsVoiceEntityListing>> GetIntegrationsSpeechTtsEngineVoicesAsyncWithHttpInfo (string engineId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of TTS engines enabled for org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>Task of TtsEngineEntityListing</returns>
        
        
        System.Threading.Tasks.Task<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesAsync (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null);

        /// <summary>
        /// Get a list of TTS engines enabled for org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>Task of ApiResponse (TtsEngineEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TtsEngineEntityListing>> GetIntegrationsSpeechTtsEnginesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null);

        /// <summary>
        /// Get TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TtsSettings</returns>
        
        
        System.Threading.Tasks.Task<TtsSettings> GetIntegrationsSpeechTtsSettingsAsync ();

        /// <summary>
        /// Get TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TtsSettings)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TtsSettings>> GetIntegrationsSpeechTtsSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>Task of IntegrationType</returns>
        
        
        System.Threading.Tasks.Task<IntegrationType> GetIntegrationsTypeAsync (string typeId);

        /// <summary>
        /// Get integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>Task of ApiResponse (IntegrationType)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<IntegrationType>> GetIntegrationsTypeAsyncWithHttpInfo (string typeId);

        /// <summary>
        /// Get properties config schema for an integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>Task of JsonSchemaDocument</returns>
        
        
        System.Threading.Tasks.Task<JsonSchemaDocument> GetIntegrationsTypeConfigschemaAsync (string typeId, string configType);

        /// <summary>
        /// Get properties config schema for an integration type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>Task of ApiResponse (JsonSchemaDocument)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<JsonSchemaDocument>> GetIntegrationsTypeConfigschemaAsyncWithHttpInfo (string typeId, string configType);

        /// <summary>
        /// List integration types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of IntegrationTypeEntityListing</returns>
        
        
        System.Threading.Tasks.Task<IntegrationTypeEntityListing> GetIntegrationsTypesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List integration types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (IntegrationTypeEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<IntegrationTypeEntityListing>> GetIntegrationsTypesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// List permitted user app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>Task of UserAppEntityListing</returns>
        
        
        System.Threading.Tasks.Task<UserAppEntityListing> GetIntegrationsUserappsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null);

        /// <summary>
        /// List permitted user app integrations for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>Task of ApiResponse (UserAppEntityListing)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<UserAppEntityListing>> GetIntegrationsUserappsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null);

        /// <summary>
        /// Update an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>Task of Integration</returns>
        
        
        System.Threading.Tasks.Task<Integration> PatchIntegrationAsync (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null);

        /// <summary>
        /// Update an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Integration>> PatchIntegrationAsyncWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null);

        /// <summary>
        /// Patch an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PatchIntegrationsActionAsync (string actionId, UpdateActionInput body);

        /// <summary>
        /// Patch an Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PatchIntegrationsActionAsyncWithHttpInfo (string actionId, UpdateActionInput body);

        /// <summary>
        /// Update an existing Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PatchIntegrationsActionDraftAsync (string actionId, UpdateDraftInput body);

        /// <summary>
        /// Update an existing Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PatchIntegrationsActionDraftAsyncWithHttpInfo (string actionId, UpdateDraftInput body);

        /// <summary>
        /// Create an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>Task of Integration</returns>
        
        
        System.Threading.Tasks.Task<Integration> PostIntegrationsAsync (CreateIntegrationRequest body = null);

        /// <summary>
        /// Create an integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Integration>> PostIntegrationsAsyncWithHttpInfo (CreateIntegrationRequest body = null);

        /// <summary>
        /// Create a new Draft from existing Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionDraftAsync (string actionId);

        /// <summary>
        /// Create a new Draft from existing Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionDraftAsyncWithHttpInfo (string actionId);

        /// <summary>
        /// Publish a Draft and make it the active Action configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionDraftPublishAsync (string actionId, PublishDraftInput body);

        /// <summary>
        /// Publish a Draft and make it the active Action configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionDraftPublishAsyncWithHttpInfo (string actionId, PublishDraftInput body);

        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of TestExecutionResult</returns>
        
        
        System.Threading.Tasks.Task<TestExecutionResult> PostIntegrationsActionDraftTestAsync (string actionId, Object body);

        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of ApiResponse (TestExecutionResult)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TestExecutionResult>> PostIntegrationsActionDraftTestAsyncWithHttpInfo (string actionId, Object body);

        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of Object</returns>
        
        
        System.Threading.Tasks.Task<Object> PostIntegrationsActionExecuteAsync (string actionId, Object body);

        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostIntegrationsActionExecuteAsyncWithHttpInfo (string actionId, Object body);

        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of TestExecutionResult</returns>
        
        
        System.Threading.Tasks.Task<TestExecutionResult> PostIntegrationsActionTestAsync (string actionId, Object body);

        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of ApiResponse (TestExecutionResult)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TestExecutionResult>> PostIntegrationsActionTestAsyncWithHttpInfo (string actionId, Object body);

        /// <summary>
        /// Create a new Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionsAsync (PostActionInput body);

        /// <summary>
        /// Create a new Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionsAsyncWithHttpInfo (PostActionInput body);

        /// <summary>
        /// Create a new Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionsDraftsAsync (PostActionInput body);

        /// <summary>
        /// Create a new Draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionsDraftsAsyncWithHttpInfo (PostActionInput body);

        /// <summary>
        /// Create a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of CredentialInfo</returns>
        
        
        System.Threading.Tasks.Task<CredentialInfo> PostIntegrationsCredentialsAsync (Credential body = null);

        /// <summary>
        /// Create a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of ApiResponse (CredentialInfo)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<CredentialInfo>> PostIntegrationsCredentialsAsyncWithHttpInfo (Credential body = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<AsyncJob> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsync (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null);

        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<AsyncJob>> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsyncWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null);

        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<AsyncJob> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsAsync (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<AsyncJob>> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsAsyncWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null);

        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of void</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateAsync (string nuanceIntegrationId, BotExecutionConfiguration settings);

        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<Object>> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateAsyncWithHttpInfo (string nuanceIntegrationId, BotExecutionConfiguration settings);

        /// <summary>
        /// Update integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>Task of IntegrationConfiguration</returns>
        
        
        System.Threading.Tasks.Task<IntegrationConfiguration> PutIntegrationConfigCurrentAsync (string integrationId, IntegrationConfiguration body = null);

        /// <summary>
        /// Update integration configuration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>Task of ApiResponse (IntegrationConfiguration)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<IntegrationConfiguration>> PutIntegrationConfigCurrentAsyncWithHttpInfo (string integrationId, IntegrationConfiguration body = null);

        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns>Task of void</returns>
        
        
        System.Threading.Tasks.Task PutIntegrationsBotconnectorIntegrationIdBotsAsync (string integrationId, BotList botList);

        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns>Task of ApiResponse</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PutIntegrationsBotconnectorIntegrationIdBotsAsyncWithHttpInfo (string integrationId, BotList botList);

        /// <summary>
        /// Update a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of CredentialInfo</returns>
        
        
        System.Threading.Tasks.Task<CredentialInfo> PutIntegrationsCredentialAsync (string credentialId, Credential body = null);

        /// <summary>
        /// Update a set of credentials
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of ApiResponse (CredentialInfo)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<CredentialInfo>> PutIntegrationsCredentialAsyncWithHttpInfo (string credentialId, Credential body = null);

        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of void</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsAsync (string nuanceIntegrationId, NuanceBotLaunchSettings settings);

        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        
        /// Preview Endpoint
        System.Threading.Tasks.Task<ApiResponse<Object>> PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsAsyncWithHttpInfo (string nuanceIntegrationId, NuanceBotLaunchSettings settings);

        /// <summary>
        /// Update TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>Task of TtsSettings</returns>
        
        
        System.Threading.Tasks.Task<TtsSettings> PutIntegrationsSpeechTtsSettingsAsync (TtsSettings body);

        /// <summary>
        /// Update TTS settings for an org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>Task of ApiResponse (TtsSettings)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<TtsSettings>> PutIntegrationsSpeechTtsSettingsAsyncWithHttpInfo (TtsSettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IntegrationsApi : IIntegrationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntegrationsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IntegrationsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Integration</returns>
        
        
        public Integration DeleteIntegration (string integrationId)
        {
             ApiResponse<Integration> localVarResponse = DeleteIntegrationWithHttpInfo(integrationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        public ApiResponse< Integration > DeleteIntegrationWithHttpInfo (string integrationId)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->DeleteIntegration");

            var localVarPath = "/api/v2/integrations/{integrationId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of Integration</returns>
        
        
        public async System.Threading.Tasks.Task<Integration> DeleteIntegrationAsync (string integrationId)
        {
             ApiResponse<Integration> localVarResponse = await DeleteIntegrationAsyncWithHttpInfo(integrationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Integration>> DeleteIntegrationAsyncWithHttpInfo (string integrationId)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->DeleteIntegration");
            

            var localVarPath = "/api/v2/integrations/{integrationId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns></returns>
        
        
        public void DeleteIntegrationsAction (string actionId)
        {
             DeleteIntegrationsActionWithHttpInfo(actionId);
        }

        /// <summary>
        /// Delete an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        public ApiResponse<Object> DeleteIntegrationsActionWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->DeleteIntegrationsAction");

            var localVarPath = "/api/v2/integrations/actions/{actionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of void</returns>
        
        
        public async System.Threading.Tasks.Task DeleteIntegrationsActionAsync (string actionId)
        {
             await DeleteIntegrationsActionAsyncWithHttpInfo(actionId);

        }

        /// <summary>
        /// Delete an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntegrationsActionAsyncWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->DeleteIntegrationsAction");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns></returns>
        
        
        public void DeleteIntegrationsActionDraft (string actionId)
        {
             DeleteIntegrationsActionDraftWithHttpInfo(actionId);
        }

        /// <summary>
        /// Delete a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        public ApiResponse<Object> DeleteIntegrationsActionDraftWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->DeleteIntegrationsActionDraft");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of void</returns>
        
        
        public async System.Threading.Tasks.Task DeleteIntegrationsActionDraftAsync (string actionId)
        {
             await DeleteIntegrationsActionDraftAsyncWithHttpInfo(actionId);

        }

        /// <summary>
        /// Delete a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntegrationsActionDraftAsyncWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->DeleteIntegrationsActionDraft");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns></returns>
        
        
        public void DeleteIntegrationsCredential (string credentialId)
        {
             DeleteIntegrationsCredentialWithHttpInfo(credentialId);
        }

        /// <summary>
        /// Delete a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        public ApiResponse<Object> DeleteIntegrationsCredentialWithHttpInfo (string credentialId)
        { 
            // verify the required parameter 'credentialId' is set
            if (credentialId == null)
                throw new ApiException(400, "Missing required parameter 'credentialId' when calling IntegrationsApi->DeleteIntegrationsCredential");

            var localVarPath = "/api/v2/integrations/credentials/{credentialId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (credentialId != null) localVarPathParams.Add("credentialId", this.Configuration.ApiClient.ParameterToString(credentialId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsCredential: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsCredential: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of void</returns>
        
        
        public async System.Threading.Tasks.Task DeleteIntegrationsCredentialAsync (string credentialId)
        {
             await DeleteIntegrationsCredentialAsyncWithHttpInfo(credentialId);

        }

        /// <summary>
        /// Delete a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntegrationsCredentialAsyncWithHttpInfo (string credentialId)
        { 
            // verify the required parameter 'credentialId' is set
            if (credentialId == null)
                throw new ApiException(400, "Missing required parameter 'credentialId' when calling IntegrationsApi->DeleteIntegrationsCredential");
            

            var localVarPath = "/api/v2/integrations/credentials/{credentialId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (credentialId != null) localVarPathParams.Add("credentialId", this.Configuration.ApiClient.ParameterToString(credentialId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsCredential: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntegrationsCredential: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Integration</returns>
        
        
        public Integration GetIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<Integration> localVarResponse = GetIntegrationWithHttpInfo(integrationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        public ApiResponse< Integration > GetIntegrationWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegration");

            var localVarPath = "/api/v2/integrations/{integrationId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of Integration</returns>
        
        
        public async System.Threading.Tasks.Task<Integration> GetIntegrationAsync (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<Integration> localVarResponse = await GetIntegrationAsyncWithHttpInfo(integrationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Integration>> GetIntegrationAsyncWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegration");
            

            var localVarPath = "/api/v2/integrations/{integrationId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>IntegrationConfiguration</returns>
        
        
        public IntegrationConfiguration GetIntegrationConfigCurrent (string integrationId)
        {
             ApiResponse<IntegrationConfiguration> localVarResponse = GetIntegrationConfigCurrentWithHttpInfo(integrationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>ApiResponse of IntegrationConfiguration</returns>
        
        
        public ApiResponse< IntegrationConfiguration > GetIntegrationConfigCurrentWithHttpInfo (string integrationId)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationConfigCurrent");

            var localVarPath = "/api/v2/integrations/{integrationId}/config/current";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationConfigCurrent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationConfigCurrent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationConfiguration>(localVarStatusCode,
                localVarHeaders,
                (IntegrationConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of IntegrationConfiguration</returns>
        
        
        public async System.Threading.Tasks.Task<IntegrationConfiguration> GetIntegrationConfigCurrentAsync (string integrationId)
        {
             ApiResponse<IntegrationConfiguration> localVarResponse = await GetIntegrationConfigCurrentAsyncWithHttpInfo(integrationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <returns>Task of ApiResponse (IntegrationConfiguration)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationConfiguration>> GetIntegrationConfigCurrentAsyncWithHttpInfo (string integrationId)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationConfigCurrent");
            

            var localVarPath = "/api/v2/integrations/{integrationId}/config/current";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationConfigCurrent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationConfigCurrent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationConfiguration>(localVarStatusCode,
                localVarHeaders,
                (IntegrationConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List integrations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>IntegrationEntityListing</returns>
        
        
        public IntegrationEntityListing GetIntegrations (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<IntegrationEntityListing> localVarResponse = GetIntegrationsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List integrations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of IntegrationEntityListing</returns>
        
        
        public ApiResponse< IntegrationEntityListing > GetIntegrationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (IntegrationEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List integrations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of IntegrationEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<IntegrationEntityListing> GetIntegrationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<IntegrationEntityListing> localVarResponse = await GetIntegrationsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List integrations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (IntegrationEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationEntityListing>> GetIntegrationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (IntegrationEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves a single Action matching id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action GetIntegrationsAction (string actionId, string expand = null, bool? includeConfig = null)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = GetIntegrationsActionWithHttpInfo(actionId, expand, includeConfig);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a single Action matching id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > GetIntegrationsActionWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsAction");

            var localVarPath = "/api/v2/integrations/actions/{actionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", this.Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves a single Action matching id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> GetIntegrationsActionAsync (string actionId, string expand = null, bool? includeConfig = null)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await GetIntegrationsActionAsyncWithHttpInfo(actionId, expand, includeConfig);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a single Action matching id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> GetIntegrationsActionAsyncWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsAction");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", this.Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action GetIntegrationsActionDraft (string actionId, string expand = null, bool? includeConfig = null)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = GetIntegrationsActionDraftWithHttpInfo(actionId, expand, includeConfig);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > GetIntegrationsActionDraftWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraft");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", this.Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> GetIntegrationsActionDraftAsync (string actionId, string expand = null, bool? includeConfig = null)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await GetIntegrationsActionDraftAsyncWithHttpInfo(actionId, expand, includeConfig);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Return config in response. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> GetIntegrationsActionDraftAsyncWithHttpInfo (string actionId, string expand = null, bool? includeConfig = null)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraft");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", this.Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve schema for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>JsonSchemaDocument</returns>
        
        
        public JsonSchemaDocument GetIntegrationsActionDraftSchema (string actionId, string fileName)
        {
             ApiResponse<JsonSchemaDocument> localVarResponse = GetIntegrationsActionDraftSchemaWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve schema for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>ApiResponse of JsonSchemaDocument</returns>
        
        
        public ApiResponse< JsonSchemaDocument > GetIntegrationsActionDraftSchemaWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraftSchema");
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionDraftSchema");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/schemas/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve schema for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>Task of JsonSchemaDocument</returns>
        
        
        public async System.Threading.Tasks.Task<JsonSchemaDocument> GetIntegrationsActionDraftSchemaAsync (string actionId, string fileName)
        {
             ApiResponse<JsonSchemaDocument> localVarResponse = await GetIntegrationsActionDraftSchemaAsyncWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve schema for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this draft.</param>
        /// <returns>Task of ApiResponse (JsonSchemaDocument)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<JsonSchemaDocument>> GetIntegrationsActionDraftSchemaAsyncWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraftSchema");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionDraftSchema");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/schemas/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve templates for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>string</returns>
        
        
        public string GetIntegrationsActionDraftTemplate (string actionId, string fileName)
        {
             ApiResponse<string> localVarResponse = GetIntegrationsActionDraftTemplateWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve templates for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>ApiResponse of string</returns>
        
        
        public ApiResponse< string > GetIntegrationsActionDraftTemplateWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraftTemplate");
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionDraftTemplate");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/templates/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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

                "text/plain"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve templates for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>Task of string</returns>
        
        
        public async System.Threading.Tasks.Task<string> GetIntegrationsActionDraftTemplateAsync (string actionId, string fileName)
        {
             ApiResponse<string> localVarResponse = await GetIntegrationsActionDraftTemplateAsyncWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve templates for a Draft based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action draft.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetIntegrationsActionDraftTemplateAsyncWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraftTemplate");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionDraftTemplate");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/templates/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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

                "text/plain"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Validate current Draft configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>DraftValidationResult</returns>
        
        
        public DraftValidationResult GetIntegrationsActionDraftValidation (string actionId)
        {
             ApiResponse<DraftValidationResult> localVarResponse = GetIntegrationsActionDraftValidationWithHttpInfo(actionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate current Draft configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of DraftValidationResult</returns>
        
        
        public ApiResponse< DraftValidationResult > GetIntegrationsActionDraftValidationWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraftValidation");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/validation";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DraftValidationResult>(localVarStatusCode,
                localVarHeaders,
                (DraftValidationResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DraftValidationResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Validate current Draft configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of DraftValidationResult</returns>
        
        
        public async System.Threading.Tasks.Task<DraftValidationResult> GetIntegrationsActionDraftValidationAsync (string actionId)
        {
             ApiResponse<DraftValidationResult> localVarResponse = await GetIntegrationsActionDraftValidationAsyncWithHttpInfo(actionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate current Draft configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse (DraftValidationResult)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<DraftValidationResult>> GetIntegrationsActionDraftValidationAsyncWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionDraftValidation");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/validation";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DraftValidationResult>(localVarStatusCode,
                localVarHeaders,
                (DraftValidationResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DraftValidationResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve schema for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>JsonSchemaDocument</returns>
        
        
        public JsonSchemaDocument GetIntegrationsActionSchema (string actionId, string fileName)
        {
             ApiResponse<JsonSchemaDocument> localVarResponse = GetIntegrationsActionSchemaWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve schema for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>ApiResponse of JsonSchemaDocument</returns>
        
        
        public ApiResponse< JsonSchemaDocument > GetIntegrationsActionSchemaWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionSchema");
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionSchema");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/schemas/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve schema for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>Task of JsonSchemaDocument</returns>
        
        
        public async System.Threading.Tasks.Task<JsonSchemaDocument> GetIntegrationsActionSchemaAsync (string actionId, string fileName)
        {
             ApiResponse<JsonSchemaDocument> localVarResponse = await GetIntegrationsActionSchemaAsyncWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve schema for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of schema file to be retrieved for this action.</param>
        /// <returns>Task of ApiResponse (JsonSchemaDocument)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<JsonSchemaDocument>> GetIntegrationsActionSchemaAsyncWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionSchema");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionSchema");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/schemas/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve text of templates for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>string</returns>
        
        
        public string GetIntegrationsActionTemplate (string actionId, string fileName)
        {
             ApiResponse<string> localVarResponse = GetIntegrationsActionTemplateWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve text of templates for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>ApiResponse of string</returns>
        
        
        public ApiResponse< string > GetIntegrationsActionTemplateWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionTemplate");
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionTemplate");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/templates/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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

                "text/plain"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve text of templates for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>Task of string</returns>
        
        
        public async System.Threading.Tasks.Task<string> GetIntegrationsActionTemplateAsync (string actionId, string fileName)
        {
             ApiResponse<string> localVarResponse = await GetIntegrationsActionTemplateAsyncWithHttpInfo(actionId, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve text of templates for an action based on filename. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="fileName">Name of template file to be retrieved for this action.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetIntegrationsActionTemplateAsyncWithHttpInfo (string actionId, string fileName)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->GetIntegrationsActionTemplate");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling IntegrationsApi->GetIntegrationsActionTemplate");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/templates/{fileName}";
            var localVarPathParams = new Dictionary<String, String>();
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

                "text/plain"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", this.Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ActionEntityListing</returns>
        
        
        public ActionEntityListing GetIntegrationsActions (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = GetIntegrationsActionsWithHttpInfo(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, category, name, ids, secure, includeAuthActions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        
        
        public ApiResponse< ActionEntityListing > GetIntegrationsActionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        { 

            var localVarPath = "/api/v2/integrations/actions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", this.Configuration.ApiClient.ParameterToString(category)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", this.Configuration.ApiClient.ParameterToString(secure)));
            if (includeAuthActions != null) localVarQueryParams.Add(new Tuple<string, string>("includeAuthActions", this.Configuration.ApiClient.ParameterToString(includeAuthActions)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ActionEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsAsync (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = await GetIntegrationsActionsAsyncWithHttpInfo(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, category, name, ids, secure, includeAuthActions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        { 

            var localVarPath = "/api/v2/integrations/actions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", this.Configuration.ApiClient.ParameterToString(category)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", this.Configuration.ApiClient.ParameterToString(secure)));
            if (includeAuthActions != null) localVarQueryParams.Add(new Tuple<string, string>("includeAuthActions", this.Configuration.ApiClient.ParameterToString(includeAuthActions)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>CategoryEntityListing</returns>
        
        
        public CategoryEntityListing GetIntegrationsActionsCategories (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null)
        {
             ApiResponse<CategoryEntityListing> localVarResponse = GetIntegrationsActionsCategoriesWithHttpInfo(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, secure);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>ApiResponse of CategoryEntityListing</returns>
        
        
        public ApiResponse< CategoryEntityListing > GetIntegrationsActionsCategoriesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null)
        { 

            var localVarPath = "/api/v2/integrations/actions/categories";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", this.Configuration.ApiClient.ParameterToString(secure)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CategoryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>Task of CategoryEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null)
        {
             ApiResponse<CategoryEntityListing> localVarResponse = await GetIntegrationsActionsCategoriesAsyncWithHttpInfo(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, secure);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<CategoryEntityListing>> GetIntegrationsActionsCategoriesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null)
        { 

            var localVarPath = "/api/v2/integrations/actions/categories";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", this.Configuration.ApiClient.ParameterToString(secure)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CategoryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ActionEntityListing</returns>
        
        
        public ActionEntityListing GetIntegrationsActionsDrafts (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = GetIntegrationsActionsDraftsWithHttpInfo(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, category, name, ids, secure, includeAuthActions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        
        
        public ApiResponse< ActionEntityListing > GetIntegrationsActionsDraftsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        { 

            var localVarPath = "/api/v2/integrations/actions/drafts";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", this.Configuration.ApiClient.ParameterToString(category)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", this.Configuration.ApiClient.ParameterToString(secure)));
            if (includeAuthActions != null) localVarQueryParams.Add(new Tuple<string, string>("includeAuthActions", this.Configuration.ApiClient.ParameterToString(includeAuthActions)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ActionEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = await GetIntegrationsActionsDraftsAsyncWithHttpInfo(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, category, name, ids, secure, includeAuthActions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="sortBy">Root level field name to sort on. (optional)</param>
        /// <param name="sortOrder">Direction to sort &#39;sortBy&#39; field. (optional, default to asc)</param>
        /// <param name="category">Filter by category name. (optional)</param>
        /// <param name="name">Filter by partial or complete action name. (optional)</param>
        /// <param name="ids">Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional)</param>
        /// <param name="secure">Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="includeAuthActions">Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsDraftsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)
        { 

            var localVarPath = "/api/v2/integrations/actions/drafts";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", this.Configuration.ApiClient.ParameterToString(category)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(ids)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", this.Configuration.ApiClient.ParameterToString(secure)));
            if (includeAuthActions != null) localVarQueryParams.Add(new Tuple<string, string>("includeAuthActions", this.Configuration.ApiClient.ParameterToString(includeAuthActions)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>BotConnectorBot</returns>
        
        
        public BotConnectorBot GetIntegrationsBotconnectorIntegrationIdBot (string integrationId, string botId, string version = null)
        {
             ApiResponse<BotConnectorBot> localVarResponse = GetIntegrationsBotconnectorIntegrationIdBotWithHttpInfo(integrationId, botId, version);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>ApiResponse of BotConnectorBot</returns>
        
        
        public ApiResponse< BotConnectorBot > GetIntegrationsBotconnectorIntegrationIdBotWithHttpInfo (string integrationId, string botId, string version = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBot");
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBot");

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots/{botId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

            // Query params
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", this.Configuration.ApiClient.ParameterToString(version)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotConnectorBot>(localVarStatusCode,
                localVarHeaders,
                (BotConnectorBot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotConnectorBot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>Task of BotConnectorBot</returns>
        
        
        public async System.Threading.Tasks.Task<BotConnectorBot> GetIntegrationsBotconnectorIntegrationIdBotAsync (string integrationId, string botId, string version = null)
        {
             ApiResponse<BotConnectorBot> localVarResponse = await GetIntegrationsBotconnectorIntegrationIdBotAsyncWithHttpInfo(integrationId, botId, version);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific botConnector bot, plus versions, for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="version">Specific Version (optional)</param>
        /// <returns>Task of ApiResponse (BotConnectorBot)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<BotConnectorBot>> GetIntegrationsBotconnectorIntegrationIdBotAsyncWithHttpInfo (string integrationId, string botId, string version = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBot");
            
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBot");
            

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots/{botId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

            // Query params
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", this.Configuration.ApiClient.ParameterToString(version)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotConnectorBot>(localVarStatusCode,
                localVarHeaders,
                (BotConnectorBot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotConnectorBot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of bot versions for a bot 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>BotConnectorBotVersionSummaryEntityListing</returns>
        
        
        public BotConnectorBotVersionSummaryEntityListing GetIntegrationsBotconnectorIntegrationIdBotVersions (string integrationId, string botId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<BotConnectorBotVersionSummaryEntityListing> localVarResponse = GetIntegrationsBotconnectorIntegrationIdBotVersionsWithHttpInfo(integrationId, botId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of bot versions for a bot 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of BotConnectorBotVersionSummaryEntityListing</returns>
        
        
        public ApiResponse< BotConnectorBotVersionSummaryEntityListing > GetIntegrationsBotconnectorIntegrationIdBotVersionsWithHttpInfo (string integrationId, string botId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBotVersions");
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBotVersions");

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots/{botId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotConnectorBotVersionSummaryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (BotConnectorBotVersionSummaryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotConnectorBotVersionSummaryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of bot versions for a bot 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of BotConnectorBotVersionSummaryEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<BotConnectorBotVersionSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsync (string integrationId, string botId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<BotConnectorBotVersionSummaryEntityListing> localVarResponse = await GetIntegrationsBotconnectorIntegrationIdBotVersionsAsyncWithHttpInfo(integrationId, botId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of bot versions for a bot 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this bot group</param>
        /// <param name="botId">The botID for this bot</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (BotConnectorBotVersionSummaryEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<BotConnectorBotVersionSummaryEntityListing>> GetIntegrationsBotconnectorIntegrationIdBotVersionsAsyncWithHttpInfo (string integrationId, string botId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBotVersions");
            
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBotVersions");
            

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots/{botId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotConnectorBotVersionSummaryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (BotConnectorBotVersionSummaryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotConnectorBotVersionSummaryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>BotList</returns>
        
        
        public BotList GetIntegrationsBotconnectorIntegrationIdBots (string integrationId)
        {
             ApiResponse<BotList> localVarResponse = GetIntegrationsBotconnectorIntegrationIdBotsWithHttpInfo(integrationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>ApiResponse of BotList</returns>
        
        
        public ApiResponse< BotList > GetIntegrationsBotconnectorIntegrationIdBotsWithHttpInfo (string integrationId)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBots");

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotList>(localVarStatusCode,
                localVarHeaders,
                (BotList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>Task of BotList</returns>
        
        
        public async System.Threading.Tasks.Task<BotList> GetIntegrationsBotconnectorIntegrationIdBotsAsync (string integrationId)
        {
             ApiResponse<BotList> localVarResponse = await GetIntegrationsBotconnectorIntegrationIdBotsAsyncWithHttpInfo(integrationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <returns>Task of ApiResponse (BotList)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<BotList>> GetIntegrationsBotconnectorIntegrationIdBotsAsyncWithHttpInfo (string integrationId)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBots");
            

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotList>(localVarStatusCode,
                localVarHeaders,
                (BotList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a summary list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>BotConnectorBotSummaryEntityListing</returns>
        
        
        public BotConnectorBotSummaryEntityListing GetIntegrationsBotconnectorIntegrationIdBotsSummaries (string integrationId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<BotConnectorBotSummaryEntityListing> localVarResponse = GetIntegrationsBotconnectorIntegrationIdBotsSummariesWithHttpInfo(integrationId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a summary list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of BotConnectorBotSummaryEntityListing</returns>
        
        
        public ApiResponse< BotConnectorBotSummaryEntityListing > GetIntegrationsBotconnectorIntegrationIdBotsSummariesWithHttpInfo (string integrationId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBotsSummaries");

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots/summaries";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotsSummaries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotsSummaries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotConnectorBotSummaryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (BotConnectorBotSummaryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotConnectorBotSummaryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a summary list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of BotConnectorBotSummaryEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<BotConnectorBotSummaryEntityListing> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsync (string integrationId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<BotConnectorBotSummaryEntityListing> localVarResponse = await GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsyncWithHttpInfo(integrationId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a summary list of botConnector bots for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (BotConnectorBotSummaryEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<BotConnectorBotSummaryEntityListing>> GetIntegrationsBotconnectorIntegrationIdBotsSummariesAsyncWithHttpInfo (string integrationId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->GetIntegrationsBotconnectorIntegrationIdBotsSummaries");
            

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots/summaries";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotsSummaries: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsBotconnectorIntegrationIdBotsSummaries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BotConnectorBotSummaryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (BotConnectorBotSummaryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BotConnectorBotSummaryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List permitted client app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ClientAppEntityListing</returns>
        
        
        public ClientAppEntityListing GetIntegrationsClientapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<ClientAppEntityListing> localVarResponse = GetIntegrationsClientappsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List permitted client app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of ClientAppEntityListing</returns>
        
        
        public ApiResponse< ClientAppEntityListing > GetIntegrationsClientappsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations/clientapps";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientapps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientapps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ClientAppEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ClientAppEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClientAppEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List permitted client app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ClientAppEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<ClientAppEntityListing> GetIntegrationsClientappsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<ClientAppEntityListing> localVarResponse = await GetIntegrationsClientappsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List permitted client app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (ClientAppEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<ClientAppEntityListing>> GetIntegrationsClientappsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations/clientapps";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientapps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientapps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ClientAppEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ClientAppEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClientAppEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// UC integration client application configuration. This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>UCIntegrationListing</returns>
        
        
        public UCIntegrationListing GetIntegrationsClientappsUnifiedcommunications (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<UCIntegrationListing> localVarResponse = GetIntegrationsClientappsUnifiedcommunicationsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// UC integration client application configuration. This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of UCIntegrationListing</returns>
        
        
        public ApiResponse< UCIntegrationListing > GetIntegrationsClientappsUnifiedcommunicationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations/clientapps/unifiedcommunications";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientappsUnifiedcommunications: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientappsUnifiedcommunications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UCIntegrationListing>(localVarStatusCode,
                localVarHeaders,
                (UCIntegrationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UCIntegrationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// UC integration client application configuration. This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of UCIntegrationListing</returns>
        
        
        public async System.Threading.Tasks.Task<UCIntegrationListing> GetIntegrationsClientappsUnifiedcommunicationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<UCIntegrationListing> localVarResponse = await GetIntegrationsClientappsUnifiedcommunicationsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// UC integration client application configuration. This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (UCIntegrationListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<UCIntegrationListing>> GetIntegrationsClientappsUnifiedcommunicationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations/clientapps/unifiedcommunications";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientappsUnifiedcommunications: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsClientappsUnifiedcommunications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UCIntegrationListing>(localVarStatusCode,
                localVarHeaders,
                (UCIntegrationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UCIntegrationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single credential with sensitive fields redacted 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Credential</returns>
        
        
        public Credential GetIntegrationsCredential (string credentialId)
        {
             ApiResponse<Credential> localVarResponse = GetIntegrationsCredentialWithHttpInfo(credentialId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single credential with sensitive fields redacted 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>ApiResponse of Credential</returns>
        
        
        public ApiResponse< Credential > GetIntegrationsCredentialWithHttpInfo (string credentialId)
        { 
            // verify the required parameter 'credentialId' is set
            if (credentialId == null)
                throw new ApiException(400, "Missing required parameter 'credentialId' when calling IntegrationsApi->GetIntegrationsCredential");

            var localVarPath = "/api/v2/integrations/credentials/{credentialId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (credentialId != null) localVarPathParams.Add("credentialId", this.Configuration.ApiClient.ParameterToString(credentialId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredential: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredential: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Credential>(localVarStatusCode,
                localVarHeaders,
                (Credential) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Credential)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single credential with sensitive fields redacted 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of Credential</returns>
        
        
        public async System.Threading.Tasks.Task<Credential> GetIntegrationsCredentialAsync (string credentialId)
        {
             ApiResponse<Credential> localVarResponse = await GetIntegrationsCredentialAsyncWithHttpInfo(credentialId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single credential with sensitive fields redacted 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <returns>Task of ApiResponse (Credential)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Credential>> GetIntegrationsCredentialAsyncWithHttpInfo (string credentialId)
        { 
            // verify the required parameter 'credentialId' is set
            if (credentialId == null)
                throw new ApiException(400, "Missing required parameter 'credentialId' when calling IntegrationsApi->GetIntegrationsCredential");
            

            var localVarPath = "/api/v2/integrations/credentials/{credentialId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (credentialId != null) localVarPathParams.Add("credentialId", this.Configuration.ApiClient.ParameterToString(credentialId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredential: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredential: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Credential>(localVarStatusCode,
                localVarHeaders,
                (Credential) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Credential)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List multiple sets of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>CredentialInfoListing</returns>
        
        
        public CredentialInfoListing GetIntegrationsCredentials (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<CredentialInfoListing> localVarResponse = GetIntegrationsCredentialsWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List multiple sets of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of CredentialInfoListing</returns>
        
        
        public ApiResponse< CredentialInfoListing > GetIntegrationsCredentialsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/integrations/credentials";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentials: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentials: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialInfoListing>(localVarStatusCode,
                localVarHeaders,
                (CredentialInfoListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialInfoListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List multiple sets of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of CredentialInfoListing</returns>
        
        
        public async System.Threading.Tasks.Task<CredentialInfoListing> GetIntegrationsCredentialsAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<CredentialInfoListing> localVarResponse = await GetIntegrationsCredentialsAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List multiple sets of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (CredentialInfoListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<CredentialInfoListing>> GetIntegrationsCredentialsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/integrations/credentials";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentials: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentials: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialInfoListing>(localVarStatusCode,
                localVarHeaders,
                (CredentialInfoListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialInfoListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List all credential types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CredentialTypeListing</returns>
        
        
        public CredentialTypeListing GetIntegrationsCredentialsTypes ()
        {
             ApiResponse<CredentialTypeListing> localVarResponse = GetIntegrationsCredentialsTypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all credential types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CredentialTypeListing</returns>
        
        
        public ApiResponse< CredentialTypeListing > GetIntegrationsCredentialsTypesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/integrations/credentials/types";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentialsTypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentialsTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialTypeListing>(localVarStatusCode,
                localVarHeaders,
                (CredentialTypeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialTypeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List all credential types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CredentialTypeListing</returns>
        
        
        public async System.Threading.Tasks.Task<CredentialTypeListing> GetIntegrationsCredentialsTypesAsync ()
        {
             ApiResponse<CredentialTypeListing> localVarResponse = await GetIntegrationsCredentialsTypesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all credential types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CredentialTypeListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<CredentialTypeListing>> GetIntegrationsCredentialsTypesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/integrations/credentials/types";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentialsTypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsCredentialsTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialTypeListing>(localVarStatusCode,
                localVarHeaders,
                (CredentialTypeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialTypeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get details about a Dialogflow agent 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>DialogflowAgent</returns>
        
        
        public DialogflowAgent GetIntegrationsSpeechDialogflowAgent (string agentId)
        {
             ApiResponse<DialogflowAgent> localVarResponse = GetIntegrationsSpeechDialogflowAgentWithHttpInfo(agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about a Dialogflow agent 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>ApiResponse of DialogflowAgent</returns>
        
        
        public ApiResponse< DialogflowAgent > GetIntegrationsSpeechDialogflowAgentWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling IntegrationsApi->GetIntegrationsSpeechDialogflowAgent");

            var localVarPath = "/api/v2/integrations/speech/dialogflow/agents/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialogflowAgent>(localVarStatusCode,
                localVarHeaders,
                (DialogflowAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialogflowAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get details about a Dialogflow agent 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>Task of DialogflowAgent</returns>
        
        
        public async System.Threading.Tasks.Task<DialogflowAgent> GetIntegrationsSpeechDialogflowAgentAsync (string agentId)
        {
             ApiResponse<DialogflowAgent> localVarResponse = await GetIntegrationsSpeechDialogflowAgentAsyncWithHttpInfo(agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about a Dialogflow agent 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId">The agent ID</param>
        /// <returns>Task of ApiResponse (DialogflowAgent)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<DialogflowAgent>> GetIntegrationsSpeechDialogflowAgentAsyncWithHttpInfo (string agentId)
        { 
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling IntegrationsApi->GetIntegrationsSpeechDialogflowAgent");
            

            var localVarPath = "/api/v2/integrations/speech/dialogflow/agents/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialogflowAgent>(localVarStatusCode,
                localVarHeaders,
                (DialogflowAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialogflowAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>DialogflowAgentSummaryEntityListing</returns>
        
        
        public DialogflowAgentSummaryEntityListing GetIntegrationsSpeechDialogflowAgents (int? pageNumber = null, int? pageSize = null, string name = null)
        {
             ApiResponse<DialogflowAgentSummaryEntityListing> localVarResponse = GetIntegrationsSpeechDialogflowAgentsWithHttpInfo(pageNumber, pageSize, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>ApiResponse of DialogflowAgentSummaryEntityListing</returns>
        
        
        public ApiResponse< DialogflowAgentSummaryEntityListing > GetIntegrationsSpeechDialogflowAgentsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/integrations/speech/dialogflow/agents";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialogflowAgentSummaryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DialogflowAgentSummaryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialogflowAgentSummaryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>Task of DialogflowAgentSummaryEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<DialogflowAgentSummaryEntityListing> GetIntegrationsSpeechDialogflowAgentsAsync (int? pageNumber = null, int? pageSize = null, string name = null)
        {
             ApiResponse<DialogflowAgentSummaryEntityListing> localVarResponse = await GetIntegrationsSpeechDialogflowAgentsAsyncWithHttpInfo(pageNumber, pageSize, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Dialogflow agents in the customers' Google accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on agent name (optional)</param>
        /// <returns>Task of ApiResponse (DialogflowAgentSummaryEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<DialogflowAgentSummaryEntityListing>> GetIntegrationsSpeechDialogflowAgentsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/integrations/speech/dialogflow/agents";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechDialogflowAgents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialogflowAgentSummaryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DialogflowAgentSummaryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialogflowAgentSummaryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get details about a Lex bot alias 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>LexBotAlias</returns>
        
        
        public LexBotAlias GetIntegrationsSpeechLexBotAlias (string aliasId)
        {
             ApiResponse<LexBotAlias> localVarResponse = GetIntegrationsSpeechLexBotAliasWithHttpInfo(aliasId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about a Lex bot alias 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>ApiResponse of LexBotAlias</returns>
        
        
        public ApiResponse< LexBotAlias > GetIntegrationsSpeechLexBotAliasWithHttpInfo (string aliasId)
        { 
            // verify the required parameter 'aliasId' is set
            if (aliasId == null)
                throw new ApiException(400, "Missing required parameter 'aliasId' when calling IntegrationsApi->GetIntegrationsSpeechLexBotAlias");

            var localVarPath = "/api/v2/integrations/speech/lex/bot/alias/{aliasId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (aliasId != null) localVarPathParams.Add("aliasId", this.Configuration.ApiClient.ParameterToString(aliasId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotAlias: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotAlias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LexBotAlias>(localVarStatusCode,
                localVarHeaders,
                (LexBotAlias) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LexBotAlias)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get details about a Lex bot alias 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>Task of LexBotAlias</returns>
        
        
        public async System.Threading.Tasks.Task<LexBotAlias> GetIntegrationsSpeechLexBotAliasAsync (string aliasId)
        {
             ApiResponse<LexBotAlias> localVarResponse = await GetIntegrationsSpeechLexBotAliasAsyncWithHttpInfo(aliasId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about a Lex bot alias 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasId">The alias ID</param>
        /// <returns>Task of ApiResponse (LexBotAlias)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<LexBotAlias>> GetIntegrationsSpeechLexBotAliasAsyncWithHttpInfo (string aliasId)
        { 
            // verify the required parameter 'aliasId' is set
            if (aliasId == null)
                throw new ApiException(400, "Missing required parameter 'aliasId' when calling IntegrationsApi->GetIntegrationsSpeechLexBotAlias");
            

            var localVarPath = "/api/v2/integrations/speech/lex/bot/alias/{aliasId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (aliasId != null) localVarPathParams.Add("aliasId", this.Configuration.ApiClient.ParameterToString(aliasId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotAlias: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotAlias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LexBotAlias>(localVarStatusCode,
                localVarHeaders,
                (LexBotAlias) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LexBotAlias)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>LexBotAliasEntityListing</returns>
        
        
        public LexBotAliasEntityListing GetIntegrationsSpeechLexBotBotIdAliases (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)
        {
             ApiResponse<LexBotAliasEntityListing> localVarResponse = GetIntegrationsSpeechLexBotBotIdAliasesWithHttpInfo(botId, pageNumber, pageSize, status, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>ApiResponse of LexBotAliasEntityListing</returns>
        
        
        public ApiResponse< LexBotAliasEntityListing > GetIntegrationsSpeechLexBotBotIdAliasesWithHttpInfo (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)
        { 
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechLexBotBotIdAliases");

            var localVarPath = "/api/v2/integrations/speech/lex/bot/{botId}/aliases";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotBotIdAliases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotBotIdAliases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LexBotAliasEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LexBotAliasEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LexBotAliasEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>Task of LexBotAliasEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<LexBotAliasEntityListing> GetIntegrationsSpeechLexBotBotIdAliasesAsync (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)
        {
             ApiResponse<LexBotAliasEntityListing> localVarResponse = await GetIntegrationsSpeechLexBotBotIdAliasesAsyncWithHttpInfo(botId, pageNumber, pageSize, status, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of aliases for a bot in the customer's AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="status">Filter on alias status (optional)</param>
        /// <param name="name">Filter on alias name (optional)</param>
        /// <returns>Task of ApiResponse (LexBotAliasEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<LexBotAliasEntityListing>> GetIntegrationsSpeechLexBotBotIdAliasesAsyncWithHttpInfo (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)
        { 
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechLexBotBotIdAliases");
            

            var localVarPath = "/api/v2/integrations/speech/lex/bot/{botId}/aliases";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotBotIdAliases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBotBotIdAliases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LexBotAliasEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LexBotAliasEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LexBotAliasEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>LexBotEntityListing</returns>
        
        
        public LexBotEntityListing GetIntegrationsSpeechLexBots (int? pageNumber = null, int? pageSize = null, string name = null)
        {
             ApiResponse<LexBotEntityListing> localVarResponse = GetIntegrationsSpeechLexBotsWithHttpInfo(pageNumber, pageSize, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>ApiResponse of LexBotEntityListing</returns>
        
        
        public ApiResponse< LexBotEntityListing > GetIntegrationsSpeechLexBotsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/integrations/speech/lex/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LexBotEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LexBotEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LexBotEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>Task of LexBotEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<LexBotEntityListing> GetIntegrationsSpeechLexBotsAsync (int? pageNumber = null, int? pageSize = null, string name = null)
        {
             ApiResponse<LexBotEntityListing> localVarResponse = await GetIntegrationsSpeechLexBotsAsyncWithHttpInfo(pageNumber, pageSize, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Lex bots in the customers' AWS accounts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Filter on bot name (optional)</param>
        /// <returns>Task of ApiResponse (LexBotEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<LexBotEntityListing>> GetIntegrationsSpeechLexBotsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/integrations/speech/lex/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechLexBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LexBotEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LexBotEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LexBotEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Nuance bot in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>NuanceBot</returns>
        
        /// Preview Endpoint
        public NuanceBot GetIntegrationsSpeechNuanceNuanceIntegrationIdBot (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null)
        {
             ApiResponse<NuanceBot> localVarResponse = GetIntegrationsSpeechNuanceNuanceIntegrationIdBotWithHttpInfo(nuanceIntegrationId, botId, expand, targetChannel);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Nuance bot in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>ApiResponse of NuanceBot</returns>
        
        /// Preview Endpoint
        public ApiResponse< NuanceBot > GetIntegrationsSpeechNuanceNuanceIntegrationIdBotWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBot");
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBot");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (targetChannel != null) localVarQueryParams.Add(new Tuple<string, string>("targetChannel", this.Configuration.ApiClient.ParameterToString(targetChannel)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBot>(localVarStatusCode,
                localVarHeaders,
                (NuanceBot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Nuance bot in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>Task of NuanceBot</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<NuanceBot> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotAsync (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null)
        {
             ApiResponse<NuanceBot> localVarResponse = await GetIntegrationsSpeechNuanceNuanceIntegrationIdBotAsyncWithHttpInfo(nuanceIntegrationId, botId, expand, targetChannel);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Nuance bot in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID to get</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="targetChannel">targetChannel (optional)</param>
        /// <returns>Task of ApiResponse (NuanceBot)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<NuanceBot>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotAsyncWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBot");
            
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBot");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (targetChannel != null) localVarQueryParams.Add(new Tuple<string, string>("targetChannel", this.Configuration.ApiClient.ParameterToString(targetChannel)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBot: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBot>(localVarStatusCode,
                localVarHeaders,
                (NuanceBot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        public AsyncJob GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob (string nuanceIntegrationId, string botId, string jobId)
        {
             ApiResponse<AsyncJob> localVarResponse = GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobWithHttpInfo(nuanceIntegrationId, botId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        public ApiResponse< AsyncJob > GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobWithHttpInfo (string nuanceIntegrationId, string botId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob");
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<AsyncJob> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobAsync (string nuanceIntegrationId, string botId, string jobId)
        {
             ApiResponse<AsyncJob> localVarResponse = await GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobAsyncWithHttpInfo(nuanceIntegrationId, botId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<AsyncJob>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobAsyncWithHttpInfo (string nuanceIntegrationId, string botId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob");
            
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>NuanceBot</returns>
        
        /// Preview Endpoint
        public NuanceBot GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults (string nuanceIntegrationId, string botId, string jobId)
        {
             ApiResponse<NuanceBot> localVarResponse = GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsWithHttpInfo(nuanceIntegrationId, botId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of NuanceBot</returns>
        
        /// Preview Endpoint
        public ApiResponse< NuanceBot > GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsWithHttpInfo (string nuanceIntegrationId, string botId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults");
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBot>(localVarStatusCode,
                localVarHeaders,
                (NuanceBot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of NuanceBot</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<NuanceBot> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsAsync (string nuanceIntegrationId, string botId, string jobId)
        {
             ApiResponse<NuanceBot> localVarResponse = await GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsAsyncWithHttpInfo(nuanceIntegrationId, botId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the result of an asynchronous Nuance bot GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (NuanceBot)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<NuanceBot>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsAsyncWithHttpInfo (string nuanceIntegrationId, string botId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults");
            
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBot>(localVarStatusCode,
                localVarHeaders,
                (NuanceBot) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBot)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        public NuanceBotEntityListing GetIntegrationsSpeechNuanceNuanceIntegrationIdBots (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        {
             ApiResponse<NuanceBotEntityListing> localVarResponse = GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsWithHttpInfo(nuanceIntegrationId, pageNumber, pageSize, onlyRegisteredBots);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>ApiResponse of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        public ApiResponse< NuanceBotEntityListing > GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBots");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (onlyRegisteredBots != null) localVarQueryParams.Add(new Tuple<string, string>("onlyRegisteredBots", this.Configuration.ApiClient.ParameterToString(onlyRegisteredBots)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBotEntityListing>(localVarStatusCode,
                localVarHeaders,
                (NuanceBotEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBotEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsAsync (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        {
             ApiResponse<NuanceBotEntityListing> localVarResponse = await GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsAsyncWithHttpInfo(nuanceIntegrationId, pageNumber, pageSize, onlyRegisteredBots);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Nuance bots available in the specified Integration If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of ApiResponse (NuanceBotEntityListing)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<NuanceBotEntityListing>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsAsyncWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBots");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (onlyRegisteredBots != null) localVarQueryParams.Add(new Tuple<string, string>("onlyRegisteredBots", this.Configuration.ApiClient.ParameterToString(onlyRegisteredBots)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBotEntityListing>(localVarStatusCode,
                localVarHeaders,
                (NuanceBotEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBotEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        public AsyncJob GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob (string nuanceIntegrationId, string jobId)
        {
             ApiResponse<AsyncJob> localVarResponse = GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobWithHttpInfo(nuanceIntegrationId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        public ApiResponse< AsyncJob > GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobWithHttpInfo (string nuanceIntegrationId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<AsyncJob> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobAsync (string nuanceIntegrationId, string jobId)
        {
             ApiResponse<AsyncJob> localVarResponse = await GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobAsyncWithHttpInfo(nuanceIntegrationId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<AsyncJob>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobAsyncWithHttpInfo (string nuanceIntegrationId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        public NuanceBotEntityListing GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults (string nuanceIntegrationId, string jobId)
        {
             ApiResponse<NuanceBotEntityListing> localVarResponse = GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsWithHttpInfo(nuanceIntegrationId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>ApiResponse of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        public ApiResponse< NuanceBotEntityListing > GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsWithHttpInfo (string nuanceIntegrationId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBotEntityListing>(localVarStatusCode,
                localVarHeaders,
                (NuanceBotEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBotEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of NuanceBotEntityListing</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<NuanceBotEntityListing> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsAsync (string nuanceIntegrationId, string jobId)
        {
             ApiResponse<NuanceBotEntityListing> localVarResponse = await GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsAsyncWithHttpInfo(nuanceIntegrationId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the result of an asynchronous Nuance bots GET job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="jobId">The asynchronous job ID</param>
        /// <returns>Task of ApiResponse (NuanceBotEntityListing)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<NuanceBotEntityListing>> GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsAsyncWithHttpInfo (string nuanceIntegrationId, string jobId)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling IntegrationsApi->GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NuanceBotEntityListing>(localVarStatusCode,
                localVarHeaders,
                (NuanceBotEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NuanceBotEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get details about a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>TtsEngineEntity</returns>
        
        
        public TtsEngineEntity GetIntegrationsSpeechTtsEngine (string engineId, bool? includeVoices = null)
        {
             ApiResponse<TtsEngineEntity> localVarResponse = GetIntegrationsSpeechTtsEngineWithHttpInfo(engineId, includeVoices);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>ApiResponse of TtsEngineEntity</returns>
        
        
        public ApiResponse< TtsEngineEntity > GetIntegrationsSpeechTtsEngineWithHttpInfo (string engineId, bool? includeVoices = null)
        { 
            // verify the required parameter 'engineId' is set
            if (engineId == null)
                throw new ApiException(400, "Missing required parameter 'engineId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngine");

            var localVarPath = "/api/v2/integrations/speech/tts/engines/{engineId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (engineId != null) localVarPathParams.Add("engineId", this.Configuration.ApiClient.ParameterToString(engineId));

            // Query params
            if (includeVoices != null) localVarQueryParams.Add(new Tuple<string, string>("includeVoices", this.Configuration.ApiClient.ParameterToString(includeVoices)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngine: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsEngineEntity>(localVarStatusCode,
                localVarHeaders,
                (TtsEngineEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsEngineEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get details about a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>Task of TtsEngineEntity</returns>
        
        
        public async System.Threading.Tasks.Task<TtsEngineEntity> GetIntegrationsSpeechTtsEngineAsync (string engineId, bool? includeVoices = null)
        {
             ApiResponse<TtsEngineEntity> localVarResponse = await GetIntegrationsSpeechTtsEngineAsyncWithHttpInfo(engineId, includeVoices);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TtsEngineEntity)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TtsEngineEntity>> GetIntegrationsSpeechTtsEngineAsyncWithHttpInfo (string engineId, bool? includeVoices = null)
        { 
            // verify the required parameter 'engineId' is set
            if (engineId == null)
                throw new ApiException(400, "Missing required parameter 'engineId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngine");
            

            var localVarPath = "/api/v2/integrations/speech/tts/engines/{engineId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (engineId != null) localVarPathParams.Add("engineId", this.Configuration.ApiClient.ParameterToString(engineId));

            // Query params
            if (includeVoices != null) localVarQueryParams.Add(new Tuple<string, string>("includeVoices", this.Configuration.ApiClient.ParameterToString(includeVoices)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngine: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsEngineEntity>(localVarStatusCode,
                localVarHeaders,
                (TtsEngineEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsEngineEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get details about a specific voice for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>TtsVoiceEntity</returns>
        
        
        public TtsVoiceEntity GetIntegrationsSpeechTtsEngineVoice (string engineId, string voiceId)
        {
             ApiResponse<TtsVoiceEntity> localVarResponse = GetIntegrationsSpeechTtsEngineVoiceWithHttpInfo(engineId, voiceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about a specific voice for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>ApiResponse of TtsVoiceEntity</returns>
        
        
        public ApiResponse< TtsVoiceEntity > GetIntegrationsSpeechTtsEngineVoiceWithHttpInfo (string engineId, string voiceId)
        { 
            // verify the required parameter 'engineId' is set
            if (engineId == null)
                throw new ApiException(400, "Missing required parameter 'engineId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngineVoice");
            // verify the required parameter 'voiceId' is set
            if (voiceId == null)
                throw new ApiException(400, "Missing required parameter 'voiceId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngineVoice");

            var localVarPath = "/api/v2/integrations/speech/tts/engines/{engineId}/voices/{voiceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (engineId != null) localVarPathParams.Add("engineId", this.Configuration.ApiClient.ParameterToString(engineId));
            if (voiceId != null) localVarPathParams.Add("voiceId", this.Configuration.ApiClient.ParameterToString(voiceId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsVoiceEntity>(localVarStatusCode,
                localVarHeaders,
                (TtsVoiceEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsVoiceEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get details about a specific voice for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>Task of TtsVoiceEntity</returns>
        
        
        public async System.Threading.Tasks.Task<TtsVoiceEntity> GetIntegrationsSpeechTtsEngineVoiceAsync (string engineId, string voiceId)
        {
             ApiResponse<TtsVoiceEntity> localVarResponse = await GetIntegrationsSpeechTtsEngineVoiceAsyncWithHttpInfo(engineId, voiceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about a specific voice for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="voiceId">The voice ID</param>
        /// <returns>Task of ApiResponse (TtsVoiceEntity)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TtsVoiceEntity>> GetIntegrationsSpeechTtsEngineVoiceAsyncWithHttpInfo (string engineId, string voiceId)
        { 
            // verify the required parameter 'engineId' is set
            if (engineId == null)
                throw new ApiException(400, "Missing required parameter 'engineId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngineVoice");
            
            // verify the required parameter 'voiceId' is set
            if (voiceId == null)
                throw new ApiException(400, "Missing required parameter 'voiceId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngineVoice");
            

            var localVarPath = "/api/v2/integrations/speech/tts/engines/{engineId}/voices/{voiceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (engineId != null) localVarPathParams.Add("engineId", this.Configuration.ApiClient.ParameterToString(engineId));
            if (voiceId != null) localVarPathParams.Add("voiceId", this.Configuration.ApiClient.ParameterToString(voiceId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsVoiceEntity>(localVarStatusCode,
                localVarHeaders,
                (TtsVoiceEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsVoiceEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of voices for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>TtsVoiceEntityListing</returns>
        
        
        public TtsVoiceEntityListing GetIntegrationsSpeechTtsEngineVoices (string engineId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<TtsVoiceEntityListing> localVarResponse = GetIntegrationsSpeechTtsEngineVoicesWithHttpInfo(engineId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of voices for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of TtsVoiceEntityListing</returns>
        
        
        public ApiResponse< TtsVoiceEntityListing > GetIntegrationsSpeechTtsEngineVoicesWithHttpInfo (string engineId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'engineId' is set
            if (engineId == null)
                throw new ApiException(400, "Missing required parameter 'engineId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngineVoices");

            var localVarPath = "/api/v2/integrations/speech/tts/engines/{engineId}/voices";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (engineId != null) localVarPathParams.Add("engineId", this.Configuration.ApiClient.ParameterToString(engineId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsVoiceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TtsVoiceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsVoiceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of voices for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of TtsVoiceEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<TtsVoiceEntityListing> GetIntegrationsSpeechTtsEngineVoicesAsync (string engineId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<TtsVoiceEntityListing> localVarResponse = await GetIntegrationsSpeechTtsEngineVoicesAsyncWithHttpInfo(engineId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of voices for a TTS engine 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="engineId">The engine ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (TtsVoiceEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TtsVoiceEntityListing>> GetIntegrationsSpeechTtsEngineVoicesAsyncWithHttpInfo (string engineId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'engineId' is set
            if (engineId == null)
                throw new ApiException(400, "Missing required parameter 'engineId' when calling IntegrationsApi->GetIntegrationsSpeechTtsEngineVoices");
            

            var localVarPath = "/api/v2/integrations/speech/tts/engines/{engineId}/voices";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (engineId != null) localVarPathParams.Add("engineId", this.Configuration.ApiClient.ParameterToString(engineId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngineVoices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsVoiceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TtsVoiceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsVoiceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of TTS engines enabled for org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>TtsEngineEntityListing</returns>
        
        
        public TtsEngineEntityListing GetIntegrationsSpeechTtsEngines (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null)
        {
             ApiResponse<TtsEngineEntityListing> localVarResponse = GetIntegrationsSpeechTtsEnginesWithHttpInfo(pageNumber, pageSize, includeVoices, name, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of TTS engines enabled for org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>ApiResponse of TtsEngineEntityListing</returns>
        
        
        public ApiResponse< TtsEngineEntityListing > GetIntegrationsSpeechTtsEnginesWithHttpInfo (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null)
        { 

            var localVarPath = "/api/v2/integrations/speech/tts/engines";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (includeVoices != null) localVarQueryParams.Add(new Tuple<string, string>("includeVoices", this.Configuration.ApiClient.ParameterToString(includeVoices)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsEngineEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TtsEngineEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsEngineEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of TTS engines enabled for org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>Task of TtsEngineEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<TtsEngineEntityListing> GetIntegrationsSpeechTtsEnginesAsync (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null)
        {
             ApiResponse<TtsEngineEntityListing> localVarResponse = await GetIntegrationsSpeechTtsEnginesAsyncWithHttpInfo(pageNumber, pageSize, includeVoices, name, language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of TTS engines enabled for org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="includeVoices">Include voices for the engine (optional, default to false)</param>
        /// <param name="name">Filter on engine name (optional)</param>
        /// <param name="language">Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. (optional)</param>
        /// <returns>Task of ApiResponse (TtsEngineEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TtsEngineEntityListing>> GetIntegrationsSpeechTtsEnginesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null)
        { 

            var localVarPath = "/api/v2/integrations/speech/tts/engines";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (includeVoices != null) localVarQueryParams.Add(new Tuple<string, string>("includeVoices", this.Configuration.ApiClient.ParameterToString(includeVoices)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngines: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsEngines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsEngineEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TtsEngineEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsEngineEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TtsSettings</returns>
        
        
        public TtsSettings GetIntegrationsSpeechTtsSettings ()
        {
             ApiResponse<TtsSettings> localVarResponse = GetIntegrationsSpeechTtsSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TtsSettings</returns>
        
        
        public ApiResponse< TtsSettings > GetIntegrationsSpeechTtsSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/integrations/speech/tts/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsSettings>(localVarStatusCode,
                localVarHeaders,
                (TtsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TtsSettings</returns>
        
        
        public async System.Threading.Tasks.Task<TtsSettings> GetIntegrationsSpeechTtsSettingsAsync ()
        {
             ApiResponse<TtsSettings> localVarResponse = await GetIntegrationsSpeechTtsSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TtsSettings)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TtsSettings>> GetIntegrationsSpeechTtsSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/integrations/speech/tts/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsSpeechTtsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsSettings>(localVarStatusCode,
                localVarHeaders,
                (TtsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>IntegrationType</returns>
        
        
        public IntegrationType GetIntegrationsType (string typeId)
        {
             ApiResponse<IntegrationType> localVarResponse = GetIntegrationsTypeWithHttpInfo(typeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>ApiResponse of IntegrationType</returns>
        
        
        public ApiResponse< IntegrationType > GetIntegrationsTypeWithHttpInfo (string typeId)
        { 
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling IntegrationsApi->GetIntegrationsType");

            var localVarPath = "/api/v2/integrations/types/{typeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsType: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationType>(localVarStatusCode,
                localVarHeaders,
                (IntegrationType) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationType)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>Task of IntegrationType</returns>
        
        
        public async System.Threading.Tasks.Task<IntegrationType> GetIntegrationsTypeAsync (string typeId)
        {
             ApiResponse<IntegrationType> localVarResponse = await GetIntegrationsTypeAsyncWithHttpInfo(typeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <returns>Task of ApiResponse (IntegrationType)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationType>> GetIntegrationsTypeAsyncWithHttpInfo (string typeId)
        { 
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling IntegrationsApi->GetIntegrationsType");
            

            var localVarPath = "/api/v2/integrations/types/{typeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsType: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationType>(localVarStatusCode,
                localVarHeaders,
                (IntegrationType) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationType)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get properties config schema for an integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>JsonSchemaDocument</returns>
        
        
        public JsonSchemaDocument GetIntegrationsTypeConfigschema (string typeId, string configType)
        {
             ApiResponse<JsonSchemaDocument> localVarResponse = GetIntegrationsTypeConfigschemaWithHttpInfo(typeId, configType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get properties config schema for an integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>ApiResponse of JsonSchemaDocument</returns>
        
        
        public ApiResponse< JsonSchemaDocument > GetIntegrationsTypeConfigschemaWithHttpInfo (string typeId, string configType)
        { 
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling IntegrationsApi->GetIntegrationsTypeConfigschema");
            // verify the required parameter 'configType' is set
            if (configType == null)
                throw new ApiException(400, "Missing required parameter 'configType' when calling IntegrationsApi->GetIntegrationsTypeConfigschema");

            var localVarPath = "/api/v2/integrations/types/{typeId}/configschemas/{configType}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId));
            if (configType != null) localVarPathParams.Add("configType", this.Configuration.ApiClient.ParameterToString(configType));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypeConfigschema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypeConfigschema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get properties config schema for an integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>Task of JsonSchemaDocument</returns>
        
        
        public async System.Threading.Tasks.Task<JsonSchemaDocument> GetIntegrationsTypeConfigschemaAsync (string typeId, string configType)
        {
             ApiResponse<JsonSchemaDocument> localVarResponse = await GetIntegrationsTypeConfigschemaAsyncWithHttpInfo(typeId, configType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get properties config schema for an integration type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Integration Type Id</param>
        /// <param name="configType">Config schema type</param>
        /// <returns>Task of ApiResponse (JsonSchemaDocument)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<JsonSchemaDocument>> GetIntegrationsTypeConfigschemaAsyncWithHttpInfo (string typeId, string configType)
        { 
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling IntegrationsApi->GetIntegrationsTypeConfigschema");
            
            // verify the required parameter 'configType' is set
            if (configType == null)
                throw new ApiException(400, "Missing required parameter 'configType' when calling IntegrationsApi->GetIntegrationsTypeConfigschema");
            

            var localVarPath = "/api/v2/integrations/types/{typeId}/configschemas/{configType}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId));
            if (configType != null) localVarPathParams.Add("configType", this.Configuration.ApiClient.ParameterToString(configType));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypeConfigschema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypeConfigschema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List integration types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>IntegrationTypeEntityListing</returns>
        
        
        public IntegrationTypeEntityListing GetIntegrationsTypes (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<IntegrationTypeEntityListing> localVarResponse = GetIntegrationsTypesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List integration types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of IntegrationTypeEntityListing</returns>
        
        
        public ApiResponse< IntegrationTypeEntityListing > GetIntegrationsTypesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations/types";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationTypeEntityListing>(localVarStatusCode,
                localVarHeaders,
                (IntegrationTypeEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationTypeEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List integration types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of IntegrationTypeEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<IntegrationTypeEntityListing> GetIntegrationsTypesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<IntegrationTypeEntityListing> localVarResponse = await GetIntegrationsTypesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List integration types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (IntegrationTypeEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationTypeEntityListing>> GetIntegrationsTypesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 

            var localVarPath = "/api/v2/integrations/types";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationTypeEntityListing>(localVarStatusCode,
                localVarHeaders,
                (IntegrationTypeEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationTypeEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List permitted user app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>UserAppEntityListing</returns>
        
        
        public UserAppEntityListing GetIntegrationsUserapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null)
        {
             ApiResponse<UserAppEntityListing> localVarResponse = GetIntegrationsUserappsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, appHost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List permitted user app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>ApiResponse of UserAppEntityListing</returns>
        
        
        public ApiResponse< UserAppEntityListing > GetIntegrationsUserappsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null)
        { 

            var localVarPath = "/api/v2/integrations/userapps";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (appHost != null) localVarQueryParams.Add(new Tuple<string, string>("appHost", this.Configuration.ApiClient.ParameterToString(appHost)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsUserapps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsUserapps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAppEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserAppEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAppEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List permitted user app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>Task of UserAppEntityListing</returns>
        
        
        public async System.Threading.Tasks.Task<UserAppEntityListing> GetIntegrationsUserappsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null)
        {
             ApiResponse<UserAppEntityListing> localVarResponse = await GetIntegrationsUserappsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, appHost);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List permitted user app integrations for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="appHost">The type of UserApp to filter by (optional)</param>
        /// <returns>Task of ApiResponse (UserAppEntityListing)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<UserAppEntityListing>> GetIntegrationsUserappsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null)
        { 

            var localVarPath = "/api/v2/integrations/userapps";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (appHost != null) localVarQueryParams.Add(new Tuple<string, string>("appHost", this.Configuration.ApiClient.ParameterToString(appHost)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsUserapps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsUserapps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAppEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserAppEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAppEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>Integration</returns>
        
        
        public Integration PatchIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null)
        {
             ApiResponse<Integration> localVarResponse = PatchIntegrationWithHttpInfo(integrationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        public ApiResponse< Integration > PatchIntegrationWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->PatchIntegration");

            var localVarPath = "/api/v2/integrations/{integrationId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>Task of Integration</returns>
        
        
        public async System.Threading.Tasks.Task<Integration> PatchIntegrationAsync (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null)
        {
             ApiResponse<Integration> localVarResponse = await PatchIntegrationAsyncWithHttpInfo(integrationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="body">Integration Update (optional)</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Integration>> PatchIntegrationAsyncWithHttpInfo (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->PatchIntegration");
            

            var localVarPath = "/api/v2/integrations/{integrationId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action PatchIntegrationsAction (string actionId, UpdateActionInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = PatchIntegrationsActionWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > PatchIntegrationsActionWithHttpInfo (string actionId, UpdateActionInput body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PatchIntegrationsAction");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PatchIntegrationsAction");

            var localVarPath = "/api/v2/integrations/actions/{actionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PatchIntegrationsActionAsync (string actionId, UpdateActionInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await PatchIntegrationsActionAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch an Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PatchIntegrationsActionAsyncWithHttpInfo (string actionId, UpdateActionInput body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PatchIntegrationsAction");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PatchIntegrationsAction");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an existing Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action PatchIntegrationsActionDraft (string actionId, UpdateDraftInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = PatchIntegrationsActionDraftWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > PatchIntegrationsActionDraftWithHttpInfo (string actionId, UpdateDraftInput body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PatchIntegrationsActionDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PatchIntegrationsActionDraft");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an existing Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PatchIntegrationsActionDraftAsync (string actionId, UpdateDraftInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await PatchIntegrationsActionDraftAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action Draft.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PatchIntegrationsActionDraftAsyncWithHttpInfo (string actionId, UpdateDraftInput body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PatchIntegrationsActionDraft");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PatchIntegrationsActionDraft");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>Integration</returns>
        
        
        public Integration PostIntegrations (CreateIntegrationRequest body = null)
        {
             ApiResponse<Integration> localVarResponse = PostIntegrationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>ApiResponse of Integration</returns>
        
        
        public ApiResponse< Integration > PostIntegrationsWithHttpInfo (CreateIntegrationRequest body = null)
        { 

            var localVarPath = "/api/v2/integrations";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>Task of Integration</returns>
        
        
        public async System.Threading.Tasks.Task<Integration> PostIntegrationsAsync (CreateIntegrationRequest body = null)
        {
             ApiResponse<Integration> localVarResponse = await PostIntegrationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an integration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Integration (optional)</param>
        /// <returns>Task of ApiResponse (Integration)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Integration>> PostIntegrationsAsyncWithHttpInfo (CreateIntegrationRequest body = null)
        { 

            var localVarPath = "/api/v2/integrations";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Integration>(localVarStatusCode,
                localVarHeaders,
                (Integration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Integration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new Draft from existing Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActionDraft (string actionId)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = PostIntegrationsActionDraftWithHttpInfo(actionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Draft from existing Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > PostIntegrationsActionDraftWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionDraft");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new Draft from existing Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionDraftAsync (string actionId)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await PostIntegrationsActionDraftAsyncWithHttpInfo(actionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Draft from existing Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionDraftAsyncWithHttpInfo (string actionId)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionDraft");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Publish a Draft and make it the active Action configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActionDraftPublish (string actionId, PublishDraftInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = PostIntegrationsActionDraftPublishWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish a Draft and make it the active Action configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > PostIntegrationsActionDraftPublishWithHttpInfo (string actionId, PublishDraftInput body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionDraftPublish");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionDraftPublish");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/publish";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Publish a Draft and make it the active Action configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionDraftPublishAsync (string actionId, PublishDraftInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await PostIntegrationsActionDraftPublishAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish a Draft and make it the active Action configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Input used to patch the Action.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionDraftPublishAsyncWithHttpInfo (string actionId, PublishDraftInput body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionDraftPublish");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionDraftPublish");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/publish";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>TestExecutionResult</returns>
        
        
        public TestExecutionResult PostIntegrationsActionDraftTest (string actionId, Object body)
        {
             ApiResponse<TestExecutionResult> localVarResponse = PostIntegrationsActionDraftTestWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>ApiResponse of TestExecutionResult</returns>
        
        
        public ApiResponse< TestExecutionResult > PostIntegrationsActionDraftTestWithHttpInfo (string actionId, Object body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionDraftTest");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionDraftTest");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/test";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of TestExecutionResult</returns>
        
        
        public async System.Threading.Tasks.Task<TestExecutionResult> PostIntegrationsActionDraftTestAsync (string actionId, Object body)
        {
             ApiResponse<TestExecutionResult> localVarResponse = await PostIntegrationsActionDraftTestAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of ApiResponse (TestExecutionResult)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TestExecutionResult>> PostIntegrationsActionDraftTestAsyncWithHttpInfo (string actionId, Object body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionDraftTest");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionDraftTest");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/draft/test";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Object</returns>
        
        
        public Object PostIntegrationsActionExecute (string actionId, Object body)
        {
             ApiResponse<Object> localVarResponse = PostIntegrationsActionExecuteWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>ApiResponse of Object</returns>
        
        
        public ApiResponse< Object > PostIntegrationsActionExecuteWithHttpInfo (string actionId, Object body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionExecute");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionExecute");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/execute";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of Object</returns>
        
        
        public async System.Threading.Tasks.Task<Object> PostIntegrationsActionExecuteAsync (string actionId, Object body)
        {
             ApiResponse<Object> localVarResponse = await PostIntegrationsActionExecuteAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostIntegrationsActionExecuteAsyncWithHttpInfo (string actionId, Object body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionExecute");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionExecute");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/execute";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>TestExecutionResult</returns>
        
        
        public TestExecutionResult PostIntegrationsActionTest (string actionId, Object body)
        {
             ApiResponse<TestExecutionResult> localVarResponse = PostIntegrationsActionTestWithHttpInfo(actionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>ApiResponse of TestExecutionResult</returns>
        
        
        public ApiResponse< TestExecutionResult > PostIntegrationsActionTestWithHttpInfo (string actionId, Object body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionTest");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionTest");

            var localVarPath = "/api/v2/integrations/actions/{actionId}/test";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of TestExecutionResult</returns>
        
        
        public async System.Threading.Tasks.Task<TestExecutionResult> PostIntegrationsActionTestAsync (string actionId, Object body)
        {
             ApiResponse<TestExecutionResult> localVarResponse = await PostIntegrationsActionTestAsyncWithHttpInfo(actionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="body">Map of parameters used for variable substitution.</param>
        /// <returns>Task of ApiResponse (TestExecutionResult)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TestExecutionResult>> PostIntegrationsActionTestAsyncWithHttpInfo (string actionId, Object body)
        { 
            // verify the required parameter 'actionId' is set
            if (actionId == null)
                throw new ApiException(400, "Missing required parameter 'actionId' when calling IntegrationsApi->PostIntegrationsActionTest");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionTest");
            

            var localVarPath = "/api/v2/integrations/actions/{actionId}/test";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (actionId != null) localVarPathParams.Add("actionId", this.Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActions (PostActionInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = PostIntegrationsActionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > PostIntegrationsActionsWithHttpInfo (PostActionInput body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActions");

            var localVarPath = "/api/v2/integrations/actions";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionsAsync (PostActionInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await PostIntegrationsActionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Action 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionsAsyncWithHttpInfo (PostActionInput body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActions");
            

            var localVarPath = "/api/v2/integrations/actions";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public PureCloudPlatform.Client.V2.Model.Action PostIntegrationsActionsDrafts (PostActionInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = PostIntegrationsActionsDraftsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>ApiResponse of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public ApiResponse< PureCloudPlatform.Client.V2.Model.Action > PostIntegrationsActionsDraftsWithHttpInfo (PostActionInput body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionsDrafts");

            var localVarPath = "/api/v2/integrations/actions/drafts";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>Task of PureCloudPlatform.Client.V2.Model.Action</returns>
        
        
        public async System.Threading.Tasks.Task<PureCloudPlatform.Client.V2.Model.Action> PostIntegrationsActionsDraftsAsync (PostActionInput body)
        {
             ApiResponse<PureCloudPlatform.Client.V2.Model.Action> localVarResponse = await PostIntegrationsActionsDraftsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Input used to create Action Draft.</param>
        /// <returns>Task of ApiResponse (PureCloudPlatform.Client.V2.Model.Action)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<PureCloudPlatform.Client.V2.Model.Action>> PostIntegrationsActionsDraftsAsyncWithHttpInfo (PostActionInput body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PostIntegrationsActionsDrafts");
            

            var localVarPath = "/api/v2/integrations/actions/drafts";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>CredentialInfo</returns>
        
        
        public CredentialInfo PostIntegrationsCredentials (Credential body = null)
        {
             ApiResponse<CredentialInfo> localVarResponse = PostIntegrationsCredentialsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>ApiResponse of CredentialInfo</returns>
        
        
        public ApiResponse< CredentialInfo > PostIntegrationsCredentialsWithHttpInfo (Credential body = null)
        { 

            var localVarPath = "/api/v2/integrations/credentials";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsCredentials: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsCredentials: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialInfo>(localVarStatusCode,
                localVarHeaders,
                (CredentialInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialInfo)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of CredentialInfo</returns>
        
        
        public async System.Threading.Tasks.Task<CredentialInfo> PostIntegrationsCredentialsAsync (Credential body = null)
        {
             ApiResponse<CredentialInfo> localVarResponse = await PostIntegrationsCredentialsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of ApiResponse (CredentialInfo)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<CredentialInfo>> PostIntegrationsCredentialsAsyncWithHttpInfo (Credential body = null)
        { 

            var localVarPath = "/api/v2/integrations/credentials";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsCredentials: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsCredentials: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialInfo>(localVarStatusCode,
                localVarHeaders,
                (CredentialInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialInfo)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        public AsyncJob PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null)
        {
             ApiResponse<AsyncJob> localVarResponse = PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsWithHttpInfo(nuanceIntegrationId, botId, expand, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        public ApiResponse< AsyncJob > PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs");
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<AsyncJob> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsync (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null)
        {
             ApiResponse<AsyncJob> localVarResponse = await PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsyncWithHttpInfo(nuanceIntegrationId, botId, expand, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Nuance bot in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="botId">The Nuance bot ID</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="body">targetChannel (optional)</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<AsyncJob>> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsAsyncWithHttpInfo (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs");
            
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));
            if (botId != null) localVarPathParams.Add("botId", this.Configuration.ApiClient.ParameterToString(botId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>AsyncJob</returns>
        
        /// Preview Endpoint
        public AsyncJob PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        {
             ApiResponse<AsyncJob> localVarResponse = PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsWithHttpInfo(nuanceIntegrationId, pageNumber, pageSize, onlyRegisteredBots);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>ApiResponse of AsyncJob</returns>
        
        /// Preview Endpoint
        public ApiResponse< AsyncJob > PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (onlyRegisteredBots != null) localVarQueryParams.Add(new Tuple<string, string>("onlyRegisteredBots", this.Configuration.ApiClient.ParameterToString(onlyRegisteredBots)));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of AsyncJob</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<AsyncJob> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsAsync (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        {
             ApiResponse<AsyncJob> localVarResponse = await PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsAsyncWithHttpInfo(nuanceIntegrationId, pageNumber, pageSize, onlyRegisteredBots);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Nuance bots in the specified Integration asynchronously 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="onlyRegisteredBots">Limit bots to the ones configured for Genesys Cloud usage (optional, default to true)</param>
        /// <returns>Task of ApiResponse (AsyncJob)</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<AsyncJob>> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsAsyncWithHttpInfo (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (onlyRegisteredBots != null) localVarQueryParams.Add(new Tuple<string, string>("onlyRegisteredBots", this.Configuration.ApiClient.ParameterToString(onlyRegisteredBots)));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncJob>(localVarStatusCode,
                localVarHeaders,
                (AsyncJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        
        /// Preview Endpoint
        public void PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate (string nuanceIntegrationId, BotExecutionConfiguration settings)
        {
             PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateWithHttpInfo(nuanceIntegrationId, settings);
        }

        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        /// Preview Endpoint
        public ApiResponse<Object> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateWithHttpInfo (string nuanceIntegrationId, BotExecutionConfiguration settings)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate");
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/validate";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (settings != null && settings.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            else
                localVarPostBody = settings; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of void</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateAsync (string nuanceIntegrationId, BotExecutionConfiguration settings)
        {
             await PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateAsyncWithHttpInfo(nuanceIntegrationId, settings);

        }

        /// <summary>
        /// Try out a single credential for a Nuance bot to know if the secret is correct 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateAsyncWithHttpInfo (string nuanceIntegrationId, BotExecutionConfiguration settings)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate");
            
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling IntegrationsApi->PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/validate";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (settings != null && settings.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            else
                localVarPostBody = settings; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>IntegrationConfiguration</returns>
        
        
        public IntegrationConfiguration PutIntegrationConfigCurrent (string integrationId, IntegrationConfiguration body = null)
        {
             ApiResponse<IntegrationConfiguration> localVarResponse = PutIntegrationConfigCurrentWithHttpInfo(integrationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>ApiResponse of IntegrationConfiguration</returns>
        
        
        public ApiResponse< IntegrationConfiguration > PutIntegrationConfigCurrentWithHttpInfo (string integrationId, IntegrationConfiguration body = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->PutIntegrationConfigCurrent");

            var localVarPath = "/api/v2/integrations/{integrationId}/config/current";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationConfigCurrent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationConfigCurrent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationConfiguration>(localVarStatusCode,
                localVarHeaders,
                (IntegrationConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>Task of IntegrationConfiguration</returns>
        
        
        public async System.Threading.Tasks.Task<IntegrationConfiguration> PutIntegrationConfigCurrentAsync (string integrationId, IntegrationConfiguration body = null)
        {
             ApiResponse<IntegrationConfiguration> localVarResponse = await PutIntegrationConfigCurrentAsyncWithHttpInfo(integrationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update integration configuration. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">Integration Id</param>
        /// <param name="body">Integration Configuration (optional)</param>
        /// <returns>Task of ApiResponse (IntegrationConfiguration)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationConfiguration>> PutIntegrationConfigCurrentAsyncWithHttpInfo (string integrationId, IntegrationConfiguration body = null)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->PutIntegrationConfigCurrent");
            

            var localVarPath = "/api/v2/integrations/{integrationId}/config/current";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationConfigCurrent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationConfigCurrent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationConfiguration>(localVarStatusCode,
                localVarHeaders,
                (IntegrationConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationConfiguration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns></returns>
        
        
        public void PutIntegrationsBotconnectorIntegrationIdBots (string integrationId, BotList botList)
        {
             PutIntegrationsBotconnectorIntegrationIdBotsWithHttpInfo(integrationId, botList);
        }

        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        public ApiResponse<Object> PutIntegrationsBotconnectorIntegrationIdBotsWithHttpInfo (string integrationId, BotList botList)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->PutIntegrationsBotconnectorIntegrationIdBots");
            // verify the required parameter 'botList' is set
            if (botList == null)
                throw new ApiException(400, "Missing required parameter 'botList' when calling IntegrationsApi->PutIntegrationsBotconnectorIntegrationIdBots");

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (botList != null && botList.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(botList); // http body (model) parameter
            else
                localVarPostBody = botList; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns>Task of void</returns>
        
        
        public async System.Threading.Tasks.Task PutIntegrationsBotconnectorIntegrationIdBotsAsync (string integrationId, BotList botList)
        {
             await PutIntegrationsBotconnectorIntegrationIdBotsAsyncWithHttpInfo(integrationId, botList);

        }

        /// <summary>
        /// Set a list of botConnector bots plus versions for this integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrationId">The integration ID for this group of bots</param>
        /// <param name="botList"></param>
        /// <returns>Task of ApiResponse</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutIntegrationsBotconnectorIntegrationIdBotsAsyncWithHttpInfo (string integrationId, BotList botList)
        { 
            // verify the required parameter 'integrationId' is set
            if (integrationId == null)
                throw new ApiException(400, "Missing required parameter 'integrationId' when calling IntegrationsApi->PutIntegrationsBotconnectorIntegrationIdBots");
            
            // verify the required parameter 'botList' is set
            if (botList == null)
                throw new ApiException(400, "Missing required parameter 'botList' when calling IntegrationsApi->PutIntegrationsBotconnectorIntegrationIdBots");
            

            var localVarPath = "/api/v2/integrations/botconnector/{integrationId}/bots";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (integrationId != null) localVarPathParams.Add("integrationId", this.Configuration.ApiClient.ParameterToString(integrationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (botList != null && botList.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(botList); // http body (model) parameter
            else
                localVarPostBody = botList; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsBotconnectorIntegrationIdBots: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>CredentialInfo</returns>
        
        
        public CredentialInfo PutIntegrationsCredential (string credentialId, Credential body = null)
        {
             ApiResponse<CredentialInfo> localVarResponse = PutIntegrationsCredentialWithHttpInfo(credentialId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>ApiResponse of CredentialInfo</returns>
        
        
        public ApiResponse< CredentialInfo > PutIntegrationsCredentialWithHttpInfo (string credentialId, Credential body = null)
        { 
            // verify the required parameter 'credentialId' is set
            if (credentialId == null)
                throw new ApiException(400, "Missing required parameter 'credentialId' when calling IntegrationsApi->PutIntegrationsCredential");

            var localVarPath = "/api/v2/integrations/credentials/{credentialId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (credentialId != null) localVarPathParams.Add("credentialId", this.Configuration.ApiClient.ParameterToString(credentialId));

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsCredential: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsCredential: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialInfo>(localVarStatusCode,
                localVarHeaders,
                (CredentialInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialInfo)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of CredentialInfo</returns>
        
        
        public async System.Threading.Tasks.Task<CredentialInfo> PutIntegrationsCredentialAsync (string credentialId, Credential body = null)
        {
             ApiResponse<CredentialInfo> localVarResponse = await PutIntegrationsCredentialAsyncWithHttpInfo(credentialId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a set of credentials 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentialId">Credential ID</param>
        /// <param name="body">Credential (optional)</param>
        /// <returns>Task of ApiResponse (CredentialInfo)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<CredentialInfo>> PutIntegrationsCredentialAsyncWithHttpInfo (string credentialId, Credential body = null)
        { 
            // verify the required parameter 'credentialId' is set
            if (credentialId == null)
                throw new ApiException(400, "Missing required parameter 'credentialId' when calling IntegrationsApi->PutIntegrationsCredential");
            

            var localVarPath = "/api/v2/integrations/credentials/{credentialId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (credentialId != null) localVarPathParams.Add("credentialId", this.Configuration.ApiClient.ParameterToString(credentialId));

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsCredential: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsCredential: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredentialInfo>(localVarStatusCode,
                localVarHeaders,
                (CredentialInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredentialInfo)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        
        /// Preview Endpoint
        public void PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings (string nuanceIntegrationId, NuanceBotLaunchSettings settings)
        {
             PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsWithHttpInfo(nuanceIntegrationId, settings);
        }

        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        /// Preview Endpoint
        public ApiResponse<Object> PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsWithHttpInfo (string nuanceIntegrationId, NuanceBotLaunchSettings settings)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings");
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling IntegrationsApi->PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings");

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (settings != null && settings.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            else
                localVarPostBody = settings; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of void</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsAsync (string nuanceIntegrationId, NuanceBotLaunchSettings settings)
        {
             await PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsAsyncWithHttpInfo(nuanceIntegrationId, settings);

        }

        /// <summary>
        /// Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nuanceIntegrationId">The integration ID for this group of bots</param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        
        /// Preview Endpoint
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsAsyncWithHttpInfo (string nuanceIntegrationId, NuanceBotLaunchSettings settings)
        { 
            // verify the required parameter 'nuanceIntegrationId' is set
            if (nuanceIntegrationId == null)
                throw new ApiException(400, "Missing required parameter 'nuanceIntegrationId' when calling IntegrationsApi->PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings");
            
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling IntegrationsApi->PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings");
            

            var localVarPath = "/api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (nuanceIntegrationId != null) localVarPathParams.Add("nuanceIntegrationId", this.Configuration.ApiClient.ParameterToString(nuanceIntegrationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (settings != null && settings.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            else
                localVarPostBody = settings; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>TtsSettings</returns>
        
        
        public TtsSettings PutIntegrationsSpeechTtsSettings (TtsSettings body)
        {
             ApiResponse<TtsSettings> localVarResponse = PutIntegrationsSpeechTtsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>ApiResponse of TtsSettings</returns>
        
        
        public ApiResponse< TtsSettings > PutIntegrationsSpeechTtsSettingsWithHttpInfo (TtsSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PutIntegrationsSpeechTtsSettings");

            var localVarPath = "/api/v2/integrations/speech/tts/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechTtsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechTtsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsSettings>(localVarStatusCode,
                localVarHeaders,
                (TtsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>Task of TtsSettings</returns>
        
        
        public async System.Threading.Tasks.Task<TtsSettings> PutIntegrationsSpeechTtsSettingsAsync (TtsSettings body)
        {
             ApiResponse<TtsSettings> localVarResponse = await PutIntegrationsSpeechTtsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update TTS settings for an org 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Updated TtsSettings</param>
        /// <returns>Task of ApiResponse (TtsSettings)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<TtsSettings>> PutIntegrationsSpeechTtsSettingsAsyncWithHttpInfo (TtsSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsApi->PutIntegrationsSpeechTtsSettings");
            

            var localVarPath = "/api/v2/integrations/speech/tts/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechTtsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIntegrationsSpeechTtsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TtsSettings>(localVarStatusCode,
                localVarHeaders,
                (TtsSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TtsSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
