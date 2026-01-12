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
    public interface IIntentsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns></returns>
        
        void DeleteIntentsCategory (string categoryId);

        /// <summary>
        /// Delete category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteIntentsCategoryWithHttpInfo (string categoryId);

        /// <summary>
        /// Delete customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns></returns>
        
        void DeleteIntentsCustomerintent (string customerIntentId);

        /// <summary>
        /// Delete customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteIntentsCustomerintentWithHttpInfo (string customerIntentId);

        /// <summary>
        /// Get customer intent assignments for externalContactId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>CustomerIntentAssignmentListing</returns>
        
        CustomerIntentAssignmentListing GetIntentsAssignmentsExternalcontact (string externalContactId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get customer intent assignments for externalContactId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>ApiResponse of CustomerIntentAssignmentListing</returns>
        
        ApiResponse<CustomerIntentAssignmentListing> GetIntentsAssignmentsExternalcontactWithHttpInfo (string externalContactId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>IntentsCategoryListing</returns>
        
        IntentsCategoryListing GetIntentsCategories (int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>ApiResponse of IntentsCategoryListing</returns>
        
        ApiResponse<IntentsCategoryListing> GetIntentsCategoriesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>IntentsCategory</returns>
        
        IntentsCategory GetIntentsCategory (string categoryId);

        /// <summary>
        /// Get category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>ApiResponse of IntentsCategory</returns>
        
        ApiResponse<IntentsCategory> GetIntentsCategoryWithHttpInfo (string categoryId);

        /// <summary>
        /// Get customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>CustomerIntentResponse</returns>
        
        CustomerIntentResponse GetIntentsCustomerintent (string customerIntentId);

        /// <summary>
        /// Get customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>ApiResponse of CustomerIntentResponse</returns>
        
        ApiResponse<CustomerIntentResponse> GetIntentsCustomerintentWithHttpInfo (string customerIntentId);

        /// <summary>
        /// Get source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>CustomerSourceIntentListing</returns>
        
        CustomerSourceIntentListing GetIntentsCustomerintentSourceintents (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>ApiResponse of CustomerSourceIntentListing</returns>
        
        ApiResponse<CustomerSourceIntentListing> GetIntentsCustomerintentSourceintentsWithHttpInfo (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>CustomerIntentListing</returns>
        
        CustomerIntentListing GetIntentsCustomerintents (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null);

        /// <summary>
        /// Get customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>ApiResponse of CustomerIntentListing</returns>
        
        ApiResponse<CustomerIntentListing> GetIntentsCustomerintentsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null);

        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>CustomerSourceIntentListing</returns>
        
        CustomerSourceIntentListing GetIntentsSourceintents (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null);

        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>ApiResponse of CustomerSourceIntentListing</returns>
        
        ApiResponse<CustomerSourceIntentListing> GetIntentsSourceintentsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null);

        /// <summary>
        /// Patch category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>IntentsCategory</returns>
        
        IntentsCategory PatchIntentsCategory (string categoryId, IntentsCategoryPatch body);

        /// <summary>
        /// Patch category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>ApiResponse of IntentsCategory</returns>
        
        ApiResponse<IntentsCategory> PatchIntentsCategoryWithHttpInfo (string categoryId, IntentsCategoryPatch body);

        /// <summary>
        /// Patch customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>CustomerIntentResponse</returns>
        
        CustomerIntentResponse PatchIntentsCustomerintent (string customerIntentId, CustomerIntentPatch body);

        /// <summary>
        /// Patch customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>ApiResponse of CustomerIntentResponse</returns>
        
        ApiResponse<CustomerIntentResponse> PatchIntentsCustomerintentWithHttpInfo (string customerIntentId, CustomerIntentPatch body);

        /// <summary>
        /// Create customer intent assignment for external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>CustomerIntentAssignmentResponse</returns>
        
        CustomerIntentAssignmentResponse PostIntentsAssignmentsExternalcontactCustomerintentAssignment (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body);

        /// <summary>
        /// Create customer intent assignment for external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>ApiResponse of CustomerIntentAssignmentResponse</returns>
        
        ApiResponse<CustomerIntentAssignmentResponse> PostIntentsAssignmentsExternalcontactCustomerintentAssignmentWithHttpInfo (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body);

        /// <summary>
        /// Create category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>IntentsCategory</returns>
        
        IntentsCategory PostIntentsCategories (IntentsCategory body);

        /// <summary>
        /// Create category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>ApiResponse of IntentsCategory</returns>
        
        ApiResponse<IntentsCategory> PostIntentsCategoriesWithHttpInfo (IntentsCategory body);

        /// <summary>
        /// Bulk add source intents to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>BulkSourceIntentsResponse</returns>
        
        BulkSourceIntentsResponse PostIntentsCustomerintentSourceintentsBulkAdd (string customerIntentId, BulkAddSourceIntentsRequest body);

        /// <summary>
        /// Bulk add source intents to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>ApiResponse of BulkSourceIntentsResponse</returns>
        
        ApiResponse<BulkSourceIntentsResponse> PostIntentsCustomerintentSourceintentsBulkAddWithHttpInfo (string customerIntentId, BulkAddSourceIntentsRequest body);

        /// <summary>
        /// Bulk remove source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>BulkSourceIntentsResponse</returns>
        
        BulkSourceIntentsResponse PostIntentsCustomerintentSourceintentsBulkRemove (string customerIntentId, BulkRemoveSourceIntentsRequest body);

        /// <summary>
        /// Bulk remove source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>ApiResponse of BulkSourceIntentsResponse</returns>
        
        ApiResponse<BulkSourceIntentsResponse> PostIntentsCustomerintentSourceintentsBulkRemoveWithHttpInfo (string customerIntentId, BulkRemoveSourceIntentsRequest body);

        /// <summary>
        /// Create customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>CustomerIntentResponse</returns>
        
        CustomerIntentResponse PostIntentsCustomerintents (CustomerIntent body);

        /// <summary>
        /// Create customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>ApiResponse of CustomerIntentResponse</returns>
        
        ApiResponse<CustomerIntentResponse> PostIntentsCustomerintentsWithHttpInfo (CustomerIntent body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteIntentsCategoryAsync (string categoryId);

        /// <summary>
        /// Delete category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntentsCategoryAsyncWithHttpInfo (string categoryId);

        /// <summary>
        /// Delete customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteIntentsCustomerintentAsync (string customerIntentId);

        /// <summary>
        /// Delete customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntentsCustomerintentAsyncWithHttpInfo (string customerIntentId);

        /// <summary>
        /// Get customer intent assignments for externalContactId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>Task of CustomerIntentAssignmentListing</returns>
        
        System.Threading.Tasks.Task<CustomerIntentAssignmentListing> GetIntentsAssignmentsExternalcontactAsync (string externalContactId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get customer intent assignments for externalContactId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CustomerIntentAssignmentListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerIntentAssignmentListing>> GetIntentsAssignmentsExternalcontactAsyncWithHttpInfo (string externalContactId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of IntentsCategoryListing</returns>
        
        System.Threading.Tasks.Task<IntentsCategoryListing> GetIntentsCategoriesAsync (int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of ApiResponse (IntentsCategoryListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IntentsCategoryListing>> GetIntentsCategoriesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of IntentsCategory</returns>
        
        System.Threading.Tasks.Task<IntentsCategory> GetIntentsCategoryAsync (string categoryId);

        /// <summary>
        /// Get category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of ApiResponse (IntentsCategory)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IntentsCategory>> GetIntentsCategoryAsyncWithHttpInfo (string categoryId);

        /// <summary>
        /// Get customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of CustomerIntentResponse</returns>
        
        System.Threading.Tasks.Task<CustomerIntentResponse> GetIntentsCustomerintentAsync (string customerIntentId);

        /// <summary>
        /// Get customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of ApiResponse (CustomerIntentResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerIntentResponse>> GetIntentsCustomerintentAsyncWithHttpInfo (string customerIntentId);

        /// <summary>
        /// Get source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of CustomerSourceIntentListing</returns>
        
        System.Threading.Tasks.Task<CustomerSourceIntentListing> GetIntentsCustomerintentSourceintentsAsync (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of ApiResponse (CustomerSourceIntentListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerSourceIntentListing>> GetIntentsCustomerintentSourceintentsAsyncWithHttpInfo (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null);

        /// <summary>
        /// Get customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>Task of CustomerIntentListing</returns>
        
        System.Threading.Tasks.Task<CustomerIntentListing> GetIntentsCustomerintentsAsync (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null);

        /// <summary>
        /// Get customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>Task of ApiResponse (CustomerIntentListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerIntentListing>> GetIntentsCustomerintentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null);

        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>Task of CustomerSourceIntentListing</returns>
        
        System.Threading.Tasks.Task<CustomerSourceIntentListing> GetIntentsSourceintentsAsync (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null);

        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>Task of ApiResponse (CustomerSourceIntentListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerSourceIntentListing>> GetIntentsSourceintentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null);

        /// <summary>
        /// Patch category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>Task of IntentsCategory</returns>
        
        System.Threading.Tasks.Task<IntentsCategory> PatchIntentsCategoryAsync (string categoryId, IntentsCategoryPatch body);

        /// <summary>
        /// Patch category for categoryId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>Task of ApiResponse (IntentsCategory)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IntentsCategory>> PatchIntentsCategoryAsyncWithHttpInfo (string categoryId, IntentsCategoryPatch body);

        /// <summary>
        /// Patch customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of CustomerIntentResponse</returns>
        
        System.Threading.Tasks.Task<CustomerIntentResponse> PatchIntentsCustomerintentAsync (string customerIntentId, CustomerIntentPatch body);

        /// <summary>
        /// Patch customer intent for customerIntentId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of ApiResponse (CustomerIntentResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerIntentResponse>> PatchIntentsCustomerintentAsyncWithHttpInfo (string customerIntentId, CustomerIntentPatch body);

        /// <summary>
        /// Create customer intent assignment for external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>Task of CustomerIntentAssignmentResponse</returns>
        
        System.Threading.Tasks.Task<CustomerIntentAssignmentResponse> PostIntentsAssignmentsExternalcontactCustomerintentAssignmentAsync (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body);

        /// <summary>
        /// Create customer intent assignment for external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>Task of ApiResponse (CustomerIntentAssignmentResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerIntentAssignmentResponse>> PostIntentsAssignmentsExternalcontactCustomerintentAssignmentAsyncWithHttpInfo (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body);

        /// <summary>
        /// Create category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>Task of IntentsCategory</returns>
        
        System.Threading.Tasks.Task<IntentsCategory> PostIntentsCategoriesAsync (IntentsCategory body);

        /// <summary>
        /// Create category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>Task of ApiResponse (IntentsCategory)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IntentsCategory>> PostIntentsCategoriesAsyncWithHttpInfo (IntentsCategory body);

        /// <summary>
        /// Bulk add source intents to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>Task of BulkSourceIntentsResponse</returns>
        
        System.Threading.Tasks.Task<BulkSourceIntentsResponse> PostIntentsCustomerintentSourceintentsBulkAddAsync (string customerIntentId, BulkAddSourceIntentsRequest body);

        /// <summary>
        /// Bulk add source intents to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>Task of ApiResponse (BulkSourceIntentsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkSourceIntentsResponse>> PostIntentsCustomerintentSourceintentsBulkAddAsyncWithHttpInfo (string customerIntentId, BulkAddSourceIntentsRequest body);

        /// <summary>
        /// Bulk remove source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>Task of BulkSourceIntentsResponse</returns>
        
        System.Threading.Tasks.Task<BulkSourceIntentsResponse> PostIntentsCustomerintentSourceintentsBulkRemoveAsync (string customerIntentId, BulkRemoveSourceIntentsRequest body);

        /// <summary>
        /// Bulk remove source intents mapped to a customer intent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>Task of ApiResponse (BulkSourceIntentsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkSourceIntentsResponse>> PostIntentsCustomerintentSourceintentsBulkRemoveAsyncWithHttpInfo (string customerIntentId, BulkRemoveSourceIntentsRequest body);

        /// <summary>
        /// Create customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of CustomerIntentResponse</returns>
        
        System.Threading.Tasks.Task<CustomerIntentResponse> PostIntentsCustomerintentsAsync (CustomerIntent body);

        /// <summary>
        /// Create customer intents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of ApiResponse (CustomerIntentResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CustomerIntentResponse>> PostIntentsCustomerintentsAsyncWithHttpInfo (CustomerIntent body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IntentsApi : IIntentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntentsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IntentsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns></returns>
        
        public void DeleteIntentsCategory (string categoryId)
        {
             DeleteIntentsCategoryWithHttpInfo(categoryId);
        }

        /// <summary>
        /// Delete category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteIntentsCategoryWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling IntentsApi->DeleteIntentsCategory");

            var localVarPath = "/api/v2/intents/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteIntentsCategoryAsync (string categoryId)
        {
             await DeleteIntentsCategoryAsyncWithHttpInfo(categoryId);

        }

        /// <summary>
        /// Delete category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntentsCategoryAsyncWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling IntentsApi->DeleteIntentsCategory");
            

            var localVarPath = "/api/v2/intents/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns></returns>
        
        public void DeleteIntentsCustomerintent (string customerIntentId)
        {
             DeleteIntentsCustomerintentWithHttpInfo(customerIntentId);
        }

        /// <summary>
        /// Delete customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteIntentsCustomerintentWithHttpInfo (string customerIntentId)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->DeleteIntentsCustomerintent");

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCustomerintent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCustomerintent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteIntentsCustomerintentAsync (string customerIntentId)
        {
             await DeleteIntentsCustomerintentAsyncWithHttpInfo(customerIntentId);

        }

        /// <summary>
        /// Delete customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIntentsCustomerintentAsyncWithHttpInfo (string customerIntentId)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->DeleteIntentsCustomerintent");
            

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCustomerintent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIntentsCustomerintent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get customer intent assignments for externalContactId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>CustomerIntentAssignmentListing</returns>
        
        public CustomerIntentAssignmentListing GetIntentsAssignmentsExternalcontact (string externalContactId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CustomerIntentAssignmentListing> localVarResponse = GetIntentsAssignmentsExternalcontactWithHttpInfo(externalContactId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get customer intent assignments for externalContactId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>ApiResponse of CustomerIntentAssignmentListing</returns>
        
        public ApiResponse< CustomerIntentAssignmentListing > GetIntentsAssignmentsExternalcontactWithHttpInfo (string externalContactId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling IntentsApi->GetIntentsAssignmentsExternalcontact");

            var localVarPath = "/api/v2/intents/assignments/externalcontacts/{externalContactId}";
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
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsAssignmentsExternalcontact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsAssignmentsExternalcontact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get customer intent assignments for externalContactId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>Task of CustomerIntentAssignmentListing</returns>
        
        public async System.Threading.Tasks.Task<CustomerIntentAssignmentListing> GetIntentsAssignmentsExternalcontactAsync (string externalContactId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CustomerIntentAssignmentListing> localVarResponse = await GetIntentsAssignmentsExternalcontactAsyncWithHttpInfo(externalContactId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get customer intent assignments for externalContactId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CustomerIntentAssignmentListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerIntentAssignmentListing>> GetIntentsAssignmentsExternalcontactAsyncWithHttpInfo (string externalContactId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling IntentsApi->GetIntentsAssignmentsExternalcontact");
            

            var localVarPath = "/api/v2/intents/assignments/externalcontacts/{externalContactId}";
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
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsAssignmentsExternalcontact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsAssignmentsExternalcontact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentAssignmentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentAssignmentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentAssignmentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>IntentsCategoryListing</returns>
        
        public IntentsCategoryListing GetIntentsCategories (int? pageSize = null, int? pageNumber = null, string queryValue = null)
        {
             ApiResponse<IntentsCategoryListing> localVarResponse = GetIntentsCategoriesWithHttpInfo(pageSize, pageNumber, queryValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>ApiResponse of IntentsCategoryListing</returns>
        
        public ApiResponse< IntentsCategoryListing > GetIntentsCategoriesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/intents/categories";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategoryListing>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategoryListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategoryListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of IntentsCategoryListing</returns>
        
        public async System.Threading.Tasks.Task<IntentsCategoryListing> GetIntentsCategoriesAsync (int? pageSize = null, int? pageNumber = null, string queryValue = null)
        {
             ApiResponse<IntentsCategoryListing> localVarResponse = await GetIntentsCategoriesAsyncWithHttpInfo(pageSize, pageNumber, queryValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get categories 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of ApiResponse (IntentsCategoryListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IntentsCategoryListing>> GetIntentsCategoriesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null)
        { 

            var localVarPath = "/api/v2/intents/categories";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategoryListing>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategoryListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategoryListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>IntentsCategory</returns>
        
        public IntentsCategory GetIntentsCategory (string categoryId)
        {
             ApiResponse<IntentsCategory> localVarResponse = GetIntentsCategoryWithHttpInfo(categoryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>ApiResponse of IntentsCategory</returns>
        
        public ApiResponse< IntentsCategory > GetIntentsCategoryWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling IntentsApi->GetIntentsCategory");

            var localVarPath = "/api/v2/intents/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategory>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of IntentsCategory</returns>
        
        public async System.Threading.Tasks.Task<IntentsCategory> GetIntentsCategoryAsync (string categoryId)
        {
             ApiResponse<IntentsCategory> localVarResponse = await GetIntentsCategoryAsyncWithHttpInfo(categoryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <returns>Task of ApiResponse (IntentsCategory)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IntentsCategory>> GetIntentsCategoryAsyncWithHttpInfo (string categoryId)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling IntentsApi->GetIntentsCategory");
            

            var localVarPath = "/api/v2/intents/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategory>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>CustomerIntentResponse</returns>
        
        public CustomerIntentResponse GetIntentsCustomerintent (string customerIntentId)
        {
             ApiResponse<CustomerIntentResponse> localVarResponse = GetIntentsCustomerintentWithHttpInfo(customerIntentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>ApiResponse of CustomerIntentResponse</returns>
        
        public ApiResponse< CustomerIntentResponse > GetIntentsCustomerintentWithHttpInfo (string customerIntentId)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->GetIntentsCustomerintent");

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of CustomerIntentResponse</returns>
        
        public async System.Threading.Tasks.Task<CustomerIntentResponse> GetIntentsCustomerintentAsync (string customerIntentId)
        {
             ApiResponse<CustomerIntentResponse> localVarResponse = await GetIntentsCustomerintentAsyncWithHttpInfo(customerIntentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <returns>Task of ApiResponse (CustomerIntentResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerIntentResponse>> GetIntentsCustomerintentAsyncWithHttpInfo (string customerIntentId)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->GetIntentsCustomerintent");
            

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>CustomerSourceIntentListing</returns>
        
        public CustomerSourceIntentListing GetIntentsCustomerintentSourceintents (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null)
        {
             ApiResponse<CustomerSourceIntentListing> localVarResponse = GetIntentsCustomerintentSourceintentsWithHttpInfo(customerIntentId, pageSize, pageNumber, queryValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>ApiResponse of CustomerSourceIntentListing</returns>
        
        public ApiResponse< CustomerSourceIntentListing > GetIntentsCustomerintentSourceintentsWithHttpInfo (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->GetIntentsCustomerintentSourceintents");

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}/sourceintents";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintentSourceintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintentSourceintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerSourceIntentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerSourceIntentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerSourceIntentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of CustomerSourceIntentListing</returns>
        
        public async System.Threading.Tasks.Task<CustomerSourceIntentListing> GetIntentsCustomerintentSourceintentsAsync (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null)
        {
             ApiResponse<CustomerSourceIntentListing> localVarResponse = await GetIntentsCustomerintentSourceintentsAsyncWithHttpInfo(customerIntentId, pageSize, pageNumber, queryValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <returns>Task of ApiResponse (CustomerSourceIntentListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerSourceIntentListing>> GetIntentsCustomerintentSourceintentsAsyncWithHttpInfo (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->GetIntentsCustomerintentSourceintents");
            

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}/sourceintents";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintentSourceintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintentSourceintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerSourceIntentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerSourceIntentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerSourceIntentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>CustomerIntentListing</returns>
        
        public CustomerIntentListing GetIntentsCustomerintents (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null)
        {
             ApiResponse<CustomerIntentListing> localVarResponse = GetIntentsCustomerintentsWithHttpInfo(pageSize, pageNumber, queryValue, categoryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>ApiResponse of CustomerIntentListing</returns>
        
        public ApiResponse< CustomerIntentListing > GetIntentsCustomerintentsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null)
        { 

            var localVarPath = "/api/v2/intents/customerintents";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));
            if (categoryId != null) localVarQueryParams.Add(new Tuple<string, string>("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>Task of CustomerIntentListing</returns>
        
        public async System.Threading.Tasks.Task<CustomerIntentListing> GetIntentsCustomerintentsAsync (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null)
        {
             ApiResponse<CustomerIntentListing> localVarResponse = await GetIntentsCustomerintentsAsyncWithHttpInfo(pageSize, pageNumber, queryValue, categoryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="queryValue">Search query value to filter results by (optional)</param>
        /// <param name="categoryId">CategoryId to filter query by (optional)</param>
        /// <returns>Task of ApiResponse (CustomerIntentListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerIntentListing>> GetIntentsCustomerintentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null)
        { 

            var localVarPath = "/api/v2/intents/customerintents";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (queryValue != null) localVarQueryParams.Add(new Tuple<string, string>("queryValue", this.Configuration.ApiClient.ParameterToString(queryValue)));
            if (categoryId != null) localVarQueryParams.Add(new Tuple<string, string>("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsCustomerintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>CustomerSourceIntentListing</returns>
        
        public CustomerSourceIntentListing GetIntentsSourceintents (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null)
        {
             ApiResponse<CustomerSourceIntentListing> localVarResponse = GetIntentsSourceintentsWithHttpInfo(pageSize, pageNumber, type, sourceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>ApiResponse of CustomerSourceIntentListing</returns>
        
        public ApiResponse< CustomerSourceIntentListing > GetIntentsSourceintentsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null)
        { 

            var localVarPath = "/api/v2/intents/sourceintents";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));
            if (sourceId != null) localVarQueryParams.Add(new Tuple<string, string>("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsSourceintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsSourceintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerSourceIntentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerSourceIntentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerSourceIntentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>Task of CustomerSourceIntentListing</returns>
        
        public async System.Threading.Tasks.Task<CustomerSourceIntentListing> GetIntentsSourceintentsAsync (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null)
        {
             ApiResponse<CustomerSourceIntentListing> localVarResponse = await GetIntentsSourceintentsAsyncWithHttpInfo(pageSize, pageNumber, type, sourceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all mapped source intents by type. If no type selected default is type Segment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="type">Source Type to query by. If none selected default response will be for type Segment. (optional)</param>
        /// <param name="sourceId">Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional)</param>
        /// <returns>Task of ApiResponse (CustomerSourceIntentListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerSourceIntentListing>> GetIntentsSourceintentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null)
        { 

            var localVarPath = "/api/v2/intents/sourceintents";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));
            if (sourceId != null) localVarQueryParams.Add(new Tuple<string, string>("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsSourceintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIntentsSourceintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerSourceIntentListing>(localVarStatusCode,
                localVarHeaders,
                (CustomerSourceIntentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerSourceIntentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>IntentsCategory</returns>
        
        public IntentsCategory PatchIntentsCategory (string categoryId, IntentsCategoryPatch body)
        {
             ApiResponse<IntentsCategory> localVarResponse = PatchIntentsCategoryWithHttpInfo(categoryId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>ApiResponse of IntentsCategory</returns>
        
        public ApiResponse< IntentsCategory > PatchIntentsCategoryWithHttpInfo (string categoryId, IntentsCategoryPatch body)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling IntentsApi->PatchIntentsCategory");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PatchIntentsCategory");

            var localVarPath = "/api/v2/intents/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategory>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>Task of IntentsCategory</returns>
        
        public async System.Threading.Tasks.Task<IntentsCategory> PatchIntentsCategoryAsync (string categoryId, IntentsCategoryPatch body)
        {
             ApiResponse<IntentsCategory> localVarResponse = await PatchIntentsCategoryAsyncWithHttpInfo(categoryId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch category for categoryId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">Category id</param>
        /// <param name="body">category</param>
        /// <returns>Task of ApiResponse (IntentsCategory)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IntentsCategory>> PatchIntentsCategoryAsyncWithHttpInfo (string categoryId, IntentsCategoryPatch body)
        { 
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling IntentsApi->PatchIntentsCategory");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PatchIntentsCategory");
            

            var localVarPath = "/api/v2/intents/categories/{categoryId}";
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
            if (categoryId != null) localVarPathParams.Add("categoryId", this.Configuration.ApiClient.ParameterToString(categoryId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategory>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>CustomerIntentResponse</returns>
        
        public CustomerIntentResponse PatchIntentsCustomerintent (string customerIntentId, CustomerIntentPatch body)
        {
             ApiResponse<CustomerIntentResponse> localVarResponse = PatchIntentsCustomerintentWithHttpInfo(customerIntentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>ApiResponse of CustomerIntentResponse</returns>
        
        public ApiResponse< CustomerIntentResponse > PatchIntentsCustomerintentWithHttpInfo (string customerIntentId, CustomerIntentPatch body)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PatchIntentsCustomerintent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PatchIntentsCustomerintent");

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCustomerintent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCustomerintent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of CustomerIntentResponse</returns>
        
        public async System.Threading.Tasks.Task<CustomerIntentResponse> PatchIntentsCustomerintentAsync (string customerIntentId, CustomerIntentPatch body)
        {
             ApiResponse<CustomerIntentResponse> localVarResponse = await PatchIntentsCustomerintentAsyncWithHttpInfo(customerIntentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch customer intent for customerIntentId 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of ApiResponse (CustomerIntentResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerIntentResponse>> PatchIntentsCustomerintentAsyncWithHttpInfo (string customerIntentId, CustomerIntentPatch body)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PatchIntentsCustomerintent");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PatchIntentsCustomerintent");
            

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCustomerintent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchIntentsCustomerintent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create customer intent assignment for external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>CustomerIntentAssignmentResponse</returns>
        
        public CustomerIntentAssignmentResponse PostIntentsAssignmentsExternalcontactCustomerintentAssignment (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body)
        {
             ApiResponse<CustomerIntentAssignmentResponse> localVarResponse = PostIntentsAssignmentsExternalcontactCustomerintentAssignmentWithHttpInfo(externalContactId, customerIntentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create customer intent assignment for external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>ApiResponse of CustomerIntentAssignmentResponse</returns>
        
        public ApiResponse< CustomerIntentAssignmentResponse > PostIntentsAssignmentsExternalcontactCustomerintentAssignmentWithHttpInfo (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling IntentsApi->PostIntentsAssignmentsExternalcontactCustomerintentAssignment");
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PostIntentsAssignmentsExternalcontactCustomerintentAssignment");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsAssignmentsExternalcontactCustomerintentAssignment");

            var localVarPath = "/api/v2/intents/assignments/externalcontacts/{externalContactId}/customerintents/{customerIntentId}/assignment";
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
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsAssignmentsExternalcontactCustomerintentAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsAssignmentsExternalcontactCustomerintentAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentAssignmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentAssignmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentAssignmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create customer intent assignment for external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>Task of CustomerIntentAssignmentResponse</returns>
        
        public async System.Threading.Tasks.Task<CustomerIntentAssignmentResponse> PostIntentsAssignmentsExternalcontactCustomerintentAssignmentAsync (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body)
        {
             ApiResponse<CustomerIntentAssignmentResponse> localVarResponse = await PostIntentsAssignmentsExternalcontactCustomerintentAssignmentAsyncWithHttpInfo(externalContactId, customerIntentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create customer intent assignment for external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact id</param>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Customer intent assignment</param>
        /// <returns>Task of ApiResponse (CustomerIntentAssignmentResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerIntentAssignmentResponse>> PostIntentsAssignmentsExternalcontactCustomerintentAssignmentAsyncWithHttpInfo (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling IntentsApi->PostIntentsAssignmentsExternalcontactCustomerintentAssignment");
            
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PostIntentsAssignmentsExternalcontactCustomerintentAssignment");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsAssignmentsExternalcontactCustomerintentAssignment");
            

            var localVarPath = "/api/v2/intents/assignments/externalcontacts/{externalContactId}/customerintents/{customerIntentId}/assignment";
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
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsAssignmentsExternalcontactCustomerintentAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsAssignmentsExternalcontactCustomerintentAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentAssignmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentAssignmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentAssignmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>IntentsCategory</returns>
        
        public IntentsCategory PostIntentsCategories (IntentsCategory body)
        {
             ApiResponse<IntentsCategory> localVarResponse = PostIntentsCategoriesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>ApiResponse of IntentsCategory</returns>
        
        public ApiResponse< IntentsCategory > PostIntentsCategoriesWithHttpInfo (IntentsCategory body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCategories");

            var localVarPath = "/api/v2/intents/categories";
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategory>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>Task of IntentsCategory</returns>
        
        public async System.Threading.Tasks.Task<IntentsCategory> PostIntentsCategoriesAsync (IntentsCategory body)
        {
             ApiResponse<IntentsCategory> localVarResponse = await PostIntentsCategoriesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create category 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">category</param>
        /// <returns>Task of ApiResponse (IntentsCategory)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IntentsCategory>> PostIntentsCategoriesAsyncWithHttpInfo (IntentsCategory body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCategories");
            

            var localVarPath = "/api/v2/intents/categories";
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntentsCategory>(localVarStatusCode,
                localVarHeaders,
                (IntentsCategory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntentsCategory)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk add source intents to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>BulkSourceIntentsResponse</returns>
        
        public BulkSourceIntentsResponse PostIntentsCustomerintentSourceintentsBulkAdd (string customerIntentId, BulkAddSourceIntentsRequest body)
        {
             ApiResponse<BulkSourceIntentsResponse> localVarResponse = PostIntentsCustomerintentSourceintentsBulkAddWithHttpInfo(customerIntentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add source intents to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>ApiResponse of BulkSourceIntentsResponse</returns>
        
        public ApiResponse< BulkSourceIntentsResponse > PostIntentsCustomerintentSourceintentsBulkAddWithHttpInfo (string customerIntentId, BulkAddSourceIntentsRequest body)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkAdd");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkAdd");

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}/sourceintents/bulk/add";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkSourceIntentsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkSourceIntentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkSourceIntentsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk add source intents to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>Task of BulkSourceIntentsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkSourceIntentsResponse> PostIntentsCustomerintentSourceintentsBulkAddAsync (string customerIntentId, BulkAddSourceIntentsRequest body)
        {
             ApiResponse<BulkSourceIntentsResponse> localVarResponse = await PostIntentsCustomerintentSourceintentsBulkAddAsyncWithHttpInfo(customerIntentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add source intents to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be added</param>
        /// <returns>Task of ApiResponse (BulkSourceIntentsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkSourceIntentsResponse>> PostIntentsCustomerintentSourceintentsBulkAddAsyncWithHttpInfo (string customerIntentId, BulkAddSourceIntentsRequest body)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkAdd");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkAdd");
            

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}/sourceintents/bulk/add";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkSourceIntentsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkSourceIntentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkSourceIntentsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk remove source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>BulkSourceIntentsResponse</returns>
        
        public BulkSourceIntentsResponse PostIntentsCustomerintentSourceintentsBulkRemove (string customerIntentId, BulkRemoveSourceIntentsRequest body)
        {
             ApiResponse<BulkSourceIntentsResponse> localVarResponse = PostIntentsCustomerintentSourceintentsBulkRemoveWithHttpInfo(customerIntentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk remove source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>ApiResponse of BulkSourceIntentsResponse</returns>
        
        public ApiResponse< BulkSourceIntentsResponse > PostIntentsCustomerintentSourceintentsBulkRemoveWithHttpInfo (string customerIntentId, BulkRemoveSourceIntentsRequest body)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkRemove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkRemove");

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}/sourceintents/bulk/remove";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkSourceIntentsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkSourceIntentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkSourceIntentsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk remove source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>Task of BulkSourceIntentsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkSourceIntentsResponse> PostIntentsCustomerintentSourceintentsBulkRemoveAsync (string customerIntentId, BulkRemoveSourceIntentsRequest body)
        {
             ApiResponse<BulkSourceIntentsResponse> localVarResponse = await PostIntentsCustomerintentSourceintentsBulkRemoveAsyncWithHttpInfo(customerIntentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk remove source intents mapped to a customer intent 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerIntentId">Customer Intent id</param>
        /// <param name="body">Source intents to be removed</param>
        /// <returns>Task of ApiResponse (BulkSourceIntentsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkSourceIntentsResponse>> PostIntentsCustomerintentSourceintentsBulkRemoveAsyncWithHttpInfo (string customerIntentId, BulkRemoveSourceIntentsRequest body)
        { 
            // verify the required parameter 'customerIntentId' is set
            if (customerIntentId == null)
                throw new ApiException(400, "Missing required parameter 'customerIntentId' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkRemove");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCustomerintentSourceintentsBulkRemove");
            

            var localVarPath = "/api/v2/intents/customerintents/{customerIntentId}/sourceintents/bulk/remove";
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
            if (customerIntentId != null) localVarPathParams.Add("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintentSourceintentsBulkRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkSourceIntentsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkSourceIntentsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkSourceIntentsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>CustomerIntentResponse</returns>
        
        public CustomerIntentResponse PostIntentsCustomerintents (CustomerIntent body)
        {
             ApiResponse<CustomerIntentResponse> localVarResponse = PostIntentsCustomerintentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>ApiResponse of CustomerIntentResponse</returns>
        
        public ApiResponse< CustomerIntentResponse > PostIntentsCustomerintentsWithHttpInfo (CustomerIntent body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCustomerintents");

            var localVarPath = "/api/v2/intents/customerintents";
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of CustomerIntentResponse</returns>
        
        public async System.Threading.Tasks.Task<CustomerIntentResponse> PostIntentsCustomerintentsAsync (CustomerIntent body)
        {
             ApiResponse<CustomerIntentResponse> localVarResponse = await PostIntentsCustomerintentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create customer intents 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Customer intent</param>
        /// <returns>Task of ApiResponse (CustomerIntentResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CustomerIntentResponse>> PostIntentsCustomerintentsAsyncWithHttpInfo (CustomerIntent body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling IntentsApi->PostIntentsCustomerintents");
            

            var localVarPath = "/api/v2/intents/customerintents";
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
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIntentsCustomerintents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerIntentResponse>(localVarStatusCode,
                localVarHeaders,
                (CustomerIntentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerIntentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
