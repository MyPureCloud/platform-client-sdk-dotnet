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
    public interface IAuthorizationApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        void DeleteAuthorizationRole (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAuthorizationRoleWithHttpInfo (string roleId);
        
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        void DeleteUserRoles (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserRolesWithHttpInfo (string userId);
        
        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        PermissionCollectionEntityListing GetAuthorizationPermissions (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        ApiResponse<PermissionCollectionEntityListing> GetAuthorizationPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        OrganizationProductEntityListing GetAuthorizationProducts ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        ApiResponse<OrganizationProductEntityListing> GetAuthorizationProductsWithHttpInfo ();
        
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole GetAuthorizationRole (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> GetAuthorizationRoleWithHttpInfo (string roleId);
        
        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference GetAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId);

        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> GetAuthorizationRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId);
        
        /// <summary>
        /// Retrieve a list of all roles defined for the organization
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
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing GetAuthorizationRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null);

        /// <summary>
        /// Retrieve a list of all roles defined for the organization
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
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> GetAuthorizationRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null);
        
        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        UserAuthorization GetUserRoles (string userId);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        ApiResponse<UserAuthorization> GetUserRolesWithHttpInfo (string userId);
        
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PatchAuthorizationRole (string roleId, DomainOrganizationRole body);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PatchAuthorizationRoleWithHttpInfo (string roleId, DomainOrganizationRole body);
        
        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference PostAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body);

        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> PostAuthorizationRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body);
        
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PostAuthorizationRoles (DomainOrganizationRoleCreate body);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PostAuthorizationRolesWithHttpInfo (DomainOrganizationRoleCreate body);
        
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing PostAuthorizationRolesDefault (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> PostAuthorizationRolesDefaultWithHttpInfo (bool? force = null);
        
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PutAuthorizationRole (string roleId, DomainOrganizationRoleUpdate body);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PutAuthorizationRoleWithHttpInfo (string roleId, DomainOrganizationRoleUpdate body);
        
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> PutAuthorizationRoleUsersAdd (string roleId, List<string> body);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> PutAuthorizationRoleUsersAddWithHttpInfo (string roleId, List<string> body);
        
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> PutAuthorizationRoleUsersRemove (string roleId, List<string> body);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> PutAuthorizationRoleUsersRemoveWithHttpInfo (string roleId, List<string> body);
        
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing PutAuthorizationRolesDefault (List<DomainOrganizationRole> body);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> PutAuthorizationRolesDefaultWithHttpInfo (List<DomainOrganizationRole> body);
        
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>UserAuthorization</returns>
        UserAuthorization PutUserRoles (string userId, List<string> body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        ApiResponse<UserAuthorization> PutUserRolesWithHttpInfo (string userId, List<string> body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAuthorizationRoleAsync (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationRoleAsyncWithHttpInfo (string roleId);
        
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserRolesAsync (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRolesAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetAuthorizationPermissionsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetAuthorizationPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationProductEntityListing> GetAuthorizationProductsAsync ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetAuthorizationProductsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> GetAuthorizationRoleAsync (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetAuthorizationRoleAsyncWithHttpInfo (string roleId);
        
        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> GetAuthorizationRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId);

        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> GetAuthorizationRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId);
        
        /// <summary>
        /// Retrieve a list of all roles defined for the organization
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
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetAuthorizationRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null);

        /// <summary>
        /// Retrieve a list of all roles defined for the organization
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
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetAuthorizationRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null);
        
        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string userId);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PatchAuthorizationRoleAsync (string roleId, DomainOrganizationRole body);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PatchAuthorizationRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body);
        
        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> PostAuthorizationRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body);

        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> PostAuthorizationRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body);
        
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PostAuthorizationRolesAsync (DomainOrganizationRoleCreate body);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PostAuthorizationRolesAsyncWithHttpInfo (DomainOrganizationRoleCreate body);
        
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> PostAuthorizationRolesDefaultAsync (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PostAuthorizationRolesDefaultAsyncWithHttpInfo (bool? force = null);
        
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PutAuthorizationRoleAsync (string roleId, DomainOrganizationRoleUpdate body);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PutAuthorizationRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRoleUpdate body);
        
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> PutAuthorizationRoleUsersAddAsync (string roleId, List<string> body);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> PutAuthorizationRoleUsersAddAsyncWithHttpInfo (string roleId, List<string> body);
        
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> PutAuthorizationRoleUsersRemoveAsync (string roleId, List<string> body);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> PutAuthorizationRoleUsersRemoveAsyncWithHttpInfo (string roleId, List<string> body);
        
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> PutAuthorizationRolesDefaultAsync (List<DomainOrganizationRole> body);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PutAuthorizationRolesDefaultAsyncWithHttpInfo (List<DomainOrganizationRole> body);
        
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of UserAuthorization</returns>
        System.Threading.Tasks.Task<UserAuthorization> PutUserRolesAsync (string userId, List<string> body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> PutUserRolesAsyncWithHttpInfo (string userId, List<string> body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizationApi : IAuthorizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration = null)
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
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        public void DeleteAuthorizationRole (string roleId)
        {
             DeleteAuthorizationRoleWithHttpInfo(roleId);
        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAuthorizationRoleWithHttpInfo (string roleId)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->DeleteAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAuthorizationRoleAsync (string roleId)
        {
             await DeleteAuthorizationRoleAsyncWithHttpInfo(roleId);

        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationRoleAsyncWithHttpInfo (string roleId)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->DeleteAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        public void DeleteUserRoles (string userId)
        {
             DeleteUserRolesWithHttpInfo(userId);
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserRolesWithHttpInfo (string userId)
        {
            
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->DeleteUserRoles");
            
            

            var localVarPath = "/api/v2/users/{userId}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserRolesAsync (string userId)
        {
             await DeleteUserRolesAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRolesAsyncWithHttpInfo (string userId)
        {
            
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->DeleteUserRoles");
            
            

            var localVarPath = "/api/v2/users/{userId}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        public PermissionCollectionEntityListing GetAuthorizationPermissions (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = GetAuthorizationPermissionsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        public ApiResponse< PermissionCollectionEntityListing > GetAuthorizationPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
            
            
            
            

            var localVarPath = "/api/v2/authorization/permissions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)));
            
        }

        
        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        public async System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetAuthorizationPermissionsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = await GetAuthorizationPermissionsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetAuthorizationPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
            
            
            
            

            var localVarPath = "/api/v2/authorization/permissions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        public OrganizationProductEntityListing GetAuthorizationProducts ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = GetAuthorizationProductsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        public ApiResponse< OrganizationProductEntityListing > GetAuthorizationProductsWithHttpInfo ()
        {
            

            var localVarPath = "/api/v2/authorization/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationProductEntityListing> GetAuthorizationProductsAsync ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = await GetAuthorizationProductsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetAuthorizationProductsAsyncWithHttpInfo ()
        {
            

            var localVarPath = "/api/v2/authorization/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole GetAuthorizationRole (string roleId)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = GetAuthorizationRoleWithHttpInfo(roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > GetAuthorizationRoleWithHttpInfo (string roleId)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> GetAuthorizationRoleAsync (string roleId)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await GetAuthorizationRoleAsyncWithHttpInfo(roleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetAuthorizationRoleAsyncWithHttpInfo (string roleId)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        
        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference GetAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = GetAuthorizationRoleComparedefaultRightRoleIdWithHttpInfo(leftRoleId, rightRoleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > GetAuthorizationRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            
            
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->GetAuthorizationRoleComparedefaultRightRoleId");
            
            
            
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->GetAuthorizationRoleComparedefaultRightRoleId");
            
            

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        
        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> GetAuthorizationRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = await GetAuthorizationRoleComparedefaultRightRoleIdAsyncWithHttpInfo(leftRoleId, rightRoleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> GetAuthorizationRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            
            
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->GetAuthorizationRoleComparedefaultRightRoleId");
            
            
            
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->GetAuthorizationRoleComparedefaultRightRoleId");
            
            

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        
        
        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing GetAuthorizationRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = GetAuthorizationRolesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, defaultRoleId, userCount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > GetAuthorizationRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/authorization/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            
            if (defaultRoleId != null) localVarQueryParams.Add("defaultRoleId", Configuration.ApiClient.ParameterToString(defaultRoleId)); // query parameter
            
            if (userCount != null) localVarQueryParams.Add("userCount", Configuration.ApiClient.ParameterToString(userCount)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        
        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetAuthorizationRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await GetAuthorizationRolesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, defaultRoleId, userCount);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetAuthorizationRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            var localVarPath = "/api/v2/authorization/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            
            if (defaultRoleId != null) localVarQueryParams.Add("defaultRoleId", Configuration.ApiClient.ParameterToString(defaultRoleId)); // query parameter
            
            if (userCount != null) localVarQueryParams.Add("userCount", Configuration.ApiClient.ParameterToString(userCount)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        
        
        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        public UserAuthorization GetUserRoles (string userId)
        {
             ApiResponse<UserAuthorization> localVarResponse = GetUserRolesWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        public ApiResponse< UserAuthorization > GetUserRolesWithHttpInfo (string userId)
        {
            
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->GetUserRoles");
            
            

            var localVarPath = "/api/v2/users/{userId}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        
        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        public async System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string userId)
        {
             ApiResponse<UserAuthorization> localVarResponse = await GetUserRolesAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string userId)
        {
            
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->GetUserRoles");
            
            

            var localVarPath = "/api/v2/users/{userId}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        
        
        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PatchAuthorizationRole (string roleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = PatchAuthorizationRoleWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PatchAuthorizationRoleWithHttpInfo (string roleId, DomainOrganizationRole body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PatchAuthorizationRole");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PatchAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PatchAuthorizationRoleAsync (string roleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await PatchAuthorizationRoleAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PatchAuthorizationRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PatchAuthorizationRole");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PatchAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        
        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference PostAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = PostAuthorizationRoleComparedefaultRightRoleIdWithHttpInfo(leftRoleId, rightRoleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > PostAuthorizationRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
            
            
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->PostAuthorizationRoleComparedefaultRightRoleId");
            
            
            
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->PostAuthorizationRoleComparedefaultRightRoleId");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationRoleComparedefaultRightRoleId");
            
            

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        
        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> PostAuthorizationRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = await PostAuthorizationRoleComparedefaultRightRoleIdAsyncWithHttpInfo(leftRoleId, rightRoleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> PostAuthorizationRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
            
            
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->PostAuthorizationRoleComparedefaultRightRoleId");
            
            
            
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->PostAuthorizationRoleComparedefaultRightRoleId");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationRoleComparedefaultRightRoleId");
            
            

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        
        
        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PostAuthorizationRoles (DomainOrganizationRoleCreate body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = PostAuthorizationRolesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PostAuthorizationRolesWithHttpInfo (DomainOrganizationRoleCreate body)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationRoles");
            
            

            var localVarPath = "/api/v2/authorization/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PostAuthorizationRolesAsync (DomainOrganizationRoleCreate body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await PostAuthorizationRolesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PostAuthorizationRolesAsyncWithHttpInfo (DomainOrganizationRoleCreate body)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationRoles");
            
            

            var localVarPath = "/api/v2/authorization/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        
        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing PostAuthorizationRolesDefault (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = PostAuthorizationRolesDefaultWithHttpInfo(force);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > PostAuthorizationRolesDefaultWithHttpInfo (bool? force = null)
        {
            
            
            

            var localVarPath = "/api/v2/authorization/roles/default";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            if (force != null) localVarQueryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        
        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> PostAuthorizationRolesDefaultAsync (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await PostAuthorizationRolesDefaultAsyncWithHttpInfo(force);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PostAuthorizationRolesDefaultAsyncWithHttpInfo (bool? force = null)
        {
            
            
            

            var localVarPath = "/api/v2/authorization/roles/default";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            if (force != null) localVarQueryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        
        
        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PutAuthorizationRole (string roleId, DomainOrganizationRoleUpdate body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = PutAuthorizationRoleWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PutAuthorizationRoleWithHttpInfo (string roleId, DomainOrganizationRoleUpdate body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutAuthorizationRole");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PutAuthorizationRoleAsync (string roleId, DomainOrganizationRoleUpdate body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await PutAuthorizationRoleAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PutAuthorizationRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRoleUpdate body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutAuthorizationRole");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRole");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        
        
        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> PutAuthorizationRoleUsersAdd (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = PutAuthorizationRoleUsersAddWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > PutAuthorizationRoleUsersAddWithHttpInfo (string roleId, List<string> body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutAuthorizationRoleUsersAdd");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRoleUsersAdd");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        
        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> PutAuthorizationRoleUsersAddAsync (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = await PutAuthorizationRoleUsersAddAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> PutAuthorizationRoleUsersAddAsyncWithHttpInfo (string roleId, List<string> body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutAuthorizationRoleUsersAdd");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRoleUsersAdd");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        
        
        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> PutAuthorizationRoleUsersRemove (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = PutAuthorizationRoleUsersRemoveWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > PutAuthorizationRoleUsersRemoveWithHttpInfo (string roleId, List<string> body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutAuthorizationRoleUsersRemove");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRoleUsersRemove");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        
        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> PutAuthorizationRoleUsersRemoveAsync (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = await PutAuthorizationRoleUsersRemoveAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> PutAuthorizationRoleUsersRemoveAsyncWithHttpInfo (string roleId, List<string> body)
        {
            
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutAuthorizationRoleUsersRemove");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRoleUsersRemove");
            
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        
        
        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing PutAuthorizationRolesDefault (List<DomainOrganizationRole> body)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = PutAuthorizationRolesDefaultWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > PutAuthorizationRolesDefaultWithHttpInfo (List<DomainOrganizationRole> body)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRolesDefault");
            
            

            var localVarPath = "/api/v2/authorization/roles/default";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        
        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> PutAuthorizationRolesDefaultAsync (List<DomainOrganizationRole> body)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await PutAuthorizationRolesDefaultAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PutAuthorizationRolesDefaultAsyncWithHttpInfo (List<DomainOrganizationRole> body)
        {
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRolesDefault");
            
            

            var localVarPath = "/api/v2/authorization/roles/default";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        
        
        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>UserAuthorization</returns>
        public UserAuthorization PutUserRoles (string userId, List<string> body)
        {
             ApiResponse<UserAuthorization> localVarResponse = PutUserRolesWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        public ApiResponse< UserAuthorization > PutUserRolesWithHttpInfo (string userId, List<string> body)
        {
            
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->PutUserRoles");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutUserRoles");
            
            

            var localVarPath = "/api/v2/users/{userId}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        
        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of UserAuthorization</returns>
        public async System.Threading.Tasks.Task<UserAuthorization> PutUserRolesAsync (string userId, List<string> body)
        {
             ApiResponse<UserAuthorization> localVarResponse = await PutUserRolesAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> PutUserRolesAsyncWithHttpInfo (string userId, List<string> body)
        {
            
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->PutUserRoles");
            
            
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutUserRoles");
            
            

            var localVarPath = "/api/v2/users/{userId}/roles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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
            
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            

            
            // authentication (PureCloud Auth) required
            
            
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        
        
    }
    
}
