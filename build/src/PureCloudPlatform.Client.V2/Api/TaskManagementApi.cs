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
    public interface ITaskManagementApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns></returns>
        
        void DeleteTaskmanagementWorkbin (string workbinId);

        /// <summary>
        /// Delete a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTaskmanagementWorkbinWithHttpInfo (string workbinId);

        /// <summary>
        /// Delete a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns></returns>
        
        void DeleteTaskmanagementWorkitem (string workitemId);

        /// <summary>
        /// Delete a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTaskmanagementWorkitemWithHttpInfo (string workitemId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns></returns>
        
        void DeleteTaskmanagementWorkitemsSchema (string schemaId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTaskmanagementWorkitemsSchemaWithHttpInfo (string schemaId);

        /// <summary>
        /// Delete a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns></returns>
        
        void DeleteTaskmanagementWorktype (string worktypeId);

        /// <summary>
        /// Delete a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTaskmanagementWorktypeWithHttpInfo (string worktypeId);

        /// <summary>
        /// Delete a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns></returns>
        
        void DeleteTaskmanagementWorktypeStatus (string worktypeId, string statusId);

        /// <summary>
        /// Delete a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTaskmanagementWorktypeStatusWithHttpInfo (string worktypeId, string statusId);

        /// <summary>
        /// Get a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Workbin</returns>
        
        Workbin GetTaskmanagementWorkbin (string workbinId);

        /// <summary>
        /// Get a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>ApiResponse of Workbin</returns>
        
        ApiResponse<Workbin> GetTaskmanagementWorkbinWithHttpInfo (string workbinId);

        /// <summary>
        /// Get a listing of a workbin's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkbinChangeListing</returns>
        
        WorkbinChangeListing GetTaskmanagementWorkbinHistory (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of a workbin's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkbinChangeListing</returns>
        
        ApiResponse<WorkbinChangeListing> GetTaskmanagementWorkbinHistoryWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a version of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>WorkbinVersion</returns>
        
        WorkbinVersion GetTaskmanagementWorkbinVersion (string workbinId, int? entityVersion);

        /// <summary>
        /// Get a version of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>ApiResponse of WorkbinVersion</returns>
        
        ApiResponse<WorkbinVersion> GetTaskmanagementWorkbinVersionWithHttpInfo (string workbinId, int? entityVersion);

        /// <summary>
        /// Get all versions of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkbinVersionListing</returns>
        
        WorkbinVersionListing GetTaskmanagementWorkbinVersions (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all versions of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkbinVersionListing</returns>
        
        ApiResponse<WorkbinVersionListing> GetTaskmanagementWorkbinVersionsWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>Workitem</returns>
        
        Workitem GetTaskmanagementWorkitem (string workitemId, string expands = null);

        /// <summary>
        /// Get a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        ApiResponse<Workitem> GetTaskmanagementWorkitemWithHttpInfo (string workitemId, string expands = null);

        /// <summary>
        /// Get a listing of a workitem's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemChangeListing</returns>
        
        WorkitemChangeListing GetTaskmanagementWorkitemHistory (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of a workitem's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemChangeListing</returns>
        
        ApiResponse<WorkitemChangeListing> GetTaskmanagementWorkitemHistoryWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemWrapup</returns>
        
        WorkitemWrapup GetTaskmanagementWorkitemUserWrapups (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemWrapup</returns>
        
        ApiResponse<WorkitemWrapup> GetTaskmanagementWorkitemUserWrapupsWithHttpInfo (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a version of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>WorkitemVersion</returns>
        
        WorkitemVersion GetTaskmanagementWorkitemVersion (string workitemId, int? entityVersion);

        /// <summary>
        /// Get a version of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>ApiResponse of WorkitemVersion</returns>
        
        ApiResponse<WorkitemVersion> GetTaskmanagementWorkitemVersionWithHttpInfo (string workitemId, int? entityVersion);

        /// <summary>
        /// Get all versions of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemVersionListing</returns>
        
        WorkitemVersionListing GetTaskmanagementWorkitemVersions (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all versions of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemVersionListing</returns>
        
        ApiResponse<WorkitemVersionListing> GetTaskmanagementWorkitemVersionsWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for all users for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemWrapupEntityListing</returns>
        
        WorkitemWrapupEntityListing GetTaskmanagementWorkitemWrapups (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for all users for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemWrapupEntityListing</returns>
        
        ApiResponse<WorkitemWrapupEntityListing> GetTaskmanagementWorkitemWrapupsWithHttpInfo (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get the workitem query job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>WorkitemQueryJobResponse</returns>
        
        WorkitemQueryJobResponse GetTaskmanagementWorkitemsQueryJob (string jobId);

        /// <summary>
        /// Get the workitem query job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of WorkitemQueryJobResponse</returns>
        
        ApiResponse<WorkitemQueryJobResponse> GetTaskmanagementWorkitemsQueryJobWithHttpInfo (string jobId);

        /// <summary>
        /// Get results from for workitem query job 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>WorkitemPagedEntityListing</returns>
        
        WorkitemPagedEntityListing GetTaskmanagementWorkitemsQueryJobResults (string jobId);

        /// <summary>
        /// Get results from for workitem query job 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of WorkitemPagedEntityListing</returns>
        
        ApiResponse<WorkitemPagedEntityListing> GetTaskmanagementWorkitemsQueryJobResultsWithHttpInfo (string jobId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetTaskmanagementWorkitemsSchema (string schemaId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetTaskmanagementWorkitemsSchemaWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetTaskmanagementWorkitemsSchemaVersion (string schemaId, string versionId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetTaskmanagementWorkitemsSchemaVersionWithHttpInfo (string schemaId, string versionId);

        /// <summary>
        /// Get all versions of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetTaskmanagementWorkitemsSchemaVersions (string schemaId);

        /// <summary>
        /// Get all versions of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetTaskmanagementWorkitemsSchemaVersionsWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DataSchemaListing</returns>
        
        DataSchemaListing GetTaskmanagementWorkitemsSchemas ();

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DataSchemaListing</returns>
        
        ApiResponse<DataSchemaListing> GetTaskmanagementWorkitemsSchemasWithHttpInfo ();

        /// <summary>
        /// Get a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>Worktype</returns>
        
        Worktype GetTaskmanagementWorktype (string worktypeId, List<string> expands = null);

        /// <summary>
        /// Get a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Worktype</returns>
        
        ApiResponse<Worktype> GetTaskmanagementWorktypeWithHttpInfo (string worktypeId, List<string> expands = null);

        /// <summary>
        /// Get a listing of a worktype's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorktypeChangeListing</returns>
        
        WorktypeChangeListing GetTaskmanagementWorktypeHistory (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of a worktype's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorktypeChangeListing</returns>
        
        ApiResponse<WorktypeChangeListing> GetTaskmanagementWorktypeHistoryWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>WorkitemStatus</returns>
        
        WorkitemStatus GetTaskmanagementWorktypeStatus (string worktypeId, string statusId);

        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>ApiResponse of WorkitemStatus</returns>
        
        ApiResponse<WorkitemStatus> GetTaskmanagementWorktypeStatusWithHttpInfo (string worktypeId, string statusId);

        /// <summary>
        /// Get list of statuses for this worktype.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>WorkitemStatusListing</returns>
        
        WorkitemStatusListing GetTaskmanagementWorktypeStatuses (string worktypeId);

        /// <summary>
        /// Get list of statuses for this worktype.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>ApiResponse of WorkitemStatusListing</returns>
        
        ApiResponse<WorkitemStatusListing> GetTaskmanagementWorktypeStatusesWithHttpInfo (string worktypeId);

        /// <summary>
        /// Get a version of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>WorktypeVersion</returns>
        
        WorktypeVersion GetTaskmanagementWorktypeVersion (string worktypeId, int? entityVersion);

        /// <summary>
        /// Get a version of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>ApiResponse of WorktypeVersion</returns>
        
        ApiResponse<WorktypeVersion> GetTaskmanagementWorktypeVersionWithHttpInfo (string worktypeId, int? entityVersion);

        /// <summary>
        /// Get all versions of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorktypeVersionListing</returns>
        
        WorktypeVersionListing GetTaskmanagementWorktypeVersions (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all versions of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorktypeVersionListing</returns>
        
        ApiResponse<WorktypeVersionListing> GetTaskmanagementWorktypeVersionsWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Update the attributes of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>Workbin</returns>
        
        Workbin PatchTaskmanagementWorkbin (string workbinId, WorkbinUpdate body);

        /// <summary>
        /// Update the attributes of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>ApiResponse of Workbin</returns>
        
        ApiResponse<Workbin> PatchTaskmanagementWorkbinWithHttpInfo (string workbinId, WorkbinUpdate body);

        /// <summary>
        /// Update the attributes of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>Workitem</returns>
        
        Workitem PatchTaskmanagementWorkitem (string workitemId, WorkitemUpdate body);

        /// <summary>
        /// Update the attributes of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        ApiResponse<Workitem> PatchTaskmanagementWorkitemWithHttpInfo (string workitemId, WorkitemUpdate body);

        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns></returns>
        
        void PatchTaskmanagementWorkitemAssignment (string workitemId, WorkitemManualAssign body);

        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PatchTaskmanagementWorkitemAssignmentWithHttpInfo (string workitemId, WorkitemManualAssign body);

        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>WorkitemWrapup</returns>
        
        WorkitemWrapup PatchTaskmanagementWorkitemUserWrapups (string workitemId, string userId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>ApiResponse of WorkitemWrapup</returns>
        
        ApiResponse<WorkitemWrapup> PatchTaskmanagementWorkitemUserWrapupsWithHttpInfo (string workitemId, string userId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>WorkitemWrapup</returns>
        
        WorkitemWrapup PatchTaskmanagementWorkitemUsersMeWrapups (string workitemId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>ApiResponse of WorkitemWrapup</returns>
        
        ApiResponse<WorkitemWrapup> PatchTaskmanagementWorkitemUsersMeWrapupsWithHttpInfo (string workitemId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Update the attributes of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Worktype</returns>
        
        Worktype PatchTaskmanagementWorktype (string worktypeId, WorktypeUpdate body = null);

        /// <summary>
        /// Update the attributes of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Worktype</returns>
        
        ApiResponse<Worktype> PatchTaskmanagementWorktypeWithHttpInfo (string worktypeId, WorktypeUpdate body = null);

        /// <summary>
        /// Update the attributes of a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkitemStatus</returns>
        
        WorkitemStatus PatchTaskmanagementWorktypeStatus (string worktypeId, string statusId, WorkitemStatusUpdate body = null);

        /// <summary>
        /// Update the attributes of a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkitemStatus</returns>
        
        ApiResponse<WorkitemStatus> PatchTaskmanagementWorktypeStatusWithHttpInfo (string worktypeId, string statusId, WorkitemStatusUpdate body = null);

        /// <summary>
        /// Create a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Workbin</returns>
        
        Workbin PostTaskmanagementWorkbins (WorkbinCreate body = null);

        /// <summary>
        /// Create a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Workbin</returns>
        
        ApiResponse<Workbin> PostTaskmanagementWorkbinsWithHttpInfo (WorkbinCreate body = null);

        /// <summary>
        /// Query for workbins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>WorkbinQueryEntityListing</returns>
        
        WorkbinQueryEntityListing PostTaskmanagementWorkbinsQuery (WorkbinQueryRequest body);

        /// <summary>
        /// Query for workbins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>ApiResponse of WorkbinQueryEntityListing</returns>
        
        ApiResponse<WorkbinQueryEntityListing> PostTaskmanagementWorkbinsQueryWithHttpInfo (WorkbinQueryRequest body);

        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Workitem</returns>
        
        Workitem PostTaskmanagementWorkitemAcdCancel (string workitemId);

        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        ApiResponse<Workitem> PostTaskmanagementWorkitemAcdCancelWithHttpInfo (string workitemId);

        /// <summary>
        /// Disconnect the assignee of the workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Workitem</returns>
        
        Workitem PostTaskmanagementWorkitemDisconnect (string workitemId);

        /// <summary>
        /// Disconnect the assignee of the workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        ApiResponse<Workitem> PostTaskmanagementWorkitemDisconnectWithHttpInfo (string workitemId);

        /// <summary>
        /// Terminate a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>Workitem</returns>
        
        Workitem PostTaskmanagementWorkitemTerminate (string workitemId, WorkitemTerminate body = null);

        /// <summary>
        /// Terminate a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        ApiResponse<Workitem> PostTaskmanagementWorkitemTerminateWithHttpInfo (string workitemId, WorkitemTerminate body = null);

        /// <summary>
        /// Create a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>Workitem</returns>
        
        Workitem PostTaskmanagementWorkitems (WorkitemCreate body);

        /// <summary>
        /// Create a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        ApiResponse<Workitem> PostTaskmanagementWorkitemsWithHttpInfo (WorkitemCreate body);

        /// <summary>
        /// Query for workitems
        /// </summary>
        /// <remarks>
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>WorkitemPostQueryEntityListing</returns>
        
        WorkitemPostQueryEntityListing PostTaskmanagementWorkitemsQuery (WorkitemQueryPostRequest body);

        /// <summary>
        /// Query for workitems
        /// </summary>
        /// <remarks>
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>ApiResponse of WorkitemPostQueryEntityListing</returns>
        
        ApiResponse<WorkitemPostQueryEntityListing> PostTaskmanagementWorkitemsQueryWithHttpInfo (WorkitemQueryPostRequest body);

        /// <summary>
        /// Create a workitem query job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>WorkitemQueryJobResponse</returns>
        
        WorkitemQueryJobResponse PostTaskmanagementWorkitemsQueryJobs (WorkitemQueryJobCreate body);

        /// <summary>
        /// Create a workitem query job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>ApiResponse of WorkitemQueryJobResponse</returns>
        
        ApiResponse<WorkitemQueryJobResponse> PostTaskmanagementWorkitemsQueryJobsWithHttpInfo (WorkitemQueryJobCreate body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>DataSchema</returns>
        
        DataSchema PostTaskmanagementWorkitemsSchemas (DataSchema body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> PostTaskmanagementWorkitemsSchemasWithHttpInfo (DataSchema body);

        /// <summary>
        /// Add a status to a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkitemStatus</returns>
        
        WorkitemStatus PostTaskmanagementWorktypeStatuses (string worktypeId, WorkitemStatusCreate body = null);

        /// <summary>
        /// Add a status to a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkitemStatus</returns>
        
        ApiResponse<WorkitemStatus> PostTaskmanagementWorktypeStatusesWithHttpInfo (string worktypeId, WorkitemStatusCreate body = null);

        /// <summary>
        /// Create a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Worktype</returns>
        
        Worktype PostTaskmanagementWorktypes (WorktypeCreate body = null);

        /// <summary>
        /// Create a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Worktype</returns>
        
        ApiResponse<Worktype> PostTaskmanagementWorktypesWithHttpInfo (WorktypeCreate body = null);

        /// <summary>
        /// Query for worktypes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>WorktypeQueryEntityListing</returns>
        
        WorktypeQueryEntityListing PostTaskmanagementWorktypesQuery (WorktypeQueryRequest body);

        /// <summary>
        /// Query for worktypes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>ApiResponse of WorktypeQueryEntityListing</returns>
        
        ApiResponse<WorktypeQueryEntityListing> PostTaskmanagementWorktypesQueryWithHttpInfo (WorktypeQueryRequest body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>DataSchema</returns>
        
        DataSchema PutTaskmanagementWorkitemsSchema (string schemaId, DataSchema body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> PutTaskmanagementWorkitemsSchemaWithHttpInfo (string schemaId, DataSchema body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTaskmanagementWorkbinAsync (string workbinId);

        /// <summary>
        /// Delete a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorkbinAsyncWithHttpInfo (string workbinId);

        /// <summary>
        /// Delete a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTaskmanagementWorkitemAsync (string workitemId);

        /// <summary>
        /// Delete a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorkitemAsyncWithHttpInfo (string workitemId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTaskmanagementWorkitemsSchemaAsync (string schemaId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorkitemsSchemaAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Delete a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTaskmanagementWorktypeAsync (string worktypeId);

        /// <summary>
        /// Delete a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorktypeAsyncWithHttpInfo (string worktypeId);

        /// <summary>
        /// Delete a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTaskmanagementWorktypeStatusAsync (string worktypeId, string statusId);

        /// <summary>
        /// Delete a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorktypeStatusAsyncWithHttpInfo (string worktypeId, string statusId);

        /// <summary>
        /// Get a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of Workbin</returns>
        
        System.Threading.Tasks.Task<Workbin> GetTaskmanagementWorkbinAsync (string workbinId);

        /// <summary>
        /// Get a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of ApiResponse (Workbin)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workbin>> GetTaskmanagementWorkbinAsyncWithHttpInfo (string workbinId);

        /// <summary>
        /// Get a listing of a workbin's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkbinChangeListing</returns>
        
        System.Threading.Tasks.Task<WorkbinChangeListing> GetTaskmanagementWorkbinHistoryAsync (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of a workbin's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkbinChangeListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkbinChangeListing>> GetTaskmanagementWorkbinHistoryAsyncWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a version of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>Task of WorkbinVersion</returns>
        
        System.Threading.Tasks.Task<WorkbinVersion> GetTaskmanagementWorkbinVersionAsync (string workbinId, int? entityVersion);

        /// <summary>
        /// Get a version of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>Task of ApiResponse (WorkbinVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkbinVersion>> GetTaskmanagementWorkbinVersionAsyncWithHttpInfo (string workbinId, int? entityVersion);

        /// <summary>
        /// Get all versions of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkbinVersionListing</returns>
        
        System.Threading.Tasks.Task<WorkbinVersionListing> GetTaskmanagementWorkbinVersionsAsync (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all versions of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkbinVersionListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkbinVersionListing>> GetTaskmanagementWorkbinVersionsAsyncWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>Task of Workitem</returns>
        
        System.Threading.Tasks.Task<Workitem> GetTaskmanagementWorkitemAsync (string workitemId, string expands = null);

        /// <summary>
        /// Get a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workitem>> GetTaskmanagementWorkitemAsyncWithHttpInfo (string workitemId, string expands = null);

        /// <summary>
        /// Get a listing of a workitem's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemChangeListing</returns>
        
        System.Threading.Tasks.Task<WorkitemChangeListing> GetTaskmanagementWorkitemHistoryAsync (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of a workitem's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemChangeListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemChangeListing>> GetTaskmanagementWorkitemHistoryAsyncWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemWrapup</returns>
        
        System.Threading.Tasks.Task<WorkitemWrapup> GetTaskmanagementWorkitemUserWrapupsAsync (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemWrapup)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemWrapup>> GetTaskmanagementWorkitemUserWrapupsAsyncWithHttpInfo (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a version of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>Task of WorkitemVersion</returns>
        
        System.Threading.Tasks.Task<WorkitemVersion> GetTaskmanagementWorkitemVersionAsync (string workitemId, int? entityVersion);

        /// <summary>
        /// Get a version of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>Task of ApiResponse (WorkitemVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemVersion>> GetTaskmanagementWorkitemVersionAsyncWithHttpInfo (string workitemId, int? entityVersion);

        /// <summary>
        /// Get all versions of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemVersionListing</returns>
        
        System.Threading.Tasks.Task<WorkitemVersionListing> GetTaskmanagementWorkitemVersionsAsync (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all versions of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemVersionListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemVersionListing>> GetTaskmanagementWorkitemVersionsAsyncWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for all users for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemWrapupEntityListing</returns>
        
        System.Threading.Tasks.Task<WorkitemWrapupEntityListing> GetTaskmanagementWorkitemWrapupsAsync (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all wrapup codes added for all users for a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemWrapupEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemWrapupEntityListing>> GetTaskmanagementWorkitemWrapupsAsyncWithHttpInfo (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get the workitem query job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of WorkitemQueryJobResponse</returns>
        
        System.Threading.Tasks.Task<WorkitemQueryJobResponse> GetTaskmanagementWorkitemsQueryJobAsync (string jobId);

        /// <summary>
        /// Get the workitem query job associated with the job id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (WorkitemQueryJobResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemQueryJobResponse>> GetTaskmanagementWorkitemsQueryJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get results from for workitem query job 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of WorkitemPagedEntityListing</returns>
        
        System.Threading.Tasks.Task<WorkitemPagedEntityListing> GetTaskmanagementWorkitemsQueryJobResultsAsync (string jobId);

        /// <summary>
        /// Get results from for workitem query job 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (WorkitemPagedEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemPagedEntityListing>> GetTaskmanagementWorkitemsQueryJobResultsAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetTaskmanagementWorkitemsSchemaAsync (string schemaId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetTaskmanagementWorkitemsSchemaAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetTaskmanagementWorkitemsSchemaVersionAsync (string schemaId, string versionId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetTaskmanagementWorkitemsSchemaVersionAsyncWithHttpInfo (string schemaId, string versionId);

        /// <summary>
        /// Get all versions of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetTaskmanagementWorkitemsSchemaVersionsAsync (string schemaId);

        /// <summary>
        /// Get all versions of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetTaskmanagementWorkitemsSchemaVersionsAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DataSchemaListing</returns>
        
        System.Threading.Tasks.Task<DataSchemaListing> GetTaskmanagementWorkitemsSchemasAsync ();

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DataSchemaListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchemaListing>> GetTaskmanagementWorkitemsSchemasAsyncWithHttpInfo ();

        /// <summary>
        /// Get a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Worktype</returns>
        
        System.Threading.Tasks.Task<Worktype> GetTaskmanagementWorktypeAsync (string worktypeId, List<string> expands = null);

        /// <summary>
        /// Get a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Worktype)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Worktype>> GetTaskmanagementWorktypeAsyncWithHttpInfo (string worktypeId, List<string> expands = null);

        /// <summary>
        /// Get a listing of a worktype's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorktypeChangeListing</returns>
        
        System.Threading.Tasks.Task<WorktypeChangeListing> GetTaskmanagementWorktypeHistoryAsync (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of a worktype's attribute change history
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorktypeChangeListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorktypeChangeListing>> GetTaskmanagementWorktypeHistoryAsyncWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of WorkitemStatus</returns>
        
        System.Threading.Tasks.Task<WorkitemStatus> GetTaskmanagementWorktypeStatusAsync (string worktypeId, string statusId);

        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of ApiResponse (WorkitemStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemStatus>> GetTaskmanagementWorktypeStatusAsyncWithHttpInfo (string worktypeId, string statusId);

        /// <summary>
        /// Get list of statuses for this worktype.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of WorkitemStatusListing</returns>
        
        System.Threading.Tasks.Task<WorkitemStatusListing> GetTaskmanagementWorktypeStatusesAsync (string worktypeId);

        /// <summary>
        /// Get list of statuses for this worktype.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of ApiResponse (WorkitemStatusListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemStatusListing>> GetTaskmanagementWorktypeStatusesAsyncWithHttpInfo (string worktypeId);

        /// <summary>
        /// Get a version of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>Task of WorktypeVersion</returns>
        
        System.Threading.Tasks.Task<WorktypeVersion> GetTaskmanagementWorktypeVersionAsync (string worktypeId, int? entityVersion);

        /// <summary>
        /// Get a version of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>Task of ApiResponse (WorktypeVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorktypeVersion>> GetTaskmanagementWorktypeVersionAsyncWithHttpInfo (string worktypeId, int? entityVersion);

        /// <summary>
        /// Get all versions of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorktypeVersionListing</returns>
        
        System.Threading.Tasks.Task<WorktypeVersionListing> GetTaskmanagementWorktypeVersionsAsync (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Get all versions of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorktypeVersionListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorktypeVersionListing>> GetTaskmanagementWorktypeVersionsAsyncWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null);

        /// <summary>
        /// Update the attributes of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>Task of Workbin</returns>
        
        System.Threading.Tasks.Task<Workbin> PatchTaskmanagementWorkbinAsync (string workbinId, WorkbinUpdate body);

        /// <summary>
        /// Update the attributes of a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>Task of ApiResponse (Workbin)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workbin>> PatchTaskmanagementWorkbinAsyncWithHttpInfo (string workbinId, WorkbinUpdate body);

        /// <summary>
        /// Update the attributes of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>Task of Workitem</returns>
        
        System.Threading.Tasks.Task<Workitem> PatchTaskmanagementWorkitemAsync (string workitemId, WorkitemUpdate body);

        /// <summary>
        /// Update the attributes of a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workitem>> PatchTaskmanagementWorkitemAsyncWithHttpInfo (string workitemId, WorkitemUpdate body);

        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PatchTaskmanagementWorkitemAssignmentAsync (string workitemId, WorkitemManualAssign body);

        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchTaskmanagementWorkitemAssignmentAsyncWithHttpInfo (string workitemId, WorkitemManualAssign body);

        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>Task of WorkitemWrapup</returns>
        
        System.Threading.Tasks.Task<WorkitemWrapup> PatchTaskmanagementWorkitemUserWrapupsAsync (string workitemId, string userId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>Task of ApiResponse (WorkitemWrapup)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemWrapup>> PatchTaskmanagementWorkitemUserWrapupsAsyncWithHttpInfo (string workitemId, string userId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>Task of WorkitemWrapup</returns>
        
        System.Threading.Tasks.Task<WorkitemWrapup> PatchTaskmanagementWorkitemUsersMeWrapupsAsync (string workitemId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>Task of ApiResponse (WorkitemWrapup)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemWrapup>> PatchTaskmanagementWorkitemUsersMeWrapupsAsyncWithHttpInfo (string workitemId, WorkitemWrapupUpdate body);

        /// <summary>
        /// Update the attributes of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of Worktype</returns>
        
        System.Threading.Tasks.Task<Worktype> PatchTaskmanagementWorktypeAsync (string worktypeId, WorktypeUpdate body = null);

        /// <summary>
        /// Update the attributes of a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (Worktype)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Worktype>> PatchTaskmanagementWorktypeAsyncWithHttpInfo (string worktypeId, WorktypeUpdate body = null);

        /// <summary>
        /// Update the attributes of a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkitemStatus</returns>
        
        System.Threading.Tasks.Task<WorkitemStatus> PatchTaskmanagementWorktypeStatusAsync (string worktypeId, string statusId, WorkitemStatusUpdate body = null);

        /// <summary>
        /// Update the attributes of a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkitemStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemStatus>> PatchTaskmanagementWorktypeStatusAsyncWithHttpInfo (string worktypeId, string statusId, WorkitemStatusUpdate body = null);

        /// <summary>
        /// Create a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of Workbin</returns>
        
        System.Threading.Tasks.Task<Workbin> PostTaskmanagementWorkbinsAsync (WorkbinCreate body = null);

        /// <summary>
        /// Create a workbin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (Workbin)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workbin>> PostTaskmanagementWorkbinsAsyncWithHttpInfo (WorkbinCreate body = null);

        /// <summary>
        /// Query for workbins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of WorkbinQueryEntityListing</returns>
        
        System.Threading.Tasks.Task<WorkbinQueryEntityListing> PostTaskmanagementWorkbinsQueryAsync (WorkbinQueryRequest body);

        /// <summary>
        /// Query for workbins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of ApiResponse (WorkbinQueryEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkbinQueryEntityListing>> PostTaskmanagementWorkbinsQueryAsyncWithHttpInfo (WorkbinQueryRequest body);

        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of Workitem</returns>
        
        System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemAcdCancelAsync (string workitemId);

        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemAcdCancelAsyncWithHttpInfo (string workitemId);

        /// <summary>
        /// Disconnect the assignee of the workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of Workitem</returns>
        
        System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemDisconnectAsync (string workitemId);

        /// <summary>
        /// Disconnect the assignee of the workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemDisconnectAsyncWithHttpInfo (string workitemId);

        /// <summary>
        /// Terminate a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>Task of Workitem</returns>
        
        System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemTerminateAsync (string workitemId, WorkitemTerminate body = null);

        /// <summary>
        /// Terminate a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemTerminateAsyncWithHttpInfo (string workitemId, WorkitemTerminate body = null);

        /// <summary>
        /// Create a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>Task of Workitem</returns>
        
        System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemsAsync (WorkitemCreate body);

        /// <summary>
        /// Create a workitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemsAsyncWithHttpInfo (WorkitemCreate body);

        /// <summary>
        /// Query for workitems
        /// </summary>
        /// <remarks>
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>Task of WorkitemPostQueryEntityListing</returns>
        
        System.Threading.Tasks.Task<WorkitemPostQueryEntityListing> PostTaskmanagementWorkitemsQueryAsync (WorkitemQueryPostRequest body);

        /// <summary>
        /// Query for workitems
        /// </summary>
        /// <remarks>
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>Task of ApiResponse (WorkitemPostQueryEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemPostQueryEntityListing>> PostTaskmanagementWorkitemsQueryAsyncWithHttpInfo (WorkitemQueryPostRequest body);

        /// <summary>
        /// Create a workitem query job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>Task of WorkitemQueryJobResponse</returns>
        
        System.Threading.Tasks.Task<WorkitemQueryJobResponse> PostTaskmanagementWorkitemsQueryJobsAsync (WorkitemQueryJobCreate body);

        /// <summary>
        /// Create a workitem query job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>Task of ApiResponse (WorkitemQueryJobResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemQueryJobResponse>> PostTaskmanagementWorkitemsQueryJobsAsyncWithHttpInfo (WorkitemQueryJobCreate body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> PostTaskmanagementWorkitemsSchemasAsync (DataSchema body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> PostTaskmanagementWorkitemsSchemasAsyncWithHttpInfo (DataSchema body);

        /// <summary>
        /// Add a status to a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkitemStatus</returns>
        
        System.Threading.Tasks.Task<WorkitemStatus> PostTaskmanagementWorktypeStatusesAsync (string worktypeId, WorkitemStatusCreate body = null);

        /// <summary>
        /// Add a status to a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkitemStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorkitemStatus>> PostTaskmanagementWorktypeStatusesAsyncWithHttpInfo (string worktypeId, WorkitemStatusCreate body = null);

        /// <summary>
        /// Create a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of Worktype</returns>
        
        System.Threading.Tasks.Task<Worktype> PostTaskmanagementWorktypesAsync (WorktypeCreate body = null);

        /// <summary>
        /// Create a worktype
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (Worktype)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Worktype>> PostTaskmanagementWorktypesAsyncWithHttpInfo (WorktypeCreate body = null);

        /// <summary>
        /// Query for worktypes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of WorktypeQueryEntityListing</returns>
        
        System.Threading.Tasks.Task<WorktypeQueryEntityListing> PostTaskmanagementWorktypesQueryAsync (WorktypeQueryRequest body);

        /// <summary>
        /// Query for worktypes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of ApiResponse (WorktypeQueryEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WorktypeQueryEntityListing>> PostTaskmanagementWorktypesQueryAsyncWithHttpInfo (WorktypeQueryRequest body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> PutTaskmanagementWorkitemsSchemaAsync (string schemaId, DataSchema body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> PutTaskmanagementWorkitemsSchemaAsyncWithHttpInfo (string schemaId, DataSchema body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskManagementApi : ITaskManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskManagementApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaskManagementApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns></returns>
        
        public void DeleteTaskmanagementWorkbin (string workbinId)
        {
             DeleteTaskmanagementWorkbinWithHttpInfo(workbinId);
        }

        /// <summary>
        /// Delete a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTaskmanagementWorkbinWithHttpInfo (string workbinId)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->DeleteTaskmanagementWorkbin");

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkbin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkbin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTaskmanagementWorkbinAsync (string workbinId)
        {
             await DeleteTaskmanagementWorkbinAsyncWithHttpInfo(workbinId);

        }

        /// <summary>
        /// Delete a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorkbinAsyncWithHttpInfo (string workbinId)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->DeleteTaskmanagementWorkbin");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkbin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkbin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns></returns>
        
        public void DeleteTaskmanagementWorkitem (string workitemId)
        {
             DeleteTaskmanagementWorkitemWithHttpInfo(workitemId);
        }

        /// <summary>
        /// Delete a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTaskmanagementWorkitemWithHttpInfo (string workitemId)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->DeleteTaskmanagementWorkitem");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitem: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTaskmanagementWorkitemAsync (string workitemId)
        {
             await DeleteTaskmanagementWorkitemAsyncWithHttpInfo(workitemId);

        }

        /// <summary>
        /// Delete a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorkitemAsyncWithHttpInfo (string workitemId)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->DeleteTaskmanagementWorkitem");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitem: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns></returns>
        
        public void DeleteTaskmanagementWorkitemsSchema (string schemaId)
        {
             DeleteTaskmanagementWorkitemsSchemaWithHttpInfo(schemaId);
        }

        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTaskmanagementWorkitemsSchemaWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->DeleteTaskmanagementWorkitemsSchema");

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitemsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitemsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTaskmanagementWorkitemsSchemaAsync (string schemaId)
        {
             await DeleteTaskmanagementWorkitemsSchemaAsyncWithHttpInfo(schemaId);

        }

        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorkitemsSchemaAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->DeleteTaskmanagementWorkitemsSchema");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitemsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorkitemsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns></returns>
        
        public void DeleteTaskmanagementWorktype (string worktypeId)
        {
             DeleteTaskmanagementWorktypeWithHttpInfo(worktypeId);
        }

        /// <summary>
        /// Delete a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTaskmanagementWorktypeWithHttpInfo (string worktypeId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->DeleteTaskmanagementWorktype");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTaskmanagementWorktypeAsync (string worktypeId)
        {
             await DeleteTaskmanagementWorktypeAsyncWithHttpInfo(worktypeId);

        }

        /// <summary>
        /// Delete a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorktypeAsyncWithHttpInfo (string worktypeId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->DeleteTaskmanagementWorktype");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns></returns>
        
        public void DeleteTaskmanagementWorktypeStatus (string worktypeId, string statusId)
        {
             DeleteTaskmanagementWorktypeStatusWithHttpInfo(worktypeId, statusId);
        }

        /// <summary>
        /// Delete a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTaskmanagementWorktypeStatusWithHttpInfo (string worktypeId, string statusId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->DeleteTaskmanagementWorktypeStatus");
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling TaskManagementApi->DeleteTaskmanagementWorktypeStatus");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (statusId != null) localVarPathParams.Add("statusId", this.Configuration.ApiClient.ParameterToString(statusId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktypeStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktypeStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTaskmanagementWorktypeStatusAsync (string worktypeId, string statusId)
        {
             await DeleteTaskmanagementWorktypeStatusAsyncWithHttpInfo(worktypeId, statusId);

        }

        /// <summary>
        /// Delete a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTaskmanagementWorktypeStatusAsyncWithHttpInfo (string worktypeId, string statusId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->DeleteTaskmanagementWorktypeStatus");
            
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling TaskManagementApi->DeleteTaskmanagementWorktypeStatus");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (statusId != null) localVarPathParams.Add("statusId", this.Configuration.ApiClient.ParameterToString(statusId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktypeStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTaskmanagementWorktypeStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Workbin</returns>
        
        public Workbin GetTaskmanagementWorkbin (string workbinId)
        {
             ApiResponse<Workbin> localVarResponse = GetTaskmanagementWorkbinWithHttpInfo(workbinId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>ApiResponse of Workbin</returns>
        
        public ApiResponse< Workbin > GetTaskmanagementWorkbinWithHttpInfo (string workbinId)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbin");

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workbin>(localVarStatusCode,
                localVarHeaders,
                (Workbin) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workbin)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of Workbin</returns>
        
        public async System.Threading.Tasks.Task<Workbin> GetTaskmanagementWorkbinAsync (string workbinId)
        {
             ApiResponse<Workbin> localVarResponse = await GetTaskmanagementWorkbinAsyncWithHttpInfo(workbinId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <returns>Task of ApiResponse (Workbin)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workbin>> GetTaskmanagementWorkbinAsyncWithHttpInfo (string workbinId)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbin");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workbin>(localVarStatusCode,
                localVarHeaders,
                (Workbin) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workbin)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a listing of a workbin's attribute change history 
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkbinChangeListing</returns>
        
        public WorkbinChangeListing GetTaskmanagementWorkbinHistory (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkbinChangeListing> localVarResponse = GetTaskmanagementWorkbinHistoryWithHttpInfo(workbinId, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of a workbin's attribute change history 
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkbinChangeListing</returns>
        
        public ApiResponse< WorkbinChangeListing > GetTaskmanagementWorkbinHistoryWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbinHistory");

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}/history";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinChangeListing>(localVarStatusCode,
                localVarHeaders,
                (WorkbinChangeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinChangeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a listing of a workbin's attribute change history 
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkbinChangeListing</returns>
        
        public async System.Threading.Tasks.Task<WorkbinChangeListing> GetTaskmanagementWorkbinHistoryAsync (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkbinChangeListing> localVarResponse = await GetTaskmanagementWorkbinHistoryAsyncWithHttpInfo(workbinId, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of a workbin's attribute change history 
        /// 
        /// GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkbinChangeListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkbinChangeListing>> GetTaskmanagementWorkbinHistoryAsyncWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbinHistory");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}/history";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinChangeListing>(localVarStatusCode,
                localVarHeaders,
                (WorkbinChangeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinChangeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a version of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>WorkbinVersion</returns>
        
        public WorkbinVersion GetTaskmanagementWorkbinVersion (string workbinId, int? entityVersion)
        {
             ApiResponse<WorkbinVersion> localVarResponse = GetTaskmanagementWorkbinVersionWithHttpInfo(workbinId, entityVersion);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a version of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>ApiResponse of WorkbinVersion</returns>
        
        public ApiResponse< WorkbinVersion > GetTaskmanagementWorkbinVersionWithHttpInfo (string workbinId, int? entityVersion)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbinVersion");
            // verify the required parameter 'entityVersion' is set
            if (entityVersion == null)
                throw new ApiException(400, "Missing required parameter 'entityVersion' when calling TaskManagementApi->GetTaskmanagementWorkbinVersion");

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}/versions/{entityVersion}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));
            if (entityVersion != null) localVarPathParams.Add("entityVersion", this.Configuration.ApiClient.ParameterToString(entityVersion));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinVersion>(localVarStatusCode,
                localVarHeaders,
                (WorkbinVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a version of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>Task of WorkbinVersion</returns>
        
        public async System.Threading.Tasks.Task<WorkbinVersion> GetTaskmanagementWorkbinVersionAsync (string workbinId, int? entityVersion)
        {
             ApiResponse<WorkbinVersion> localVarResponse = await GetTaskmanagementWorkbinVersionAsyncWithHttpInfo(workbinId, entityVersion);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a version of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="entityVersion">Workbin version</param>
        /// <returns>Task of ApiResponse (WorkbinVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkbinVersion>> GetTaskmanagementWorkbinVersionAsyncWithHttpInfo (string workbinId, int? entityVersion)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbinVersion");
            
            // verify the required parameter 'entityVersion' is set
            if (entityVersion == null)
                throw new ApiException(400, "Missing required parameter 'entityVersion' when calling TaskManagementApi->GetTaskmanagementWorkbinVersion");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}/versions/{entityVersion}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));
            if (entityVersion != null) localVarPathParams.Add("entityVersion", this.Configuration.ApiClient.ParameterToString(entityVersion));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinVersion>(localVarStatusCode,
                localVarHeaders,
                (WorkbinVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all versions of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkbinVersionListing</returns>
        
        public WorkbinVersionListing GetTaskmanagementWorkbinVersions (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkbinVersionListing> localVarResponse = GetTaskmanagementWorkbinVersionsWithHttpInfo(workbinId, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all versions of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkbinVersionListing</returns>
        
        public ApiResponse< WorkbinVersionListing > GetTaskmanagementWorkbinVersionsWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbinVersions");

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinVersionListing>(localVarStatusCode,
                localVarHeaders,
                (WorkbinVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all versions of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkbinVersionListing</returns>
        
        public async System.Threading.Tasks.Task<WorkbinVersionListing> GetTaskmanagementWorkbinVersionsAsync (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkbinVersionListing> localVarResponse = await GetTaskmanagementWorkbinVersionsAsyncWithHttpInfo(workbinId, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all versions of a workbin 
        /// 
        /// GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkbinVersionListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkbinVersionListing>> GetTaskmanagementWorkbinVersionsAsyncWithHttpInfo (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->GetTaskmanagementWorkbinVersions");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkbinVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinVersionListing>(localVarStatusCode,
                localVarHeaders,
                (WorkbinVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>Workitem</returns>
        
        public Workitem GetTaskmanagementWorkitem (string workitemId, string expands = null)
        {
             ApiResponse<Workitem> localVarResponse = GetTaskmanagementWorkitemWithHttpInfo(workitemId, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        public ApiResponse< Workitem > GetTaskmanagementWorkitemWithHttpInfo (string workitemId, string expands = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitem");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitem: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>Task of Workitem</returns>
        
        public async System.Threading.Tasks.Task<Workitem> GetTaskmanagementWorkitemAsync (string workitemId, string expands = null)
        {
             ApiResponse<Workitem> localVarResponse = await GetTaskmanagementWorkitemAsyncWithHttpInfo(workitemId, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="expands">Which fields to expand. Comma separated if more than one. (optional)</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workitem>> GetTaskmanagementWorkitemAsyncWithHttpInfo (string workitemId, string expands = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitem");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitem: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a listing of a workitem's attribute change history 
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemChangeListing</returns>
        
        public WorkitemChangeListing GetTaskmanagementWorkitemHistory (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemChangeListing> localVarResponse = GetTaskmanagementWorkitemHistoryWithHttpInfo(workitemId, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of a workitem's attribute change history 
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemChangeListing</returns>
        
        public ApiResponse< WorkitemChangeListing > GetTaskmanagementWorkitemHistoryWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemHistory");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/history";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemChangeListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemChangeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemChangeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a listing of a workitem's attribute change history 
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemChangeListing</returns>
        
        public async System.Threading.Tasks.Task<WorkitemChangeListing> GetTaskmanagementWorkitemHistoryAsync (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemChangeListing> localVarResponse = await GetTaskmanagementWorkitemHistoryAsyncWithHttpInfo(workitemId, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of a workitem's attribute change history 
        /// 
        /// GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemChangeListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemChangeListing>> GetTaskmanagementWorkitemHistoryAsyncWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemHistory");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/history";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemChangeListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemChangeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemChangeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemWrapup</returns>
        
        public WorkitemWrapup GetTaskmanagementWorkitemUserWrapups (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemWrapup> localVarResponse = GetTaskmanagementWorkitemUserWrapupsWithHttpInfo(workitemId, userId, expands, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemWrapup</returns>
        
        public ApiResponse< WorkitemWrapup > GetTaskmanagementWorkitemUserWrapupsWithHttpInfo (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemUserWrapups");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling TaskManagementApi->GetTaskmanagementWorkitemUserWrapups");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemUserWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemUserWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapup>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemWrapup</returns>
        
        public async System.Threading.Tasks.Task<WorkitemWrapup> GetTaskmanagementWorkitemUserWrapupsAsync (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemWrapup> localVarResponse = await GetTaskmanagementWorkitemUserWrapupsAsyncWithHttpInfo(workitemId, userId, expands, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all wrapup codes added for the given user for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemWrapup)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemWrapup>> GetTaskmanagementWorkitemUserWrapupsAsyncWithHttpInfo (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemUserWrapups");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling TaskManagementApi->GetTaskmanagementWorkitemUserWrapups");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemUserWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemUserWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapup>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a version of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>WorkitemVersion</returns>
        
        public WorkitemVersion GetTaskmanagementWorkitemVersion (string workitemId, int? entityVersion)
        {
             ApiResponse<WorkitemVersion> localVarResponse = GetTaskmanagementWorkitemVersionWithHttpInfo(workitemId, entityVersion);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a version of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>ApiResponse of WorkitemVersion</returns>
        
        public ApiResponse< WorkitemVersion > GetTaskmanagementWorkitemVersionWithHttpInfo (string workitemId, int? entityVersion)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemVersion");
            // verify the required parameter 'entityVersion' is set
            if (entityVersion == null)
                throw new ApiException(400, "Missing required parameter 'entityVersion' when calling TaskManagementApi->GetTaskmanagementWorkitemVersion");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/versions/{entityVersion}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));
            if (entityVersion != null) localVarPathParams.Add("entityVersion", this.Configuration.ApiClient.ParameterToString(entityVersion));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemVersion>(localVarStatusCode,
                localVarHeaders,
                (WorkitemVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a version of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>Task of WorkitemVersion</returns>
        
        public async System.Threading.Tasks.Task<WorkitemVersion> GetTaskmanagementWorkitemVersionAsync (string workitemId, int? entityVersion)
        {
             ApiResponse<WorkitemVersion> localVarResponse = await GetTaskmanagementWorkitemVersionAsyncWithHttpInfo(workitemId, entityVersion);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a version of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="entityVersion">Workitem version</param>
        /// <returns>Task of ApiResponse (WorkitemVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemVersion>> GetTaskmanagementWorkitemVersionAsyncWithHttpInfo (string workitemId, int? entityVersion)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemVersion");
            
            // verify the required parameter 'entityVersion' is set
            if (entityVersion == null)
                throw new ApiException(400, "Missing required parameter 'entityVersion' when calling TaskManagementApi->GetTaskmanagementWorkitemVersion");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/versions/{entityVersion}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));
            if (entityVersion != null) localVarPathParams.Add("entityVersion", this.Configuration.ApiClient.ParameterToString(entityVersion));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemVersion>(localVarStatusCode,
                localVarHeaders,
                (WorkitemVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all versions of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemVersionListing</returns>
        
        public WorkitemVersionListing GetTaskmanagementWorkitemVersions (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemVersionListing> localVarResponse = GetTaskmanagementWorkitemVersionsWithHttpInfo(workitemId, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all versions of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemVersionListing</returns>
        
        public ApiResponse< WorkitemVersionListing > GetTaskmanagementWorkitemVersionsWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemVersions");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemVersionListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all versions of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemVersionListing</returns>
        
        public async System.Threading.Tasks.Task<WorkitemVersionListing> GetTaskmanagementWorkitemVersionsAsync (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemVersionListing> localVarResponse = await GetTaskmanagementWorkitemVersionsAsyncWithHttpInfo(workitemId, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all versions of a workitem 
        /// 
        /// GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemVersionListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemVersionListing>> GetTaskmanagementWorkitemVersionsAsyncWithHttpInfo (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemVersions");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemVersionListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all wrapup codes added for all users for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorkitemWrapupEntityListing</returns>
        
        public WorkitemWrapupEntityListing GetTaskmanagementWorkitemWrapups (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemWrapupEntityListing> localVarResponse = GetTaskmanagementWorkitemWrapupsWithHttpInfo(workitemId, expands, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all wrapup codes added for all users for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorkitemWrapupEntityListing</returns>
        
        public ApiResponse< WorkitemWrapupEntityListing > GetTaskmanagementWorkitemWrapupsWithHttpInfo (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemWrapups");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapupEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapupEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapupEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all wrapup codes added for all users for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorkitemWrapupEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WorkitemWrapupEntityListing> GetTaskmanagementWorkitemWrapupsAsync (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorkitemWrapupEntityListing> localVarResponse = await GetTaskmanagementWorkitemWrapupsAsyncWithHttpInfo(workitemId, expands, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all wrapup codes added for all users for a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorkitemWrapupEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemWrapupEntityListing>> GetTaskmanagementWorkitemWrapupsAsyncWithHttpInfo (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->GetTaskmanagementWorkitemWrapups");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapupEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapupEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapupEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the workitem query job associated with the job id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>WorkitemQueryJobResponse</returns>
        
        public WorkitemQueryJobResponse GetTaskmanagementWorkitemsQueryJob (string jobId)
        {
             ApiResponse<WorkitemQueryJobResponse> localVarResponse = GetTaskmanagementWorkitemsQueryJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the workitem query job associated with the job id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of WorkitemQueryJobResponse</returns>
        
        public ApiResponse< WorkitemQueryJobResponse > GetTaskmanagementWorkitemsQueryJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling TaskManagementApi->GetTaskmanagementWorkitemsQueryJob");

            var localVarPath = "/api/v2/taskmanagement/workitems/query/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemQueryJobResponse>(localVarStatusCode,
                localVarHeaders,
                (WorkitemQueryJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemQueryJobResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the workitem query job associated with the job id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of WorkitemQueryJobResponse</returns>
        
        public async System.Threading.Tasks.Task<WorkitemQueryJobResponse> GetTaskmanagementWorkitemsQueryJobAsync (string jobId)
        {
             ApiResponse<WorkitemQueryJobResponse> localVarResponse = await GetTaskmanagementWorkitemsQueryJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the workitem query job associated with the job id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (WorkitemQueryJobResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemQueryJobResponse>> GetTaskmanagementWorkitemsQueryJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling TaskManagementApi->GetTaskmanagementWorkitemsQueryJob");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/query/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemQueryJobResponse>(localVarStatusCode,
                localVarHeaders,
                (WorkitemQueryJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemQueryJobResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get results from for workitem query job  
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>WorkitemPagedEntityListing</returns>
        
        public WorkitemPagedEntityListing GetTaskmanagementWorkitemsQueryJobResults (string jobId)
        {
             ApiResponse<WorkitemPagedEntityListing> localVarResponse = GetTaskmanagementWorkitemsQueryJobResultsWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results from for workitem query job  
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of WorkitemPagedEntityListing</returns>
        
        public ApiResponse< WorkitemPagedEntityListing > GetTaskmanagementWorkitemsQueryJobResultsWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling TaskManagementApi->GetTaskmanagementWorkitemsQueryJobResults");

            var localVarPath = "/api/v2/taskmanagement/workitems/query/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemPagedEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemPagedEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemPagedEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get results from for workitem query job  
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of WorkitemPagedEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WorkitemPagedEntityListing> GetTaskmanagementWorkitemsQueryJobResultsAsync (string jobId)
        {
             ApiResponse<WorkitemPagedEntityListing> localVarResponse = await GetTaskmanagementWorkitemsQueryJobResultsAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results from for workitem query job  
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (WorkitemPagedEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemPagedEntityListing>> GetTaskmanagementWorkitemsQueryJobResultsAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling TaskManagementApi->GetTaskmanagementWorkitemsQueryJobResults");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/query/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsQueryJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemPagedEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemPagedEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemPagedEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetTaskmanagementWorkitemsSchema (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = GetTaskmanagementWorkitemsSchemaWithHttpInfo(schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetTaskmanagementWorkitemsSchemaWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchema");

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetTaskmanagementWorkitemsSchemaAsync (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetTaskmanagementWorkitemsSchemaAsyncWithHttpInfo(schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetTaskmanagementWorkitemsSchemaAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchema");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetTaskmanagementWorkitemsSchemaVersion (string schemaId, string versionId)
        {
             ApiResponse<DataSchema> localVarResponse = GetTaskmanagementWorkitemsSchemaVersionWithHttpInfo(schemaId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetTaskmanagementWorkitemsSchemaVersionWithHttpInfo (string schemaId, string versionId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchemaVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchemaVersion");

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetTaskmanagementWorkitemsSchemaVersionAsync (string schemaId, string versionId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetTaskmanagementWorkitemsSchemaVersionAsyncWithHttpInfo(schemaId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetTaskmanagementWorkitemsSchemaVersionAsyncWithHttpInfo (string schemaId, string versionId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchemaVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchemaVersion");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all versions of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetTaskmanagementWorkitemsSchemaVersions (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = GetTaskmanagementWorkitemsSchemaVersionsWithHttpInfo(schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all versions of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetTaskmanagementWorkitemsSchemaVersionsWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchemaVersions");

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all versions of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetTaskmanagementWorkitemsSchemaVersionsAsync (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetTaskmanagementWorkitemsSchemaVersionsAsyncWithHttpInfo(schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all versions of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetTaskmanagementWorkitemsSchemaVersionsAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->GetTaskmanagementWorkitemsSchemaVersions");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemaVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DataSchemaListing</returns>
        
        public DataSchemaListing GetTaskmanagementWorkitemsSchemas ()
        {
             ApiResponse<DataSchemaListing> localVarResponse = GetTaskmanagementWorkitemsSchemasWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DataSchemaListing</returns>
        
        public ApiResponse< DataSchemaListing > GetTaskmanagementWorkitemsSchemasWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (DataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DataSchemaListing</returns>
        
        public async System.Threading.Tasks.Task<DataSchemaListing> GetTaskmanagementWorkitemsSchemasAsync ()
        {
             ApiResponse<DataSchemaListing> localVarResponse = await GetTaskmanagementWorkitemsSchemasAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DataSchemaListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchemaListing>> GetTaskmanagementWorkitemsSchemasAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorkitemsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (DataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>Worktype</returns>
        
        public Worktype GetTaskmanagementWorktype (string worktypeId, List<string> expands = null)
        {
             ApiResponse<Worktype> localVarResponse = GetTaskmanagementWorktypeWithHttpInfo(worktypeId, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Worktype</returns>
        
        public ApiResponse< Worktype > GetTaskmanagementWorktypeWithHttpInfo (string worktypeId, List<string> expands = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktype");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

            // Query params
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Worktype>(localVarStatusCode,
                localVarHeaders,
                (Worktype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Worktype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Worktype</returns>
        
        public async System.Threading.Tasks.Task<Worktype> GetTaskmanagementWorktypeAsync (string worktypeId, List<string> expands = null)
        {
             ApiResponse<Worktype> localVarResponse = await GetTaskmanagementWorktypeAsyncWithHttpInfo(worktypeId, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="expands">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Worktype)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Worktype>> GetTaskmanagementWorktypeAsyncWithHttpInfo (string worktypeId, List<string> expands = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktype");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

            // Query params
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Worktype>(localVarStatusCode,
                localVarHeaders,
                (Worktype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Worktype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a listing of a worktype's attribute change history 
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorktypeChangeListing</returns>
        
        public WorktypeChangeListing GetTaskmanagementWorktypeHistory (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorktypeChangeListing> localVarResponse = GetTaskmanagementWorktypeHistoryWithHttpInfo(worktypeId, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of a worktype's attribute change history 
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorktypeChangeListing</returns>
        
        public ApiResponse< WorktypeChangeListing > GetTaskmanagementWorktypeHistoryWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeHistory");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/history";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeChangeListing>(localVarStatusCode,
                localVarHeaders,
                (WorktypeChangeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeChangeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a listing of a worktype's attribute change history 
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorktypeChangeListing</returns>
        
        public async System.Threading.Tasks.Task<WorktypeChangeListing> GetTaskmanagementWorktypeHistoryAsync (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorktypeChangeListing> localVarResponse = await GetTaskmanagementWorktypeHistoryAsyncWithHttpInfo(worktypeId, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of a worktype's attribute change history 
        /// 
        /// GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorktypeChangeListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorktypeChangeListing>> GetTaskmanagementWorktypeHistoryAsyncWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeHistory");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/history";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeChangeListing>(localVarStatusCode,
                localVarHeaders,
                (WorktypeChangeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeChangeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>WorkitemStatus</returns>
        
        public WorkitemStatus GetTaskmanagementWorktypeStatus (string worktypeId, string statusId)
        {
             ApiResponse<WorkitemStatus> localVarResponse = GetTaskmanagementWorktypeStatusWithHttpInfo(worktypeId, statusId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>ApiResponse of WorkitemStatus</returns>
        
        public ApiResponse< WorkitemStatus > GetTaskmanagementWorktypeStatusWithHttpInfo (string worktypeId, string statusId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeStatus");
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling TaskManagementApi->GetTaskmanagementWorktypeStatus");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (statusId != null) localVarPathParams.Add("statusId", this.Configuration.ApiClient.ParameterToString(statusId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatus>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of WorkitemStatus</returns>
        
        public async System.Threading.Tasks.Task<WorkitemStatus> GetTaskmanagementWorktypeStatusAsync (string worktypeId, string statusId)
        {
             ApiResponse<WorkitemStatus> localVarResponse = await GetTaskmanagementWorktypeStatusAsyncWithHttpInfo(worktypeId, statusId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <returns>Task of ApiResponse (WorkitemStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemStatus>> GetTaskmanagementWorktypeStatusAsyncWithHttpInfo (string worktypeId, string statusId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeStatus");
            
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling TaskManagementApi->GetTaskmanagementWorktypeStatus");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (statusId != null) localVarPathParams.Add("statusId", this.Configuration.ApiClient.ParameterToString(statusId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatus>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get list of statuses for this worktype. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>WorkitemStatusListing</returns>
        
        public WorkitemStatusListing GetTaskmanagementWorktypeStatuses (string worktypeId)
        {
             ApiResponse<WorkitemStatusListing> localVarResponse = GetTaskmanagementWorktypeStatusesWithHttpInfo(worktypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of statuses for this worktype. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>ApiResponse of WorkitemStatusListing</returns>
        
        public ApiResponse< WorkitemStatusListing > GetTaskmanagementWorktypeStatusesWithHttpInfo (string worktypeId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeStatuses");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatuses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatusListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatusListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatusListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get list of statuses for this worktype. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of WorkitemStatusListing</returns>
        
        public async System.Threading.Tasks.Task<WorkitemStatusListing> GetTaskmanagementWorktypeStatusesAsync (string worktypeId)
        {
             ApiResponse<WorkitemStatusListing> localVarResponse = await GetTaskmanagementWorktypeStatusesAsyncWithHttpInfo(worktypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of statuses for this worktype. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <returns>Task of ApiResponse (WorkitemStatusListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemStatusListing>> GetTaskmanagementWorktypeStatusesAsyncWithHttpInfo (string worktypeId)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeStatuses");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatuses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeStatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatusListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatusListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatusListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a version of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>WorktypeVersion</returns>
        
        public WorktypeVersion GetTaskmanagementWorktypeVersion (string worktypeId, int? entityVersion)
        {
             ApiResponse<WorktypeVersion> localVarResponse = GetTaskmanagementWorktypeVersionWithHttpInfo(worktypeId, entityVersion);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a version of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>ApiResponse of WorktypeVersion</returns>
        
        public ApiResponse< WorktypeVersion > GetTaskmanagementWorktypeVersionWithHttpInfo (string worktypeId, int? entityVersion)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeVersion");
            // verify the required parameter 'entityVersion' is set
            if (entityVersion == null)
                throw new ApiException(400, "Missing required parameter 'entityVersion' when calling TaskManagementApi->GetTaskmanagementWorktypeVersion");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/versions/{entityVersion}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (entityVersion != null) localVarPathParams.Add("entityVersion", this.Configuration.ApiClient.ParameterToString(entityVersion));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeVersion>(localVarStatusCode,
                localVarHeaders,
                (WorktypeVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a version of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>Task of WorktypeVersion</returns>
        
        public async System.Threading.Tasks.Task<WorktypeVersion> GetTaskmanagementWorktypeVersionAsync (string worktypeId, int? entityVersion)
        {
             ApiResponse<WorktypeVersion> localVarResponse = await GetTaskmanagementWorktypeVersionAsyncWithHttpInfo(worktypeId, entityVersion);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a version of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="entityVersion">Worktype version</param>
        /// <returns>Task of ApiResponse (WorktypeVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorktypeVersion>> GetTaskmanagementWorktypeVersionAsyncWithHttpInfo (string worktypeId, int? entityVersion)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeVersion");
            
            // verify the required parameter 'entityVersion' is set
            if (entityVersion == null)
                throw new ApiException(400, "Missing required parameter 'entityVersion' when calling TaskManagementApi->GetTaskmanagementWorktypeVersion");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/versions/{entityVersion}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (entityVersion != null) localVarPathParams.Add("entityVersion", this.Configuration.ApiClient.ParameterToString(entityVersion));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeVersion>(localVarStatusCode,
                localVarHeaders,
                (WorktypeVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all versions of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>WorktypeVersionListing</returns>
        
        public WorktypeVersionListing GetTaskmanagementWorktypeVersions (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorktypeVersionListing> localVarResponse = GetTaskmanagementWorktypeVersionsWithHttpInfo(worktypeId, after, pageSize, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all versions of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>ApiResponse of WorktypeVersionListing</returns>
        
        public ApiResponse< WorktypeVersionListing > GetTaskmanagementWorktypeVersionsWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeVersions");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeVersionListing>(localVarStatusCode,
                localVarHeaders,
                (WorktypeVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all versions of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of WorktypeVersionListing</returns>
        
        public async System.Threading.Tasks.Task<WorktypeVersionListing> GetTaskmanagementWorktypeVersionsAsync (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        {
             ApiResponse<WorktypeVersionListing> localVarResponse = await GetTaskmanagementWorktypeVersionsAsyncWithHttpInfo(worktypeId, after, pageSize, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all versions of a worktype 
        /// 
        /// GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional, default to 25)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to descending)</param>
        /// <returns>Task of ApiResponse (WorktypeVersionListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorktypeVersionListing>> GetTaskmanagementWorktypeVersionsAsyncWithHttpInfo (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->GetTaskmanagementWorktypeVersions");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTaskmanagementWorktypeVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeVersionListing>(localVarStatusCode,
                localVarHeaders,
                (WorktypeVersionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeVersionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>Workbin</returns>
        
        public Workbin PatchTaskmanagementWorkbin (string workbinId, WorkbinUpdate body)
        {
             ApiResponse<Workbin> localVarResponse = PatchTaskmanagementWorkbinWithHttpInfo(workbinId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>ApiResponse of Workbin</returns>
        
        public ApiResponse< Workbin > PatchTaskmanagementWorkbinWithHttpInfo (string workbinId, WorkbinUpdate body)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->PatchTaskmanagementWorkbin");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkbin");

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkbin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkbin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workbin>(localVarStatusCode,
                localVarHeaders,
                (Workbin) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workbin)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>Task of Workbin</returns>
        
        public async System.Threading.Tasks.Task<Workbin> PatchTaskmanagementWorkbinAsync (string workbinId, WorkbinUpdate body)
        {
             ApiResponse<Workbin> localVarResponse = await PatchTaskmanagementWorkbinAsyncWithHttpInfo(workbinId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workbinId">Workbin ID</param>
        /// <param name="body">Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}.</param>
        /// <returns>Task of ApiResponse (Workbin)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workbin>> PatchTaskmanagementWorkbinAsyncWithHttpInfo (string workbinId, WorkbinUpdate body)
        { 
            // verify the required parameter 'workbinId' is set
            if (workbinId == null)
                throw new ApiException(400, "Missing required parameter 'workbinId' when calling TaskManagementApi->PatchTaskmanagementWorkbin");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkbin");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/{workbinId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workbinId != null) localVarPathParams.Add("workbinId", this.Configuration.ApiClient.ParameterToString(workbinId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkbin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkbin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workbin>(localVarStatusCode,
                localVarHeaders,
                (Workbin) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workbin)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>Workitem</returns>
        
        public Workitem PatchTaskmanagementWorkitem (string workitemId, WorkitemUpdate body)
        {
             ApiResponse<Workitem> localVarResponse = PatchTaskmanagementWorkitemWithHttpInfo(workitemId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        public ApiResponse< Workitem > PatchTaskmanagementWorkitemWithHttpInfo (string workitemId, WorkitemUpdate body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitem");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitem");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitem: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>Task of Workitem</returns>
        
        public async System.Threading.Tasks.Task<Workitem> PatchTaskmanagementWorkitemAsync (string workitemId, WorkitemUpdate body)
        {
             ApiResponse<Workitem> localVarResponse = await PatchTaskmanagementWorkitemAsyncWithHttpInfo(workitemId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Workitem</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workitem>> PatchTaskmanagementWorkitemAsyncWithHttpInfo (string workitemId, WorkitemUpdate body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitem");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitem");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitem: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns></returns>
        
        public void PatchTaskmanagementWorkitemAssignment (string workitemId, WorkitemManualAssign body)
        {
             PatchTaskmanagementWorkitemAssignmentWithHttpInfo(workitemId, body);
        }

        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PatchTaskmanagementWorkitemAssignmentWithHttpInfo (string workitemId, WorkitemManualAssign body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitemAssignment");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitemAssignment");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/assignment";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PatchTaskmanagementWorkitemAssignmentAsync (string workitemId, WorkitemManualAssign body)
        {
             await PatchTaskmanagementWorkitemAssignmentAsyncWithHttpInfo(workitemId, body);

        }

        /// <summary>
        /// Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Targeted user</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchTaskmanagementWorkitemAssignmentAsyncWithHttpInfo (string workitemId, WorkitemManualAssign body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitemAssignment");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitemAssignment");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/assignment";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>WorkitemWrapup</returns>
        
        public WorkitemWrapup PatchTaskmanagementWorkitemUserWrapups (string workitemId, string userId, WorkitemWrapupUpdate body)
        {
             ApiResponse<WorkitemWrapup> localVarResponse = PatchTaskmanagementWorkitemUserWrapupsWithHttpInfo(workitemId, userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>ApiResponse of WorkitemWrapup</returns>
        
        public ApiResponse< WorkitemWrapup > PatchTaskmanagementWorkitemUserWrapupsWithHttpInfo (string workitemId, string userId, WorkitemWrapupUpdate body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitemUserWrapups");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling TaskManagementApi->PatchTaskmanagementWorkitemUserWrapups");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitemUserWrapups");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUserWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUserWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapup>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>Task of WorkitemWrapup</returns>
        
        public async System.Threading.Tasks.Task<WorkitemWrapup> PatchTaskmanagementWorkitemUserWrapupsAsync (string workitemId, string userId, WorkitemWrapupUpdate body)
        {
             ApiResponse<WorkitemWrapup> localVarResponse = await PatchTaskmanagementWorkitemUserWrapupsAsyncWithHttpInfo(workitemId, userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add/Remove a wrapup code for a given user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="userId">The ID of the user</param>
        /// <param name="body">Request body to add/remove a wrapup code for a workitem</param>
        /// <returns>Task of ApiResponse (WorkitemWrapup)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemWrapup>> PatchTaskmanagementWorkitemUserWrapupsAsyncWithHttpInfo (string workitemId, string userId, WorkitemWrapupUpdate body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitemUserWrapups");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling TaskManagementApi->PatchTaskmanagementWorkitemUserWrapups");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitemUserWrapups");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUserWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUserWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapup>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>WorkitemWrapup</returns>
        
        public WorkitemWrapup PatchTaskmanagementWorkitemUsersMeWrapups (string workitemId, WorkitemWrapupUpdate body)
        {
             ApiResponse<WorkitemWrapup> localVarResponse = PatchTaskmanagementWorkitemUsersMeWrapupsWithHttpInfo(workitemId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>ApiResponse of WorkitemWrapup</returns>
        
        public ApiResponse< WorkitemWrapup > PatchTaskmanagementWorkitemUsersMeWrapupsWithHttpInfo (string workitemId, WorkitemWrapupUpdate body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitemUsersMeWrapups");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitemUsersMeWrapups");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/users/me/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUsersMeWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUsersMeWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapup>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>Task of WorkitemWrapup</returns>
        
        public async System.Threading.Tasks.Task<WorkitemWrapup> PatchTaskmanagementWorkitemUsersMeWrapupsAsync (string workitemId, WorkitemWrapupUpdate body)
        {
             ApiResponse<WorkitemWrapup> localVarResponse = await PatchTaskmanagementWorkitemUsersMeWrapupsAsyncWithHttpInfo(workitemId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add/Remove a wrapup code for the current user in a workitem. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">The ID of the Workitem.</param>
        /// <param name="body">Request body to add/remove the wrapup code for workitem</param>
        /// <returns>Task of ApiResponse (WorkitemWrapup)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemWrapup>> PatchTaskmanagementWorkitemUsersMeWrapupsAsyncWithHttpInfo (string workitemId, WorkitemWrapupUpdate body)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PatchTaskmanagementWorkitemUsersMeWrapups");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PatchTaskmanagementWorkitemUsersMeWrapups");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/users/me/wrapups";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUsersMeWrapups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorkitemUsersMeWrapups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemWrapup>(localVarStatusCode,
                localVarHeaders,
                (WorkitemWrapup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemWrapup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Worktype</returns>
        
        public Worktype PatchTaskmanagementWorktype (string worktypeId, WorktypeUpdate body = null)
        {
             ApiResponse<Worktype> localVarResponse = PatchTaskmanagementWorktypeWithHttpInfo(worktypeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Worktype</returns>
        
        public ApiResponse< Worktype > PatchTaskmanagementWorktypeWithHttpInfo (string worktypeId, WorktypeUpdate body = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->PatchTaskmanagementWorktype");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Worktype>(localVarStatusCode,
                localVarHeaders,
                (Worktype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Worktype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of Worktype</returns>
        
        public async System.Threading.Tasks.Task<Worktype> PatchTaskmanagementWorktypeAsync (string worktypeId, WorktypeUpdate body = null)
        {
             ApiResponse<Worktype> localVarResponse = await PatchTaskmanagementWorktypeAsyncWithHttpInfo(worktypeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (Worktype)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Worktype>> PatchTaskmanagementWorktypeAsyncWithHttpInfo (string worktypeId, WorktypeUpdate body = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->PatchTaskmanagementWorktype");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Worktype>(localVarStatusCode,
                localVarHeaders,
                (Worktype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Worktype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkitemStatus</returns>
        
        public WorkitemStatus PatchTaskmanagementWorktypeStatus (string worktypeId, string statusId, WorkitemStatusUpdate body = null)
        {
             ApiResponse<WorkitemStatus> localVarResponse = PatchTaskmanagementWorktypeStatusWithHttpInfo(worktypeId, statusId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkitemStatus</returns>
        
        public ApiResponse< WorkitemStatus > PatchTaskmanagementWorktypeStatusWithHttpInfo (string worktypeId, string statusId, WorkitemStatusUpdate body = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->PatchTaskmanagementWorktypeStatus");
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling TaskManagementApi->PatchTaskmanagementWorktypeStatus");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (statusId != null) localVarPathParams.Add("statusId", this.Configuration.ApiClient.ParameterToString(statusId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktypeStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktypeStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatus>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkitemStatus</returns>
        
        public async System.Threading.Tasks.Task<WorkitemStatus> PatchTaskmanagementWorktypeStatusAsync (string worktypeId, string statusId, WorkitemStatusUpdate body = null)
        {
             ApiResponse<WorkitemStatus> localVarResponse = await PatchTaskmanagementWorktypeStatusAsyncWithHttpInfo(worktypeId, statusId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a status 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="statusId">Status id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkitemStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemStatus>> PatchTaskmanagementWorktypeStatusAsyncWithHttpInfo (string worktypeId, string statusId, WorkitemStatusUpdate body = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->PatchTaskmanagementWorktypeStatus");
            
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling TaskManagementApi->PatchTaskmanagementWorktypeStatus");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));
            if (statusId != null) localVarPathParams.Add("statusId", this.Configuration.ApiClient.ParameterToString(statusId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktypeStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTaskmanagementWorktypeStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatus>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Workbin</returns>
        
        public Workbin PostTaskmanagementWorkbins (WorkbinCreate body = null)
        {
             ApiResponse<Workbin> localVarResponse = PostTaskmanagementWorkbinsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Workbin</returns>
        
        public ApiResponse< Workbin > PostTaskmanagementWorkbinsWithHttpInfo (WorkbinCreate body = null)
        { 

            var localVarPath = "/api/v2/taskmanagement/workbins";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbins: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbins: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workbin>(localVarStatusCode,
                localVarHeaders,
                (Workbin) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workbin)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of Workbin</returns>
        
        public async System.Threading.Tasks.Task<Workbin> PostTaskmanagementWorkbinsAsync (WorkbinCreate body = null)
        {
             ApiResponse<Workbin> localVarResponse = await PostTaskmanagementWorkbinsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a workbin 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (Workbin)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workbin>> PostTaskmanagementWorkbinsAsyncWithHttpInfo (WorkbinCreate body = null)
        { 

            var localVarPath = "/api/v2/taskmanagement/workbins";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbins: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbins: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workbin>(localVarStatusCode,
                localVarHeaders,
                (Workbin) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workbin)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for workbins 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>WorkbinQueryEntityListing</returns>
        
        public WorkbinQueryEntityListing PostTaskmanagementWorkbinsQuery (WorkbinQueryRequest body)
        {
             ApiResponse<WorkbinQueryEntityListing> localVarResponse = PostTaskmanagementWorkbinsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for workbins 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>ApiResponse of WorkbinQueryEntityListing</returns>
        
        public ApiResponse< WorkbinQueryEntityListing > PostTaskmanagementWorkbinsQueryWithHttpInfo (WorkbinQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkbinsQuery");

            var localVarPath = "/api/v2/taskmanagement/workbins/query";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbinsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbinsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkbinQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for workbins 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of WorkbinQueryEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WorkbinQueryEntityListing> PostTaskmanagementWorkbinsQueryAsync (WorkbinQueryRequest body)
        {
             ApiResponse<WorkbinQueryEntityListing> localVarResponse = await PostTaskmanagementWorkbinsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for workbins 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of ApiResponse (WorkbinQueryEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkbinQueryEntityListing>> PostTaskmanagementWorkbinsQueryAsyncWithHttpInfo (WorkbinQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkbinsQuery");
            

            var localVarPath = "/api/v2/taskmanagement/workbins/query";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbinsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkbinsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkbinQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkbinQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkbinQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Workitem</returns>
        
        public Workitem PostTaskmanagementWorkitemAcdCancel (string workitemId)
        {
             ApiResponse<Workitem> localVarResponse = PostTaskmanagementWorkitemAcdCancelWithHttpInfo(workitemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        public ApiResponse< Workitem > PostTaskmanagementWorkitemAcdCancelWithHttpInfo (string workitemId)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PostTaskmanagementWorkitemAcdCancel");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/acd/cancel";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemAcdCancel: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemAcdCancel: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of Workitem</returns>
        
        public async System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemAcdCancelAsync (string workitemId)
        {
             ApiResponse<Workitem> localVarResponse = await PostTaskmanagementWorkitemAcdCancelAsyncWithHttpInfo(workitemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel the assignment process for a workitem that is currently queued for assignment through ACD. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemAcdCancelAsyncWithHttpInfo (string workitemId)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PostTaskmanagementWorkitemAcdCancel");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/acd/cancel";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemAcdCancel: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemAcdCancel: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Disconnect the assignee of the workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Workitem</returns>
        
        public Workitem PostTaskmanagementWorkitemDisconnect (string workitemId)
        {
             ApiResponse<Workitem> localVarResponse = PostTaskmanagementWorkitemDisconnectWithHttpInfo(workitemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disconnect the assignee of the workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        public ApiResponse< Workitem > PostTaskmanagementWorkitemDisconnectWithHttpInfo (string workitemId)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PostTaskmanagementWorkitemDisconnect");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/disconnect";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemDisconnect: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemDisconnect: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Disconnect the assignee of the workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of Workitem</returns>
        
        public async System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemDisconnectAsync (string workitemId)
        {
             ApiResponse<Workitem> localVarResponse = await PostTaskmanagementWorkitemDisconnectAsyncWithHttpInfo(workitemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disconnect the assignee of the workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemDisconnectAsyncWithHttpInfo (string workitemId)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PostTaskmanagementWorkitemDisconnect");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/disconnect";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemDisconnect: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemDisconnect: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Terminate a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>Workitem</returns>
        
        public Workitem PostTaskmanagementWorkitemTerminate (string workitemId, WorkitemTerminate body = null)
        {
             ApiResponse<Workitem> localVarResponse = PostTaskmanagementWorkitemTerminateWithHttpInfo(workitemId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Terminate a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        public ApiResponse< Workitem > PostTaskmanagementWorkitemTerminateWithHttpInfo (string workitemId, WorkitemTerminate body = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PostTaskmanagementWorkitemTerminate");

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/terminate";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemTerminate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemTerminate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Terminate a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>Task of Workitem</returns>
        
        public async System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemTerminateAsync (string workitemId, WorkitemTerminate body = null)
        {
             ApiResponse<Workitem> localVarResponse = await PostTaskmanagementWorkitemTerminateAsyncWithHttpInfo(workitemId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Terminate a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workitemId">Workitem ID</param>
        /// <param name="body">Terminated request (optional)</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemTerminateAsyncWithHttpInfo (string workitemId, WorkitemTerminate body = null)
        { 
            // verify the required parameter 'workitemId' is set
            if (workitemId == null)
                throw new ApiException(400, "Missing required parameter 'workitemId' when calling TaskManagementApi->PostTaskmanagementWorkitemTerminate");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/{workitemId}/terminate";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (workitemId != null) localVarPathParams.Add("workitemId", this.Configuration.ApiClient.ParameterToString(workitemId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemTerminate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemTerminate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>Workitem</returns>
        
        public Workitem PostTaskmanagementWorkitems (WorkitemCreate body)
        {
             ApiResponse<Workitem> localVarResponse = PostTaskmanagementWorkitemsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>ApiResponse of Workitem</returns>
        
        public ApiResponse< Workitem > PostTaskmanagementWorkitemsWithHttpInfo (WorkitemCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitems");

            var localVarPath = "/api/v2/taskmanagement/workitems";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitems: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitems: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>Task of Workitem</returns>
        
        public async System.Threading.Tasks.Task<Workitem> PostTaskmanagementWorkitemsAsync (WorkitemCreate body)
        {
             ApiResponse<Workitem> localVarResponse = await PostTaskmanagementWorkitemsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a workitem 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workitem</param>
        /// <returns>Task of ApiResponse (Workitem)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Workitem>> PostTaskmanagementWorkitemsAsyncWithHttpInfo (WorkitemCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitems");
            

            var localVarPath = "/api/v2/taskmanagement/workitems";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitems: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitems: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workitem>(localVarStatusCode,
                localVarHeaders,
                (Workitem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workitem)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for workitems 
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>WorkitemPostQueryEntityListing</returns>
        
        public WorkitemPostQueryEntityListing PostTaskmanagementWorkitemsQuery (WorkitemQueryPostRequest body)
        {
             ApiResponse<WorkitemPostQueryEntityListing> localVarResponse = PostTaskmanagementWorkitemsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for workitems 
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>ApiResponse of WorkitemPostQueryEntityListing</returns>
        
        public ApiResponse< WorkitemPostQueryEntityListing > PostTaskmanagementWorkitemsQueryWithHttpInfo (WorkitemQueryPostRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitemsQuery");

            var localVarPath = "/api/v2/taskmanagement/workitems/query";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemPostQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemPostQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemPostQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for workitems 
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>Task of WorkitemPostQueryEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WorkitemPostQueryEntityListing> PostTaskmanagementWorkitemsQueryAsync (WorkitemQueryPostRequest body)
        {
             ApiResponse<WorkitemPostQueryEntityListing> localVarResponse = await PostTaskmanagementWorkitemsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for workitems 
        /// This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.
        /// PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryPostRequest</param>
        /// <returns>Task of ApiResponse (WorkitemPostQueryEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemPostQueryEntityListing>> PostTaskmanagementWorkitemsQueryAsyncWithHttpInfo (WorkitemQueryPostRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitemsQuery");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/query";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemPostQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorkitemPostQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemPostQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a workitem query job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>WorkitemQueryJobResponse</returns>
        
        public WorkitemQueryJobResponse PostTaskmanagementWorkitemsQueryJobs (WorkitemQueryJobCreate body)
        {
             ApiResponse<WorkitemQueryJobResponse> localVarResponse = PostTaskmanagementWorkitemsQueryJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a workitem query job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>ApiResponse of WorkitemQueryJobResponse</returns>
        
        public ApiResponse< WorkitemQueryJobResponse > PostTaskmanagementWorkitemsQueryJobsWithHttpInfo (WorkitemQueryJobCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitemsQueryJobs");

            var localVarPath = "/api/v2/taskmanagement/workitems/query/jobs";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQueryJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQueryJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemQueryJobResponse>(localVarStatusCode,
                localVarHeaders,
                (WorkitemQueryJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemQueryJobResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a workitem query job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>Task of WorkitemQueryJobResponse</returns>
        
        public async System.Threading.Tasks.Task<WorkitemQueryJobResponse> PostTaskmanagementWorkitemsQueryJobsAsync (WorkitemQueryJobCreate body)
        {
             ApiResponse<WorkitemQueryJobResponse> localVarResponse = await PostTaskmanagementWorkitemsQueryJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a workitem query job 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkitemQueryJobCreate</param>
        /// <returns>Task of ApiResponse (WorkitemQueryJobResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemQueryJobResponse>> PostTaskmanagementWorkitemsQueryJobsAsyncWithHttpInfo (WorkitemQueryJobCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitemsQueryJobs");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/query/jobs";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQueryJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsQueryJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemQueryJobResponse>(localVarStatusCode,
                localVarHeaders,
                (WorkitemQueryJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemQueryJobResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema PostTaskmanagementWorkitemsSchemas (DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = PostTaskmanagementWorkitemsSchemasWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > PostTaskmanagementWorkitemsSchemasWithHttpInfo (DataSchema body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitemsSchemas");

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> PostTaskmanagementWorkitemsSchemasAsync (DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = await PostTaskmanagementWorkitemsSchemasAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> PostTaskmanagementWorkitemsSchemasAsyncWithHttpInfo (DataSchema body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorkitemsSchemas");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorkitemsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add a status to a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkitemStatus</returns>
        
        public WorkitemStatus PostTaskmanagementWorktypeStatuses (string worktypeId, WorkitemStatusCreate body = null)
        {
             ApiResponse<WorkitemStatus> localVarResponse = PostTaskmanagementWorktypeStatusesWithHttpInfo(worktypeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a status to a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkitemStatus</returns>
        
        public ApiResponse< WorkitemStatus > PostTaskmanagementWorktypeStatusesWithHttpInfo (string worktypeId, WorkitemStatusCreate body = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->PostTaskmanagementWorktypeStatuses");

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypeStatuses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypeStatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatus>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add a status to a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkitemStatus</returns>
        
        public async System.Threading.Tasks.Task<WorkitemStatus> PostTaskmanagementWorktypeStatusesAsync (string worktypeId, WorkitemStatusCreate body = null)
        {
             ApiResponse<WorkitemStatus> localVarResponse = await PostTaskmanagementWorktypeStatusesAsyncWithHttpInfo(worktypeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a status to a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worktypeId">Worktype id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkitemStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorkitemStatus>> PostTaskmanagementWorktypeStatusesAsyncWithHttpInfo (string worktypeId, WorkitemStatusCreate body = null)
        { 
            // verify the required parameter 'worktypeId' is set
            if (worktypeId == null)
                throw new ApiException(400, "Missing required parameter 'worktypeId' when calling TaskManagementApi->PostTaskmanagementWorktypeStatuses");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/{worktypeId}/statuses";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (worktypeId != null) localVarPathParams.Add("worktypeId", this.Configuration.ApiClient.ParameterToString(worktypeId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypeStatuses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypeStatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkitemStatus>(localVarStatusCode,
                localVarHeaders,
                (WorkitemStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkitemStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Worktype</returns>
        
        public Worktype PostTaskmanagementWorktypes (WorktypeCreate body = null)
        {
             ApiResponse<Worktype> localVarResponse = PostTaskmanagementWorktypesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Worktype</returns>
        
        public ApiResponse< Worktype > PostTaskmanagementWorktypesWithHttpInfo (WorktypeCreate body = null)
        { 

            var localVarPath = "/api/v2/taskmanagement/worktypes";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Worktype>(localVarStatusCode,
                localVarHeaders,
                (Worktype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Worktype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of Worktype</returns>
        
        public async System.Threading.Tasks.Task<Worktype> PostTaskmanagementWorktypesAsync (WorktypeCreate body = null)
        {
             ApiResponse<Worktype> localVarResponse = await PostTaskmanagementWorktypesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a worktype 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (Worktype)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Worktype>> PostTaskmanagementWorktypesAsyncWithHttpInfo (WorktypeCreate body = null)
        { 

            var localVarPath = "/api/v2/taskmanagement/worktypes";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Worktype>(localVarStatusCode,
                localVarHeaders,
                (Worktype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Worktype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for worktypes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>WorktypeQueryEntityListing</returns>
        
        public WorktypeQueryEntityListing PostTaskmanagementWorktypesQuery (WorktypeQueryRequest body)
        {
             ApiResponse<WorktypeQueryEntityListing> localVarResponse = PostTaskmanagementWorktypesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for worktypes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>ApiResponse of WorktypeQueryEntityListing</returns>
        
        public ApiResponse< WorktypeQueryEntityListing > PostTaskmanagementWorktypesQueryWithHttpInfo (WorktypeQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorktypesQuery");

            var localVarPath = "/api/v2/taskmanagement/worktypes/query";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorktypeQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for worktypes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of WorktypeQueryEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WorktypeQueryEntityListing> PostTaskmanagementWorktypesQueryAsync (WorktypeQueryRequest body)
        {
             ApiResponse<WorktypeQueryEntityListing> localVarResponse = await PostTaskmanagementWorktypesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for worktypes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QueryPostRequest</param>
        /// <returns>Task of ApiResponse (WorktypeQueryEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WorktypeQueryEntityListing>> PostTaskmanagementWorktypesQueryAsyncWithHttpInfo (WorktypeQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PostTaskmanagementWorktypesQuery");
            

            var localVarPath = "/api/v2/taskmanagement/worktypes/query";
            var localVarPathParams = new Dictionary<String, String>();
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTaskmanagementWorktypesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorktypeQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WorktypeQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorktypeQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema PutTaskmanagementWorkitemsSchema (string schemaId, DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = PutTaskmanagementWorkitemsSchemaWithHttpInfo(schemaId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > PutTaskmanagementWorkitemsSchemaWithHttpInfo (string schemaId, DataSchema body)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->PutTaskmanagementWorkitemsSchema");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PutTaskmanagementWorkitemsSchema");

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutTaskmanagementWorkitemsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTaskmanagementWorkitemsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> PutTaskmanagementWorkitemsSchemaAsync (string schemaId, DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = await PutTaskmanagementWorkitemsSchemaAsyncWithHttpInfo(schemaId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> PutTaskmanagementWorkitemsSchemaAsyncWithHttpInfo (string schemaId, DataSchema body)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling TaskManagementApi->PutTaskmanagementWorkitemsSchema");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskManagementApi->PutTaskmanagementWorkitemsSchema");
            

            var localVarPath = "/api/v2/taskmanagement/workitems/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutTaskmanagementWorkitemsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutTaskmanagementWorkitemsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
