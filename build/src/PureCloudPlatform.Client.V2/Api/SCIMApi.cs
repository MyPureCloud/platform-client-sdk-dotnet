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
    public interface ISCIMApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Empty</returns>
        Empty DeleteScimUser (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> DeleteScimUserWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Empty</returns>
        Empty DeleteScimV2User (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> DeleteScimV2UserWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group GetScimGroup (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> GetScimGroupWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ScimListResponse</returns>
        ScimListResponse GetScimGroups (int? startIndex = null, int? count = null, string filter = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        ApiResponse<ScimListResponse> GetScimGroupsWithHttpInfo (int? startIndex = null, int? count = null, string filter = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User GetScimUser (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> GetScimUserWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ScimListResponse</returns>
        ScimListResponse GetScimUsers (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        ApiResponse<ScimListResponse> GetScimUsersWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group GetScimV2Group (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> GetScimV2GroupWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ScimListResponse</returns>
        ScimListResponse GetScimV2Groups (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        ApiResponse<ScimListResponse> GetScimV2GroupsWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get the SCIM configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimServiceProviderConfig</returns>
        ScimServiceProviderConfig GetScimV2Serviceproviderconfig (string ifNoneMatch = null);

        /// <summary>
        /// Get the SCIM configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimServiceProviderConfig</returns>
        ApiResponse<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigWithHttpInfo (string ifNoneMatch = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User GetScimV2User (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> GetScimV2UserWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ScimListResponse</returns>
        ScimListResponse GetScimV2Users (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        ApiResponse<ScimListResponse> GetScimV2UsersWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PatchScimGroup (string groupId, PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PatchScimGroupWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PatchScimUser (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PatchScimUserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PatchScimV2Group (string groupId, PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PatchScimV2GroupWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PatchScimV2User (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PatchScimV2UserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PostScimUsers (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PostScimUsersWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PostScimV2Users (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PostScimV2UsersWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PutScimGroup (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PutScimGroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PutScimUser (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PutScimUserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PutScimV2Group (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PutScimV2GroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PutScimV2User (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PutScimV2UserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> DeleteScimUserAsync (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimUserAsyncWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> DeleteScimV2UserAsync (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimV2UserAsyncWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> GetScimGroupAsync (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimGroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ScimListResponse</returns>
        System.Threading.Tasks.Task<ScimListResponse> GetScimGroupsAsync (int? startIndex = null, int? count = null, string filter = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimGroupsAsyncWithHttpInfo (int? startIndex = null, int? count = null, string filter = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> GetScimUserAsync (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimUserAsyncWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ScimListResponse</returns>
        System.Threading.Tasks.Task<ScimListResponse> GetScimUsersAsync (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimUsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> GetScimV2GroupAsync (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimV2GroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ScimListResponse</returns>
        System.Threading.Tasks.Task<ScimListResponse> GetScimV2GroupsAsync (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimV2GroupsAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get the SCIM configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimServiceProviderConfig</returns>
        System.Threading.Tasks.Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync (string ifNoneMatch = null);

        /// <summary>
        /// Get the SCIM configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimServiceProviderConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimServiceProviderConfig>> GetScimV2ServiceproviderconfigAsyncWithHttpInfo (string ifNoneMatch = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> GetScimV2UserAsync (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimV2UserAsyncWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ScimListResponse</returns>
        System.Threading.Tasks.Task<ScimListResponse> GetScimV2UsersAsync (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimV2UsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PatchScimGroupAsync (string groupId, PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimGroupAsyncWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PatchScimUserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimUserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PatchScimV2GroupAsync (string groupId, PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimV2GroupAsyncWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PatchScimV2UserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimV2UserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PostScimUsersAsync (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimUsersAsyncWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PostScimV2UsersAsync (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimV2UsersAsyncWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PutScimGroupAsync (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimGroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PutScimUserAsync (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimUserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PutScimV2GroupAsync (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimV2GroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PutScimV2UserAsync (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimV2UserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SCIMApi : ISCIMApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SCIMApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SCIMApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Empty</returns>
        public Empty DeleteScimUser (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = DeleteScimUserWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > DeleteScimUserWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> DeleteScimUserAsync (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = await DeleteScimUserAsyncWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimUserAsyncWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Empty</returns>
        public Empty DeleteScimV2User (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = DeleteScimV2UserWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > DeleteScimV2UserWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> DeleteScimV2UserAsync (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = await DeleteScimV2UserAsyncWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimV2UserAsyncWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group GetScimGroup (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = GetScimGroupWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > GetScimGroupWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimGroup");

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> GetScimGroupAsync (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await GetScimGroupAsyncWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimGroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimGroup");
            

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ScimListResponse</returns>
        public ScimListResponse GetScimGroups (int? startIndex = null, int? count = null, string filter = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = GetScimGroupsWithHttpInfo(startIndex, count, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        public ApiResponse< ScimListResponse > GetScimGroupsWithHttpInfo (int? startIndex = null, int? count = null, string filter = null)
        { 

            var localVarPath = "/api/v2/scim/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ScimListResponse</returns>
        public async System.Threading.Tasks.Task<ScimListResponse> GetScimGroupsAsync (int? startIndex = null, int? count = null, string filter = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = await GetScimGroupsAsyncWithHttpInfo(startIndex, count, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimGroupsAsyncWithHttpInfo (int? startIndex = null, int? count = null, string filter = null)
        { 

            var localVarPath = "/api/v2/scim/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User GetScimUser (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = GetScimUserWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > GetScimUserWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> GetScimUserAsync (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await GetScimUserAsyncWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimUserAsyncWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ScimListResponse</returns>
        public ScimListResponse GetScimUsers (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = GetScimUsersWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        public ApiResponse< ScimListResponse > GetScimUsersWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimUsers");

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ScimListResponse</returns>
        public async System.Threading.Tasks.Task<ScimListResponse> GetScimUsersAsync (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = await GetScimUsersAsyncWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimUsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimUsers");
            

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group GetScimV2Group (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = GetScimV2GroupWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > GetScimV2GroupWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimV2Group");

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> GetScimV2GroupAsync (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await GetScimV2GroupAsyncWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimV2GroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimV2Group");
            

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ScimListResponse</returns>
        public ScimListResponse GetScimV2Groups (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = GetScimV2GroupsWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        public ApiResponse< ScimListResponse > GetScimV2GroupsWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Groups");

            var localVarPath = "/api/v2/scim/v2/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ScimListResponse</returns>
        public async System.Threading.Tasks.Task<ScimListResponse> GetScimV2GroupsAsync (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = await GetScimV2GroupsAsyncWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimV2GroupsAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Groups");
            

            var localVarPath = "/api/v2/scim/v2/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the SCIM configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimServiceProviderConfig</returns>
        public ScimServiceProviderConfig GetScimV2Serviceproviderconfig (string ifNoneMatch = null)
        {
             ApiResponse<ScimServiceProviderConfig> localVarResponse = GetScimV2ServiceproviderconfigWithHttpInfo(ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the SCIM configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimServiceProviderConfig</returns>
        public ApiResponse< ScimServiceProviderConfig > GetScimV2ServiceproviderconfigWithHttpInfo (string ifNoneMatch = null)
        { 

            var localVarPath = "/api/v2/scim/v2/serviceproviderconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimServiceProviderConfig>(localVarStatusCode,
                localVarHeaders,
                (ScimServiceProviderConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimServiceProviderConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the SCIM configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimServiceProviderConfig</returns>
        public async System.Threading.Tasks.Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync (string ifNoneMatch = null)
        {
             ApiResponse<ScimServiceProviderConfig> localVarResponse = await GetScimV2ServiceproviderconfigAsyncWithHttpInfo(ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the SCIM configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimServiceProviderConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimServiceProviderConfig>> GetScimV2ServiceproviderconfigAsyncWithHttpInfo (string ifNoneMatch = null)
        { 

            var localVarPath = "/api/v2/scim/v2/serviceproviderconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimServiceProviderConfig>(localVarStatusCode,
                localVarHeaders,
                (ScimServiceProviderConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimServiceProviderConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User GetScimV2User (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = GetScimV2UserWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > GetScimV2UserWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> GetScimV2UserAsync (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await GetScimV2UserAsyncWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource. If no match is found, returns request. If match is found, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimV2UserAsyncWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ScimListResponse</returns>
        public ScimListResponse GetScimV2Users (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = GetScimV2UsersWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimListResponse</returns>
        public ApiResponse< ScimListResponse > GetScimV2UsersWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Users");

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ScimListResponse</returns>
        public async System.Threading.Tasks.Task<ScimListResponse> GetScimV2UsersAsync (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimListResponse> localVarResponse = await GetScimV2UsersAsyncWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns totalResults. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimListResponse>> GetScimV2UsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Users");
            

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PatchScimGroup (string groupId, PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PatchScimGroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PatchScimGroupWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimGroup");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimGroup");

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PatchScimGroupAsync (string groupId, PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PatchScimGroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimGroupAsyncWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimGroup");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimGroup");
            

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PatchScimUser (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PatchScimUserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PatchScimUserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimUser");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PatchScimUserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PatchScimUserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimUserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimUser");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PatchScimV2Group (string groupId, PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PatchScimV2GroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PatchScimV2GroupWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimV2Group");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2Group");

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PatchScimV2GroupAsync (string groupId, PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PatchScimV2GroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimV2GroupAsyncWithHttpInfo (string groupId, PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimV2Group");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2Group");
            

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PatchScimV2User (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PatchScimV2UserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PatchScimV2UserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimV2User");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PatchScimV2UserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PatchScimV2UserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">SCIM Patch Request</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimV2UserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimV2User");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PostScimUsers (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = PostScimUsersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PostScimUsersWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimUsers");

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PostScimUsersAsync (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = await PostScimUsersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimUsersAsyncWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimUsers");
            

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PostScimV2Users (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = PostScimV2UsersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PostScimV2UsersWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimV2Users");

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PostScimV2UsersAsync (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = await PostScimV2UsersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SCIM Create User</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimV2UsersAsyncWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimV2Users");
            

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PutScimGroup (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PutScimGroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PutScimGroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimGroup");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimGroup");

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PutScimGroupAsync (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PutScimGroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimGroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimGroup");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimGroup");
            

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PutScimUser (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PutScimUserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PutScimUserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimUser");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PutScimUserAsync (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PutScimUserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimUserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimUser");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PutScimV2Group (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PutScimV2GroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PutScimV2GroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimV2Group");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2Group");

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PutScimV2GroupAsync (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PutScimV2GroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">Group</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimV2GroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimV2Group");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2Group");
            

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PutScimV2User (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PutScimV2UserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PutScimV2UserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimV2User");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PutScimV2UserAsync (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PutScimV2UserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">User</param>
        /// <param name="ifMatch">The ETag of a resource. If no match is found, returns 412 Precondition Failed. If match is found, performs request. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimV2UserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimV2User");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
