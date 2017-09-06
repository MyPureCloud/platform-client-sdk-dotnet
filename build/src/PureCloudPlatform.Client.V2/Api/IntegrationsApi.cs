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
        /// Retrieves a single Action matching id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ActionEntityListing</returns>
        ActionEntityListing GetIntegrationsActions (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        ApiResponse<ActionEntityListing> GetIntegrationsActionsWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>CategoryEntityListing</returns>
        CategoryEntityListing GetIntegrationsActionsCategories (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of CategoryEntityListing</returns>
        ApiResponse<CategoryEntityListing> GetIntegrationsActionsCategoriesWithHttpInfo (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ActionEntityListing</returns>
        ActionEntityListing GetIntegrationsActionsDrafts (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        ApiResponse<ActionEntityListing> GetIntegrationsActionsDraftsWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
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
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        /// Retrieves a single Action matching id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ActionEntityListing</returns>
        System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsAsync (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsAsyncWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of CategoryEntityListing</returns>
        System.Threading.Tasks.Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves all categories of available Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (CategoryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoryEntityListing>> GetIntegrationsActionsCategoriesAsyncWithHttpInfo (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ActionEntityListing</returns>
        System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsDraftsAsyncWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
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
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
        public IntegrationsApi(Configuration configuration = null)
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                null);
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                null);
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                null);
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                null);
        }

        
        
        /// <summary>
        /// Retrieves a single Action matching id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
        }

        
        /// <summary>
        /// Retrieves a single Action matching id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
        }

        
        
        /// <summary>
        /// Retrieve a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
        }

        
        /// <summary>
        /// Retrieve a Draft 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionId">actionId</param>
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
        /// <param name="expand">Indicates fields of the response which should be expanded. (optional)</param>
        /// <param name="includeConfig">Show config when available (optional, default to false)</param>
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (includeConfig != null) localVarQueryParams.Add(new Tuple<string, string>("includeConfig", Configuration.ApiClient.ParameterToString(includeConfig)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)));
            
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "text/plain"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "text/plain"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DraftValidationResult>(localVarStatusCode,
                localVarHeaders,
                (DraftValidationResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DraftValidationResult)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionDraftValidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DraftValidationResult>(localVarStatusCode,
                localVarHeaders,
                (DraftValidationResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DraftValidationResult)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSchemaDocument>(localVarStatusCode,
                localVarHeaders,
                (JsonSchemaDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSchemaDocument)));
            
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "text/plain"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "text/plain"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));
            if (fileName != null) localVarPathParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        
        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ActionEntityListing</returns>
        public ActionEntityListing GetIntegrationsActions (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = GetIntegrationsActionsWithHttpInfo(category, secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        public ApiResponse< ActionEntityListing > GetIntegrationsActionsWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
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
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", Configuration.ApiClient.ParameterToString(category)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)));
            
        }

        
        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ActionEntityListing</returns>
        public async System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsAsync (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = await GetIntegrationsActionsAsyncWithHttpInfo(category, secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves all actions associated with filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsAsyncWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
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
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", Configuration.ApiClient.ParameterToString(category)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)));
            
        }

        
        
        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>CategoryEntityListing</returns>
        public CategoryEntityListing GetIntegrationsActionsCategories (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<CategoryEntityListing> localVarResponse = GetIntegrationsActionsCategoriesWithHttpInfo(secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of CategoryEntityListing</returns>
        public ApiResponse< CategoryEntityListing > GetIntegrationsActionsCategoriesWithHttpInfo (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
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
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CategoryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryEntityListing)));
            
        }

        
        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of CategoryEntityListing</returns>
        public async System.Threading.Tasks.Task<CategoryEntityListing> GetIntegrationsActionsCategoriesAsync (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<CategoryEntityListing> localVarResponse = await GetIntegrationsActionsCategoriesAsyncWithHttpInfo(secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves all categories of available Actions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secure">Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (CategoryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoryEntityListing>> GetIntegrationsActionsCategoriesAsyncWithHttpInfo (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
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
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CategoryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CategoryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryEntityListing)));
            
        }

        
        
        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ActionEntityListing</returns>
        public ActionEntityListing GetIntegrationsActionsDrafts (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = GetIntegrationsActionsDraftsWithHttpInfo(category, secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of ActionEntityListing</returns>
        public ApiResponse< ActionEntityListing > GetIntegrationsActionsDraftsWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
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
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", Configuration.ApiClient.ParameterToString(category)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)));
            
        }

        
        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ActionEntityListing</returns>
        public async System.Threading.Tasks.Task<ActionEntityListing> GetIntegrationsActionsDraftsAsync (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<ActionEntityListing> localVarResponse = await GetIntegrationsActionsDraftsAsyncWithHttpInfo(category, secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves all action drafts associated with the filters passed in via query param. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Filter by category name (optional)</param>
        /// <param name="secure">Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional)</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (ActionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActionEntityListing>> GetIntegrationsActionsDraftsAsyncWithHttpInfo (string category = null, string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
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
            if (category != null) localVarQueryParams.Add(new Tuple<string, string>("category", Configuration.ApiClient.ParameterToString(category)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ActionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionEntityListing)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntegrationsActionDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionDraftTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)));
            
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
            if (actionId != null) localVarPathParams.Add("actionId", Configuration.ApiClient.ParameterToString(actionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionTest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TestExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (TestExecutionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TestExecutionResult)));
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntegrationsActionsDrafts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PureCloudPlatform.Client.V2.Model.Action>(localVarStatusCode,
                localVarHeaders,
                (PureCloudPlatform.Client.V2.Model.Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PureCloudPlatform.Client.V2.Model.Action)));
            
        }

        
        
    }
    
}
