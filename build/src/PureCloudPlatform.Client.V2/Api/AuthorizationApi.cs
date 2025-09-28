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
    public interface IAuthorizationApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns></returns>
        
        void DeleteAuthorizationDivision (string divisionId, bool? force = null);

        /// <summary>
        /// Delete a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAuthorizationDivisionWithHttpInfo (string divisionId, bool? force = null);

        /// <summary>
        /// Delete an access control policy
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns></returns>
        
        void DeleteAuthorizationPoliciesTargetSubjectSubjectId (string targetName, string subjectId);

        /// <summary>
        /// Delete an access control policy
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAuthorizationPoliciesTargetSubjectSubjectIdWithHttpInfo (string targetName, string subjectId);

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
        /// Delete a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns></returns>
        
        void DeleteAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId);

        /// <summary>
        /// Delete a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAuthorizationSubjectDivisionRoleWithHttpInfo (string subjectId, string divisionId, string roleId);

        /// <summary>
        /// Returns an authorization division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>AuthzDivision</returns>
        
        AuthzDivision GetAuthorizationDivision (string divisionId, bool? objectCount = null);

        /// <summary>
        /// Returns an authorization division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        ApiResponse<AuthzDivision> GetAuthorizationDivisionWithHttpInfo (string divisionId, bool? objectCount = null);

        /// <summary>
        /// Gets all grants for a given division.
        /// </summary>
        /// <remarks>
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>AuthzDivisionGrantEntityListing</returns>
        
        AuthzDivisionGrantEntityListing GetAuthorizationDivisionGrants (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets all grants for a given division.
        /// </summary>
        /// <remarks>
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthzDivisionGrantEntityListing</returns>
        
        ApiResponse<AuthzDivisionGrantEntityListing> GetAuthorizationDivisionGrantsWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization
        /// </summary>
        /// <remarks>
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>AuthzDivisionEntityListing</returns>
        
        AuthzDivisionEntityListing GetAuthorizationDivisions (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null);

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization
        /// </summary>
        /// <remarks>
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>ApiResponse of AuthzDivisionEntityListing</returns>
        
        ApiResponse<AuthzDivisionEntityListing> GetAuthorizationDivisionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null);

        /// <summary>
        /// Get a list of soft deleted divisions for the org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>AuthzDivisionEntityListing</returns>
        
        AuthzDivisionEntityListing GetAuthorizationDivisionsDeleted (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of soft deleted divisions for the org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthzDivisionEntityListing</returns>
        
        ApiResponse<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve the home division for the organization.
        /// </summary>
        /// <remarks>
        /// Will not include object counts.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuthzDivision</returns>
        
        AuthzDivision GetAuthorizationDivisionsHome ();

        /// <summary>
        /// Retrieve the home division for the organization.
        /// </summary>
        /// <remarks>
        /// Will not include object counts.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        ApiResponse<AuthzDivision> GetAuthorizationDivisionsHomeWithHttpInfo ();

        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>int?</returns>
        
        int? GetAuthorizationDivisionsLimit ();

        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of int?</returns>
        
        ApiResponse<int?> GetAuthorizationDivisionsLimitWithHttpInfo ();

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor
        /// </summary>
        /// <remarks>
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>AuthzDivisionCursorListing</returns>
        
        AuthzDivisionCursorListing GetAuthorizationDivisionsQuery (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null);

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor
        /// </summary>
        /// <remarks>
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>ApiResponse of AuthzDivisionCursorListing</returns>
        
        ApiResponse<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryWithHttpInfo (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>List&lt;AuthzDivision&gt;</returns>
        [Obsolete]
        List<AuthzDivision> GetAuthorizationDivisionspermittedMe (string permission, string name = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>ApiResponse of List&lt;AuthzDivision&gt;</returns>
        [Obsolete]
        ApiResponse<List<AuthzDivision>> GetAuthorizationDivisionspermittedMeWithHttpInfo (string permission, string name = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DivsPermittedEntityListing</returns>
        
        DivsPermittedEntityListing GetAuthorizationDivisionspermittedPagedMe (string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DivsPermittedEntityListing</returns>
        
        ApiResponse<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedMeWithHttpInfo (string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Returns which divisions the specified user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DivsPermittedEntityListing</returns>
        [Obsolete]
        DivsPermittedEntityListing GetAuthorizationDivisionspermittedPagedSubjectId (string subjectId, string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Returns which divisions the specified user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DivsPermittedEntityListing</returns>
        [Obsolete]
        ApiResponse<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedSubjectIdWithHttpInfo (string subjectId, string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        
        PermissionCollectionEntityListing GetAuthorizationPermissions (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        
        ApiResponse<PermissionCollectionEntityListing> GetAuthorizationPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null);

        /// <summary>
        /// Get a page of access policies for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>AuthorizationPolicyEntityListing</returns>
        
        AuthorizationPolicyEntityListing GetAuthorizationPolicies (string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthorizationPolicyEntityListing</returns>
        
        ApiResponse<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesWithHttpInfo (string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>AuthorizationPolicyEntityListing</returns>
        
        AuthorizationPolicyEntityListing GetAuthorizationPoliciesSubjectSubjectId (string subjectId, string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthorizationPolicyEntityListing</returns>
        
        ApiResponse<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesSubjectSubjectIdWithHttpInfo (string subjectId, string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given policy target
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>AuthorizationPolicyEntityListing</returns>
        
        AuthorizationPolicyEntityListing GetAuthorizationPoliciesTarget (string targetName, string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given policy target
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthorizationPolicyEntityListing</returns>
        
        ApiResponse<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesTargetWithHttpInfo (string targetName, string after = null, int? pageSize = null);

        /// <summary>
        /// Get an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>AuthorizationPolicy</returns>
        
        AuthorizationPolicy GetAuthorizationPoliciesTargetSubjectSubjectId (string targetName, string subjectId);

        /// <summary>
        /// Get an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        ApiResponse<AuthorizationPolicy> GetAuthorizationPoliciesTargetSubjectSubjectIdWithHttpInfo (string targetName, string subjectId);

        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TargetAttributes</returns>
        
        TargetAttributes GetAuthorizationPoliciesTargets ();

        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TargetAttributes</returns>
        
        ApiResponse<TargetAttributes> GetAuthorizationPoliciesTargetsWithHttpInfo ();

        /// <summary>
        /// Get an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>AuthorizationPolicy</returns>
        
        AuthorizationPolicy GetAuthorizationPolicy (string policyId);

        /// <summary>
        /// Get an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        ApiResponse<AuthorizationPolicy> GetAuthorizationPolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>PolicyAttributeSet</returns>
        
        PolicyAttributeSet GetAuthorizationPolicyAttributes (string policyId);

        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>ApiResponse of PolicyAttributeSet</returns>
        
        ApiResponse<PolicyAttributeSet> GetAuthorizationPolicyAttributesWithHttpInfo (string policyId);

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
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        
        DomainOrganizationRole GetAuthorizationRole (string roleId, bool? userCount = null, List<string> expand = null);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        
        ApiResponse<DomainOrganizationRole> GetAuthorizationRoleWithHttpInfo (string roleId, bool? userCount = null, List<string> expand = null);

        /// <summary>
        /// Get an org role to default role comparison
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
        /// Get an org role to default role comparison
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
        /// Get the subjects&#39; granted divisions in the specified role.
        /// </summary>
        /// <remarks>
        /// Includes the divisions for which the subject has a grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>SubjectDivisionGrantsEntityListing</returns>
        
        SubjectDivisionGrantsEntityListing GetAuthorizationRoleSubjectgrants (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get the subjects&#39; granted divisions in the specified role.
        /// </summary>
        /// <remarks>
        /// Includes the divisions for which the subject has a grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of SubjectDivisionGrantsEntityListing</returns>
        
        ApiResponse<SubjectDivisionGrantsEntityListing> GetAuthorizationRoleSubjectgrantsWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get a list of the users in a specified role.
        /// </summary>
        /// <remarks>
        /// Get an array of the UUIDs of the users in the specified role.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>UserReferenceEntityListing</returns>
        
        UserReferenceEntityListing GetAuthorizationRoleUsers (string roleId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the users in a specified role.
        /// </summary>
        /// <remarks>
        /// Get an array of the UUIDs of the users in the specified role.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of UserReferenceEntityListing</returns>
        
        ApiResponse<UserReferenceEntityListing> GetAuthorizationRoleUsersWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null);

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
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        
        OrganizationRoleEntityListing GetAuthorizationRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null);

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
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        
        ApiResponse<OrganizationRoleEntityListing> GetAuthorizationRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null);

        /// <summary>
        /// Get authorization role settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RoleSettings</returns>
        
        RoleSettings GetAuthorizationRolesSettings ();

        /// <summary>
        /// Get authorization role settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RoleSettings</returns>
        
        ApiResponse<RoleSettings> GetAuthorizationRolesSettingsWithHttpInfo ();

        /// <summary>
        /// Get authorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuthorizationSettings</returns>
        
        AuthorizationSettings GetAuthorizationSettings ();

        /// <summary>
        /// Get authorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuthorizationSettings</returns>
        
        ApiResponse<AuthorizationSettings> GetAuthorizationSettingsWithHttpInfo ();

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>AuthzSubject</returns>
        
        AuthzSubject GetAuthorizationSubject (string subjectId, bool? includeDuplicates = null);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>ApiResponse of AuthzSubject</returns>
        
        ApiResponse<AuthzSubject> GetAuthorizationSubjectWithHttpInfo (string subjectId, bool? includeDuplicates = null);

        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>AuthzSubject</returns>
        
        AuthzSubject GetAuthorizationSubjectsMe (bool? includeDuplicates = null);

        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>ApiResponse of AuthzSubject</returns>
        
        ApiResponse<AuthzSubject> GetAuthorizationSubjectsMeWithHttpInfo (bool? includeDuplicates = null);

        /// <summary>
        /// Get the count of roles granted to a list of subjects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        
        Dictionary<string, Object> GetAuthorizationSubjectsRolecounts (List<string> id = null);

        /// <summary>
        /// Get the count of roles granted to a list of subjects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        
        ApiResponse<Dictionary<string, Object>> GetAuthorizationSubjectsRolecountsWithHttpInfo (List<string> id = null);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>UserAuthorization</returns>
        
        UserAuthorization GetUserRoles (string subjectId);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        
        ApiResponse<UserAuthorization> GetUserRolesWithHttpInfo (string subjectId);

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
        /// Change authorization settings
        /// </summary>
        /// <remarks>
        /// Change authorization settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>AuthorizationSettings</returns>
        
        AuthorizationSettings PatchAuthorizationSettings (AuthorizationSettings body);

        /// <summary>
        /// Change authorization settings
        /// </summary>
        /// <remarks>
        /// Change authorization settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>ApiResponse of AuthorizationSettings</returns>
        
        ApiResponse<AuthorizationSettings> PatchAuthorizationSettingsWithHttpInfo (AuthorizationSettings body);

        /// <summary>
        /// Assign a list of objects to a division
        /// </summary>
        /// <remarks>
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns></returns>
        
        void PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body);

        /// <summary>
        /// Assign a list of objects to a division
        /// </summary>
        /// <remarks>
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostAuthorizationDivisionObjectWithHttpInfo (string divisionId, string objectType, List<string> body);

        /// <summary>
        /// Recreate a previously deleted division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>AuthzDivision</returns>
        
        AuthzDivision PostAuthorizationDivisionRestore (string divisionId, AuthzDivision body);

        /// <summary>
        /// Recreate a previously deleted division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        ApiResponse<AuthzDivision> PostAuthorizationDivisionRestoreWithHttpInfo (string divisionId, AuthzDivision body);

        /// <summary>
        /// Create a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>AuthzDivision</returns>
        
        AuthzDivision PostAuthorizationDivisions (AuthzDivision body);

        /// <summary>
        /// Create a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        ApiResponse<AuthzDivision> PostAuthorizationDivisionsWithHttpInfo (AuthzDivision body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>AuthorizationPolicy</returns>
        
        AuthorizationPolicy PostAuthorizationPoliciesTarget (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        ApiResponse<AuthorizationPolicy> PostAuthorizationPoliciesTargetWithHttpInfo (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ValidationErrorListing</returns>
        
        ValidationErrorListing PostAuthorizationPoliciesTargetValidate (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of ValidationErrorListing</returns>
        
        ApiResponse<ValidationErrorListing> PostAuthorizationPoliciesTargetValidateWithHttpInfo (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>PolicyTestResult</returns>
        
        PolicyTestResult PostAuthorizationPolicySimulate (string policyId, PolicyTestPayload body);

        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>ApiResponse of PolicyTestResult</returns>
        
        ApiResponse<PolicyTestResult> PostAuthorizationPolicySimulateWithHttpInfo (string policyId, PolicyTestPayload body);

        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        void PostAuthorizationRole (string roleId, SubjectDivisions body, string subjectType = null);

        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostAuthorizationRoleWithHttpInfo (string roleId, SubjectDivisions body, string subjectType = null);

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
        /// Bulk-grant roles and divisions to a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        void PostAuthorizationSubjectBulkadd (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Bulk-grant roles and divisions to a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostAuthorizationSubjectBulkaddWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Bulk-remove grants from a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns></returns>
        
        void PostAuthorizationSubjectBulkremove (string subjectId, RoleDivisionGrants body);

        /// <summary>
        /// Bulk-remove grants from a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostAuthorizationSubjectBulkremoveWithHttpInfo (string subjectId, RoleDivisionGrants body);

        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request.
        /// </summary>
        /// <remarks>
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        void PostAuthorizationSubjectBulkreplace (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request.
        /// </summary>
        /// <remarks>
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostAuthorizationSubjectBulkreplaceWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Make a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        void PostAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId, string subjectType = null);

        /// <summary>
        /// Make a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostAuthorizationSubjectDivisionRoleWithHttpInfo (string subjectId, string divisionId, string roleId, string subjectType = null);

        /// <summary>
        /// Update a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>AuthzDivision</returns>
        
        AuthzDivision PutAuthorizationDivision (string divisionId, AuthzDivision body);

        /// <summary>
        /// Update a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        ApiResponse<AuthzDivision> PutAuthorizationDivisionWithHttpInfo (string divisionId, AuthzDivision body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>AuthorizationPolicy</returns>
        
        AuthorizationPolicy PutAuthorizationPoliciesTarget (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        ApiResponse<AuthorizationPolicy> PutAuthorizationPoliciesTargetWithHttpInfo (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Update an access control policy with a given ID
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>AuthorizationPolicy</returns>
        
        AuthorizationPolicy PutAuthorizationPolicy (string policyId, AuthorizationPolicy body);

        /// <summary>
        /// Update an access control policy with a given ID
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        ApiResponse<AuthorizationPolicy> PutAuthorizationPolicyWithHttpInfo (string policyId, AuthorizationPolicy body);

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
        /// Change authorization role settings
        /// </summary>
        /// <remarks>
        /// Change role settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>RoleSettings</returns>
        
        RoleSettings PutAuthorizationRolesSettings (RoleSettings body);

        /// <summary>
        /// Change authorization role settings
        /// </summary>
        /// <remarks>
        /// Change role settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>ApiResponse of RoleSettings</returns>
        
        ApiResponse<RoleSettings> PutAuthorizationRolesSettingsWithHttpInfo (RoleSettings body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>UserAuthorization</returns>
        
        UserAuthorization PutUserRoles (string subjectId, List<string> body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        
        ApiResponse<UserAuthorization> PutUserRolesWithHttpInfo (string subjectId, List<string> body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAuthorizationDivisionAsync (string divisionId, bool? force = null);

        /// <summary>
        /// Delete a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationDivisionAsyncWithHttpInfo (string divisionId, bool? force = null);

        /// <summary>
        /// Delete an access control policy
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAuthorizationPoliciesTargetSubjectSubjectIdAsync (string targetName, string subjectId);

        /// <summary>
        /// Delete an access control policy
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationPoliciesTargetSubjectSubjectIdAsyncWithHttpInfo (string targetName, string subjectId);

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
        /// Delete a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAuthorizationSubjectDivisionRoleAsync (string subjectId, string divisionId, string roleId);

        /// <summary>
        /// Delete a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationSubjectDivisionRoleAsyncWithHttpInfo (string subjectId, string divisionId, string roleId);

        /// <summary>
        /// Returns an authorization division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>Task of AuthzDivision</returns>
        
        System.Threading.Tasks.Task<AuthzDivision> GetAuthorizationDivisionAsync (string divisionId, bool? objectCount = null);

        /// <summary>
        /// Returns an authorization division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> GetAuthorizationDivisionAsyncWithHttpInfo (string divisionId, bool? objectCount = null);

        /// <summary>
        /// Gets all grants for a given division.
        /// </summary>
        /// <remarks>
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of AuthzDivisionGrantEntityListing</returns>
        
        System.Threading.Tasks.Task<AuthzDivisionGrantEntityListing> GetAuthorizationDivisionGrantsAsync (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets all grants for a given division.
        /// </summary>
        /// <remarks>
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionGrantEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivisionGrantEntityListing>> GetAuthorizationDivisionGrantsAsyncWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization
        /// </summary>
        /// <remarks>
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of AuthzDivisionEntityListing</returns>
        
        System.Threading.Tasks.Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null);

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization
        /// </summary>
        /// <remarks>
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivisionEntityListing>> GetAuthorizationDivisionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null);

        /// <summary>
        /// Get a list of soft deleted divisions for the org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of AuthzDivisionEntityListing</returns>
        
        System.Threading.Tasks.Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of soft deleted divisions for the org
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivisionEntityListing>> GetAuthorizationDivisionsDeletedAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Retrieve the home division for the organization.
        /// </summary>
        /// <remarks>
        /// Will not include object counts.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuthzDivision</returns>
        
        System.Threading.Tasks.Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync ();

        /// <summary>
        /// Retrieve the home division for the organization.
        /// </summary>
        /// <remarks>
        /// Will not include object counts.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> GetAuthorizationDivisionsHomeAsyncWithHttpInfo ();

        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of int?</returns>
        
        System.Threading.Tasks.Task<int?> GetAuthorizationDivisionsLimitAsync ();

        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (int?)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<int?>> GetAuthorizationDivisionsLimitAsyncWithHttpInfo ();

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor
        /// </summary>
        /// <remarks>
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>Task of AuthzDivisionCursorListing</returns>
        
        System.Threading.Tasks.Task<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryAsync (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null);

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor
        /// </summary>
        /// <remarks>
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionCursorListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivisionCursorListing>> GetAuthorizationDivisionsQueryAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of List&lt;AuthzDivision&gt;</returns>
        [Obsolete]
        System.Threading.Tasks.Task<List<AuthzDivision>> GetAuthorizationDivisionspermittedMeAsync (string permission, string name = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;AuthzDivision&gt;)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<List<AuthzDivision>>> GetAuthorizationDivisionspermittedMeAsyncWithHttpInfo (string permission, string name = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DivsPermittedEntityListing</returns>
        
        System.Threading.Tasks.Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedMeAsync (string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Returns which divisions the current user has the given permission in.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DivsPermittedEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DivsPermittedEntityListing>> GetAuthorizationDivisionspermittedPagedMeAsyncWithHttpInfo (string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Returns which divisions the specified user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DivsPermittedEntityListing</returns>
        [Obsolete]
        System.Threading.Tasks.Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedSubjectIdAsync (string subjectId, string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Returns which divisions the specified user has the given permission in.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DivsPermittedEntityListing)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<DivsPermittedEntityListing>> GetAuthorizationDivisionspermittedPagedSubjectIdAsyncWithHttpInfo (string subjectId, string permission, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        
        System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetAuthorizationPermissionsAsync (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetAuthorizationPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null);

        /// <summary>
        /// Get a page of access policies for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of AuthorizationPolicyEntityListing</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesAsync (string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicyEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicyEntityListing>> GetAuthorizationPoliciesAsyncWithHttpInfo (string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of AuthorizationPolicyEntityListing</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesSubjectSubjectIdAsync (string subjectId, string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicyEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicyEntityListing>> GetAuthorizationPoliciesSubjectSubjectIdAsyncWithHttpInfo (string subjectId, string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given policy target
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of AuthorizationPolicyEntityListing</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesTargetAsync (string targetName, string after = null, int? pageSize = null);

        /// <summary>
        /// Get a page of access policies for a given policy target
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicyEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicyEntityListing>> GetAuthorizationPoliciesTargetAsyncWithHttpInfo (string targetName, string after = null, int? pageSize = null);

        /// <summary>
        /// Get an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicy> GetAuthorizationPoliciesTargetSubjectSubjectIdAsync (string targetName, string subjectId);

        /// <summary>
        /// Get an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> GetAuthorizationPoliciesTargetSubjectSubjectIdAsyncWithHttpInfo (string targetName, string subjectId);

        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TargetAttributes</returns>
        
        System.Threading.Tasks.Task<TargetAttributes> GetAuthorizationPoliciesTargetsAsync ();

        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TargetAttributes)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TargetAttributes>> GetAuthorizationPoliciesTargetsAsyncWithHttpInfo ();

        /// <summary>
        /// Get an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicy> GetAuthorizationPolicyAsync (string policyId);

        /// <summary>
        /// Get an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> GetAuthorizationPolicyAsyncWithHttpInfo (string policyId);

        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>Task of PolicyAttributeSet</returns>
        
        System.Threading.Tasks.Task<PolicyAttributeSet> GetAuthorizationPolicyAttributesAsync (string policyId);

        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID
        /// </summary>
        /// <remarks>
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>Task of ApiResponse (PolicyAttributeSet)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<PolicyAttributeSet>> GetAuthorizationPolicyAttributesAsyncWithHttpInfo (string policyId);

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
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        
        System.Threading.Tasks.Task<DomainOrganizationRole> GetAuthorizationRoleAsync (string roleId, bool? userCount = null, List<string> expand = null);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetAuthorizationRoleAsyncWithHttpInfo (string roleId, bool? userCount = null, List<string> expand = null);

        /// <summary>
        /// Get an org role to default role comparison
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
        /// Get an org role to default role comparison
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
        /// Get the subjects&#39; granted divisions in the specified role.
        /// </summary>
        /// <remarks>
        /// Includes the divisions for which the subject has a grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of SubjectDivisionGrantsEntityListing</returns>
        
        System.Threading.Tasks.Task<SubjectDivisionGrantsEntityListing> GetAuthorizationRoleSubjectgrantsAsync (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get the subjects&#39; granted divisions in the specified role.
        /// </summary>
        /// <remarks>
        /// Includes the divisions for which the subject has a grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (SubjectDivisionGrantsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SubjectDivisionGrantsEntityListing>> GetAuthorizationRoleSubjectgrantsAsyncWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get a list of the users in a specified role.
        /// </summary>
        /// <remarks>
        /// Get an array of the UUIDs of the users in the specified role.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of UserReferenceEntityListing</returns>
        
        System.Threading.Tasks.Task<UserReferenceEntityListing> GetAuthorizationRoleUsersAsync (string roleId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the users in a specified role.
        /// </summary>
        /// <remarks>
        /// Get an array of the UUIDs of the users in the specified role.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (UserReferenceEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UserReferenceEntityListing>> GetAuthorizationRoleUsersAsyncWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null);

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
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetAuthorizationRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null);

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
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetAuthorizationRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null);

        /// <summary>
        /// Get authorization role settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RoleSettings</returns>
        
        System.Threading.Tasks.Task<RoleSettings> GetAuthorizationRolesSettingsAsync ();

        /// <summary>
        /// Get authorization role settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RoleSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<RoleSettings>> GetAuthorizationRolesSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get authorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuthorizationSettings</returns>
        
        System.Threading.Tasks.Task<AuthorizationSettings> GetAuthorizationSettingsAsync ();

        /// <summary>
        /// Get authorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuthorizationSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationSettings>> GetAuthorizationSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of AuthzSubject</returns>
        
        System.Threading.Tasks.Task<AuthzSubject> GetAuthorizationSubjectAsync (string subjectId, bool? includeDuplicates = null);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuthzSubject)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzSubject>> GetAuthorizationSubjectAsyncWithHttpInfo (string subjectId, bool? includeDuplicates = null);

        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of AuthzSubject</returns>
        
        System.Threading.Tasks.Task<AuthzSubject> GetAuthorizationSubjectsMeAsync (bool? includeDuplicates = null);

        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuthzSubject)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzSubject>> GetAuthorizationSubjectsMeAsyncWithHttpInfo (bool? includeDuplicates = null);

        /// <summary>
        /// Get the count of roles granted to a list of subjects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        
        System.Threading.Tasks.Task<Dictionary<string, Object>> GetAuthorizationSubjectsRolecountsAsync (List<string> id = null);

        /// <summary>
        /// Get the count of roles granted to a list of subjects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetAuthorizationSubjectsRolecountsAsyncWithHttpInfo (List<string> id = null);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        
        System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string subjectId);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string subjectId);

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
        /// Change authorization settings
        /// </summary>
        /// <remarks>
        /// Change authorization settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>Task of AuthorizationSettings</returns>
        
        System.Threading.Tasks.Task<AuthorizationSettings> PatchAuthorizationSettingsAsync (AuthorizationSettings body);

        /// <summary>
        /// Change authorization settings
        /// </summary>
        /// <remarks>
        /// Change authorization settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>Task of ApiResponse (AuthorizationSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationSettings>> PatchAuthorizationSettingsAsyncWithHttpInfo (AuthorizationSettings body);

        /// <summary>
        /// Assign a list of objects to a division
        /// </summary>
        /// <remarks>
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostAuthorizationDivisionObjectAsync (string divisionId, string objectType, List<string> body);

        /// <summary>
        /// Assign a list of objects to a division
        /// </summary>
        /// <remarks>
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationDivisionObjectAsyncWithHttpInfo (string divisionId, string objectType, List<string> body);

        /// <summary>
        /// Recreate a previously deleted division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>Task of AuthzDivision</returns>
        
        System.Threading.Tasks.Task<AuthzDivision> PostAuthorizationDivisionRestoreAsync (string divisionId, AuthzDivision body);

        /// <summary>
        /// Recreate a previously deleted division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> PostAuthorizationDivisionRestoreAsyncWithHttpInfo (string divisionId, AuthzDivision body);

        /// <summary>
        /// Create a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>Task of AuthzDivision</returns>
        
        System.Threading.Tasks.Task<AuthzDivision> PostAuthorizationDivisionsAsync (AuthzDivision body);

        /// <summary>
        /// Create a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> PostAuthorizationDivisionsAsyncWithHttpInfo (AuthzDivision body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicy> PostAuthorizationPoliciesTargetAsync (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> PostAuthorizationPoliciesTargetAsyncWithHttpInfo (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ValidationErrorListing</returns>
        
        System.Threading.Tasks.Task<ValidationErrorListing> PostAuthorizationPoliciesTargetValidateAsync (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (ValidationErrorListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ValidationErrorListing>> PostAuthorizationPoliciesTargetValidateAsyncWithHttpInfo (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>Task of PolicyTestResult</returns>
        
        System.Threading.Tasks.Task<PolicyTestResult> PostAuthorizationPolicySimulateAsync (string policyId, PolicyTestPayload body);

        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values
        /// </summary>
        /// <remarks>
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>Task of ApiResponse (PolicyTestResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<PolicyTestResult>> PostAuthorizationPolicySimulateAsyncWithHttpInfo (string policyId, PolicyTestPayload body);

        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostAuthorizationRoleAsync (string roleId, SubjectDivisions body, string subjectType = null);

        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationRoleAsyncWithHttpInfo (string roleId, SubjectDivisions body, string subjectType = null);

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
        /// Bulk-grant roles and divisions to a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostAuthorizationSubjectBulkaddAsync (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Bulk-grant roles and divisions to a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectBulkaddAsyncWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Bulk-remove grants from a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostAuthorizationSubjectBulkremoveAsync (string subjectId, RoleDivisionGrants body);

        /// <summary>
        /// Bulk-remove grants from a subject.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectBulkremoveAsyncWithHttpInfo (string subjectId, RoleDivisionGrants body);

        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request.
        /// </summary>
        /// <remarks>
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostAuthorizationSubjectBulkreplaceAsync (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request.
        /// </summary>
        /// <remarks>
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectBulkreplaceAsyncWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null);

        /// <summary>
        /// Make a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostAuthorizationSubjectDivisionRoleAsync (string subjectId, string divisionId, string roleId, string subjectType = null);

        /// <summary>
        /// Make a grant of a role in a division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectDivisionRoleAsyncWithHttpInfo (string subjectId, string divisionId, string roleId, string subjectType = null);

        /// <summary>
        /// Update a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>Task of AuthzDivision</returns>
        
        System.Threading.Tasks.Task<AuthzDivision> PutAuthorizationDivisionAsync (string divisionId, AuthzDivision body);

        /// <summary>
        /// Update a division.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> PutAuthorizationDivisionAsyncWithHttpInfo (string divisionId, AuthzDivision body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicy> PutAuthorizationPoliciesTargetAsync (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> PutAuthorizationPoliciesTargetAsyncWithHttpInfo (string targetName, AuthorizationPolicy body);

        /// <summary>
        /// Update an access control policy with a given ID
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        System.Threading.Tasks.Task<AuthorizationPolicy> PutAuthorizationPolicyAsync (string policyId, AuthorizationPolicy body);

        /// <summary>
        /// Update an access control policy with a given ID
        /// </summary>
        /// <remarks>
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> PutAuthorizationPolicyAsyncWithHttpInfo (string policyId, AuthorizationPolicy body);

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
        /// Change authorization role settings
        /// </summary>
        /// <remarks>
        /// Change role settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>Task of RoleSettings</returns>
        
        System.Threading.Tasks.Task<RoleSettings> PutAuthorizationRolesSettingsAsync (RoleSettings body);

        /// <summary>
        /// Change authorization role settings
        /// </summary>
        /// <remarks>
        /// Change role settings
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>Task of ApiResponse (RoleSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<RoleSettings>> PutAuthorizationRolesSettingsAsyncWithHttpInfo (RoleSettings body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of UserAuthorization</returns>
        
        System.Threading.Tasks.Task<UserAuthorization> PutUserRolesAsync (string subjectId, List<string> body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> PutUserRolesAsyncWithHttpInfo (string subjectId, List<string> body);

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
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
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
        public AuthorizationApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns></returns>
        
        public void DeleteAuthorizationDivision (string divisionId, bool? force = null)
        {
             DeleteAuthorizationDivisionWithHttpInfo(divisionId, force);
        }

        /// <summary>
        /// Delete a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAuthorizationDivisionWithHttpInfo (string divisionId, bool? force = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->DeleteAuthorizationDivision");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

            // Query params
            if (force != null) localVarQueryParams.Add(new Tuple<string, string>("force", this.Configuration.ApiClient.ParameterToString(force)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationDivision: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationDivision: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAuthorizationDivisionAsync (string divisionId, bool? force = null)
        {
             await DeleteAuthorizationDivisionAsyncWithHttpInfo(divisionId, force);

        }

        /// <summary>
        /// Delete a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="force">DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationDivisionAsyncWithHttpInfo (string divisionId, bool? force = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->DeleteAuthorizationDivision");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

            // Query params
            if (force != null) localVarQueryParams.Add(new Tuple<string, string>("force", this.Configuration.ApiClient.ParameterToString(force)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationDivision: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationDivision: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an access control policy 
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns></returns>
        
        public void DeleteAuthorizationPoliciesTargetSubjectSubjectId (string targetName, string subjectId)
        {
             DeleteAuthorizationPoliciesTargetSubjectSubjectIdWithHttpInfo(targetName, subjectId);
        }

        /// <summary>
        /// Delete an access control policy 
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAuthorizationPoliciesTargetSubjectSubjectIdWithHttpInfo (string targetName, string subjectId)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->DeleteAuthorizationPoliciesTargetSubjectSubjectId");
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->DeleteAuthorizationPoliciesTargetSubjectSubjectId");

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}/subject/{subjectId}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an access control policy 
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAuthorizationPoliciesTargetSubjectSubjectIdAsync (string targetName, string subjectId)
        {
             await DeleteAuthorizationPoliciesTargetSubjectSubjectIdAsyncWithHttpInfo(targetName, subjectId);

        }

        /// <summary>
        /// Delete an access control policy 
        /// 
        /// DeleteAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationPoliciesTargetSubjectSubjectIdAsyncWithHttpInfo (string targetName, string subjectId)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->DeleteAuthorizationPoliciesTargetSubjectSubjectId");
            
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->DeleteAuthorizationPoliciesTargetSubjectSubjectId");
            

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}/subject/{subjectId}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an organization role. 
        /// 
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
        /// 
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an organization role. 
        /// 
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
        /// 
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns></returns>
        
        public void DeleteAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId)
        {
             DeleteAuthorizationSubjectDivisionRoleWithHttpInfo(subjectId, divisionId, roleId);
        }

        /// <summary>
        /// Delete a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAuthorizationSubjectDivisionRoleWithHttpInfo (string subjectId, string divisionId, string roleId)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->DeleteAuthorizationSubjectDivisionRole");
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->DeleteAuthorizationSubjectDivisionRole");
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->DeleteAuthorizationSubjectDivisionRole");

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationSubjectDivisionRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationSubjectDivisionRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAuthorizationSubjectDivisionRoleAsync (string subjectId, string divisionId, string roleId)
        {
             await DeleteAuthorizationSubjectDivisionRoleAsyncWithHttpInfo(subjectId, divisionId, roleId);

        }

        /// <summary>
        /// Delete a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division of the grant</param>
        /// <param name="roleId">the id of the role of the grant</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAuthorizationSubjectDivisionRoleAsyncWithHttpInfo (string subjectId, string divisionId, string roleId)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->DeleteAuthorizationSubjectDivisionRole");
            
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->DeleteAuthorizationSubjectDivisionRole");
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->DeleteAuthorizationSubjectDivisionRole");
            

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationSubjectDivisionRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAuthorizationSubjectDivisionRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns an authorization division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>AuthzDivision</returns>
        
        public AuthzDivision GetAuthorizationDivision (string divisionId, bool? objectCount = null)
        {
             ApiResponse<AuthzDivision> localVarResponse = GetAuthorizationDivisionWithHttpInfo(divisionId, objectCount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns an authorization division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        public ApiResponse< AuthzDivision > GetAuthorizationDivisionWithHttpInfo (string divisionId, bool? objectCount = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->GetAuthorizationDivision");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

            // Query params
            if (objectCount != null) localVarQueryParams.Add(new Tuple<string, string>("objectCount", this.Configuration.ApiClient.ParameterToString(objectCount)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivision: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivision: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns an authorization division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>Task of AuthzDivision</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivision> GetAuthorizationDivisionAsync (string divisionId, bool? objectCount = null)
        {
             ApiResponse<AuthzDivision> localVarResponse = await GetAuthorizationDivisionAsyncWithHttpInfo(divisionId, objectCount);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns an authorization division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectCount">Get count of objects in this division, grouped by type (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> GetAuthorizationDivisionAsyncWithHttpInfo (string divisionId, bool? objectCount = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->GetAuthorizationDivision");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

            // Query params
            if (objectCount != null) localVarQueryParams.Add(new Tuple<string, string>("objectCount", this.Configuration.ApiClient.ParameterToString(objectCount)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivision: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivision: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets all grants for a given division. 
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>AuthzDivisionGrantEntityListing</returns>
        
        public AuthzDivisionGrantEntityListing GetAuthorizationDivisionGrants (string divisionId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AuthzDivisionGrantEntityListing> localVarResponse = GetAuthorizationDivisionGrantsWithHttpInfo(divisionId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all grants for a given division. 
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthzDivisionGrantEntityListing</returns>
        
        public ApiResponse< AuthzDivisionGrantEntityListing > GetAuthorizationDivisionGrantsWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->GetAuthorizationDivisionGrants");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/grants";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionGrants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionGrants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionGrantEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionGrantEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionGrantEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets all grants for a given division. 
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of AuthzDivisionGrantEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivisionGrantEntityListing> GetAuthorizationDivisionGrantsAsync (string divisionId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AuthzDivisionGrantEntityListing> localVarResponse = await GetAuthorizationDivisionGrantsAsyncWithHttpInfo(divisionId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all grants for a given division. 
        /// Returns all grants assigned to a given division. Maximum page size is 500.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionGrantEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivisionGrantEntityListing>> GetAuthorizationDivisionGrantsAsyncWithHttpInfo (string divisionId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->GetAuthorizationDivisionGrants");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/grants";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionGrants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionGrants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionGrantEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionGrantEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionGrantEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of all divisions defined for the organization 
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>AuthzDivisionEntityListing</returns>
        
        public AuthzDivisionEntityListing GetAuthorizationDivisions (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)
        {
             ApiResponse<AuthzDivisionEntityListing> localVarResponse = GetAuthorizationDivisionsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, objectCount, id, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization 
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>ApiResponse of AuthzDivisionEntityListing</returns>
        
        public ApiResponse< AuthzDivisionEntityListing > GetAuthorizationDivisionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)
        { 

            var localVarPath = "/api/v2/authorization/divisions";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (objectCount != null) localVarQueryParams.Add(new Tuple<string, string>("objectCount", this.Configuration.ApiClient.ParameterToString(objectCount)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of all divisions defined for the organization 
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of AuthzDivisionEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)
        {
             ApiResponse<AuthzDivisionEntityListing> localVarResponse = await GetAuthorizationDivisionsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, objectCount, id, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization 
        /// Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="objectCount">Include the count of objects contained in the division (optional, default to false)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivisionEntityListing>> GetAuthorizationDivisionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)
        { 

            var localVarPath = "/api/v2/authorization/divisions";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (objectCount != null) localVarQueryParams.Add(new Tuple<string, string>("objectCount", this.Configuration.ApiClient.ParameterToString(objectCount)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of soft deleted divisions for the org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>AuthzDivisionEntityListing</returns>
        
        public AuthzDivisionEntityListing GetAuthorizationDivisionsDeleted (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AuthzDivisionEntityListing> localVarResponse = GetAuthorizationDivisionsDeletedWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of soft deleted divisions for the org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthzDivisionEntityListing</returns>
        
        public ApiResponse< AuthzDivisionEntityListing > GetAuthorizationDivisionsDeletedWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/authorization/divisions/deleted";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsDeleted: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsDeleted: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of soft deleted divisions for the org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of AuthzDivisionEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AuthzDivisionEntityListing> localVarResponse = await GetAuthorizationDivisionsDeletedAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of soft deleted divisions for the org 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivisionEntityListing>> GetAuthorizationDivisionsDeletedAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/authorization/divisions/deleted";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsDeleted: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsDeleted: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve the home division for the organization. 
        /// Will not include object counts.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuthzDivision</returns>
        
        public AuthzDivision GetAuthorizationDivisionsHome ()
        {
             ApiResponse<AuthzDivision> localVarResponse = GetAuthorizationDivisionsHomeWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the home division for the organization. 
        /// Will not include object counts.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        public ApiResponse< AuthzDivision > GetAuthorizationDivisionsHomeWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/divisions/home";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsHome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsHome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve the home division for the organization. 
        /// Will not include object counts.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuthzDivision</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync ()
        {
             ApiResponse<AuthzDivision> localVarResponse = await GetAuthorizationDivisionsHomeAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the home division for the organization. 
        /// Will not include object counts.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> GetAuthorizationDivisionsHomeAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/divisions/home";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsHome: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsHome: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>int?</returns>
        
        public int? GetAuthorizationDivisionsLimit ()
        {
             ApiResponse<int?> localVarResponse = GetAuthorizationDivisionsLimitWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of int?</returns>
        
        public ApiResponse< int? > GetAuthorizationDivisionsLimitWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/divisions/limit";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<int?>(localVarStatusCode,
                localVarHeaders,
                (int?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of int?</returns>
        
        public async System.Threading.Tasks.Task<int?> GetAuthorizationDivisionsLimitAsync ()
        {
             ApiResponse<int?> localVarResponse = await GetAuthorizationDivisionsLimitAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (int?)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<int?>> GetAuthorizationDivisionsLimitAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/divisions/limit";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<int?>(localVarStatusCode,
                localVarHeaders,
                (int?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor 
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>AuthzDivisionCursorListing</returns>
        
        public AuthzDivisionCursorListing GetAuthorizationDivisionsQuery (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null)
        {
             ApiResponse<AuthzDivisionCursorListing> localVarResponse = GetAuthorizationDivisionsQueryWithHttpInfo(before, after, pageSize, id, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor 
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>ApiResponse of AuthzDivisionCursorListing</returns>
        
        public ApiResponse< AuthzDivisionCursorListing > GetAuthorizationDivisionsQueryWithHttpInfo (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null)
        { 

            var localVarPath = "/api/v2/authorization/divisions/query";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionCursorListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionCursorListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionCursorListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor 
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>Task of AuthzDivisionCursorListing</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivisionCursorListing> GetAuthorizationDivisionsQueryAsync (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null)
        {
             ApiResponse<AuthzDivisionCursorListing> localVarResponse = await GetAuthorizationDivisionsQueryAsyncWithHttpInfo(before, after, pageSize, id, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all divisions defined for the organization with cursor 
        /// Use \"after\" and \"before\" param to fetch next/previous page}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="id">Optionally request specific divisions by their IDs (optional)</param>
        /// <param name="name">Optionally request specific divisions by division name (optional)</param>
        /// <returns>Task of ApiResponse (AuthzDivisionCursorListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivisionCursorListing>> GetAuthorizationDivisionsQueryAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null)
        { 

            var localVarPath = "/api/v2/authorization/divisions/query";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivisionCursorListing>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivisionCursorListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivisionCursorListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>List&lt;AuthzDivision&gt;</returns>
        [Obsolete]
        public List<AuthzDivision> GetAuthorizationDivisionspermittedMe (string permission, string name = null)
        {
             ApiResponse<List<AuthzDivision>> localVarResponse = GetAuthorizationDivisionspermittedMeWithHttpInfo(permission, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>ApiResponse of List&lt;AuthzDivision&gt;</returns>
        [Obsolete]
        public ApiResponse< List<AuthzDivision> > GetAuthorizationDivisionspermittedMeWithHttpInfo (string permission, string name = null)
        { 
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthorizationApi->GetAuthorizationDivisionspermittedMe");

            var localVarPath = "/api/v2/authorization/divisionspermitted/me";
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(permission)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AuthzDivision>>(localVarStatusCode,
                localVarHeaders,
                (List<AuthzDivision>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AuthzDivision>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of List&lt;AuthzDivision&gt;</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<List<AuthzDivision>> GetAuthorizationDivisionspermittedMeAsync (string permission, string name = null)
        {
             ApiResponse<List<AuthzDivision>> localVarResponse = await GetAuthorizationDivisionspermittedMeAsyncWithHttpInfo(permission, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="name">Search term to filter by division name (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;AuthzDivision&gt;)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<List<AuthzDivision>>> GetAuthorizationDivisionspermittedMeAsyncWithHttpInfo (string permission, string name = null)
        { 
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthorizationApi->GetAuthorizationDivisionspermittedMe");
            

            var localVarPath = "/api/v2/authorization/divisionspermitted/me";
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(permission)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AuthzDivision>>(localVarStatusCode,
                localVarHeaders,
                (List<AuthzDivision>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AuthzDivision>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DivsPermittedEntityListing</returns>
        
        public DivsPermittedEntityListing GetAuthorizationDivisionspermittedPagedMe (string permission, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DivsPermittedEntityListing> localVarResponse = GetAuthorizationDivisionspermittedPagedMeWithHttpInfo(permission, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DivsPermittedEntityListing</returns>
        
        public ApiResponse< DivsPermittedEntityListing > GetAuthorizationDivisionspermittedPagedMeWithHttpInfo (string permission, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthorizationApi->GetAuthorizationDivisionspermittedPagedMe");

            var localVarPath = "/api/v2/authorization/divisionspermitted/paged/me";
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
            if (permission != null) localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(permission)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DivsPermittedEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DivsPermittedEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DivsPermittedEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DivsPermittedEntityListing</returns>
        
        public async System.Threading.Tasks.Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedMeAsync (string permission, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DivsPermittedEntityListing> localVarResponse = await GetAuthorizationDivisionspermittedPagedMeAsyncWithHttpInfo(permission, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns which divisions the current user has the given permission in. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DivsPermittedEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DivsPermittedEntityListing>> GetAuthorizationDivisionspermittedPagedMeAsyncWithHttpInfo (string permission, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthorizationApi->GetAuthorizationDivisionspermittedPagedMe");
            

            var localVarPath = "/api/v2/authorization/divisionspermitted/paged/me";
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
            if (permission != null) localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(permission)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DivsPermittedEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DivsPermittedEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DivsPermittedEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns which divisions the specified user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DivsPermittedEntityListing</returns>
        [Obsolete]
        public DivsPermittedEntityListing GetAuthorizationDivisionspermittedPagedSubjectId (string subjectId, string permission, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DivsPermittedEntityListing> localVarResponse = GetAuthorizationDivisionspermittedPagedSubjectIdWithHttpInfo(subjectId, permission, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns which divisions the specified user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DivsPermittedEntityListing</returns>
        [Obsolete]
        public ApiResponse< DivsPermittedEntityListing > GetAuthorizationDivisionspermittedPagedSubjectIdWithHttpInfo (string subjectId, string permission, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationDivisionspermittedPagedSubjectId");
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthorizationApi->GetAuthorizationDivisionspermittedPagedSubjectId");

            var localVarPath = "/api/v2/authorization/divisionspermitted/paged/{subjectId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (permission != null) localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(permission)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DivsPermittedEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DivsPermittedEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DivsPermittedEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns which divisions the specified user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DivsPermittedEntityListing</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<DivsPermittedEntityListing> GetAuthorizationDivisionspermittedPagedSubjectIdAsync (string subjectId, string permission, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DivsPermittedEntityListing> localVarResponse = await GetAuthorizationDivisionspermittedPagedSubjectIdAsyncWithHttpInfo(subjectId, permission, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns which divisions the specified user has the given permission in. 
        /// This route is deprecated, use authorization/divisionspermitted/paged/me instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="permission">The permission string, including the object to access, e.g. routing:queue:view</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DivsPermittedEntityListing)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<DivsPermittedEntityListing>> GetAuthorizationDivisionspermittedPagedSubjectIdAsyncWithHttpInfo (string subjectId, string permission, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationDivisionspermittedPagedSubjectId");
            
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthorizationApi->GetAuthorizationDivisionspermittedPagedSubjectId");
            

            var localVarPath = "/api/v2/authorization/divisionspermitted/paged/{subjectId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (permission != null) localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(permission)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionspermittedPagedSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DivsPermittedEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DivsPermittedEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DivsPermittedEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all permissions. 
        /// Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        
        public PermissionCollectionEntityListing GetAuthorizationPermissions (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = GetAuthorizationPermissionsWithHttpInfo(pageSize, pageNumber, queryType, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all permissions. 
        /// Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        
        public ApiResponse< PermissionCollectionEntityListing > GetAuthorizationPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null)
        { 

            var localVarPath = "/api/v2/authorization/permissions";
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
            if (queryType != null) localVarQueryParams.Add(new Tuple<string, string>("queryType", this.Configuration.ApiClient.ParameterToString(queryType)));
            if (query != null) localVarQueryParams.Add(new Tuple<string, string>("query", this.Configuration.ApiClient.ParameterToString(query)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PermissionCollectionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all permissions. 
        /// Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        
        public async System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetAuthorizationPermissionsAsync (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = await GetAuthorizationPermissionsAsyncWithHttpInfo(pageSize, pageNumber, queryType, query);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all permissions. 
        /// Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="queryType">Query filter type (optional)</param>
        /// <param name="query">Comma-separated list of permissions or domains to query (optional)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetAuthorizationPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null)
        { 

            var localVarPath = "/api/v2/authorization/permissions";
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
            if (queryType != null) localVarQueryParams.Add(new Tuple<string, string>("queryType", this.Configuration.ApiClient.ParameterToString(queryType)));
            if (query != null) localVarQueryParams.Add(new Tuple<string, string>("query", this.Configuration.ApiClient.ParameterToString(query)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPermissions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PermissionCollectionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a page of access policies for an organization 
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>AuthorizationPolicyEntityListing</returns>
        
        public AuthorizationPolicyEntityListing GetAuthorizationPolicies (string after = null, int? pageSize = null)
        {
             ApiResponse<AuthorizationPolicyEntityListing> localVarResponse = GetAuthorizationPoliciesWithHttpInfo(after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a page of access policies for an organization 
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthorizationPolicyEntityListing</returns>
        
        public ApiResponse< AuthorizationPolicyEntityListing > GetAuthorizationPoliciesWithHttpInfo (string after = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/authorization/policies";
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
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a page of access policies for an organization 
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of AuthorizationPolicyEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesAsync (string after = null, int? pageSize = null)
        {
             ApiResponse<AuthorizationPolicyEntityListing> localVarResponse = await GetAuthorizationPoliciesAsyncWithHttpInfo(after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a page of access policies for an organization 
        /// 
        /// GetAuthorizationPolicies is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicyEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicyEntityListing>> GetAuthorizationPoliciesAsyncWithHttpInfo (string after = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/authorization/policies";
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
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicies: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a page of access policies for a given subject 
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>AuthorizationPolicyEntityListing</returns>
        
        public AuthorizationPolicyEntityListing GetAuthorizationPoliciesSubjectSubjectId (string subjectId, string after = null, int? pageSize = null)
        {
             ApiResponse<AuthorizationPolicyEntityListing> localVarResponse = GetAuthorizationPoliciesSubjectSubjectIdWithHttpInfo(subjectId, after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a page of access policies for a given subject 
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthorizationPolicyEntityListing</returns>
        
        public ApiResponse< AuthorizationPolicyEntityListing > GetAuthorizationPoliciesSubjectSubjectIdWithHttpInfo (string subjectId, string after = null, int? pageSize = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationPoliciesSubjectSubjectId");

            var localVarPath = "/api/v2/authorization/policies/subject/{subjectId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesSubjectSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesSubjectSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a page of access policies for a given subject 
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of AuthorizationPolicyEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesSubjectSubjectIdAsync (string subjectId, string after = null, int? pageSize = null)
        {
             ApiResponse<AuthorizationPolicyEntityListing> localVarResponse = await GetAuthorizationPoliciesSubjectSubjectIdAsyncWithHttpInfo(subjectId, after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a page of access policies for a given subject 
        /// 
        /// GetAuthorizationPoliciesSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The ID of the subject to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicyEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicyEntityListing>> GetAuthorizationPoliciesSubjectSubjectIdAsyncWithHttpInfo (string subjectId, string after = null, int? pageSize = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationPoliciesSubjectSubjectId");
            

            var localVarPath = "/api/v2/authorization/policies/subject/{subjectId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesSubjectSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesSubjectSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a page of access policies for a given policy target 
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>AuthorizationPolicyEntityListing</returns>
        
        public AuthorizationPolicyEntityListing GetAuthorizationPoliciesTarget (string targetName, string after = null, int? pageSize = null)
        {
             ApiResponse<AuthorizationPolicyEntityListing> localVarResponse = GetAuthorizationPoliciesTargetWithHttpInfo(targetName, after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a page of access policies for a given policy target 
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>ApiResponse of AuthorizationPolicyEntityListing</returns>
        
        public ApiResponse< AuthorizationPolicyEntityListing > GetAuthorizationPoliciesTargetWithHttpInfo (string targetName, string after = null, int? pageSize = null)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->GetAuthorizationPoliciesTarget");

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a page of access policies for a given policy target 
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of AuthorizationPolicyEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicyEntityListing> GetAuthorizationPoliciesTargetAsync (string targetName, string after = null, int? pageSize = null)
        {
             ApiResponse<AuthorizationPolicyEntityListing> localVarResponse = await GetAuthorizationPoliciesTargetAsyncWithHttpInfo(targetName, after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a page of access policies for a given policy target 
        /// 
        /// GetAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which policies are applied</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicyEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicyEntityListing>> GetAuthorizationPoliciesTargetAsyncWithHttpInfo (string targetName, string after = null, int? pageSize = null)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->GetAuthorizationPoliciesTarget");
            

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicyEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicyEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicyEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an access control policy for a specified resource target and subject 
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>AuthorizationPolicy</returns>
        
        public AuthorizationPolicy GetAuthorizationPoliciesTargetSubjectSubjectId (string targetName, string subjectId)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = GetAuthorizationPoliciesTargetSubjectSubjectIdWithHttpInfo(targetName, subjectId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an access control policy for a specified resource target and subject 
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        public ApiResponse< AuthorizationPolicy > GetAuthorizationPoliciesTargetSubjectSubjectIdWithHttpInfo (string targetName, string subjectId)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->GetAuthorizationPoliciesTargetSubjectSubjectId");
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationPoliciesTargetSubjectSubjectId");

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}/subject/{subjectId}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an access control policy for a specified resource target and subject 
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicy> GetAuthorizationPoliciesTargetSubjectSubjectIdAsync (string targetName, string subjectId)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = await GetAuthorizationPoliciesTargetSubjectSubjectIdAsyncWithHttpInfo(targetName, subjectId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an access control policy for a specified resource target and subject 
        /// 
        /// GetAuthorizationPoliciesTargetSubjectSubjectId is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action resource target to which the policy is applied</param>
        /// <param name="subjectId">The ID of the subject to which the policy is applied</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> GetAuthorizationPoliciesTargetSubjectSubjectIdAsyncWithHttpInfo (string targetName, string subjectId)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->GetAuthorizationPoliciesTargetSubjectSubjectId");
            
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationPoliciesTargetSubjectSubjectId");
            

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}/subject/{subjectId}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargetSubjectSubjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets 
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TargetAttributes</returns>
        
        public TargetAttributes GetAuthorizationPoliciesTargets ()
        {
             ApiResponse<TargetAttributes> localVarResponse = GetAuthorizationPoliciesTargetsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets 
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TargetAttributes</returns>
        
        public ApiResponse< TargetAttributes > GetAuthorizationPoliciesTargetsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/policies/targets";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TargetAttributes>(localVarStatusCode,
                localVarHeaders,
                (TargetAttributes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TargetAttributes)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets 
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TargetAttributes</returns>
        
        public async System.Threading.Tasks.Task<TargetAttributes> GetAuthorizationPoliciesTargetsAsync ()
        {
             ApiResponse<TargetAttributes> localVarResponse = await GetAuthorizationPoliciesTargetsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a map of policy targets to valid attributes for those targets 
        /// 
        /// GetAuthorizationPoliciesTargets is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TargetAttributes)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TargetAttributes>> GetAuthorizationPoliciesTargetsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/policies/targets";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPoliciesTargets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TargetAttributes>(localVarStatusCode,
                localVarHeaders,
                (TargetAttributes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TargetAttributes)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>AuthorizationPolicy</returns>
        
        public AuthorizationPolicy GetAuthorizationPolicy (string policyId)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = GetAuthorizationPolicyWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        public ApiResponse< AuthorizationPolicy > GetAuthorizationPolicyWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->GetAuthorizationPolicy");

            var localVarPath = "/api/v2/authorization/policies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicy> GetAuthorizationPolicyAsync (string policyId)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = await GetAuthorizationPolicyAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> GetAuthorizationPolicyAsyncWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->GetAuthorizationPolicy");
            

            var localVarPath = "/api/v2/authorization/policies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>PolicyAttributeSet</returns>
        
        public PolicyAttributeSet GetAuthorizationPolicyAttributes (string policyId)
        {
             ApiResponse<PolicyAttributeSet> localVarResponse = GetAuthorizationPolicyAttributesWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>ApiResponse of PolicyAttributeSet</returns>
        
        public ApiResponse< PolicyAttributeSet > GetAuthorizationPolicyAttributesWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->GetAuthorizationPolicyAttributes");

            var localVarPath = "/api/v2/authorization/policies/{policyId}/attributes";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicyAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicyAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyAttributeSet>(localVarStatusCode,
                localVarHeaders,
                (PolicyAttributeSet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyAttributeSet)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>Task of PolicyAttributeSet</returns>
        
        public async System.Threading.Tasks.Task<PolicyAttributeSet> GetAuthorizationPolicyAttributesAsync (string policyId)
        {
             ApiResponse<PolicyAttributeSet> localVarResponse = await GetAuthorizationPolicyAttributesAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of attributes used to evaluate an access control policy with the specified policy ID 
        /// 
        /// GetAuthorizationPolicyAttributes is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to retrieve attributes</param>
        /// <returns>Task of ApiResponse (PolicyAttributeSet)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<PolicyAttributeSet>> GetAuthorizationPolicyAttributesAsyncWithHttpInfo (string policyId)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->GetAuthorizationPolicyAttributes");
            

            var localVarPath = "/api/v2/authorization/policies/{policyId}/attributes";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicyAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationPolicyAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyAttributeSet>(localVarStatusCode,
                localVarHeaders,
                (PolicyAttributeSet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyAttributeSet)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of enabled products 
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        
        public OrganizationProductEntityListing GetAuthorizationProducts ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = GetAuthorizationProductsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of enabled products 
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        
        public ApiResponse< OrganizationProductEntityListing > GetAuthorizationProductsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/products";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationProductEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of enabled products 
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        
        public async System.Threading.Tasks.Task<OrganizationProductEntityListing> GetAuthorizationProductsAsync ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = await GetAuthorizationProductsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of enabled products 
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetAuthorizationProductsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/products";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationProducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationProductEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a single organization role. 
        /// Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        
        public DomainOrganizationRole GetAuthorizationRole (string roleId, bool? userCount = null, List<string> expand = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = GetAuthorizationRoleWithHttpInfo(roleId, userCount, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single organization role. 
        /// Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        
        public ApiResponse< DomainOrganizationRole > GetAuthorizationRoleWithHttpInfo (string roleId, bool? userCount = null, List<string> expand = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

            // Query params
            if (userCount != null) localVarQueryParams.Add(new Tuple<string, string>("userCount", this.Configuration.ApiClient.ParameterToString(userCount)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a single organization role. 
        /// Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        
        public async System.Threading.Tasks.Task<DomainOrganizationRole> GetAuthorizationRoleAsync (string roleId, bool? userCount = null, List<string> expand = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await GetAuthorizationRoleAsyncWithHttpInfo(roleId, userCount, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single organization role. 
        /// Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="userCount">Fetch the count of users who have this role granted in at least one division. Setting this value or defaulting to &#39;true&#39; can lead to slower load times or timeouts for role queries with large member counts. (optional, default to true)</param>
        /// <param name="expand">Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetAuthorizationRoleAsyncWithHttpInfo (string roleId, bool? userCount = null, List<string> expand = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRole");
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

            // Query params
            if (userCount != null) localVarQueryParams.Add(new Tuple<string, string>("userCount", this.Configuration.ApiClient.ParameterToString(userCount)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an org role to default role comparison 
        /// Compares any organization role to a default role id and show differences
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
        /// Get an org role to default role comparison 
        /// Compares any organization role to a default role id and show differences
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", this.Configuration.ApiClient.ParameterToString(leftRoleId));
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", this.Configuration.ApiClient.ParameterToString(rightRoleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an org role to default role comparison 
        /// Compares any organization role to a default role id and show differences
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
        /// Get an org role to default role comparison 
        /// Compares any organization role to a default role id and show differences
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", this.Configuration.ApiClient.ParameterToString(leftRoleId));
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", this.Configuration.ApiClient.ParameterToString(rightRoleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the subjects&#39; granted divisions in the specified role. 
        /// Includes the divisions for which the subject has a grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>SubjectDivisionGrantsEntityListing</returns>
        
        public SubjectDivisionGrantsEntityListing GetAuthorizationRoleSubjectgrants (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<SubjectDivisionGrantsEntityListing> localVarResponse = GetAuthorizationRoleSubjectgrantsWithHttpInfo(roleId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the subjects&#39; granted divisions in the specified role. 
        /// Includes the divisions for which the subject has a grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of SubjectDivisionGrantsEntityListing</returns>
        
        public ApiResponse< SubjectDivisionGrantsEntityListing > GetAuthorizationRoleSubjectgrantsWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRoleSubjectgrants");

            var localVarPath = "/api/v2/authorization/roles/{roleId}/subjectgrants";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleSubjectgrants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleSubjectgrants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SubjectDivisionGrantsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SubjectDivisionGrantsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubjectDivisionGrantsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the subjects&#39; granted divisions in the specified role. 
        /// Includes the divisions for which the subject has a grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of SubjectDivisionGrantsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SubjectDivisionGrantsEntityListing> GetAuthorizationRoleSubjectgrantsAsync (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<SubjectDivisionGrantsEntityListing> localVarResponse = await GetAuthorizationRoleSubjectgrantsAsyncWithHttpInfo(roleId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the subjects&#39; granted divisions in the specified role. 
        /// Includes the divisions for which the subject has a grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (SubjectDivisionGrantsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SubjectDivisionGrantsEntityListing>> GetAuthorizationRoleSubjectgrantsAsyncWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRoleSubjectgrants");
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}/subjectgrants";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleSubjectgrants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleSubjectgrants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SubjectDivisionGrantsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SubjectDivisionGrantsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubjectDivisionGrantsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of the users in a specified role. 
        /// Get an array of the UUIDs of the users in the specified role.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>UserReferenceEntityListing</returns>
        
        public UserReferenceEntityListing GetAuthorizationRoleUsers (string roleId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserReferenceEntityListing> localVarResponse = GetAuthorizationRoleUsersWithHttpInfo(roleId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of the users in a specified role. 
        /// Get an array of the UUIDs of the users in the specified role.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of UserReferenceEntityListing</returns>
        
        public ApiResponse< UserReferenceEntityListing > GetAuthorizationRoleUsersWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRoleUsers");

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserReferenceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserReferenceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReferenceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of the users in a specified role. 
        /// Get an array of the UUIDs of the users in the specified role.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of UserReferenceEntityListing</returns>
        
        public async System.Threading.Tasks.Task<UserReferenceEntityListing> GetAuthorizationRoleUsersAsync (string roleId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserReferenceEntityListing> localVarResponse = await GetAuthorizationRoleUsersAsyncWithHttpInfo(roleId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of the users in a specified role. 
        /// Get an array of the UUIDs of the users in the specified role.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (UserReferenceEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UserReferenceEntityListing>> GetAuthorizationRoleUsersAsyncWithHttpInfo (string roleId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetAuthorizationRoleUsers");
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoleUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserReferenceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserReferenceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReferenceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        
        public OrganizationRoleEntityListing GetAuthorizationRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = GetAuthorizationRolesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, permission, defaultRoleId, userCount, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        
        public ApiResponse< OrganizationRoleEntityListing > GetAuthorizationRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null)
        { 

            var localVarPath = "/api/v2/authorization/roles";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) permission.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (defaultRoleId != null) defaultRoleId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("defaultRoleId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (userCount != null) localVarQueryParams.Add(new Tuple<string, string>("userCount", this.Configuration.ApiClient.ParameterToString(userCount)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetAuthorizationRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await GetAuthorizationRolesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, permission, defaultRoleId, userCount, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="defaultRoleId"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetAuthorizationRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null)
        { 

            var localVarPath = "/api/v2/authorization/roles";
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) permission.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (defaultRoleId != null) defaultRoleId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("defaultRoleId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (userCount != null) localVarQueryParams.Add(new Tuple<string, string>("userCount", this.Configuration.ApiClient.ParameterToString(userCount)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get authorization role settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RoleSettings</returns>
        
        public RoleSettings GetAuthorizationRolesSettings ()
        {
             ApiResponse<RoleSettings> localVarResponse = GetAuthorizationRolesSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get authorization role settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RoleSettings</returns>
        
        public ApiResponse< RoleSettings > GetAuthorizationRolesSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/roles/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRolesSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRolesSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoleSettings>(localVarStatusCode,
                localVarHeaders,
                (RoleSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get authorization role settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RoleSettings</returns>
        
        public async System.Threading.Tasks.Task<RoleSettings> GetAuthorizationRolesSettingsAsync ()
        {
             ApiResponse<RoleSettings> localVarResponse = await GetAuthorizationRolesSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get authorization role settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RoleSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<RoleSettings>> GetAuthorizationRolesSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/roles/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRolesSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationRolesSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoleSettings>(localVarStatusCode,
                localVarHeaders,
                (RoleSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get authorization settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuthorizationSettings</returns>
        
        public AuthorizationSettings GetAuthorizationSettings ()
        {
             ApiResponse<AuthorizationSettings> localVarResponse = GetAuthorizationSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get authorization settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuthorizationSettings</returns>
        
        public ApiResponse< AuthorizationSettings > GetAuthorizationSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationSettings>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get authorization settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AuthorizationSettings</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationSettings> GetAuthorizationSettingsAsync ()
        {
             ApiResponse<AuthorizationSettings> localVarResponse = await GetAuthorizationSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get authorization settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AuthorizationSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationSettings>> GetAuthorizationSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationSettings>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>AuthzSubject</returns>
        
        public AuthzSubject GetAuthorizationSubject (string subjectId, bool? includeDuplicates = null)
        {
             ApiResponse<AuthzSubject> localVarResponse = GetAuthorizationSubjectWithHttpInfo(subjectId, includeDuplicates);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>ApiResponse of AuthzSubject</returns>
        
        public ApiResponse< AuthzSubject > GetAuthorizationSubjectWithHttpInfo (string subjectId, bool? includeDuplicates = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationSubject");

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (includeDuplicates != null) localVarQueryParams.Add(new Tuple<string, string>("includeDuplicates", this.Configuration.ApiClient.ParameterToString(includeDuplicates)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzSubject>(localVarStatusCode,
                localVarHeaders,
                (AuthzSubject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzSubject)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of AuthzSubject</returns>
        
        public async System.Threading.Tasks.Task<AuthzSubject> GetAuthorizationSubjectAsync (string subjectId, bool? includeDuplicates = null)
        {
             ApiResponse<AuthzSubject> localVarResponse = await GetAuthorizationSubjectAsyncWithHttpInfo(subjectId, includeDuplicates);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuthzSubject)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzSubject>> GetAuthorizationSubjectAsyncWithHttpInfo (string subjectId, bool? includeDuplicates = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetAuthorizationSubject");
            

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (includeDuplicates != null) localVarQueryParams.Add(new Tuple<string, string>("includeDuplicates", this.Configuration.ApiClient.ParameterToString(includeDuplicates)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzSubject>(localVarStatusCode,
                localVarHeaders,
                (AuthzSubject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzSubject)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>AuthzSubject</returns>
        
        public AuthzSubject GetAuthorizationSubjectsMe (bool? includeDuplicates = null)
        {
             ApiResponse<AuthzSubject> localVarResponse = GetAuthorizationSubjectsMeWithHttpInfo(includeDuplicates);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>ApiResponse of AuthzSubject</returns>
        
        public ApiResponse< AuthzSubject > GetAuthorizationSubjectsMeWithHttpInfo (bool? includeDuplicates = null)
        { 

            var localVarPath = "/api/v2/authorization/subjects/me";
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
            if (includeDuplicates != null) localVarQueryParams.Add(new Tuple<string, string>("includeDuplicates", this.Configuration.ApiClient.ParameterToString(includeDuplicates)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzSubject>(localVarStatusCode,
                localVarHeaders,
                (AuthzSubject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzSubject)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of AuthzSubject</returns>
        
        public async System.Threading.Tasks.Task<AuthzSubject> GetAuthorizationSubjectsMeAsync (bool? includeDuplicates = null)
        {
             ApiResponse<AuthzSubject> localVarResponse = await GetAuthorizationSubjectsMeAsyncWithHttpInfo(includeDuplicates);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a listing of roles and permissions for the currently authenticated user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeDuplicates">Include multiple entries with the same role and division but different subjects (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuthzSubject)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzSubject>> GetAuthorizationSubjectsMeAsyncWithHttpInfo (bool? includeDuplicates = null)
        { 

            var localVarPath = "/api/v2/authorization/subjects/me";
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
            if (includeDuplicates != null) localVarQueryParams.Add(new Tuple<string, string>("includeDuplicates", this.Configuration.ApiClient.ParameterToString(includeDuplicates)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzSubject>(localVarStatusCode,
                localVarHeaders,
                (AuthzSubject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzSubject)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the count of roles granted to a list of subjects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        
        public Dictionary<string, Object> GetAuthorizationSubjectsRolecounts (List<string> id = null)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = GetAuthorizationSubjectsRolecountsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the count of roles granted to a list of subjects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        
        public ApiResponse< Dictionary<string, Object> > GetAuthorizationSubjectsRolecountsWithHttpInfo (List<string> id = null)
        { 

            var localVarPath = "/api/v2/authorization/subjects/rolecounts";
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
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsRolecounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsRolecounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the count of roles granted to a list of subjects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        
        public async System.Threading.Tasks.Task<Dictionary<string, Object>> GetAuthorizationSubjectsRolecountsAsync (List<string> id = null)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = await GetAuthorizationSubjectsRolecountsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the count of roles granted to a list of subjects 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id (optional)</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetAuthorizationSubjectsRolecountsAsyncWithHttpInfo (List<string> id = null)
        { 

            var localVarPath = "/api/v2/authorization/subjects/rolecounts";
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
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsRolecounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationSubjectsRolecounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>UserAuthorization</returns>
        
        public UserAuthorization GetUserRoles (string subjectId)
        {
             ApiResponse<UserAuthorization> localVarResponse = GetUserRolesWithHttpInfo(subjectId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        
        public ApiResponse< UserAuthorization > GetUserRolesWithHttpInfo (string subjectId)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetUserRoles");

            var localVarPath = "/api/v2/users/{subjectId}/roles";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        
        public async System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string subjectId)
        {
             ApiResponse<UserAuthorization> localVarResponse = await GetUserRolesAsyncWithHttpInfo(subjectId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string subjectId)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->GetUserRoles");
            

            var localVarPath = "/api/v2/users/{subjectId}/roles";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch Organization Role for needsUpdate Field 
        /// Patch Organization Role for needsUpdate Field
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
        /// Patch Organization Role for needsUpdate Field 
        /// Patch Organization Role for needsUpdate Field
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch Organization Role for needsUpdate Field 
        /// Patch Organization Role for needsUpdate Field
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
        /// Patch Organization Role for needsUpdate Field 
        /// Patch Organization Role for needsUpdate Field
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Change authorization settings 
        /// Change authorization settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>AuthorizationSettings</returns>
        
        public AuthorizationSettings PatchAuthorizationSettings (AuthorizationSettings body)
        {
             ApiResponse<AuthorizationSettings> localVarResponse = PatchAuthorizationSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change authorization settings 
        /// Change authorization settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>ApiResponse of AuthorizationSettings</returns>
        
        public ApiResponse< AuthorizationSettings > PatchAuthorizationSettingsWithHttpInfo (AuthorizationSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PatchAuthorizationSettings");

            var localVarPath = "/api/v2/authorization/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationSettings>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Change authorization settings 
        /// Change authorization settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>Task of AuthorizationSettings</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationSettings> PatchAuthorizationSettingsAsync (AuthorizationSettings body)
        {
             ApiResponse<AuthorizationSettings> localVarResponse = await PatchAuthorizationSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change authorization settings 
        /// Change authorization settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Settings</param>
        /// <returns>Task of ApiResponse (AuthorizationSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationSettings>> PatchAuthorizationSettingsAsyncWithHttpInfo (AuthorizationSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PatchAuthorizationSettings");
            

            var localVarPath = "/api/v2/authorization/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAuthorizationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationSettings>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Assign a list of objects to a division 
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns></returns>
        
        public void PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body)
        {
             PostAuthorizationDivisionObjectWithHttpInfo(divisionId, objectType, body);
        }

        /// <summary>
        /// Assign a list of objects to a division 
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostAuthorizationDivisionObjectWithHttpInfo (string divisionId, string objectType, List<string> body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PostAuthorizationDivisionObject");
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling AuthorizationApi->PostAuthorizationDivisionObject");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationDivisionObject");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/objects/{objectType}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (objectType != null) localVarPathParams.Add("objectType", this.Configuration.ApiClient.ParameterToString(objectType));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Assign a list of objects to a division 
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostAuthorizationDivisionObjectAsync (string divisionId, string objectType, List<string> body)
        {
             await PostAuthorizationDivisionObjectAsyncWithHttpInfo(divisionId, objectType, body);

        }

        /// <summary>
        /// Assign a list of objects to a division 
        /// Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationDivisionObjectAsyncWithHttpInfo (string divisionId, string objectType, List<string> body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PostAuthorizationDivisionObject");
            
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling AuthorizationApi->PostAuthorizationDivisionObject");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationDivisionObject");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/objects/{objectType}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (objectType != null) localVarPathParams.Add("objectType", this.Configuration.ApiClient.ParameterToString(objectType));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Recreate a previously deleted division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>AuthzDivision</returns>
        
        public AuthzDivision PostAuthorizationDivisionRestore (string divisionId, AuthzDivision body)
        {
             ApiResponse<AuthzDivision> localVarResponse = PostAuthorizationDivisionRestoreWithHttpInfo(divisionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recreate a previously deleted division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        public ApiResponse< AuthzDivision > PostAuthorizationDivisionRestoreWithHttpInfo (string divisionId, AuthzDivision body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PostAuthorizationDivisionRestore");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationDivisionRestore");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/restore";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionRestore: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionRestore: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Recreate a previously deleted division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>Task of AuthzDivision</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivision> PostAuthorizationDivisionRestoreAsync (string divisionId, AuthzDivision body)
        {
             ApiResponse<AuthzDivision> localVarResponse = await PostAuthorizationDivisionRestoreAsyncWithHttpInfo(divisionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recreate a previously deleted division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Recreated division data</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> PostAuthorizationDivisionRestoreAsyncWithHttpInfo (string divisionId, AuthzDivision body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PostAuthorizationDivisionRestore");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationDivisionRestore");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/restore";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionRestore: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionRestore: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>AuthzDivision</returns>
        
        public AuthzDivision PostAuthorizationDivisions (AuthzDivision body)
        {
             ApiResponse<AuthzDivision> localVarResponse = PostAuthorizationDivisionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        public ApiResponse< AuthzDivision > PostAuthorizationDivisionsWithHttpInfo (AuthzDivision body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationDivisions");

            var localVarPath = "/api/v2/authorization/divisions";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>Task of AuthzDivision</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivision> PostAuthorizationDivisionsAsync (AuthzDivision body)
        {
             ApiResponse<AuthzDivision> localVarResponse = await PostAuthorizationDivisionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Division</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> PostAuthorizationDivisionsAsyncWithHttpInfo (AuthzDivision body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationDivisions");
            

            var localVarPath = "/api/v2/authorization/divisions";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add an access control policy for a specified resource target and subject 
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>AuthorizationPolicy</returns>
        
        public AuthorizationPolicy PostAuthorizationPoliciesTarget (string targetName, AuthorizationPolicy body)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = PostAuthorizationPoliciesTargetWithHttpInfo(targetName, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add an access control policy for a specified resource target and subject 
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        public ApiResponse< AuthorizationPolicy > PostAuthorizationPoliciesTargetWithHttpInfo (string targetName, AuthorizationPolicy body)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->PostAuthorizationPoliciesTarget");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationPoliciesTarget");

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add an access control policy for a specified resource target and subject 
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicy> PostAuthorizationPoliciesTargetAsync (string targetName, AuthorizationPolicy body)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = await PostAuthorizationPoliciesTargetAsyncWithHttpInfo(targetName, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add an access control policy for a specified resource target and subject 
        /// 
        /// PostAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> PostAuthorizationPoliciesTargetAsyncWithHttpInfo (string targetName, AuthorizationPolicy body)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->PostAuthorizationPoliciesTarget");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationPoliciesTarget");
            

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target 
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ValidationErrorListing</returns>
        
        public ValidationErrorListing PostAuthorizationPoliciesTargetValidate (string targetName, AuthorizationPolicy body)
        {
             ApiResponse<ValidationErrorListing> localVarResponse = PostAuthorizationPoliciesTargetValidateWithHttpInfo(targetName, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target 
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of ValidationErrorListing</returns>
        
        public ApiResponse< ValidationErrorListing > PostAuthorizationPoliciesTargetValidateWithHttpInfo (string targetName, AuthorizationPolicy body)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->PostAuthorizationPoliciesTargetValidate");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationPoliciesTargetValidate");

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}/validate";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTargetValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTargetValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidationErrorListing>(localVarStatusCode,
                localVarHeaders,
                (ValidationErrorListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidationErrorListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target 
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ValidationErrorListing</returns>
        
        public async System.Threading.Tasks.Task<ValidationErrorListing> PostAuthorizationPoliciesTargetValidateAsync (string targetName, AuthorizationPolicy body)
        {
             ApiResponse<ValidationErrorListing> localVarResponse = await PostAuthorizationPoliciesTargetValidateAsyncWithHttpInfo(targetName, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate the conditions and attributes of an access control policy for a specified resource target 
        /// 
        /// PostAuthorizationPoliciesTargetValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (ValidationErrorListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ValidationErrorListing>> PostAuthorizationPoliciesTargetValidateAsyncWithHttpInfo (string targetName, AuthorizationPolicy body)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->PostAuthorizationPoliciesTargetValidate");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationPoliciesTargetValidate");
            

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}/validate";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTargetValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPoliciesTargetValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidationErrorListing>(localVarStatusCode,
                localVarHeaders,
                (ValidationErrorListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidationErrorListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values 
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>PolicyTestResult</returns>
        
        public PolicyTestResult PostAuthorizationPolicySimulate (string policyId, PolicyTestPayload body)
        {
             ApiResponse<PolicyTestResult> localVarResponse = PostAuthorizationPolicySimulateWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values 
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>ApiResponse of PolicyTestResult</returns>
        
        public ApiResponse< PolicyTestResult > PostAuthorizationPolicySimulateWithHttpInfo (string policyId, PolicyTestPayload body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->PostAuthorizationPolicySimulate");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationPolicySimulate");

            var localVarPath = "/api/v2/authorization/policies/{policyId}/simulate";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPolicySimulate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPolicySimulate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyTestResult>(localVarStatusCode,
                localVarHeaders,
                (PolicyTestResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyTestResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values 
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>Task of PolicyTestResult</returns>
        
        public async System.Threading.Tasks.Task<PolicyTestResult> PostAuthorizationPolicySimulateAsync (string policyId, PolicyTestPayload body)
        {
             ApiResponse<PolicyTestResult> localVarResponse = await PostAuthorizationPolicySimulateAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simulate a request and evaluate the specified policy ID against the provided values 
        /// 
        /// PostAuthorizationPolicySimulate is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to test the simulated data against</param>
        /// <param name="body">A map of attribute names to type and simulated data value</param>
        /// <returns>Task of ApiResponse (PolicyTestResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<PolicyTestResult>> PostAuthorizationPolicySimulateAsyncWithHttpInfo (string policyId, PolicyTestPayload body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->PostAuthorizationPolicySimulate");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationPolicySimulate");
            

            var localVarPath = "/api/v2/authorization/policies/{policyId}/simulate";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPolicySimulate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationPolicySimulate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyTestResult>(localVarStatusCode,
                localVarHeaders,
                (PolicyTestResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyTestResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        public void PostAuthorizationRole (string roleId, SubjectDivisions body, string subjectType = null)
        {
             PostAuthorizationRoleWithHttpInfo(roleId, body, subjectType);
        }

        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostAuthorizationRoleWithHttpInfo (string roleId, SubjectDivisions body, string subjectType = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PostAuthorizationRole");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostAuthorizationRoleAsync (string roleId, SubjectDivisions body, string subjectType = null)
        {
             await PostAuthorizationRoleAsyncWithHttpInfo(roleId, body, subjectType);

        }

        /// <summary>
        /// Bulk-grant subjects and divisions with an organization role. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Subjects and Divisions</param>
        /// <param name="subjectType">what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationRoleAsyncWithHttpInfo (string roleId, SubjectDivisions body, string subjectType = null)
        { 
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PostAuthorizationRole");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationRole");
            

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an unsaved org role to default role comparison 
        /// Allows users to compare their existing roles in an unsaved state to its default role
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
        /// Get an unsaved org role to default role comparison 
        /// Allows users to compare their existing roles in an unsaved state to its default role
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", this.Configuration.ApiClient.ParameterToString(leftRoleId));
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", this.Configuration.ApiClient.ParameterToString(rightRoleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an unsaved org role to default role comparison 
        /// Allows users to compare their existing roles in an unsaved state to its default role
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
        /// Get an unsaved org role to default role comparison 
        /// Allows users to compare their existing roles in an unsaved state to its default role
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", this.Configuration.ApiClient.ParameterToString(leftRoleId));
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", this.Configuration.ApiClient.ParameterToString(rightRoleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarHeaders,
                (DomainOrgRoleDifference) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an organization role. 
        /// 
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
        /// 
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an organization role. 
        /// 
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
        /// 
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Restores all default roles 
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
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
        /// Restores all default roles 
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        
        public ApiResponse< OrganizationRoleEntityListing > PostAuthorizationRolesDefaultWithHttpInfo (bool? force = null)
        { 

            var localVarPath = "/api/v2/authorization/roles/default";
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
            if (force != null) localVarQueryParams.Add(new Tuple<string, string>("force", this.Configuration.ApiClient.ParameterToString(force)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Restores all default roles 
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
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
        /// Restores all default roles 
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PostAuthorizationRolesDefaultAsyncWithHttpInfo (bool? force = null)
        { 

            var localVarPath = "/api/v2/authorization/roles/default";
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
            if (force != null) localVarQueryParams.Add(new Tuple<string, string>("force", this.Configuration.ApiClient.ParameterToString(force)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk-grant roles and divisions to a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        public void PostAuthorizationSubjectBulkadd (string subjectId, RoleDivisionGrants body, string subjectType = null)
        {
             PostAuthorizationSubjectBulkaddWithHttpInfo(subjectId, body, subjectType);
        }

        /// <summary>
        /// Bulk-grant roles and divisions to a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostAuthorizationSubjectBulkaddWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectBulkadd");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationSubjectBulkadd");

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/bulkadd";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkadd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkadd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk-grant roles and divisions to a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostAuthorizationSubjectBulkaddAsync (string subjectId, RoleDivisionGrants body, string subjectType = null)
        {
             await PostAuthorizationSubjectBulkaddAsyncWithHttpInfo(subjectId, body, subjectType);

        }

        /// <summary>
        /// Bulk-grant roles and divisions to a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectBulkaddAsyncWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectBulkadd");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationSubjectBulkadd");
            

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/bulkadd";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkadd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkadd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk-remove grants from a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns></returns>
        
        public void PostAuthorizationSubjectBulkremove (string subjectId, RoleDivisionGrants body)
        {
             PostAuthorizationSubjectBulkremoveWithHttpInfo(subjectId, body);
        }

        /// <summary>
        /// Bulk-remove grants from a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostAuthorizationSubjectBulkremoveWithHttpInfo (string subjectId, RoleDivisionGrants body)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectBulkremove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationSubjectBulkremove");

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/bulkremove";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkremove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkremove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk-remove grants from a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostAuthorizationSubjectBulkremoveAsync (string subjectId, RoleDivisionGrants body)
        {
             await PostAuthorizationSubjectBulkremoveAsyncWithHttpInfo(subjectId, body);

        }

        /// <summary>
        /// Bulk-remove grants from a subject. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectBulkremoveAsyncWithHttpInfo (string subjectId, RoleDivisionGrants body)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectBulkremove");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationSubjectBulkremove");
            

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/bulkremove";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkremove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkremove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request. 
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        public void PostAuthorizationSubjectBulkreplace (string subjectId, RoleDivisionGrants body, string subjectType = null)
        {
             PostAuthorizationSubjectBulkreplaceWithHttpInfo(subjectId, body, subjectType);
        }

        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request. 
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostAuthorizationSubjectBulkreplaceWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectBulkreplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationSubjectBulkreplace");

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/bulkreplace";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkreplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkreplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request. 
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostAuthorizationSubjectBulkreplaceAsync (string subjectId, RoleDivisionGrants body, string subjectType = null)
        {
             await PostAuthorizationSubjectBulkreplaceAsyncWithHttpInfo(subjectId, body, subjectType);

        }

        /// <summary>
        /// Replace subject&#39;s roles and divisions with the exact list supplied in the request. 
        /// This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="body">Pairs of role and division IDs</param>
        /// <param name="subjectType">what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectBulkreplaceAsyncWithHttpInfo (string subjectId, RoleDivisionGrants body, string subjectType = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectBulkreplace");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostAuthorizationSubjectBulkreplace");
            

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/bulkreplace";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkreplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectBulkreplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Make a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns></returns>
        
        public void PostAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId, string subjectType = null)
        {
             PostAuthorizationSubjectDivisionRoleWithHttpInfo(subjectId, divisionId, roleId, subjectType);
        }

        /// <summary>
        /// Make a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostAuthorizationSubjectDivisionRoleWithHttpInfo (string subjectId, string divisionId, string roleId, string subjectType = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectDivisionRole");
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PostAuthorizationSubjectDivisionRole");
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PostAuthorizationSubjectDivisionRole");

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectDivisionRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectDivisionRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Make a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostAuthorizationSubjectDivisionRoleAsync (string subjectId, string divisionId, string roleId, string subjectType = null)
        {
             await PostAuthorizationSubjectDivisionRoleAsyncWithHttpInfo(subjectId, divisionId, roleId, subjectType);

        }

        /// <summary>
        /// Make a grant of a role in a division 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Subject ID (user or group)</param>
        /// <param name="divisionId">the id of the division to which to make the grant</param>
        /// <param name="roleId">the id of the role to grant</param>
        /// <param name="subjectType">what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional, default to "PC_USER")</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAuthorizationSubjectDivisionRoleAsyncWithHttpInfo (string subjectId, string divisionId, string roleId, string subjectType = null)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PostAuthorizationSubjectDivisionRole");
            
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PostAuthorizationSubjectDivisionRole");
            
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PostAuthorizationSubjectDivisionRole");
            

            var localVarPath = "/api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId}";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

            // Query params
            if (subjectType != null) localVarQueryParams.Add(new Tuple<string, string>("subjectType", this.Configuration.ApiClient.ParameterToString(subjectType)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectDivisionRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationSubjectDivisionRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>AuthzDivision</returns>
        
        public AuthzDivision PutAuthorizationDivision (string divisionId, AuthzDivision body)
        {
             ApiResponse<AuthzDivision> localVarResponse = PutAuthorizationDivisionWithHttpInfo(divisionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>ApiResponse of AuthzDivision</returns>
        
        public ApiResponse< AuthzDivision > PutAuthorizationDivisionWithHttpInfo (string divisionId, AuthzDivision body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PutAuthorizationDivision");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationDivision");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}";
            var localVarHttpMethod = "Put";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationDivision: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationDivision: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>Task of AuthzDivision</returns>
        
        public async System.Threading.Tasks.Task<AuthzDivision> PutAuthorizationDivisionAsync (string divisionId, AuthzDivision body)
        {
             ApiResponse<AuthzDivision> localVarResponse = await PutAuthorizationDivisionAsyncWithHttpInfo(divisionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a division. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="body">Updated division data</param>
        /// <returns>Task of ApiResponse (AuthzDivision)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthzDivision>> PutAuthorizationDivisionAsyncWithHttpInfo (string divisionId, AuthzDivision body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling AuthorizationApi->PutAuthorizationDivision");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationDivision");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}";
            var localVarHttpMethod = "Put";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationDivision: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationDivision: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzDivision>(localVarStatusCode,
                localVarHeaders,
                (AuthzDivision) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzDivision)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy 
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>AuthorizationPolicy</returns>
        
        public AuthorizationPolicy PutAuthorizationPoliciesTarget (string targetName, AuthorizationPolicy body)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = PutAuthorizationPoliciesTargetWithHttpInfo(targetName, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy 
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        public ApiResponse< AuthorizationPolicy > PutAuthorizationPoliciesTargetWithHttpInfo (string targetName, AuthorizationPolicy body)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->PutAuthorizationPoliciesTarget");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationPoliciesTarget");

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}";
            var localVarHttpMethod = "Put";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPoliciesTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPoliciesTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy 
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicy> PutAuthorizationPoliciesTargetAsync (string targetName, AuthorizationPolicy body)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = await PutAuthorizationPoliciesTargetAsyncWithHttpInfo(targetName, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add an access control policy for a specified resource target and subject, overwriting any existing policy 
        /// 
        /// PutAuthorizationPoliciesTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetName">The domain:entity:action target to which the policy will be applied</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> PutAuthorizationPoliciesTargetAsyncWithHttpInfo (string targetName, AuthorizationPolicy body)
        { 
            // verify the required parameter 'targetName' is set
            if (targetName == null)
                throw new ApiException(400, "Missing required parameter 'targetName' when calling AuthorizationApi->PutAuthorizationPoliciesTarget");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationPoliciesTarget");
            

            var localVarPath = "/api/v2/authorization/policies/targets/{targetName}";
            var localVarHttpMethod = "Put";
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
            if (targetName != null) localVarPathParams.Add("targetName", this.Configuration.ApiClient.ParameterToString(targetName));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPoliciesTarget: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPoliciesTarget: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an access control policy with a given ID 
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>AuthorizationPolicy</returns>
        
        public AuthorizationPolicy PutAuthorizationPolicy (string policyId, AuthorizationPolicy body)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = PutAuthorizationPolicyWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an access control policy with a given ID 
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>ApiResponse of AuthorizationPolicy</returns>
        
        public ApiResponse< AuthorizationPolicy > PutAuthorizationPolicyWithHttpInfo (string policyId, AuthorizationPolicy body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->PutAuthorizationPolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationPolicy");

            var localVarPath = "/api/v2/authorization/policies/{policyId}";
            var localVarHttpMethod = "Put";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an access control policy with a given ID 
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of AuthorizationPolicy</returns>
        
        public async System.Threading.Tasks.Task<AuthorizationPolicy> PutAuthorizationPolicyAsync (string policyId, AuthorizationPolicy body)
        {
             ApiResponse<AuthorizationPolicy> localVarResponse = await PutAuthorizationPolicyAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an access control policy with a given ID 
        /// 
        /// PutAuthorizationPolicy is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">The ID of the policy to update</param>
        /// <param name="body">Access control policy</param>
        /// <returns>Task of ApiResponse (AuthorizationPolicy)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AuthorizationPolicy>> PutAuthorizationPolicyAsyncWithHttpInfo (string policyId, AuthorizationPolicy body)
        { 
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling AuthorizationApi->PutAuthorizationPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationPolicy");
            

            var localVarPath = "/api/v2/authorization/policies/{policyId}";
            var localVarHttpMethod = "Put";
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
            if (policyId != null) localVarPathParams.Add("policyId", this.Configuration.ApiClient.ParameterToString(policyId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthorizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (AuthorizationPolicy) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorizationPolicy)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an organization role. 
        /// Update
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
        /// Update an organization role. 
        /// Update
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
            var localVarHttpMethod = "Put";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an organization role. 
        /// Update
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
        /// Update an organization role. 
        /// Update
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
            var localVarHttpMethod = "Put";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarHeaders,
                (DomainOrganizationRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Sets the users for the role 
        /// 
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
        /// 
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
            var localVarHttpMethod = "Put";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Sets the users for the role 
        /// 
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
        /// 
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
            var localVarHttpMethod = "Put";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Removes the users from the role 
        /// 
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
        /// 
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
            var localVarHttpMethod = "Put";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Removes the users from the role 
        /// 
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
        /// 
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
            var localVarHttpMethod = "Put";
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
            if (roleId != null) localVarPathParams.Add("roleId", this.Configuration.ApiClient.ParameterToString(roleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRoleUsersRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Restore specified default roles 
        /// 
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
        /// 
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
            var localVarHttpMethod = "Put";
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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Restore specified default roles 
        /// 
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
        /// 
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
            var localVarHttpMethod = "Put";
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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationRoleEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Change authorization role settings 
        /// Change role settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>RoleSettings</returns>
        
        public RoleSettings PutAuthorizationRolesSettings (RoleSettings body)
        {
             ApiResponse<RoleSettings> localVarResponse = PutAuthorizationRolesSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change authorization role settings 
        /// Change role settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>ApiResponse of RoleSettings</returns>
        
        public ApiResponse< RoleSettings > PutAuthorizationRolesSettingsWithHttpInfo (RoleSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRolesSettings");

            var localVarPath = "/api/v2/authorization/roles/settings";
            var localVarHttpMethod = "Put";
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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoleSettings>(localVarStatusCode,
                localVarHeaders,
                (RoleSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Change authorization role settings 
        /// Change role settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>Task of RoleSettings</returns>
        
        public async System.Threading.Tasks.Task<RoleSettings> PutAuthorizationRolesSettingsAsync (RoleSettings body)
        {
             ApiResponse<RoleSettings> localVarResponse = await PutAuthorizationRolesSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change authorization role settings 
        /// Change role settings
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Authorization Role Settings</param>
        /// <returns>Task of ApiResponse (RoleSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<RoleSettings>> PutAuthorizationRolesSettingsAsyncWithHttpInfo (RoleSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutAuthorizationRolesSettings");
            

            var localVarPath = "/api/v2/authorization/roles/settings";
            var localVarHttpMethod = "Put";
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
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAuthorizationRolesSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoleSettings>(localVarStatusCode,
                localVarHeaders,
                (RoleSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Sets the user&#39;s roles 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>UserAuthorization</returns>
        
        public UserAuthorization PutUserRoles (string subjectId, List<string> body)
        {
             ApiResponse<UserAuthorization> localVarResponse = PutUserRolesWithHttpInfo(subjectId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        
        public ApiResponse< UserAuthorization > PutUserRolesWithHttpInfo (string subjectId, List<string> body)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PutUserRoles");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutUserRoles");

            var localVarPath = "/api/v2/users/{subjectId}/roles";
            var localVarHttpMethod = "Put";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Sets the user&#39;s roles 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of UserAuthorization</returns>
        
        public async System.Threading.Tasks.Task<UserAuthorization> PutUserRolesAsync (string subjectId, List<string> body)
        {
             ApiResponse<UserAuthorization> localVarResponse = await PutUserRolesAsyncWithHttpInfo(subjectId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> PutUserRolesAsyncWithHttpInfo (string subjectId, List<string> body)
        { 
            // verify the required parameter 'subjectId' is set
            if (subjectId == null)
                throw new ApiException(400, "Missing required parameter 'subjectId' when calling AuthorizationApi->PutUserRoles");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutUserRoles");
            

            var localVarPath = "/api/v2/users/{subjectId}/roles";
            var localVarHttpMethod = "Put";
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
            if (subjectId != null) localVarPathParams.Add("subjectId", this.Configuration.ApiClient.ParameterToString(subjectId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarHeaders,
                (UserAuthorization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
